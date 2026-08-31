using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EquipSequenceUpgradeResponse : IMessage<EquipSequenceUpgradeResponse>, IMessage, IEquatable<EquipSequenceUpgradeResponse>, IDeepCloneable<EquipSequenceUpgradeResponse>, IBufferMessage
{
	private static readonly MessageParser<EquipSequenceUpgradeResponse> _parser = new MessageParser<EquipSequenceUpgradeResponse>(() => new EquipSequenceUpgradeResponse());

	private UnknownFieldSet _unknownFields;

	public const int EquipInfoFieldNumber = 1;

	private EquipDBInfo equipInfo_;

	public const int CharInfoFieldNumber = 2;

	private CharDBInfo charInfo_;

	public const int ResultTypeFieldNumber = 3;

	private Define_EquipUpgradeResultType resultType_;

	public const int TryCountFieldNumber = 4;

	private int tryCount_;

	public const int ConsumeItemInfoFieldNumber = 5;

	private static readonly FieldCodec<ItemDBInfo> _repeated_consumeItemInfo_codec = FieldCodec.ForMessage(42u, ItemDBInfo.Parser);

	private readonly RepeatedField<ItemDBInfo> consumeItemInfo_ = new RepeatedField<ItemDBInfo>();

	public const int LackItemInfoFieldNumber = 6;

	private static readonly FieldCodec<ItemDBInfo> _repeated_lackItemInfo_codec = FieldCodec.ForMessage(50u, ItemDBInfo.Parser);

	private readonly RepeatedField<ItemDBInfo> lackItemInfo_ = new RepeatedField<ItemDBInfo>();

	public const int UpgradeUsedGoldFieldNumber = 7;

	private int upgradeUsedGold_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EquipSequenceUpgradeResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => EquipSequenceUpgradeResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipDBInfo EquipInfo
	{
		get
		{
			return equipInfo_;
		}
		set
		{
			equipInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharDBInfo CharInfo
	{
		get
		{
			return charInfo_;
		}
		set
		{
			charInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Define_EquipUpgradeResultType ResultType
	{
		get
		{
			return resultType_;
		}
		set
		{
			resultType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TryCount
	{
		get
		{
			return tryCount_;
		}
		set
		{
			tryCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ItemDBInfo> ConsumeItemInfo => consumeItemInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ItemDBInfo> LackItemInfo => lackItemInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int UpgradeUsedGold
	{
		get
		{
			return upgradeUsedGold_;
		}
		set
		{
			upgradeUsedGold_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipSequenceUpgradeResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipSequenceUpgradeResponse(EquipSequenceUpgradeResponse other)
		: this()
	{
		equipInfo_ = ((other.equipInfo_ != null) ? other.equipInfo_.Clone() : null);
		charInfo_ = ((other.charInfo_ != null) ? other.charInfo_.Clone() : null);
		resultType_ = other.resultType_;
		tryCount_ = other.tryCount_;
		consumeItemInfo_ = other.consumeItemInfo_.Clone();
		lackItemInfo_ = other.lackItemInfo_.Clone();
		upgradeUsedGold_ = other.upgradeUsedGold_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipSequenceUpgradeResponse Clone()
	{
		return new EquipSequenceUpgradeResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as EquipSequenceUpgradeResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(EquipSequenceUpgradeResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(EquipInfo, other.EquipInfo) && object.Equals(CharInfo, other.CharInfo) && ResultType == other.ResultType && TryCount == other.TryCount && consumeItemInfo_.Equals(other.consumeItemInfo_) && lackItemInfo_.Equals(other.lackItemInfo_) && UpgradeUsedGold == other.UpgradeUsedGold)
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
		if (equipInfo_ != null)
		{
			num ^= EquipInfo.GetHashCode();
		}
		if (charInfo_ != null)
		{
			num ^= CharInfo.GetHashCode();
		}
		if (ResultType != Define_EquipUpgradeResultType.UpgradeSuccess)
		{
			num ^= ResultType.GetHashCode();
		}
		if (TryCount != 0)
		{
			num ^= TryCount.GetHashCode();
		}
		num ^= consumeItemInfo_.GetHashCode();
		num ^= lackItemInfo_.GetHashCode();
		if (UpgradeUsedGold != 0)
		{
			num ^= UpgradeUsedGold.GetHashCode();
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
		if (equipInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(EquipInfo);
		}
		if (charInfo_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(CharInfo);
		}
		if (ResultType != Define_EquipUpgradeResultType.UpgradeSuccess)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)ResultType);
		}
		if (TryCount != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(TryCount);
		}
		consumeItemInfo_.WriteTo(ref output, _repeated_consumeItemInfo_codec);
		lackItemInfo_.WriteTo(ref output, _repeated_lackItemInfo_codec);
		if (UpgradeUsedGold != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(UpgradeUsedGold);
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
		if (equipInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EquipInfo);
		}
		if (charInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CharInfo);
		}
		if (ResultType != Define_EquipUpgradeResultType.UpgradeSuccess)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ResultType);
		}
		if (TryCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TryCount);
		}
		num += consumeItemInfo_.CalculateSize(_repeated_consumeItemInfo_codec);
		num += lackItemInfo_.CalculateSize(_repeated_lackItemInfo_codec);
		if (UpgradeUsedGold != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UpgradeUsedGold);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(EquipSequenceUpgradeResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.equipInfo_ != null)
		{
			if (equipInfo_ == null)
			{
				EquipInfo = new EquipDBInfo();
			}
			EquipInfo.MergeFrom(other.EquipInfo);
		}
		if (other.charInfo_ != null)
		{
			if (charInfo_ == null)
			{
				CharInfo = new CharDBInfo();
			}
			CharInfo.MergeFrom(other.CharInfo);
		}
		if (other.ResultType != Define_EquipUpgradeResultType.UpgradeSuccess)
		{
			ResultType = other.ResultType;
		}
		if (other.TryCount != 0)
		{
			TryCount = other.TryCount;
		}
		consumeItemInfo_.Add(other.consumeItemInfo_);
		lackItemInfo_.Add(other.lackItemInfo_);
		if (other.UpgradeUsedGold != 0)
		{
			UpgradeUsedGold = other.UpgradeUsedGold;
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
			case 10u:
				if (equipInfo_ == null)
				{
					EquipInfo = new EquipDBInfo();
				}
				input.ReadMessage(EquipInfo);
				break;
			case 18u:
				if (charInfo_ == null)
				{
					CharInfo = new CharDBInfo();
				}
				input.ReadMessage(CharInfo);
				break;
			case 24u:
				ResultType = (Define_EquipUpgradeResultType)input.ReadEnum();
				break;
			case 32u:
				TryCount = input.ReadInt32();
				break;
			case 42u:
				consumeItemInfo_.AddEntriesFrom(ref input, _repeated_consumeItemInfo_codec);
				break;
			case 50u:
				lackItemInfo_.AddEntriesFrom(ref input, _repeated_lackItemInfo_codec);
				break;
			case 56u:
				UpgradeUsedGold = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
