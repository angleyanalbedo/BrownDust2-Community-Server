using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MissionUpdateInfoMap : IMessage<MissionUpdateInfoMap>, IMessage, IEquatable<MissionUpdateInfoMap>, IDeepCloneable<MissionUpdateInfoMap>, IBufferMessage
{
	private static readonly MessageParser<MissionUpdateInfoMap> _parser = new MessageParser<MissionUpdateInfoMap>(() => new MissionUpdateInfoMap());

	private UnknownFieldSet _unknownFields;

	public const int MissionInfoFieldNumber = 1;

	private static readonly MapField<int, int>.Codec _map_missionInfo_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8u, 0), FieldCodec.ForInt32(16u, 0), 10u);

	private readonly MapField<int, int> missionInfo_ = new MapField<int, int>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MissionUpdateInfoMap> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => NotifyReflection.Descriptor.MessageTypes[1];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<int, int> MissionInfo => missionInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MissionUpdateInfoMap()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MissionUpdateInfoMap(MissionUpdateInfoMap other)
		: this()
	{
		missionInfo_ = other.missionInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MissionUpdateInfoMap Clone()
	{
		return new MissionUpdateInfoMap(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as MissionUpdateInfoMap);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MissionUpdateInfoMap other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (MissionInfo.Equals(other.MissionInfo))
				{
					return object.Equals(_unknownFields, other._unknownFields);
				}
				return false;
			}
			return true;
		}
		return false;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		num ^= MissionInfo.GetHashCode();
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		missionInfo_.WriteTo(ref output, _map_missionInfo_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		num += missionInfo_.CalculateSize(_map_missionInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(MissionUpdateInfoMap other)
	{
		if (other != null)
		{
			missionInfo_.Add(other.missionInfo_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
				missionInfo_.AddEntriesFrom(ref input, _map_missionInfo_codec);
			}
		}
	}
}
