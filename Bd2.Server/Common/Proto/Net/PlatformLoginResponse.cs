using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PlatformLoginResponse : IMessage<PlatformLoginResponse>, IMessage, IEquatable<PlatformLoginResponse>, IDeepCloneable<PlatformLoginResponse>, IBufferMessage
{
	private static readonly MessageParser<PlatformLoginResponse> _parser = new MessageParser<PlatformLoginResponse>(() => new PlatformLoginResponse());

	private UnknownFieldSet _unknownFields;

	public const int UserInfoFieldNumber = 1;

	private UserDBInfo userInfo_;

	public const int UserGuildInfoFieldNumber = 2;

	private GuildMemberDBInfo userGuildInfo_;

	public const int GuildBaseInfoFieldNumber = 3;

	private GuildBaseDBInfo guildBaseInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PlatformLoginResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => PlatformLoginResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public GuildMemberDBInfo UserGuildInfo
	{
		get
		{
			return userGuildInfo_;
		}
		set
		{
			userGuildInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildBaseDBInfo GuildBaseInfo
	{
		get
		{
			return guildBaseInfo_;
		}
		set
		{
			guildBaseInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlatformLoginResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PlatformLoginResponse(PlatformLoginResponse other)
		: this()
	{
		userInfo_ = ((other.userInfo_ != null) ? other.userInfo_.Clone() : null);
		userGuildInfo_ = ((other.userGuildInfo_ != null) ? other.userGuildInfo_.Clone() : null);
		guildBaseInfo_ = ((other.guildBaseInfo_ != null) ? other.guildBaseInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PlatformLoginResponse Clone()
	{
		return new PlatformLoginResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlatformLoginResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlatformLoginResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(UserInfo, other.UserInfo) && object.Equals(UserGuildInfo, other.UserGuildInfo) && object.Equals(GuildBaseInfo, other.GuildBaseInfo))
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
		if (userGuildInfo_ != null)
		{
			num ^= UserGuildInfo.GetHashCode();
		}
		if (guildBaseInfo_ != null)
		{
			num ^= GuildBaseInfo.GetHashCode();
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
		if (userInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(UserInfo);
		}
		if (userGuildInfo_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(UserGuildInfo);
		}
		if (guildBaseInfo_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(GuildBaseInfo);
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
		if (userInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(UserInfo);
		}
		if (userGuildInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(UserGuildInfo);
		}
		if (guildBaseInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GuildBaseInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlatformLoginResponse other)
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
		if (other.userGuildInfo_ != null)
		{
			if (userGuildInfo_ == null)
			{
				UserGuildInfo = new GuildMemberDBInfo();
			}
			UserGuildInfo.MergeFrom(other.UserGuildInfo);
		}
		if (other.guildBaseInfo_ != null)
		{
			if (guildBaseInfo_ == null)
			{
				GuildBaseInfo = new GuildBaseDBInfo();
			}
			GuildBaseInfo.MergeFrom(other.GuildBaseInfo);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				if (guildBaseInfo_ == null)
				{
					GuildBaseInfo = new GuildBaseDBInfo();
				}
				input.ReadMessage(GuildBaseInfo);
				break;
			case 18u:
				if (userGuildInfo_ == null)
				{
					UserGuildInfo = new GuildMemberDBInfo();
				}
				input.ReadMessage(UserGuildInfo);
				break;
			case 10u:
				if (userInfo_ == null)
				{
					UserInfo = new UserDBInfo();
				}
				input.ReadMessage(UserInfo);
				break;
			}
		}
	}
}
