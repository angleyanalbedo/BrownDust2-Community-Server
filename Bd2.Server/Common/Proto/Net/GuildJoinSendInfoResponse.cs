using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GuildJoinSendInfoResponse : IMessage<GuildJoinSendInfoResponse>, IMessage, IEquatable<GuildJoinSendInfoResponse>, IDeepCloneable<GuildJoinSendInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<GuildJoinSendInfoResponse> _parser = new MessageParser<GuildJoinSendInfoResponse>(() => new GuildJoinSendInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int JoinSendInfoFieldNumber = 1;

	private static readonly FieldCodec<GuildDBInfo> _repeated_joinSendInfo_codec = FieldCodec.ForMessage(10u, GuildDBInfo.Parser);

	private readonly RepeatedField<GuildDBInfo> joinSendInfo_ = new RepeatedField<GuildDBInfo>();

	public const int ActionInfoFieldNumber = 2;

	private static readonly FieldCodec<GuildActionDBInfo> _repeated_actionInfo_codec = FieldCodec.ForMessage(18u, GuildActionDBInfo.Parser);

	private readonly RepeatedField<GuildActionDBInfo> actionInfo_ = new RepeatedField<GuildActionDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildJoinSendInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GuildJoinSendInfoResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<GuildDBInfo> JoinSendInfo => joinSendInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GuildActionDBInfo> ActionInfo => actionInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildJoinSendInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildJoinSendInfoResponse(GuildJoinSendInfoResponse other)
		: this()
	{
		joinSendInfo_ = other.joinSendInfo_.Clone();
		actionInfo_ = other.actionInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildJoinSendInfoResponse Clone()
	{
		return new GuildJoinSendInfoResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as GuildJoinSendInfoResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildJoinSendInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (joinSendInfo_.Equals(other.joinSendInfo_) && actionInfo_.Equals(other.actionInfo_))
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
		num ^= joinSendInfo_.GetHashCode();
		num ^= actionInfo_.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		joinSendInfo_.WriteTo(ref output, _repeated_joinSendInfo_codec);
		actionInfo_.WriteTo(ref output, _repeated_actionInfo_codec);
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
		num += joinSendInfo_.CalculateSize(_repeated_joinSendInfo_codec);
		num += actionInfo_.CalculateSize(_repeated_actionInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildJoinSendInfoResponse other)
	{
		if (other != null)
		{
			joinSendInfo_.Add(other.joinSendInfo_);
			actionInfo_.Add(other.actionInfo_);
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 18u:
				actionInfo_.AddEntriesFrom(ref input, _repeated_actionInfo_codec);
				break;
			case 10u:
				joinSendInfo_.AddEntriesFrom(ref input, _repeated_joinSendInfo_codec);
				break;
			}
		}
	}
}
