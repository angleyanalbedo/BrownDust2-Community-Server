using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MapActiveInfo : IMessage<MapActiveInfo>, IMessage, IEquatable<MapActiveInfo>, IDeepCloneable<MapActiveInfo>, IBufferMessage
{
	private static readonly MessageParser<MapActiveInfo> _parser = new MessageParser<MapActiveInfo>(() => new MapActiveInfo());

	private UnknownFieldSet _unknownFields;

	public const int MapIdFieldNumber = 1;

	private int mapId_;

	public const int ActiveInfoFieldNumber = 2;

	private static readonly FieldCodec<string> _repeated_activeInfo_codec = FieldCodec.ForString(18u);

	private readonly RepeatedField<string> activeInfo_ = new RepeatedField<string>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MapActiveInfo> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MapActiveInfoReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MapId
	{
		get
		{
			return mapId_;
		}
		set
		{
			mapId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<string> ActiveInfo => activeInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapActiveInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapActiveInfo(MapActiveInfo other)
		: this()
	{
		mapId_ = other.mapId_;
		activeInfo_ = other.activeInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapActiveInfo Clone()
	{
		return new MapActiveInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MapActiveInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MapActiveInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (MapId == other.MapId && activeInfo_.Equals(other.activeInfo_))
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
		if (MapId != 0)
		{
			num ^= MapId.GetHashCode();
		}
		num ^= activeInfo_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
		if (MapId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(MapId);
		}
		activeInfo_.WriteTo(ref output, _repeated_activeInfo_codec);
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
		if (MapId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MapId);
		}
		num += activeInfo_.CalculateSize(_repeated_activeInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MapActiveInfo other)
	{
		if (other != null)
		{
			if (other.MapId != 0)
			{
				MapId = other.MapId;
			}
			activeInfo_.Add(other.activeInfo_);
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 18u:
				activeInfo_.AddEntriesFrom(ref input, _repeated_activeInfo_codec);
				break;
			case 8u:
				MapId = input.ReadInt32();
				break;
			}
		}
	}
}
