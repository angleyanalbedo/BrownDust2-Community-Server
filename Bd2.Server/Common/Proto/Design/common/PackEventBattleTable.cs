using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class PackEventBattleTable : IMessage<PackEventBattleTable>, IMessage, IEquatable<PackEventBattleTable>, IDeepCloneable<PackEventBattleTable>, IBufferMessage
{
	private static readonly MessageParser<PackEventBattleTable> _parser = new MessageParser<PackEventBattleTable>(() => new PackEventBattleTable());

	private UnknownFieldSet _unknownFields;

	public const int BattleDeckIdFieldNumber = 1;

	private int battleDeckId_;

	public const int BattlePowerFieldNumber = 2;

	private int battlePower_;

	public const int EventApCountFieldNumber = 3;

	private int eventApCount_;

	public const int GroupIdFieldNumber = 4;

	private int groupId_;

	public const int IdFieldNumber = 5;

	private int id_;

	public const int IsFixedCameraFieldNumber = 6;

	private int isFixedCamera_;

	public const int QuickBattlePossibleFieldNumber = 7;

	private int quickBattlePossible_;

	public const int RepeatRewardCountFieldNumber = 8;

	private static readonly FieldCodec<int> _repeated_repeatRewardCount_codec = FieldCodec.ForInt32(66u);

	private readonly RepeatedField<int> repeatRewardCount_ = new RepeatedField<int>();

	public const int RepeatRewardTypeFieldNumber = 9;

	private static readonly FieldCodec<int> _repeated_repeatRewardType_codec = FieldCodec.ForInt32(74u);

	private readonly RepeatedField<int> repeatRewardType_ = new RepeatedField<int>();

	public const int RepeatRewardidFieldNumber = 10;

	private static readonly FieldCodec<int> _repeated_repeatRewardid_codec = FieldCodec.ForInt32(82u);

	private readonly RepeatedField<int> repeatRewardid_ = new RepeatedField<int>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PackEventBattleTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => PackEventBattleTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BattleDeckId
	{
		get
		{
			return battleDeckId_;
		}
		set
		{
			battleDeckId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BattlePower
	{
		get
		{
			return battlePower_;
		}
		set
		{
			battlePower_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EventApCount
	{
		get
		{
			return eventApCount_;
		}
		set
		{
			eventApCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int IsFixedCamera
	{
		get
		{
			return isFixedCamera_;
		}
		set
		{
			isFixedCamera_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int QuickBattlePossible
	{
		get
		{
			return quickBattlePossible_;
		}
		set
		{
			quickBattlePossible_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> RepeatRewardCount => repeatRewardCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> RepeatRewardType => repeatRewardType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> RepeatRewardid => repeatRewardid_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PackEventBattleTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PackEventBattleTable(PackEventBattleTable other)
		: this()
	{
		battleDeckId_ = other.battleDeckId_;
		battlePower_ = other.battlePower_;
		eventApCount_ = other.eventApCount_;
		groupId_ = other.groupId_;
		id_ = other.id_;
		isFixedCamera_ = other.isFixedCamera_;
		quickBattlePossible_ = other.quickBattlePossible_;
		repeatRewardCount_ = other.repeatRewardCount_.Clone();
		repeatRewardType_ = other.repeatRewardType_.Clone();
		repeatRewardid_ = other.repeatRewardid_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackEventBattleTable Clone()
	{
		return new PackEventBattleTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as PackEventBattleTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PackEventBattleTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (BattleDeckId == other.BattleDeckId && BattlePower == other.BattlePower && EventApCount == other.EventApCount && GroupId == other.GroupId && Id == other.Id && IsFixedCamera == other.IsFixedCamera && QuickBattlePossible == other.QuickBattlePossible && repeatRewardCount_.Equals(other.repeatRewardCount_) && repeatRewardType_.Equals(other.repeatRewardType_) && repeatRewardid_.Equals(other.repeatRewardid_))
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
		if (BattleDeckId != 0)
		{
			num ^= BattleDeckId.GetHashCode();
		}
		if (BattlePower != 0)
		{
			num ^= BattlePower.GetHashCode();
		}
		if (EventApCount != 0)
		{
			num ^= EventApCount.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (IsFixedCamera != 0)
		{
			num ^= IsFixedCamera.GetHashCode();
		}
		if (QuickBattlePossible != 0)
		{
			num ^= QuickBattlePossible.GetHashCode();
		}
		num ^= repeatRewardCount_.GetHashCode();
		num ^= repeatRewardType_.GetHashCode();
		num ^= repeatRewardid_.GetHashCode();
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
		if (BattleDeckId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BattleDeckId);
		}
		if (BattlePower != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BattlePower);
		}
		if (EventApCount != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(EventApCount);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(GroupId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Id);
		}
		if (IsFixedCamera != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(IsFixedCamera);
		}
		if (QuickBattlePossible != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(QuickBattlePossible);
		}
		repeatRewardCount_.WriteTo(ref output, _repeated_repeatRewardCount_codec);
		repeatRewardType_.WriteTo(ref output, _repeated_repeatRewardType_codec);
		repeatRewardid_.WriteTo(ref output, _repeated_repeatRewardid_codec);
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
		if (BattleDeckId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleDeckId);
		}
		if (BattlePower != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattlePower);
		}
		if (EventApCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventApCount);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (IsFixedCamera != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IsFixedCamera);
		}
		if (QuickBattlePossible != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(QuickBattlePossible);
		}
		num += repeatRewardCount_.CalculateSize(_repeated_repeatRewardCount_codec);
		num += repeatRewardType_.CalculateSize(_repeated_repeatRewardType_codec);
		num += repeatRewardid_.CalculateSize(_repeated_repeatRewardid_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PackEventBattleTable other)
	{
		if (other != null)
		{
			if (other.BattleDeckId != 0)
			{
				BattleDeckId = other.BattleDeckId;
			}
			if (other.BattlePower != 0)
			{
				BattlePower = other.BattlePower;
			}
			if (other.EventApCount != 0)
			{
				EventApCount = other.EventApCount;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.IsFixedCamera != 0)
			{
				IsFixedCamera = other.IsFixedCamera;
			}
			if (other.QuickBattlePossible != 0)
			{
				QuickBattlePossible = other.QuickBattlePossible;
			}
			repeatRewardCount_.Add(other.repeatRewardCount_);
			repeatRewardType_.Add(other.repeatRewardType_);
			repeatRewardid_.Add(other.repeatRewardid_);
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
				BattleDeckId = input.ReadInt32();
				break;
			case 16u:
				BattlePower = input.ReadInt32();
				break;
			case 24u:
				EventApCount = input.ReadInt32();
				break;
			case 32u:
				GroupId = input.ReadInt32();
				break;
			case 40u:
				Id = input.ReadInt32();
				break;
			case 48u:
				IsFixedCamera = input.ReadInt32();
				break;
			case 56u:
				QuickBattlePossible = input.ReadInt32();
				break;
			case 64u:
			case 66u:
				repeatRewardCount_.AddEntriesFrom(ref input, _repeated_repeatRewardCount_codec);
				break;
			case 72u:
			case 74u:
				repeatRewardType_.AddEntriesFrom(ref input, _repeated_repeatRewardType_codec);
				break;
			case 80u:
			case 82u:
				repeatRewardid_.AddEntriesFrom(ref input, _repeated_repeatRewardid_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
