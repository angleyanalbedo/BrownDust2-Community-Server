using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PackBuyResponse : IMessage<PackBuyResponse>, IMessage, IEquatable<PackBuyResponse>, IDeepCloneable<PackBuyResponse>, IBufferMessage
{
	private static readonly MessageParser<PackBuyResponse> _parser = new MessageParser<PackBuyResponse>(() => new PackBuyResponse());

	private UnknownFieldSet _unknownFields;

	public const int PackInfoFieldNumber = 1;

	private PackDBInfo packInfo_;

	public const int RewardInfoBundleFieldNumber = 2;

	private RewardDBInfoBundle rewardInfoBundle_;

	public const int DeckInfoFieldNumber = 3;

	private static readonly FieldCodec<DeckDBInfo> _repeated_deckInfo_codec = FieldCodec.ForMessage(26u, DeckDBInfo.Parser);

	private readonly RepeatedField<DeckDBInfo> deckInfo_ = new RepeatedField<DeckDBInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PackBuyResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PackBuyResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackDBInfo PackInfo
	{
		get
		{
			return packInfo_;
		}
		set
		{
			packInfo_ = value;
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
	public RepeatedField<DeckDBInfo> DeckInfo => deckInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackBuyResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackBuyResponse(PackBuyResponse other)
		: this()
	{
		packInfo_ = ((other.packInfo_ != null) ? other.packInfo_.Clone() : null);
		rewardInfoBundle_ = ((other.rewardInfoBundle_ != null) ? other.rewardInfoBundle_.Clone() : null);
		deckInfo_ = other.deckInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackBuyResponse Clone()
	{
		return new PackBuyResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as PackBuyResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PackBuyResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(PackInfo, other.PackInfo) && object.Equals(RewardInfoBundle, other.RewardInfoBundle) && deckInfo_.Equals(other.deckInfo_))
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
		if (packInfo_ != null)
		{
			num ^= PackInfo.GetHashCode();
		}
		if (rewardInfoBundle_ != null)
		{
			num ^= RewardInfoBundle.GetHashCode();
		}
		num ^= deckInfo_.GetHashCode();
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
		if (packInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(PackInfo);
		}
		if (rewardInfoBundle_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(RewardInfoBundle);
		}
		deckInfo_.WriteTo(ref output, _repeated_deckInfo_codec);
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
		if (packInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PackInfo);
		}
		if (rewardInfoBundle_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RewardInfoBundle);
		}
		num += deckInfo_.CalculateSize(_repeated_deckInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PackBuyResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.packInfo_ != null)
		{
			if (packInfo_ == null)
			{
				PackInfo = new PackDBInfo();
			}
			PackInfo.MergeFrom(other.PackInfo);
		}
		if (other.rewardInfoBundle_ != null)
		{
			if (rewardInfoBundle_ == null)
			{
				RewardInfoBundle = new RewardDBInfoBundle();
			}
			RewardInfoBundle.MergeFrom(other.RewardInfoBundle);
		}
		deckInfo_.Add(other.deckInfo_);
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 26u:
				deckInfo_.AddEntriesFrom(ref input, _repeated_deckInfo_codec);
				break;
			case 18u:
				if (rewardInfoBundle_ == null)
				{
					RewardInfoBundle = new RewardDBInfoBundle();
				}
				input.ReadMessage(RewardInfoBundle);
				break;
			case 10u:
				if (packInfo_ == null)
				{
					PackInfo = new PackDBInfo();
				}
				input.ReadMessage(PackInfo);
				break;
			}
		}
	}
}
