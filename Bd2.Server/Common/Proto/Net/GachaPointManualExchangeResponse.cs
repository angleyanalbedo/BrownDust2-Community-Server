using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GachaPointManualExchangeResponse : IMessage<GachaPointManualExchangeResponse>, IMessage, IEquatable<GachaPointManualExchangeResponse>, IDeepCloneable<GachaPointManualExchangeResponse>, IBufferMessage
{
	private static readonly MessageParser<GachaPointManualExchangeResponse> _parser = new MessageParser<GachaPointManualExchangeResponse>(() => new GachaPointManualExchangeResponse());

	private UnknownFieldSet _unknownFields;

	public const int RewardInfoBundleFieldNumber = 1;

	private RewardDBInfoBundle rewardInfoBundle_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GachaPointManualExchangeResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => GachaPointManualExchangeResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RewardDBInfoBundle RewardInfoBundle
	{
		get
		{
			return rewardInfoBundle_;
		}
		set
		{
			rewardInfoBundle_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GachaPointManualExchangeResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GachaPointManualExchangeResponse(GachaPointManualExchangeResponse other)
		: this()
	{
		rewardInfoBundle_ = ((other.rewardInfoBundle_ != null) ? other.rewardInfoBundle_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaPointManualExchangeResponse Clone()
	{
		return new GachaPointManualExchangeResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GachaPointManualExchangeResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GachaPointManualExchangeResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(RewardInfoBundle, other.RewardInfoBundle))
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
		if (rewardInfoBundle_ != null)
		{
			num ^= RewardInfoBundle.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (rewardInfoBundle_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(RewardInfoBundle);
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
		if (rewardInfoBundle_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RewardInfoBundle);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GachaPointManualExchangeResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.rewardInfoBundle_ != null)
		{
			if (rewardInfoBundle_ == null)
			{
				RewardInfoBundle = new RewardDBInfoBundle();
			}
			RewardInfoBundle.MergeFrom(other.RewardInfoBundle);
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
			if (rewardInfoBundle_ == null)
			{
				RewardInfoBundle = new RewardDBInfoBundle();
			}
			input.ReadMessage(RewardInfoBundle);
		}
	}
}
