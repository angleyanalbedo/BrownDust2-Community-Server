using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class LoginUserResponse : IMessage<LoginUserResponse>, IMessage, IEquatable<LoginUserResponse>, IDeepCloneable<LoginUserResponse>, IBufferMessage
{
	private static readonly MessageParser<LoginUserResponse> _parser = new MessageParser<LoginUserResponse>(() => new LoginUserResponse());

	private UnknownFieldSet _unknownFields;

	public const int UserInfoFieldNumber = 1;

	private UserDBInfo userInfo_;

	public const int AccumulatedPaymentAmountFieldNumber = 2;

	private float accumulatedPaymentAmount_;

	public const int DateOfBirthFieldNumber = 3;

	private int dateOfBirth_;

	public const int RewardInfoBundleFieldNumber = 4;

	private RewardDBInfoBundle rewardInfoBundle_;

	public const int RepaymentCurrencyFieldNumber = 5;

	private static readonly FieldCodec<RewardDBInfo> _repeated_repaymentCurrency_codec = FieldCodec.ForMessage(42u, RewardDBInfo.Parser);

	private readonly RepeatedField<RewardDBInfo> repaymentCurrency_ = new RepeatedField<RewardDBInfo>();

	public const int UserGuildInfoFieldNumber = 6;

	private GuildMemberDBInfo userGuildInfo_;

	public const int GuildBaseInfoFieldNumber = 7;

	private GuildBaseDBInfo guildBaseInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LoginUserResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LoginUserResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UserDBInfo UserInfo
	{
		get
		{
			return userInfo_;
		}
		set
		{
			userInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public float AccumulatedPaymentAmount
	{
		get
		{
			return accumulatedPaymentAmount_;
		}
		set
		{
			accumulatedPaymentAmount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DateOfBirth
	{
		get
		{
			return dateOfBirth_;
		}
		set
		{
			dateOfBirth_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RewardDBInfoBundle RewardInfoBundle
	{
		get
		{
			return rewardInfoBundle_;
		}
		set
		{
			rewardInfoBundle_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<RewardDBInfo> RepaymentCurrency => repaymentCurrency_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildMemberDBInfo UserGuildInfo
	{
		get
		{
			return userGuildInfo_;
		}
		set
		{
			userGuildInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public LoginUserResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LoginUserResponse(LoginUserResponse other)
		: this()
	{
		userInfo_ = ((other.userInfo_ != null) ? other.userInfo_.Clone() : null);
		accumulatedPaymentAmount_ = other.accumulatedPaymentAmount_;
		dateOfBirth_ = other.dateOfBirth_;
		rewardInfoBundle_ = ((other.rewardInfoBundle_ != null) ? other.rewardInfoBundle_.Clone() : null);
		repaymentCurrency_ = other.repaymentCurrency_.Clone();
		userGuildInfo_ = ((other.userGuildInfo_ != null) ? other.userGuildInfo_.Clone() : null);
		guildBaseInfo_ = ((other.guildBaseInfo_ != null) ? other.guildBaseInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LoginUserResponse Clone()
	{
		return new LoginUserResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LoginUserResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(LoginUserResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(UserInfo, other.UserInfo) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(AccumulatedPaymentAmount, other.AccumulatedPaymentAmount) && DateOfBirth == other.DateOfBirth && object.Equals(RewardInfoBundle, other.RewardInfoBundle) && repaymentCurrency_.Equals(other.repaymentCurrency_) && object.Equals(UserGuildInfo, other.UserGuildInfo) && object.Equals(GuildBaseInfo, other.GuildBaseInfo))
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
		if (userInfo_ != null)
		{
			num ^= UserInfo.GetHashCode();
		}
		if (AccumulatedPaymentAmount != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(AccumulatedPaymentAmount);
		}
		if (DateOfBirth != 0)
		{
			num ^= DateOfBirth.GetHashCode();
		}
		if (rewardInfoBundle_ != null)
		{
			num ^= RewardInfoBundle.GetHashCode();
		}
		num ^= repaymentCurrency_.GetHashCode();
		if (userGuildInfo_ != null)
		{
			num ^= UserGuildInfo.GetHashCode();
		}
		if (guildBaseInfo_ != null)
		{
			num ^= GuildBaseInfo.GetHashCode();
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
		if (userInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(UserInfo);
		}
		if (AccumulatedPaymentAmount != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(AccumulatedPaymentAmount);
		}
		if (DateOfBirth != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(DateOfBirth);
		}
		if (rewardInfoBundle_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(RewardInfoBundle);
		}
		repaymentCurrency_.WriteTo(ref output, _repeated_repaymentCurrency_codec);
		if (userGuildInfo_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(UserGuildInfo);
		}
		if (guildBaseInfo_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(GuildBaseInfo);
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
		if (userInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(UserInfo);
		}
		if (AccumulatedPaymentAmount != 0f)
		{
			num += 5;
		}
		if (DateOfBirth != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DateOfBirth);
		}
		if (rewardInfoBundle_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RewardInfoBundle);
		}
		num += repaymentCurrency_.CalculateSize(_repeated_repaymentCurrency_codec);
		if (userGuildInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(UserGuildInfo);
		}
		if (guildBaseInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GuildBaseInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LoginUserResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.userInfo_ != null)
		{
			if (userInfo_ == null)
			{
				UserInfo = new UserDBInfo();
			}
			UserInfo.MergeFrom(other.UserInfo);
		}
		if (other.AccumulatedPaymentAmount != 0f)
		{
			AccumulatedPaymentAmount = other.AccumulatedPaymentAmount;
		}
		if (other.DateOfBirth != 0)
		{
			DateOfBirth = other.DateOfBirth;
		}
		if (other.rewardInfoBundle_ != null)
		{
			if (rewardInfoBundle_ == null)
			{
				RewardInfoBundle = new RewardDBInfoBundle();
			}
			RewardInfoBundle.MergeFrom(other.RewardInfoBundle);
		}
		repaymentCurrency_.Add(other.repaymentCurrency_);
		if (other.userGuildInfo_ != null)
		{
			if (userGuildInfo_ == null)
			{
				UserGuildInfo = new GuildMemberDBInfo();
			}
			UserGuildInfo.MergeFrom(other.UserGuildInfo);
		}
		if (other.guildBaseInfo_ != null)
		{
			if (guildBaseInfo_ == null)
			{
				GuildBaseInfo = new GuildBaseDBInfo();
			}
			GuildBaseInfo.MergeFrom(other.GuildBaseInfo);
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
			case 10u:
				if (userInfo_ == null)
				{
					UserInfo = new UserDBInfo();
				}
				input.ReadMessage(UserInfo);
				break;
			case 21u:
				AccumulatedPaymentAmount = input.ReadFloat();
				break;
			case 24u:
				DateOfBirth = input.ReadInt32();
				break;
			case 34u:
				if (rewardInfoBundle_ == null)
				{
					RewardInfoBundle = new RewardDBInfoBundle();
				}
				input.ReadMessage(RewardInfoBundle);
				break;
			case 42u:
				repaymentCurrency_.AddEntriesFrom(ref input, _repeated_repaymentCurrency_codec);
				break;
			case 50u:
				if (userGuildInfo_ == null)
				{
					UserGuildInfo = new GuildMemberDBInfo();
				}
				input.ReadMessage(UserGuildInfo);
				break;
			case 58u:
				if (guildBaseInfo_ == null)
				{
					GuildBaseInfo = new GuildBaseDBInfo();
				}
				input.ReadMessage(GuildBaseInfo);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
