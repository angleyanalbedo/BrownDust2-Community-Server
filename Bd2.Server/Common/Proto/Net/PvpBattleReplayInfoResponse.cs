using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PvpBattleReplayInfoResponse : IMessage<PvpBattleReplayInfoResponse>, IMessage, IEquatable<PvpBattleReplayInfoResponse>, IDeepCloneable<PvpBattleReplayInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<PvpBattleReplayInfoResponse> _parser = new MessageParser<PvpBattleReplayInfoResponse>(() => new PvpBattleReplayInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int BlueDeckFullInfoFieldNumber = 1;

	private PvpBattleUserDeckFullInfo blueDeckFullInfo_;

	public const int RedDeckFullInfoFieldNumber = 2;

	private PvpBattleUserDeckFullInfo redDeckFullInfo_;

	public const int BattleRandomSeedFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_battleRandomSeed_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> battleRandomSeed_ = new RepeatedField<int>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PvpBattleReplayInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PvpBattleReplayInfoResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PvpBattleUserDeckFullInfo BlueDeckFullInfo
	{
		get
		{
			return blueDeckFullInfo_;
		}
		set
		{
			blueDeckFullInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PvpBattleUserDeckFullInfo RedDeckFullInfo
	{
		get
		{
			return redDeckFullInfo_;
		}
		set
		{
			redDeckFullInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> BattleRandomSeed => battleRandomSeed_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleReplayInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleReplayInfoResponse(PvpBattleReplayInfoResponse other)
		: this()
	{
		blueDeckFullInfo_ = ((other.blueDeckFullInfo_ != null) ? other.blueDeckFullInfo_.Clone() : null);
		redDeckFullInfo_ = ((other.redDeckFullInfo_ != null) ? other.redDeckFullInfo_.Clone() : null);
		battleRandomSeed_ = other.battleRandomSeed_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleReplayInfoResponse Clone()
	{
		return new PvpBattleReplayInfoResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as PvpBattleReplayInfoResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PvpBattleReplayInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(BlueDeckFullInfo, other.BlueDeckFullInfo) && object.Equals(RedDeckFullInfo, other.RedDeckFullInfo) && battleRandomSeed_.Equals(other.battleRandomSeed_))
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
		if (blueDeckFullInfo_ != null)
		{
			num ^= BlueDeckFullInfo.GetHashCode();
		}
		if (redDeckFullInfo_ != null)
		{
			num ^= RedDeckFullInfo.GetHashCode();
		}
		num ^= battleRandomSeed_.GetHashCode();
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
		if (blueDeckFullInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(BlueDeckFullInfo);
		}
		if (redDeckFullInfo_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(RedDeckFullInfo);
		}
		battleRandomSeed_.WriteTo(ref output, _repeated_battleRandomSeed_codec);
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
		if (blueDeckFullInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BlueDeckFullInfo);
		}
		if (redDeckFullInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RedDeckFullInfo);
		}
		num += battleRandomSeed_.CalculateSize(_repeated_battleRandomSeed_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PvpBattleReplayInfoResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.blueDeckFullInfo_ != null)
		{
			if (blueDeckFullInfo_ == null)
			{
				BlueDeckFullInfo = new PvpBattleUserDeckFullInfo();
			}
			BlueDeckFullInfo.MergeFrom(other.BlueDeckFullInfo);
		}
		if (other.redDeckFullInfo_ != null)
		{
			if (redDeckFullInfo_ == null)
			{
				RedDeckFullInfo = new PvpBattleUserDeckFullInfo();
			}
			RedDeckFullInfo.MergeFrom(other.RedDeckFullInfo);
		}
		battleRandomSeed_.Add(other.battleRandomSeed_);
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
			case 10u:
				if (blueDeckFullInfo_ == null)
				{
					BlueDeckFullInfo = new PvpBattleUserDeckFullInfo();
				}
				input.ReadMessage(BlueDeckFullInfo);
				break;
			case 18u:
				if (redDeckFullInfo_ == null)
				{
					RedDeckFullInfo = new PvpBattleUserDeckFullInfo();
				}
				input.ReadMessage(RedDeckFullInfo);
				break;
			case 24u:
			case 26u:
				battleRandomSeed_.AddEntriesFrom(ref input, _repeated_battleRandomSeed_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
