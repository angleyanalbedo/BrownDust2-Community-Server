using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class CostumeConceptInfoTable : IMessage<CostumeConceptInfoTable>, IMessage, IEquatable<CostumeConceptInfoTable>, IDeepCloneable<CostumeConceptInfoTable>, IBufferMessage
{
	private static readonly MessageParser<CostumeConceptInfoTable> _parser = new MessageParser<CostumeConceptInfoTable>(() => new CostumeConceptInfoTable());

	private UnknownFieldSet _unknownFields;

	public const int AgeProfileTextIdFieldNumber = 1;

	private int ageProfileTextId_;

	public const int AssociationProfileTextIdFieldNumber = 2;

	private int associationProfileTextId_;

	public const int BirthDayProfileTextIdFieldNumber = 3;

	private int birthDayProfileTextId_;

	public const int CutSceneDialogProfileTextIdFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_cutSceneDialogProfileTextId_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> cutSceneDialogProfileTextId_ = new RepeatedField<int>();

	public const int CutSceneDialogVoiceResourceNameFieldNumber = 5;

	private static readonly FieldCodec<string> _repeated_cutSceneDialogVoiceResourceName_codec = FieldCodec.ForString(42u);

	private readonly RepeatedField<string> cutSceneDialogVoiceResourceName_ = new RepeatedField<string>();

	public const int DislikeProfileTextIdFieldNumber = 6;

	private int dislikeProfileTextId_;

	public const int FavoriteProfileTextIdFieldNumber = 7;

	private int favoriteProfileTextId_;

	public const int GeneralDialogProfileTextIdFieldNumber = 8;

	private static readonly FieldCodec<int> _repeated_generalDialogProfileTextId_codec = FieldCodec.ForInt32(66u);

	private readonly RepeatedField<int> generalDialogProfileTextId_ = new RepeatedField<int>();

	public const int GeneralDialogVoiceResourceNameFieldNumber = 9;

	private static readonly FieldCodec<string> _repeated_generalDialogVoiceResourceName_codec = FieldCodec.ForString(74u);

	private readonly RepeatedField<string> generalDialogVoiceResourceName_ = new RepeatedField<string>();

	public const int HeightProfileTextIdFieldNumber = 10;

	private int heightProfileTextId_;

	public const int HobbyProfileTextIdFieldNumber = 11;

	private int hobbyProfileTextId_;

	public const int IdFieldNumber = 12;

	private int id_;

	public const int PreciousProfileTextIdFieldNumber = 13;

	private int preciousProfileTextId_;

	public const int Rumor1ProfileTextIdFieldNumber = 14;

	private int rumor1ProfileTextId_;

	public const int Rumor2ProfileTextIdFieldNumber = 15;

	private int rumor2ProfileTextId_;

	public const int SkillDialogProfileTextIdFieldNumber = 16;

	private static readonly FieldCodec<int> _repeated_skillDialogProfileTextId_codec = FieldCodec.ForInt32(130u);

	private readonly RepeatedField<int> skillDialogProfileTextId_ = new RepeatedField<int>();

	public const int SkillDialogVoiceResourceNameFieldNumber = 17;

	private static readonly FieldCodec<string> _repeated_skillDialogVoiceResourceName_codec = FieldCodec.ForString(138u);

	private readonly RepeatedField<string> skillDialogVoiceResourceName_ = new RepeatedField<string>();

	public const int SummaryProfileTextIdFieldNumber = 18;

	private int summaryProfileTextId_;

	public const int TalentDialogProfileTextIdFieldNumber = 19;

	private static readonly FieldCodec<int> _repeated_talentDialogProfileTextId_codec = FieldCodec.ForInt32(154u);

	private readonly RepeatedField<int> talentDialogProfileTextId_ = new RepeatedField<int>();

	public const int TalentDialogVoiceResourceNameFieldNumber = 20;

	private static readonly FieldCodec<string> _repeated_talentDialogVoiceResourceName_codec = FieldCodec.ForString(162u);

	private readonly RepeatedField<string> talentDialogVoiceResourceName_ = new RepeatedField<string>();

	public const int VictoryDialogProfileTextIdFieldNumber = 21;

	private static readonly FieldCodec<int> _repeated_victoryDialogProfileTextId_codec = FieldCodec.ForInt32(170u);

	private readonly RepeatedField<int> victoryDialogProfileTextId_ = new RepeatedField<int>();

	public const int VictoryDialogVoiceResourceNameFieldNumber = 22;

	private static readonly FieldCodec<string> _repeated_victoryDialogVoiceResourceName_codec = FieldCodec.ForString(178u);

	private readonly RepeatedField<string> victoryDialogVoiceResourceName_ = new RepeatedField<string>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CostumeConceptInfoTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CostumeConceptInfoTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int AgeProfileTextId
	{
		get
		{
			return ageProfileTextId_;
		}
		set
		{
			ageProfileTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AssociationProfileTextId
	{
		get
		{
			return associationProfileTextId_;
		}
		set
		{
			associationProfileTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BirthDayProfileTextId
	{
		get
		{
			return birthDayProfileTextId_;
		}
		set
		{
			birthDayProfileTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> CutSceneDialogProfileTextId => cutSceneDialogProfileTextId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<string> CutSceneDialogVoiceResourceName => cutSceneDialogVoiceResourceName_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int DislikeProfileTextId
	{
		get
		{
			return dislikeProfileTextId_;
		}
		set
		{
			dislikeProfileTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FavoriteProfileTextId
	{
		get
		{
			return favoriteProfileTextId_;
		}
		set
		{
			favoriteProfileTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> GeneralDialogProfileTextId => generalDialogProfileTextId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<string> GeneralDialogVoiceResourceName => generalDialogVoiceResourceName_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int HeightProfileTextId
	{
		get
		{
			return heightProfileTextId_;
		}
		set
		{
			heightProfileTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int HobbyProfileTextId
	{
		get
		{
			return hobbyProfileTextId_;
		}
		set
		{
			hobbyProfileTextId_ = value;
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
	public int PreciousProfileTextId
	{
		get
		{
			return preciousProfileTextId_;
		}
		set
		{
			preciousProfileTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Rumor1ProfileTextId
	{
		get
		{
			return rumor1ProfileTextId_;
		}
		set
		{
			rumor1ProfileTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Rumor2ProfileTextId
	{
		get
		{
			return rumor2ProfileTextId_;
		}
		set
		{
			rumor2ProfileTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> SkillDialogProfileTextId => skillDialogProfileTextId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<string> SkillDialogVoiceResourceName => skillDialogVoiceResourceName_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SummaryProfileTextId
	{
		get
		{
			return summaryProfileTextId_;
		}
		set
		{
			summaryProfileTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> TalentDialogProfileTextId => talentDialogProfileTextId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<string> TalentDialogVoiceResourceName => talentDialogVoiceResourceName_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> VictoryDialogProfileTextId => victoryDialogProfileTextId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<string> VictoryDialogVoiceResourceName => victoryDialogVoiceResourceName_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CostumeConceptInfoTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CostumeConceptInfoTable(CostumeConceptInfoTable other)
		: this()
	{
		ageProfileTextId_ = other.ageProfileTextId_;
		associationProfileTextId_ = other.associationProfileTextId_;
		birthDayProfileTextId_ = other.birthDayProfileTextId_;
		cutSceneDialogProfileTextId_ = other.cutSceneDialogProfileTextId_.Clone();
		cutSceneDialogVoiceResourceName_ = other.cutSceneDialogVoiceResourceName_.Clone();
		dislikeProfileTextId_ = other.dislikeProfileTextId_;
		favoriteProfileTextId_ = other.favoriteProfileTextId_;
		generalDialogProfileTextId_ = other.generalDialogProfileTextId_.Clone();
		generalDialogVoiceResourceName_ = other.generalDialogVoiceResourceName_.Clone();
		heightProfileTextId_ = other.heightProfileTextId_;
		hobbyProfileTextId_ = other.hobbyProfileTextId_;
		id_ = other.id_;
		preciousProfileTextId_ = other.preciousProfileTextId_;
		rumor1ProfileTextId_ = other.rumor1ProfileTextId_;
		rumor2ProfileTextId_ = other.rumor2ProfileTextId_;
		skillDialogProfileTextId_ = other.skillDialogProfileTextId_.Clone();
		skillDialogVoiceResourceName_ = other.skillDialogVoiceResourceName_.Clone();
		summaryProfileTextId_ = other.summaryProfileTextId_;
		talentDialogProfileTextId_ = other.talentDialogProfileTextId_.Clone();
		talentDialogVoiceResourceName_ = other.talentDialogVoiceResourceName_.Clone();
		victoryDialogProfileTextId_ = other.victoryDialogProfileTextId_.Clone();
		victoryDialogVoiceResourceName_ = other.victoryDialogVoiceResourceName_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CostumeConceptInfoTable Clone()
	{
		return new CostumeConceptInfoTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CostumeConceptInfoTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CostumeConceptInfoTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (AgeProfileTextId == other.AgeProfileTextId && AssociationProfileTextId == other.AssociationProfileTextId && BirthDayProfileTextId == other.BirthDayProfileTextId && cutSceneDialogProfileTextId_.Equals(other.cutSceneDialogProfileTextId_) && cutSceneDialogVoiceResourceName_.Equals(other.cutSceneDialogVoiceResourceName_) && DislikeProfileTextId == other.DislikeProfileTextId && FavoriteProfileTextId == other.FavoriteProfileTextId && generalDialogProfileTextId_.Equals(other.generalDialogProfileTextId_) && generalDialogVoiceResourceName_.Equals(other.generalDialogVoiceResourceName_) && HeightProfileTextId == other.HeightProfileTextId && HobbyProfileTextId == other.HobbyProfileTextId && Id == other.Id && PreciousProfileTextId == other.PreciousProfileTextId && Rumor1ProfileTextId == other.Rumor1ProfileTextId && Rumor2ProfileTextId == other.Rumor2ProfileTextId && skillDialogProfileTextId_.Equals(other.skillDialogProfileTextId_) && skillDialogVoiceResourceName_.Equals(other.skillDialogVoiceResourceName_) && SummaryProfileTextId == other.SummaryProfileTextId && talentDialogProfileTextId_.Equals(other.talentDialogProfileTextId_) && talentDialogVoiceResourceName_.Equals(other.talentDialogVoiceResourceName_) && victoryDialogProfileTextId_.Equals(other.victoryDialogProfileTextId_) && victoryDialogVoiceResourceName_.Equals(other.victoryDialogVoiceResourceName_))
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
		if (AgeProfileTextId != 0)
		{
			num ^= AgeProfileTextId.GetHashCode();
		}
		if (AssociationProfileTextId != 0)
		{
			num ^= AssociationProfileTextId.GetHashCode();
		}
		if (BirthDayProfileTextId != 0)
		{
			num ^= BirthDayProfileTextId.GetHashCode();
		}
		num ^= cutSceneDialogProfileTextId_.GetHashCode();
		num ^= cutSceneDialogVoiceResourceName_.GetHashCode();
		if (DislikeProfileTextId != 0)
		{
			num ^= DislikeProfileTextId.GetHashCode();
		}
		if (FavoriteProfileTextId != 0)
		{
			num ^= FavoriteProfileTextId.GetHashCode();
		}
		num ^= generalDialogProfileTextId_.GetHashCode();
		num ^= generalDialogVoiceResourceName_.GetHashCode();
		if (HeightProfileTextId != 0)
		{
			num ^= HeightProfileTextId.GetHashCode();
		}
		if (HobbyProfileTextId != 0)
		{
			num ^= HobbyProfileTextId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (PreciousProfileTextId != 0)
		{
			num ^= PreciousProfileTextId.GetHashCode();
		}
		if (Rumor1ProfileTextId != 0)
		{
			num ^= Rumor1ProfileTextId.GetHashCode();
		}
		if (Rumor2ProfileTextId != 0)
		{
			num ^= Rumor2ProfileTextId.GetHashCode();
		}
		num ^= skillDialogProfileTextId_.GetHashCode();
		num ^= skillDialogVoiceResourceName_.GetHashCode();
		if (SummaryProfileTextId != 0)
		{
			num ^= SummaryProfileTextId.GetHashCode();
		}
		num ^= talentDialogProfileTextId_.GetHashCode();
		num ^= talentDialogVoiceResourceName_.GetHashCode();
		num ^= victoryDialogProfileTextId_.GetHashCode();
		num ^= victoryDialogVoiceResourceName_.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (AgeProfileTextId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(AgeProfileTextId);
		}
		if (AssociationProfileTextId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(AssociationProfileTextId);
		}
		if (BirthDayProfileTextId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(BirthDayProfileTextId);
		}
		cutSceneDialogProfileTextId_.WriteTo(ref output, _repeated_cutSceneDialogProfileTextId_codec);
		cutSceneDialogVoiceResourceName_.WriteTo(ref output, _repeated_cutSceneDialogVoiceResourceName_codec);
		if (DislikeProfileTextId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(DislikeProfileTextId);
		}
		if (FavoriteProfileTextId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(FavoriteProfileTextId);
		}
		generalDialogProfileTextId_.WriteTo(ref output, _repeated_generalDialogProfileTextId_codec);
		generalDialogVoiceResourceName_.WriteTo(ref output, _repeated_generalDialogVoiceResourceName_codec);
		if (HeightProfileTextId != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(HeightProfileTextId);
		}
		if (HobbyProfileTextId != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(HobbyProfileTextId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(Id);
		}
		if (PreciousProfileTextId != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(PreciousProfileTextId);
		}
		if (Rumor1ProfileTextId != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(Rumor1ProfileTextId);
		}
		if (Rumor2ProfileTextId != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(Rumor2ProfileTextId);
		}
		skillDialogProfileTextId_.WriteTo(ref output, _repeated_skillDialogProfileTextId_codec);
		skillDialogVoiceResourceName_.WriteTo(ref output, _repeated_skillDialogVoiceResourceName_codec);
		if (SummaryProfileTextId != 0)
		{
			output.WriteRawTag(144, 1);
			output.WriteInt32(SummaryProfileTextId);
		}
		talentDialogProfileTextId_.WriteTo(ref output, _repeated_talentDialogProfileTextId_codec);
		talentDialogVoiceResourceName_.WriteTo(ref output, _repeated_talentDialogVoiceResourceName_codec);
		victoryDialogProfileTextId_.WriteTo(ref output, _repeated_victoryDialogProfileTextId_codec);
		victoryDialogVoiceResourceName_.WriteTo(ref output, _repeated_victoryDialogVoiceResourceName_codec);
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
		if (AgeProfileTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AgeProfileTextId);
		}
		if (AssociationProfileTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AssociationProfileTextId);
		}
		if (BirthDayProfileTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BirthDayProfileTextId);
		}
		num += cutSceneDialogProfileTextId_.CalculateSize(_repeated_cutSceneDialogProfileTextId_codec);
		num += cutSceneDialogVoiceResourceName_.CalculateSize(_repeated_cutSceneDialogVoiceResourceName_codec);
		if (DislikeProfileTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DislikeProfileTextId);
		}
		if (FavoriteProfileTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FavoriteProfileTextId);
		}
		num += generalDialogProfileTextId_.CalculateSize(_repeated_generalDialogProfileTextId_codec);
		num += generalDialogVoiceResourceName_.CalculateSize(_repeated_generalDialogVoiceResourceName_codec);
		if (HeightProfileTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HeightProfileTextId);
		}
		if (HobbyProfileTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HobbyProfileTextId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (PreciousProfileTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PreciousProfileTextId);
		}
		if (Rumor1ProfileTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Rumor1ProfileTextId);
		}
		if (Rumor2ProfileTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Rumor2ProfileTextId);
		}
		num += skillDialogProfileTextId_.CalculateSize(_repeated_skillDialogProfileTextId_codec);
		num += skillDialogVoiceResourceName_.CalculateSize(_repeated_skillDialogVoiceResourceName_codec);
		if (SummaryProfileTextId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SummaryProfileTextId);
		}
		num += talentDialogProfileTextId_.CalculateSize(_repeated_talentDialogProfileTextId_codec);
		num += talentDialogVoiceResourceName_.CalculateSize(_repeated_talentDialogVoiceResourceName_codec);
		num += victoryDialogProfileTextId_.CalculateSize(_repeated_victoryDialogProfileTextId_codec);
		num += victoryDialogVoiceResourceName_.CalculateSize(_repeated_victoryDialogVoiceResourceName_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CostumeConceptInfoTable other)
	{
		if (other != null)
		{
			if (other.AgeProfileTextId != 0)
			{
				AgeProfileTextId = other.AgeProfileTextId;
			}
			if (other.AssociationProfileTextId != 0)
			{
				AssociationProfileTextId = other.AssociationProfileTextId;
			}
			if (other.BirthDayProfileTextId != 0)
			{
				BirthDayProfileTextId = other.BirthDayProfileTextId;
			}
			cutSceneDialogProfileTextId_.Add(other.cutSceneDialogProfileTextId_);
			cutSceneDialogVoiceResourceName_.Add(other.cutSceneDialogVoiceResourceName_);
			if (other.DislikeProfileTextId != 0)
			{
				DislikeProfileTextId = other.DislikeProfileTextId;
			}
			if (other.FavoriteProfileTextId != 0)
			{
				FavoriteProfileTextId = other.FavoriteProfileTextId;
			}
			generalDialogProfileTextId_.Add(other.generalDialogProfileTextId_);
			generalDialogVoiceResourceName_.Add(other.generalDialogVoiceResourceName_);
			if (other.HeightProfileTextId != 0)
			{
				HeightProfileTextId = other.HeightProfileTextId;
			}
			if (other.HobbyProfileTextId != 0)
			{
				HobbyProfileTextId = other.HobbyProfileTextId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.PreciousProfileTextId != 0)
			{
				PreciousProfileTextId = other.PreciousProfileTextId;
			}
			if (other.Rumor1ProfileTextId != 0)
			{
				Rumor1ProfileTextId = other.Rumor1ProfileTextId;
			}
			if (other.Rumor2ProfileTextId != 0)
			{
				Rumor2ProfileTextId = other.Rumor2ProfileTextId;
			}
			skillDialogProfileTextId_.Add(other.skillDialogProfileTextId_);
			skillDialogVoiceResourceName_.Add(other.skillDialogVoiceResourceName_);
			if (other.SummaryProfileTextId != 0)
			{
				SummaryProfileTextId = other.SummaryProfileTextId;
			}
			talentDialogProfileTextId_.Add(other.talentDialogProfileTextId_);
			talentDialogVoiceResourceName_.Add(other.talentDialogVoiceResourceName_);
			victoryDialogProfileTextId_.Add(other.victoryDialogProfileTextId_);
			victoryDialogVoiceResourceName_.Add(other.victoryDialogVoiceResourceName_);
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
			case 48u:
				DislikeProfileTextId = input.ReadInt32();
				break;
			case 56u:
				FavoriteProfileTextId = input.ReadInt32();
				break;
			case 74u:
				generalDialogVoiceResourceName_.AddEntriesFrom(ref input, _repeated_generalDialogVoiceResourceName_codec);
				break;
			case 80u:
				HeightProfileTextId = input.ReadInt32();
				break;
			case 88u:
				HobbyProfileTextId = input.ReadInt32();
				break;
			case 64u:
			case 66u:
				generalDialogProfileTextId_.AddEntriesFrom(ref input, _repeated_generalDialogProfileTextId_codec);
				break;
			case 8u:
				AgeProfileTextId = input.ReadInt32();
				break;
			case 16u:
				AssociationProfileTextId = input.ReadInt32();
				break;
			case 24u:
				BirthDayProfileTextId = input.ReadInt32();
				break;
			case 32u:
			case 34u:
				cutSceneDialogProfileTextId_.AddEntriesFrom(ref input, _repeated_cutSceneDialogProfileTextId_codec);
				break;
			case 42u:
				cutSceneDialogVoiceResourceName_.AddEntriesFrom(ref input, _repeated_cutSceneDialogVoiceResourceName_codec);
				break;
			case 120u:
				Rumor2ProfileTextId = input.ReadInt32();
				break;
			case 138u:
				skillDialogVoiceResourceName_.AddEntriesFrom(ref input, _repeated_skillDialogVoiceResourceName_codec);
				break;
			case 128u:
			case 130u:
				skillDialogProfileTextId_.AddEntriesFrom(ref input, _repeated_skillDialogProfileTextId_codec);
				break;
			case 96u:
				Id = input.ReadInt32();
				break;
			case 104u:
				PreciousProfileTextId = input.ReadInt32();
				break;
			case 112u:
				Rumor1ProfileTextId = input.ReadInt32();
				break;
			case 162u:
				talentDialogVoiceResourceName_.AddEntriesFrom(ref input, _repeated_talentDialogVoiceResourceName_codec);
				break;
			case 178u:
				victoryDialogVoiceResourceName_.AddEntriesFrom(ref input, _repeated_victoryDialogVoiceResourceName_codec);
				break;
			case 168u:
			case 170u:
				victoryDialogProfileTextId_.AddEntriesFrom(ref input, _repeated_victoryDialogProfileTextId_codec);
				break;
			case 144u:
				SummaryProfileTextId = input.ReadInt32();
				break;
			case 152u:
			case 154u:
				talentDialogProfileTextId_.AddEntriesFrom(ref input, _repeated_talentDialogProfileTextId_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
