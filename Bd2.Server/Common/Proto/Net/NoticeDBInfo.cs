using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class NoticeDBInfo : IMessage<NoticeDBInfo>, IMessage, IEquatable<NoticeDBInfo>, IDeepCloneable<NoticeDBInfo>, IBufferMessage
{
	private static readonly MessageParser<NoticeDBInfo> _parser = new MessageParser<NoticeDBInfo>(() => new NoticeDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int NoticeTypeFieldNumber = 2;

	private Define_NoticeType noticeType_;

	public const int TitleFieldNumber = 3;

	private string title_ = "";

	public const int ThumbnailFieldNumber = 4;

	private string thumbnail_ = "";

	public const int StartTimeFieldNumber = 5;

	private long startTime_;

	public const int EndTimeFieldNumber = 6;

	private long endTime_;

	public const int WebUrlFieldNumber = 7;

	private string webUrl_ = "";

	public const int NoticeContentsInfoFieldNumber = 8;

	private static readonly FieldCodec<NoticeContentsInfo> _repeated_noticeContentsInfo_codec = FieldCodec.ForMessage(66u, Bd2.Server.Common.Proto.Net.NoticeContentsInfo.Parser);

	private readonly RepeatedField<NoticeContentsInfo> noticeContentsInfo_ = new RepeatedField<NoticeContentsInfo>();

	public const int PromotionBannerIdFieldNumber = 9;

	private int promotionBannerId_;

	public const int IsPinFieldNumber = 10;

	private bool isPin_;

	public const int SortFieldNumber = 11;

	private int sort_;

	public const int SubTypeFieldNumber = 12;

	private int subType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NoticeDBInfo> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => NoticeDBInfoReflection.Descriptor.MessageTypes[1];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public Define_NoticeType NoticeType
	{
		get
		{
			return noticeType_;
		}
		set
		{
			noticeType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Title
	{
		get
		{
			return title_;
		}
		set
		{
			title_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Thumbnail
	{
		get
		{
			return thumbnail_;
		}
		set
		{
			thumbnail_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long StartTime
	{
		get
		{
			return startTime_;
		}
		set
		{
			startTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long EndTime
	{
		get
		{
			return endTime_;
		}
		set
		{
			endTime_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string WebUrl
	{
		get
		{
			return webUrl_;
		}
		set
		{
			webUrl_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NoticeContentsInfo> NoticeContentsInfo => noticeContentsInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PromotionBannerId
	{
		get
		{
			return promotionBannerId_;
		}
		set
		{
			promotionBannerId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsPin
	{
		get
		{
			return isPin_;
		}
		set
		{
			isPin_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Sort
	{
		get
		{
			return sort_;
		}
		set
		{
			sort_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SubType
	{
		get
		{
			return subType_;
		}
		set
		{
			subType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NoticeDBInfo()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public NoticeDBInfo(NoticeDBInfo other)
		: this()
	{
		id_ = other.id_;
		noticeType_ = other.noticeType_;
		title_ = other.title_;
		thumbnail_ = other.thumbnail_;
		startTime_ = other.startTime_;
		endTime_ = other.endTime_;
		webUrl_ = other.webUrl_;
		noticeContentsInfo_ = other.noticeContentsInfo_.Clone();
		promotionBannerId_ = other.promotionBannerId_;
		isPin_ = other.isPin_;
		sort_ = other.sort_;
		subType_ = other.subType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NoticeDBInfo Clone()
	{
		return new NoticeDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NoticeDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NoticeDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && NoticeType == other.NoticeType && !(Title != other.Title) && !(Thumbnail != other.Thumbnail) && StartTime == other.StartTime && EndTime == other.EndTime && !(WebUrl != other.WebUrl) && noticeContentsInfo_.Equals(other.noticeContentsInfo_) && PromotionBannerId == other.PromotionBannerId && IsPin == other.IsPin && Sort == other.Sort && SubType == other.SubType)
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
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (NoticeType != Define_NoticeType.NtNotice)
		{
			num ^= NoticeType.GetHashCode();
		}
		if (Title.Length != 0)
		{
			num ^= Title.GetHashCode();
		}
		if (Thumbnail.Length != 0)
		{
			num ^= Thumbnail.GetHashCode();
		}
		if (StartTime != 0L)
		{
			num ^= StartTime.GetHashCode();
		}
		if (EndTime != 0L)
		{
			num ^= EndTime.GetHashCode();
		}
		if (WebUrl.Length != 0)
		{
			num ^= WebUrl.GetHashCode();
		}
		num ^= noticeContentsInfo_.GetHashCode();
		if (PromotionBannerId != 0)
		{
			num ^= PromotionBannerId.GetHashCode();
		}
		if (IsPin)
		{
			num ^= IsPin.GetHashCode();
		}
		if (Sort != 0)
		{
			num ^= Sort.GetHashCode();
		}
		if (SubType != 0)
		{
			num ^= SubType.GetHashCode();
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
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (NoticeType != Define_NoticeType.NtNotice)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)NoticeType);
		}
		if (Title.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Title);
		}
		if (Thumbnail.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(Thumbnail);
		}
		if (StartTime != 0L)
		{
			output.WriteRawTag(40);
			output.WriteInt64(StartTime);
		}
		if (EndTime != 0L)
		{
			output.WriteRawTag(48);
			output.WriteInt64(EndTime);
		}
		if (WebUrl.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(WebUrl);
		}
		noticeContentsInfo_.WriteTo(ref output, _repeated_noticeContentsInfo_codec);
		if (PromotionBannerId != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(PromotionBannerId);
		}
		if (IsPin)
		{
			output.WriteRawTag(80);
			output.WriteBool(IsPin);
		}
		if (Sort != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(Sort);
		}
		if (SubType != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(SubType);
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
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (NoticeType != Define_NoticeType.NtNotice)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)NoticeType);
		}
		if (Title.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Title);
		}
		if (Thumbnail.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Thumbnail);
		}
		if (StartTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(StartTime);
		}
		if (EndTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(EndTime);
		}
		if (WebUrl.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(WebUrl);
		}
		num += noticeContentsInfo_.CalculateSize(_repeated_noticeContentsInfo_codec);
		if (PromotionBannerId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PromotionBannerId);
		}
		if (IsPin)
		{
			num += 2;
		}
		if (Sort != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Sort);
		}
		if (SubType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SubType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(NoticeDBInfo other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.NoticeType != Define_NoticeType.NtNotice)
			{
				NoticeType = other.NoticeType;
			}
			if (other.Title.Length != 0)
			{
				Title = other.Title;
			}
			if (other.Thumbnail.Length != 0)
			{
				Thumbnail = other.Thumbnail;
			}
			if (other.StartTime != 0L)
			{
				StartTime = other.StartTime;
			}
			if (other.EndTime != 0L)
			{
				EndTime = other.EndTime;
			}
			if (other.WebUrl.Length != 0)
			{
				WebUrl = other.WebUrl;
			}
			noticeContentsInfo_.Add(other.noticeContentsInfo_);
			if (other.PromotionBannerId != 0)
			{
				PromotionBannerId = other.PromotionBannerId;
			}
			if (other.IsPin)
			{
				IsPin = other.IsPin;
			}
			if (other.Sort != 0)
			{
				Sort = other.Sort;
			}
			if (other.SubType != 0)
			{
				SubType = other.SubType;
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
				Id = input.ReadInt32();
				break;
			case 16u:
				NoticeType = (Define_NoticeType)input.ReadEnum();
				break;
			case 26u:
				Title = input.ReadString();
				break;
			case 34u:
				Thumbnail = input.ReadString();
				break;
			case 40u:
				StartTime = input.ReadInt64();
				break;
			case 48u:
				EndTime = input.ReadInt64();
				break;
			case 58u:
				WebUrl = input.ReadString();
				break;
			case 66u:
				noticeContentsInfo_.AddEntriesFrom(ref input, _repeated_noticeContentsInfo_codec);
				break;
			case 72u:
				PromotionBannerId = input.ReadInt32();
				break;
			case 80u:
				IsPin = input.ReadBool();
				break;
			case 88u:
				Sort = input.ReadInt32();
				break;
			case 96u:
				SubType = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
