using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class LoginEventResponse : IMessage<LoginEventResponse>, IMessage, IEquatable<LoginEventResponse>, IDeepCloneable<LoginEventResponse>, IBufferMessage
{
	private static readonly MessageParser<LoginEventResponse> _parser = new MessageParser<LoginEventResponse>(() => new LoginEventResponse());

	private UnknownFieldSet _unknownFields;

	public const int LoginEventInfoFieldNumber = 1;

	private static readonly FieldCodec<LoginEventInfo> _repeated_loginEventInfo_codec = FieldCodec.ForMessage(10u, Bd2.Server.Common.Proto.Net.LoginEventInfo.Parser);

	private readonly RepeatedField<LoginEventInfo> loginEventInfo_ = new RepeatedField<LoginEventInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LoginEventResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LoginEventResponseReflection.Descriptor.MessageTypes[1];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LoginEventInfo> LoginEventInfo => loginEventInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LoginEventResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LoginEventResponse(LoginEventResponse other)
		: this()
	{
		loginEventInfo_ = other.loginEventInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LoginEventResponse Clone()
	{
		return new LoginEventResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LoginEventResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LoginEventResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (loginEventInfo_.Equals(other.loginEventInfo_))
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
		num ^= loginEventInfo_.GetHashCode();
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
		loginEventInfo_.WriteTo(ref output, _repeated_loginEventInfo_codec);
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
		num += loginEventInfo_.CalculateSize(_repeated_loginEventInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LoginEventResponse other)
	{
		if (other != null)
		{
			loginEventInfo_.Add(other.loginEventInfo_);
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				loginEventInfo_.AddEntriesFrom(ref input, _repeated_loginEventInfo_codec);
			}
		}
	}
}
