using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MonsterHuntUserInfoResponse : IMessage<MonsterHuntUserInfoResponse>, IMessage, IEquatable<MonsterHuntUserInfoResponse>, IDeepCloneable<MonsterHuntUserInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<MonsterHuntUserInfoResponse> _parser = new MessageParser<MonsterHuntUserInfoResponse>(() => new MonsterHuntUserInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int MonsterHuntUserInfoFieldNumber = 1;

	private MonsterHuntUserDBInfo monsterHuntUserInfo_;

	public const int RankFieldNumber = 2;

	private int rank_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonsterHuntUserInfoResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MonsterHuntUserInfoResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterHuntUserDBInfo MonsterHuntUserInfo
	{
		get
		{
			return monsterHuntUserInfo_;
		}
		set
		{
			monsterHuntUserInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Rank
	{
		get
		{
			return rank_;
		}
		set
		{
			rank_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MonsterHuntUserInfoResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MonsterHuntUserInfoResponse(MonsterHuntUserInfoResponse other)
		: this()
	{
		monsterHuntUserInfo_ = ((other.monsterHuntUserInfo_ != null) ? other.monsterHuntUserInfo_.Clone() : null);
		rank_ = other.rank_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterHuntUserInfoResponse Clone()
	{
		return new MonsterHuntUserInfoResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as MonsterHuntUserInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonsterHuntUserInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(MonsterHuntUserInfo, other.MonsterHuntUserInfo) && Rank == other.Rank)
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
		if (monsterHuntUserInfo_ != null)
		{
			num ^= MonsterHuntUserInfo.GetHashCode();
		}
		if (Rank != 0)
		{
			num ^= Rank.GetHashCode();
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
		if (monsterHuntUserInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(MonsterHuntUserInfo);
		}
		if (Rank != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Rank);
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
		if (monsterHuntUserInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MonsterHuntUserInfo);
		}
		if (Rank != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Rank);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonsterHuntUserInfoResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.monsterHuntUserInfo_ != null)
		{
			if (monsterHuntUserInfo_ == null)
			{
				MonsterHuntUserInfo = new MonsterHuntUserDBInfo();
			}
			MonsterHuntUserInfo.MergeFrom(other.MonsterHuntUserInfo);
		}
		if (other.Rank != 0)
		{
			Rank = other.Rank;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 16u:
				Rank = input.ReadInt32();
				break;
			case 10u:
				if (monsterHuntUserInfo_ == null)
				{
					MonsterHuntUserInfo = new MonsterHuntUserDBInfo();
				}
				input.ReadMessage(MonsterHuntUserInfo);
				break;
			}
		}
	}
}
