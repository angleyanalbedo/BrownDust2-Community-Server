using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class LoginEventInfo : IMessage<LoginEventInfo>, IMessage, IEquatable<LoginEventInfo>, IDeepCloneable<LoginEventInfo>, IBufferMessage
{
	private static readonly MessageParser<LoginEventInfo> _parser = new MessageParser<LoginEventInfo>(() => new LoginEventInfo());

	private UnknownFieldSet _unknownFields;

	public const int LoginEventIdFieldNumber = 1;

	private int loginEventId_;

	public const int NextLoginTimeFieldNumber = 2;

	private long nextLoginTime_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<LoginEventInfo> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => LoginEventResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int LoginEventId
	{
		get
		{
			return loginEventId_;
		}
		set
		{
			loginEventId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long NextLoginTime
	{
		get
		{
			return nextLoginTime_;
		}
		set
		{
			nextLoginTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LoginEventInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LoginEventInfo(LoginEventInfo other)
		: this()
	{
		loginEventId_ = other.loginEventId_;
		nextLoginTime_ = other.nextLoginTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LoginEventInfo Clone()
	{
		return new LoginEventInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LoginEventInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LoginEventInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (LoginEventId == other.LoginEventId && NextLoginTime == other.NextLoginTime)
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
		if (LoginEventId != 0)
		{
			num ^= LoginEventId.GetHashCode();
		}
		if (NextLoginTime != 0L)
		{
			num ^= NextLoginTime.GetHashCode();
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
		if (LoginEventId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(LoginEventId);
		}
		if (NextLoginTime != 0L)
		{
			output.WriteRawTag(16);
			output.WriteInt64(NextLoginTime);
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
		if (LoginEventId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LoginEventId);
		}
		if (NextLoginTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(NextLoginTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LoginEventInfo other)
	{
		if (other != null)
		{
			if (other.LoginEventId != 0)
			{
				LoginEventId = other.LoginEventId;
			}
			if (other.NextLoginTime != 0L)
			{
				NextLoginTime = other.NextLoginTime;
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
			case 16u:
				NextLoginTime = input.ReadInt64();
				break;
			case 8u:
				LoginEventId = input.ReadInt32();
				break;
			}
		}
	}
}
