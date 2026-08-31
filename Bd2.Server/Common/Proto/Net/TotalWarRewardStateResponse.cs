using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class TotalWarRewardStateResponse : IMessage<TotalWarRewardStateResponse>, IMessage, IEquatable<TotalWarRewardStateResponse>, IDeepCloneable<TotalWarRewardStateResponse>, IBufferMessage
{
	private static readonly MessageParser<TotalWarRewardStateResponse> _parser = new MessageParser<TotalWarRewardStateResponse>(() => new TotalWarRewardStateResponse());

	private UnknownFieldSet _unknownFields;

	public const int IsObtainableDailyRewardFieldNumber = 1;

	private bool isObtainableDailyReward_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TotalWarRewardStateResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TotalWarRewardStateResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsObtainableDailyReward
	{
		get
		{
			return isObtainableDailyReward_;
		}
		set
		{
			isObtainableDailyReward_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TotalWarRewardStateResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TotalWarRewardStateResponse(TotalWarRewardStateResponse other)
		: this()
	{
		isObtainableDailyReward_ = other.isObtainableDailyReward_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TotalWarRewardStateResponse Clone()
	{
		return new TotalWarRewardStateResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TotalWarRewardStateResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TotalWarRewardStateResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (IsObtainableDailyReward == other.IsObtainableDailyReward)
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
		if (IsObtainableDailyReward)
		{
			num ^= IsObtainableDailyReward.GetHashCode();
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
		if (IsObtainableDailyReward)
		{
			output.WriteRawTag(8);
			output.WriteBool(IsObtainableDailyReward);
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
		if (IsObtainableDailyReward)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TotalWarRewardStateResponse other)
	{
		if (other != null)
		{
			if (other.IsObtainableDailyReward)
			{
				IsObtainableDailyReward = other.IsObtainableDailyReward;
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				IsObtainableDailyReward = input.ReadBool();
			}
		}
	}
}
