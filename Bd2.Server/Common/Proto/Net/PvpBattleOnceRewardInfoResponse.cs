using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PvpBattleOnceRewardInfoResponse : IMessage<PvpBattleOnceRewardInfoResponse>, IMessage, IEquatable<PvpBattleOnceRewardInfoResponse>, IDeepCloneable<PvpBattleOnceRewardInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<PvpBattleOnceRewardInfoResponse> _parser = new MessageParser<PvpBattleOnceRewardInfoResponse>(() => new PvpBattleOnceRewardInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int OnceRewardInfoFieldNumber = 1;

	private static readonly FieldCodec<int> _repeated_onceRewardInfo_codec = FieldCodec.ForInt32(10u);

	private readonly RepeatedField<int> onceRewardInfo_ = new RepeatedField<int>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PvpBattleOnceRewardInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PvpBattleOnceRewardInfoResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> OnceRewardInfo => onceRewardInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleOnceRewardInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleOnceRewardInfoResponse(PvpBattleOnceRewardInfoResponse other)
		: this()
	{
		onceRewardInfo_ = other.onceRewardInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleOnceRewardInfoResponse Clone()
	{
		return new PvpBattleOnceRewardInfoResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as PvpBattleOnceRewardInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PvpBattleOnceRewardInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (onceRewardInfo_.Equals(other.onceRewardInfo_))
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
		num ^= onceRewardInfo_.GetHashCode();
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
		onceRewardInfo_.WriteTo(ref output, _repeated_onceRewardInfo_codec);
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
		num += onceRewardInfo_.CalculateSize(_repeated_onceRewardInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PvpBattleOnceRewardInfoResponse other)
	{
		if (other != null)
		{
			onceRewardInfo_.Add(other.onceRewardInfo_);
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
			if (num != 8 && num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				onceRewardInfo_.AddEntriesFrom(ref input, _repeated_onceRewardInfo_codec);
			}
		}
	}
}
