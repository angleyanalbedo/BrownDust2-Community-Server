using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PassInfoResponse : IMessage<PassInfoResponse>, IMessage, IEquatable<PassInfoResponse>, IDeepCloneable<PassInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<PassInfoResponse> _parser = new MessageParser<PassInfoResponse>(() => new PassInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int PassInfoFieldNumber = 1;

	private static readonly FieldCodec<PassDBInfo> _repeated_passInfo_codec = FieldCodec.ForMessage(10u, PassDBInfo.Parser);

	private readonly RepeatedField<PassDBInfo> passInfo_ = new RepeatedField<PassDBInfo>();

	public const int PassRewardInfoFieldNumber = 2;

	private static readonly FieldCodec<PassRewardDBInfo> _repeated_passRewardInfo_codec = FieldCodec.ForMessage(18u, PassRewardDBInfo.Parser);

	private readonly RepeatedField<PassRewardDBInfo> passRewardInfo_ = new RepeatedField<PassRewardDBInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PassInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PassInfoResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<PassDBInfo> PassInfo => passInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PassRewardDBInfo> PassRewardInfo => passRewardInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PassInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PassInfoResponse(PassInfoResponse other)
		: this()
	{
		passInfo_ = other.passInfo_.Clone();
		passRewardInfo_ = other.passRewardInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PassInfoResponse Clone()
	{
		return new PassInfoResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as PassInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PassInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (passInfo_.Equals(other.passInfo_) && passRewardInfo_.Equals(other.passRewardInfo_))
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
		num ^= passInfo_.GetHashCode();
		num ^= passRewardInfo_.GetHashCode();
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
		passInfo_.WriteTo(ref output, _repeated_passInfo_codec);
		passRewardInfo_.WriteTo(ref output, _repeated_passRewardInfo_codec);
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
		num += passInfo_.CalculateSize(_repeated_passInfo_codec);
		num += passRewardInfo_.CalculateSize(_repeated_passRewardInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PassInfoResponse other)
	{
		if (other != null)
		{
			passInfo_.Add(other.passInfo_);
			passRewardInfo_.Add(other.passRewardInfo_);
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
			case 18u:
				passRewardInfo_.AddEntriesFrom(ref input, _repeated_passRewardInfo_codec);
				break;
			case 10u:
				passInfo_.AddEntriesFrom(ref input, _repeated_passInfo_codec);
				break;
			}
		}
	}
}
