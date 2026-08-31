using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class UpdateIntroduceTable : IMessage<UpdateIntroduceTable>, IMessage, IEquatable<UpdateIntroduceTable>, IDeepCloneable<UpdateIntroduceTable>, IBufferMessage
{
	private static readonly MessageParser<UpdateIntroduceTable> _parser = new MessageParser<UpdateIntroduceTable>(() => new UpdateIntroduceTable());

	private UnknownFieldSet _unknownFields;

	public const int CostumeIllustPathFieldNumber = 1;

	private string costumeIllustPath_ = "";

	public const int IdFieldNumber = 2;

	private int id_;

	public const int MagicIdFieldNumber = 3;

	private int magicId_;

	public const int OrderIdFieldNumber = 4;

	private int orderId_;

	public const int ResourcePathFieldNumber = 5;

	private string resourcePath_ = "";

	public const int SubMagicIdFieldNumber = 6;

	private int subMagicId_;

	public const int TypeFieldNumber = 7;

	private int type_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<UpdateIntroduceTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => UpdateIntroduceTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string CostumeIllustPath
	{
		get
		{
			return costumeIllustPath_;
		}
		set
		{
			costumeIllustPath_ = ProtoPreconditions.CheckNotNull(value, "value");
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
	public int MagicId
	{
		get
		{
			return magicId_;
		}
		set
		{
			magicId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int OrderId
	{
		get
		{
			return orderId_;
		}
		set
		{
			orderId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string ResourcePath
	{
		get
		{
			return resourcePath_;
		}
		set
		{
			resourcePath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SubMagicId
	{
		get
		{
			return subMagicId_;
		}
		set
		{
			subMagicId_ = value;
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
	public UpdateIntroduceTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateIntroduceTable(UpdateIntroduceTable other)
		: this()
	{
		costumeIllustPath_ = other.costumeIllustPath_;
		id_ = other.id_;
		magicId_ = other.magicId_;
		orderId_ = other.orderId_;
		resourcePath_ = other.resourcePath_;
		subMagicId_ = other.subMagicId_;
		type_ = other.type_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateIntroduceTable Clone()
	{
		return new UpdateIntroduceTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as UpdateIntroduceTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UpdateIntroduceTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (!(CostumeIllustPath != other.CostumeIllustPath) && Id == other.Id && MagicId == other.MagicId && OrderId == other.OrderId && !(ResourcePath != other.ResourcePath) && SubMagicId == other.SubMagicId && Type == other.Type)
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
		if (CostumeIllustPath.Length != 0)
		{
			num ^= CostumeIllustPath.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (MagicId != 0)
		{
			num ^= MagicId.GetHashCode();
		}
		if (OrderId != 0)
		{
			num ^= OrderId.GetHashCode();
		}
		if (ResourcePath.Length != 0)
		{
			num ^= ResourcePath.GetHashCode();
		}
		if (SubMagicId != 0)
		{
			num ^= SubMagicId.GetHashCode();
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (CostumeIllustPath.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(CostumeIllustPath);
		}
		if (Id != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Id);
		}
		if (MagicId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(MagicId);
		}
		if (OrderId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(OrderId);
		}
		if (ResourcePath.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(ResourcePath);
		}
		if (SubMagicId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(SubMagicId);
		}
		if (Type != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(Type);
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
		if (CostumeIllustPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(CostumeIllustPath);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (MagicId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MagicId);
		}
		if (OrderId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OrderId);
		}
		if (ResourcePath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ResourcePath);
		}
		if (SubMagicId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SubMagicId);
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
	public void MergeFrom(UpdateIntroduceTable other)
	{
		if (other != null)
		{
			if (other.CostumeIllustPath.Length != 0)
			{
				CostumeIllustPath = other.CostumeIllustPath;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.MagicId != 0)
			{
				MagicId = other.MagicId;
			}
			if (other.OrderId != 0)
			{
				OrderId = other.OrderId;
			}
			if (other.ResourcePath.Length != 0)
			{
				ResourcePath = other.ResourcePath;
			}
			if (other.SubMagicId != 0)
			{
				SubMagicId = other.SubMagicId;
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			case 10u:
				CostumeIllustPath = input.ReadString();
				break;
			case 16u:
				Id = input.ReadInt32();
				break;
			case 24u:
				MagicId = input.ReadInt32();
				break;
			case 32u:
				OrderId = input.ReadInt32();
				break;
			case 42u:
				ResourcePath = input.ReadString();
				break;
			case 48u:
				SubMagicId = input.ReadInt32();
				break;
			case 56u:
				Type = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
