using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PackPreviewInfoResponse : IMessage<PackPreviewInfoResponse>, IMessage, IEquatable<PackPreviewInfoResponse>, IDeepCloneable<PackPreviewInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<PackPreviewInfoResponse> _parser = new MessageParser<PackPreviewInfoResponse>(() => new PackPreviewInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int QuestInfoFieldNumber = 1;

	private static readonly FieldCodec<QuestDBInfo> _repeated_questInfo_codec = FieldCodec.ForMessage(10u, QuestDBInfo.Parser);

	private readonly RepeatedField<QuestDBInfo> questInfo_ = new RepeatedField<QuestDBInfo>();

	public const int QuestTitleInfoFieldNumber = 2;

	private static readonly FieldCodec<QuestTitleDBInfo> _repeated_questTitleInfo_codec = FieldCodec.ForMessage(18u, QuestTitleDBInfo.Parser);

	private readonly RepeatedField<QuestTitleDBInfo> questTitleInfo_ = new RepeatedField<QuestTitleDBInfo>();

	public const int IsPackEventRewardFieldNumber = 3;

	private bool isPackEventReward_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PackPreviewInfoResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => PackPreviewInfoResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<QuestDBInfo> QuestInfo => questInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<QuestTitleDBInfo> QuestTitleInfo => questTitleInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsPackEventReward
	{
		get
		{
			return isPackEventReward_;
		}
		set
		{
			isPackEventReward_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackPreviewInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackPreviewInfoResponse(PackPreviewInfoResponse other)
		: this()
	{
		questInfo_ = other.questInfo_.Clone();
		questTitleInfo_ = other.questTitleInfo_.Clone();
		isPackEventReward_ = other.isPackEventReward_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackPreviewInfoResponse Clone()
	{
		return new PackPreviewInfoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PackPreviewInfoResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PackPreviewInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (questInfo_.Equals(other.questInfo_) && questTitleInfo_.Equals(other.questTitleInfo_) && IsPackEventReward == other.IsPackEventReward)
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
		num ^= questInfo_.GetHashCode();
		num ^= questTitleInfo_.GetHashCode();
		if (IsPackEventReward)
		{
			num ^= IsPackEventReward.GetHashCode();
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
		questInfo_.WriteTo(ref output, _repeated_questInfo_codec);
		questTitleInfo_.WriteTo(ref output, _repeated_questTitleInfo_codec);
		if (IsPackEventReward)
		{
			output.WriteRawTag(24);
			output.WriteBool(IsPackEventReward);
		}
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
		num += questInfo_.CalculateSize(_repeated_questInfo_codec);
		num += questTitleInfo_.CalculateSize(_repeated_questTitleInfo_codec);
		if (IsPackEventReward)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PackPreviewInfoResponse other)
	{
		if (other != null)
		{
			questInfo_.Add(other.questInfo_);
			questTitleInfo_.Add(other.questTitleInfo_);
			if (other.IsPackEventReward)
			{
				IsPackEventReward = other.IsPackEventReward;
			}
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
			case 24u:
				IsPackEventReward = input.ReadBool();
				break;
			case 18u:
				questTitleInfo_.AddEntriesFrom(ref input, _repeated_questTitleInfo_codec);
				break;
			case 10u:
				questInfo_.AddEntriesFrom(ref input, _repeated_questInfo_codec);
				break;
			}
		}
	}
}
