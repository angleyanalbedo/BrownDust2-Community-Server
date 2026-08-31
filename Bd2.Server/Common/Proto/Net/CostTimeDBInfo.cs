using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class CostTimeDBInfo : IMessage<CostTimeDBInfo>, IMessage, IEquatable<CostTimeDBInfo>, IDeepCloneable<CostTimeDBInfo>, IBufferMessage
{
	private static readonly MessageParser<CostTimeDBInfo> _parser = new MessageParser<CostTimeDBInfo>(() => new CostTimeDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int LastChargeTimeFieldNumber = 1;

	private long lastChargeTime_;

	public const int CostItemInfoFieldNumber = 2;

	private ItemDBInfo costItemInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CostTimeDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CostTimeDBInfoReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long LastChargeTime
	{
		get
		{
			return lastChargeTime_;
		}
		set
		{
			lastChargeTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemDBInfo CostItemInfo
	{
		get
		{
			return costItemInfo_;
		}
		set
		{
			costItemInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CostTimeDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CostTimeDBInfo(CostTimeDBInfo other)
		: this()
	{
		lastChargeTime_ = other.lastChargeTime_;
		costItemInfo_ = ((other.costItemInfo_ != null) ? other.costItemInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CostTimeDBInfo Clone()
	{
		return new CostTimeDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CostTimeDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CostTimeDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (LastChargeTime == other.LastChargeTime && object.Equals(CostItemInfo, other.CostItemInfo))
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
		if (LastChargeTime != 0L)
		{
			num ^= LastChargeTime.GetHashCode();
		}
		if (costItemInfo_ != null)
		{
			num ^= CostItemInfo.GetHashCode();
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
		if (LastChargeTime != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(LastChargeTime);
		}
		if (costItemInfo_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(CostItemInfo);
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
		if (LastChargeTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(LastChargeTime);
		}
		if (costItemInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CostItemInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CostTimeDBInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.LastChargeTime != 0L)
		{
			LastChargeTime = other.LastChargeTime;
		}
		if (other.costItemInfo_ != null)
		{
			if (costItemInfo_ == null)
			{
				CostItemInfo = new ItemDBInfo();
			}
			CostItemInfo.MergeFrom(other.CostItemInfo);
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 18u:
				if (costItemInfo_ == null)
				{
					CostItemInfo = new ItemDBInfo();
				}
				input.ReadMessage(CostItemInfo);
				break;
			case 8u:
				LastChargeTime = input.ReadInt64();
				break;
			}
		}
	}
}
