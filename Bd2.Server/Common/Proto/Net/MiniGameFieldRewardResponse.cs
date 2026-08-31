using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MiniGameFieldRewardResponse : IMessage<MiniGameFieldRewardResponse>, IMessage, IEquatable<MiniGameFieldRewardResponse>, IDeepCloneable<MiniGameFieldRewardResponse>, IBufferMessage
{
	private static readonly MessageParser<MiniGameFieldRewardResponse> _parser = new MessageParser<MiniGameFieldRewardResponse>(() => new MiniGameFieldRewardResponse());

	private UnknownFieldSet _unknownFields;

	public const int LastRewardPointFieldNumber = 1;

	private int lastRewardPoint_;

	public const int RewardFieldNumber = 2;

	private static readonly FieldCodec<ItemDBInfo> _repeated_reward_codec = FieldCodec.ForMessage(18u, ItemDBInfo.Parser);

	private readonly RepeatedField<ItemDBInfo> reward_ = new RepeatedField<ItemDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MiniGameFieldRewardResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MiniGameFieldRewardResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int LastRewardPoint
	{
		get
		{
			return lastRewardPoint_;
		}
		set
		{
			lastRewardPoint_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ItemDBInfo> Reward => reward_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameFieldRewardResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MiniGameFieldRewardResponse(MiniGameFieldRewardResponse other)
		: this()
	{
		lastRewardPoint_ = other.lastRewardPoint_;
		reward_ = other.reward_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MiniGameFieldRewardResponse Clone()
	{
		return new MiniGameFieldRewardResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as MiniGameFieldRewardResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MiniGameFieldRewardResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (LastRewardPoint == other.LastRewardPoint && reward_.Equals(other.reward_))
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
		if (LastRewardPoint != 0)
		{
			num ^= LastRewardPoint.GetHashCode();
		}
		num ^= reward_.GetHashCode();
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
		if (LastRewardPoint != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(LastRewardPoint);
		}
		reward_.WriteTo(ref output, _repeated_reward_codec);
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
		if (LastRewardPoint != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LastRewardPoint);
		}
		num += reward_.CalculateSize(_repeated_reward_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MiniGameFieldRewardResponse other)
	{
		if (other != null)
		{
			if (other.LastRewardPoint != 0)
			{
				LastRewardPoint = other.LastRewardPoint;
			}
			reward_.Add(other.reward_);
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
			case 18u:
				reward_.AddEntriesFrom(ref input, _repeated_reward_codec);
				break;
			case 8u:
				LastRewardPoint = input.ReadInt32();
				break;
			}
		}
	}
}
