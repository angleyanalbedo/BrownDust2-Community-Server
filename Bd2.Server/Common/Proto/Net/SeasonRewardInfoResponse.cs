using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class SeasonRewardInfoResponse : IMessage<SeasonRewardInfoResponse>, IMessage, IEquatable<SeasonRewardInfoResponse>, IDeepCloneable<SeasonRewardInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<SeasonRewardInfoResponse> _parser = new MessageParser<SeasonRewardInfoResponse>(() => new SeasonRewardInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int RewardInfoFieldNumber = 1;

	private static readonly FieldCodec<SeasonRewardDBInfo> _repeated_rewardInfo_codec = FieldCodec.ForMessage(10u, SeasonRewardDBInfo.Parser);

	private readonly RepeatedField<SeasonRewardDBInfo> rewardInfo_ = new RepeatedField<SeasonRewardDBInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<SeasonRewardInfoResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => SeasonRewardInfoResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<SeasonRewardDBInfo> RewardInfo => rewardInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SeasonRewardInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SeasonRewardInfoResponse(SeasonRewardInfoResponse other)
		: this()
	{
		rewardInfo_ = other.rewardInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SeasonRewardInfoResponse Clone()
	{
		return new SeasonRewardInfoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SeasonRewardInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SeasonRewardInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (rewardInfo_.Equals(other.rewardInfo_))
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
		num ^= rewardInfo_.GetHashCode();
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
		rewardInfo_.WriteTo(ref output, _repeated_rewardInfo_codec);
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
		num += rewardInfo_.CalculateSize(_repeated_rewardInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SeasonRewardInfoResponse other)
	{
		if (other != null)
		{
			rewardInfo_.Add(other.rewardInfo_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				rewardInfo_.AddEntriesFrom(ref input, _repeated_rewardInfo_codec);
			}
		}
	}
}
