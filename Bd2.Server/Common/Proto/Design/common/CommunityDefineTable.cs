using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class CommunityDefineTable : IMessage<CommunityDefineTable>, IMessage, IEquatable<CommunityDefineTable>, IDeepCloneable<CommunityDefineTable>, IBufferMessage
{
	private static readonly MessageParser<CommunityDefineTable> _parser = new MessageParser<CommunityDefineTable>(() => new CommunityDefineTable());

	private UnknownFieldSet _unknownFields;

	public const int FriendSendExpireDayFieldNumber = 1;

	private int friendSendExpireDay_;

	public const int IdFieldNumber = 2;

	private int id_;

	public const int MaxFriendCountFieldNumber = 3;

	private int maxFriendCount_;

	public const int MaxFriendRecommendCountFieldNumber = 4;

	private int maxFriendRecommendCount_;

	public const int MaxFriendRecvCountFieldNumber = 5;

	private int maxFriendRecvCount_;

	public const int MaxFriendSendCountFieldNumber = 6;

	private int maxFriendSendCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CommunityDefineTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CommunityDefineTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FriendSendExpireDay
	{
		get
		{
			return friendSendExpireDay_;
		}
		set
		{
			friendSendExpireDay_ = value;
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
	public int MaxFriendCount
	{
		get
		{
			return maxFriendCount_;
		}
		set
		{
			maxFriendCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MaxFriendRecommendCount
	{
		get
		{
			return maxFriendRecommendCount_;
		}
		set
		{
			maxFriendRecommendCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MaxFriendRecvCount
	{
		get
		{
			return maxFriendRecvCount_;
		}
		set
		{
			maxFriendRecvCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MaxFriendSendCount
	{
		get
		{
			return maxFriendSendCount_;
		}
		set
		{
			maxFriendSendCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CommunityDefineTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CommunityDefineTable(CommunityDefineTable other)
		: this()
	{
		friendSendExpireDay_ = other.friendSendExpireDay_;
		id_ = other.id_;
		maxFriendCount_ = other.maxFriendCount_;
		maxFriendRecommendCount_ = other.maxFriendRecommendCount_;
		maxFriendRecvCount_ = other.maxFriendRecvCount_;
		maxFriendSendCount_ = other.maxFriendSendCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CommunityDefineTable Clone()
	{
		return new CommunityDefineTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CommunityDefineTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CommunityDefineTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (FriendSendExpireDay == other.FriendSendExpireDay && Id == other.Id && MaxFriendCount == other.MaxFriendCount && MaxFriendRecommendCount == other.MaxFriendRecommendCount && MaxFriendRecvCount == other.MaxFriendRecvCount && MaxFriendSendCount == other.MaxFriendSendCount)
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
		if (FriendSendExpireDay != 0)
		{
			num ^= FriendSendExpireDay.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (MaxFriendCount != 0)
		{
			num ^= MaxFriendCount.GetHashCode();
		}
		if (MaxFriendRecommendCount != 0)
		{
			num ^= MaxFriendRecommendCount.GetHashCode();
		}
		if (MaxFriendRecvCount != 0)
		{
			num ^= MaxFriendRecvCount.GetHashCode();
		}
		if (MaxFriendSendCount != 0)
		{
			num ^= MaxFriendSendCount.GetHashCode();
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
		if (FriendSendExpireDay != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(FriendSendExpireDay);
		}
		if (Id != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Id);
		}
		if (MaxFriendCount != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(MaxFriendCount);
		}
		if (MaxFriendRecommendCount != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(MaxFriendRecommendCount);
		}
		if (MaxFriendRecvCount != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(MaxFriendRecvCount);
		}
		if (MaxFriendSendCount != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(MaxFriendSendCount);
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
		if (FriendSendExpireDay != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FriendSendExpireDay);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (MaxFriendCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxFriendCount);
		}
		if (MaxFriendRecommendCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxFriendRecommendCount);
		}
		if (MaxFriendRecvCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxFriendRecvCount);
		}
		if (MaxFriendSendCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxFriendSendCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CommunityDefineTable other)
	{
		if (other != null)
		{
			if (other.FriendSendExpireDay != 0)
			{
				FriendSendExpireDay = other.FriendSendExpireDay;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.MaxFriendCount != 0)
			{
				MaxFriendCount = other.MaxFriendCount;
			}
			if (other.MaxFriendRecommendCount != 0)
			{
				MaxFriendRecommendCount = other.MaxFriendRecommendCount;
			}
			if (other.MaxFriendRecvCount != 0)
			{
				MaxFriendRecvCount = other.MaxFriendRecvCount;
			}
			if (other.MaxFriendSendCount != 0)
			{
				MaxFriendSendCount = other.MaxFriendSendCount;
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
				FriendSendExpireDay = input.ReadInt32();
				break;
			case 16u:
				Id = input.ReadInt32();
				break;
			case 24u:
				MaxFriendCount = input.ReadInt32();
				break;
			case 32u:
				MaxFriendRecommendCount = input.ReadInt32();
				break;
			case 40u:
				MaxFriendRecvCount = input.ReadInt32();
				break;
			case 48u:
				MaxFriendSendCount = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
