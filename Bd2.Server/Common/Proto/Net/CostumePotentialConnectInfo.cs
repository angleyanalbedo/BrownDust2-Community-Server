using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class CostumePotentialConnectInfo : IMessage<CostumePotentialConnectInfo>, IMessage, IEquatable<CostumePotentialConnectInfo>, IDeepCloneable<CostumePotentialConnectInfo>, IBufferMessage
{
	private static readonly MessageParser<CostumePotentialConnectInfo> _parser = new MessageParser<CostumePotentialConnectInfo>(() => new CostumePotentialConnectInfo());

	private UnknownFieldSet _unknownFields;

	public const int InvenIndexFieldNumber = 1;

	private long invenIndex_;

	public const int CostumeIdFieldNumber = 2;

	private int costumeId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CostumePotentialConnectInfo> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => CostumePotentialConnectRequestReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long InvenIndex
	{
		get
		{
			return invenIndex_;
		}
		set
		{
			invenIndex_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CostumeId
	{
		get
		{
			return costumeId_;
		}
		set
		{
			costumeId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CostumePotentialConnectInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CostumePotentialConnectInfo(CostumePotentialConnectInfo other)
		: this()
	{
		invenIndex_ = other.invenIndex_;
		costumeId_ = other.costumeId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CostumePotentialConnectInfo Clone()
	{
		return new CostumePotentialConnectInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CostumePotentialConnectInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CostumePotentialConnectInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (InvenIndex == other.InvenIndex && CostumeId == other.CostumeId)
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
		if (InvenIndex != 0L)
		{
			num ^= InvenIndex.GetHashCode();
		}
		if (CostumeId != 0)
		{
			num ^= CostumeId.GetHashCode();
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
		if (InvenIndex != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(InvenIndex);
		}
		if (CostumeId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(CostumeId);
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
		if (InvenIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(InvenIndex);
		}
		if (CostumeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CostumeId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CostumePotentialConnectInfo other)
	{
		if (other != null)
		{
			if (other.InvenIndex != 0L)
			{
				InvenIndex = other.InvenIndex;
			}
			if (other.CostumeId != 0)
			{
				CostumeId = other.CostumeId;
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
				CostumeId = input.ReadInt32();
				break;
			case 8u:
				InvenIndex = input.ReadInt64();
				break;
			}
		}
	}
}
