using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class CookingResearchResponse : IMessage<CookingResearchResponse>, IMessage, IEquatable<CookingResearchResponse>, IDeepCloneable<CookingResearchResponse>, IBufferMessage
{
	private static readonly MessageParser<CookingResearchResponse> _parser = new MessageParser<CookingResearchResponse>(() => new CookingResearchResponse());

	private UnknownFieldSet _unknownFields;

	public const int ItemInfoFieldNumber = 1;

	private ItemDBInfo itemInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CookingResearchResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => CookingResearchResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemDBInfo ItemInfo
	{
		get
		{
			return itemInfo_;
		}
		set
		{
			itemInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CookingResearchResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CookingResearchResponse(CookingResearchResponse other)
		: this()
	{
		itemInfo_ = ((other.itemInfo_ != null) ? other.itemInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CookingResearchResponse Clone()
	{
		return new CookingResearchResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CookingResearchResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CookingResearchResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(ItemInfo, other.ItemInfo))
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
		if (itemInfo_ != null)
		{
			num ^= ItemInfo.GetHashCode();
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
		if (itemInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(ItemInfo);
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
		if (itemInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ItemInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CookingResearchResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.itemInfo_ != null)
		{
			if (itemInfo_ == null)
			{
				ItemInfo = new ItemDBInfo();
			}
			ItemInfo.MergeFrom(other.ItemInfo);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (itemInfo_ == null)
			{
				ItemInfo = new ItemDBInfo();
			}
			input.ReadMessage(ItemInfo);
		}
	}
}
