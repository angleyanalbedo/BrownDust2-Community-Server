using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MiniGameRunEndRequest : IMessage<MiniGameRunEndRequest>, IMessage, IEquatable<MiniGameRunEndRequest>, IDeepCloneable<MiniGameRunEndRequest>, IBufferMessage
{
	private static readonly MessageParser<MiniGameRunEndRequest> _parser = new MessageParser<MiniGameRunEndRequest>(() => new MiniGameRunEndRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int IsForceEndFieldNumber = 2;

	private bool isForceEnd_;

	public const int RecordValueFieldNumber = 3;

	private int recordValue_;

	public const int RecordPlayInfoFieldNumber = 4;

	private string recordPlayInfo_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MiniGameRunEndRequest> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MiniGameRunEndRequestReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsForceEnd
	{
		get
		{
			return isForceEnd_;
		}
		set
		{
			isForceEnd_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RecordValue
	{
		get
		{
			return recordValue_;
		}
		set
		{
			recordValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string RecordPlayInfo
	{
		get
		{
			return recordPlayInfo_;
		}
		set
		{
			recordPlayInfo_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameRunEndRequest()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameRunEndRequest(MiniGameRunEndRequest other)
		: this()
	{
		seq_ = other.seq_;
		isForceEnd_ = other.isForceEnd_;
		recordValue_ = other.recordValue_;
		recordPlayInfo_ = other.recordPlayInfo_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameRunEndRequest Clone()
	{
		return new MiniGameRunEndRequest(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as MiniGameRunEndRequest);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MiniGameRunEndRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && IsForceEnd == other.IsForceEnd && RecordValue == other.RecordValue && !(RecordPlayInfo != other.RecordPlayInfo))
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
		if (Seq != 0)
		{
			num ^= Seq.GetHashCode();
		}
		if (IsForceEnd)
		{
			num ^= IsForceEnd.GetHashCode();
		}
		if (RecordValue != 0)
		{
			num ^= RecordValue.GetHashCode();
		}
		if (RecordPlayInfo.Length != 0)
		{
			num ^= RecordPlayInfo.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
		if (Seq != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Seq);
		}
		if (IsForceEnd)
		{
			output.WriteRawTag(16);
			output.WriteBool(IsForceEnd);
		}
		if (RecordValue != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(RecordValue);
		}
		if (RecordPlayInfo.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(RecordPlayInfo);
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
		if (Seq != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Seq);
		}
		if (IsForceEnd)
		{
			num += 2;
		}
		if (RecordValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RecordValue);
		}
		if (RecordPlayInfo.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(RecordPlayInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MiniGameRunEndRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			if (other.IsForceEnd)
			{
				IsForceEnd = other.IsForceEnd;
			}
			if (other.RecordValue != 0)
			{
				RecordValue = other.RecordValue;
			}
			if (other.RecordPlayInfo.Length != 0)
			{
				RecordPlayInfo = other.RecordPlayInfo;
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
				Seq = input.ReadInt32();
				break;
			case 16u:
				IsForceEnd = input.ReadBool();
				break;
			case 24u:
				RecordValue = input.ReadInt32();
				break;
			case 34u:
				RecordPlayInfo = input.ReadString();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
