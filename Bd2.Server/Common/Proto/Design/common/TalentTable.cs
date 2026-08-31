using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class TalentTable : IMessage<TalentTable>, IMessage, IEquatable<TalentTable>, IDeepCloneable<TalentTable>, IBufferMessage
{
	private static readonly MessageParser<TalentTable> _parser = new MessageParser<TalentTable>(() => new TalentTable());

	private UnknownFieldSet _unknownFields;

	public const int BlurImageNameFieldNumber = 1;

	private string blurImageName_ = "";

	public const int GrowthGroupIdFieldNumber = 2;

	private int growthGroupId_;

	public const int IconSpriteNameFieldNumber = 3;

	private string iconSpriteName_ = "";

	public const int IdFieldNumber = 4;

	private int id_;

	public const int ImageSpriteNameFieldNumber = 5;

	private string imageSpriteName_ = "";

	public const int MaxLevelFieldNumber = 6;

	private int maxLevel_;

	public const int SkillEffectTalk1FieldNumber = 7;

	private int skillEffectTalk1_;

	public const int SkillEffectTalk2FieldNumber = 8;

	private int skillEffectTalk2_;

	public const int TalentDescNameTextIdFieldNumber = 9;

	private int talentDescNameTextId_;

	public const int TalentNameTextIdFieldNumber = 10;

	private int talentNameTextId_;

	public const int TalentSkillGroupIdFieldNumber = 11;

	private int talentSkillGroupId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TalentTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TalentTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public int GrowthGroupId
	{
		get
		{
			return growthGroupId_;
		}
		set
		{
			growthGroupId_ = value;
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string ImageSpriteName
	{
		get
		{
			return imageSpriteName_;
		}
		set
		{
			imageSpriteName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MaxLevel
	{
		get
		{
			return maxLevel_;
		}
		set
		{
			maxLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SkillEffectTalk1
	{
		get
		{
			return skillEffectTalk1_;
		}
		set
		{
			skillEffectTalk1_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SkillEffectTalk2
	{
		get
		{
			return skillEffectTalk2_;
		}
		set
		{
			skillEffectTalk2_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TalentDescNameTextId
	{
		get
		{
			return talentDescNameTextId_;
		}
		set
		{
			talentDescNameTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TalentNameTextId
	{
		get
		{
			return talentNameTextId_;
		}
		set
		{
			talentNameTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TalentSkillGroupId
	{
		get
		{
			return talentSkillGroupId_;
		}
		set
		{
			talentSkillGroupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TalentTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TalentTable(TalentTable other)
		: this()
	{
		blurImageName_ = other.blurImageName_;
		growthGroupId_ = other.growthGroupId_;
		iconSpriteName_ = other.iconSpriteName_;
		id_ = other.id_;
		imageSpriteName_ = other.imageSpriteName_;
		maxLevel_ = other.maxLevel_;
		skillEffectTalk1_ = other.skillEffectTalk1_;
		skillEffectTalk2_ = other.skillEffectTalk2_;
		talentDescNameTextId_ = other.talentDescNameTextId_;
		talentNameTextId_ = other.talentNameTextId_;
		talentSkillGroupId_ = other.talentSkillGroupId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TalentTable Clone()
	{
		return new TalentTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TalentTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TalentTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (!(BlurImageName != other.BlurImageName) && GrowthGroupId == other.GrowthGroupId && !(IconSpriteName != other.IconSpriteName) && Id == other.Id && !(ImageSpriteName != other.ImageSpriteName) && MaxLevel == other.MaxLevel && SkillEffectTalk1 == other.SkillEffectTalk1 && SkillEffectTalk2 == other.SkillEffectTalk2 && TalentDescNameTextId == other.TalentDescNameTextId && TalentNameTextId == other.TalentNameTextId && TalentSkillGroupId == other.TalentSkillGroupId)
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
		if (BlurImageName.Length != 0)
		{
			num ^= BlurImageName.GetHashCode();
		}
		if (GrowthGroupId != 0)
		{
			num ^= GrowthGroupId.GetHashCode();
		}
		if (IconSpriteName.Length != 0)
		{
			num ^= IconSpriteName.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (ImageSpriteName.Length != 0)
		{
			num ^= ImageSpriteName.GetHashCode();
		}
		if (MaxLevel != 0)
		{
			num ^= MaxLevel.GetHashCode();
		}
		if (SkillEffectTalk1 != 0)
		{
			num ^= SkillEffectTalk1.GetHashCode();
		}
		if (SkillEffectTalk2 != 0)
		{
			num ^= SkillEffectTalk2.GetHashCode();
		}
		if (TalentDescNameTextId != 0)
		{
			num ^= TalentDescNameTextId.GetHashCode();
		}
		if (TalentNameTextId != 0)
		{
			num ^= TalentNameTextId.GetHashCode();
		}
		if (TalentSkillGroupId != 0)
		{
			num ^= TalentSkillGroupId.GetHashCode();
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
		if (BlurImageName.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(BlurImageName);
		}
		if (GrowthGroupId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(GrowthGroupId);
		}
		if (IconSpriteName.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(IconSpriteName);
		}
		if (Id != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Id);
		}
		if (ImageSpriteName.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(ImageSpriteName);
		}
		if (MaxLevel != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(MaxLevel);
		}
		if (SkillEffectTalk1 != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(SkillEffectTalk1);
		}
		if (SkillEffectTalk2 != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(SkillEffectTalk2);
		}
		if (TalentDescNameTextId != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(TalentDescNameTextId);
		}
		if (TalentNameTextId != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(TalentNameTextId);
		}
		if (TalentSkillGroupId != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(TalentSkillGroupId);
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
		if (BlurImageName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BlurImageName);
		}
		if (GrowthGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GrowthGroupId);
		}
		if (IconSpriteName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(IconSpriteName);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (ImageSpriteName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ImageSpriteName);
		}
		if (MaxLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxLevel);
		}
		if (SkillEffectTalk1 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SkillEffectTalk1);
		}
		if (SkillEffectTalk2 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SkillEffectTalk2);
		}
		if (TalentDescNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TalentDescNameTextId);
		}
		if (TalentNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TalentNameTextId);
		}
		if (TalentSkillGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TalentSkillGroupId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TalentTable other)
	{
		if (other != null)
		{
			if (other.BlurImageName.Length != 0)
			{
				BlurImageName = other.BlurImageName;
			}
			if (other.GrowthGroupId != 0)
			{
				GrowthGroupId = other.GrowthGroupId;
			}
			if (other.IconSpriteName.Length != 0)
			{
				IconSpriteName = other.IconSpriteName;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.ImageSpriteName.Length != 0)
			{
				ImageSpriteName = other.ImageSpriteName;
			}
			if (other.MaxLevel != 0)
			{
				MaxLevel = other.MaxLevel;
			}
			if (other.SkillEffectTalk1 != 0)
			{
				SkillEffectTalk1 = other.SkillEffectTalk1;
			}
			if (other.SkillEffectTalk2 != 0)
			{
				SkillEffectTalk2 = other.SkillEffectTalk2;
			}
			if (other.TalentDescNameTextId != 0)
			{
				TalentDescNameTextId = other.TalentDescNameTextId;
			}
			if (other.TalentNameTextId != 0)
			{
				TalentNameTextId = other.TalentNameTextId;
			}
			if (other.TalentSkillGroupId != 0)
			{
				TalentSkillGroupId = other.TalentSkillGroupId;
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
				BlurImageName = input.ReadString();
				break;
			case 16u:
				GrowthGroupId = input.ReadInt32();
				break;
			case 26u:
				IconSpriteName = input.ReadString();
				break;
			case 32u:
				Id = input.ReadInt32();
				break;
			case 42u:
				ImageSpriteName = input.ReadString();
				break;
			case 48u:
				MaxLevel = input.ReadInt32();
				break;
			case 56u:
				SkillEffectTalk1 = input.ReadInt32();
				break;
			case 64u:
				SkillEffectTalk2 = input.ReadInt32();
				break;
			case 72u:
				TalentDescNameTextId = input.ReadInt32();
				break;
			case 80u:
				TalentNameTextId = input.ReadInt32();
				break;
			case 88u:
				TalentSkillGroupId = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
