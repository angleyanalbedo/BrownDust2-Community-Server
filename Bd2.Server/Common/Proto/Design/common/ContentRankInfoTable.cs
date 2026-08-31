using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class ContentRankInfoTable : IMessage<ContentRankInfoTable>, IMessage, IEquatable<ContentRankInfoTable>, IDeepCloneable<ContentRankInfoTable>, IBufferMessage
{
	private static readonly MessageParser<ContentRankInfoTable> _parser = new MessageParser<ContentRankInfoTable>(() => new ContentRankInfoTable());

	private UnknownFieldSet _unknownFields;

	public const int EvilCastleFloorMyRankMaxCountFieldNumber = 1;

	private int evilCastleFloorMyRankMaxCount_;

	public const int EvilCastleFloorTopRankMaxCountFieldNumber = 2;

	private int evilCastleFloorTopRankMaxCount_;

	public const int EvilCastleTotalMyRankMaxCountFieldNumber = 3;

	private int evilCastleTotalMyRankMaxCount_;

	public const int EvilCastleTotalTopRankMaxCountFieldNumber = 4;

	private int evilCastleTotalTopRankMaxCount_;

	public const int IdFieldNumber = 5;

	private int id_;

	public const int MirrorWarMyRankMaxCountFieldNumber = 6;

	private int mirrorWarMyRankMaxCount_;

	public const int MirrorWarTopRankMaxCountFieldNumber = 7;

	private int mirrorWarTopRankMaxCount_;

	public const int MonsterHuntMyRankMaxCountFieldNumber = 8;

	private int monsterHuntMyRankMaxCount_;

	public const int MonsterHuntTopRankMaxCountFieldNumber = 9;

	private int monsterHuntTopRankMaxCount_;

	public const int RoguelikeMyRankMaxCountFieldNumber = 10;

	private int roguelikeMyRankMaxCount_;

	public const int RoguelikeTopRankMaxCountFieldNumber = 11;

	private int roguelikeTopRankMaxCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ContentRankInfoTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ContentRankInfoTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int EvilCastleFloorMyRankMaxCount
	{
		get
		{
			return evilCastleFloorMyRankMaxCount_;
		}
		set
		{
			evilCastleFloorMyRankMaxCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EvilCastleFloorTopRankMaxCount
	{
		get
		{
			return evilCastleFloorTopRankMaxCount_;
		}
		set
		{
			evilCastleFloorTopRankMaxCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int EvilCastleTotalMyRankMaxCount
	{
		get
		{
			return evilCastleTotalMyRankMaxCount_;
		}
		set
		{
			evilCastleTotalMyRankMaxCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int EvilCastleTotalTopRankMaxCount
	{
		get
		{
			return evilCastleTotalTopRankMaxCount_;
		}
		set
		{
			evilCastleTotalTopRankMaxCount_ = value;
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
	public int MirrorWarMyRankMaxCount
	{
		get
		{
			return mirrorWarMyRankMaxCount_;
		}
		set
		{
			mirrorWarMyRankMaxCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MirrorWarTopRankMaxCount
	{
		get
		{
			return mirrorWarTopRankMaxCount_;
		}
		set
		{
			mirrorWarTopRankMaxCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MonsterHuntMyRankMaxCount
	{
		get
		{
			return monsterHuntMyRankMaxCount_;
		}
		set
		{
			monsterHuntMyRankMaxCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MonsterHuntTopRankMaxCount
	{
		get
		{
			return monsterHuntTopRankMaxCount_;
		}
		set
		{
			monsterHuntTopRankMaxCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RoguelikeMyRankMaxCount
	{
		get
		{
			return roguelikeMyRankMaxCount_;
		}
		set
		{
			roguelikeMyRankMaxCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RoguelikeTopRankMaxCount
	{
		get
		{
			return roguelikeTopRankMaxCount_;
		}
		set
		{
			roguelikeTopRankMaxCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContentRankInfoTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContentRankInfoTable(ContentRankInfoTable other)
		: this()
	{
		evilCastleFloorMyRankMaxCount_ = other.evilCastleFloorMyRankMaxCount_;
		evilCastleFloorTopRankMaxCount_ = other.evilCastleFloorTopRankMaxCount_;
		evilCastleTotalMyRankMaxCount_ = other.evilCastleTotalMyRankMaxCount_;
		evilCastleTotalTopRankMaxCount_ = other.evilCastleTotalTopRankMaxCount_;
		id_ = other.id_;
		mirrorWarMyRankMaxCount_ = other.mirrorWarMyRankMaxCount_;
		mirrorWarTopRankMaxCount_ = other.mirrorWarTopRankMaxCount_;
		monsterHuntMyRankMaxCount_ = other.monsterHuntMyRankMaxCount_;
		monsterHuntTopRankMaxCount_ = other.monsterHuntTopRankMaxCount_;
		roguelikeMyRankMaxCount_ = other.roguelikeMyRankMaxCount_;
		roguelikeTopRankMaxCount_ = other.roguelikeTopRankMaxCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContentRankInfoTable Clone()
	{
		return new ContentRankInfoTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ContentRankInfoTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ContentRankInfoTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (EvilCastleFloorMyRankMaxCount == other.EvilCastleFloorMyRankMaxCount && EvilCastleFloorTopRankMaxCount == other.EvilCastleFloorTopRankMaxCount && EvilCastleTotalMyRankMaxCount == other.EvilCastleTotalMyRankMaxCount && EvilCastleTotalTopRankMaxCount == other.EvilCastleTotalTopRankMaxCount && Id == other.Id && MirrorWarMyRankMaxCount == other.MirrorWarMyRankMaxCount && MirrorWarTopRankMaxCount == other.MirrorWarTopRankMaxCount && MonsterHuntMyRankMaxCount == other.MonsterHuntMyRankMaxCount && MonsterHuntTopRankMaxCount == other.MonsterHuntTopRankMaxCount && RoguelikeMyRankMaxCount == other.RoguelikeMyRankMaxCount && RoguelikeTopRankMaxCount == other.RoguelikeTopRankMaxCount)
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
		if (EvilCastleFloorMyRankMaxCount != 0)
		{
			num ^= EvilCastleFloorMyRankMaxCount.GetHashCode();
		}
		if (EvilCastleFloorTopRankMaxCount != 0)
		{
			num ^= EvilCastleFloorTopRankMaxCount.GetHashCode();
		}
		if (EvilCastleTotalMyRankMaxCount != 0)
		{
			num ^= EvilCastleTotalMyRankMaxCount.GetHashCode();
		}
		if (EvilCastleTotalTopRankMaxCount != 0)
		{
			num ^= EvilCastleTotalTopRankMaxCount.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (MirrorWarMyRankMaxCount != 0)
		{
			num ^= MirrorWarMyRankMaxCount.GetHashCode();
		}
		if (MirrorWarTopRankMaxCount != 0)
		{
			num ^= MirrorWarTopRankMaxCount.GetHashCode();
		}
		if (MonsterHuntMyRankMaxCount != 0)
		{
			num ^= MonsterHuntMyRankMaxCount.GetHashCode();
		}
		if (MonsterHuntTopRankMaxCount != 0)
		{
			num ^= MonsterHuntTopRankMaxCount.GetHashCode();
		}
		if (RoguelikeMyRankMaxCount != 0)
		{
			num ^= RoguelikeMyRankMaxCount.GetHashCode();
		}
		if (RoguelikeTopRankMaxCount != 0)
		{
			num ^= RoguelikeTopRankMaxCount.GetHashCode();
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
		if (EvilCastleFloorMyRankMaxCount != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(EvilCastleFloorMyRankMaxCount);
		}
		if (EvilCastleFloorTopRankMaxCount != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(EvilCastleFloorTopRankMaxCount);
		}
		if (EvilCastleTotalMyRankMaxCount != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(EvilCastleTotalMyRankMaxCount);
		}
		if (EvilCastleTotalTopRankMaxCount != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(EvilCastleTotalTopRankMaxCount);
		}
		if (Id != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Id);
		}
		if (MirrorWarMyRankMaxCount != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(MirrorWarMyRankMaxCount);
		}
		if (MirrorWarTopRankMaxCount != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(MirrorWarTopRankMaxCount);
		}
		if (MonsterHuntMyRankMaxCount != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(MonsterHuntMyRankMaxCount);
		}
		if (MonsterHuntTopRankMaxCount != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(MonsterHuntTopRankMaxCount);
		}
		if (RoguelikeMyRankMaxCount != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(RoguelikeMyRankMaxCount);
		}
		if (RoguelikeTopRankMaxCount != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(RoguelikeTopRankMaxCount);
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
		if (EvilCastleFloorMyRankMaxCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EvilCastleFloorMyRankMaxCount);
		}
		if (EvilCastleFloorTopRankMaxCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EvilCastleFloorTopRankMaxCount);
		}
		if (EvilCastleTotalMyRankMaxCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EvilCastleTotalMyRankMaxCount);
		}
		if (EvilCastleTotalTopRankMaxCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EvilCastleTotalTopRankMaxCount);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (MirrorWarMyRankMaxCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MirrorWarMyRankMaxCount);
		}
		if (MirrorWarTopRankMaxCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MirrorWarTopRankMaxCount);
		}
		if (MonsterHuntMyRankMaxCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MonsterHuntMyRankMaxCount);
		}
		if (MonsterHuntTopRankMaxCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MonsterHuntTopRankMaxCount);
		}
		if (RoguelikeMyRankMaxCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RoguelikeMyRankMaxCount);
		}
		if (RoguelikeTopRankMaxCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RoguelikeTopRankMaxCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ContentRankInfoTable other)
	{
		if (other != null)
		{
			if (other.EvilCastleFloorMyRankMaxCount != 0)
			{
				EvilCastleFloorMyRankMaxCount = other.EvilCastleFloorMyRankMaxCount;
			}
			if (other.EvilCastleFloorTopRankMaxCount != 0)
			{
				EvilCastleFloorTopRankMaxCount = other.EvilCastleFloorTopRankMaxCount;
			}
			if (other.EvilCastleTotalMyRankMaxCount != 0)
			{
				EvilCastleTotalMyRankMaxCount = other.EvilCastleTotalMyRankMaxCount;
			}
			if (other.EvilCastleTotalTopRankMaxCount != 0)
			{
				EvilCastleTotalTopRankMaxCount = other.EvilCastleTotalTopRankMaxCount;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.MirrorWarMyRankMaxCount != 0)
			{
				MirrorWarMyRankMaxCount = other.MirrorWarMyRankMaxCount;
			}
			if (other.MirrorWarTopRankMaxCount != 0)
			{
				MirrorWarTopRankMaxCount = other.MirrorWarTopRankMaxCount;
			}
			if (other.MonsterHuntMyRankMaxCount != 0)
			{
				MonsterHuntMyRankMaxCount = other.MonsterHuntMyRankMaxCount;
			}
			if (other.MonsterHuntTopRankMaxCount != 0)
			{
				MonsterHuntTopRankMaxCount = other.MonsterHuntTopRankMaxCount;
			}
			if (other.RoguelikeMyRankMaxCount != 0)
			{
				RoguelikeMyRankMaxCount = other.RoguelikeMyRankMaxCount;
			}
			if (other.RoguelikeTopRankMaxCount != 0)
			{
				RoguelikeTopRankMaxCount = other.RoguelikeTopRankMaxCount;
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
				EvilCastleFloorMyRankMaxCount = input.ReadInt32();
				break;
			case 16u:
				EvilCastleFloorTopRankMaxCount = input.ReadInt32();
				break;
			case 24u:
				EvilCastleTotalMyRankMaxCount = input.ReadInt32();
				break;
			case 32u:
				EvilCastleTotalTopRankMaxCount = input.ReadInt32();
				break;
			case 40u:
				Id = input.ReadInt32();
				break;
			case 48u:
				MirrorWarMyRankMaxCount = input.ReadInt32();
				break;
			case 56u:
				MirrorWarTopRankMaxCount = input.ReadInt32();
				break;
			case 64u:
				MonsterHuntMyRankMaxCount = input.ReadInt32();
				break;
			case 72u:
				MonsterHuntTopRankMaxCount = input.ReadInt32();
				break;
			case 80u:
				RoguelikeMyRankMaxCount = input.ReadInt32();
				break;
			case 88u:
				RoguelikeTopRankMaxCount = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
