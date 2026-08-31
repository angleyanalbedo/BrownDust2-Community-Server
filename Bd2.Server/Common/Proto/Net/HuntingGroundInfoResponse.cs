using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class HuntingGroundInfoResponse : IMessage<HuntingGroundInfoResponse>, IMessage, IEquatable<HuntingGroundInfoResponse>, IDeepCloneable<HuntingGroundInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<HuntingGroundInfoResponse> _parser = new MessageParser<HuntingGroundInfoResponse>(() => new HuntingGroundInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int HuntingGroundInfoFieldNumber = 1;

	private HuntingGroundDBInfo huntingGroundInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<HuntingGroundInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HuntingGroundInfoResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HuntingGroundDBInfo HuntingGroundInfo
	{
		get
		{
			return huntingGroundInfo_;
		}
		set
		{
			huntingGroundInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HuntingGroundInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HuntingGroundInfoResponse(HuntingGroundInfoResponse other)
		: this()
	{
		huntingGroundInfo_ = ((other.huntingGroundInfo_ != null) ? other.huntingGroundInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HuntingGroundInfoResponse Clone()
	{
		return new HuntingGroundInfoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HuntingGroundInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HuntingGroundInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(HuntingGroundInfo, other.HuntingGroundInfo))
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
		if (huntingGroundInfo_ != null)
		{
			num ^= HuntingGroundInfo.GetHashCode();
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
		if (huntingGroundInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(HuntingGroundInfo);
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
		if (huntingGroundInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HuntingGroundInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(HuntingGroundInfoResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.huntingGroundInfo_ != null)
		{
			if (huntingGroundInfo_ == null)
			{
				HuntingGroundInfo = new HuntingGroundDBInfo();
			}
			HuntingGroundInfo.MergeFrom(other.HuntingGroundInfo);
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
			if (huntingGroundInfo_ == null)
			{
				HuntingGroundInfo = new HuntingGroundDBInfo();
			}
			input.ReadMessage(HuntingGroundInfo);
		}
	}
}
