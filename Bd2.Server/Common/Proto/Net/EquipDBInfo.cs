using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EquipDBInfo : IMessage<EquipDBInfo>, IMessage, IEquatable<EquipDBInfo>, IDeepCloneable<EquipDBInfo>, IBufferMessage
{
	private static readonly MessageParser<EquipDBInfo> _parser = new MessageParser<EquipDBInfo>(() => new EquipDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int InvenIndexFieldNumber = 1;

	private long invenIndex_;

	public const int UseCharFieldNumber = 2;

	private long useChar_;

	public const int KeepFlagFieldNumber = 3;

	private int keepFlag_;

	public const int LockFlagFieldNumber = 4;

	private int lockFlag_;

	public const int BaseInfoFieldNumber = 5;

	private EquipBaseInfo baseInfo_;

	public const int PictorialbookInfoFieldNumber = 6;

	private PictorialBookDBInfo pictorialbookInfo_;

	public const int SortIdFieldNumber = 7;

	private int sortId_;

	private bool isNew;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EquipDBInfo> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => EquipDBInfoReflection.Descriptor.MessageTypes[0];

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
	public long UseChar
	{
		get
		{
			return useChar_;
		}
		set
		{
			useChar_ = value;
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int LockFlag
	{
		get
		{
			return lockFlag_;
		}
		set
		{
			lockFlag_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EquipBaseInfo BaseInfo
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	public bool IsSelectSlot { get; set; }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipDBInfo(EquipDBInfo other)
		: this()
	{
		invenIndex_ = other.invenIndex_;
		useChar_ = other.useChar_;
		keepFlag_ = other.keepFlag_;
		lockFlag_ = other.lockFlag_;
		baseInfo_ = ((other.baseInfo_ != null) ? other.baseInfo_.Clone() : null);
		pictorialbookInfo_ = ((other.pictorialbookInfo_ != null) ? other.pictorialbookInfo_.Clone() : null);
		sortId_ = other.sortId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EquipDBInfo Clone()
	{
		return new EquipDBInfo(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as EquipDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EquipDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (InvenIndex == other.InvenIndex && UseChar == other.UseChar && KeepFlag == other.KeepFlag && LockFlag == other.LockFlag && object.Equals(BaseInfo, other.BaseInfo) && object.Equals(PictorialbookInfo, other.PictorialbookInfo) && SortId == other.SortId)
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
		if (UseChar != 0L)
		{
			num ^= UseChar.GetHashCode();
		}
		if (KeepFlag != 0)
		{
			num ^= KeepFlag.GetHashCode();
		}
		if (LockFlag != 0)
		{
			num ^= LockFlag.GetHashCode();
		}
		if (baseInfo_ != null)
		{
			num ^= BaseInfo.GetHashCode();
		}
		if (pictorialbookInfo_ != null)
		{
			num ^= PictorialbookInfo.GetHashCode();
		}
		if (SortId != 0)
		{
			num ^= SortId.GetHashCode();
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
		if (UseChar != 0L)
		{
			output.WriteRawTag(16);
			output.WriteInt64(UseChar);
		}
		if (KeepFlag != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(KeepFlag);
		}
		if (LockFlag != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(LockFlag);
		}
		if (baseInfo_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(BaseInfo);
		}
		if (pictorialbookInfo_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(PictorialbookInfo);
		}
		if (SortId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(SortId);
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
		if (UseChar != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(UseChar);
		}
		if (KeepFlag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(KeepFlag);
		}
		if (LockFlag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LockFlag);
		}
		if (baseInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BaseInfo);
		}
		if (pictorialbookInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PictorialbookInfo);
		}
		if (SortId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SortId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EquipDBInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.InvenIndex != 0L)
		{
			InvenIndex = other.InvenIndex;
		}
		if (other.UseChar != 0L)
		{
			UseChar = other.UseChar;
		}
		if (other.KeepFlag != 0)
		{
			KeepFlag = other.KeepFlag;
		}
		if (other.LockFlag != 0)
		{
			LockFlag = other.LockFlag;
		}
		if (other.baseInfo_ != null)
		{
			if (baseInfo_ == null)
			{
				BaseInfo = new EquipBaseInfo();
			}
			BaseInfo.MergeFrom(other.BaseInfo);
		}
		if (other.pictorialbookInfo_ != null)
		{
			if (pictorialbookInfo_ == null)
			{
				PictorialbookInfo = new PictorialBookDBInfo();
			}
			PictorialbookInfo.MergeFrom(other.PictorialbookInfo);
		}
		if (other.SortId != 0)
		{
			SortId = other.SortId;
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
				UseChar = input.ReadInt64();
				break;
			case 24u:
				KeepFlag = input.ReadInt32();
				break;
			case 32u:
				LockFlag = input.ReadInt32();
				break;
			case 42u:
				if (baseInfo_ == null)
				{
					BaseInfo = new EquipBaseInfo();
				}
				input.ReadMessage(BaseInfo);
				break;
			case 50u:
				if (pictorialbookInfo_ == null)
				{
					PictorialbookInfo = new PictorialBookDBInfo();
				}
				input.ReadMessage(PictorialbookInfo);
				break;
			case 56u:
				SortId = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
