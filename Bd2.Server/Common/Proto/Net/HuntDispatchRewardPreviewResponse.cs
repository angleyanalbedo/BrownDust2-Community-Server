using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class HuntDispatchRewardPreviewResponse : IMessage<HuntDispatchRewardPreviewResponse>, IMessage, IEquatable<HuntDispatchRewardPreviewResponse>, IDeepCloneable<HuntDispatchRewardPreviewResponse>, IBufferMessage
{
	private static readonly MessageParser<HuntDispatchRewardPreviewResponse> _parser = new MessageParser<HuntDispatchRewardPreviewResponse>(() => new HuntDispatchRewardPreviewResponse());

	private UnknownFieldSet _unknownFields;

	public const int CurrentPlayCountFieldNumber = 1;

	private int currentPlayCount_;

	public const int RewardInfoBundleFieldNumber = 2;

	private RewardDBInfoBundle rewardInfoBundle_;

	public const int IsNotReturnFreeApFieldNumber = 3;

	private bool isNotReturnFreeAp_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<HuntDispatchRewardPreviewResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HuntDispatchRewardPreviewResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CurrentPlayCount
	{
		get
		{
			return currentPlayCount_;
		}
		set
		{
			currentPlayCount_ = value;
		}
	}

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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsNotReturnFreeAp
	{
		get
		{
			return isNotReturnFreeAp_;
		}
		set
		{
			isNotReturnFreeAp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HuntDispatchRewardPreviewResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HuntDispatchRewardPreviewResponse(HuntDispatchRewardPreviewResponse other)
		: this()
	{
		currentPlayCount_ = other.currentPlayCount_;
		rewardInfoBundle_ = ((other.rewardInfoBundle_ != null) ? other.rewardInfoBundle_.Clone() : null);
		isNotReturnFreeAp_ = other.isNotReturnFreeAp_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HuntDispatchRewardPreviewResponse Clone()
	{
		return new HuntDispatchRewardPreviewResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as HuntDispatchRewardPreviewResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(HuntDispatchRewardPreviewResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (CurrentPlayCount == other.CurrentPlayCount && object.Equals(RewardInfoBundle, other.RewardInfoBundle) && IsNotReturnFreeAp == other.IsNotReturnFreeAp)
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
		if (CurrentPlayCount != 0)
		{
			num ^= CurrentPlayCount.GetHashCode();
		}
		if (rewardInfoBundle_ != null)
		{
			num ^= RewardInfoBundle.GetHashCode();
		}
		if (IsNotReturnFreeAp)
		{
			num ^= IsNotReturnFreeAp.GetHashCode();
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
		if (CurrentPlayCount != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(CurrentPlayCount);
		}
		if (rewardInfoBundle_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(RewardInfoBundle);
		}
		if (IsNotReturnFreeAp)
		{
			output.WriteRawTag(24);
			output.WriteBool(IsNotReturnFreeAp);
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
		if (CurrentPlayCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CurrentPlayCount);
		}
		if (rewardInfoBundle_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RewardInfoBundle);
		}
		if (IsNotReturnFreeAp)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(HuntDispatchRewardPreviewResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.CurrentPlayCount != 0)
		{
			CurrentPlayCount = other.CurrentPlayCount;
		}
		if (other.rewardInfoBundle_ != null)
		{
			if (rewardInfoBundle_ == null)
			{
				RewardInfoBundle = new RewardDBInfoBundle();
			}
			RewardInfoBundle.MergeFrom(other.RewardInfoBundle);
		}
		if (other.IsNotReturnFreeAp)
		{
			IsNotReturnFreeAp = other.IsNotReturnFreeAp;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
			case 24u:
				IsNotReturnFreeAp = input.ReadBool();
				break;
			case 18u:
				if (rewardInfoBundle_ == null)
				{
					RewardInfoBundle = new RewardDBInfoBundle();
				}
				input.ReadMessage(RewardInfoBundle);
				break;
			case 8u:
				CurrentPlayCount = input.ReadInt32();
				break;
			}
		}
	}
}
