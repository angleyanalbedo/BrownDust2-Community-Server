using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GuildInfoEditRequest : IMessage<GuildInfoEditRequest>, IMessage, IEquatable<GuildInfoEditRequest>, IDeepCloneable<GuildInfoEditRequest>, IBufferMessage
{
	private static readonly MessageParser<GuildInfoEditRequest> _parser = new MessageParser<GuildInfoEditRequest>(() => new GuildInfoEditRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int IconFieldNumber = 2;

	private int icon_;

	public const int IconColorFieldNumber = 3;

	private string iconColor_ = "";

	public const int MessageFieldNumber = 4;

	private string message_ = "";

	public const int JoinTypeFieldNumber = 5;

	private Define_GuildJoinType joinType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildInfoEditRequest> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => GuildInfoEditRequestReflection.Descriptor.MessageTypes[0];

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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public GuildInfoEditRequest()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildInfoEditRequest(GuildInfoEditRequest other)
		: this()
	{
		seq_ = other.seq_;
		icon_ = other.icon_;
		iconColor_ = other.iconColor_;
		message_ = other.message_;
		joinType_ = other.joinType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildInfoEditRequest Clone()
	{
		return new GuildInfoEditRequest(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as GuildInfoEditRequest);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildInfoEditRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && Icon == other.Icon && !(IconColor != other.IconColor) && !(Message != other.Message) && JoinType == other.JoinType)
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (Seq != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Seq);
		}
		if (Icon != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Icon);
		}
		if (IconColor.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(IconColor);
		}
		if (Message.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(Message);
		}
		if (JoinType != Define_GuildJoinType.GuildTypeNone)
		{
			output.WriteRawTag(40);
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
	public void MergeFrom(GuildInfoEditRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
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
				Icon = input.ReadInt32();
				break;
			case 26u:
				IconColor = input.ReadString();
				break;
			case 34u:
				Message = input.ReadString();
				break;
			case 40u:
				JoinType = (Define_GuildJoinType)input.ReadEnum();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
