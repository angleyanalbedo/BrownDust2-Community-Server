using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class BattleGolemDBInfo : IMessage<BattleGolemDBInfo>, IMessage, IEquatable<BattleGolemDBInfo>, IDeepCloneable<BattleGolemDBInfo>, IBufferMessage
{
	private static readonly MessageParser<BattleGolemDBInfo> _parser = new MessageParser<BattleGolemDBInfo>(() => new BattleGolemDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int LevelFieldNumber = 1;

	private int level_;

	public const int GaugeFieldNumber = 2;

	private double gauge_;

	public const int RemainTurnFieldNumber = 3;

	private int remainTurn_;

	public const int ReserveCostumeIdFieldNumber = 4;

	private int reserveCostumeId_;

	public const int SkillTurnDicFieldNumber = 5;

	private static readonly MapField<int, int>.Codec _map_skillTurnDic_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8u, 0), FieldCodec.ForInt32(16u, 0), 42u);

	private readonly MapField<int, int> skillTurnDic_ = new MapField<int, int>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BattleGolemDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BattleGolemDBInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double Gauge
	{
		get
		{
			return gauge_;
		}
		set
		{
			gauge_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RemainTurn
	{
		get
		{
			return remainTurn_;
		}
		set
		{
			remainTurn_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ReserveCostumeId
	{
		get
		{
			return reserveCostumeId_;
		}
		set
		{
			reserveCostumeId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<int, int> SkillTurnDic => skillTurnDic_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BattleGolemDBInfo()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BattleGolemDBInfo(BattleGolemDBInfo other)
		: this()
	{
		level_ = other.level_;
		gauge_ = other.gauge_;
		remainTurn_ = other.remainTurn_;
		reserveCostumeId_ = other.reserveCostumeId_;
		skillTurnDic_ = other.skillTurnDic_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleGolemDBInfo Clone()
	{
		return new BattleGolemDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BattleGolemDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BattleGolemDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Level == other.Level && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Gauge, other.Gauge) && RemainTurn == other.RemainTurn && ReserveCostumeId == other.ReserveCostumeId && SkillTurnDic.Equals(other.SkillTurnDic))
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
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (Gauge != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Gauge);
		}
		if (RemainTurn != 0)
		{
			num ^= RemainTurn.GetHashCode();
		}
		if (ReserveCostumeId != 0)
		{
			num ^= ReserveCostumeId.GetHashCode();
		}
		num ^= SkillTurnDic.GetHashCode();
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
		if (Level != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Level);
		}
		if (Gauge != 0.0)
		{
			output.WriteRawTag(17);
			output.WriteDouble(Gauge);
		}
		if (RemainTurn != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(RemainTurn);
		}
		if (ReserveCostumeId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ReserveCostumeId);
		}
		skillTurnDic_.WriteTo(ref output, _map_skillTurnDic_codec);
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
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Level);
		}
		if (Gauge != 0.0)
		{
			num += 9;
		}
		if (RemainTurn != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RemainTurn);
		}
		if (ReserveCostumeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ReserveCostumeId);
		}
		num += skillTurnDic_.CalculateSize(_map_skillTurnDic_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BattleGolemDBInfo other)
	{
		if (other != null)
		{
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.Gauge != 0.0)
			{
				Gauge = other.Gauge;
			}
			if (other.RemainTurn != 0)
			{
				RemainTurn = other.RemainTurn;
			}
			if (other.ReserveCostumeId != 0)
			{
				ReserveCostumeId = other.ReserveCostumeId;
			}
			skillTurnDic_.Add(other.skillTurnDic_);
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
				Level = input.ReadInt32();
				break;
			case 17u:
				Gauge = input.ReadDouble();
				break;
			case 24u:
				RemainTurn = input.ReadInt32();
				break;
			case 32u:
				ReserveCostumeId = input.ReadInt32();
				break;
			case 42u:
				skillTurnDic_.AddEntriesFrom(ref input, _map_skillTurnDic_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
