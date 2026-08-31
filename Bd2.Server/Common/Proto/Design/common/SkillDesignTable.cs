using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class SkillDesignTable : IMessage<SkillDesignTable>, IMessage, IEquatable<SkillDesignTable>, IDeepCloneable<SkillDesignTable>, IBufferMessage
{
	private static readonly MessageParser<SkillDesignTable> _parser = new MessageParser<SkillDesignTable>(() => new SkillDesignTable());

	private UnknownFieldSet _unknownFields;

	public const int AttackEffectSkillTextIdFieldNumber = 1;

	private static readonly FieldCodec<int> _repeated_attackEffectSkillTextId_codec = FieldCodec.ForInt32(10u);

	private readonly RepeatedField<int> attackEffectSkillTextId_ = new RepeatedField<int>();

	public const int CameraShakeTypeFieldNumber = 2;

	private int cameraShakeType_;

	public const int CameraZoomInTypeFieldNumber = 3;

	private int cameraZoomInType_;

	public const int IdFieldNumber = 4;

	private int id_;

	public const int Skill1EffectSkillTextIdFieldNumber = 5;

	private static readonly FieldCodec<int> _repeated_skill1EffectSkillTextId_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> skill1EffectSkillTextId_ = new RepeatedField<int>();

	public const int Skill2EffectSkillTextIdFieldNumber = 6;

	private static readonly FieldCodec<int> _repeated_skill2EffectSkillTextId_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> skill2EffectSkillTextId_ = new RepeatedField<int>();

	public const int SkillBackgroundFieldNumber = 7;

	private string skillBackground_ = "";

	public const int SkillCutSceneFieldNumber = 8;

	private string skillCutScene_ = "";

	public const int SkillIconSpriteNameFieldNumber = 9;

	private string skillIconSpriteName_ = "";

	public const int StunEffectSkillTextIdFieldNumber = 10;

	private static readonly FieldCodec<int> _repeated_stunEffectSkillTextId_codec = FieldCodec.ForInt32(82u);

	private readonly RepeatedField<int> stunEffectSkillTextId_ = new RepeatedField<int>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SkillDesignTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => SkillDesignTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> AttackEffectSkillTextId => attackEffectSkillTextId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CameraShakeType
	{
		get
		{
			return cameraShakeType_;
		}
		set
		{
			cameraShakeType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CameraZoomInType
	{
		get
		{
			return cameraZoomInType_;
		}
		set
		{
			cameraZoomInType_ = value;
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
	public RepeatedField<int> Skill1EffectSkillTextId => skill1EffectSkillTextId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> Skill2EffectSkillTextId => skill2EffectSkillTextId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string SkillBackground
	{
		get
		{
			return skillBackground_;
		}
		set
		{
			skillBackground_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string SkillCutScene
	{
		get
		{
			return skillCutScene_;
		}
		set
		{
			skillCutScene_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string SkillIconSpriteName
	{
		get
		{
			return skillIconSpriteName_;
		}
		set
		{
			skillIconSpriteName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> StunEffectSkillTextId => stunEffectSkillTextId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SkillDesignTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SkillDesignTable(SkillDesignTable other)
		: this()
	{
		attackEffectSkillTextId_ = other.attackEffectSkillTextId_.Clone();
		cameraShakeType_ = other.cameraShakeType_;
		cameraZoomInType_ = other.cameraZoomInType_;
		id_ = other.id_;
		skill1EffectSkillTextId_ = other.skill1EffectSkillTextId_.Clone();
		skill2EffectSkillTextId_ = other.skill2EffectSkillTextId_.Clone();
		skillBackground_ = other.skillBackground_;
		skillCutScene_ = other.skillCutScene_;
		skillIconSpriteName_ = other.skillIconSpriteName_;
		stunEffectSkillTextId_ = other.stunEffectSkillTextId_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SkillDesignTable Clone()
	{
		return new SkillDesignTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SkillDesignTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SkillDesignTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (attackEffectSkillTextId_.Equals(other.attackEffectSkillTextId_) && CameraShakeType == other.CameraShakeType && CameraZoomInType == other.CameraZoomInType && Id == other.Id && skill1EffectSkillTextId_.Equals(other.skill1EffectSkillTextId_) && skill2EffectSkillTextId_.Equals(other.skill2EffectSkillTextId_) && !(SkillBackground != other.SkillBackground) && !(SkillCutScene != other.SkillCutScene) && !(SkillIconSpriteName != other.SkillIconSpriteName) && stunEffectSkillTextId_.Equals(other.stunEffectSkillTextId_))
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
		num ^= attackEffectSkillTextId_.GetHashCode();
		if (CameraShakeType != 0)
		{
			num ^= CameraShakeType.GetHashCode();
		}
		if (CameraZoomInType != 0)
		{
			num ^= CameraZoomInType.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		num ^= skill1EffectSkillTextId_.GetHashCode();
		num ^= skill2EffectSkillTextId_.GetHashCode();
		if (SkillBackground.Length != 0)
		{
			num ^= SkillBackground.GetHashCode();
		}
		if (SkillCutScene.Length != 0)
		{
			num ^= SkillCutScene.GetHashCode();
		}
		if (SkillIconSpriteName.Length != 0)
		{
			num ^= SkillIconSpriteName.GetHashCode();
		}
		num ^= stunEffectSkillTextId_.GetHashCode();
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
		if (CameraShakeType != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(CameraShakeType);
		}
		if (CameraZoomInType != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(CameraZoomInType);
		}
		if (Id != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Id);
		}
		skill1EffectSkillTextId_.WriteTo(ref output, _repeated_skill1EffectSkillTextId_codec);
		skill2EffectSkillTextId_.WriteTo(ref output, _repeated_skill2EffectSkillTextId_codec);
		if (SkillBackground.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(SkillBackground);
		}
		if (SkillCutScene.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(SkillCutScene);
		}
		if (SkillIconSpriteName.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(SkillIconSpriteName);
		}
		stunEffectSkillTextId_.WriteTo(ref output, _repeated_stunEffectSkillTextId_codec);
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
		num += attackEffectSkillTextId_.CalculateSize(_repeated_attackEffectSkillTextId_codec);
		if (CameraShakeType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CameraShakeType);
		}
		if (CameraZoomInType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CameraZoomInType);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		num += skill1EffectSkillTextId_.CalculateSize(_repeated_skill1EffectSkillTextId_codec);
		num += skill2EffectSkillTextId_.CalculateSize(_repeated_skill2EffectSkillTextId_codec);
		if (SkillBackground.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SkillBackground);
		}
		if (SkillCutScene.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SkillCutScene);
		}
		if (SkillIconSpriteName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SkillIconSpriteName);
		}
		num += stunEffectSkillTextId_.CalculateSize(_repeated_stunEffectSkillTextId_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SkillDesignTable other)
	{
		if (other != null)
		{
			attackEffectSkillTextId_.Add(other.attackEffectSkillTextId_);
			if (other.CameraShakeType != 0)
			{
				CameraShakeType = other.CameraShakeType;
			}
			if (other.CameraZoomInType != 0)
			{
				CameraZoomInType = other.CameraZoomInType;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			skill1EffectSkillTextId_.Add(other.skill1EffectSkillTextId_);
			skill2EffectSkillTextId_.Add(other.skill2EffectSkillTextId_);
			if (other.SkillBackground.Length != 0)
			{
				SkillBackground = other.SkillBackground;
			}
			if (other.SkillCutScene.Length != 0)
			{
				SkillCutScene = other.SkillCutScene;
			}
			if (other.SkillIconSpriteName.Length != 0)
			{
				SkillIconSpriteName = other.SkillIconSpriteName;
			}
			stunEffectSkillTextId_.Add(other.stunEffectSkillTextId_);
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
			case 10u:
				attackEffectSkillTextId_.AddEntriesFrom(ref input, _repeated_attackEffectSkillTextId_codec);
				break;
			case 16u:
				CameraShakeType = input.ReadInt32();
				break;
			case 24u:
				CameraZoomInType = input.ReadInt32();
				break;
			case 32u:
				Id = input.ReadInt32();
				break;
			case 40u:
			case 42u:
				skill1EffectSkillTextId_.AddEntriesFrom(ref input, _repeated_skill1EffectSkillTextId_codec);
				break;
			case 48u:
			case 50u:
				skill2EffectSkillTextId_.AddEntriesFrom(ref input, _repeated_skill2EffectSkillTextId_codec);
				break;
			case 58u:
				SkillBackground = input.ReadString();
				break;
			case 66u:
				SkillCutScene = input.ReadString();
				break;
			case 74u:
				SkillIconSpriteName = input.ReadString();
				break;
			case 80u:
			case 82u:
				stunEffectSkillTextId_.AddEntriesFrom(ref input, _repeated_stunEffectSkillTextId_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
