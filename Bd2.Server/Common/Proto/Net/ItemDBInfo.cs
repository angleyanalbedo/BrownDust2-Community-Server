using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class ItemDBInfo : IMessage<ItemDBInfo>, IMessage, IEquatable<ItemDBInfo>, IDeepCloneable<ItemDBInfo>, IBufferMessage
{
	private bool isNew;

	private static readonly MessageParser<ItemDBInfo> _parser = new MessageParser<ItemDBInfo>(() => new ItemDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int InvenIndexFieldNumber = 1;

	private long invenIndex_;

	public const int IdFieldNumber = 2;

	private int id_;

	public const int TypeFieldNumber = 3;

	private int type_;

	public const int CountFieldNumber = 4;

	private int count_;

	public const int KeepFlagFieldNumber = 5;

	private int keepFlag_;

	public const int TimeValueFieldNumber = 6;

	private long timeValue_;

	public const int PictorialbookInfoFieldNumber = 7;

	private PictorialBookDBInfo pictorialbookInfo_;

	public const int ExpiryTimeFieldNumber = 8;

	private long expiryTime_;

	public const int SortIdFieldNumber = 9;

	private int sortId_;

	public const int UseCountFieldNumber = 10;

	private int useCount_;

	public bool IsNew
	{
		get
		{
			return isNew;
		}
		set
		{
			isNew = value;
		}
	}

	public bool IsDisableSlot { get; set; }

	public int SortType { get; set; }

	public int SortNumber { get; set; }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ItemDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ItemDBInfoReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Count
	{
		get
		{
			return count_;
		}
		set
		{
			count_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int KeepFlag
	{
		get
		{
			return keepFlag_;
		}
		set
		{
			keepFlag_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long TimeValue
	{
		get
		{
			return timeValue_;
		}
		set
		{
			timeValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PictorialBookDBInfo PictorialbookInfo
	{
		get
		{
			return pictorialbookInfo_;
		}
		set
		{
			pictorialbookInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long ExpiryTime
	{
		get
		{
			return expiryTime_;
		}
		set
		{
			expiryTime_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SortId
	{
		get
		{
			return sortId_;
		}
		set
		{
			sortId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int UseCount
	{
		get
		{
			return useCount_;
		}
		set
		{
			useCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemDBInfo(ItemDBInfo other)
		: this()
	{
		invenIndex_ = other.invenIndex_;
		id_ = other.id_;
		type_ = other.type_;
		count_ = other.count_;
		keepFlag_ = other.keepFlag_;
		timeValue_ = other.timeValue_;
		pictorialbookInfo_ = ((other.pictorialbookInfo_ != null) ? other.pictorialbookInfo_.Clone() : null);
		expiryTime_ = other.expiryTime_;
		sortId_ = other.sortId_;
		useCount_ = other.useCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemDBInfo Clone()
	{
		return new ItemDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ItemDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ItemDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (InvenIndex == other.InvenIndex && Id == other.Id && Type == other.Type && Count == other.Count && KeepFlag == other.KeepFlag && TimeValue == other.TimeValue && object.Equals(PictorialbookInfo, other.PictorialbookInfo) && ExpiryTime == other.ExpiryTime && SortId == other.SortId && UseCount == other.UseCount)
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
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (Type != 0)
		{
			num ^= Type.GetHashCode();
		}
		if (Count != 0)
		{
			num ^= Count.GetHashCode();
		}
		if (KeepFlag != 0)
		{
			num ^= KeepFlag.GetHashCode();
		}
		if (TimeValue != 0L)
		{
			num ^= TimeValue.GetHashCode();
		}
		if (pictorialbookInfo_ != null)
		{
			num ^= PictorialbookInfo.GetHashCode();
		}
		if (ExpiryTime != 0L)
		{
			num ^= ExpiryTime.GetHashCode();
		}
		if (SortId != 0)
		{
			num ^= SortId.GetHashCode();
		}
		if (UseCount != 0)
		{
			num ^= UseCount.GetHashCode();
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
		if (InvenIndex != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(InvenIndex);
		}
		if (Id != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Id);
		}
		if (Type != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Type);
		}
		if (Count != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Count);
		}
		if (KeepFlag != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(KeepFlag);
		}
		if (TimeValue != 0L)
		{
			output.WriteRawTag(48);
			output.WriteInt64(TimeValue);
		}
		if (pictorialbookInfo_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(PictorialbookInfo);
		}
		if (ExpiryTime != 0L)
		{
			output.WriteRawTag(64);
			output.WriteInt64(ExpiryTime);
		}
		if (SortId != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(SortId);
		}
		if (UseCount != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(UseCount);
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
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (Type != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Type);
		}
		if (Count != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Count);
		}
		if (KeepFlag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(KeepFlag);
		}
		if (TimeValue != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(TimeValue);
		}
		if (pictorialbookInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PictorialbookInfo);
		}
		if (ExpiryTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(ExpiryTime);
		}
		if (SortId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SortId);
		}
		if (UseCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UseCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ItemDBInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.InvenIndex != 0L)
		{
			InvenIndex = other.InvenIndex;
		}
		if (other.Id != 0)
		{
			Id = other.Id;
		}
		if (other.Type != 0)
		{
			Type = other.Type;
		}
		if (other.Count != 0)
		{
			Count = other.Count;
		}
		if (other.KeepFlag != 0)
		{
			KeepFlag = other.KeepFlag;
		}
		if (other.TimeValue != 0L)
		{
			TimeValue = other.TimeValue;
		}
		if (other.pictorialbookInfo_ != null)
		{
			if (pictorialbookInfo_ == null)
			{
				PictorialbookInfo = new PictorialBookDBInfo();
			}
			PictorialbookInfo.MergeFrom(other.PictorialbookInfo);
		}
		if (other.ExpiryTime != 0L)
		{
			ExpiryTime = other.ExpiryTime;
		}
		if (other.SortId != 0)
		{
			SortId = other.SortId;
		}
		if (other.UseCount != 0)
		{
			UseCount = other.UseCount;
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
				InvenIndex = input.ReadInt64();
				break;
			case 16u:
				Id = input.ReadInt32();
				break;
			case 24u:
				Type = input.ReadInt32();
				break;
			case 32u:
				Count = input.ReadInt32();
				break;
			case 40u:
				KeepFlag = input.ReadInt32();
				break;
			case 48u:
				TimeValue = input.ReadInt64();
				break;
			case 58u:
				if (pictorialbookInfo_ == null)
				{
					PictorialbookInfo = new PictorialBookDBInfo();
				}
				input.ReadMessage(PictorialbookInfo);
				break;
			case 64u:
				ExpiryTime = input.ReadInt64();
				break;
			case 72u:
				SortId = input.ReadInt32();
				break;
			case 80u:
				UseCount = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
