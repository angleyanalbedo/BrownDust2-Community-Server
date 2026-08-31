using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class HuntDispatchStartResponse : IMessage<HuntDispatchStartResponse>, IMessage, IEquatable<HuntDispatchStartResponse>, IDeepCloneable<HuntDispatchStartResponse>, IBufferMessage
{
	private static readonly MessageParser<HuntDispatchStartResponse> _parser = new MessageParser<HuntDispatchStartResponse>(() => new HuntDispatchStartResponse());

	private UnknownFieldSet _unknownFields;

	public const int HuntDispatchInfoFieldNumber = 1;

	private HuntDispatchDBInfo huntDispatchInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<HuntDispatchStartResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HuntDispatchStartResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HuntDispatchDBInfo HuntDispatchInfo
	{
		get
		{
			return huntDispatchInfo_;
		}
		set
		{
			huntDispatchInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HuntDispatchStartResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HuntDispatchStartResponse(HuntDispatchStartResponse other)
		: this()
	{
		huntDispatchInfo_ = ((other.huntDispatchInfo_ != null) ? other.huntDispatchInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HuntDispatchStartResponse Clone()
	{
		return new HuntDispatchStartResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HuntDispatchStartResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(HuntDispatchStartResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(HuntDispatchInfo, other.HuntDispatchInfo))
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
		if (huntDispatchInfo_ != null)
		{
			num ^= HuntDispatchInfo.GetHashCode();
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
		if (huntDispatchInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(HuntDispatchInfo);
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
		if (huntDispatchInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HuntDispatchInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HuntDispatchStartResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.huntDispatchInfo_ != null)
		{
			if (huntDispatchInfo_ == null)
			{
				HuntDispatchInfo = new HuntDispatchDBInfo();
			}
			HuntDispatchInfo.MergeFrom(other.HuntDispatchInfo);
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
			if (huntDispatchInfo_ == null)
			{
				HuntDispatchInfo = new HuntDispatchDBInfo();
			}
			input.ReadMessage(HuntDispatchInfo);
		}
	}
}
