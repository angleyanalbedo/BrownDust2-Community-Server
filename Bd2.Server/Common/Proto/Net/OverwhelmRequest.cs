using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class OverwhelmRequest : IMessage<OverwhelmRequest>, IMessage, IEquatable<OverwhelmRequest>, IDeepCloneable<OverwhelmRequest>, IBufferMessage
{
	private static readonly MessageParser<OverwhelmRequest> _parser = new MessageParser<OverwhelmRequest>(() => new OverwhelmRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int MonsterInfoFieldNumber = 2;

	private static readonly FieldCodec<OverwhelmMonsterInfo> _repeated_monsterInfo_codec = FieldCodec.ForMessage(18u, OverwhelmMonsterInfo.Parser);

	private readonly RepeatedField<OverwhelmMonsterInfo> monsterInfo_ = new RepeatedField<OverwhelmMonsterInfo>();

	public const int QuestInfoFieldNumber = 3;

	private static readonly FieldCodec<OverwhelmQuestUpdateInfo> _repeated_questInfo_codec = FieldCodec.ForMessage(26u, OverwhelmQuestUpdateInfo.Parser);

	private readonly RepeatedField<OverwhelmQuestUpdateInfo> questInfo_ = new RepeatedField<OverwhelmQuestUpdateInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<OverwhelmRequest> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => OverwhelmRequestReflection.Descriptor.MessageTypes[2];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public RepeatedField<OverwhelmMonsterInfo> MonsterInfo => monsterInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OverwhelmQuestUpdateInfo> QuestInfo => questInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OverwhelmRequest()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OverwhelmRequest(OverwhelmRequest other)
		: this()
	{
		seq_ = other.seq_;
		monsterInfo_ = other.monsterInfo_.Clone();
		questInfo_ = other.questInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OverwhelmRequest Clone()
	{
		return new OverwhelmRequest(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as OverwhelmRequest);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(OverwhelmRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && monsterInfo_.Equals(other.monsterInfo_) && questInfo_.Equals(other.questInfo_))
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
		if (Seq != 0)
		{
			num ^= Seq.GetHashCode();
		}
		num ^= monsterInfo_.GetHashCode();
		num ^= questInfo_.GetHashCode();
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
		if (Seq != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Seq);
		}
		monsterInfo_.WriteTo(ref output, _repeated_monsterInfo_codec);
		questInfo_.WriteTo(ref output, _repeated_questInfo_codec);
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
		num += monsterInfo_.CalculateSize(_repeated_monsterInfo_codec);
		num += questInfo_.CalculateSize(_repeated_questInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OverwhelmRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			monsterInfo_.Add(other.monsterInfo_);
			questInfo_.Add(other.questInfo_);
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
			case 26u:
				questInfo_.AddEntriesFrom(ref input, _repeated_questInfo_codec);
				break;
			case 18u:
				monsterInfo_.AddEntriesFrom(ref input, _repeated_monsterInfo_codec);
				break;
			case 8u:
				Seq = input.ReadInt32();
				break;
			}
		}
	}
}
