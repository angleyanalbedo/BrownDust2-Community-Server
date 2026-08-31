using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class SkillTextTable_TW : IMessage<SkillTextTable_TW>, IMessage, IEquatable<SkillTextTable_TW>, IDeepCloneable<SkillTextTable_TW>, IBufferMessage
{
	private static readonly MessageParser<SkillTextTable_TW> _parser = new MessageParser<SkillTextTable_TW>(() => new SkillTextTable_TW());

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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SkillTextTable_TW> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SkillTextTableTWReflection.Descriptor.MessageTypes[0];

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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public SkillTextTable_TW()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SkillTextTable_TW(SkillTextTable_TW other)
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
	public SkillTextTable_TW Clone()
	{
		return new SkillTextTable_TW(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as SkillTextTable_TW);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(SkillTextTable_TW other)
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public void MergeFrom(SkillTextTable_TW other)
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
