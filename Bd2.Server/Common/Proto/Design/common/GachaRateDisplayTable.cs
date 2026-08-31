using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class GachaRateDisplayTable : IMessage<GachaRateDisplayTable>, IMessage, IEquatable<GachaRateDisplayTable>, IDeepCloneable<GachaRateDisplayTable>, IBufferMessage
{
	private static readonly MessageParser<GachaRateDisplayTable> _parser = new MessageParser<GachaRateDisplayTable>(() => new GachaRateDisplayTable());

	private UnknownFieldSet _unknownFields;

	public const int DisplayRateFieldNumber = 1;

	private double displayRate_;

	public const int GachaGroupIdFieldNumber = 2;

	private int gachaGroupId_;

	public const int GroupIdFieldNumber = 3;

	private int groupId_;

	public const int IdFieldNumber = 4;

	private int id_;

	public const int NameLocalTextFieldNumber = 5;

	private int nameLocalText_;

	public const int TypeFieldNumber = 6;

	private int type_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GachaRateDisplayTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => GachaRateDisplayTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double DisplayRate
	{
		get
		{
			return displayRate_;
		}
		set
		{
			displayRate_ = value;
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int NameLocalText
	{
		get
		{
			return nameLocalText_;
		}
		set
		{
			nameLocalText_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaRateDisplayTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaRateDisplayTable(GachaRateDisplayTable other)
		: this()
	{
		displayRate_ = other.displayRate_;
		gachaGroupId_ = other.gachaGroupId_;
		groupId_ = other.groupId_;
		id_ = other.id_;
		nameLocalText_ = other.nameLocalText_;
		type_ = other.type_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GachaRateDisplayTable Clone()
	{
		return new GachaRateDisplayTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GachaRateDisplayTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GachaRateDisplayTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(DisplayRate, other.DisplayRate) && GachaGroupId == other.GachaGroupId && GroupId == other.GroupId && Id == other.Id && NameLocalText == other.NameLocalText && Type == other.Type)
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
		if (DisplayRate != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(DisplayRate);
		}
		if (GachaGroupId != 0)
		{
			num ^= GachaGroupId.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (NameLocalText != 0)
		{
			num ^= NameLocalText.GetHashCode();
		}
		if (Type != 0)
		{
			num ^= Type.GetHashCode();
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
		if (DisplayRate != 0.0)
		{
			output.WriteRawTag(9);
			output.WriteDouble(DisplayRate);
		}
		if (GachaGroupId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(GachaGroupId);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(GroupId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Id);
		}
		if (NameLocalText != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(NameLocalText);
		}
		if (Type != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(Type);
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
		if (DisplayRate != 0.0)
		{
			num += 9;
		}
		if (GachaGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GachaGroupId);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (NameLocalText != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NameLocalText);
		}
		if (Type != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Type);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GachaRateDisplayTable other)
	{
		if (other != null)
		{
			if (other.DisplayRate != 0.0)
			{
				DisplayRate = other.DisplayRate;
			}
			if (other.GachaGroupId != 0)
			{
				GachaGroupId = other.GachaGroupId;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.NameLocalText != 0)
			{
				NameLocalText = other.NameLocalText;
			}
			if (other.Type != 0)
			{
				Type = other.Type;
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
			case 9u:
				DisplayRate = input.ReadDouble();
				break;
			case 16u:
				GachaGroupId = input.ReadInt32();
				break;
			case 24u:
				GroupId = input.ReadInt32();
				break;
			case 32u:
				Id = input.ReadInt32();
				break;
			case 40u:
				NameLocalText = input.ReadInt32();
				break;
			case 48u:
				Type = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
