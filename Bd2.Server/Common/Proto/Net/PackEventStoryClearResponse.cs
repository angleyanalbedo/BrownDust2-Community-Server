using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PackEventStoryClearResponse : IMessage<PackEventStoryClearResponse>, IMessage, IEquatable<PackEventStoryClearResponse>, IDeepCloneable<PackEventStoryClearResponse>, IBufferMessage
{
	private static readonly MessageParser<PackEventStoryClearResponse> _parser = new MessageParser<PackEventStoryClearResponse>(() => new PackEventStoryClearResponse());

	private UnknownFieldSet _unknownFields;

	public const int RewardInfoBundleFieldNumber = 1;

	private RewardDBInfoBundle rewardInfoBundle_;

	public const int ClearInfoFieldNumber = 2;

	private PackEventStoryDBInfo clearInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PackEventStoryClearResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PackEventStoryClearResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackEventStoryDBInfo ClearInfo
	{
		get
		{
			return clearInfo_;
		}
		set
		{
			clearInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackEventStoryClearResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PackEventStoryClearResponse(PackEventStoryClearResponse other)
		: this()
	{
		rewardInfoBundle_ = ((other.rewardInfoBundle_ != null) ? other.rewardInfoBundle_.Clone() : null);
		clearInfo_ = ((other.clearInfo_ != null) ? other.clearInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PackEventStoryClearResponse Clone()
	{
		return new PackEventStoryClearResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PackEventStoryClearResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PackEventStoryClearResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(RewardInfoBundle, other.RewardInfoBundle) && object.Equals(ClearInfo, other.ClearInfo))
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
		if (rewardInfoBundle_ != null)
		{
			num ^= RewardInfoBundle.GetHashCode();
		}
		if (clearInfo_ != null)
		{
			num ^= ClearInfo.GetHashCode();
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (rewardInfoBundle_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(RewardInfoBundle);
		}
		if (clearInfo_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(ClearInfo);
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
		if (rewardInfoBundle_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RewardInfoBundle);
		}
		if (clearInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ClearInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PackEventStoryClearResponse other)
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
		if (other.clearInfo_ != null)
		{
			if (clearInfo_ == null)
			{
				ClearInfo = new PackEventStoryDBInfo();
			}
			ClearInfo.MergeFrom(other.ClearInfo);
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 18u:
				if (clearInfo_ == null)
				{
					ClearInfo = new PackEventStoryDBInfo();
				}
				input.ReadMessage(ClearInfo);
				break;
			case 10u:
				if (rewardInfoBundle_ == null)
				{
					RewardInfoBundle = new RewardDBInfoBundle();
				}
				input.ReadMessage(RewardInfoBundle);
				break;
			}
		}
	}
}
