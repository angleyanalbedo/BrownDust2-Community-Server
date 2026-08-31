using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GuildMemberRoleEditResponse : IMessage<GuildMemberRoleEditResponse>, IMessage, IEquatable<GuildMemberRoleEditResponse>, IDeepCloneable<GuildMemberRoleEditResponse>, IBufferMessage
{
	private static readonly MessageParser<GuildMemberRoleEditResponse> _parser = new MessageParser<GuildMemberRoleEditResponse>(() => new GuildMemberRoleEditResponse());

	private UnknownFieldSet _unknownFields;

	public const int MemberInfoFieldNumber = 1;

	private static readonly FieldCodec<GuildMemberDBInfo> _repeated_memberInfo_codec = FieldCodec.ForMessage(10u, GuildMemberDBInfo.Parser);

	private readonly RepeatedField<GuildMemberDBInfo> memberInfo_ = new RepeatedField<GuildMemberDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildMemberRoleEditResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => GuildMemberRoleEditResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<GuildMemberDBInfo> MemberInfo => memberInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildMemberRoleEditResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildMemberRoleEditResponse(GuildMemberRoleEditResponse other)
		: this()
	{
		memberInfo_ = other.memberInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildMemberRoleEditResponse Clone()
	{
		return new GuildMemberRoleEditResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GuildMemberRoleEditResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildMemberRoleEditResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (memberInfo_.Equals(other.memberInfo_))
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
		num ^= memberInfo_.GetHashCode();
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
		memberInfo_.WriteTo(ref output, _repeated_memberInfo_codec);
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
		num += memberInfo_.CalculateSize(_repeated_memberInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildMemberRoleEditResponse other)
	{
		if (other != null)
		{
			memberInfo_.Add(other.memberInfo_);
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
				memberInfo_.AddEntriesFrom(ref input, _repeated_memberInfo_codec);
			}
		}
	}
}
