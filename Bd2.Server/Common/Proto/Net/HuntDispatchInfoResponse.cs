using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class HuntDispatchInfoResponse : IMessage<HuntDispatchInfoResponse>, IMessage, IEquatable<HuntDispatchInfoResponse>, IDeepCloneable<HuntDispatchInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<HuntDispatchInfoResponse> _parser = new MessageParser<HuntDispatchInfoResponse>(() => new HuntDispatchInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int HuntDispatchInfoFieldNumber = 1;

	private static readonly FieldCodec<HuntDispatchDBInfo> _repeated_huntDispatchInfo_codec = FieldCodec.ForMessage(10u, HuntDispatchDBInfo.Parser);

	private readonly RepeatedField<HuntDispatchDBInfo> huntDispatchInfo_ = new RepeatedField<HuntDispatchDBInfo>();

	public const int HuntingGroundMinPackIdFieldNumber = 2;

	private int huntingGroundMinPackId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HuntDispatchInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HuntDispatchInfoResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HuntDispatchDBInfo> HuntDispatchInfo => huntDispatchInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int HuntingGroundMinPackId
	{
		get
		{
			return huntingGroundMinPackId_;
		}
		set
		{
			huntingGroundMinPackId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HuntDispatchInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HuntDispatchInfoResponse(HuntDispatchInfoResponse other)
		: this()
	{
		huntDispatchInfo_ = other.huntDispatchInfo_.Clone();
		huntingGroundMinPackId_ = other.huntingGroundMinPackId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HuntDispatchInfoResponse Clone()
	{
		return new HuntDispatchInfoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HuntDispatchInfoResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(HuntDispatchInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (huntDispatchInfo_.Equals(other.huntDispatchInfo_) && HuntingGroundMinPackId == other.HuntingGroundMinPackId)
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
		num ^= huntDispatchInfo_.GetHashCode();
		if (HuntingGroundMinPackId != 0)
		{
			num ^= HuntingGroundMinPackId.GetHashCode();
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
		huntDispatchInfo_.WriteTo(ref output, _repeated_huntDispatchInfo_codec);
		if (HuntingGroundMinPackId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(HuntingGroundMinPackId);
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
		num += huntDispatchInfo_.CalculateSize(_repeated_huntDispatchInfo_codec);
		if (HuntingGroundMinPackId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HuntingGroundMinPackId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HuntDispatchInfoResponse other)
	{
		if (other != null)
		{
			huntDispatchInfo_.Add(other.huntDispatchInfo_);
			if (other.HuntingGroundMinPackId != 0)
			{
				HuntingGroundMinPackId = other.HuntingGroundMinPackId;
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 16u:
				HuntingGroundMinPackId = input.ReadInt32();
				break;
			case 10u:
				huntDispatchInfo_.AddEntriesFrom(ref input, _repeated_huntDispatchInfo_codec);
				break;
			}
		}
	}
}
