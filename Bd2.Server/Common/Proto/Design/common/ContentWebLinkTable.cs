using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class ContentWebLinkTable : IMessage<ContentWebLinkTable>, IMessage, IEquatable<ContentWebLinkTable>, IDeepCloneable<ContentWebLinkTable>, IBufferMessage
{
	private static readonly MessageParser<ContentWebLinkTable> _parser = new MessageParser<ContentWebLinkTable>(() => new ContentWebLinkTable());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int LinkUrlPathCnFieldNumber = 2;

	private string linkUrlPathCn_ = "";

	public const int LinkUrlPathEnFieldNumber = 3;

	private string linkUrlPathEn_ = "";

	public const int LinkUrlPathJpFieldNumber = 4;

	private string linkUrlPathJp_ = "";

	public const int LinkUrlPathKrFieldNumber = 5;

	private string linkUrlPathKr_ = "";

	public const int LinkUrlPathTwFieldNumber = 6;

	private string linkUrlPathTw_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ContentWebLinkTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ContentWebLinkTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public string LinkUrlPathCn
	{
		get
		{
			return linkUrlPathCn_;
		}
		set
		{
			linkUrlPathCn_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string LinkUrlPathEn
	{
		get
		{
			return linkUrlPathEn_;
		}
		set
		{
			linkUrlPathEn_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string LinkUrlPathJp
	{
		get
		{
			return linkUrlPathJp_;
		}
		set
		{
			linkUrlPathJp_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string LinkUrlPathKr
	{
		get
		{
			return linkUrlPathKr_;
		}
		set
		{
			linkUrlPathKr_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string LinkUrlPathTw
	{
		get
		{
			return linkUrlPathTw_;
		}
		set
		{
			linkUrlPathTw_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ContentWebLinkTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContentWebLinkTable(ContentWebLinkTable other)
		: this()
	{
		id_ = other.id_;
		linkUrlPathCn_ = other.linkUrlPathCn_;
		linkUrlPathEn_ = other.linkUrlPathEn_;
		linkUrlPathJp_ = other.linkUrlPathJp_;
		linkUrlPathKr_ = other.linkUrlPathKr_;
		linkUrlPathTw_ = other.linkUrlPathTw_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContentWebLinkTable Clone()
	{
		return new ContentWebLinkTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ContentWebLinkTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ContentWebLinkTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && !(LinkUrlPathCn != other.LinkUrlPathCn) && !(LinkUrlPathEn != other.LinkUrlPathEn) && !(LinkUrlPathJp != other.LinkUrlPathJp) && !(LinkUrlPathKr != other.LinkUrlPathKr) && !(LinkUrlPathTw != other.LinkUrlPathTw))
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
		if (LinkUrlPathCn.Length != 0)
		{
			num ^= LinkUrlPathCn.GetHashCode();
		}
		if (LinkUrlPathEn.Length != 0)
		{
			num ^= LinkUrlPathEn.GetHashCode();
		}
		if (LinkUrlPathJp.Length != 0)
		{
			num ^= LinkUrlPathJp.GetHashCode();
		}
		if (LinkUrlPathKr.Length != 0)
		{
			num ^= LinkUrlPathKr.GetHashCode();
		}
		if (LinkUrlPathTw.Length != 0)
		{
			num ^= LinkUrlPathTw.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (LinkUrlPathCn.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(LinkUrlPathCn);
		}
		if (LinkUrlPathEn.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(LinkUrlPathEn);
		}
		if (LinkUrlPathJp.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(LinkUrlPathJp);
		}
		if (LinkUrlPathKr.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(LinkUrlPathKr);
		}
		if (LinkUrlPathTw.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(LinkUrlPathTw);
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
		if (LinkUrlPathCn.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LinkUrlPathCn);
		}
		if (LinkUrlPathEn.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LinkUrlPathEn);
		}
		if (LinkUrlPathJp.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LinkUrlPathJp);
		}
		if (LinkUrlPathKr.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LinkUrlPathKr);
		}
		if (LinkUrlPathTw.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LinkUrlPathTw);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ContentWebLinkTable other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.LinkUrlPathCn.Length != 0)
			{
				LinkUrlPathCn = other.LinkUrlPathCn;
			}
			if (other.LinkUrlPathEn.Length != 0)
			{
				LinkUrlPathEn = other.LinkUrlPathEn;
			}
			if (other.LinkUrlPathJp.Length != 0)
			{
				LinkUrlPathJp = other.LinkUrlPathJp;
			}
			if (other.LinkUrlPathKr.Length != 0)
			{
				LinkUrlPathKr = other.LinkUrlPathKr;
			}
			if (other.LinkUrlPathTw.Length != 0)
			{
				LinkUrlPathTw = other.LinkUrlPathTw;
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
				Id = input.ReadInt32();
				break;
			case 18u:
				LinkUrlPathCn = input.ReadString();
				break;
			case 26u:
				LinkUrlPathEn = input.ReadString();
				break;
			case 34u:
				LinkUrlPathJp = input.ReadString();
				break;
			case 42u:
				LinkUrlPathKr = input.ReadString();
				break;
			case 50u:
				LinkUrlPathTw = input.ReadString();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
