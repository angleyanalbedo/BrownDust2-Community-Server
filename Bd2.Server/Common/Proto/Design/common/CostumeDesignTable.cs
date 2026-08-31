using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class CostumeDesignTable : IMessage<CostumeDesignTable>, IMessage, IEquatable<CostumeDesignTable>, IDeepCloneable<CostumeDesignTable>, IBufferMessage
{
	private static readonly MessageParser<CostumeDesignTable> _parser = new MessageParser<CostumeDesignTable>(() => new CostumeDesignTable());

	private UnknownFieldSet _unknownFields;

	public const int AttackEffectSkillTextIdFieldNumber = 1;

	private static readonly FieldCodec<int> _repeated_attackEffectSkillTextId_codec = FieldCodec.ForInt32(10u);

	private readonly RepeatedField<int> attackEffectSkillTextId_ = new RepeatedField<int>();

	public const int BlurImageNameFieldNumber = 2;

	private string blurImageName_ = "";

	public const int FaceIconNameFieldNumber = 3;

	private string faceIconName_ = "";

	public const int FaceIllustNameFieldNumber = 4;

	private string faceIllustName_ = "";

	public const int IconSpriteNameFieldNumber = 5;

	private string iconSpriteName_ = "";

	public const int IdFieldNumber = 6;

	private int id_;

	public const int IllustNameFieldNumber = 7;

	private string illustName_ = "";

	public const int InventoryIllustNameFieldNumber = 8;

	private string inventoryIllustName_ = "";

	public const int IsCollaboFieldNumber = 9;

	private int isCollabo_;

	public const int LobbyCutsceneFieldNumber = 10;

	private string lobbyCutscene_ = "";

	public const int LoopPrefabNameFieldNumber = 11;

	private string loopPrefabName_ = "";

	public const int PrefabNameFieldNumber = 12;

	private string prefabName_ = "";

	public const int SimpleIllustNameFieldNumber = 13;

	private string simpleIllustName_ = "";

	public const int SkillTimelineNameFieldNumber = 14;

	private string skillTimelineName_ = "";

	public const int UiResourceNameFieldNumber = 15;

	private string uiResourceName_ = "";

	public const int VoiceResourceNameFieldNumber = 16;

	private string voiceResourceName_ = "";

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CostumeDesignTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => CostumeDesignTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> AttackEffectSkillTextId => attackEffectSkillTextId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string BlurImageName
	{
		get
		{
			return blurImageName_;
		}
		set
		{
			blurImageName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string FaceIconName
	{
		get
		{
			return faceIconName_;
		}
		set
		{
			faceIconName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string FaceIllustName
	{
		get
		{
			return faceIllustName_;
		}
		set
		{
			faceIllustName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string IconSpriteName
	{
		get
		{
			return iconSpriteName_;
		}
		set
		{
			iconSpriteName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public string IllustName
	{
		get
		{
			return illustName_;
		}
		set
		{
			illustName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string InventoryIllustName
	{
		get
		{
			return inventoryIllustName_;
		}
		set
		{
			inventoryIllustName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int IsCollabo
	{
		get
		{
			return isCollabo_;
		}
		set
		{
			isCollabo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string LobbyCutscene
	{
		get
		{
			return lobbyCutscene_;
		}
		set
		{
			lobbyCutscene_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string LoopPrefabName
	{
		get
		{
			return loopPrefabName_;
		}
		set
		{
			loopPrefabName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string PrefabName
	{
		get
		{
			return prefabName_;
		}
		set
		{
			prefabName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string SimpleIllustName
	{
		get
		{
			return simpleIllustName_;
		}
		set
		{
			simpleIllustName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string SkillTimelineName
	{
		get
		{
			return skillTimelineName_;
		}
		set
		{
			skillTimelineName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string UiResourceName
	{
		get
		{
			return uiResourceName_;
		}
		set
		{
			uiResourceName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string VoiceResourceName
	{
		get
		{
			return voiceResourceName_;
		}
		set
		{
			voiceResourceName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CostumeDesignTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CostumeDesignTable(CostumeDesignTable other)
		: this()
	{
		attackEffectSkillTextId_ = other.attackEffectSkillTextId_.Clone();
		blurImageName_ = other.blurImageName_;
		faceIconName_ = other.faceIconName_;
		faceIllustName_ = other.faceIllustName_;
		iconSpriteName_ = other.iconSpriteName_;
		id_ = other.id_;
		illustName_ = other.illustName_;
		inventoryIllustName_ = other.inventoryIllustName_;
		isCollabo_ = other.isCollabo_;
		lobbyCutscene_ = other.lobbyCutscene_;
		loopPrefabName_ = other.loopPrefabName_;
		prefabName_ = other.prefabName_;
		simpleIllustName_ = other.simpleIllustName_;
		skillTimelineName_ = other.skillTimelineName_;
		uiResourceName_ = other.uiResourceName_;
		voiceResourceName_ = other.voiceResourceName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CostumeDesignTable Clone()
	{
		return new CostumeDesignTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as CostumeDesignTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CostumeDesignTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (attackEffectSkillTextId_.Equals(other.attackEffectSkillTextId_) && !(BlurImageName != other.BlurImageName) && !(FaceIconName != other.FaceIconName) && !(FaceIllustName != other.FaceIllustName) && !(IconSpriteName != other.IconSpriteName) && Id == other.Id && !(IllustName != other.IllustName) && !(InventoryIllustName != other.InventoryIllustName) && IsCollabo == other.IsCollabo && !(LobbyCutscene != other.LobbyCutscene) && !(LoopPrefabName != other.LoopPrefabName) && !(PrefabName != other.PrefabName) && !(SimpleIllustName != other.SimpleIllustName) && !(SkillTimelineName != other.SkillTimelineName) && !(UiResourceName != other.UiResourceName) && !(VoiceResourceName != other.VoiceResourceName))
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
		num ^= attackEffectSkillTextId_.GetHashCode();
		if (BlurImageName.Length != 0)
		{
			num ^= BlurImageName.GetHashCode();
		}
		if (FaceIconName.Length != 0)
		{
			num ^= FaceIconName.GetHashCode();
		}
		if (FaceIllustName.Length != 0)
		{
			num ^= FaceIllustName.GetHashCode();
		}
		if (IconSpriteName.Length != 0)
		{
			num ^= IconSpriteName.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (IllustName.Length != 0)
		{
			num ^= IllustName.GetHashCode();
		}
		if (InventoryIllustName.Length != 0)
		{
			num ^= InventoryIllustName.GetHashCode();
		}
		if (IsCollabo != 0)
		{
			num ^= IsCollabo.GetHashCode();
		}
		if (LobbyCutscene.Length != 0)
		{
			num ^= LobbyCutscene.GetHashCode();
		}
		if (LoopPrefabName.Length != 0)
		{
			num ^= LoopPrefabName.GetHashCode();
		}
		if (PrefabName.Length != 0)
		{
			num ^= PrefabName.GetHashCode();
		}
		if (SimpleIllustName.Length != 0)
		{
			num ^= SimpleIllustName.GetHashCode();
		}
		if (SkillTimelineName.Length != 0)
		{
			num ^= SkillTimelineName.GetHashCode();
		}
		if (UiResourceName.Length != 0)
		{
			num ^= UiResourceName.GetHashCode();
		}
		if (VoiceResourceName.Length != 0)
		{
			num ^= VoiceResourceName.GetHashCode();
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
		attackEffectSkillTextId_.WriteTo(ref output, _repeated_attackEffectSkillTextId_codec);
		if (BlurImageName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(BlurImageName);
		}
		if (FaceIconName.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(FaceIconName);
		}
		if (FaceIllustName.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(FaceIllustName);
		}
		if (IconSpriteName.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(IconSpriteName);
		}
		if (Id != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(Id);
		}
		if (IllustName.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(IllustName);
		}
		if (InventoryIllustName.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(InventoryIllustName);
		}
		if (IsCollabo != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(IsCollabo);
		}
		if (LobbyCutscene.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(LobbyCutscene);
		}
		if (LoopPrefabName.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(LoopPrefabName);
		}
		if (PrefabName.Length != 0)
		{
			output.WriteRawTag(98);
			output.WriteString(PrefabName);
		}
		if (SimpleIllustName.Length != 0)
		{
			output.WriteRawTag(106);
			output.WriteString(SimpleIllustName);
		}
		if (SkillTimelineName.Length != 0)
		{
			output.WriteRawTag(114);
			output.WriteString(SkillTimelineName);
		}
		if (UiResourceName.Length != 0)
		{
			output.WriteRawTag(122);
			output.WriteString(UiResourceName);
		}
		if (VoiceResourceName.Length != 0)
		{
			output.WriteRawTag(130, 1);
			output.WriteString(VoiceResourceName);
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
		num += attackEffectSkillTextId_.CalculateSize(_repeated_attackEffectSkillTextId_codec);
		if (BlurImageName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BlurImageName);
		}
		if (FaceIconName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(FaceIconName);
		}
		if (FaceIllustName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(FaceIllustName);
		}
		if (IconSpriteName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(IconSpriteName);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (IllustName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(IllustName);
		}
		if (InventoryIllustName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(InventoryIllustName);
		}
		if (IsCollabo != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IsCollabo);
		}
		if (LobbyCutscene.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LobbyCutscene);
		}
		if (LoopPrefabName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LoopPrefabName);
		}
		if (PrefabName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PrefabName);
		}
		if (SimpleIllustName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SimpleIllustName);
		}
		if (SkillTimelineName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SkillTimelineName);
		}
		if (UiResourceName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UiResourceName);
		}
		if (VoiceResourceName.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(VoiceResourceName);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CostumeDesignTable other)
	{
		if (other != null)
		{
			attackEffectSkillTextId_.Add(other.attackEffectSkillTextId_);
			if (other.BlurImageName.Length != 0)
			{
				BlurImageName = other.BlurImageName;
			}
			if (other.FaceIconName.Length != 0)
			{
				FaceIconName = other.FaceIconName;
			}
			if (other.FaceIllustName.Length != 0)
			{
				FaceIllustName = other.FaceIllustName;
			}
			if (other.IconSpriteName.Length != 0)
			{
				IconSpriteName = other.IconSpriteName;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.IllustName.Length != 0)
			{
				IllustName = other.IllustName;
			}
			if (other.InventoryIllustName.Length != 0)
			{
				InventoryIllustName = other.InventoryIllustName;
			}
			if (other.IsCollabo != 0)
			{
				IsCollabo = other.IsCollabo;
			}
			if (other.LobbyCutscene.Length != 0)
			{
				LobbyCutscene = other.LobbyCutscene;
			}
			if (other.LoopPrefabName.Length != 0)
			{
				LoopPrefabName = other.LoopPrefabName;
			}
			if (other.PrefabName.Length != 0)
			{
				PrefabName = other.PrefabName;
			}
			if (other.SimpleIllustName.Length != 0)
			{
				SimpleIllustName = other.SimpleIllustName;
			}
			if (other.SkillTimelineName.Length != 0)
			{
				SkillTimelineName = other.SkillTimelineName;
			}
			if (other.UiResourceName.Length != 0)
			{
				UiResourceName = other.UiResourceName;
			}
			if (other.VoiceResourceName.Length != 0)
			{
				VoiceResourceName = other.VoiceResourceName;
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
			case 10u:
				attackEffectSkillTextId_.AddEntriesFrom(ref input, _repeated_attackEffectSkillTextId_codec);
				break;
			case 18u:
				BlurImageName = input.ReadString();
				break;
			case 26u:
				FaceIconName = input.ReadString();
				break;
			case 34u:
				FaceIllustName = input.ReadString();
				break;
			case 42u:
				IconSpriteName = input.ReadString();
				break;
			case 48u:
				Id = input.ReadInt32();
				break;
			case 58u:
				IllustName = input.ReadString();
				break;
			case 66u:
				InventoryIllustName = input.ReadString();
				break;
			case 72u:
				IsCollabo = input.ReadInt32();
				break;
			case 82u:
				LobbyCutscene = input.ReadString();
				break;
			case 90u:
				LoopPrefabName = input.ReadString();
				break;
			case 98u:
				PrefabName = input.ReadString();
				break;
			case 106u:
				SimpleIllustName = input.ReadString();
				break;
			case 114u:
				SkillTimelineName = input.ReadString();
				break;
			case 122u:
				UiResourceName = input.ReadString();
				break;
			case 130u:
				VoiceResourceName = input.ReadString();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
