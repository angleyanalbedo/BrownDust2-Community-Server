using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PassRewardRequest : IMessage<PassRewardRequest>, IMessage, IEquatable<PassRewardRequest>, IDeepCloneable<PassRewardRequest>, IBufferMessage
{
	private static readonly MessageParser<PassRewardRequest> _parser = new MessageParser<PassRewardRequest>(() => new PassRewardRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int IsAllFieldNumber = 2;

	private bool isAll_;

	public const int PassIdFieldNumber = 3;

	private int passId_;

	public const int IdFieldNumber = 4;

	private int id_;

	public const int RewardTypeFieldNumber = 5;

	private Define_PassRewardType rewardType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PassRewardRequest> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PassRewardRequestReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsAll
	{
		get
		{
			return isAll_;
		}
		set
		{
			isAll_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PassId
	{
		get
		{
			return passId_;
		}
		set
		{
			passId_ = value;
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
	public Define_PassRewardType RewardType
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
	public PassRewardRequest()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PassRewardRequest(PassRewardRequest other)
		: this()
	{
		seq_ = other.seq_;
		isAll_ = other.isAll_;
		passId_ = other.passId_;
		id_ = other.id_;
		rewardType_ = other.rewardType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PassRewardRequest Clone()
	{
		return new PassRewardRequest(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as PassRewardRequest);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PassRewardRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && IsAll == other.IsAll && PassId == other.PassId && Id == other.Id && RewardType == other.RewardType)
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
		if (Seq != 0)
		{
			num ^= Seq.GetHashCode();
		}
		if (IsAll)
		{
			num ^= IsAll.GetHashCode();
		}
		if (PassId != 0)
		{
			num ^= PassId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (RewardType != Define_PassRewardType.SprBasic)
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
		if (Seq != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Seq);
		}
		if (IsAll)
		{
			output.WriteRawTag(16);
			output.WriteBool(IsAll);
		}
		if (PassId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(PassId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Id);
		}
		if (RewardType != Define_PassRewardType.SprBasic)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)RewardType);
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
		if (IsAll)
		{
			num += 2;
		}
		if (PassId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PassId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (RewardType != Define_PassRewardType.SprBasic)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)RewardType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PassRewardRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			if (other.IsAll)
			{
				IsAll = other.IsAll;
			}
			if (other.PassId != 0)
			{
				PassId = other.PassId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.RewardType != Define_PassRewardType.SprBasic)
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
				Seq = input.ReadInt32();
				break;
			case 16u:
				IsAll = input.ReadBool();
				break;
			case 24u:
				PassId = input.ReadInt32();
				break;
			case 32u:
				Id = input.ReadInt32();
				break;
			case 40u:
				RewardType = (Define_PassRewardType)input.ReadEnum();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
