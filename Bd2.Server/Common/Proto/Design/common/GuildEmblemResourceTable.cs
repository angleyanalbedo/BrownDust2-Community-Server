using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class GuildEmblemResourceTable : IMessage<GuildEmblemResourceTable>, IMessage, IEquatable<GuildEmblemResourceTable>, IDeepCloneable<GuildEmblemResourceTable>, IBufferMessage
{
	private static readonly MessageParser<GuildEmblemResourceTable> _parser = new MessageParser<GuildEmblemResourceTable>(() => new GuildEmblemResourceTable());

	private UnknownFieldSet _unknownFields;

	public const int DisplayResourceNameFieldNumber = 1;

	private string displayResourceName_ = "";

	public const int IdFieldNumber = 2;

	private int id_;

	public const int ResourceNameFieldNumber = 3;

	private string resourceName_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildEmblemResourceTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GuildEmblemResourceTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string DisplayResourceName
	{
		get
		{
			return displayResourceName_;
		}
		set
		{
			displayResourceName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Id
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string ResourceName
	{
		get
		{
			return resourceName_;
		}
		set
		{
			resourceName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildEmblemResourceTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildEmblemResourceTable(GuildEmblemResourceTable other)
		: this()
	{
		displayResourceName_ = other.displayResourceName_;
		id_ = other.id_;
		resourceName_ = other.resourceName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildEmblemResourceTable Clone()
	{
		return new GuildEmblemResourceTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GuildEmblemResourceTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildEmblemResourceTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (!(DisplayResourceName != other.DisplayResourceName) && Id == other.Id && !(ResourceName != other.ResourceName))
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
		if (DisplayResourceName.Length != 0)
		{
			num ^= DisplayResourceName.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (ResourceName.Length != 0)
		{
			num ^= ResourceName.GetHashCode();
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (DisplayResourceName.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(DisplayResourceName);
		}
		if (Id != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Id);
		}
		if (ResourceName.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(ResourceName);
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
		if (DisplayResourceName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DisplayResourceName);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (ResourceName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ResourceName);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildEmblemResourceTable other)
	{
		if (other != null)
		{
			if (other.DisplayResourceName.Length != 0)
			{
				DisplayResourceName = other.DisplayResourceName;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.ResourceName.Length != 0)
			{
				ResourceName = other.ResourceName;
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
			case 26u:
				ResourceName = input.ReadString();
				break;
			case 16u:
				Id = input.ReadInt32();
				break;
			case 10u:
				DisplayResourceName = input.ReadString();
				break;
			}
		}
	}
}
