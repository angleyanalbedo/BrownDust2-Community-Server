using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PackSubQuestClearInfoResponse : IMessage<PackSubQuestClearInfoResponse>, IMessage, IEquatable<PackSubQuestClearInfoResponse>, IDeepCloneable<PackSubQuestClearInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<PackSubQuestClearInfoResponse> _parser = new MessageParser<PackSubQuestClearInfoResponse>(() => new PackSubQuestClearInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int SubQuestClearInfoFieldNumber = 1;

	private static readonly FieldCodec<PackSubQuestClearInfo> _repeated_subQuestClearInfo_codec = FieldCodec.ForMessage(10u, PackSubQuestClearInfo.Parser);

	private readonly RepeatedField<PackSubQuestClearInfo> subQuestClearInfo_ = new RepeatedField<PackSubQuestClearInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PackSubQuestClearInfoResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => PackSubQuestClearInfoResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<PackSubQuestClearInfo> SubQuestClearInfo => subQuestClearInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PackSubQuestClearInfoResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PackSubQuestClearInfoResponse(PackSubQuestClearInfoResponse other)
		: this()
	{
		subQuestClearInfo_ = other.subQuestClearInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackSubQuestClearInfoResponse Clone()
	{
		return new PackSubQuestClearInfoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PackSubQuestClearInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PackSubQuestClearInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (subQuestClearInfo_.Equals(other.subQuestClearInfo_))
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
		num ^= subQuestClearInfo_.GetHashCode();
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
		subQuestClearInfo_.WriteTo(ref output, _repeated_subQuestClearInfo_codec);
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
		num += subQuestClearInfo_.CalculateSize(_repeated_subQuestClearInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PackSubQuestClearInfoResponse other)
	{
		if (other != null)
		{
			subQuestClearInfo_.Add(other.subQuestClearInfo_);
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				subQuestClearInfo_.AddEntriesFrom(ref input, _repeated_subQuestClearInfo_codec);
			}
		}
	}
}
