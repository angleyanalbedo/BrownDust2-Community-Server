using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class FieldTrapDBInfo : IMessage<FieldTrapDBInfo>, IMessage, IEquatable<FieldTrapDBInfo>, IDeepCloneable<FieldTrapDBInfo>, IBufferMessage
{
	private static readonly MessageParser<FieldTrapDBInfo> _parser = new MessageParser<FieldTrapDBInfo>(() => new FieldTrapDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int PackIdFieldNumber = 1;

	private int packId_;

	public const int MapIdFieldNumber = 2;

	private int mapId_;

	public const int TrapIdFieldNumber = 3;

	private int trapId_;

	public const int StateFieldNumber = 4;

	private int state_;

	public const int SwitchObjectIdFieldNumber = 5;

	private static readonly FieldCodec<int> _repeated_switchObjectId_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> switchObjectId_ = new RepeatedField<int>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FieldTrapDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FieldTrapDBInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PackId
	{
		get
		{
			return packId_;
		}
		set
		{
			packId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TrapId
	{
		get
		{
			return trapId_;
		}
		set
		{
			trapId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int State
	{
		get
		{
			return state_;
		}
		set
		{
			state_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> SwitchObjectId => switchObjectId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FieldTrapDBInfo()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FieldTrapDBInfo(FieldTrapDBInfo other)
		: this()
	{
		packId_ = other.packId_;
		mapId_ = other.mapId_;
		trapId_ = other.trapId_;
		state_ = other.state_;
		switchObjectId_ = other.switchObjectId_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FieldTrapDBInfo Clone()
	{
		return new FieldTrapDBInfo(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as FieldTrapDBInfo);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(FieldTrapDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (PackId == other.PackId && MapId == other.MapId && TrapId == other.TrapId && State == other.State && switchObjectId_.Equals(other.switchObjectId_))
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
		if (PackId != 0)
		{
			num ^= PackId.GetHashCode();
		}
		if (MapId != 0)
		{
			num ^= MapId.GetHashCode();
		}
		if (TrapId != 0)
		{
			num ^= TrapId.GetHashCode();
		}
		if (State != 0)
		{
			num ^= State.GetHashCode();
		}
		num ^= switchObjectId_.GetHashCode();
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (PackId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(PackId);
		}
		if (MapId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(MapId);
		}
		if (TrapId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(TrapId);
		}
		if (State != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(State);
		}
		switchObjectId_.WriteTo(ref output, _repeated_switchObjectId_codec);
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
		if (PackId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PackId);
		}
		if (MapId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MapId);
		}
		if (TrapId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TrapId);
		}
		if (State != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(State);
		}
		num += switchObjectId_.CalculateSize(_repeated_switchObjectId_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FieldTrapDBInfo other)
	{
		if (other != null)
		{
			if (other.PackId != 0)
			{
				PackId = other.PackId;
			}
			if (other.MapId != 0)
			{
				MapId = other.MapId;
			}
			if (other.TrapId != 0)
			{
				TrapId = other.TrapId;
			}
			if (other.State != 0)
			{
				State = other.State;
			}
			switchObjectId_.Add(other.switchObjectId_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
			case 8u:
				PackId = input.ReadInt32();
				break;
			case 16u:
				MapId = input.ReadInt32();
				break;
			case 24u:
				TrapId = input.ReadInt32();
				break;
			case 32u:
				State = input.ReadInt32();
				break;
			case 40u:
			case 42u:
				switchObjectId_.AddEntriesFrom(ref input, _repeated_switchObjectId_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
