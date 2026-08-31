using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EquipStorageOutResponse : IMessage<EquipStorageOutResponse>, IMessage, IEquatable<EquipStorageOutResponse>, IDeepCloneable<EquipStorageOutResponse>, IBufferMessage
{
	private static readonly MessageParser<EquipStorageOutResponse> _parser = new MessageParser<EquipStorageOutResponse>(() => new EquipStorageOutResponse());

	private UnknownFieldSet _unknownFields;

	public const int EquipInfoFieldNumber = 1;

	private EquipDBInfo equipInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<EquipStorageOutResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => EquipStorageOutResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipDBInfo EquipInfo
	{
		get
		{
			return equipInfo_;
		}
		set
		{
			equipInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipStorageOutResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipStorageOutResponse(EquipStorageOutResponse other)
		: this()
	{
		equipInfo_ = ((other.equipInfo_ != null) ? other.equipInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipStorageOutResponse Clone()
	{
		return new EquipStorageOutResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EquipStorageOutResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EquipStorageOutResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(EquipInfo, other.EquipInfo))
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
		if (equipInfo_ != null)
		{
			num ^= EquipInfo.GetHashCode();
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
		if (equipInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(EquipInfo);
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
		if (equipInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EquipInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EquipStorageOutResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.equipInfo_ != null)
		{
			if (equipInfo_ == null)
			{
				EquipInfo = new EquipDBInfo();
			}
			EquipInfo.MergeFrom(other.EquipInfo);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (equipInfo_ == null)
			{
				EquipInfo = new EquipDBInfo();
			}
			input.ReadMessage(EquipInfo);
		}
	}
}
