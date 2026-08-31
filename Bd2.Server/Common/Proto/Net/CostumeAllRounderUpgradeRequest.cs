using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class CostumeAllRounderUpgradeRequest : IMessage<CostumeAllRounderUpgradeRequest>, IMessage, IEquatable<CostumeAllRounderUpgradeRequest>, IDeepCloneable<CostumeAllRounderUpgradeRequest>, IBufferMessage
{
	private static readonly MessageParser<CostumeAllRounderUpgradeRequest> _parser = new MessageParser<CostumeAllRounderUpgradeRequest>(() => new CostumeAllRounderUpgradeRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int CostumeInvenIndexFieldNumber = 2;

	private long costumeInvenIndex_;

	public const int ProductGroupIdFieldNumber = 3;

	private int productGroupId_;

	public const int ProductIdFieldNumber = 4;

	private int productId_;

	public const int UseItemInfoFieldNumber = 5;

	private static readonly FieldCodec<ItemDBInfo> _repeated_useItemInfo_codec = FieldCodec.ForMessage(42u, ItemDBInfo.Parser);

	private readonly RepeatedField<ItemDBInfo> useItemInfo_ = new RepeatedField<ItemDBInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CostumeAllRounderUpgradeRequest> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => CostumeAllRounderUpgradeRequestReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Seq
	{
		get
		{
			return seq_;
		}
		set
		{
			seq_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long CostumeInvenIndex
	{
		get
		{
			return costumeInvenIndex_;
		}
		set
		{
			costumeInvenIndex_ = value;
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
	public int ProductId
	{
		get
		{
			return productId_;
		}
		set
		{
			productId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ItemDBInfo> UseItemInfo => useItemInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CostumeAllRounderUpgradeRequest()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CostumeAllRounderUpgradeRequest(CostumeAllRounderUpgradeRequest other)
		: this()
	{
		seq_ = other.seq_;
		costumeInvenIndex_ = other.costumeInvenIndex_;
		productGroupId_ = other.productGroupId_;
		productId_ = other.productId_;
		useItemInfo_ = other.useItemInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CostumeAllRounderUpgradeRequest Clone()
	{
		return new CostumeAllRounderUpgradeRequest(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as CostumeAllRounderUpgradeRequest);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CostumeAllRounderUpgradeRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && CostumeInvenIndex == other.CostumeInvenIndex && ProductGroupId == other.ProductGroupId && ProductId == other.ProductId && useItemInfo_.Equals(other.useItemInfo_))
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
		if (Seq != 0)
		{
			num ^= Seq.GetHashCode();
		}
		if (CostumeInvenIndex != 0L)
		{
			num ^= CostumeInvenIndex.GetHashCode();
		}
		if (ProductGroupId != 0)
		{
			num ^= ProductGroupId.GetHashCode();
		}
		if (ProductId != 0)
		{
			num ^= ProductId.GetHashCode();
		}
		num ^= useItemInfo_.GetHashCode();
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
		if (Seq != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Seq);
		}
		if (CostumeInvenIndex != 0L)
		{
			output.WriteRawTag(16);
			output.WriteInt64(CostumeInvenIndex);
		}
		if (ProductGroupId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ProductGroupId);
		}
		if (ProductId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ProductId);
		}
		useItemInfo_.WriteTo(ref output, _repeated_useItemInfo_codec);
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
		if (Seq != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Seq);
		}
		if (CostumeInvenIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(CostumeInvenIndex);
		}
		if (ProductGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ProductGroupId);
		}
		if (ProductId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ProductId);
		}
		num += useItemInfo_.CalculateSize(_repeated_useItemInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CostumeAllRounderUpgradeRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			if (other.CostumeInvenIndex != 0L)
			{
				CostumeInvenIndex = other.CostumeInvenIndex;
			}
			if (other.ProductGroupId != 0)
			{
				ProductGroupId = other.ProductGroupId;
			}
			if (other.ProductId != 0)
			{
				ProductId = other.ProductId;
			}
			useItemInfo_.Add(other.useItemInfo_);
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
				Seq = input.ReadInt32();
				break;
			case 16u:
				CostumeInvenIndex = input.ReadInt64();
				break;
			case 24u:
				ProductGroupId = input.ReadInt32();
				break;
			case 32u:
				ProductId = input.ReadInt32();
				break;
			case 42u:
				useItemInfo_.AddEntriesFrom(ref input, _repeated_useItemInfo_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
