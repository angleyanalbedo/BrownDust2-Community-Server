using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class PackJamEventTable : IMessage<PackJamEventTable>, IMessage, IEquatable<PackJamEventTable>, IDeepCloneable<PackJamEventTable>, IBufferMessage
{
	private static readonly MessageParser<PackJamEventTable> _parser = new MessageParser<PackJamEventTable>(() => new PackJamEventTable());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int InsertMaxFieldNumber = 2;

	private int insertMax_;

	public const int InsertMinFieldNumber = 3;

	private int insertMin_;

	public const int RewardCountFieldNumber = 4;

	private int rewardCount_;

	public const int RewardIdFieldNumber = 5;

	private int rewardId_;

	public const int RewardTypeFieldNumber = 6;

	private int rewardType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PackJamEventTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => PackJamEventTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public int InsertMax
	{
		get
		{
			return insertMax_;
		}
		set
		{
			insertMax_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int InsertMin
	{
		get
		{
			return insertMin_;
		}
		set
		{
			insertMin_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RewardCount
	{
		get
		{
			return rewardCount_;
		}
		set
		{
			rewardCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RewardId
	{
		get
		{
			return rewardId_;
		}
		set
		{
			rewardId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RewardType
	{
		get
		{
			return rewardType_;
		}
		set
		{
			rewardType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackJamEventTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackJamEventTable(PackJamEventTable other)
		: this()
	{
		id_ = other.id_;
		insertMax_ = other.insertMax_;
		insertMin_ = other.insertMin_;
		rewardCount_ = other.rewardCount_;
		rewardId_ = other.rewardId_;
		rewardType_ = other.rewardType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PackJamEventTable Clone()
	{
		return new PackJamEventTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as PackJamEventTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PackJamEventTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && InsertMax == other.InsertMax && InsertMin == other.InsertMin && RewardCount == other.RewardCount && RewardId == other.RewardId && RewardType == other.RewardType)
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
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (InsertMax != 0)
		{
			num ^= InsertMax.GetHashCode();
		}
		if (InsertMin != 0)
		{
			num ^= InsertMin.GetHashCode();
		}
		if (RewardCount != 0)
		{
			num ^= RewardCount.GetHashCode();
		}
		if (RewardId != 0)
		{
			num ^= RewardId.GetHashCode();
		}
		if (RewardType != 0)
		{
			num ^= RewardType.GetHashCode();
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
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (InsertMax != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(InsertMax);
		}
		if (InsertMin != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(InsertMin);
		}
		if (RewardCount != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(RewardCount);
		}
		if (RewardId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(RewardId);
		}
		if (RewardType != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(RewardType);
		}
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
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (InsertMax != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(InsertMax);
		}
		if (InsertMin != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(InsertMin);
		}
		if (RewardCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RewardCount);
		}
		if (RewardId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RewardId);
		}
		if (RewardType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RewardType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PackJamEventTable other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.InsertMax != 0)
			{
				InsertMax = other.InsertMax;
			}
			if (other.InsertMin != 0)
			{
				InsertMin = other.InsertMin;
			}
			if (other.RewardCount != 0)
			{
				RewardCount = other.RewardCount;
			}
			if (other.RewardId != 0)
			{
				RewardId = other.RewardId;
			}
			if (other.RewardType != 0)
			{
				RewardType = other.RewardType;
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			case 8u:
				Id = input.ReadInt32();
				break;
			case 16u:
				InsertMax = input.ReadInt32();
				break;
			case 24u:
				InsertMin = input.ReadInt32();
				break;
			case 32u:
				RewardCount = input.ReadInt32();
				break;
			case 40u:
				RewardId = input.ReadInt32();
				break;
			case 48u:
				RewardType = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
