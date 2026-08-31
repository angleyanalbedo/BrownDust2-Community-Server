using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class EventShopTable : IMessage<EventShopTable>, IMessage, IEquatable<EventShopTable>, IDeepCloneable<EventShopTable>, IBufferMessage
{
	private static readonly MessageParser<EventShopTable> _parser = new MessageParser<EventShopTable>(() => new EventShopTable());

	private UnknownFieldSet _unknownFields;

	public const int EventTextIdFieldNumber = 1;

	private int eventTextId_;

	public const int IdFieldNumber = 2;

	private int id_;

	public const int PriceIdFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_priceId_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> priceId_ = new RepeatedField<int>();

	public const int PriceTypeFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_priceType_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> priceType_ = new RepeatedField<int>();

	public const int ProductGroupIdFieldNumber = 5;

	private int productGroupId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EventShopTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EventShopTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int EventTextId
	{
		get
		{
			return eventTextId_;
		}
		set
		{
			eventTextId_ = value;
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
	public RepeatedField<int> PriceId => priceId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> PriceType => priceType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventShopTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EventShopTable(EventShopTable other)
		: this()
	{
		eventTextId_ = other.eventTextId_;
		id_ = other.id_;
		priceId_ = other.priceId_.Clone();
		priceType_ = other.priceType_.Clone();
		productGroupId_ = other.productGroupId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventShopTable Clone()
	{
		return new EventShopTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as EventShopTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(EventShopTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (EventTextId == other.EventTextId && Id == other.Id && priceId_.Equals(other.priceId_) && priceType_.Equals(other.priceType_) && ProductGroupId == other.ProductGroupId)
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
		if (EventTextId != 0)
		{
			num ^= EventTextId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		num ^= priceId_.GetHashCode();
		num ^= priceType_.GetHashCode();
		if (ProductGroupId != 0)
		{
			num ^= ProductGroupId.GetHashCode();
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
		if (EventTextId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(EventTextId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Id);
		}
		priceId_.WriteTo(ref output, _repeated_priceId_codec);
		priceType_.WriteTo(ref output, _repeated_priceType_codec);
		if (ProductGroupId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(ProductGroupId);
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
		if (EventTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventTextId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		num += priceId_.CalculateSize(_repeated_priceId_codec);
		num += priceType_.CalculateSize(_repeated_priceType_codec);
		if (ProductGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ProductGroupId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EventShopTable other)
	{
		if (other != null)
		{
			if (other.EventTextId != 0)
			{
				EventTextId = other.EventTextId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			priceId_.Add(other.priceId_);
			priceType_.Add(other.priceType_);
			if (other.ProductGroupId != 0)
			{
				ProductGroupId = other.ProductGroupId;
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
			case 40u:
				ProductGroupId = input.ReadInt32();
				break;
			case 32u:
			case 34u:
				priceType_.AddEntriesFrom(ref input, _repeated_priceType_codec);
				break;
			case 8u:
				EventTextId = input.ReadInt32();
				break;
			case 16u:
				Id = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 24u:
			case 26u:
				priceId_.AddEntriesFrom(ref input, _repeated_priceId_codec);
				break;
			}
		}
	}
}
