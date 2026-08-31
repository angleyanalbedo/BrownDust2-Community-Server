using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class BattleGiveUpResponse : IMessage<BattleGiveUpResponse>, IMessage, IEquatable<BattleGiveUpResponse>, IDeepCloneable<BattleGiveUpResponse>, IBufferMessage
{
	private static readonly MessageParser<BattleGiveUpResponse> _parser = new MessageParser<BattleGiveUpResponse>(() => new BattleGiveUpResponse());

	private UnknownFieldSet _unknownFields;

	public const int UserInfoFieldNumber = 1;

	private UserDBInfo userInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BattleGiveUpResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BattleGiveUpResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public UserDBInfo UserInfo
	{
		get
		{
			return userInfo_;
		}
		set
		{
			userInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BattleGiveUpResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BattleGiveUpResponse(BattleGiveUpResponse other)
		: this()
	{
		userInfo_ = ((other.userInfo_ != null) ? other.userInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BattleGiveUpResponse Clone()
	{
		return new BattleGiveUpResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as BattleGiveUpResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BattleGiveUpResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(UserInfo, other.UserInfo))
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
		if (userInfo_ != null)
		{
			num ^= UserInfo.GetHashCode();
		}
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
		if (userInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(UserInfo);
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
		if (userInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(UserInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BattleGiveUpResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.userInfo_ != null)
		{
			if (userInfo_ == null)
			{
				UserInfo = new UserDBInfo();
			}
			UserInfo.MergeFrom(other.UserInfo);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (userInfo_ == null)
			{
				UserInfo = new UserDBInfo();
			}
			input.ReadMessage(UserInfo);
		}
	}
}
