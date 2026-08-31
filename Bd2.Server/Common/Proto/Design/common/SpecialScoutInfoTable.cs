using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class SpecialScoutInfoTable : IMessage<SpecialScoutInfoTable>, IMessage, IEquatable<SpecialScoutInfoTable>, IDeepCloneable<SpecialScoutInfoTable>, IBufferMessage
{
	private static readonly MessageParser<SpecialScoutInfoTable> _parser = new MessageParser<SpecialScoutInfoTable>(() => new SpecialScoutInfoTable());

	private UnknownFieldSet _unknownFields;

	public const int AppearTotalCountFieldNumber = 1;

	private int appearTotalCount_;

	public const int AutoResetMinuteFieldNumber = 2;

	private int autoResetMinute_;

	public const int IdFieldNumber = 3;

	private int id_;

	public const int ResetCostCountFieldNumber = 4;

	private int resetCostCount_;

	public const int ResetCostIdFieldNumber = 5;

	private int resetCostId_;

	public const int ResetCostTypeFieldNumber = 6;

	private int resetCostType_;

	public const int ResetLimitCountFieldNumber = 7;

	private int resetLimitCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SpecialScoutInfoTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SpecialScoutInfoTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int AppearTotalCount
	{
		get
		{
			return appearTotalCount_;
		}
		set
		{
			appearTotalCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int AutoResetMinute
	{
		get
		{
			return autoResetMinute_;
		}
		set
		{
			autoResetMinute_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ResetCostCount
	{
		get
		{
			return resetCostCount_;
		}
		set
		{
			resetCostCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ResetCostId
	{
		get
		{
			return resetCostId_;
		}
		set
		{
			resetCostId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ResetCostType
	{
		get
		{
			return resetCostType_;
		}
		set
		{
			resetCostType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ResetLimitCount
	{
		get
		{
			return resetLimitCount_;
		}
		set
		{
			resetLimitCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpecialScoutInfoTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpecialScoutInfoTable(SpecialScoutInfoTable other)
		: this()
	{
		appearTotalCount_ = other.appearTotalCount_;
		autoResetMinute_ = other.autoResetMinute_;
		id_ = other.id_;
		resetCostCount_ = other.resetCostCount_;
		resetCostId_ = other.resetCostId_;
		resetCostType_ = other.resetCostType_;
		resetLimitCount_ = other.resetLimitCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpecialScoutInfoTable Clone()
	{
		return new SpecialScoutInfoTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as SpecialScoutInfoTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(SpecialScoutInfoTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (AppearTotalCount == other.AppearTotalCount && AutoResetMinute == other.AutoResetMinute && Id == other.Id && ResetCostCount == other.ResetCostCount && ResetCostId == other.ResetCostId && ResetCostType == other.ResetCostType && ResetLimitCount == other.ResetLimitCount)
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
		if (AppearTotalCount != 0)
		{
			num ^= AppearTotalCount.GetHashCode();
		}
		if (AutoResetMinute != 0)
		{
			num ^= AutoResetMinute.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (ResetCostCount != 0)
		{
			num ^= ResetCostCount.GetHashCode();
		}
		if (ResetCostId != 0)
		{
			num ^= ResetCostId.GetHashCode();
		}
		if (ResetCostType != 0)
		{
			num ^= ResetCostType.GetHashCode();
		}
		if (ResetLimitCount != 0)
		{
			num ^= ResetLimitCount.GetHashCode();
		}
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (AppearTotalCount != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(AppearTotalCount);
		}
		if (AutoResetMinute != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(AutoResetMinute);
		}
		if (Id != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Id);
		}
		if (ResetCostCount != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ResetCostCount);
		}
		if (ResetCostId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(ResetCostId);
		}
		if (ResetCostType != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(ResetCostType);
		}
		if (ResetLimitCount != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(ResetLimitCount);
		}
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
		if (AppearTotalCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AppearTotalCount);
		}
		if (AutoResetMinute != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AutoResetMinute);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (ResetCostCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ResetCostCount);
		}
		if (ResetCostId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ResetCostId);
		}
		if (ResetCostType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ResetCostType);
		}
		if (ResetLimitCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ResetLimitCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(SpecialScoutInfoTable other)
	{
		if (other != null)
		{
			if (other.AppearTotalCount != 0)
			{
				AppearTotalCount = other.AppearTotalCount;
			}
			if (other.AutoResetMinute != 0)
			{
				AutoResetMinute = other.AutoResetMinute;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.ResetCostCount != 0)
			{
				ResetCostCount = other.ResetCostCount;
			}
			if (other.ResetCostId != 0)
			{
				ResetCostId = other.ResetCostId;
			}
			if (other.ResetCostType != 0)
			{
				ResetCostType = other.ResetCostType;
			}
			if (other.ResetLimitCount != 0)
			{
				ResetLimitCount = other.ResetLimitCount;
			}
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
				AppearTotalCount = input.ReadInt32();
				break;
			case 16u:
				AutoResetMinute = input.ReadInt32();
				break;
			case 24u:
				Id = input.ReadInt32();
				break;
			case 32u:
				ResetCostCount = input.ReadInt32();
				break;
			case 40u:
				ResetCostId = input.ReadInt32();
				break;
			case 48u:
				ResetCostType = input.ReadInt32();
				break;
			case 56u:
				ResetLimitCount = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
