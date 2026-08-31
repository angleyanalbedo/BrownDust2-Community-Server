using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PackSubQuestClearInfo : IMessage<PackSubQuestClearInfo>, IMessage, IEquatable<PackSubQuestClearInfo>, IDeepCloneable<PackSubQuestClearInfo>, IBufferMessage
{
	private static readonly MessageParser<PackSubQuestClearInfo> _parser = new MessageParser<PackSubQuestClearInfo>(() => new PackSubQuestClearInfo());

	private UnknownFieldSet _unknownFields;

	public const int PackIdFieldNumber = 1;

	private int packId_;

	public const int SubQuestClearCountFieldNumber = 2;

	private int subQuestClearCount_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PackSubQuestClearInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PackSubQuestClearInfoResponseReflection.Descriptor.MessageTypes[1];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PackId
	{
		get
		{
			return packId_;
		}
		set
		{
			packId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SubQuestClearCount
	{
		get
		{
			return subQuestClearCount_;
		}
		set
		{
			subQuestClearCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackSubQuestClearInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackSubQuestClearInfo(PackSubQuestClearInfo other)
		: this()
	{
		packId_ = other.packId_;
		subQuestClearCount_ = other.subQuestClearCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackSubQuestClearInfo Clone()
	{
		return new PackSubQuestClearInfo(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as PackSubQuestClearInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PackSubQuestClearInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (PackId == other.PackId && SubQuestClearCount == other.SubQuestClearCount)
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
		if (PackId != 0)
		{
			num ^= PackId.GetHashCode();
		}
		if (SubQuestClearCount != 0)
		{
			num ^= SubQuestClearCount.GetHashCode();
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
		if (PackId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(PackId);
		}
		if (SubQuestClearCount != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SubQuestClearCount);
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
		if (PackId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PackId);
		}
		if (SubQuestClearCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SubQuestClearCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PackSubQuestClearInfo other)
	{
		if (other != null)
		{
			if (other.PackId != 0)
			{
				PackId = other.PackId;
			}
			if (other.SubQuestClearCount != 0)
			{
				SubQuestClearCount = other.SubQuestClearCount;
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
				SubQuestClearCount = input.ReadInt32();
				break;
			case 8u:
				PackId = input.ReadInt32();
				break;
			}
		}
	}
}
