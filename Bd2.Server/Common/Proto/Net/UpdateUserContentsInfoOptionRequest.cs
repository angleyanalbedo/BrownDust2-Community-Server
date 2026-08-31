using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class UpdateUserContentsInfoOptionRequest : IMessage<UpdateUserContentsInfoOptionRequest>, IMessage, IEquatable<UpdateUserContentsInfoOptionRequest>, IDeepCloneable<UpdateUserContentsInfoOptionRequest>, IBufferMessage
{
	private static readonly MessageParser<UpdateUserContentsInfoOptionRequest> _parser = new MessageParser<UpdateUserContentsInfoOptionRequest>(() => new UpdateUserContentsInfoOptionRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int IsAllPrivateFieldNumber = 2;

	private bool isAllPrivate_;

	public const int OptionsFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_options_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> options_ = new RepeatedField<int>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UpdateUserContentsInfoOptionRequest> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => UpdateUserContentsInfoOptionRequestReflection.Descriptor.MessageTypes[0];

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
	public bool IsAllPrivate
	{
		get
		{
			return isAllPrivate_;
		}
		set
		{
			isAllPrivate_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> Options => options_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateUserContentsInfoOptionRequest()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public UpdateUserContentsInfoOptionRequest(UpdateUserContentsInfoOptionRequest other)
		: this()
	{
		seq_ = other.seq_;
		isAllPrivate_ = other.isAllPrivate_;
		options_ = other.options_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public UpdateUserContentsInfoOptionRequest Clone()
	{
		return new UpdateUserContentsInfoOptionRequest(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as UpdateUserContentsInfoOptionRequest);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(UpdateUserContentsInfoOptionRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && IsAllPrivate == other.IsAllPrivate && options_.Equals(other.options_))
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
		if (IsAllPrivate)
		{
			num ^= IsAllPrivate.GetHashCode();
		}
		num ^= options_.GetHashCode();
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
		if (IsAllPrivate)
		{
			output.WriteRawTag(16);
			output.WriteBool(IsAllPrivate);
		}
		options_.WriteTo(ref output, _repeated_options_codec);
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
		if (IsAllPrivate)
		{
			num += 2;
		}
		num += options_.CalculateSize(_repeated_options_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(UpdateUserContentsInfoOptionRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			if (other.IsAllPrivate)
			{
				IsAllPrivate = other.IsAllPrivate;
			}
			options_.Add(other.options_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
			case 8u:
				Seq = input.ReadInt32();
				break;
			case 16u:
				IsAllPrivate = input.ReadBool();
				break;
			case 24u:
			case 26u:
				options_.AddEntriesFrom(ref input, _repeated_options_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
