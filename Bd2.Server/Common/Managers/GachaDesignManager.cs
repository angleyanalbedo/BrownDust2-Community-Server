using System;
using System.Collections.Generic;
using System.Linq;
using Bd2.Server.Common.DB;

namespace Bd2.Server.Common.Managers;

/// <summary>
/// Reads the current GachaGroupTable/GachaTable wire layout.
/// The generated server Proto classes are from an older schema; the client
/// dump shows that the current schema inserted fields before the gacha fields.
/// </summary>
public static class GachaDesignManager
{
    public sealed record GachaGroup(
        int RowId,
        int Id,
        int NameTextId,
        int Type,
        int OneTimeGachaId,
        int TenTimeGachaId,
        int PickUpItemId,
        int ScheduleType,
        int SortId,
        string BannerImage);

    public static List<GachaGroup> LoadGroups()
    {
        return DesignDbHelper.LoadRawFromCommon("GachaGroupTable")
            .Select(row => ParseGroup(row.Id, row.ProtoBuf))
            .Where(x => x.RowId > 0)
            .ToList();
    }

    public static HashSet<int> LoadGachaIds()
    {
        // Current GachaTable.Id is field 9. SQLite row ids are not the
        // business ids referenced by GachaGroupTable.OneTime/TenTimeGachaId.
        return DesignDbHelper.LoadRawFromCommon("GachaTable")
            .Select(row => ReadIntField(row.ProtoBuf, 9))
            .Where(x => x > 0)
            .ToHashSet();
    }

    private static GachaGroup ParseGroup(long rowId, byte[] data)
    {
        var ints = ReadIntFields(data);
        var strings = ReadStringFields(data);
        return new GachaGroup(
            checked((int)rowId),
            GetInt(ints, 18),
            GetInt(ints, 14),
            GetInt(ints, 17),
            GetInt(ints, 24),
            GetInt(ints, 33),
            GetInt(ints, 26),
            GetInt(ints, 28),
            GetInt(ints, 32),
            GetString(strings, 12));
    }

    private static Dictionary<int, int> ReadIntFields(byte[] data)
    {
        var result = new Dictionary<int, int>();
        ReadFields(data, (field, wire, value, text) =>
        {
            if (wire == 0 && value <= int.MaxValue)
                result[field] = (int)value;
        });
        return result;
    }

    private static Dictionary<int, string> ReadStringFields(byte[] data)
    {
        var result = new Dictionary<int, string>();
        ReadFields(data, (field, wire, value, text) =>
        {
            if (wire == 2 && text != null)
                result[field] = text;
        });
        return result;
    }

    private static int ReadIntField(byte[] data, int field)
    {
        var values = ReadIntFields(data);
        return GetInt(values, field);
    }

    private static int GetInt(Dictionary<int, int> values, int field) =>
        values.TryGetValue(field, out var value) ? value : 0;

    private static string GetString(Dictionary<int, string> values, int field) =>
        values.TryGetValue(field, out var value) ? value : "";

    private static void ReadFields(byte[] data, Action<int, int, ulong, string?> callback)
    {
        for (var offset = 0; offset < data.Length;)
        {
            var tag = ReadVarint(data, ref offset);
            var field = checked((int)(tag >> 3));
            var wire = (int)(tag & 7);
            switch (wire)
            {
                case 0:
                    callback(field, wire, ReadVarint(data, ref offset), null);
                    break;
                case 1:
                    EnsureAvailable(data, offset, 8);
                    offset += 8;
                    callback(field, wire, 0, null);
                    break;
                case 2:
                    var length = checked((int)ReadVarint(data, ref offset));
                    EnsureAvailable(data, offset, length);
                    callback(field, wire, 0, System.Text.Encoding.UTF8.GetString(data, offset, length));
                    offset += length;
                    break;
                case 5:
                    EnsureAvailable(data, offset, 4);
                    offset += 4;
                    callback(field, wire, 0, null);
                    break;
                default:
                    throw new InvalidOperationException($"Unsupported protobuf wire type {wire} for field {field}.");
            }
        }
    }

    private static ulong ReadVarint(byte[] data, ref int offset)
    {
        ulong value = 0;
        var shift = 0;
        while (offset < data.Length && shift < 64)
        {
            var current = data[offset++];
            value |= (ulong)(current & 0x7F) << shift;
            if ((current & 0x80) == 0)
                return value;
            shift += 7;
        }
        throw new InvalidOperationException("Invalid protobuf varint.");
    }

    private static void EnsureAvailable(byte[] data, int offset, int length)
    {
        if (length < 0 || offset > data.Length - length)
            throw new InvalidOperationException("Invalid protobuf field length.");
    }
}
