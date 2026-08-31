using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using Google.Protobuf;

namespace Bd2.Server.Common.DB;

/// <summary>
/// 从解密后的 BD2 设计数据库（SQLite）中读取游戏设计表数据。
///
/// 数据库文件命名规则：
///   common_v1.db         — 全局设计数据（551张表，对应 common_v1 = SHA1("common_v1")）
///   pack{id}_v1.db       — 章节设计数据（对应 SHA1("pack{id}_v1")）
///   FieldObjectSceneData_v1.db — 场景物体数据
///
/// 每张表的结构：
///   索引列（id, uniqueCharId 等 INTEGER）+ ProtoBuf BLOB 列
///   ProtoBuf 列存储 Google Protobuf 序列化的消息二进制数据，
///   使用对应的 Proto 类 Parser.ParseFrom() 解码。
///
/// 文件来源：
///   使用 tools/bd2_db_decrypt.py 解密游戏客户端 DB，
///   再用 tools/setup_design_db.py 复制到 DesignDb/ 目录并重命名为友好名称。
///   csproj 中配置 CopyToOutputDirectory 将 DesignDb/ 复制到运行时 design_dbs/。
/// </summary>
public static class DesignDbHelper
{
    public sealed record RawTableRow(long Id, byte[] ProtoBuf);

    public static List<RawTableRow> LoadRawFromCommon(string tableName)
    {
        var results = new List<RawTableRow>();
        using var connection = new SQLiteConnection($"Data Source={GetCommonDbPath()};Version=3;Read Only=True;");
        connection.Open();
        using var command = new SQLiteCommand($"SELECT id, ProtoBuf FROM [{tableName}]", connection);
        using var reader = command.ExecuteReader();
        while (reader.Read()) results.Add(new RawTableRow(Convert.ToInt64(reader["id"]), (byte[])reader["ProtoBuf"]));
        return results;
    }

    /// <summary>
    /// 设计数据库文件所在目录（相对于工作目录）。
    /// csproj 中通过 Content Link 将 DesignDb/ 映射到输出目录的 design_dbs/。
    /// </summary>
    public static string DesignDbDirectory { get; set; } = "design_dbs";

    /// <summary>
    /// 从 common_v1 数据库读取指定表的所有行，解码 ProtoBuf 列为 IMessage 对象。
    /// 适用于 CharTable、EquipmentTable 等全局设计表。
    /// </summary>
    public static List<T> LoadFromCommon<T>(string tableName, MessageParser<T> parser) where T : IMessage<T>
    {
        return LoadFromDb(GetCommonDbPath(), tableName, parser);
    }

    /// <summary>
    /// 从指定 pack 的数据库读取指定表的所有行。
    /// 适用于 BattleDeckTable、FieldMonsterTable 等章节级设计表。
    /// </summary>
    public static List<T> LoadFromPack<T>(int packId, string tableName, MessageParser<T> parser) where T : IMessage<T>
    {
        return LoadFromDb(GetPackDbPath(packId), tableName, parser);
    }

    /// <summary>
    /// 从指定 SQLite 数据库文件读取指定表的所有行，解码 ProtoBuf BLOB 列。
    /// </summary>
    public static List<T> LoadFromDb<T>(string dbPath, string tableName, MessageParser<T> parser) where T : IMessage<T>
    {
        var results = new List<T>();
        var connectionString = $"Data Source={dbPath};Version=3;Read Only=True;";

        using var connection = new SQLiteConnection(connectionString);
        connection.Open();

        using var command = new SQLiteCommand($"SELECT ProtoBuf FROM [{tableName}]", connection);
        using var reader = command.ExecuteReader();

        while (reader.Read())
        {
            var protoBytes = (byte[])reader["ProtoBuf"];
            results.Add(parser.ParseFrom(protoBytes));
        }

        return results;
    }

    public static string GetCommonDbPath() => Path.Combine(DesignDbDirectory, "common_v1.db");

    public static string GetPackDbPath(int packId) => Path.Combine(DesignDbDirectory, $"pack{packId}_v1.db");

    /// <summary>
    /// 验证设计数据库目录是否存在，可在服务启动时调用以提前发现问题。
    /// </summary>
    public static void ValidateDesignDbDirectory()
    {
        if (!Directory.Exists(DesignDbDirectory))
        {
            throw new DirectoryNotFoundException(
                $"Design database directory not found: '{Path.GetFullPath(DesignDbDirectory)}'. " +
                $"Run 'python tools/setup_design_db.py' to populate the DesignDb/ folder, " +
                $"then rebuild the project.");
        }

        var commonDb = GetCommonDbPath();
        if (!File.Exists(commonDb))
        {
            throw new FileNotFoundException(
                $"Common design database not found: '{Path.GetFullPath(commonDb)}'. " +
                $"Run 'python tools/setup_design_db.py' first.");
        }

        var dbFiles = Directory.GetFiles(DesignDbDirectory, "*.db");
        Console.WriteLine($"[DesignDbHelper] Loaded {dbFiles.Length} design DB files from '{Path.GetFullPath(DesignDbDirectory)}'");
    }
}
