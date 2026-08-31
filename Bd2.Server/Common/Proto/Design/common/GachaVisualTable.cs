using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class GachaVisualTable : IMessage<GachaVisualTable>, IMessage, IEquatable<GachaVisualTable>, IDeepCloneable<GachaVisualTable>, IBufferMessage
{
	private static readonly MessageParser<GachaVisualTable> _parser = new MessageParser<GachaVisualTable>(() => new GachaVisualTable());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int TypeFieldNumber = 2;

	private int type_;

	public const int VisualLocalTextIDFieldNumber = 3;

	private int visualLocalTextID_;

	public const int VoiceResourceNameFieldNumber = 4;

	private string voiceResourceName_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GachaVisualTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GachaVisualTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public int Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int VisualLocalTextID
	{
		get
		{
			return visualLocalTextID_;
		}
		set
		{
			visualLocalTextID_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaVisualTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GachaVisualTable(GachaVisualTable other)
		: this()
	{
		id_ = other.id_;
		type_ = other.type_;
		visualLocalTextID_ = other.visualLocalTextID_;
		voiceResourceName_ = other.voiceResourceName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GachaVisualTable Clone()
	{
		return new GachaVisualTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GachaVisualTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GachaVisualTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && Type == other.Type && VisualLocalTextID == other.VisualLocalTextID && !(VoiceResourceName != other.VoiceResourceName))
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
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (Type != 0)
		{
			num ^= Type.GetHashCode();
		}
		if (VisualLocalTextID != 0)
		{
			num ^= VisualLocalTextID.GetHashCode();
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
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (Type != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Type);
		}
		if (VisualLocalTextID != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(VisualLocalTextID);
		}
		if (VoiceResourceName.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(VoiceResourceName);
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
		if (Type != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Type);
		}
		if (VisualLocalTextID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(VisualLocalTextID);
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
	public void MergeFrom(GachaVisualTable other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Type != 0)
			{
				Type = other.Type;
			}
			if (other.VisualLocalTextID != 0)
			{
				VisualLocalTextID = other.VisualLocalTextID;
			}
			if (other.VoiceResourceName.Length != 0)
			{
				VoiceResourceName = other.VoiceResourceName;
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
			case 16u:
				Type = input.ReadInt32();
				break;
			case 24u:
				VisualLocalTextID = input.ReadInt32();
				break;
			case 34u:
				VoiceResourceName = input.ReadString();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
