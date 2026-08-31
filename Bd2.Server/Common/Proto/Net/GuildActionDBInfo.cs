using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GuildActionDBInfo : IMessage<GuildActionDBInfo>, IMessage, IEquatable<GuildActionDBInfo>, IDeepCloneable<GuildActionDBInfo>, IBufferMessage
{
	private static readonly MessageParser<GuildActionDBInfo> _parser = new MessageParser<GuildActionDBInfo>(() => new GuildActionDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int TypeFieldNumber = 1;

	private Define_GuildAction type_;

	public const int TimeFieldNumber = 2;

	private long time_;

	public const int GuildIdFieldNumber = 3;

	private long guildId_;

	public const int GuildNameFieldNumber = 4;

	private string guildName_ = "";

	public const int IsNotifyFieldNumber = 5;

	private bool isNotify_;

	public const int RoleFieldNumber = 6;

	private Define_GuildMemberRole role_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildActionDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GuildActionDBInfoReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Define_GuildAction Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Time
	{
		get
		{
			return time_;
		}
		set
		{
			time_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long GuildId
	{
		get
		{
			return guildId_;
		}
		set
		{
			guildId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string GuildName
	{
		get
		{
			return guildName_;
		}
		set
		{
			guildName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsNotify
	{
		get
		{
			return isNotify_;
		}
		set
		{
			isNotify_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Define_GuildMemberRole Role
	{
		get
		{
			return role_;
		}
		set
		{
			role_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildActionDBInfo()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildActionDBInfo(GuildActionDBInfo other)
		: this()
	{
		type_ = other.type_;
		time_ = other.time_;
		guildId_ = other.guildId_;
		guildName_ = other.guildName_;
		isNotify_ = other.isNotify_;
		role_ = other.role_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildActionDBInfo Clone()
	{
		return new GuildActionDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GuildActionDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildActionDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Type == other.Type && Time == other.Time && GuildId == other.GuildId && !(GuildName != other.GuildName) && IsNotify == other.IsNotify && Role == other.Role)
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
		if (Type != Define_GuildAction.GuildActionNone)
		{
			num ^= Type.GetHashCode();
		}
		if (Time != 0L)
		{
			num ^= Time.GetHashCode();
		}
		if (GuildId != 0L)
		{
			num ^= GuildId.GetHashCode();
		}
		if (GuildName.Length != 0)
		{
			num ^= GuildName.GetHashCode();
		}
		if (IsNotify)
		{
			num ^= IsNotify.GetHashCode();
		}
		if (Role != Define_GuildMemberRole.GuildRoleNone)
		{
			num ^= Role.GetHashCode();
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
		if (Type != Define_GuildAction.GuildActionNone)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Type);
		}
		if (Time != 0L)
		{
			output.WriteRawTag(16);
			output.WriteInt64(Time);
		}
		if (GuildId != 0L)
		{
			output.WriteRawTag(24);
			output.WriteInt64(GuildId);
		}
		if (GuildName.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(GuildName);
		}
		if (IsNotify)
		{
			output.WriteRawTag(40);
			output.WriteBool(IsNotify);
		}
		if (Role != Define_GuildMemberRole.GuildRoleNone)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)Role);
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
		if (Type != Define_GuildAction.GuildActionNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (Time != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(Time);
		}
		if (GuildId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(GuildId);
		}
		if (GuildName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GuildName);
		}
		if (IsNotify)
		{
			num += 2;
		}
		if (Role != Define_GuildMemberRole.GuildRoleNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Role);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GuildActionDBInfo other)
	{
		if (other != null)
		{
			if (other.Type != Define_GuildAction.GuildActionNone)
			{
				Type = other.Type;
			}
			if (other.Time != 0L)
			{
				Time = other.Time;
			}
			if (other.GuildId != 0L)
			{
				GuildId = other.GuildId;
			}
			if (other.GuildName.Length != 0)
			{
				GuildName = other.GuildName;
			}
			if (other.IsNotify)
			{
				IsNotify = other.IsNotify;
			}
			if (other.Role != Define_GuildMemberRole.GuildRoleNone)
			{
				Role = other.Role;
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
			case 8u:
				Type = (Define_GuildAction)input.ReadEnum();
				break;
			case 16u:
				Time = input.ReadInt64();
				break;
			case 24u:
				GuildId = input.ReadInt64();
				break;
			case 34u:
				GuildName = input.ReadString();
				break;
			case 40u:
				IsNotify = input.ReadBool();
				break;
			case 48u:
				Role = (Define_GuildMemberRole)input.ReadEnum();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
