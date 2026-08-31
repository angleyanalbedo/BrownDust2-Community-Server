using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class LocalTextTable : IMessage<LocalTextTable>, IMessage, IEquatable<LocalTextTable>, IDeepCloneable<LocalTextTable>, IBufferMessage
{
	private static readonly MessageParser<LocalTextTable> _parser = new MessageParser<LocalTextTable>(() => new LocalTextTable());

	private UnknownFieldSet _unknownFields;

	public const int DateFieldNumber = 1;

	private string date_ = "";

	public const int IdFieldNumber = 2;

	private int id_;

	public const int TextFieldNumber = 3;

	private string text_ = "";

	public const int TextCnFieldNumber = 4;

	private string textCn_ = "";

	public const int TextEnFieldNumber = 5;

	private string textEn_ = "";

	public const int TextJpFieldNumber = 6;

	private string textJp_ = "";

	public const int TextTwFieldNumber = 7;

	private string textTw_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LocalTextTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LocalTextTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Date
	{
		get
		{
			return date_;
		}
		set
		{
			date_ = ProtoPreconditions.CheckNotNull(value, "value");
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
	public string TextCn
	{
		get
		{
			return textCn_;
		}
		set
		{
			textCn_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string TextEn
	{
		get
		{
			return textEn_;
		}
		set
		{
			textEn_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string TextJp
	{
		get
		{
			return textJp_;
		}
		set
		{
			textJp_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string TextTw
	{
		get
		{
			return textTw_;
		}
		set
		{
			textTw_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LocalTextTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LocalTextTable(LocalTextTable other)
		: this()
	{
		date_ = other.date_;
		id_ = other.id_;
		text_ = other.text_;
		textCn_ = other.textCn_;
		textEn_ = other.textEn_;
		textJp_ = other.textJp_;
		textTw_ = other.textTw_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LocalTextTable Clone()
	{
		return new LocalTextTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LocalTextTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LocalTextTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (!(Date != other.Date) && Id == other.Id && !(Text != other.Text) && !(TextCn != other.TextCn) && !(TextEn != other.TextEn) && !(TextJp != other.TextJp) && !(TextTw != other.TextTw))
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
		if (Date.Length != 0)
		{
			num ^= Date.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (Text.Length != 0)
		{
			num ^= Text.GetHashCode();
		}
		if (TextCn.Length != 0)
		{
			num ^= TextCn.GetHashCode();
		}
		if (TextEn.Length != 0)
		{
			num ^= TextEn.GetHashCode();
		}
		if (TextJp.Length != 0)
		{
			num ^= TextJp.GetHashCode();
		}
		if (TextTw.Length != 0)
		{
			num ^= TextTw.GetHashCode();
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
		if (Date.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Date);
		}
		if (Id != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Id);
		}
		if (Text.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Text);
		}
		if (TextCn.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(TextCn);
		}
		if (TextEn.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(TextEn);
		}
		if (TextJp.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(TextJp);
		}
		if (TextTw.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(TextTw);
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
		if (Date.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Date);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (Text.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Text);
		}
		if (TextCn.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TextCn);
		}
		if (TextEn.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TextEn);
		}
		if (TextJp.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TextJp);
		}
		if (TextTw.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TextTw);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LocalTextTable other)
	{
		if (other != null)
		{
			if (other.Date.Length != 0)
			{
				Date = other.Date;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Text.Length != 0)
			{
				Text = other.Text;
			}
			if (other.TextCn.Length != 0)
			{
				TextCn = other.TextCn;
			}
			if (other.TextEn.Length != 0)
			{
				TextEn = other.TextEn;
			}
			if (other.TextJp.Length != 0)
			{
				TextJp = other.TextJp;
			}
			if (other.TextTw.Length != 0)
			{
				TextTw = other.TextTw;
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
			case 10u:
				Date = input.ReadString();
				break;
			case 16u:
				Id = input.ReadInt32();
				break;
			case 26u:
				Text = input.ReadString();
				break;
			case 34u:
				TextCn = input.ReadString();
				break;
			case 42u:
				TextEn = input.ReadString();
				break;
			case 50u:
				TextJp = input.ReadString();
				break;
			case 58u:
				TextTw = input.ReadString();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
