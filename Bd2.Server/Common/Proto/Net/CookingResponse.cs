using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class CookingResponse : IMessage<CookingResponse>, IMessage, IEquatable<CookingResponse>, IDeepCloneable<CookingResponse>, IBufferMessage
{
	private static readonly MessageParser<CookingResponse> _parser = new MessageParser<CookingResponse>(() => new CookingResponse());

	private UnknownFieldSet _unknownFields;

	public const int ItemInfoFieldNumber = 1;

	private static readonly FieldCodec<ItemDBInfo> _repeated_itemInfo_codec = FieldCodec.ForMessage(10u, ItemDBInfo.Parser);

	private readonly RepeatedField<ItemDBInfo> itemInfo_ = new RepeatedField<ItemDBInfo>();

	public const int AddTalentExpFieldNumber = 2;

	private int addTalentExp_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CookingResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CookingResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ItemDBInfo> ItemInfo => itemInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AddTalentExp
	{
		get
		{
			return addTalentExp_;
		}
		set
		{
			addTalentExp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CookingResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CookingResponse(CookingResponse other)
		: this()
	{
		itemInfo_ = other.itemInfo_.Clone();
		addTalentExp_ = other.addTalentExp_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CookingResponse Clone()
	{
		return new CookingResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as CookingResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CookingResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (itemInfo_.Equals(other.itemInfo_) && AddTalentExp == other.AddTalentExp)
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
		num ^= itemInfo_.GetHashCode();
		if (AddTalentExp != 0)
		{
			num ^= AddTalentExp.GetHashCode();
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
		itemInfo_.WriteTo(ref output, _repeated_itemInfo_codec);
		if (AddTalentExp != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(AddTalentExp);
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
		num += itemInfo_.CalculateSize(_repeated_itemInfo_codec);
		if (AddTalentExp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AddTalentExp);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CookingResponse other)
	{
		if (other != null)
		{
			itemInfo_.Add(other.itemInfo_);
			if (other.AddTalentExp != 0)
			{
				AddTalentExp = other.AddTalentExp;
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
			case 16u:
				AddTalentExp = input.ReadInt32();
				break;
			case 10u:
				itemInfo_.AddEntriesFrom(ref input, _repeated_itemInfo_codec);
				break;
			}
		}
	}
}
