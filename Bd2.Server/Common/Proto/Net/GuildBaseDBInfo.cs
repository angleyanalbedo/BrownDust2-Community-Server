using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GuildBaseDBInfo : IMessage<GuildBaseDBInfo>, IMessage, IEquatable<GuildBaseDBInfo>, IDeepCloneable<GuildBaseDBInfo>, IBufferMessage
{
	private static readonly MessageParser<GuildBaseDBInfo> _parser = new MessageParser<GuildBaseDBInfo>(() => new GuildBaseDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private long id_;

	public const int NameFieldNumber = 2;

	private string name_ = "";

	public const int IconFieldNumber = 3;

	private int icon_;

	public const int IconColorFieldNumber = 4;

	private string iconColor_ = "";

	public const int GradeFieldNumber = 5;

	private int grade_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildBaseDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GuildBaseDBInfoReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public int Grade
	{
		get
		{
			return grade_;
		}
		set
		{
			grade_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildBaseDBInfo()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildBaseDBInfo(GuildBaseDBInfo other)
		: this()
	{
		id_ = other.id_;
		name_ = other.name_;
		icon_ = other.icon_;
		iconColor_ = other.iconColor_;
		grade_ = other.grade_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildBaseDBInfo Clone()
	{
		return new GuildBaseDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GuildBaseDBInfo);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildBaseDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && !(Name != other.Name) && Icon == other.Icon && !(IconColor != other.IconColor) && Grade == other.Grade)
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
		if (Id != 0L)
		{
			num ^= Id.GetHashCode();
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
		if (Grade != 0)
		{
			num ^= Grade.GetHashCode();
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
		if (Id != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(Id);
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
		if (Grade != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Grade);
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
		if (Id != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(Id);
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
		if (Grade != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Grade);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildBaseDBInfo other)
	{
		if (other != null)
		{
			if (other.Id != 0L)
			{
				Id = other.Id;
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
			if (other.Grade != 0)
			{
				Grade = other.Grade;
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
				Id = input.ReadInt64();
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
			case 40u:
				Grade = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
