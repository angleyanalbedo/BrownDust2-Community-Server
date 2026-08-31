using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class UserContentsInfoOptionResponse : IMessage<UserContentsInfoOptionResponse>, IMessage, IEquatable<UserContentsInfoOptionResponse>, IDeepCloneable<UserContentsInfoOptionResponse>, IBufferMessage
{
	private static readonly MessageParser<UserContentsInfoOptionResponse> _parser = new MessageParser<UserContentsInfoOptionResponse>(() => new UserContentsInfoOptionResponse());

	private UnknownFieldSet _unknownFields;

	public const int IsAllPrivateFieldNumber = 1;

	private bool isAllPrivate_;

	public const int OptionsFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_options_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> options_ = new RepeatedField<int>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UserContentsInfoOptionResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => UserContentsInfoOptionResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> Options => options_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UserContentsInfoOptionResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UserContentsInfoOptionResponse(UserContentsInfoOptionResponse other)
		: this()
	{
		isAllPrivate_ = other.isAllPrivate_;
		options_ = other.options_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UserContentsInfoOptionResponse Clone()
	{
		return new UserContentsInfoOptionResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as UserContentsInfoOptionResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UserContentsInfoOptionResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (IsAllPrivate == other.IsAllPrivate && options_.Equals(other.options_))
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
		if (IsAllPrivate)
		{
			output.WriteRawTag(8);
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(UserContentsInfoOptionResponse other)
	{
		if (other != null)
		{
			if (other.IsAllPrivate)
			{
				IsAllPrivate = other.IsAllPrivate;
			}
			options_.Add(other.options_);
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
			case 16u:
			case 18u:
				options_.AddEntriesFrom(ref input, _repeated_options_codec);
				break;
			case 8u:
				IsAllPrivate = input.ReadBool();
				break;
			}
		}
	}
}
