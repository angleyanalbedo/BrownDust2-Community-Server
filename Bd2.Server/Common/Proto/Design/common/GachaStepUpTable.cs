using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class GachaStepUpTable : IMessage<GachaStepUpTable>, IMessage, IEquatable<GachaStepUpTable>, IDeepCloneable<GachaStepUpTable>, IBufferMessage
{
	private static readonly MessageParser<GachaStepUpTable> _parser = new MessageParser<GachaStepUpTable>(() => new GachaStepUpTable());

	private UnknownFieldSet _unknownFields;

	public const int FixedIdFieldNumber = 1;

	private int fixedId_;

	public const int FixedLocalTextIdFieldNumber = 2;

	private int fixedLocalTextId_;

	public const int GachaGroupIdFieldNumber = 3;

	private int gachaGroupId_;

	public const int GachaIdFieldNumber = 4;

	private int gachaId_;

	public const int GroupIdFieldNumber = 5;

	private int groupId_;

	public const int IdFieldNumber = 6;

	private int id_;

	public const int IsDisplayFixedItemFieldNumber = 7;

	private int isDisplayFixedItem_;

	public const int StepLocalTextIdFieldNumber = 8;

	private int stepLocalTextId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GachaStepUpTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => GachaStepUpTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FixedId
	{
		get
		{
			return fixedId_;
		}
		set
		{
			fixedId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FixedLocalTextId
	{
		get
		{
			return fixedLocalTextId_;
		}
		set
		{
			fixedLocalTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GachaGroupId
	{
		get
		{
			return gachaGroupId_;
		}
		set
		{
			gachaGroupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GachaId
	{
		get
		{
			return gachaId_;
		}
		set
		{
			gachaId_ = value;
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
	public int IsDisplayFixedItem
	{
		get
		{
			return isDisplayFixedItem_;
		}
		set
		{
			isDisplayFixedItem_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int StepLocalTextId
	{
		get
		{
			return stepLocalTextId_;
		}
		set
		{
			stepLocalTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GachaStepUpTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GachaStepUpTable(GachaStepUpTable other)
		: this()
	{
		fixedId_ = other.fixedId_;
		fixedLocalTextId_ = other.fixedLocalTextId_;
		gachaGroupId_ = other.gachaGroupId_;
		gachaId_ = other.gachaId_;
		groupId_ = other.groupId_;
		id_ = other.id_;
		isDisplayFixedItem_ = other.isDisplayFixedItem_;
		stepLocalTextId_ = other.stepLocalTextId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaStepUpTable Clone()
	{
		return new GachaStepUpTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GachaStepUpTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GachaStepUpTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (FixedId == other.FixedId && FixedLocalTextId == other.FixedLocalTextId && GachaGroupId == other.GachaGroupId && GachaId == other.GachaId && GroupId == other.GroupId && Id == other.Id && IsDisplayFixedItem == other.IsDisplayFixedItem && StepLocalTextId == other.StepLocalTextId)
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
		if (FixedId != 0)
		{
			num ^= FixedId.GetHashCode();
		}
		if (FixedLocalTextId != 0)
		{
			num ^= FixedLocalTextId.GetHashCode();
		}
		if (GachaGroupId != 0)
		{
			num ^= GachaGroupId.GetHashCode();
		}
		if (GachaId != 0)
		{
			num ^= GachaId.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (IsDisplayFixedItem != 0)
		{
			num ^= IsDisplayFixedItem.GetHashCode();
		}
		if (StepLocalTextId != 0)
		{
			num ^= StepLocalTextId.GetHashCode();
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
		if (FixedId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(FixedId);
		}
		if (FixedLocalTextId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(FixedLocalTextId);
		}
		if (GachaGroupId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(GachaGroupId);
		}
		if (GachaId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(GachaId);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(GroupId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(Id);
		}
		if (IsDisplayFixedItem != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(IsDisplayFixedItem);
		}
		if (StepLocalTextId != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(StepLocalTextId);
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
		if (FixedId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FixedId);
		}
		if (FixedLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FixedLocalTextId);
		}
		if (GachaGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GachaGroupId);
		}
		if (GachaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GachaId);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (IsDisplayFixedItem != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IsDisplayFixedItem);
		}
		if (StepLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StepLocalTextId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GachaStepUpTable other)
	{
		if (other != null)
		{
			if (other.FixedId != 0)
			{
				FixedId = other.FixedId;
			}
			if (other.FixedLocalTextId != 0)
			{
				FixedLocalTextId = other.FixedLocalTextId;
			}
			if (other.GachaGroupId != 0)
			{
				GachaGroupId = other.GachaGroupId;
			}
			if (other.GachaId != 0)
			{
				GachaId = other.GachaId;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.IsDisplayFixedItem != 0)
			{
				IsDisplayFixedItem = other.IsDisplayFixedItem;
			}
			if (other.StepLocalTextId != 0)
			{
				StepLocalTextId = other.StepLocalTextId;
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
				FixedId = input.ReadInt32();
				break;
			case 16u:
				FixedLocalTextId = input.ReadInt32();
				break;
			case 24u:
				GachaGroupId = input.ReadInt32();
				break;
			case 32u:
				GachaId = input.ReadInt32();
				break;
			case 40u:
				GroupId = input.ReadInt32();
				break;
			case 48u:
				Id = input.ReadInt32();
				break;
			case 56u:
				IsDisplayFixedItem = input.ReadInt32();
				break;
			case 64u:
				StepLocalTextId = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
