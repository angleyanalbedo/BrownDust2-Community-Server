using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class PassLevelTable : IMessage<PassLevelTable>, IMessage, IEquatable<PassLevelTable>, IDeepCloneable<PassLevelTable>, IBufferMessage
{
	private static readonly MessageParser<PassLevelTable> _parser = new MessageParser<PassLevelTable>(() => new PassLevelTable());

	private UnknownFieldSet _unknownFields;

	public const int BasicRewardCountFieldNumber = 1;

	private int basicRewardCount_;

	public const int BasicRewardIdFieldNumber = 2;

	private int basicRewardId_;

	public const int BasicRewardTypeFieldNumber = 3;

	private int basicRewardType_;

	public const int GroupIdFieldNumber = 4;

	private int groupId_;

	public const int IdFieldNumber = 5;

	private int id_;

	public const int NextNeedExpFieldNumber = 6;

	private int nextNeedExp_;

	public const int Pass1RewardCountFieldNumber = 7;

	private int pass1RewardCount_;

	public const int Pass1RewardIdFieldNumber = 8;

	private int pass1RewardId_;

	public const int Pass1RewardTypeFieldNumber = 9;

	private int pass1RewardType_;

	public const int PremiumTypeFieldNumber = 10;

	private int premiumType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PassLevelTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PassLevelTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BasicRewardCount
	{
		get
		{
			return basicRewardCount_;
		}
		set
		{
			basicRewardCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BasicRewardId
	{
		get
		{
			return basicRewardId_;
		}
		set
		{
			basicRewardId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BasicRewardType
	{
		get
		{
			return basicRewardType_;
		}
		set
		{
			basicRewardType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int NextNeedExp
	{
		get
		{
			return nextNeedExp_;
		}
		set
		{
			nextNeedExp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Pass1RewardCount
	{
		get
		{
			return pass1RewardCount_;
		}
		set
		{
			pass1RewardCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Pass1RewardId
	{
		get
		{
			return pass1RewardId_;
		}
		set
		{
			pass1RewardId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Pass1RewardType
	{
		get
		{
			return pass1RewardType_;
		}
		set
		{
			pass1RewardType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PremiumType
	{
		get
		{
			return premiumType_;
		}
		set
		{
			premiumType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PassLevelTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PassLevelTable(PassLevelTable other)
		: this()
	{
		basicRewardCount_ = other.basicRewardCount_;
		basicRewardId_ = other.basicRewardId_;
		basicRewardType_ = other.basicRewardType_;
		groupId_ = other.groupId_;
		id_ = other.id_;
		nextNeedExp_ = other.nextNeedExp_;
		pass1RewardCount_ = other.pass1RewardCount_;
		pass1RewardId_ = other.pass1RewardId_;
		pass1RewardType_ = other.pass1RewardType_;
		premiumType_ = other.premiumType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PassLevelTable Clone()
	{
		return new PassLevelTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PassLevelTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PassLevelTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (BasicRewardCount == other.BasicRewardCount && BasicRewardId == other.BasicRewardId && BasicRewardType == other.BasicRewardType && GroupId == other.GroupId && Id == other.Id && NextNeedExp == other.NextNeedExp && Pass1RewardCount == other.Pass1RewardCount && Pass1RewardId == other.Pass1RewardId && Pass1RewardType == other.Pass1RewardType && PremiumType == other.PremiumType)
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
		if (BasicRewardCount != 0)
		{
			num ^= BasicRewardCount.GetHashCode();
		}
		if (BasicRewardId != 0)
		{
			num ^= BasicRewardId.GetHashCode();
		}
		if (BasicRewardType != 0)
		{
			num ^= BasicRewardType.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (NextNeedExp != 0)
		{
			num ^= NextNeedExp.GetHashCode();
		}
		if (Pass1RewardCount != 0)
		{
			num ^= Pass1RewardCount.GetHashCode();
		}
		if (Pass1RewardId != 0)
		{
			num ^= Pass1RewardId.GetHashCode();
		}
		if (Pass1RewardType != 0)
		{
			num ^= Pass1RewardType.GetHashCode();
		}
		if (PremiumType != 0)
		{
			num ^= PremiumType.GetHashCode();
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (BasicRewardCount != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BasicRewardCount);
		}
		if (BasicRewardId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BasicRewardId);
		}
		if (BasicRewardType != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(BasicRewardType);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(GroupId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Id);
		}
		if (NextNeedExp != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(NextNeedExp);
		}
		if (Pass1RewardCount != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(Pass1RewardCount);
		}
		if (Pass1RewardId != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(Pass1RewardId);
		}
		if (Pass1RewardType != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(Pass1RewardType);
		}
		if (PremiumType != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(PremiumType);
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
		if (BasicRewardCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BasicRewardCount);
		}
		if (BasicRewardId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BasicRewardId);
		}
		if (BasicRewardType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BasicRewardType);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (NextNeedExp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NextNeedExp);
		}
		if (Pass1RewardCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Pass1RewardCount);
		}
		if (Pass1RewardId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Pass1RewardId);
		}
		if (Pass1RewardType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Pass1RewardType);
		}
		if (PremiumType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PremiumType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PassLevelTable other)
	{
		if (other != null)
		{
			if (other.BasicRewardCount != 0)
			{
				BasicRewardCount = other.BasicRewardCount;
			}
			if (other.BasicRewardId != 0)
			{
				BasicRewardId = other.BasicRewardId;
			}
			if (other.BasicRewardType != 0)
			{
				BasicRewardType = other.BasicRewardType;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.NextNeedExp != 0)
			{
				NextNeedExp = other.NextNeedExp;
			}
			if (other.Pass1RewardCount != 0)
			{
				Pass1RewardCount = other.Pass1RewardCount;
			}
			if (other.Pass1RewardId != 0)
			{
				Pass1RewardId = other.Pass1RewardId;
			}
			if (other.Pass1RewardType != 0)
			{
				Pass1RewardType = other.Pass1RewardType;
			}
			if (other.PremiumType != 0)
			{
				PremiumType = other.PremiumType;
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
				BasicRewardCount = input.ReadInt32();
				break;
			case 16u:
				BasicRewardId = input.ReadInt32();
				break;
			case 24u:
				BasicRewardType = input.ReadInt32();
				break;
			case 32u:
				GroupId = input.ReadInt32();
				break;
			case 40u:
				Id = input.ReadInt32();
				break;
			case 48u:
				NextNeedExp = input.ReadInt32();
				break;
			case 56u:
				Pass1RewardCount = input.ReadInt32();
				break;
			case 64u:
				Pass1RewardId = input.ReadInt32();
				break;
			case 72u:
				Pass1RewardType = input.ReadInt32();
				break;
			case 80u:
				PremiumType = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
