using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GachaBuyPreviewResponse : IMessage<GachaBuyPreviewResponse>, IMessage, IEquatable<GachaBuyPreviewResponse>, IDeepCloneable<GachaBuyPreviewResponse>, IBufferMessage
{
	private static readonly MessageParser<GachaBuyPreviewResponse> _parser = new MessageParser<GachaBuyPreviewResponse>(() => new GachaBuyPreviewResponse());

	private UnknownFieldSet _unknownFields;

	public const int PreviewItemInfoFieldNumber = 1;

	private RewardDBInfoBundle previewItemInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GachaBuyPreviewResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GachaBuyPreviewResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RewardDBInfoBundle PreviewItemInfo
	{
		get
		{
			return previewItemInfo_;
		}
		set
		{
			previewItemInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaBuyPreviewResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GachaBuyPreviewResponse(GachaBuyPreviewResponse other)
		: this()
	{
		previewItemInfo_ = ((other.previewItemInfo_ != null) ? other.previewItemInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GachaBuyPreviewResponse Clone()
	{
		return new GachaBuyPreviewResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GachaBuyPreviewResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GachaBuyPreviewResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(PreviewItemInfo, other.PreviewItemInfo))
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
		if (previewItemInfo_ != null)
		{
			num ^= PreviewItemInfo.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (previewItemInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(PreviewItemInfo);
		}
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
		if (previewItemInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PreviewItemInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GachaBuyPreviewResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.previewItemInfo_ != null)
		{
			if (previewItemInfo_ == null)
			{
				PreviewItemInfo = new RewardDBInfoBundle();
			}
			PreviewItemInfo.MergeFrom(other.PreviewItemInfo);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (previewItemInfo_ == null)
			{
				PreviewItemInfo = new RewardDBInfoBundle();
			}
			input.ReadMessage(PreviewItemInfo);
		}
	}
}
