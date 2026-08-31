using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PvpBattleRankUserInfo : IMessage<PvpBattleRankUserInfo>, IMessage, IEquatable<PvpBattleRankUserInfo>, IDeepCloneable<PvpBattleRankUserInfo>, IBufferMessage
{
	private static readonly MessageParser<PvpBattleRankUserInfo> _parser = new MessageParser<PvpBattleRankUserInfo>(() => new PvpBattleRankUserInfo());

	private UnknownFieldSet _unknownFields;

	public const int OwnerIndexFieldNumber = 1;

	private long ownerIndex_;

	public const int UserIdFieldNumber = 2;

	private string userId_ = "";

	public const int UserExpFieldNumber = 3;

	private int userExp_;

	public const int PortraitCostumeIdFieldNumber = 4;

	private int portraitCostumeId_;

	public const int GuildBaseInfoFieldNumber = 5;

	private GuildBaseDBInfo guildBaseInfo_;

	public const int BaseInfoFieldNumber = 6;

	private PvpBattleUserBaseInfo baseInfo_;

	public const int TitleIdFieldNumber = 7;

	private int titleId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PvpBattleRankUserInfo> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => PvpBattleRankUserInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long OwnerIndex
	{
		get
		{
			return ownerIndex_;
		}
		set
		{
			ownerIndex_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string UserId
	{
		get
		{
			return userId_;
		}
		set
		{
			userId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int UserExp
	{
		get
		{
			return userExp_;
		}
		set
		{
			userExp_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PortraitCostumeId
	{
		get
		{
			return portraitCostumeId_;
		}
		set
		{
			portraitCostumeId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildBaseDBInfo GuildBaseInfo
	{
		get
		{
			return guildBaseInfo_;
		}
		set
		{
			guildBaseInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public int TitleId
	{
		get
		{
			return titleId_;
		}
		set
		{
			titleId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleRankUserInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleRankUserInfo(PvpBattleRankUserInfo other)
		: this()
	{
		ownerIndex_ = other.ownerIndex_;
		userId_ = other.userId_;
		userExp_ = other.userExp_;
		portraitCostumeId_ = other.portraitCostumeId_;
		guildBaseInfo_ = ((other.guildBaseInfo_ != null) ? other.guildBaseInfo_.Clone() : null);
		baseInfo_ = ((other.baseInfo_ != null) ? other.baseInfo_.Clone() : null);
		titleId_ = other.titleId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PvpBattleRankUserInfo Clone()
	{
		return new PvpBattleRankUserInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PvpBattleRankUserInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PvpBattleRankUserInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (OwnerIndex == other.OwnerIndex && !(UserId != other.UserId) && UserExp == other.UserExp && PortraitCostumeId == other.PortraitCostumeId && object.Equals(GuildBaseInfo, other.GuildBaseInfo) && object.Equals(BaseInfo, other.BaseInfo) && TitleId == other.TitleId)
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
		if (OwnerIndex != 0L)
		{
			num ^= OwnerIndex.GetHashCode();
		}
		if (UserId.Length != 0)
		{
			num ^= UserId.GetHashCode();
		}
		if (UserExp != 0)
		{
			num ^= UserExp.GetHashCode();
		}
		if (PortraitCostumeId != 0)
		{
			num ^= PortraitCostumeId.GetHashCode();
		}
		if (guildBaseInfo_ != null)
		{
			num ^= GuildBaseInfo.GetHashCode();
		}
		if (baseInfo_ != null)
		{
			num ^= BaseInfo.GetHashCode();
		}
		if (TitleId != 0)
		{
			num ^= TitleId.GetHashCode();
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
		if (OwnerIndex != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(OwnerIndex);
		}
		if (UserId.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(UserId);
		}
		if (UserExp != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(UserExp);
		}
		if (PortraitCostumeId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(PortraitCostumeId);
		}
		if (guildBaseInfo_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(GuildBaseInfo);
		}
		if (baseInfo_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(BaseInfo);
		}
		if (TitleId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(TitleId);
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
		if (OwnerIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(OwnerIndex);
		}
		if (UserId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UserId);
		}
		if (UserExp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UserExp);
		}
		if (PortraitCostumeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PortraitCostumeId);
		}
		if (guildBaseInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GuildBaseInfo);
		}
		if (baseInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BaseInfo);
		}
		if (TitleId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TitleId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PvpBattleRankUserInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.OwnerIndex != 0L)
		{
			OwnerIndex = other.OwnerIndex;
		}
		if (other.UserId.Length != 0)
		{
			UserId = other.UserId;
		}
		if (other.UserExp != 0)
		{
			UserExp = other.UserExp;
		}
		if (other.PortraitCostumeId != 0)
		{
			PortraitCostumeId = other.PortraitCostumeId;
		}
		if (other.guildBaseInfo_ != null)
		{
			if (guildBaseInfo_ == null)
			{
				GuildBaseInfo = new GuildBaseDBInfo();
			}
			GuildBaseInfo.MergeFrom(other.GuildBaseInfo);
		}
		if (other.baseInfo_ != null)
		{
			if (baseInfo_ == null)
			{
				BaseInfo = new PvpBattleUserBaseInfo();
			}
			BaseInfo.MergeFrom(other.BaseInfo);
		}
		if (other.TitleId != 0)
		{
			TitleId = other.TitleId;
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
			case 8u:
				OwnerIndex = input.ReadInt64();
				break;
			case 18u:
				UserId = input.ReadString();
				break;
			case 24u:
				UserExp = input.ReadInt32();
				break;
			case 32u:
				PortraitCostumeId = input.ReadInt32();
				break;
			case 42u:
				if (guildBaseInfo_ == null)
				{
					GuildBaseInfo = new GuildBaseDBInfo();
				}
				input.ReadMessage(GuildBaseInfo);
				break;
			case 50u:
				if (baseInfo_ == null)
				{
					BaseInfo = new PvpBattleUserBaseInfo();
				}
				input.ReadMessage(BaseInfo);
				break;
			case 56u:
				TitleId = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
