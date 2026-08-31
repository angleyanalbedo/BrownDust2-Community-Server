using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PvpBattleUserInfoResponse : IMessage<PvpBattleUserInfoResponse>, IMessage, IEquatable<PvpBattleUserInfoResponse>, IDeepCloneable<PvpBattleUserInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<PvpBattleUserInfoResponse> _parser = new MessageParser<PvpBattleUserInfoResponse>(() => new PvpBattleUserInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int BaseInfoFieldNumber = 1;

	private PvpBattleUserBaseInfo baseInfo_;

	public const int IsSeasonRewardFieldNumber = 2;

	private bool isSeasonReward_;

	public const int PvpTableChangeSeasonFieldNumber = 3;

	private int pvpTableChangeSeason_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PvpBattleUserInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PvpBattleUserInfoResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PvpBattleUserBaseInfo BaseInfo
	{
		get
		{
			return baseInfo_;
		}
		set
		{
			baseInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsSeasonReward
	{
		get
		{
			return isSeasonReward_;
		}
		set
		{
			isSeasonReward_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PvpTableChangeSeason
	{
		get
		{
			return pvpTableChangeSeason_;
		}
		set
		{
			pvpTableChangeSeason_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleUserInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleUserInfoResponse(PvpBattleUserInfoResponse other)
		: this()
	{
		baseInfo_ = ((other.baseInfo_ != null) ? other.baseInfo_.Clone() : null);
		isSeasonReward_ = other.isSeasonReward_;
		pvpTableChangeSeason_ = other.pvpTableChangeSeason_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PvpBattleUserInfoResponse Clone()
	{
		return new PvpBattleUserInfoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PvpBattleUserInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PvpBattleUserInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(BaseInfo, other.BaseInfo) && IsSeasonReward == other.IsSeasonReward && PvpTableChangeSeason == other.PvpTableChangeSeason)
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
		if (baseInfo_ != null)
		{
			num ^= BaseInfo.GetHashCode();
		}
		if (IsSeasonReward)
		{
			num ^= IsSeasonReward.GetHashCode();
		}
		if (PvpTableChangeSeason != 0)
		{
			num ^= PvpTableChangeSeason.GetHashCode();
		}
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (baseInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(BaseInfo);
		}
		if (IsSeasonReward)
		{
			output.WriteRawTag(16);
			output.WriteBool(IsSeasonReward);
		}
		if (PvpTableChangeSeason != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(PvpTableChangeSeason);
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
		if (baseInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BaseInfo);
		}
		if (IsSeasonReward)
		{
			num += 2;
		}
		if (PvpTableChangeSeason != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PvpTableChangeSeason);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PvpBattleUserInfoResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.baseInfo_ != null)
		{
			if (baseInfo_ == null)
			{
				BaseInfo = new PvpBattleUserBaseInfo();
			}
			BaseInfo.MergeFrom(other.BaseInfo);
		}
		if (other.IsSeasonReward)
		{
			IsSeasonReward = other.IsSeasonReward;
		}
		if (other.PvpTableChangeSeason != 0)
		{
			PvpTableChangeSeason = other.PvpTableChangeSeason;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 24u:
				PvpTableChangeSeason = input.ReadInt32();
				break;
			case 16u:
				IsSeasonReward = input.ReadBool();
				break;
			case 10u:
				if (baseInfo_ == null)
				{
					BaseInfo = new PvpBattleUserBaseInfo();
				}
				input.ReadMessage(BaseInfo);
				break;
			}
		}
	}
}
