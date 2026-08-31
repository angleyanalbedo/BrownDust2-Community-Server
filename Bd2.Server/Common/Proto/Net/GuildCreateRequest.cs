using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GuildCreateRequest : IMessage<GuildCreateRequest>, IMessage, IEquatable<GuildCreateRequest>, IDeepCloneable<GuildCreateRequest>, IBufferMessage
{
	private static readonly MessageParser<GuildCreateRequest> _parser = new MessageParser<GuildCreateRequest>(() => new GuildCreateRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int NameFieldNumber = 2;

	private string name_ = "";

	public const int IconFieldNumber = 3;

	private int icon_;

	public const int IconColorFieldNumber = 4;

	private string iconColor_ = "";

	public const int MessageFieldNumber = 5;

	private string message_ = "";

	public const int JoinTypeFieldNumber = 6;

	private Define_GuildJoinType joinType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildCreateRequest> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GuildCreateRequestReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public string Name
	{
		get
		{
			return name_;
		}
		set
		{
			name_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Icon
	{
		get
		{
			return icon_;
		}
		set
		{
			icon_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string IconColor
	{
		get
		{
			return iconColor_;
		}
		set
		{
			iconColor_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Message
	{
		get
		{
			return message_;
		}
		set
		{
			message_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Define_GuildJoinType JoinType
	{
		get
		{
			return joinType_;
		}
		set
		{
			joinType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildCreateRequest()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildCreateRequest(GuildCreateRequest other)
		: this()
	{
		seq_ = other.seq_;
		name_ = other.name_;
		icon_ = other.icon_;
		iconColor_ = other.iconColor_;
		message_ = other.message_;
		joinType_ = other.joinType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildCreateRequest Clone()
	{
		return new GuildCreateRequest(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as GuildCreateRequest);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildCreateRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && !(Name != other.Name) && Icon == other.Icon && !(IconColor != other.IconColor) && !(Message != other.Message) && JoinType == other.JoinType)
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
		if (Seq != 0)
		{
			num ^= Seq.GetHashCode();
		}
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (Icon != 0)
		{
			num ^= Icon.GetHashCode();
		}
		if (IconColor.Length != 0)
		{
			num ^= IconColor.GetHashCode();
		}
		if (Message.Length != 0)
		{
			num ^= Message.GetHashCode();
		}
		if (JoinType != Define_GuildJoinType.GuildTypeNone)
		{
			num ^= JoinType.GetHashCode();
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
		if (Seq != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Seq);
		}
		if (Name.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Name);
		}
		if (Icon != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Icon);
		}
		if (IconColor.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(IconColor);
		}
		if (Message.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(Message);
		}
		if (JoinType != Define_GuildJoinType.GuildTypeNone)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)JoinType);
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
		if (Seq != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Seq);
		}
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (Icon != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Icon);
		}
		if (IconColor.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(IconColor);
		}
		if (Message.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Message);
		}
		if (JoinType != Define_GuildJoinType.GuildTypeNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)JoinType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildCreateRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.Icon != 0)
			{
				Icon = other.Icon;
			}
			if (other.IconColor.Length != 0)
			{
				IconColor = other.IconColor;
			}
			if (other.Message.Length != 0)
			{
				Message = other.Message;
			}
			if (other.JoinType != Define_GuildJoinType.GuildTypeNone)
			{
				JoinType = other.JoinType;
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
			case 18u:
				Name = input.ReadString();
				break;
			case 24u:
				Icon = input.ReadInt32();
				break;
			case 34u:
				IconColor = input.ReadString();
				break;
			case 42u:
				Message = input.ReadString();
				break;
			case 48u:
				JoinType = (Define_GuildJoinType)input.ReadEnum();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
