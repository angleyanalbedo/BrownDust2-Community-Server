using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EventExchangeRewardResponse : IMessage<EventExchangeRewardResponse>, IMessage, IEquatable<EventExchangeRewardResponse>, IDeepCloneable<EventExchangeRewardResponse>, IBufferMessage
{
	private static readonly MessageParser<EventExchangeRewardResponse> _parser = new MessageParser<EventExchangeRewardResponse>(() => new EventExchangeRewardResponse());

	private UnknownFieldSet _unknownFields;

	public const int RewardInfoBundleFieldNumber = 1;

	private RewardDBInfoBundle rewardInfoBundle_;

	public const int ChangeExchangeRewardInfoFieldNumber = 2;

	private static readonly FieldCodec<EventExchangeRewardDBInfo> _repeated_changeExchangeRewardInfo_codec = FieldCodec.ForMessage(18u, EventExchangeRewardDBInfo.Parser);

	private readonly RepeatedField<EventExchangeRewardDBInfo> changeExchangeRewardInfo_ = new RepeatedField<EventExchangeRewardDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EventExchangeRewardResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EventExchangeRewardResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RewardDBInfoBundle RewardInfoBundle
	{
		get
		{
			return rewardInfoBundle_;
		}
		set
		{
			rewardInfoBundle_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EventExchangeRewardDBInfo> ChangeExchangeRewardInfo => changeExchangeRewardInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventExchangeRewardResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventExchangeRewardResponse(EventExchangeRewardResponse other)
		: this()
	{
		rewardInfoBundle_ = ((other.rewardInfoBundle_ != null) ? other.rewardInfoBundle_.Clone() : null);
		changeExchangeRewardInfo_ = other.changeExchangeRewardInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventExchangeRewardResponse Clone()
	{
		return new EventExchangeRewardResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as EventExchangeRewardResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EventExchangeRewardResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(RewardInfoBundle, other.RewardInfoBundle) && changeExchangeRewardInfo_.Equals(other.changeExchangeRewardInfo_))
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
		if (rewardInfoBundle_ != null)
		{
			num ^= RewardInfoBundle.GetHashCode();
		}
		num ^= changeExchangeRewardInfo_.GetHashCode();
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
		if (rewardInfoBundle_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(RewardInfoBundle);
		}
		changeExchangeRewardInfo_.WriteTo(ref output, _repeated_changeExchangeRewardInfo_codec);
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
		if (rewardInfoBundle_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RewardInfoBundle);
		}
		num += changeExchangeRewardInfo_.CalculateSize(_repeated_changeExchangeRewardInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EventExchangeRewardResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.rewardInfoBundle_ != null)
		{
			if (rewardInfoBundle_ == null)
			{
				RewardInfoBundle = new RewardDBInfoBundle();
			}
			RewardInfoBundle.MergeFrom(other.RewardInfoBundle);
		}
		changeExchangeRewardInfo_.Add(other.changeExchangeRewardInfo_);
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 18u:
				changeExchangeRewardInfo_.AddEntriesFrom(ref input, _repeated_changeExchangeRewardInfo_codec);
				break;
			case 10u:
				if (rewardInfoBundle_ == null)
				{
					RewardInfoBundle = new RewardDBInfoBundle();
				}
				input.ReadMessage(RewardInfoBundle);
				break;
			}
		}
	}
}
