using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class LoginUserRequest : IMessage<LoginUserRequest>, IMessage, IEquatable<LoginUserRequest>, IDeepCloneable<LoginUserRequest>, IBufferMessage
{
	private static readonly MessageParser<LoginUserRequest> _parser = new MessageParser<LoginUserRequest>(() => new LoginUserRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int AccessTokenFieldNumber = 2;

	private string accessToken_ = "";

	public const int MarketTypeFieldNumber = 3;

	private int marketType_;

	public const int VersionFieldNumber = 4;

	private string version_ = "";

	public const int UserOsFieldNumber = 5;

	private string userOs_ = "";

	public const int EnvInfoFieldNumber = 6;

	private EnvInfo envInfo_;

	public const int LanguageTypeFieldNumber = 7;

	private Define_LanguageType languageType_;

	public const int ResourceDownloadTypeFieldNumber = 8;

	private int resourceDownloadType_;

	public const int LanguageSoundTypeFieldNumber = 9;

	private Define_LanguageType languageSoundType_;

	public const int ScreenFixTypeFieldNumber = 10;

	private int screenFixType_;

	public const int BundleOptionTypeFieldNumber = 11;

	private Define_BundleOptionType bundleOptionType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LoginUserRequest> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LoginUserRequestReflection.Descriptor.MessageTypes[0];

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
	public string AccessToken
	{
		get
		{
			return accessToken_;
		}
		set
		{
			accessToken_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MarketType
	{
		get
		{
			return marketType_;
		}
		set
		{
			marketType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Version
	{
		get
		{
			return version_;
		}
		set
		{
			version_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string UserOs
	{
		get
		{
			return userOs_;
		}
		set
		{
			userOs_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnvInfo EnvInfo
	{
		get
		{
			return envInfo_;
		}
		set
		{
			envInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Define_LanguageType LanguageType
	{
		get
		{
			return languageType_;
		}
		set
		{
			languageType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ResourceDownloadType
	{
		get
		{
			return resourceDownloadType_;
		}
		set
		{
			resourceDownloadType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Define_LanguageType LanguageSoundType
	{
		get
		{
			return languageSoundType_;
		}
		set
		{
			languageSoundType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ScreenFixType
	{
		get
		{
			return screenFixType_;
		}
		set
		{
			screenFixType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Define_BundleOptionType BundleOptionType
	{
		get
		{
			return bundleOptionType_;
		}
		set
		{
			bundleOptionType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public LoginUserRequest()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public LoginUserRequest(LoginUserRequest other)
		: this()
	{
		seq_ = other.seq_;
		accessToken_ = other.accessToken_;
		marketType_ = other.marketType_;
		version_ = other.version_;
		userOs_ = other.userOs_;
		envInfo_ = ((other.envInfo_ != null) ? other.envInfo_.Clone() : null);
		languageType_ = other.languageType_;
		resourceDownloadType_ = other.resourceDownloadType_;
		languageSoundType_ = other.languageSoundType_;
		screenFixType_ = other.screenFixType_;
		bundleOptionType_ = other.bundleOptionType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public LoginUserRequest Clone()
	{
		return new LoginUserRequest(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as LoginUserRequest);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LoginUserRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && !(AccessToken != other.AccessToken) && MarketType == other.MarketType && !(Version != other.Version) && !(UserOs != other.UserOs) && object.Equals(EnvInfo, other.EnvInfo) && LanguageType == other.LanguageType && ResourceDownloadType == other.ResourceDownloadType && LanguageSoundType == other.LanguageSoundType && ScreenFixType == other.ScreenFixType && BundleOptionType == other.BundleOptionType)
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
		if (AccessToken.Length != 0)
		{
			num ^= AccessToken.GetHashCode();
		}
		if (MarketType != 0)
		{
			num ^= MarketType.GetHashCode();
		}
		if (Version.Length != 0)
		{
			num ^= Version.GetHashCode();
		}
		if (UserOs.Length != 0)
		{
			num ^= UserOs.GetHashCode();
		}
		if (envInfo_ != null)
		{
			num ^= EnvInfo.GetHashCode();
		}
		if (LanguageType != Define_LanguageType.LangNone)
		{
			num ^= LanguageType.GetHashCode();
		}
		if (ResourceDownloadType != 0)
		{
			num ^= ResourceDownloadType.GetHashCode();
		}
		if (LanguageSoundType != Define_LanguageType.LangNone)
		{
			num ^= LanguageSoundType.GetHashCode();
		}
		if (ScreenFixType != 0)
		{
			num ^= ScreenFixType.GetHashCode();
		}
		if (BundleOptionType != Define_BundleOptionType.BundleOptionTypeNone)
		{
			num ^= BundleOptionType.GetHashCode();
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
		if (Seq != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Seq);
		}
		if (AccessToken.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(AccessToken);
		}
		if (MarketType != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(MarketType);
		}
		if (Version.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(Version);
		}
		if (UserOs.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(UserOs);
		}
		if (envInfo_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(EnvInfo);
		}
		if (LanguageType != Define_LanguageType.LangNone)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)LanguageType);
		}
		if (ResourceDownloadType != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(ResourceDownloadType);
		}
		if (LanguageSoundType != Define_LanguageType.LangNone)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)LanguageSoundType);
		}
		if (ScreenFixType != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(ScreenFixType);
		}
		if (BundleOptionType != Define_BundleOptionType.BundleOptionTypeNone)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)BundleOptionType);
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
		if (AccessToken.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AccessToken);
		}
		if (MarketType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MarketType);
		}
		if (Version.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Version);
		}
		if (UserOs.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UserOs);
		}
		if (envInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EnvInfo);
		}
		if (LanguageType != Define_LanguageType.LangNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)LanguageType);
		}
		if (ResourceDownloadType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ResourceDownloadType);
		}
		if (LanguageSoundType != Define_LanguageType.LangNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)LanguageSoundType);
		}
		if (ScreenFixType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ScreenFixType);
		}
		if (BundleOptionType != Define_BundleOptionType.BundleOptionTypeNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)BundleOptionType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(LoginUserRequest other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Seq != 0)
		{
			Seq = other.Seq;
		}
		if (other.AccessToken.Length != 0)
		{
			AccessToken = other.AccessToken;
		}
		if (other.MarketType != 0)
		{
			MarketType = other.MarketType;
		}
		if (other.Version.Length != 0)
		{
			Version = other.Version;
		}
		if (other.UserOs.Length != 0)
		{
			UserOs = other.UserOs;
		}
		if (other.envInfo_ != null)
		{
			if (envInfo_ == null)
			{
				EnvInfo = new EnvInfo();
			}
			EnvInfo.MergeFrom(other.EnvInfo);
		}
		if (other.LanguageType != Define_LanguageType.LangNone)
		{
			LanguageType = other.LanguageType;
		}
		if (other.ResourceDownloadType != 0)
		{
			ResourceDownloadType = other.ResourceDownloadType;
		}
		if (other.LanguageSoundType != Define_LanguageType.LangNone)
		{
			LanguageSoundType = other.LanguageSoundType;
		}
		if (other.ScreenFixType != 0)
		{
			ScreenFixType = other.ScreenFixType;
		}
		if (other.BundleOptionType != Define_BundleOptionType.BundleOptionTypeNone)
		{
			BundleOptionType = other.BundleOptionType;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 18u:
				AccessToken = input.ReadString();
				break;
			case 24u:
				MarketType = input.ReadInt32();
				break;
			case 34u:
				Version = input.ReadString();
				break;
			case 42u:
				UserOs = input.ReadString();
				break;
			case 50u:
				if (envInfo_ == null)
				{
					EnvInfo = new EnvInfo();
				}
				input.ReadMessage(EnvInfo);
				break;
			case 56u:
				LanguageType = (Define_LanguageType)input.ReadEnum();
				break;
			case 64u:
				ResourceDownloadType = input.ReadInt32();
				break;
			case 72u:
				LanguageSoundType = (Define_LanguageType)input.ReadEnum();
				break;
			case 80u:
				ScreenFixType = input.ReadInt32();
				break;
			case 88u:
				BundleOptionType = (Define_BundleOptionType)input.ReadEnum();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
