using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MailDBInfo : IMessage<MailDBInfo>, IMessage, IEquatable<MailDBInfo>, IDeepCloneable<MailDBInfo>, IBufferMessage
{
	private static readonly MessageParser<MailDBInfo> _parser = new MessageParser<MailDBInfo>(() => new MailDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int InvenIndexFieldNumber = 1;

	private long invenIndex_;

	public const int TypeFieldNumber = 2;

	private int type_;

	public const int MailIdFieldNumber = 3;

	private int mailId_;

	public const int SenderTextFieldNumber = 4;

	private string senderText_ = "";

	public const int TitleTextFieldNumber = 5;

	private string titleText_ = "";

	public const int MessageTextFieldNumber = 6;

	private string messageText_ = "";

	public const int RewardExpireTimeFieldNumber = 7;

	private long rewardExpireTime_;

	public const int ItemTypeFieldNumber = 8;

	private static readonly FieldCodec<int> _repeated_itemType_codec = FieldCodec.ForInt32(66u);

	private readonly RepeatedField<int> itemType_ = new RepeatedField<int>();

	public const int ItemIdFieldNumber = 9;

	private static readonly FieldCodec<int> _repeated_itemId_codec = FieldCodec.ForInt32(74u);

	private readonly RepeatedField<int> itemId_ = new RepeatedField<int>();

	public const int ItemCountFieldNumber = 10;

	private static readonly FieldCodec<int> _repeated_itemCount_codec = FieldCodec.ForInt32(82u);

	private readonly RepeatedField<int> itemCount_ = new RepeatedField<int>();

	public const int IsOpenFieldNumber = 11;

	private bool isOpen_;

	public const int OpenTimeFieldNumber = 12;

	private long openTime_;

	public const int CreateTimeFieldNumber = 13;

	private long createTime_;

	public const int HistoryDeleteTimeFieldNumber = 14;

	private long historyDeleteTime_;

	public const int IsCashFieldNumber = 15;

	private bool isCash_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MailDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MailDBInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long InvenIndex
	{
		get
		{
			return invenIndex_;
		}
		set
		{
			invenIndex_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MailId
	{
		get
		{
			return mailId_;
		}
		set
		{
			mailId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string SenderText
	{
		get
		{
			return senderText_;
		}
		set
		{
			senderText_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string TitleText
	{
		get
		{
			return titleText_;
		}
		set
		{
			titleText_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string MessageText
	{
		get
		{
			return messageText_;
		}
		set
		{
			messageText_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long RewardExpireTime
	{
		get
		{
			return rewardExpireTime_;
		}
		set
		{
			rewardExpireTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> ItemType => itemType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> ItemId => itemId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> ItemCount => itemCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsOpen
	{
		get
		{
			return isOpen_;
		}
		set
		{
			isOpen_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long OpenTime
	{
		get
		{
			return openTime_;
		}
		set
		{
			openTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CreateTime
	{
		get
		{
			return createTime_;
		}
		set
		{
			createTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long HistoryDeleteTime
	{
		get
		{
			return historyDeleteTime_;
		}
		set
		{
			historyDeleteTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsCash
	{
		get
		{
			return isCash_;
		}
		set
		{
			isCash_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MailDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MailDBInfo(MailDBInfo other)
		: this()
	{
		invenIndex_ = other.invenIndex_;
		type_ = other.type_;
		mailId_ = other.mailId_;
		senderText_ = other.senderText_;
		titleText_ = other.titleText_;
		messageText_ = other.messageText_;
		rewardExpireTime_ = other.rewardExpireTime_;
		itemType_ = other.itemType_.Clone();
		itemId_ = other.itemId_.Clone();
		itemCount_ = other.itemCount_.Clone();
		isOpen_ = other.isOpen_;
		openTime_ = other.openTime_;
		createTime_ = other.createTime_;
		historyDeleteTime_ = other.historyDeleteTime_;
		isCash_ = other.isCash_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MailDBInfo Clone()
	{
		return new MailDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MailDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MailDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (InvenIndex == other.InvenIndex && Type == other.Type && MailId == other.MailId && !(SenderText != other.SenderText) && !(TitleText != other.TitleText) && !(MessageText != other.MessageText) && RewardExpireTime == other.RewardExpireTime && itemType_.Equals(other.itemType_) && itemId_.Equals(other.itemId_) && itemCount_.Equals(other.itemCount_) && IsOpen == other.IsOpen && OpenTime == other.OpenTime && CreateTime == other.CreateTime && HistoryDeleteTime == other.HistoryDeleteTime && IsCash == other.IsCash)
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
		if (InvenIndex != 0L)
		{
			num ^= InvenIndex.GetHashCode();
		}
		if (Type != 0)
		{
			num ^= Type.GetHashCode();
		}
		if (MailId != 0)
		{
			num ^= MailId.GetHashCode();
		}
		if (SenderText.Length != 0)
		{
			num ^= SenderText.GetHashCode();
		}
		if (TitleText.Length != 0)
		{
			num ^= TitleText.GetHashCode();
		}
		if (MessageText.Length != 0)
		{
			num ^= MessageText.GetHashCode();
		}
		if (RewardExpireTime != 0L)
		{
			num ^= RewardExpireTime.GetHashCode();
		}
		num ^= itemType_.GetHashCode();
		num ^= itemId_.GetHashCode();
		num ^= itemCount_.GetHashCode();
		if (IsOpen)
		{
			num ^= IsOpen.GetHashCode();
		}
		if (OpenTime != 0L)
		{
			num ^= OpenTime.GetHashCode();
		}
		if (CreateTime != 0L)
		{
			num ^= CreateTime.GetHashCode();
		}
		if (HistoryDeleteTime != 0L)
		{
			num ^= HistoryDeleteTime.GetHashCode();
		}
		if (IsCash)
		{
			num ^= IsCash.GetHashCode();
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
		if (InvenIndex != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(InvenIndex);
		}
		if (Type != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Type);
		}
		if (MailId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(MailId);
		}
		if (SenderText.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(SenderText);
		}
		if (TitleText.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(TitleText);
		}
		if (MessageText.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(MessageText);
		}
		if (RewardExpireTime != 0L)
		{
			output.WriteRawTag(56);
			output.WriteInt64(RewardExpireTime);
		}
		itemType_.WriteTo(ref output, _repeated_itemType_codec);
		itemId_.WriteTo(ref output, _repeated_itemId_codec);
		itemCount_.WriteTo(ref output, _repeated_itemCount_codec);
		if (IsOpen)
		{
			output.WriteRawTag(88);
			output.WriteBool(IsOpen);
		}
		if (OpenTime != 0L)
		{
			output.WriteRawTag(96);
			output.WriteInt64(OpenTime);
		}
		if (CreateTime != 0L)
		{
			output.WriteRawTag(104);
			output.WriteInt64(CreateTime);
		}
		if (HistoryDeleteTime != 0L)
		{
			output.WriteRawTag(112);
			output.WriteInt64(HistoryDeleteTime);
		}
		if (IsCash)
		{
			output.WriteRawTag(120);
			output.WriteBool(IsCash);
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
		if (InvenIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(InvenIndex);
		}
		if (Type != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Type);
		}
		if (MailId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MailId);
		}
		if (SenderText.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SenderText);
		}
		if (TitleText.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TitleText);
		}
		if (MessageText.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MessageText);
		}
		if (RewardExpireTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(RewardExpireTime);
		}
		num += itemType_.CalculateSize(_repeated_itemType_codec);
		num += itemId_.CalculateSize(_repeated_itemId_codec);
		num += itemCount_.CalculateSize(_repeated_itemCount_codec);
		if (IsOpen)
		{
			num += 2;
		}
		if (OpenTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(OpenTime);
		}
		if (CreateTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(CreateTime);
		}
		if (HistoryDeleteTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(HistoryDeleteTime);
		}
		if (IsCash)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MailDBInfo other)
	{
		if (other != null)
		{
			if (other.InvenIndex != 0L)
			{
				InvenIndex = other.InvenIndex;
			}
			if (other.Type != 0)
			{
				Type = other.Type;
			}
			if (other.MailId != 0)
			{
				MailId = other.MailId;
			}
			if (other.SenderText.Length != 0)
			{
				SenderText = other.SenderText;
			}
			if (other.TitleText.Length != 0)
			{
				TitleText = other.TitleText;
			}
			if (other.MessageText.Length != 0)
			{
				MessageText = other.MessageText;
			}
			if (other.RewardExpireTime != 0L)
			{
				RewardExpireTime = other.RewardExpireTime;
			}
			itemType_.Add(other.itemType_);
			itemId_.Add(other.itemId_);
			itemCount_.Add(other.itemCount_);
			if (other.IsOpen)
			{
				IsOpen = other.IsOpen;
			}
			if (other.OpenTime != 0L)
			{
				OpenTime = other.OpenTime;
			}
			if (other.CreateTime != 0L)
			{
				CreateTime = other.CreateTime;
			}
			if (other.HistoryDeleteTime != 0L)
			{
				HistoryDeleteTime = other.HistoryDeleteTime;
			}
			if (other.IsCash)
			{
				IsCash = other.IsCash;
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
				InvenIndex = input.ReadInt64();
				break;
			case 16u:
				Type = input.ReadInt32();
				break;
			case 24u:
				MailId = input.ReadInt32();
				break;
			case 34u:
				SenderText = input.ReadString();
				break;
			case 42u:
				TitleText = input.ReadString();
				break;
			case 50u:
				MessageText = input.ReadString();
				break;
			case 56u:
				RewardExpireTime = input.ReadInt64();
				break;
			case 64u:
			case 66u:
				itemType_.AddEntriesFrom(ref input, _repeated_itemType_codec);
				break;
			case 72u:
			case 74u:
				itemId_.AddEntriesFrom(ref input, _repeated_itemId_codec);
				break;
			case 80u:
			case 82u:
				itemCount_.AddEntriesFrom(ref input, _repeated_itemCount_codec);
				break;
			case 88u:
				IsOpen = input.ReadBool();
				break;
			case 96u:
				OpenTime = input.ReadInt64();
				break;
			case 104u:
				CreateTime = input.ReadInt64();
				break;
			case 112u:
				HistoryDeleteTime = input.ReadInt64();
				break;
			case 120u:
				IsCash = input.ReadBool();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
