using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class EventDropTable : IMessage<EventDropTable>, IMessage, IEquatable<EventDropTable>, IDeepCloneable<EventDropTable>, IBufferMessage
{
	private static readonly MessageParser<EventDropTable> _parser = new MessageParser<EventDropTable>(() => new EventDropTable());

	private UnknownFieldSet _unknownFields;

	public const int EventNameLocalTextIdFieldNumber = 1;

	private int eventNameLocalTextId_;

	public const int IdFieldNumber = 2;

	private int id_;

	public const int PackIdFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_packId_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> packId_ = new RepeatedField<int>();

	public const int RatioFieldNumber = 4;

	private int ratio_;

	public const int RewardItemCountFieldNumber = 5;

	private int rewardItemCount_;

	public const int RewardItemIdFieldNumber = 6;

	private int rewardItemId_;

	public const int RewardItemTypeFieldNumber = 7;

	private int rewardItemType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EventDropTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => EventDropTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EventNameLocalTextId
	{
		get
		{
			return eventNameLocalTextId_;
		}
		set
		{
			eventNameLocalTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public RepeatedField<int> PackId => packId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Ratio
	{
		get
		{
			return ratio_;
		}
		set
		{
			ratio_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RewardItemCount
	{
		get
		{
			return rewardItemCount_;
		}
		set
		{
			rewardItemCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RewardItemId
	{
		get
		{
			return rewardItemId_;
		}
		set
		{
			rewardItemId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RewardItemType
	{
		get
		{
			return rewardItemType_;
		}
		set
		{
			rewardItemType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventDropTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventDropTable(EventDropTable other)
		: this()
	{
		eventNameLocalTextId_ = other.eventNameLocalTextId_;
		id_ = other.id_;
		packId_ = other.packId_.Clone();
		ratio_ = other.ratio_;
		rewardItemCount_ = other.rewardItemCount_;
		rewardItemId_ = other.rewardItemId_;
		rewardItemType_ = other.rewardItemType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventDropTable Clone()
	{
		return new EventDropTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EventDropTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EventDropTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (EventNameLocalTextId == other.EventNameLocalTextId && Id == other.Id && packId_.Equals(other.packId_) && Ratio == other.Ratio && RewardItemCount == other.RewardItemCount && RewardItemId == other.RewardItemId && RewardItemType == other.RewardItemType)
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
		if (EventNameLocalTextId != 0)
		{
			num ^= EventNameLocalTextId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		num ^= packId_.GetHashCode();
		if (Ratio != 0)
		{
			num ^= Ratio.GetHashCode();
		}
		if (RewardItemCount != 0)
		{
			num ^= RewardItemCount.GetHashCode();
		}
		if (RewardItemId != 0)
		{
			num ^= RewardItemId.GetHashCode();
		}
		if (RewardItemType != 0)
		{
			num ^= RewardItemType.GetHashCode();
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (EventNameLocalTextId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(EventNameLocalTextId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Id);
		}
		packId_.WriteTo(ref output, _repeated_packId_codec);
		if (Ratio != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Ratio);
		}
		if (RewardItemCount != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(RewardItemCount);
		}
		if (RewardItemId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(RewardItemId);
		}
		if (RewardItemType != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(RewardItemType);
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
		if (EventNameLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventNameLocalTextId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		num += packId_.CalculateSize(_repeated_packId_codec);
		if (Ratio != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Ratio);
		}
		if (RewardItemCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RewardItemCount);
		}
		if (RewardItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RewardItemId);
		}
		if (RewardItemType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RewardItemType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EventDropTable other)
	{
		if (other != null)
		{
			if (other.EventNameLocalTextId != 0)
			{
				EventNameLocalTextId = other.EventNameLocalTextId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			packId_.Add(other.packId_);
			if (other.Ratio != 0)
			{
				Ratio = other.Ratio;
			}
			if (other.RewardItemCount != 0)
			{
				RewardItemCount = other.RewardItemCount;
			}
			if (other.RewardItemId != 0)
			{
				RewardItemId = other.RewardItemId;
			}
			if (other.RewardItemType != 0)
			{
				RewardItemType = other.RewardItemType;
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
			switch (num)
			{
			case 8u:
				EventNameLocalTextId = input.ReadInt32();
				break;
			case 16u:
				Id = input.ReadInt32();
				break;
			case 24u:
			case 26u:
				packId_.AddEntriesFrom(ref input, _repeated_packId_codec);
				break;
			case 32u:
				Ratio = input.ReadInt32();
				break;
			case 40u:
				RewardItemCount = input.ReadInt32();
				break;
			case 48u:
				RewardItemId = input.ReadInt32();
				break;
			case 56u:
				RewardItemType = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
