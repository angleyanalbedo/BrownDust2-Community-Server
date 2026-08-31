using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class AchievementClearRequest : IMessage<AchievementClearRequest>, IMessage, IEquatable<AchievementClearRequest>, IDeepCloneable<AchievementClearRequest>, IBufferMessage
{
	private static readonly MessageParser<AchievementClearRequest> _parser = new MessageParser<AchievementClearRequest>(() => new AchievementClearRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int ContentsGroupFieldNumber = 2;

	private int contentsGroup_;

	public const int ClearInfoFieldNumber = 3;

	private static readonly FieldCodec<AchievementClearInfo> _repeated_clearInfo_codec = FieldCodec.ForMessage(26u, AchievementClearInfo.Parser);

	private readonly RepeatedField<AchievementClearInfo> clearInfo_ = new RepeatedField<AchievementClearInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AchievementClearRequest> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AchievementClearRequestReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Seq
	{
		get
		{
			return seq_;
		}
		set
		{
			seq_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ContentsGroup
	{
		get
		{
			return contentsGroup_;
		}
		set
		{
			contentsGroup_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<AchievementClearInfo> ClearInfo => clearInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AchievementClearRequest()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AchievementClearRequest(AchievementClearRequest other)
		: this()
	{
		seq_ = other.seq_;
		contentsGroup_ = other.contentsGroup_;
		clearInfo_ = other.clearInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AchievementClearRequest Clone()
	{
		return new AchievementClearRequest(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as AchievementClearRequest);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AchievementClearRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && ContentsGroup == other.ContentsGroup && clearInfo_.Equals(other.clearInfo_))
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
		if (Seq != 0)
		{
			num ^= Seq.GetHashCode();
		}
		if (ContentsGroup != 0)
		{
			num ^= ContentsGroup.GetHashCode();
		}
		num ^= clearInfo_.GetHashCode();
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
		if (Seq != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Seq);
		}
		if (ContentsGroup != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ContentsGroup);
		}
		clearInfo_.WriteTo(ref output, _repeated_clearInfo_codec);
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
		if (Seq != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Seq);
		}
		if (ContentsGroup != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ContentsGroup);
		}
		num += clearInfo_.CalculateSize(_repeated_clearInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AchievementClearRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			if (other.ContentsGroup != 0)
			{
				ContentsGroup = other.ContentsGroup;
			}
			clearInfo_.Add(other.clearInfo_);
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
				clearInfo_.AddEntriesFrom(ref input, _repeated_clearInfo_codec);
				break;
			case 16u:
				ContentsGroup = input.ReadInt32();
				break;
			case 8u:
				Seq = input.ReadInt32();
				break;
			}
		}
	}
}
