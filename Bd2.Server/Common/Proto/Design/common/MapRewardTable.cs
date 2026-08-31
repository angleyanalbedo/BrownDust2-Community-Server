using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class MapRewardTable : IMessage<MapRewardTable>, IMessage, IEquatable<MapRewardTable>, IDeepCloneable<MapRewardTable>, IBufferMessage
{
	private static readonly MessageParser<MapRewardTable> _parser = new MessageParser<MapRewardTable>(() => new MapRewardTable());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int InsideMapIdFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_insideMapId_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> insideMapId_ = new RepeatedField<int>();

	public const int MapIdFieldNumber = 3;

	private int mapId_;

	public const int PackIdFieldNumber = 4;

	private int packId_;

	public const int RewardAcquireTypeFieldNumber = 5;

	private static readonly FieldCodec<int> _repeated_rewardAcquireType_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> rewardAcquireType_ = new RepeatedField<int>();

	public const int RewardIdFieldNumber = 6;

	private int rewardId_;

	public const int RewardInfoCountFieldNumber = 7;

	private int rewardInfoCount_;

	public const int RewardInfoTypeFieldNumber = 8;

	private int rewardInfoType_;

	public const int RewardTypeFieldNumber = 9;

	private int rewardType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MapRewardTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MapRewardTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> InsideMapId => insideMapId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MapId
	{
		get
		{
			return mapId_;
		}
		set
		{
			mapId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PackId
	{
		get
		{
			return packId_;
		}
		set
		{
			packId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> RewardAcquireType => rewardAcquireType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RewardId
	{
		get
		{
			return rewardId_;
		}
		set
		{
			rewardId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RewardInfoCount
	{
		get
		{
			return rewardInfoCount_;
		}
		set
		{
			rewardInfoCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RewardInfoType
	{
		get
		{
			return rewardInfoType_;
		}
		set
		{
			rewardInfoType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RewardType
	{
		get
		{
			return rewardType_;
		}
		set
		{
			rewardType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapRewardTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapRewardTable(MapRewardTable other)
		: this()
	{
		id_ = other.id_;
		insideMapId_ = other.insideMapId_.Clone();
		mapId_ = other.mapId_;
		packId_ = other.packId_;
		rewardAcquireType_ = other.rewardAcquireType_.Clone();
		rewardId_ = other.rewardId_;
		rewardInfoCount_ = other.rewardInfoCount_;
		rewardInfoType_ = other.rewardInfoType_;
		rewardType_ = other.rewardType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MapRewardTable Clone()
	{
		return new MapRewardTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MapRewardTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MapRewardTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && insideMapId_.Equals(other.insideMapId_) && MapId == other.MapId && PackId == other.PackId && rewardAcquireType_.Equals(other.rewardAcquireType_) && RewardId == other.RewardId && RewardInfoCount == other.RewardInfoCount && RewardInfoType == other.RewardInfoType && RewardType == other.RewardType)
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
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		num ^= insideMapId_.GetHashCode();
		if (MapId != 0)
		{
			num ^= MapId.GetHashCode();
		}
		if (PackId != 0)
		{
			num ^= PackId.GetHashCode();
		}
		num ^= rewardAcquireType_.GetHashCode();
		if (RewardId != 0)
		{
			num ^= RewardId.GetHashCode();
		}
		if (RewardInfoCount != 0)
		{
			num ^= RewardInfoCount.GetHashCode();
		}
		if (RewardInfoType != 0)
		{
			num ^= RewardInfoType.GetHashCode();
		}
		if (RewardType != 0)
		{
			num ^= RewardType.GetHashCode();
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		insideMapId_.WriteTo(ref output, _repeated_insideMapId_codec);
		if (MapId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(MapId);
		}
		if (PackId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(PackId);
		}
		rewardAcquireType_.WriteTo(ref output, _repeated_rewardAcquireType_codec);
		if (RewardId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(RewardId);
		}
		if (RewardInfoCount != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(RewardInfoCount);
		}
		if (RewardInfoType != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(RewardInfoType);
		}
		if (RewardType != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(RewardType);
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
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		num += insideMapId_.CalculateSize(_repeated_insideMapId_codec);
		if (MapId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MapId);
		}
		if (PackId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PackId);
		}
		num += rewardAcquireType_.CalculateSize(_repeated_rewardAcquireType_codec);
		if (RewardId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RewardId);
		}
		if (RewardInfoCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RewardInfoCount);
		}
		if (RewardInfoType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RewardInfoType);
		}
		if (RewardType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RewardType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(MapRewardTable other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			insideMapId_.Add(other.insideMapId_);
			if (other.MapId != 0)
			{
				MapId = other.MapId;
			}
			if (other.PackId != 0)
			{
				PackId = other.PackId;
			}
			rewardAcquireType_.Add(other.rewardAcquireType_);
			if (other.RewardId != 0)
			{
				RewardId = other.RewardId;
			}
			if (other.RewardInfoCount != 0)
			{
				RewardInfoCount = other.RewardInfoCount;
			}
			if (other.RewardInfoType != 0)
			{
				RewardInfoType = other.RewardInfoType;
			}
			if (other.RewardType != 0)
			{
				RewardType = other.RewardType;
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
				Id = input.ReadInt32();
				break;
			case 24u:
				MapId = input.ReadInt32();
				break;
			case 32u:
				PackId = input.ReadInt32();
				break;
			case 16u:
			case 18u:
				insideMapId_.AddEntriesFrom(ref input, _repeated_insideMapId_codec);
				break;
			case 40u:
			case 42u:
				rewardAcquireType_.AddEntriesFrom(ref input, _repeated_rewardAcquireType_codec);
				break;
			case 48u:
				RewardId = input.ReadInt32();
				break;
			case 56u:
				RewardInfoCount = input.ReadInt32();
				break;
			case 64u:
				RewardInfoType = input.ReadInt32();
				break;
			case 72u:
				RewardType = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
