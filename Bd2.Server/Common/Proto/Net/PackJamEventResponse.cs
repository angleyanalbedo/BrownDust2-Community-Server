using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PackJamEventResponse : IMessage<PackJamEventResponse>, IMessage, IEquatable<PackJamEventResponse>, IDeepCloneable<PackJamEventResponse>, IBufferMessage
{
	private static readonly MessageParser<PackJamEventResponse> _parser = new MessageParser<PackJamEventResponse>(() => new PackJamEventResponse());

	private UnknownFieldSet _unknownFields;

	public const int PackEventRewardFieldNumber = 1;

	private ItemDBInfo packEventReward_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PackJamEventResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PackJamEventResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ItemDBInfo PackEventReward
	{
		get
		{
			return packEventReward_;
		}
		set
		{
			packEventReward_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackJamEventResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PackJamEventResponse(PackJamEventResponse other)
		: this()
	{
		packEventReward_ = ((other.packEventReward_ != null) ? other.packEventReward_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackJamEventResponse Clone()
	{
		return new PackJamEventResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PackJamEventResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PackJamEventResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(PackEventReward, other.PackEventReward))
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
		if (packEventReward_ != null)
		{
			num ^= PackEventReward.GetHashCode();
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
		if (packEventReward_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(PackEventReward);
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
		if (packEventReward_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PackEventReward);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PackJamEventResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.packEventReward_ != null)
		{
			if (packEventReward_ == null)
			{
				PackEventReward = new ItemDBInfo();
			}
			PackEventReward.MergeFrom(other.PackEventReward);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (packEventReward_ == null)
			{
				PackEventReward = new ItemDBInfo();
			}
			input.ReadMessage(PackEventReward);
		}
	}
}
