using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GachaFixedDBInfo : IMessage<GachaFixedDBInfo>, IMessage, IEquatable<GachaFixedDBInfo>, IDeepCloneable<GachaFixedDBInfo>, IBufferMessage
{
	private static readonly MessageParser<GachaFixedDBInfo> _parser = new MessageParser<GachaFixedDBInfo>(() => new GachaFixedDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int FixedIdFieldNumber = 1;

	private int fixedId_;

	public const int TypeFieldNumber = 2;

	private int type_;

	public const int CountFieldNumber = 3;

	private int count_;

	public const int ApplySortIdFieldNumber = 4;

	private int applySortId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GachaFixedDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GachaFixedDBInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FixedId
	{
		get
		{
			return fixedId_;
		}
		set
		{
			fixedId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Count
	{
		get
		{
			return count_;
		}
		set
		{
			count_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ApplySortId
	{
		get
		{
			return applySortId_;
		}
		set
		{
			applySortId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GachaFixedDBInfo()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GachaFixedDBInfo(GachaFixedDBInfo other)
		: this()
	{
		fixedId_ = other.fixedId_;
		type_ = other.type_;
		count_ = other.count_;
		applySortId_ = other.applySortId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GachaFixedDBInfo Clone()
	{
		return new GachaFixedDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GachaFixedDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GachaFixedDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (FixedId == other.FixedId && Type == other.Type && Count == other.Count && ApplySortId == other.ApplySortId)
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
		if (FixedId != 0)
		{
			num ^= FixedId.GetHashCode();
		}
		if (Type != 0)
		{
			num ^= Type.GetHashCode();
		}
		if (Count != 0)
		{
			num ^= Count.GetHashCode();
		}
		if (ApplySortId != 0)
		{
			num ^= ApplySortId.GetHashCode();
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
		if (FixedId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(FixedId);
		}
		if (Type != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Type);
		}
		if (Count != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Count);
		}
		if (ApplySortId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ApplySortId);
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
		if (FixedId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FixedId);
		}
		if (Type != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Type);
		}
		if (Count != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Count);
		}
		if (ApplySortId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ApplySortId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GachaFixedDBInfo other)
	{
		if (other != null)
		{
			if (other.FixedId != 0)
			{
				FixedId = other.FixedId;
			}
			if (other.Type != 0)
			{
				Type = other.Type;
			}
			if (other.Count != 0)
			{
				Count = other.Count;
			}
			if (other.ApplySortId != 0)
			{
				ApplySortId = other.ApplySortId;
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
				FixedId = input.ReadInt32();
				break;
			case 16u:
				Type = input.ReadInt32();
				break;
			case 24u:
				Count = input.ReadInt32();
				break;
			case 32u:
				ApplySortId = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
