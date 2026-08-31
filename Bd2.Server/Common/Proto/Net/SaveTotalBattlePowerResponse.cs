using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class SaveTotalBattlePowerResponse : IMessage<SaveTotalBattlePowerResponse>, IMessage, IEquatable<SaveTotalBattlePowerResponse>, IDeepCloneable<SaveTotalBattlePowerResponse>, IBufferMessage
{
	private static readonly MessageParser<SaveTotalBattlePowerResponse> _parser = new MessageParser<SaveTotalBattlePowerResponse>(() => new SaveTotalBattlePowerResponse());

	private UnknownFieldSet _unknownFields;

	public const int HighestTotalBattlePowerFieldNumber = 1;

	private int highestTotalBattlePower_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SaveTotalBattlePowerResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SaveTotalBattlePowerResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int HighestTotalBattlePower
	{
		get
		{
			return highestTotalBattlePower_;
		}
		set
		{
			highestTotalBattlePower_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SaveTotalBattlePowerResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SaveTotalBattlePowerResponse(SaveTotalBattlePowerResponse other)
		: this()
	{
		highestTotalBattlePower_ = other.highestTotalBattlePower_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SaveTotalBattlePowerResponse Clone()
	{
		return new SaveTotalBattlePowerResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SaveTotalBattlePowerResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SaveTotalBattlePowerResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (HighestTotalBattlePower == other.HighestTotalBattlePower)
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
		if (HighestTotalBattlePower != 0)
		{
			num ^= HighestTotalBattlePower.GetHashCode();
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
		if (HighestTotalBattlePower != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(HighestTotalBattlePower);
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
		if (HighestTotalBattlePower != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HighestTotalBattlePower);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SaveTotalBattlePowerResponse other)
	{
		if (other != null)
		{
			if (other.HighestTotalBattlePower != 0)
			{
				HighestTotalBattlePower = other.HighestTotalBattlePower;
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
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				HighestTotalBattlePower = input.ReadInt32();
			}
		}
	}
}
