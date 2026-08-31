using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class TextDescriptionTable : IMessage<TextDescriptionTable>, IMessage, IEquatable<TextDescriptionTable>, IDeepCloneable<TextDescriptionTable>, IBufferMessage
{
	private static readonly MessageParser<TextDescriptionTable> _parser = new MessageParser<TextDescriptionTable>(() => new TextDescriptionTable());

	private UnknownFieldSet _unknownFields;

	public const int DescSkillTextIdFieldNumber = 1;

	private int descSkillTextId_;

	public const int IdFieldNumber = 2;

	private int id_;

	public const int TargetSkillTextIdFieldNumber = 3;

	private int targetSkillTextId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TextDescriptionTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TextDescriptionTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DescSkillTextId
	{
		get
		{
			return descSkillTextId_;
		}
		set
		{
			descSkillTextId_ = value;
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
	public int TargetSkillTextId
	{
		get
		{
			return targetSkillTextId_;
		}
		set
		{
			targetSkillTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TextDescriptionTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TextDescriptionTable(TextDescriptionTable other)
		: this()
	{
		descSkillTextId_ = other.descSkillTextId_;
		id_ = other.id_;
		targetSkillTextId_ = other.targetSkillTextId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TextDescriptionTable Clone()
	{
		return new TextDescriptionTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as TextDescriptionTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TextDescriptionTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (DescSkillTextId == other.DescSkillTextId && Id == other.Id && TargetSkillTextId == other.TargetSkillTextId)
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
		if (DescSkillTextId != 0)
		{
			num ^= DescSkillTextId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (TargetSkillTextId != 0)
		{
			num ^= TargetSkillTextId.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (DescSkillTextId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(DescSkillTextId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Id);
		}
		if (TargetSkillTextId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(TargetSkillTextId);
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
		if (DescSkillTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DescSkillTextId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (TargetSkillTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetSkillTextId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(TextDescriptionTable other)
	{
		if (other != null)
		{
			if (other.DescSkillTextId != 0)
			{
				DescSkillTextId = other.DescSkillTextId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.TargetSkillTextId != 0)
			{
				TargetSkillTextId = other.TargetSkillTextId;
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 24u:
				TargetSkillTextId = input.ReadInt32();
				break;
			case 16u:
				Id = input.ReadInt32();
				break;
			case 8u:
				DescSkillTextId = input.ReadInt32();
				break;
			}
		}
	}
}
