using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class SkillTextTable_EN : IMessage<SkillTextTable_EN>, IMessage, IEquatable<SkillTextTable_EN>, IDeepCloneable<SkillTextTable_EN>, IBufferMessage
{
	private static readonly MessageParser<SkillTextTable_EN> _parser = new MessageParser<SkillTextTable_EN>(() => new SkillTextTable_EN());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int NodeAddTargetBuffTextIdFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_nodeAddTargetBuffTextId_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> nodeAddTargetBuffTextId_ = new RepeatedField<int>();

	public const int NodeAddTextFieldNumber = 3;

	private string nodeAddText_ = "";

	public const int TargetBuffTextIdFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_targetBuffTextId_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> targetBuffTextId_ = new RepeatedField<int>();

	public const int TextFieldNumber = 5;

	private string text_ = "";

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<SkillTextTable_EN> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => SkillTextTableENReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<int> NodeAddTargetBuffTextId => nodeAddTargetBuffTextId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string NodeAddText
	{
		get
		{
			return nodeAddText_;
		}
		set
		{
			nodeAddText_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> TargetBuffTextId => targetBuffTextId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Text
	{
		get
		{
			return text_;
		}
		set
		{
			text_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SkillTextTable_EN()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SkillTextTable_EN(SkillTextTable_EN other)
		: this()
	{
		id_ = other.id_;
		nodeAddTargetBuffTextId_ = other.nodeAddTargetBuffTextId_.Clone();
		nodeAddText_ = other.nodeAddText_;
		targetBuffTextId_ = other.targetBuffTextId_.Clone();
		text_ = other.text_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SkillTextTable_EN Clone()
	{
		return new SkillTextTable_EN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SkillTextTable_EN);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(SkillTextTable_EN other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && nodeAddTargetBuffTextId_.Equals(other.nodeAddTargetBuffTextId_) && !(NodeAddText != other.NodeAddText) && targetBuffTextId_.Equals(other.targetBuffTextId_) && !(Text != other.Text))
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
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		num ^= nodeAddTargetBuffTextId_.GetHashCode();
		if (NodeAddText.Length != 0)
		{
			num ^= NodeAddText.GetHashCode();
		}
		num ^= targetBuffTextId_.GetHashCode();
		if (Text.Length != 0)
		{
			num ^= Text.GetHashCode();
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
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		nodeAddTargetBuffTextId_.WriteTo(ref output, _repeated_nodeAddTargetBuffTextId_codec);
		if (NodeAddText.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(NodeAddText);
		}
		targetBuffTextId_.WriteTo(ref output, _repeated_targetBuffTextId_codec);
		if (Text.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(Text);
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
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		num += nodeAddTargetBuffTextId_.CalculateSize(_repeated_nodeAddTargetBuffTextId_codec);
		if (NodeAddText.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(NodeAddText);
		}
		num += targetBuffTextId_.CalculateSize(_repeated_targetBuffTextId_codec);
		if (Text.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Text);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SkillTextTable_EN other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			nodeAddTargetBuffTextId_.Add(other.nodeAddTargetBuffTextId_);
			if (other.NodeAddText.Length != 0)
			{
				NodeAddText = other.NodeAddText;
			}
			targetBuffTextId_.Add(other.targetBuffTextId_);
			if (other.Text.Length != 0)
			{
				Text = other.Text;
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
			case 26u:
				NodeAddText = input.ReadString();
				break;
			case 42u:
				Text = input.ReadString();
				break;
			case 32u:
			case 34u:
				targetBuffTextId_.AddEntriesFrom(ref input, _repeated_targetBuffTextId_codec);
				break;
			case 8u:
				Id = input.ReadInt32();
				break;
			case 16u:
			case 18u:
				nodeAddTargetBuffTextId_.AddEntriesFrom(ref input, _repeated_nodeAddTargetBuffTextId_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
