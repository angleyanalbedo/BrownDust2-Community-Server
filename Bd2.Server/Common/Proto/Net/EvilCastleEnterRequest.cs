using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EvilCastleEnterRequest : IMessage<EvilCastleEnterRequest>, IMessage, IEquatable<EvilCastleEnterRequest>, IDeepCloneable<EvilCastleEnterRequest>, IBufferMessage
{
	private static readonly MessageParser<EvilCastleEnterRequest> _parser = new MessageParser<EvilCastleEnterRequest>(() => new EvilCastleEnterRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int PackIdFieldNumber = 2;

	private int packId_;

	public const int StageIndexFieldNumber = 3;

	private int stageIndex_;

	public const int IsRetryFieldNumber = 4;

	private bool isRetry_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<EvilCastleEnterRequest> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EvilCastleEnterRequestReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public int StageIndex
	{
		get
		{
			return stageIndex_;
		}
		set
		{
			stageIndex_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsRetry
	{
		get
		{
			return isRetry_;
		}
		set
		{
			isRetry_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleEnterRequest()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleEnterRequest(EvilCastleEnterRequest other)
		: this()
	{
		seq_ = other.seq_;
		packId_ = other.packId_;
		stageIndex_ = other.stageIndex_;
		isRetry_ = other.isRetry_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleEnterRequest Clone()
	{
		return new EvilCastleEnterRequest(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EvilCastleEnterRequest);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EvilCastleEnterRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && PackId == other.PackId && StageIndex == other.StageIndex && IsRetry == other.IsRetry)
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
		if (PackId != 0)
		{
			num ^= PackId.GetHashCode();
		}
		if (StageIndex != 0)
		{
			num ^= StageIndex.GetHashCode();
		}
		if (IsRetry)
		{
			num ^= IsRetry.GetHashCode();
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
		if (PackId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(PackId);
		}
		if (StageIndex != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(StageIndex);
		}
		if (IsRetry)
		{
			output.WriteRawTag(32);
			output.WriteBool(IsRetry);
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
		if (PackId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PackId);
		}
		if (StageIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StageIndex);
		}
		if (IsRetry)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EvilCastleEnterRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			if (other.PackId != 0)
			{
				PackId = other.PackId;
			}
			if (other.StageIndex != 0)
			{
				StageIndex = other.StageIndex;
			}
			if (other.IsRetry)
			{
				IsRetry = other.IsRetry;
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
				PackId = input.ReadInt32();
				break;
			case 24u:
				StageIndex = input.ReadInt32();
				break;
			case 32u:
				IsRetry = input.ReadBool();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
