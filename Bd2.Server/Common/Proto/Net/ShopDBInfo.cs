using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class ShopDBInfo : IMessage<ShopDBInfo>, IMessage, IEquatable<ShopDBInfo>, IDeepCloneable<ShopDBInfo>, IBufferMessage
{
	private static readonly MessageParser<ShopDBInfo> _parser = new MessageParser<ShopDBInfo>(() => new ShopDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int ShopRemainTimeFieldNumber = 1;

	private int shopRemainTime_;

	public const int ShopRandSeedFieldNumber = 2;

	private int shopRandSeed_;

	public const int ProductInfoFieldNumber = 3;

	private static readonly FieldCodec<ProductDBInfo> _repeated_productInfo_codec = FieldCodec.ForMessage(26u, ProductDBInfo.Parser);

	private readonly RepeatedField<ProductDBInfo> productInfo_ = new RepeatedField<ProductDBInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ShopDBInfo> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => ShopDBInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ShopRemainTime
	{
		get
		{
			return shopRemainTime_;
		}
		set
		{
			shopRemainTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ShopRandSeed
	{
		get
		{
			return shopRandSeed_;
		}
		set
		{
			shopRandSeed_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ProductDBInfo> ProductInfo => productInfo_;

	public long ShopRemainTick { get; set; }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShopDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShopDBInfo(ShopDBInfo other)
		: this()
	{
		shopRemainTime_ = other.shopRemainTime_;
		shopRandSeed_ = other.shopRandSeed_;
		productInfo_ = other.productInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShopDBInfo Clone()
	{
		return new ShopDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ShopDBInfo);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ShopDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (ShopRemainTime == other.ShopRemainTime && ShopRandSeed == other.ShopRandSeed && productInfo_.Equals(other.productInfo_))
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
		if (ShopRemainTime != 0)
		{
			num ^= ShopRemainTime.GetHashCode();
		}
		if (ShopRandSeed != 0)
		{
			num ^= ShopRandSeed.GetHashCode();
		}
		num ^= productInfo_.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (ShopRemainTime != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ShopRemainTime);
		}
		if (ShopRandSeed != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ShopRandSeed);
		}
		productInfo_.WriteTo(ref output, _repeated_productInfo_codec);
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
		if (ShopRemainTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ShopRemainTime);
		}
		if (ShopRandSeed != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ShopRandSeed);
		}
		num += productInfo_.CalculateSize(_repeated_productInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ShopDBInfo other)
	{
		if (other != null)
		{
			if (other.ShopRemainTime != 0)
			{
				ShopRemainTime = other.ShopRemainTime;
			}
			if (other.ShopRandSeed != 0)
			{
				ShopRandSeed = other.ShopRandSeed;
			}
			productInfo_.Add(other.productInfo_);
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 26u:
				productInfo_.AddEntriesFrom(ref input, _repeated_productInfo_codec);
				break;
			case 16u:
				ShopRandSeed = input.ReadInt32();
				break;
			case 8u:
				ShopRemainTime = input.ReadInt32();
				break;
			}
		}
	}
}
