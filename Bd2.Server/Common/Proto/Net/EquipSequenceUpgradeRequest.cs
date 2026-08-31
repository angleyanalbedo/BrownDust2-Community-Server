using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EquipSequenceUpgradeRequest : IMessage<EquipSequenceUpgradeRequest>, IMessage, IEquatable<EquipSequenceUpgradeRequest>, IDeepCloneable<EquipSequenceUpgradeRequest>, IBufferMessage
{
	private static readonly MessageParser<EquipSequenceUpgradeRequest> _parser = new MessageParser<EquipSequenceUpgradeRequest>(() => new EquipSequenceUpgradeRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int InvenIndexFieldNumber = 2;

	private long invenIndex_;

	public const int UpgradeCountFieldNumber = 3;

	private int upgradeCount_;

	public const int UpgradeSeqFieldNumber = 4;

	private int upgradeSeq_;

	public const int UpgradeGoldLimitFieldNumber = 5;

	private int upgradeGoldLimit_;

	public const int UpgradeTargetLevelFieldNumber = 6;

	private int upgradeTargetLevel_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EquipSequenceUpgradeRequest> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EquipSequenceUpgradeRequestReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Seq
	{
		get
		{
			return seq_;
		}
		set
		{
			seq_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long InvenIndex
	{
		get
		{
			return invenIndex_;
		}
		set
		{
			invenIndex_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int UpgradeCount
	{
		get
		{
			return upgradeCount_;
		}
		set
		{
			upgradeCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int UpgradeSeq
	{
		get
		{
			return upgradeSeq_;
		}
		set
		{
			upgradeSeq_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int UpgradeGoldLimit
	{
		get
		{
			return upgradeGoldLimit_;
		}
		set
		{
			upgradeGoldLimit_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int UpgradeTargetLevel
	{
		get
		{
			return upgradeTargetLevel_;
		}
		set
		{
			upgradeTargetLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipSequenceUpgradeRequest()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipSequenceUpgradeRequest(EquipSequenceUpgradeRequest other)
		: this()
	{
		seq_ = other.seq_;
		invenIndex_ = other.invenIndex_;
		upgradeCount_ = other.upgradeCount_;
		upgradeSeq_ = other.upgradeSeq_;
		upgradeGoldLimit_ = other.upgradeGoldLimit_;
		upgradeTargetLevel_ = other.upgradeTargetLevel_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EquipSequenceUpgradeRequest Clone()
	{
		return new EquipSequenceUpgradeRequest(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EquipSequenceUpgradeRequest);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EquipSequenceUpgradeRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && InvenIndex == other.InvenIndex && UpgradeCount == other.UpgradeCount && UpgradeSeq == other.UpgradeSeq && UpgradeGoldLimit == other.UpgradeGoldLimit && UpgradeTargetLevel == other.UpgradeTargetLevel)
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
		if (Seq != 0)
		{
			num ^= Seq.GetHashCode();
		}
		if (InvenIndex != 0L)
		{
			num ^= InvenIndex.GetHashCode();
		}
		if (UpgradeCount != 0)
		{
			num ^= UpgradeCount.GetHashCode();
		}
		if (UpgradeSeq != 0)
		{
			num ^= UpgradeSeq.GetHashCode();
		}
		if (UpgradeGoldLimit != 0)
		{
			num ^= UpgradeGoldLimit.GetHashCode();
		}
		if (UpgradeTargetLevel != 0)
		{
			num ^= UpgradeTargetLevel.GetHashCode();
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
		if (Seq != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Seq);
		}
		if (InvenIndex != 0L)
		{
			output.WriteRawTag(16);
			output.WriteInt64(InvenIndex);
		}
		if (UpgradeCount != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(UpgradeCount);
		}
		if (UpgradeSeq != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(UpgradeSeq);
		}
		if (UpgradeGoldLimit != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(UpgradeGoldLimit);
		}
		if (UpgradeTargetLevel != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(UpgradeTargetLevel);
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
		if (Seq != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Seq);
		}
		if (InvenIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(InvenIndex);
		}
		if (UpgradeCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UpgradeCount);
		}
		if (UpgradeSeq != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UpgradeSeq);
		}
		if (UpgradeGoldLimit != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UpgradeGoldLimit);
		}
		if (UpgradeTargetLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UpgradeTargetLevel);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(EquipSequenceUpgradeRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			if (other.InvenIndex != 0L)
			{
				InvenIndex = other.InvenIndex;
			}
			if (other.UpgradeCount != 0)
			{
				UpgradeCount = other.UpgradeCount;
			}
			if (other.UpgradeSeq != 0)
			{
				UpgradeSeq = other.UpgradeSeq;
			}
			if (other.UpgradeGoldLimit != 0)
			{
				UpgradeGoldLimit = other.UpgradeGoldLimit;
			}
			if (other.UpgradeTargetLevel != 0)
			{
				UpgradeTargetLevel = other.UpgradeTargetLevel;
			}
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
			switch (num)
			{
			case 8u:
				Seq = input.ReadInt32();
				break;
			case 16u:
				InvenIndex = input.ReadInt64();
				break;
			case 24u:
				UpgradeCount = input.ReadInt32();
				break;
			case 32u:
				UpgradeSeq = input.ReadInt32();
				break;
			case 40u:
				UpgradeGoldLimit = input.ReadInt32();
				break;
			case 48u:
				UpgradeTargetLevel = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
