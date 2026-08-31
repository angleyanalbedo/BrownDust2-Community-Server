using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class FieldObjectPreviewResponse : IMessage<FieldObjectPreviewResponse>, IMessage, IEquatable<FieldObjectPreviewResponse>, IDeepCloneable<FieldObjectPreviewResponse>, IBufferMessage
{
	private static readonly MessageParser<FieldObjectPreviewResponse> _parser = new MessageParser<FieldObjectPreviewResponse>(() => new FieldObjectPreviewResponse());

	private UnknownFieldSet _unknownFields;

	public const int FieldRewardObtainInfoFieldNumber = 1;

	private static readonly FieldCodec<FieldObjectDBInfo> _repeated_fieldRewardObtainInfo_codec = FieldCodec.ForMessage(10u, FieldObjectDBInfo.Parser);

	private readonly RepeatedField<FieldObjectDBInfo> fieldRewardObtainInfo_ = new RepeatedField<FieldObjectDBInfo>();

	public const int ResearchObjectIdFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_researchObjectId_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> researchObjectId_ = new RepeatedField<int>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FieldObjectPreviewResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => FieldObjectPreviewResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<FieldObjectDBInfo> FieldRewardObtainInfo => fieldRewardObtainInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> ResearchObjectId => researchObjectId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FieldObjectPreviewResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FieldObjectPreviewResponse(FieldObjectPreviewResponse other)
		: this()
	{
		fieldRewardObtainInfo_ = other.fieldRewardObtainInfo_.Clone();
		researchObjectId_ = other.researchObjectId_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FieldObjectPreviewResponse Clone()
	{
		return new FieldObjectPreviewResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as FieldObjectPreviewResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(FieldObjectPreviewResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (fieldRewardObtainInfo_.Equals(other.fieldRewardObtainInfo_) && researchObjectId_.Equals(other.researchObjectId_))
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
		num ^= fieldRewardObtainInfo_.GetHashCode();
		num ^= researchObjectId_.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		fieldRewardObtainInfo_.WriteTo(ref output, _repeated_fieldRewardObtainInfo_codec);
		researchObjectId_.WriteTo(ref output, _repeated_researchObjectId_codec);
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
		num += fieldRewardObtainInfo_.CalculateSize(_repeated_fieldRewardObtainInfo_codec);
		num += researchObjectId_.CalculateSize(_repeated_researchObjectId_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FieldObjectPreviewResponse other)
	{
		if (other != null)
		{
			fieldRewardObtainInfo_.Add(other.fieldRewardObtainInfo_);
			researchObjectId_.Add(other.researchObjectId_);
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
			case 18u:
				researchObjectId_.AddEntriesFrom(ref input, _repeated_researchObjectId_codec);
				break;
			case 10u:
				fieldRewardObtainInfo_.AddEntriesFrom(ref input, _repeated_fieldRewardObtainInfo_codec);
				break;
			}
		}
	}
}
