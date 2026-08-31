using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MaintenanceInfoRequest : IMessage<MaintenanceInfoRequest>, IMessage, IEquatable<MaintenanceInfoRequest>, IDeepCloneable<MaintenanceInfoRequest>, IBufferMessage
{
	private static readonly MessageParser<MaintenanceInfoRequest> _parser = new MessageParser<MaintenanceInfoRequest>(() => new MaintenanceInfoRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int MarketTypeFieldNumber = 2;

	private int marketType_;

	public const int VersionFieldNumber = 3;

	private string version_ = "";

	public const int BundleVersionFieldNumber = 4;

	private string bundleVersion_ = "";

	public const int AccessTokenFieldNumber = 5;

	private string accessToken_ = "";

	public const int LanguageTypeFieldNumber = 6;

	private int languageType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MaintenanceInfoRequest> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MaintenanceInfoRequestReflection.Descriptor.MessageTypes[0];

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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public string BundleVersion
	{
		get
		{
			return bundleVersion_;
		}
		set
		{
			bundleVersion_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public int LanguageType
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
	public MaintenanceInfoRequest()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MaintenanceInfoRequest(MaintenanceInfoRequest other)
		: this()
	{
		seq_ = other.seq_;
		marketType_ = other.marketType_;
		version_ = other.version_;
		bundleVersion_ = other.bundleVersion_;
		accessToken_ = other.accessToken_;
		languageType_ = other.languageType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MaintenanceInfoRequest Clone()
	{
		return new MaintenanceInfoRequest(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MaintenanceInfoRequest);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MaintenanceInfoRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && MarketType == other.MarketType && !(Version != other.Version) && !(BundleVersion != other.BundleVersion) && !(AccessToken != other.AccessToken) && LanguageType == other.LanguageType)
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
		if (MarketType != 0)
		{
			num ^= MarketType.GetHashCode();
		}
		if (Version.Length != 0)
		{
			num ^= Version.GetHashCode();
		}
		if (BundleVersion.Length != 0)
		{
			num ^= BundleVersion.GetHashCode();
		}
		if (AccessToken.Length != 0)
		{
			num ^= AccessToken.GetHashCode();
		}
		if (LanguageType != 0)
		{
			num ^= LanguageType.GetHashCode();
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
		if (MarketType != 0)
		{
			output.WriteRawTag(16);
			output.WriteSInt32(MarketType);
		}
		if (Version.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Version);
		}
		if (BundleVersion.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(BundleVersion);
		}
		if (AccessToken.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(AccessToken);
		}
		if (LanguageType != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(LanguageType);
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
		if (MarketType != 0)
		{
			num += 1 + CodedOutputStream.ComputeSInt32Size(MarketType);
		}
		if (Version.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Version);
		}
		if (BundleVersion.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BundleVersion);
		}
		if (AccessToken.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AccessToken);
		}
		if (LanguageType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LanguageType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MaintenanceInfoRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			if (other.MarketType != 0)
			{
				MarketType = other.MarketType;
			}
			if (other.Version.Length != 0)
			{
				Version = other.Version;
			}
			if (other.BundleVersion.Length != 0)
			{
				BundleVersion = other.BundleVersion;
			}
			if (other.AccessToken.Length != 0)
			{
				AccessToken = other.AccessToken;
			}
			if (other.LanguageType != 0)
			{
				LanguageType = other.LanguageType;
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
				MarketType = input.ReadSInt32();
				break;
			case 26u:
				Version = input.ReadString();
				break;
			case 34u:
				BundleVersion = input.ReadString();
				break;
			case 42u:
				AccessToken = input.ReadString();
				break;
			case 48u:
				LanguageType = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
