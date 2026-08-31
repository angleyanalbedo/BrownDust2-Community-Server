using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MiniGameBingoDBInfo : IMessage<MiniGameBingoDBInfo>, IMessage, IEquatable<MiniGameBingoDBInfo>, IDeepCloneable<MiniGameBingoDBInfo>, IBufferMessage
{
	private static readonly MessageParser<MiniGameBingoDBInfo> _parser = new MessageParser<MiniGameBingoDBInfo>(() => new MiniGameBingoDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int EventScheduleIdFieldNumber = 1;

	private int eventScheduleId_;

	public const int ClearCountFieldNumber = 2;

	private int clearCount_;

	public const int BingoBoardFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_bingoBoard_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> bingoBoard_ = new RepeatedField<int>();

	public const int OpenBingoBoardIndexFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_openBingoBoardIndex_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> openBingoBoardIndex_ = new RepeatedField<int>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MiniGameBingoDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MiniGameBingoDBInfoReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EventScheduleId
	{
		get
		{
			return eventScheduleId_;
		}
		set
		{
			eventScheduleId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ClearCount
	{
		get
		{
			return clearCount_;
		}
		set
		{
			clearCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> BingoBoard => bingoBoard_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> OpenBingoBoardIndex => openBingoBoardIndex_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameBingoDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameBingoDBInfo(MiniGameBingoDBInfo other)
		: this()
	{
		eventScheduleId_ = other.eventScheduleId_;
		clearCount_ = other.clearCount_;
		bingoBoard_ = other.bingoBoard_.Clone();
		openBingoBoardIndex_ = other.openBingoBoardIndex_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameBingoDBInfo Clone()
	{
		return new MiniGameBingoDBInfo(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as MiniGameBingoDBInfo);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MiniGameBingoDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (EventScheduleId == other.EventScheduleId && ClearCount == other.ClearCount && bingoBoard_.Equals(other.bingoBoard_) && openBingoBoardIndex_.Equals(other.openBingoBoardIndex_))
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
		if (EventScheduleId != 0)
		{
			num ^= EventScheduleId.GetHashCode();
		}
		if (ClearCount != 0)
		{
			num ^= ClearCount.GetHashCode();
		}
		num ^= bingoBoard_.GetHashCode();
		num ^= openBingoBoardIndex_.GetHashCode();
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
		if (EventScheduleId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(EventScheduleId);
		}
		if (ClearCount != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ClearCount);
		}
		bingoBoard_.WriteTo(ref output, _repeated_bingoBoard_codec);
		openBingoBoardIndex_.WriteTo(ref output, _repeated_openBingoBoardIndex_codec);
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
		if (EventScheduleId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventScheduleId);
		}
		if (ClearCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ClearCount);
		}
		num += bingoBoard_.CalculateSize(_repeated_bingoBoard_codec);
		num += openBingoBoardIndex_.CalculateSize(_repeated_openBingoBoardIndex_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(MiniGameBingoDBInfo other)
	{
		if (other != null)
		{
			if (other.EventScheduleId != 0)
			{
				EventScheduleId = other.EventScheduleId;
			}
			if (other.ClearCount != 0)
			{
				ClearCount = other.ClearCount;
			}
			bingoBoard_.Add(other.bingoBoard_);
			openBingoBoardIndex_.Add(other.openBingoBoardIndex_);
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
				EventScheduleId = input.ReadInt32();
				break;
			case 16u:
				ClearCount = input.ReadInt32();
				break;
			case 32u:
			case 34u:
				openBingoBoardIndex_.AddEntriesFrom(ref input, _repeated_openBingoBoardIndex_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 24u:
			case 26u:
				bingoBoard_.AddEntriesFrom(ref input, _repeated_bingoBoard_codec);
				break;
			}
		}
	}
}
