using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class HuntingGroundDBInfo : IMessage<HuntingGroundDBInfo>, IMessage, IEquatable<HuntingGroundDBInfo>, IDeepCloneable<HuntingGroundDBInfo>, IBufferMessage
{
	private static readonly MessageParser<HuntingGroundDBInfo> _parser = new MessageParser<HuntingGroundDBInfo>(() => new HuntingGroundDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int IsAutoFieldNumber = 1;

	private bool isAuto_;

	public const int CurrentIdFieldNumber = 2;

	private int currentId_;

	public const int HighestIdFieldNumber = 3;

	private int highestId_;

	public const int MonsterInfoFieldNumber = 4;

	private static readonly FieldCodec<MonsterDBInfo> _repeated_monsterInfo_codec = FieldCodec.ForMessage(34u, MonsterDBInfo.Parser);

	private readonly RepeatedField<MonsterDBInfo> monsterInfo_ = new RepeatedField<MonsterDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HuntingGroundDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HuntingGroundDBInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsAuto
	{
		get
		{
			return isAuto_;
		}
		set
		{
			isAuto_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CurrentId
	{
		get
		{
			return currentId_;
		}
		set
		{
			currentId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int HighestId
	{
		get
		{
			return highestId_;
		}
		set
		{
			highestId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<MonsterDBInfo> MonsterInfo => monsterInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HuntingGroundDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HuntingGroundDBInfo(HuntingGroundDBInfo other)
		: this()
	{
		isAuto_ = other.isAuto_;
		currentId_ = other.currentId_;
		highestId_ = other.highestId_;
		monsterInfo_ = other.monsterInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HuntingGroundDBInfo Clone()
	{
		return new HuntingGroundDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HuntingGroundDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HuntingGroundDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (IsAuto == other.IsAuto && CurrentId == other.CurrentId && HighestId == other.HighestId && monsterInfo_.Equals(other.monsterInfo_))
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
		if (IsAuto)
		{
			num ^= IsAuto.GetHashCode();
		}
		if (CurrentId != 0)
		{
			num ^= CurrentId.GetHashCode();
		}
		if (HighestId != 0)
		{
			num ^= HighestId.GetHashCode();
		}
		num ^= monsterInfo_.GetHashCode();
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
		if (IsAuto)
		{
			output.WriteRawTag(8);
			output.WriteBool(IsAuto);
		}
		if (CurrentId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(CurrentId);
		}
		if (HighestId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(HighestId);
		}
		monsterInfo_.WriteTo(ref output, _repeated_monsterInfo_codec);
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
		if (IsAuto)
		{
			num += 2;
		}
		if (CurrentId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CurrentId);
		}
		if (HighestId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HighestId);
		}
		num += monsterInfo_.CalculateSize(_repeated_monsterInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(HuntingGroundDBInfo other)
	{
		if (other != null)
		{
			if (other.IsAuto)
			{
				IsAuto = other.IsAuto;
			}
			if (other.CurrentId != 0)
			{
				CurrentId = other.CurrentId;
			}
			if (other.HighestId != 0)
			{
				HighestId = other.HighestId;
			}
			monsterInfo_.Add(other.monsterInfo_);
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
			case 8u:
				IsAuto = input.ReadBool();
				break;
			case 16u:
				CurrentId = input.ReadInt32();
				break;
			case 24u:
				HighestId = input.ReadInt32();
				break;
			case 34u:
				monsterInfo_.AddEntriesFrom(ref input, _repeated_monsterInfo_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
