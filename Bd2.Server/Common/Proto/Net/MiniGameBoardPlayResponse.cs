using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MiniGameBoardPlayResponse : IMessage<MiniGameBoardPlayResponse>, IMessage, IEquatable<MiniGameBoardPlayResponse>, IDeepCloneable<MiniGameBoardPlayResponse>, IBufferMessage
{
	private static readonly MessageParser<MiniGameBoardPlayResponse> _parser = new MessageParser<MiniGameBoardPlayResponse>(() => new MiniGameBoardPlayResponse());

	private UnknownFieldSet _unknownFields;

	public const int MiniGameBoardInfoFieldNumber = 1;

	private MiniGameBoardDBInfo miniGameBoardInfo_;

	public const int MiniGameControllerInfoFieldNumber = 2;

	private static readonly FieldCodec<MiniGameMoveControllerInfo> _repeated_miniGameControllerInfo_codec = FieldCodec.ForMessage(18u, MiniGameMoveControllerInfo.Parser);

	private readonly RepeatedField<MiniGameMoveControllerInfo> miniGameControllerInfo_ = new RepeatedField<MiniGameMoveControllerInfo>();

	public const int CompleteRewardFieldNumber = 3;

	private RewardDBInfoBundle completeReward_;

	public const int ScaffoldRewardFieldNumber = 4;

	private RewardDBInfoBundle scaffoldReward_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MiniGameBoardPlayResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MiniGameBoardPlayResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameBoardDBInfo MiniGameBoardInfo
	{
		get
		{
			return miniGameBoardInfo_;
		}
		set
		{
			miniGameBoardInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MiniGameMoveControllerInfo> MiniGameControllerInfo => miniGameControllerInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RewardDBInfoBundle ScaffoldReward
	{
		get
		{
			return scaffoldReward_;
		}
		set
		{
			scaffoldReward_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MiniGameBoardPlayResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameBoardPlayResponse(MiniGameBoardPlayResponse other)
		: this()
	{
		miniGameBoardInfo_ = ((other.miniGameBoardInfo_ != null) ? other.miniGameBoardInfo_.Clone() : null);
		miniGameControllerInfo_ = other.miniGameControllerInfo_.Clone();
		completeReward_ = ((other.completeReward_ != null) ? other.completeReward_.Clone() : null);
		scaffoldReward_ = ((other.scaffoldReward_ != null) ? other.scaffoldReward_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameBoardPlayResponse Clone()
	{
		return new MiniGameBoardPlayResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MiniGameBoardPlayResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MiniGameBoardPlayResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(MiniGameBoardInfo, other.MiniGameBoardInfo) && miniGameControllerInfo_.Equals(other.miniGameControllerInfo_) && object.Equals(CompleteReward, other.CompleteReward) && object.Equals(ScaffoldReward, other.ScaffoldReward))
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
		if (miniGameBoardInfo_ != null)
		{
			num ^= MiniGameBoardInfo.GetHashCode();
		}
		num ^= miniGameControllerInfo_.GetHashCode();
		if (completeReward_ != null)
		{
			num ^= CompleteReward.GetHashCode();
		}
		if (scaffoldReward_ != null)
		{
			num ^= ScaffoldReward.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (miniGameBoardInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(MiniGameBoardInfo);
		}
		miniGameControllerInfo_.WriteTo(ref output, _repeated_miniGameControllerInfo_codec);
		if (completeReward_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(CompleteReward);
		}
		if (scaffoldReward_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(ScaffoldReward);
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
		if (miniGameBoardInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MiniGameBoardInfo);
		}
		num += miniGameControllerInfo_.CalculateSize(_repeated_miniGameControllerInfo_codec);
		if (completeReward_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CompleteReward);
		}
		if (scaffoldReward_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ScaffoldReward);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MiniGameBoardPlayResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.miniGameBoardInfo_ != null)
		{
			if (miniGameBoardInfo_ == null)
			{
				MiniGameBoardInfo = new MiniGameBoardDBInfo();
			}
			MiniGameBoardInfo.MergeFrom(other.MiniGameBoardInfo);
		}
		miniGameControllerInfo_.Add(other.miniGameControllerInfo_);
		if (other.completeReward_ != null)
		{
			if (completeReward_ == null)
			{
				CompleteReward = new RewardDBInfoBundle();
			}
			CompleteReward.MergeFrom(other.CompleteReward);
		}
		if (other.scaffoldReward_ != null)
		{
			if (scaffoldReward_ == null)
			{
				ScaffoldReward = new RewardDBInfoBundle();
			}
			ScaffoldReward.MergeFrom(other.ScaffoldReward);
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
			case 10u:
				if (miniGameBoardInfo_ == null)
				{
					MiniGameBoardInfo = new MiniGameBoardDBInfo();
				}
				input.ReadMessage(MiniGameBoardInfo);
				break;
			case 18u:
				miniGameControllerInfo_.AddEntriesFrom(ref input, _repeated_miniGameControllerInfo_codec);
				break;
			case 26u:
				if (completeReward_ == null)
				{
					CompleteReward = new RewardDBInfoBundle();
				}
				input.ReadMessage(CompleteReward);
				break;
			case 34u:
				if (scaffoldReward_ == null)
				{
					ScaffoldReward = new RewardDBInfoBundle();
				}
				input.ReadMessage(ScaffoldReward);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
