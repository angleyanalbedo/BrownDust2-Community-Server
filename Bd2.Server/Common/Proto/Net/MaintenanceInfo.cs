using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MaintenanceInfo : IMessage<MaintenanceInfo>, IMessage, IEquatable<MaintenanceInfo>, IDeepCloneable<MaintenanceInfo>, IBufferMessage
{
	private static readonly MessageParser<MaintenanceInfo> _parser = new MessageParser<MaintenanceInfo>(() => new MaintenanceInfo());

	private UnknownFieldSet _unknownFields;

	public const int MarketTypeFieldNumber = 1;

	private int marketType_;

	public const int VersionFieldNumber = 2;

	private string version_ = "";

	public const int BundleVersionFieldNumber = 3;

	private string bundleVersion_ = "";

	public const int IsBundleUpdateFieldNumber = 4;

	private bool isBundleUpdate_;

	public const int MaintenanceTypeFieldNumber = 5;

	private int maintenanceType_;

	public const int DateFieldNumber = 6;

	private string date_ = "";

	public const int RegionListFieldNumber = 7;

	private string regionList_ = "";

	public const int UseDsaFieldNumber = 8;

	private int useDsa_;

	public const int MaintenanceUrlFieldNumber = 9;

	private string maintenanceUrl_ = "";

	public const int UseMaintenanceUrlFieldNumber = 10;

	private int useMaintenanceUrl_;

	public const int DownloadUrlFieldNumber = 11;

	private string downloadUrl_ = "";

	public const int NoticeFieldNumber = 12;

	private string notice_ = "";

	public const int BundleVersionSdFieldNumber = 13;

	private string bundleVersionSd_ = "";

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MaintenanceInfo> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MaintenanceInfoResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsBundleUpdate
	{
		get
		{
			return isBundleUpdate_;
		}
		set
		{
			isBundleUpdate_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MaintenanceType
	{
		get
		{
			return maintenanceType_;
		}
		set
		{
			maintenanceType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Date
	{
		get
		{
			return date_;
		}
		set
		{
			date_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string RegionList
	{
		get
		{
			return regionList_;
		}
		set
		{
			regionList_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int UseDsa
	{
		get
		{
			return useDsa_;
		}
		set
		{
			useDsa_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string MaintenanceUrl
	{
		get
		{
			return maintenanceUrl_;
		}
		set
		{
			maintenanceUrl_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int UseMaintenanceUrl
	{
		get
		{
			return useMaintenanceUrl_;
		}
		set
		{
			useMaintenanceUrl_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string DownloadUrl
	{
		get
		{
			return downloadUrl_;
		}
		set
		{
			downloadUrl_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Notice
	{
		get
		{
			return notice_;
		}
		set
		{
			notice_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string BundleVersionSd
	{
		get
		{
			return bundleVersionSd_;
		}
		set
		{
			bundleVersionSd_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MaintenanceInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MaintenanceInfo(MaintenanceInfo other)
		: this()
	{
		marketType_ = other.marketType_;
		version_ = other.version_;
		bundleVersion_ = other.bundleVersion_;
		isBundleUpdate_ = other.isBundleUpdate_;
		maintenanceType_ = other.maintenanceType_;
		date_ = other.date_;
		regionList_ = other.regionList_;
		useDsa_ = other.useDsa_;
		maintenanceUrl_ = other.maintenanceUrl_;
		useMaintenanceUrl_ = other.useMaintenanceUrl_;
		downloadUrl_ = other.downloadUrl_;
		notice_ = other.notice_;
		bundleVersionSd_ = other.bundleVersionSd_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MaintenanceInfo Clone()
	{
		return new MaintenanceInfo(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as MaintenanceInfo);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MaintenanceInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (MarketType == other.MarketType && !(Version != other.Version) && !(BundleVersion != other.BundleVersion) && IsBundleUpdate == other.IsBundleUpdate && MaintenanceType == other.MaintenanceType && !(Date != other.Date) && !(RegionList != other.RegionList) && UseDsa == other.UseDsa && !(MaintenanceUrl != other.MaintenanceUrl) && UseMaintenanceUrl == other.UseMaintenanceUrl && !(DownloadUrl != other.DownloadUrl) && !(Notice != other.Notice) && !(BundleVersionSd != other.BundleVersionSd))
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
		if (IsBundleUpdate)
		{
			num ^= IsBundleUpdate.GetHashCode();
		}
		if (MaintenanceType != 0)
		{
			num ^= MaintenanceType.GetHashCode();
		}
		if (Date.Length != 0)
		{
			num ^= Date.GetHashCode();
		}
		if (RegionList.Length != 0)
		{
			num ^= RegionList.GetHashCode();
		}
		if (UseDsa != 0)
		{
			num ^= UseDsa.GetHashCode();
		}
		if (MaintenanceUrl.Length != 0)
		{
			num ^= MaintenanceUrl.GetHashCode();
		}
		if (UseMaintenanceUrl != 0)
		{
			num ^= UseMaintenanceUrl.GetHashCode();
		}
		if (DownloadUrl.Length != 0)
		{
			num ^= DownloadUrl.GetHashCode();
		}
		if (Notice.Length != 0)
		{
			num ^= Notice.GetHashCode();
		}
		if (BundleVersionSd.Length != 0)
		{
			num ^= BundleVersionSd.GetHashCode();
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
		if (MarketType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(MarketType);
		}
		if (Version.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Version);
		}
		if (BundleVersion.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(BundleVersion);
		}
		if (IsBundleUpdate)
		{
			output.WriteRawTag(32);
			output.WriteBool(IsBundleUpdate);
		}
		if (MaintenanceType != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(MaintenanceType);
		}
		if (Date.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(Date);
		}
		if (RegionList.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(RegionList);
		}
		if (UseDsa != 0)
		{
			output.WriteRawTag(64);
			output.WriteSInt32(UseDsa);
		}
		if (MaintenanceUrl.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(MaintenanceUrl);
		}
		if (UseMaintenanceUrl != 0)
		{
			output.WriteRawTag(80);
			output.WriteSInt32(UseMaintenanceUrl);
		}
		if (DownloadUrl.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(DownloadUrl);
		}
		if (Notice.Length != 0)
		{
			output.WriteRawTag(98);
			output.WriteString(Notice);
		}
		if (BundleVersionSd.Length != 0)
		{
			output.WriteRawTag(106);
			output.WriteString(BundleVersionSd);
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
		if (MarketType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MarketType);
		}
		if (Version.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Version);
		}
		if (BundleVersion.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BundleVersion);
		}
		if (IsBundleUpdate)
		{
			num += 2;
		}
		if (MaintenanceType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaintenanceType);
		}
		if (Date.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Date);
		}
		if (RegionList.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(RegionList);
		}
		if (UseDsa != 0)
		{
			num += 1 + CodedOutputStream.ComputeSInt32Size(UseDsa);
		}
		if (MaintenanceUrl.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MaintenanceUrl);
		}
		if (UseMaintenanceUrl != 0)
		{
			num += 1 + CodedOutputStream.ComputeSInt32Size(UseMaintenanceUrl);
		}
		if (DownloadUrl.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DownloadUrl);
		}
		if (Notice.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Notice);
		}
		if (BundleVersionSd.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BundleVersionSd);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MaintenanceInfo other)
	{
		if (other != null)
		{
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
			if (other.IsBundleUpdate)
			{
				IsBundleUpdate = other.IsBundleUpdate;
			}
			if (other.MaintenanceType != 0)
			{
				MaintenanceType = other.MaintenanceType;
			}
			if (other.Date.Length != 0)
			{
				Date = other.Date;
			}
			if (other.RegionList.Length != 0)
			{
				RegionList = other.RegionList;
			}
			if (other.UseDsa != 0)
			{
				UseDsa = other.UseDsa;
			}
			if (other.MaintenanceUrl.Length != 0)
			{
				MaintenanceUrl = other.MaintenanceUrl;
			}
			if (other.UseMaintenanceUrl != 0)
			{
				UseMaintenanceUrl = other.UseMaintenanceUrl;
			}
			if (other.DownloadUrl.Length != 0)
			{
				DownloadUrl = other.DownloadUrl;
			}
			if (other.Notice.Length != 0)
			{
				Notice = other.Notice;
			}
			if (other.BundleVersionSd.Length != 0)
			{
				BundleVersionSd = other.BundleVersionSd;
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
				MarketType = input.ReadInt32();
				break;
			case 18u:
				Version = input.ReadString();
				break;
			case 26u:
				BundleVersion = input.ReadString();
				break;
			case 32u:
				IsBundleUpdate = input.ReadBool();
				break;
			case 40u:
				MaintenanceType = input.ReadInt32();
				break;
			case 50u:
				Date = input.ReadString();
				break;
			case 58u:
				RegionList = input.ReadString();
				break;
			case 64u:
				UseDsa = input.ReadSInt32();
				break;
			case 74u:
				MaintenanceUrl = input.ReadString();
				break;
			case 80u:
				UseMaintenanceUrl = input.ReadSInt32();
				break;
			case 90u:
				DownloadUrl = input.ReadString();
				break;
			case 98u:
				Notice = input.ReadString();
				break;
			case 106u:
				BundleVersionSd = input.ReadString();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
