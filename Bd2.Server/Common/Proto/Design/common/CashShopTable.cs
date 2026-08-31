using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class CashShopTable : IMessage<CashShopTable>, IMessage, IEquatable<CashShopTable>, IDeepCloneable<CashShopTable>, IBufferMessage
{
	private static readonly MessageParser<CashShopTable> _parser = new MessageParser<CashShopTable>(() => new CashShopTable());

	private UnknownFieldSet _unknownFields;

	public const int GroupIdFieldNumber = 1;

	private int groupId_;

	public const int IdFieldNumber = 2;

	private int id_;

	public const int IllustNameFieldNumber = 3;

	private string illustName_ = "";

	public const int PriceIdFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_priceId_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> priceId_ = new RepeatedField<int>();

	public const int PriceTypeFieldNumber = 5;

	private static readonly FieldCodec<int> _repeated_priceType_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> priceType_ = new RepeatedField<int>();

	public const int PriorityFieldNumber = 6;

	private int priority_;

	public const int ProductGroupIdFieldNumber = 7;

	private int productGroupId_;

	public const int ResourceNameFieldNumber = 8;

	private string resourceName_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CashShopTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CashShopTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public string IllustName
	{
		get
		{
			return illustName_;
		}
		set
		{
			illustName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> PriceId => priceId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> PriceType => priceType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Priority
	{
		get
		{
			return priority_;
		}
		set
		{
			priority_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ProductGroupId
	{
		get
		{
			return productGroupId_;
		}
		set
		{
			productGroupId_ = value;
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CashShopTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CashShopTable(CashShopTable other)
		: this()
	{
		groupId_ = other.groupId_;
		id_ = other.id_;
		illustName_ = other.illustName_;
		priceId_ = other.priceId_.Clone();
		priceType_ = other.priceType_.Clone();
		priority_ = other.priority_;
		productGroupId_ = other.productGroupId_;
		resourceName_ = other.resourceName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CashShopTable Clone()
	{
		return new CashShopTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as CashShopTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CashShopTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (GroupId == other.GroupId && Id == other.Id && !(IllustName != other.IllustName) && priceId_.Equals(other.priceId_) && priceType_.Equals(other.priceType_) && Priority == other.Priority && ProductGroupId == other.ProductGroupId && !(ResourceName != other.ResourceName))
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
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (IllustName.Length != 0)
		{
			num ^= IllustName.GetHashCode();
		}
		num ^= priceId_.GetHashCode();
		num ^= priceType_.GetHashCode();
		if (Priority != 0)
		{
			num ^= Priority.GetHashCode();
		}
		if (ProductGroupId != 0)
		{
			num ^= ProductGroupId.GetHashCode();
		}
		if (ResourceName.Length != 0)
		{
			num ^= ResourceName.GetHashCode();
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
		if (GroupId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(GroupId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Id);
		}
		if (IllustName.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(IllustName);
		}
		priceId_.WriteTo(ref output, _repeated_priceId_codec);
		priceType_.WriteTo(ref output, _repeated_priceType_codec);
		if (Priority != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(Priority);
		}
		if (ProductGroupId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(ProductGroupId);
		}
		if (ResourceName.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(ResourceName);
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
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (IllustName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(IllustName);
		}
		num += priceId_.CalculateSize(_repeated_priceId_codec);
		num += priceType_.CalculateSize(_repeated_priceType_codec);
		if (Priority != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Priority);
		}
		if (ProductGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ProductGroupId);
		}
		if (ResourceName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ResourceName);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CashShopTable other)
	{
		if (other != null)
		{
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.IllustName.Length != 0)
			{
				IllustName = other.IllustName;
			}
			priceId_.Add(other.priceId_);
			priceType_.Add(other.priceType_);
			if (other.Priority != 0)
			{
				Priority = other.Priority;
			}
			if (other.ProductGroupId != 0)
			{
				ProductGroupId = other.ProductGroupId;
			}
			if (other.ResourceName.Length != 0)
			{
				ResourceName = other.ResourceName;
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
				Id = input.ReadInt32();
				break;
			case 26u:
				IllustName = input.ReadString();
				break;
			case 32u:
			case 34u:
				priceId_.AddEntriesFrom(ref input, _repeated_priceId_codec);
				break;
			case 40u:
			case 42u:
				priceType_.AddEntriesFrom(ref input, _repeated_priceType_codec);
				break;
			case 48u:
				Priority = input.ReadInt32();
				break;
			case 56u:
				ProductGroupId = input.ReadInt32();
				break;
			case 66u:
				ResourceName = input.ReadString();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
