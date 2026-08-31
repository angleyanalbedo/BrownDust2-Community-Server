using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PackInfoResponse : IMessage<PackInfoResponse>, IMessage, IEquatable<PackInfoResponse>, IDeepCloneable<PackInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<PackInfoResponse> _parser = new MessageParser<PackInfoResponse>(() => new PackInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int PackInfoFieldNumber = 1;

	private static readonly FieldCodec<PackDBInfo> _repeated_packInfo_codec = FieldCodec.ForMessage(10u, PackDBInfo.Parser);

	private readonly RepeatedField<PackDBInfo> packInfo_ = new RepeatedField<PackDBInfo>();

	public const int QuestLevelInfoFieldNumber = 2;

	private static readonly FieldCodec<QuestLevelDBInfo> _repeated_questLevelInfo_codec = FieldCodec.ForMessage(18u, QuestLevelDBInfo.Parser);

	private readonly RepeatedField<QuestLevelDBInfo> questLevelInfo_ = new RepeatedField<QuestLevelDBInfo>();

	public const int PackClearRewardInfoFieldNumber = 3;

	private static readonly FieldCodec<PackClearRewardDBInfo> _repeated_packClearRewardInfo_codec = FieldCodec.ForMessage(26u, PackClearRewardDBInfo.Parser);

	private readonly RepeatedField<PackClearRewardDBInfo> packClearRewardInfo_ = new RepeatedField<PackClearRewardDBInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PackInfoResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => PackInfoResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PackDBInfo> PackInfo => packInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<QuestLevelDBInfo> QuestLevelInfo => questLevelInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PackClearRewardDBInfo> PackClearRewardInfo => packClearRewardInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackInfoResponse(PackInfoResponse other)
		: this()
	{
		packInfo_ = other.packInfo_.Clone();
		questLevelInfo_ = other.questLevelInfo_.Clone();
		packClearRewardInfo_ = other.packClearRewardInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PackInfoResponse Clone()
	{
		return new PackInfoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PackInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PackInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (packInfo_.Equals(other.packInfo_) && questLevelInfo_.Equals(other.questLevelInfo_) && packClearRewardInfo_.Equals(other.packClearRewardInfo_))
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
		num ^= packInfo_.GetHashCode();
		num ^= questLevelInfo_.GetHashCode();
		num ^= packClearRewardInfo_.GetHashCode();
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
		packInfo_.WriteTo(ref output, _repeated_packInfo_codec);
		questLevelInfo_.WriteTo(ref output, _repeated_questLevelInfo_codec);
		packClearRewardInfo_.WriteTo(ref output, _repeated_packClearRewardInfo_codec);
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
		num += packInfo_.CalculateSize(_repeated_packInfo_codec);
		num += questLevelInfo_.CalculateSize(_repeated_questLevelInfo_codec);
		num += packClearRewardInfo_.CalculateSize(_repeated_packClearRewardInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PackInfoResponse other)
	{
		if (other != null)
		{
			packInfo_.Add(other.packInfo_);
			questLevelInfo_.Add(other.questLevelInfo_);
			packClearRewardInfo_.Add(other.packClearRewardInfo_);
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 26u:
				packClearRewardInfo_.AddEntriesFrom(ref input, _repeated_packClearRewardInfo_codec);
				break;
			case 18u:
				questLevelInfo_.AddEntriesFrom(ref input, _repeated_questLevelInfo_codec);
				break;
			case 10u:
				packInfo_.AddEntriesFrom(ref input, _repeated_packInfo_codec);
				break;
			}
		}
	}
}
