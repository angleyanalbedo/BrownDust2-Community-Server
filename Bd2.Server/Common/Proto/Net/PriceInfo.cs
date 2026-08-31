using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PriceInfo : IMessage<PriceInfo>, IMessage, IEquatable<PriceInfo>, IDeepCloneable<PriceInfo>, IBufferMessage
{
	private static readonly MessageParser<PriceInfo> _parser = new MessageParser<PriceInfo>(() => new PriceInfo());

	private UnknownFieldSet _unknownFields;

	public const int PriceCurrencyCodeFieldNumber = 1;

	private string priceCurrencyCode_ = "";

	public const int PriceFieldNumber = 2;

	private float price_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PriceInfo> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => PriceInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string PriceCurrencyCode
	{
		get
		{
			return priceCurrencyCode_;
		}
		set
		{
			priceCurrencyCode_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public float Price
	{
		get
		{
			return price_;
		}
		set
		{
			price_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PriceInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PriceInfo(PriceInfo other)
		: this()
	{
		priceCurrencyCode_ = other.priceCurrencyCode_;
		price_ = other.price_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PriceInfo Clone()
	{
		return new PriceInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PriceInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PriceInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (!(PriceCurrencyCode != other.PriceCurrencyCode) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Price, other.Price))
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
		if (PriceCurrencyCode.Length != 0)
		{
			num ^= PriceCurrencyCode.GetHashCode();
		}
		if (Price != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Price);
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
		if (PriceCurrencyCode.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(PriceCurrencyCode);
		}
		if (Price != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(Price);
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
		if (PriceCurrencyCode.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PriceCurrencyCode);
		}
		if (Price != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PriceInfo other)
	{
		if (other != null)
		{
			if (other.PriceCurrencyCode.Length != 0)
			{
				PriceCurrencyCode = other.PriceCurrencyCode;
			}
			if (other.Price != 0f)
			{
				Price = other.Price;
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 21u:
				Price = input.ReadFloat();
				break;
			case 10u:
				PriceCurrencyCode = input.ReadString();
				break;
			}
		}
	}
}
