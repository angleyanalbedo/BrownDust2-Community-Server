using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class GuideTutorialTable : IMessage<GuideTutorialTable>, IMessage, IEquatable<GuideTutorialTable>, IDeepCloneable<GuideTutorialTable>, IBufferMessage
{
	private static readonly MessageParser<GuideTutorialTable> _parser = new MessageParser<GuideTutorialTable>(() => new GuideTutorialTable());

	private UnknownFieldSet _unknownFields;

	public const int GroupIdFieldNumber = 1;

	private int groupId_;

	public const int GuideOrderFieldNumber = 2;

	private int guideOrder_;

	public const int IdFieldNumber = 3;

	private int id_;

	public const int ResourceNameFieldNumber = 4;

	private string resourceName_ = "";

	public const int TextLocalTextIdFieldNumber = 5;

	private int textLocalTextId_;

	public const int TitleLocalTextIdFieldNumber = 6;

	private int titleLocalTextId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuideTutorialTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => GuideTutorialTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int GuideOrder
	{
		get
		{
			return guideOrder_;
		}
		set
		{
			guideOrder_ = value;
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
	public string ResourceName
	{
		get
		{
			return resourceName_;
		}
		set
		{
			resourceName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TextLocalTextId
	{
		get
		{
			return textLocalTextId_;
		}
		set
		{
			textLocalTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TitleLocalTextId
	{
		get
		{
			return titleLocalTextId_;
		}
		set
		{
			titleLocalTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuideTutorialTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuideTutorialTable(GuideTutorialTable other)
		: this()
	{
		groupId_ = other.groupId_;
		guideOrder_ = other.guideOrder_;
		id_ = other.id_;
		resourceName_ = other.resourceName_;
		textLocalTextId_ = other.textLocalTextId_;
		titleLocalTextId_ = other.titleLocalTextId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuideTutorialTable Clone()
	{
		return new GuideTutorialTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GuideTutorialTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuideTutorialTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (GroupId == other.GroupId && GuideOrder == other.GuideOrder && Id == other.Id && !(ResourceName != other.ResourceName) && TextLocalTextId == other.TextLocalTextId && TitleLocalTextId == other.TitleLocalTextId)
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
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (GuideOrder != 0)
		{
			num ^= GuideOrder.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (ResourceName.Length != 0)
		{
			num ^= ResourceName.GetHashCode();
		}
		if (TextLocalTextId != 0)
		{
			num ^= TextLocalTextId.GetHashCode();
		}
		if (TitleLocalTextId != 0)
		{
			num ^= TitleLocalTextId.GetHashCode();
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
		if (GroupId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(GroupId);
		}
		if (GuideOrder != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(GuideOrder);
		}
		if (Id != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Id);
		}
		if (ResourceName.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(ResourceName);
		}
		if (TextLocalTextId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(TextLocalTextId);
		}
		if (TitleLocalTextId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(TitleLocalTextId);
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
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (GuideOrder != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GuideOrder);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (ResourceName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ResourceName);
		}
		if (TextLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TextLocalTextId);
		}
		if (TitleLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TitleLocalTextId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuideTutorialTable other)
	{
		if (other != null)
		{
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.GuideOrder != 0)
			{
				GuideOrder = other.GuideOrder;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.ResourceName.Length != 0)
			{
				ResourceName = other.ResourceName;
			}
			if (other.TextLocalTextId != 0)
			{
				TextLocalTextId = other.TextLocalTextId;
			}
			if (other.TitleLocalTextId != 0)
			{
				TitleLocalTextId = other.TitleLocalTextId;
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
				GroupId = input.ReadInt32();
				break;
			case 16u:
				GuideOrder = input.ReadInt32();
				break;
			case 24u:
				Id = input.ReadInt32();
				break;
			case 34u:
				ResourceName = input.ReadString();
				break;
			case 40u:
				TextLocalTextId = input.ReadInt32();
				break;
			case 48u:
				TitleLocalTextId = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
