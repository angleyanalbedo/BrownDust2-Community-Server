using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PackSubQuestClearInfoRequest : IMessage<PackSubQuestClearInfoRequest>, IMessage, IEquatable<PackSubQuestClearInfoRequest>, IDeepCloneable<PackSubQuestClearInfoRequest>, IBufferMessage
{
	private static readonly MessageParser<PackSubQuestClearInfoRequest> _parser = new MessageParser<PackSubQuestClearInfoRequest>(() => new PackSubQuestClearInfoRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int PackIdFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_packId_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> packId_ = new RepeatedField<int>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PackSubQuestClearInfoRequest> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PackSubQuestClearInfoRequestReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> PackId => packId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PackSubQuestClearInfoRequest()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackSubQuestClearInfoRequest(PackSubQuestClearInfoRequest other)
		: this()
	{
		seq_ = other.seq_;
		packId_ = other.packId_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackSubQuestClearInfoRequest Clone()
	{
		return new PackSubQuestClearInfoRequest(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PackSubQuestClearInfoRequest);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PackSubQuestClearInfoRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && packId_.Equals(other.packId_))
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
		num ^= packId_.GetHashCode();
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
		if (Seq != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Seq);
		}
		packId_.WriteTo(ref output, _repeated_packId_codec);
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
		num += packId_.CalculateSize(_repeated_packId_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PackSubQuestClearInfoRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			packId_.Add(other.packId_);
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
			case 16u:
			case 18u:
				packId_.AddEntriesFrom(ref input, _repeated_packId_codec);
				break;
			case 8u:
				Seq = input.ReadInt32();
				break;
			}
		}
	}
}
