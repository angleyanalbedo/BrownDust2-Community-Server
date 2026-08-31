using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EquipClearResponse : IMessage<EquipClearResponse>, IMessage, IEquatable<EquipClearResponse>, IDeepCloneable<EquipClearResponse>, IBufferMessage
{
	private static readonly MessageParser<EquipClearResponse> _parser = new MessageParser<EquipClearResponse>(() => new EquipClearResponse());

	private UnknownFieldSet _unknownFields;

	public const int CharInfoFieldNumber = 1;

	private CharDBInfo charInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EquipClearResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EquipClearResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharDBInfo CharInfo
	{
		get
		{
			return charInfo_;
		}
		set
		{
			charInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EquipClearResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EquipClearResponse(EquipClearResponse other)
		: this()
	{
		charInfo_ = ((other.charInfo_ != null) ? other.charInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EquipClearResponse Clone()
	{
		return new EquipClearResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EquipClearResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EquipClearResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(CharInfo, other.CharInfo))
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
		if (charInfo_ != null)
		{
			num ^= CharInfo.GetHashCode();
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
		if (charInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(CharInfo);
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
		if (charInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CharInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EquipClearResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.charInfo_ != null)
		{
			if (charInfo_ == null)
			{
				CharInfo = new CharDBInfo();
			}
			CharInfo.MergeFrom(other.CharInfo);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				continue;
			}
			if (charInfo_ == null)
			{
				CharInfo = new CharDBInfo();
			}
			input.ReadMessage(CharInfo);
		}
	}
}
