using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EvilCastleRewardInfoResponse : IMessage<EvilCastleRewardInfoResponse>, IMessage, IEquatable<EvilCastleRewardInfoResponse>, IDeepCloneable<EvilCastleRewardInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<EvilCastleRewardInfoResponse> _parser = new MessageParser<EvilCastleRewardInfoResponse>(() => new EvilCastleRewardInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int EndSeasonInfoFieldNumber = 1;

	private static readonly FieldCodec<EvilCastleEndSeasonDBInfo> _repeated_endSeasonInfo_codec = FieldCodec.ForMessage(10u, EvilCastleEndSeasonDBInfo.Parser);

	private readonly RepeatedField<EvilCastleEndSeasonDBInfo> endSeasonInfo_ = new RepeatedField<EvilCastleEndSeasonDBInfo>();

	public const int EndSeasonTotalInfoFieldNumber = 2;

	private EvilCastleEndSeasonTotalDBInfo endSeasonTotalInfo_;

	public const int RewardInfoBundleFieldNumber = 3;

	private RewardDBInfoBundle rewardInfoBundle_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EvilCastleRewardInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EvilCastleRewardInfoResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<EvilCastleEndSeasonDBInfo> EndSeasonInfo => endSeasonInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleEndSeasonTotalDBInfo EndSeasonTotalInfo
	{
		get
		{
			return endSeasonTotalInfo_;
		}
		set
		{
			endSeasonTotalInfo_ = value;
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
	public EvilCastleRewardInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRewardInfoResponse(EvilCastleRewardInfoResponse other)
		: this()
	{
		endSeasonInfo_ = other.endSeasonInfo_.Clone();
		endSeasonTotalInfo_ = ((other.endSeasonTotalInfo_ != null) ? other.endSeasonTotalInfo_.Clone() : null);
		rewardInfoBundle_ = ((other.rewardInfoBundle_ != null) ? other.rewardInfoBundle_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRewardInfoResponse Clone()
	{
		return new EvilCastleRewardInfoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EvilCastleRewardInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EvilCastleRewardInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (endSeasonInfo_.Equals(other.endSeasonInfo_) && object.Equals(EndSeasonTotalInfo, other.EndSeasonTotalInfo) && object.Equals(RewardInfoBundle, other.RewardInfoBundle))
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
		num ^= endSeasonInfo_.GetHashCode();
		if (endSeasonTotalInfo_ != null)
		{
			num ^= EndSeasonTotalInfo.GetHashCode();
		}
		if (rewardInfoBundle_ != null)
		{
			num ^= RewardInfoBundle.GetHashCode();
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
		endSeasonInfo_.WriteTo(ref output, _repeated_endSeasonInfo_codec);
		if (endSeasonTotalInfo_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(EndSeasonTotalInfo);
		}
		if (rewardInfoBundle_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(RewardInfoBundle);
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
		num += endSeasonInfo_.CalculateSize(_repeated_endSeasonInfo_codec);
		if (endSeasonTotalInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EndSeasonTotalInfo);
		}
		if (rewardInfoBundle_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RewardInfoBundle);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EvilCastleRewardInfoResponse other)
	{
		if (other == null)
		{
			return;
		}
		endSeasonInfo_.Add(other.endSeasonInfo_);
		if (other.endSeasonTotalInfo_ != null)
		{
			if (endSeasonTotalInfo_ == null)
			{
				EndSeasonTotalInfo = new EvilCastleEndSeasonTotalDBInfo();
			}
			EndSeasonTotalInfo.MergeFrom(other.EndSeasonTotalInfo);
		}
		if (other.rewardInfoBundle_ != null)
		{
			if (rewardInfoBundle_ == null)
			{
				RewardInfoBundle = new RewardDBInfoBundle();
			}
			RewardInfoBundle.MergeFrom(other.RewardInfoBundle);
		}
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 26u:
				if (rewardInfoBundle_ == null)
				{
					RewardInfoBundle = new RewardDBInfoBundle();
				}
				input.ReadMessage(RewardInfoBundle);
				break;
			case 18u:
				if (endSeasonTotalInfo_ == null)
				{
					EndSeasonTotalInfo = new EvilCastleEndSeasonTotalDBInfo();
				}
				input.ReadMessage(EndSeasonTotalInfo);
				break;
			case 10u:
				endSeasonInfo_.AddEntriesFrom(ref input, _repeated_endSeasonInfo_codec);
				break;
			}
		}
	}
}
