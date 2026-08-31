using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class CharDBInfo : IMessage<CharDBInfo>, IMessage, IEquatable<CharDBInfo>, IDeepCloneable<CharDBInfo>, IBufferMessage
{
	private static readonly MessageParser<CharDBInfo> _parser = new MessageParser<CharDBInfo>(() => new CharDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int InvenIndexFieldNumber = 1;

	private long invenIndex_;

	public const int IdFieldNumber = 2;

	private int id_;

	public const int HpFieldNumber = 3;

	private long hp_;

	public const int LevelFieldNumber = 4;

	private int level_;

	public const int CostumeIdFieldNumber = 5;

	private int costumeId_;

	public const int ExpFieldNumber = 6;

	private int exp_;

	public const int UseCostumeFieldNumber = 7;

	private long useCostume_;

	public const int TalentLevelFieldNumber = 8;

	private int talentLevel_;

	public const int TalentExpFieldNumber = 9;

	private int talentExp_;

	public const int SolidarityRewardFieldNumber = 10;

	private int solidarityReward_;

	public const int ExpiryTimeFieldNumber = 11;

	private long expiryTime_;

	public const int PictorialbookInfoFieldNumber = 12;

	private static readonly FieldCodec<PictorialBookDBInfo> _repeated_pictorialbookInfo_codec = FieldCodec.ForMessage(98u, PictorialBookDBInfo.Parser);

	private readonly RepeatedField<PictorialBookDBInfo> pictorialbookInfo_ = new RepeatedField<PictorialBookDBInfo>();

	public const int ConnectPotentialCostumeFieldNumber = 13;

	private int connectPotentialCostume_;

	public bool IsNew { get; set; }

	public bool IsLive => Hp > 0;

	public long MiniGameHP { get; set; }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CharDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CharDBInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Hp
	{
		get
		{
			return hp_;
		}
		set
		{
			hp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CostumeId
	{
		get
		{
			return costumeId_;
		}
		set
		{
			costumeId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Exp
	{
		get
		{
			return exp_;
		}
		set
		{
			exp_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long UseCostume
	{
		get
		{
			return useCostume_;
		}
		set
		{
			useCostume_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TalentLevel
	{
		get
		{
			return talentLevel_;
		}
		set
		{
			talentLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TalentExp
	{
		get
		{
			return talentExp_;
		}
		set
		{
			talentExp_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SolidarityReward
	{
		get
		{
			return solidarityReward_;
		}
		set
		{
			solidarityReward_ = value;
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
	public RepeatedField<PictorialBookDBInfo> PictorialbookInfo => pictorialbookInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ConnectPotentialCostume
	{
		get
		{
			return connectPotentialCostume_;
		}
		set
		{
			connectPotentialCostume_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharDBInfo(CharDBInfo other)
		: this()
	{
		invenIndex_ = other.invenIndex_;
		id_ = other.id_;
		hp_ = other.hp_;
		level_ = other.level_;
		costumeId_ = other.costumeId_;
		exp_ = other.exp_;
		useCostume_ = other.useCostume_;
		talentLevel_ = other.talentLevel_;
		talentExp_ = other.talentExp_;
		solidarityReward_ = other.solidarityReward_;
		expiryTime_ = other.expiryTime_;
		pictorialbookInfo_ = other.pictorialbookInfo_.Clone();
		connectPotentialCostume_ = other.connectPotentialCostume_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharDBInfo Clone()
	{
		return new CharDBInfo(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as CharDBInfo);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CharDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (InvenIndex == other.InvenIndex && Id == other.Id && Hp == other.Hp && Level == other.Level && CostumeId == other.CostumeId && Exp == other.Exp && UseCostume == other.UseCostume && TalentLevel == other.TalentLevel && TalentExp == other.TalentExp && SolidarityReward == other.SolidarityReward && ExpiryTime == other.ExpiryTime && pictorialbookInfo_.Equals(other.pictorialbookInfo_) && ConnectPotentialCostume == other.ConnectPotentialCostume)
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
		if (InvenIndex != 0L)
		{
			num ^= InvenIndex.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (Hp != 0L)
		{
			num ^= Hp.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (CostumeId != 0)
		{
			num ^= CostumeId.GetHashCode();
		}
		if (Exp != 0)
		{
			num ^= Exp.GetHashCode();
		}
		if (UseCostume != 0L)
		{
			num ^= UseCostume.GetHashCode();
		}
		if (TalentLevel != 0)
		{
			num ^= TalentLevel.GetHashCode();
		}
		if (TalentExp != 0)
		{
			num ^= TalentExp.GetHashCode();
		}
		if (SolidarityReward != 0)
		{
			num ^= SolidarityReward.GetHashCode();
		}
		if (ExpiryTime != 0L)
		{
			num ^= ExpiryTime.GetHashCode();
		}
		num ^= pictorialbookInfo_.GetHashCode();
		if (ConnectPotentialCostume != 0)
		{
			num ^= ConnectPotentialCostume.GetHashCode();
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
		if (Hp != 0L)
		{
			output.WriteRawTag(24);
			output.WriteInt64(Hp);
		}
		if (Level != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Level);
		}
		if (CostumeId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(CostumeId);
		}
		if (Exp != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(Exp);
		}
		if (UseCostume != 0L)
		{
			output.WriteRawTag(56);
			output.WriteInt64(UseCostume);
		}
		if (TalentLevel != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(TalentLevel);
		}
		if (TalentExp != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(TalentExp);
		}
		if (SolidarityReward != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(SolidarityReward);
		}
		if (ExpiryTime != 0L)
		{
			output.WriteRawTag(88);
			output.WriteInt64(ExpiryTime);
		}
		pictorialbookInfo_.WriteTo(ref output, _repeated_pictorialbookInfo_codec);
		if (ConnectPotentialCostume != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(ConnectPotentialCostume);
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
		if (Hp != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(Hp);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Level);
		}
		if (CostumeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CostumeId);
		}
		if (Exp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Exp);
		}
		if (UseCostume != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(UseCostume);
		}
		if (TalentLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TalentLevel);
		}
		if (TalentExp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TalentExp);
		}
		if (SolidarityReward != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SolidarityReward);
		}
		if (ExpiryTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(ExpiryTime);
		}
		num += pictorialbookInfo_.CalculateSize(_repeated_pictorialbookInfo_codec);
		if (ConnectPotentialCostume != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConnectPotentialCostume);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CharDBInfo other)
	{
		if (other != null)
		{
			if (other.InvenIndex != 0L)
			{
				InvenIndex = other.InvenIndex;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Hp != 0L)
			{
				Hp = other.Hp;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.CostumeId != 0)
			{
				CostumeId = other.CostumeId;
			}
			if (other.Exp != 0)
			{
				Exp = other.Exp;
			}
			if (other.UseCostume != 0L)
			{
				UseCostume = other.UseCostume;
			}
			if (other.TalentLevel != 0)
			{
				TalentLevel = other.TalentLevel;
			}
			if (other.TalentExp != 0)
			{
				TalentExp = other.TalentExp;
			}
			if (other.SolidarityReward != 0)
			{
				SolidarityReward = other.SolidarityReward;
			}
			if (other.ExpiryTime != 0L)
			{
				ExpiryTime = other.ExpiryTime;
			}
			pictorialbookInfo_.Add(other.pictorialbookInfo_);
			if (other.ConnectPotentialCostume != 0)
			{
				ConnectPotentialCostume = other.ConnectPotentialCostume;
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
				InvenIndex = input.ReadInt64();
				break;
			case 16u:
				Id = input.ReadInt32();
				break;
			case 24u:
				Hp = input.ReadInt64();
				break;
			case 32u:
				Level = input.ReadInt32();
				break;
			case 40u:
				CostumeId = input.ReadInt32();
				break;
			case 48u:
				Exp = input.ReadInt32();
				break;
			case 56u:
				UseCostume = input.ReadInt64();
				break;
			case 64u:
				TalentLevel = input.ReadInt32();
				break;
			case 72u:
				TalentExp = input.ReadInt32();
				break;
			case 80u:
				SolidarityReward = input.ReadInt32();
				break;
			case 88u:
				ExpiryTime = input.ReadInt64();
				break;
			case 98u:
				pictorialbookInfo_.AddEntriesFrom(ref input, _repeated_pictorialbookInfo_codec);
				break;
			case 104u:
				ConnectPotentialCostume = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
