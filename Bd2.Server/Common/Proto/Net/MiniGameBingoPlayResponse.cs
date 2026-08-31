using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MiniGameBingoPlayResponse : IMessage<MiniGameBingoPlayResponse>, IMessage, IEquatable<MiniGameBingoPlayResponse>, IDeepCloneable<MiniGameBingoPlayResponse>, IBufferMessage
{
	private static readonly MessageParser<MiniGameBingoPlayResponse> _parser = new MessageParser<MiniGameBingoPlayResponse>(() => new MiniGameBingoPlayResponse());

	private UnknownFieldSet _unknownFields;

	public const int BeforeMiniGameBingoInfoFieldNumber = 1;

	private MiniGameBingoDBInfo beforeMiniGameBingoInfo_;

	public const int MiniGameBingoInfoFieldNumber = 2;

	private MiniGameBingoDBInfo miniGameBingoInfo_;

	public const int OpenBingoIndexFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_openBingoIndex_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> openBingoIndex_ = new RepeatedField<int>();

	public const int OpenLineInfoFieldNumber = 4;

	private static readonly FieldCodec<MiniGameBingoLineInfo> _repeated_openLineInfo_codec = FieldCodec.ForMessage(34u, MiniGameBingoLineInfo.Parser);

	private readonly RepeatedField<MiniGameBingoLineInfo> openLineInfo_ = new RepeatedField<MiniGameBingoLineInfo>();

	public const int SpaceRewardFieldNumber = 5;

	private RewardDBInfoBundle spaceReward_;

	public const int LineRewardFieldNumber = 6;

	private RewardDBInfoBundle lineReward_;

	public const int CompleteRewardFieldNumber = 7;

	private RewardDBInfoBundle completeReward_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MiniGameBingoPlayResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MiniGameBingoPlayResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameBingoDBInfo BeforeMiniGameBingoInfo
	{
		get
		{
			return beforeMiniGameBingoInfo_;
		}
		set
		{
			beforeMiniGameBingoInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MiniGameBingoDBInfo MiniGameBingoInfo
	{
		get
		{
			return miniGameBingoInfo_;
		}
		set
		{
			miniGameBingoInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> OpenBingoIndex => openBingoIndex_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<MiniGameBingoLineInfo> OpenLineInfo => openLineInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RewardDBInfoBundle SpaceReward
	{
		get
		{
			return spaceReward_;
		}
		set
		{
			spaceReward_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RewardDBInfoBundle LineReward
	{
		get
		{
			return lineReward_;
		}
		set
		{
			lineReward_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RewardDBInfoBundle CompleteReward
	{
		get
		{
			return completeReward_;
		}
		set
		{
			completeReward_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MiniGameBingoPlayResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameBingoPlayResponse(MiniGameBingoPlayResponse other)
		: this()
	{
		beforeMiniGameBingoInfo_ = ((other.beforeMiniGameBingoInfo_ != null) ? other.beforeMiniGameBingoInfo_.Clone() : null);
		miniGameBingoInfo_ = ((other.miniGameBingoInfo_ != null) ? other.miniGameBingoInfo_.Clone() : null);
		openBingoIndex_ = other.openBingoIndex_.Clone();
		openLineInfo_ = other.openLineInfo_.Clone();
		spaceReward_ = ((other.spaceReward_ != null) ? other.spaceReward_.Clone() : null);
		lineReward_ = ((other.lineReward_ != null) ? other.lineReward_.Clone() : null);
		completeReward_ = ((other.completeReward_ != null) ? other.completeReward_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameBingoPlayResponse Clone()
	{
		return new MiniGameBingoPlayResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MiniGameBingoPlayResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MiniGameBingoPlayResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(BeforeMiniGameBingoInfo, other.BeforeMiniGameBingoInfo) && object.Equals(MiniGameBingoInfo, other.MiniGameBingoInfo) && openBingoIndex_.Equals(other.openBingoIndex_) && openLineInfo_.Equals(other.openLineInfo_) && object.Equals(SpaceReward, other.SpaceReward) && object.Equals(LineReward, other.LineReward) && object.Equals(CompleteReward, other.CompleteReward))
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
		if (beforeMiniGameBingoInfo_ != null)
		{
			num ^= BeforeMiniGameBingoInfo.GetHashCode();
		}
		if (miniGameBingoInfo_ != null)
		{
			num ^= MiniGameBingoInfo.GetHashCode();
		}
		num ^= openBingoIndex_.GetHashCode();
		num ^= openLineInfo_.GetHashCode();
		if (spaceReward_ != null)
		{
			num ^= SpaceReward.GetHashCode();
		}
		if (lineReward_ != null)
		{
			num ^= LineReward.GetHashCode();
		}
		if (completeReward_ != null)
		{
			num ^= CompleteReward.GetHashCode();
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
		if (beforeMiniGameBingoInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(BeforeMiniGameBingoInfo);
		}
		if (miniGameBingoInfo_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(MiniGameBingoInfo);
		}
		openBingoIndex_.WriteTo(ref output, _repeated_openBingoIndex_codec);
		openLineInfo_.WriteTo(ref output, _repeated_openLineInfo_codec);
		if (spaceReward_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(SpaceReward);
		}
		if (lineReward_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(LineReward);
		}
		if (completeReward_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(CompleteReward);
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
		if (beforeMiniGameBingoInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BeforeMiniGameBingoInfo);
		}
		if (miniGameBingoInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MiniGameBingoInfo);
		}
		num += openBingoIndex_.CalculateSize(_repeated_openBingoIndex_codec);
		num += openLineInfo_.CalculateSize(_repeated_openLineInfo_codec);
		if (spaceReward_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SpaceReward);
		}
		if (lineReward_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LineReward);
		}
		if (completeReward_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CompleteReward);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MiniGameBingoPlayResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.beforeMiniGameBingoInfo_ != null)
		{
			if (beforeMiniGameBingoInfo_ == null)
			{
				BeforeMiniGameBingoInfo = new MiniGameBingoDBInfo();
			}
			BeforeMiniGameBingoInfo.MergeFrom(other.BeforeMiniGameBingoInfo);
		}
		if (other.miniGameBingoInfo_ != null)
		{
			if (miniGameBingoInfo_ == null)
			{
				MiniGameBingoInfo = new MiniGameBingoDBInfo();
			}
			MiniGameBingoInfo.MergeFrom(other.MiniGameBingoInfo);
		}
		openBingoIndex_.Add(other.openBingoIndex_);
		openLineInfo_.Add(other.openLineInfo_);
		if (other.spaceReward_ != null)
		{
			if (spaceReward_ == null)
			{
				SpaceReward = new RewardDBInfoBundle();
			}
			SpaceReward.MergeFrom(other.SpaceReward);
		}
		if (other.lineReward_ != null)
		{
			if (lineReward_ == null)
			{
				LineReward = new RewardDBInfoBundle();
			}
			LineReward.MergeFrom(other.LineReward);
		}
		if (other.completeReward_ != null)
		{
			if (completeReward_ == null)
			{
				CompleteReward = new RewardDBInfoBundle();
			}
			CompleteReward.MergeFrom(other.CompleteReward);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			switch (num)
			{
			case 10u:
				if (beforeMiniGameBingoInfo_ == null)
				{
					BeforeMiniGameBingoInfo = new MiniGameBingoDBInfo();
				}
				input.ReadMessage(BeforeMiniGameBingoInfo);
				break;
			case 18u:
				if (miniGameBingoInfo_ == null)
				{
					MiniGameBingoInfo = new MiniGameBingoDBInfo();
				}
				input.ReadMessage(MiniGameBingoInfo);
				break;
			case 24u:
			case 26u:
				openBingoIndex_.AddEntriesFrom(ref input, _repeated_openBingoIndex_codec);
				break;
			case 34u:
				openLineInfo_.AddEntriesFrom(ref input, _repeated_openLineInfo_codec);
				break;
			case 42u:
				if (spaceReward_ == null)
				{
					SpaceReward = new RewardDBInfoBundle();
				}
				input.ReadMessage(SpaceReward);
				break;
			case 50u:
				if (lineReward_ == null)
				{
					LineReward = new RewardDBInfoBundle();
				}
				input.ReadMessage(LineReward);
				break;
			case 58u:
				if (completeReward_ == null)
				{
					CompleteReward = new RewardDBInfoBundle();
				}
				input.ReadMessage(CompleteReward);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
