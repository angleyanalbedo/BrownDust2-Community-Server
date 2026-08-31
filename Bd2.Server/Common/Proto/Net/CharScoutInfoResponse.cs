using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class CharScoutInfoResponse : IMessage<CharScoutInfoResponse>, IMessage, IEquatable<CharScoutInfoResponse>, IDeepCloneable<CharScoutInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<CharScoutInfoResponse> _parser = new MessageParser<CharScoutInfoResponse>(() => new CharScoutInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int AppearCharIdFieldNumber = 1;

	private static readonly FieldCodec<int> _repeated_appearCharId_codec = FieldCodec.ForInt32(10u);

	private readonly RepeatedField<int> appearCharId_ = new RepeatedField<int>();

	public const int UseResetCountFieldNumber = 2;

	private int useResetCount_;

	public const int NextAutoResetTimeFieldNumber = 3;

	private long nextAutoResetTime_;

	public const int ScoutCompleteCharIdFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_scoutCompleteCharId_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> scoutCompleteCharId_ = new RepeatedField<int>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CharScoutInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CharScoutInfoResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> AppearCharId => appearCharId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int UseResetCount
	{
		get
		{
			return useResetCount_;
		}
		set
		{
			useResetCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long NextAutoResetTime
	{
		get
		{
			return nextAutoResetTime_;
		}
		set
		{
			nextAutoResetTime_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> ScoutCompleteCharId => scoutCompleteCharId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharScoutInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharScoutInfoResponse(CharScoutInfoResponse other)
		: this()
	{
		appearCharId_ = other.appearCharId_.Clone();
		useResetCount_ = other.useResetCount_;
		nextAutoResetTime_ = other.nextAutoResetTime_;
		scoutCompleteCharId_ = other.scoutCompleteCharId_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharScoutInfoResponse Clone()
	{
		return new CharScoutInfoResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as CharScoutInfoResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CharScoutInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (appearCharId_.Equals(other.appearCharId_) && UseResetCount == other.UseResetCount && NextAutoResetTime == other.NextAutoResetTime && scoutCompleteCharId_.Equals(other.scoutCompleteCharId_))
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
		num ^= appearCharId_.GetHashCode();
		if (UseResetCount != 0)
		{
			num ^= UseResetCount.GetHashCode();
		}
		if (NextAutoResetTime != 0L)
		{
			num ^= NextAutoResetTime.GetHashCode();
		}
		num ^= scoutCompleteCharId_.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		appearCharId_.WriteTo(ref output, _repeated_appearCharId_codec);
		if (UseResetCount != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(UseResetCount);
		}
		if (NextAutoResetTime != 0L)
		{
			output.WriteRawTag(24);
			output.WriteInt64(NextAutoResetTime);
		}
		scoutCompleteCharId_.WriteTo(ref output, _repeated_scoutCompleteCharId_codec);
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
		num += appearCharId_.CalculateSize(_repeated_appearCharId_codec);
		if (UseResetCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UseResetCount);
		}
		if (NextAutoResetTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(NextAutoResetTime);
		}
		num += scoutCompleteCharId_.CalculateSize(_repeated_scoutCompleteCharId_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharScoutInfoResponse other)
	{
		if (other != null)
		{
			appearCharId_.Add(other.appearCharId_);
			if (other.UseResetCount != 0)
			{
				UseResetCount = other.UseResetCount;
			}
			if (other.NextAutoResetTime != 0L)
			{
				NextAutoResetTime = other.NextAutoResetTime;
			}
			scoutCompleteCharId_.Add(other.scoutCompleteCharId_);
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
			case 10u:
				appearCharId_.AddEntriesFrom(ref input, _repeated_appearCharId_codec);
				break;
			case 16u:
				UseResetCount = input.ReadInt32();
				break;
			case 24u:
				NextAutoResetTime = input.ReadInt64();
				break;
			case 32u:
			case 34u:
				scoutCompleteCharId_.AddEntriesFrom(ref input, _repeated_scoutCompleteCharId_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
