using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class JpUserInfoResponse : IMessage<JpUserInfoResponse>, IMessage, IEquatable<JpUserInfoResponse>, IDeepCloneable<JpUserInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<JpUserInfoResponse> _parser = new MessageParser<JpUserInfoResponse>(() => new JpUserInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int AccumulatedPaymentAmountFieldNumber = 1;

	private float accumulatedPaymentAmount_;

	public const int DateOfBirthFieldNumber = 2;

	private int dateOfBirth_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<JpUserInfoResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => JpUserInfoResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public float AccumulatedPaymentAmount
	{
		get
		{
			return accumulatedPaymentAmount_;
		}
		set
		{
			accumulatedPaymentAmount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DateOfBirth
	{
		get
		{
			return dateOfBirth_;
		}
		set
		{
			dateOfBirth_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JpUserInfoResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public JpUserInfoResponse(JpUserInfoResponse other)
		: this()
	{
		accumulatedPaymentAmount_ = other.accumulatedPaymentAmount_;
		dateOfBirth_ = other.dateOfBirth_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public JpUserInfoResponse Clone()
	{
		return new JpUserInfoResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as JpUserInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JpUserInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(AccumulatedPaymentAmount, other.AccumulatedPaymentAmount) && DateOfBirth == other.DateOfBirth)
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
		if (AccumulatedPaymentAmount != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(AccumulatedPaymentAmount);
		}
		if (DateOfBirth != 0)
		{
			num ^= DateOfBirth.GetHashCode();
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
		if (AccumulatedPaymentAmount != 0f)
		{
			output.WriteRawTag(13);
			output.WriteFloat(AccumulatedPaymentAmount);
		}
		if (DateOfBirth != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(DateOfBirth);
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
		if (AccumulatedPaymentAmount != 0f)
		{
			num += 5;
		}
		if (DateOfBirth != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DateOfBirth);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JpUserInfoResponse other)
	{
		if (other != null)
		{
			if (other.AccumulatedPaymentAmount != 0f)
			{
				AccumulatedPaymentAmount = other.AccumulatedPaymentAmount;
			}
			if (other.DateOfBirth != 0)
			{
				DateOfBirth = other.DateOfBirth;
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
			case 16u:
				DateOfBirth = input.ReadInt32();
				break;
			case 13u:
				AccumulatedPaymentAmount = input.ReadFloat();
				break;
			}
		}
	}
}
