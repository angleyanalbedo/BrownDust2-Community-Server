using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EventMissionInfoMap : IMessage<EventMissionInfoMap>, IMessage, IEquatable<EventMissionInfoMap>, IDeepCloneable<EventMissionInfoMap>, IBufferMessage
{
	private static readonly MessageParser<EventMissionInfoMap> _parser = new MessageParser<EventMissionInfoMap>(() => new EventMissionInfoMap());

	private UnknownFieldSet _unknownFields;

	public const int MissionGroupInfoFieldNumber = 1;

	private static readonly MapField<int, MissionUpdateInfoMap>.Codec _map_missionGroupInfo_codec = new MapField<int, MissionUpdateInfoMap>.Codec(FieldCodec.ForInt32(8u, 0), FieldCodec.ForMessage(18u, MissionUpdateInfoMap.Parser), 10u);

	private readonly MapField<int, MissionUpdateInfoMap> missionGroupInfo_ = new MapField<int, MissionUpdateInfoMap>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<EventMissionInfoMap> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NotifyReflection.Descriptor.MessageTypes[2];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<int, MissionUpdateInfoMap> MissionGroupInfo => missionGroupInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EventMissionInfoMap()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EventMissionInfoMap(EventMissionInfoMap other)
		: this()
	{
		missionGroupInfo_ = other.missionGroupInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EventMissionInfoMap Clone()
	{
		return new EventMissionInfoMap(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as EventMissionInfoMap);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EventMissionInfoMap other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (MissionGroupInfo.Equals(other.MissionGroupInfo))
				{
					return object.Equals(_unknownFields, other._unknownFields);
				}
				return false;
			}
			return true;
		}
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		num ^= MissionGroupInfo.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		missionGroupInfo_.WriteTo(ref output, _map_missionGroupInfo_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		num += missionGroupInfo_.CalculateSize(_map_missionGroupInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EventMissionInfoMap other)
	{
		if (other != null)
		{
			missionGroupInfo_.Add(other.missionGroupInfo_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				missionGroupInfo_.AddEntriesFrom(ref input, _map_missionGroupInfo_codec);
			}
		}
	}
}
