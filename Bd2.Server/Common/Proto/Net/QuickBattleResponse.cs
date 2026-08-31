using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class QuickBattleResponse : IMessage<QuickBattleResponse>, IMessage, IEquatable<QuickBattleResponse>, IDeepCloneable<QuickBattleResponse>, IBufferMessage
{
	private static readonly MessageParser<QuickBattleResponse> _parser = new MessageParser<QuickBattleResponse>(() => new QuickBattleResponse());

	private UnknownFieldSet _unknownFields;

	public const int RewardBundleFieldNumber = 1;

	private RewardDBInfoBundle rewardBundle_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<QuickBattleResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => QuickBattleResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RewardDBInfoBundle RewardBundle
	{
		get
		{
			return rewardBundle_;
		}
		set
		{
			rewardBundle_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuickBattleResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuickBattleResponse(QuickBattleResponse other)
		: this()
	{
		rewardBundle_ = ((other.rewardBundle_ != null) ? other.rewardBundle_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public QuickBattleResponse Clone()
	{
		return new QuickBattleResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as QuickBattleResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(QuickBattleResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(RewardBundle, other.RewardBundle))
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
		if (rewardBundle_ != null)
		{
			num ^= RewardBundle.GetHashCode();
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
		if (rewardBundle_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(RewardBundle);
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
		if (rewardBundle_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RewardBundle);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(QuickBattleResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.rewardBundle_ != null)
		{
			if (rewardBundle_ == null)
			{
				RewardBundle = new RewardDBInfoBundle();
			}
			RewardBundle.MergeFrom(other.RewardBundle);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (rewardBundle_ == null)
			{
				RewardBundle = new RewardDBInfoBundle();
			}
			input.ReadMessage(RewardBundle);
		}
	}
}
