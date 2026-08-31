using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class EndGuideTable : IMessage<EndGuideTable>, IMessage, IEquatable<EndGuideTable>, IDeepCloneable<EndGuideTable>, IBufferMessage
{
	private static readonly MessageParser<EndGuideTable> _parser = new MessageParser<EndGuideTable>(() => new EndGuideTable());

	private UnknownFieldSet _unknownFields;

	public const int AtlasNameFieldNumber = 1;

	private string atlasName_ = "";

	public const int GroupIdFieldNumber = 2;

	private int groupId_;

	public const int GuideDescLocalTextIdFieldNumber = 3;

	private int guideDescLocalTextId_;

	public const int GuideNameLocalTextIdFieldNumber = 4;

	private int guideNameLocalTextId_;

	public const int GuideTextureNameFieldNumber = 5;

	private string guideTextureName_ = "";

	public const int IdFieldNumber = 6;

	private int id_;

	public const int SpinePrefabNameFieldNumber = 7;

	private string spinePrefabName_ = "";

	public const int SpriteNameFieldNumber = 8;

	private string spriteName_ = "";

	public const int VoiceResourceNameFieldNumber = 9;

	private string voiceResourceName_ = "";

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<EndGuideTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => EndGuideTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string AtlasName
	{
		get
		{
			return atlasName_;
		}
		set
		{
			atlasName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GuideDescLocalTextId
	{
		get
		{
			return guideDescLocalTextId_;
		}
		set
		{
			guideDescLocalTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int GuideNameLocalTextId
	{
		get
		{
			return guideNameLocalTextId_;
		}
		set
		{
			guideNameLocalTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string GuideTextureName
	{
		get
		{
			return guideTextureName_;
		}
		set
		{
			guideTextureName_ = ProtoPreconditions.CheckNotNull(value, "value");
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
	public string SpinePrefabName
	{
		get
		{
			return spinePrefabName_;
		}
		set
		{
			spinePrefabName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string SpriteName
	{
		get
		{
			return spriteName_;
		}
		set
		{
			spriteName_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EndGuideTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EndGuideTable(EndGuideTable other)
		: this()
	{
		atlasName_ = other.atlasName_;
		groupId_ = other.groupId_;
		guideDescLocalTextId_ = other.guideDescLocalTextId_;
		guideNameLocalTextId_ = other.guideNameLocalTextId_;
		guideTextureName_ = other.guideTextureName_;
		id_ = other.id_;
		spinePrefabName_ = other.spinePrefabName_;
		spriteName_ = other.spriteName_;
		voiceResourceName_ = other.voiceResourceName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EndGuideTable Clone()
	{
		return new EndGuideTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EndGuideTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EndGuideTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (!(AtlasName != other.AtlasName) && GroupId == other.GroupId && GuideDescLocalTextId == other.GuideDescLocalTextId && GuideNameLocalTextId == other.GuideNameLocalTextId && !(GuideTextureName != other.GuideTextureName) && Id == other.Id && !(SpinePrefabName != other.SpinePrefabName) && !(SpriteName != other.SpriteName) && !(VoiceResourceName != other.VoiceResourceName))
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
		if (AtlasName.Length != 0)
		{
			num ^= AtlasName.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (GuideDescLocalTextId != 0)
		{
			num ^= GuideDescLocalTextId.GetHashCode();
		}
		if (GuideNameLocalTextId != 0)
		{
			num ^= GuideNameLocalTextId.GetHashCode();
		}
		if (GuideTextureName.Length != 0)
		{
			num ^= GuideTextureName.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (SpinePrefabName.Length != 0)
		{
			num ^= SpinePrefabName.GetHashCode();
		}
		if (SpriteName.Length != 0)
		{
			num ^= SpriteName.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
		if (AtlasName.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(AtlasName);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(GroupId);
		}
		if (GuideDescLocalTextId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(GuideDescLocalTextId);
		}
		if (GuideNameLocalTextId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(GuideNameLocalTextId);
		}
		if (GuideTextureName.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(GuideTextureName);
		}
		if (Id != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(Id);
		}
		if (SpinePrefabName.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(SpinePrefabName);
		}
		if (SpriteName.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(SpriteName);
		}
		if (VoiceResourceName.Length != 0)
		{
			output.WriteRawTag(74);
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
		if (AtlasName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AtlasName);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (GuideDescLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GuideDescLocalTextId);
		}
		if (GuideNameLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GuideNameLocalTextId);
		}
		if (GuideTextureName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GuideTextureName);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (SpinePrefabName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SpinePrefabName);
		}
		if (SpriteName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SpriteName);
		}
		if (VoiceResourceName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(VoiceResourceName);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EndGuideTable other)
	{
		if (other != null)
		{
			if (other.AtlasName.Length != 0)
			{
				AtlasName = other.AtlasName;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.GuideDescLocalTextId != 0)
			{
				GuideDescLocalTextId = other.GuideDescLocalTextId;
			}
			if (other.GuideNameLocalTextId != 0)
			{
				GuideNameLocalTextId = other.GuideNameLocalTextId;
			}
			if (other.GuideTextureName.Length != 0)
			{
				GuideTextureName = other.GuideTextureName;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.SpinePrefabName.Length != 0)
			{
				SpinePrefabName = other.SpinePrefabName;
			}
			if (other.SpriteName.Length != 0)
			{
				SpriteName = other.SpriteName;
			}
			if (other.VoiceResourceName.Length != 0)
			{
				VoiceResourceName = other.VoiceResourceName;
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
				AtlasName = input.ReadString();
				break;
			case 16u:
				GroupId = input.ReadInt32();
				break;
			case 24u:
				GuideDescLocalTextId = input.ReadInt32();
				break;
			case 32u:
				GuideNameLocalTextId = input.ReadInt32();
				break;
			case 42u:
				GuideTextureName = input.ReadString();
				break;
			case 48u:
				Id = input.ReadInt32();
				break;
			case 58u:
				SpinePrefabName = input.ReadString();
				break;
			case 66u:
				SpriteName = input.ReadString();
				break;
			case 74u:
				VoiceResourceName = input.ReadString();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
