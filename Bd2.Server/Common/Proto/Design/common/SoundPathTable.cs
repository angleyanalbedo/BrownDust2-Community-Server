using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class SoundPathTable : IMessage<SoundPathTable>, IMessage, IEquatable<SoundPathTable>, IDeepCloneable<SoundPathTable>, IBufferMessage
{
	private static readonly MessageParser<SoundPathTable> _parser = new MessageParser<SoundPathTable>(() => new SoundPathTable());

	private UnknownFieldSet _unknownFields;

	public const int ButtonNameFieldNumber = 1;

	private string buttonName_ = "";

	public const int IdFieldNumber = 2;

	private int id_;

	public const int SoundFilePathFieldNumber = 3;

	private string soundFilePath_ = "";

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<SoundPathTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => SoundPathTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string ButtonName
	{
		get
		{
			return buttonName_;
		}
		set
		{
			buttonName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string SoundFilePath
	{
		get
		{
			return soundFilePath_;
		}
		set
		{
			soundFilePath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SoundPathTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SoundPathTable(SoundPathTable other)
		: this()
	{
		buttonName_ = other.buttonName_;
		id_ = other.id_;
		soundFilePath_ = other.soundFilePath_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SoundPathTable Clone()
	{
		return new SoundPathTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SoundPathTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SoundPathTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (!(ButtonName != other.ButtonName) && Id == other.Id && !(SoundFilePath != other.SoundFilePath))
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
		if (ButtonName.Length != 0)
		{
			num ^= ButtonName.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (SoundFilePath.Length != 0)
		{
			num ^= SoundFilePath.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (ButtonName.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(ButtonName);
		}
		if (Id != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Id);
		}
		if (SoundFilePath.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(SoundFilePath);
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
		if (ButtonName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ButtonName);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (SoundFilePath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SoundFilePath);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(SoundPathTable other)
	{
		if (other != null)
		{
			if (other.ButtonName.Length != 0)
			{
				ButtonName = other.ButtonName;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.SoundFilePath.Length != 0)
			{
				SoundFilePath = other.SoundFilePath;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
				SoundFilePath = input.ReadString();
				break;
			case 16u:
				Id = input.ReadInt32();
				break;
			case 10u:
				ButtonName = input.ReadString();
				break;
			}
		}
	}
}
