using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MiniGameDBInfo : IMessage<MiniGameDBInfo>, IMessage, IEquatable<MiniGameDBInfo>, IDeepCloneable<MiniGameDBInfo>, IBufferMessage
{
	private static readonly MessageParser<MiniGameDBInfo> _parser = new MessageParser<MiniGameDBInfo>(() => new MiniGameDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int EventScheduleIdFieldNumber = 1;

	private int eventScheduleId_;

	public const int LastRewardPointFieldNumber = 2;

	private int lastRewardPoint_;

	public const int BestRecordValueFieldNumber = 3;

	private int bestRecordValue_;

	public const int IsPossibleQuickRewardFieldNumber = 4;

	private bool isPossibleQuickReward_;

	public const int WorldBestRecordOwnerIndexFieldNumber = 5;

	private long worldBestRecordOwnerIndex_;

	public const int WorldBestRecordUserIdFieldNumber = 6;

	private string worldBestRecordUserId_ = "";

	public const int WorldBestRecordValueFieldNumber = 7;

	private int worldBestRecordValue_;

	public const int WorldBestRecordPlayInfoFieldNumber = 8;

	private string worldBestRecordPlayInfo_ = "";

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MiniGameDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MiniGameDBInfoReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EventScheduleId
	{
		get
		{
			return eventScheduleId_;
		}
		set
		{
			eventScheduleId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int LastRewardPoint
	{
		get
		{
			return lastRewardPoint_;
		}
		set
		{
			lastRewardPoint_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BestRecordValue
	{
		get
		{
			return bestRecordValue_;
		}
		set
		{
			bestRecordValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsPossibleQuickReward
	{
		get
		{
			return isPossibleQuickReward_;
		}
		set
		{
			isPossibleQuickReward_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long WorldBestRecordOwnerIndex
	{
		get
		{
			return worldBestRecordOwnerIndex_;
		}
		set
		{
			worldBestRecordOwnerIndex_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string WorldBestRecordUserId
	{
		get
		{
			return worldBestRecordUserId_;
		}
		set
		{
			worldBestRecordUserId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int WorldBestRecordValue
	{
		get
		{
			return worldBestRecordValue_;
		}
		set
		{
			worldBestRecordValue_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string WorldBestRecordPlayInfo
	{
		get
		{
			return worldBestRecordPlayInfo_;
		}
		set
		{
			worldBestRecordPlayInfo_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MiniGameDBInfo()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MiniGameDBInfo(MiniGameDBInfo other)
		: this()
	{
		eventScheduleId_ = other.eventScheduleId_;
		lastRewardPoint_ = other.lastRewardPoint_;
		bestRecordValue_ = other.bestRecordValue_;
		isPossibleQuickReward_ = other.isPossibleQuickReward_;
		worldBestRecordOwnerIndex_ = other.worldBestRecordOwnerIndex_;
		worldBestRecordUserId_ = other.worldBestRecordUserId_;
		worldBestRecordValue_ = other.worldBestRecordValue_;
		worldBestRecordPlayInfo_ = other.worldBestRecordPlayInfo_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MiniGameDBInfo Clone()
	{
		return new MiniGameDBInfo(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as MiniGameDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MiniGameDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (EventScheduleId == other.EventScheduleId && LastRewardPoint == other.LastRewardPoint && BestRecordValue == other.BestRecordValue && IsPossibleQuickReward == other.IsPossibleQuickReward && WorldBestRecordOwnerIndex == other.WorldBestRecordOwnerIndex && !(WorldBestRecordUserId != other.WorldBestRecordUserId) && WorldBestRecordValue == other.WorldBestRecordValue && !(WorldBestRecordPlayInfo != other.WorldBestRecordPlayInfo))
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
		if (EventScheduleId != 0)
		{
			num ^= EventScheduleId.GetHashCode();
		}
		if (LastRewardPoint != 0)
		{
			num ^= LastRewardPoint.GetHashCode();
		}
		if (BestRecordValue != 0)
		{
			num ^= BestRecordValue.GetHashCode();
		}
		if (IsPossibleQuickReward)
		{
			num ^= IsPossibleQuickReward.GetHashCode();
		}
		if (WorldBestRecordOwnerIndex != 0L)
		{
			num ^= WorldBestRecordOwnerIndex.GetHashCode();
		}
		if (WorldBestRecordUserId.Length != 0)
		{
			num ^= WorldBestRecordUserId.GetHashCode();
		}
		if (WorldBestRecordValue != 0)
		{
			num ^= WorldBestRecordValue.GetHashCode();
		}
		if (WorldBestRecordPlayInfo.Length != 0)
		{
			num ^= WorldBestRecordPlayInfo.GetHashCode();
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
		if (EventScheduleId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(EventScheduleId);
		}
		if (LastRewardPoint != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(LastRewardPoint);
		}
		if (BestRecordValue != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(BestRecordValue);
		}
		if (IsPossibleQuickReward)
		{
			output.WriteRawTag(32);
			output.WriteBool(IsPossibleQuickReward);
		}
		if (WorldBestRecordOwnerIndex != 0L)
		{
			output.WriteRawTag(40);
			output.WriteInt64(WorldBestRecordOwnerIndex);
		}
		if (WorldBestRecordUserId.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(WorldBestRecordUserId);
		}
		if (WorldBestRecordValue != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(WorldBestRecordValue);
		}
		if (WorldBestRecordPlayInfo.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(WorldBestRecordPlayInfo);
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
		if (EventScheduleId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventScheduleId);
		}
		if (LastRewardPoint != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LastRewardPoint);
		}
		if (BestRecordValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BestRecordValue);
		}
		if (IsPossibleQuickReward)
		{
			num += 2;
		}
		if (WorldBestRecordOwnerIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(WorldBestRecordOwnerIndex);
		}
		if (WorldBestRecordUserId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(WorldBestRecordUserId);
		}
		if (WorldBestRecordValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(WorldBestRecordValue);
		}
		if (WorldBestRecordPlayInfo.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(WorldBestRecordPlayInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(MiniGameDBInfo other)
	{
		if (other != null)
		{
			if (other.EventScheduleId != 0)
			{
				EventScheduleId = other.EventScheduleId;
			}
			if (other.LastRewardPoint != 0)
			{
				LastRewardPoint = other.LastRewardPoint;
			}
			if (other.BestRecordValue != 0)
			{
				BestRecordValue = other.BestRecordValue;
			}
			if (other.IsPossibleQuickReward)
			{
				IsPossibleQuickReward = other.IsPossibleQuickReward;
			}
			if (other.WorldBestRecordOwnerIndex != 0L)
			{
				WorldBestRecordOwnerIndex = other.WorldBestRecordOwnerIndex;
			}
			if (other.WorldBestRecordUserId.Length != 0)
			{
				WorldBestRecordUserId = other.WorldBestRecordUserId;
			}
			if (other.WorldBestRecordValue != 0)
			{
				WorldBestRecordValue = other.WorldBestRecordValue;
			}
			if (other.WorldBestRecordPlayInfo.Length != 0)
			{
				WorldBestRecordPlayInfo = other.WorldBestRecordPlayInfo;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
			case 8u:
				EventScheduleId = input.ReadInt32();
				break;
			case 16u:
				LastRewardPoint = input.ReadInt32();
				break;
			case 24u:
				BestRecordValue = input.ReadInt32();
				break;
			case 32u:
				IsPossibleQuickReward = input.ReadBool();
				break;
			case 40u:
				WorldBestRecordOwnerIndex = input.ReadInt64();
				break;
			case 50u:
				WorldBestRecordUserId = input.ReadString();
				break;
			case 56u:
				WorldBestRecordValue = input.ReadInt32();
				break;
			case 66u:
				WorldBestRecordPlayInfo = input.ReadString();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
