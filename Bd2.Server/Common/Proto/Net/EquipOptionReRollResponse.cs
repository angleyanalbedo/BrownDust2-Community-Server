using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EquipOptionReRollResponse : IMessage<EquipOptionReRollResponse>, IMessage, IEquatable<EquipOptionReRollResponse>, IDeepCloneable<EquipOptionReRollResponse>, IBufferMessage
{
	private static readonly MessageParser<EquipOptionReRollResponse> _parser = new MessageParser<EquipOptionReRollResponse>(() => new EquipOptionReRollResponse());

	private UnknownFieldSet _unknownFields;

	public const int MainOptionFieldNumber = 1;

	private static readonly FieldCodec<EquipOptionInfo> _repeated_mainOption_codec = FieldCodec.ForMessage(10u, EquipOptionInfo.Parser);

	private readonly RepeatedField<EquipOptionInfo> mainOption_ = new RepeatedField<EquipOptionInfo>();

	public const int SubOptionFieldNumber = 2;

	private static readonly FieldCodec<EquipOptionInfo> _repeated_subOption_codec = FieldCodec.ForMessage(18u, EquipOptionInfo.Parser);

	private readonly RepeatedField<EquipOptionInfo> subOption_ = new RepeatedField<EquipOptionInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<EquipOptionReRollResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => EquipOptionReRollResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EquipOptionInfo> MainOption => mainOption_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<EquipOptionInfo> SubOption => subOption_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipOptionReRollResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EquipOptionReRollResponse(EquipOptionReRollResponse other)
		: this()
	{
		mainOption_ = other.mainOption_.Clone();
		subOption_ = other.subOption_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipOptionReRollResponse Clone()
	{
		return new EquipOptionReRollResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EquipOptionReRollResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EquipOptionReRollResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (mainOption_.Equals(other.mainOption_) && subOption_.Equals(other.subOption_))
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
		num ^= mainOption_.GetHashCode();
		num ^= subOption_.GetHashCode();
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
		mainOption_.WriteTo(ref output, _repeated_mainOption_codec);
		subOption_.WriteTo(ref output, _repeated_subOption_codec);
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
		num += mainOption_.CalculateSize(_repeated_mainOption_codec);
		num += subOption_.CalculateSize(_repeated_subOption_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(EquipOptionReRollResponse other)
	{
		if (other != null)
		{
			mainOption_.Add(other.mainOption_);
			subOption_.Add(other.subOption_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 18u:
				subOption_.AddEntriesFrom(ref input, _repeated_subOption_codec);
				break;
			case 10u:
				mainOption_.AddEntriesFrom(ref input, _repeated_mainOption_codec);
				break;
			}
		}
	}
}
