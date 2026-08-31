using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class MonsterHuntRankTable : IMessage<MonsterHuntRankTable>, IMessage, IEquatable<MonsterHuntRankTable>, IDeepCloneable<MonsterHuntRankTable>, IBufferMessage
{
	private static readonly MessageParser<MonsterHuntRankTable> _parser = new MessageParser<MonsterHuntRankTable>(() => new MonsterHuntRankTable());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int RankNameTextIdFieldNumber = 2;

	private string rankNameTextId_ = "";

	public const int RankingFieldNumber = 3;

	private int ranking_;

	public const int SeasonRewardCountFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_seasonRewardCount_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> seasonRewardCount_ = new RepeatedField<int>();

	public const int SeasonRewardIdFieldNumber = 5;

	private static readonly FieldCodec<int> _repeated_seasonRewardId_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> seasonRewardId_ = new RepeatedField<int>();

	public const int SeasonRewardTypeFieldNumber = 6;

	private static readonly FieldCodec<int> _repeated_seasonRewardType_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> seasonRewardType_ = new RepeatedField<int>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MonsterHuntRankTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MonsterHuntRankTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string RankNameTextId
	{
		get
		{
			return rankNameTextId_;
		}
		set
		{
			rankNameTextId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Ranking
	{
		get
		{
			return ranking_;
		}
		set
		{
			ranking_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> SeasonRewardCount => seasonRewardCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> SeasonRewardId => seasonRewardId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> SeasonRewardType => seasonRewardType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterHuntRankTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterHuntRankTable(MonsterHuntRankTable other)
		: this()
	{
		id_ = other.id_;
		rankNameTextId_ = other.rankNameTextId_;
		ranking_ = other.ranking_;
		seasonRewardCount_ = other.seasonRewardCount_.Clone();
		seasonRewardId_ = other.seasonRewardId_.Clone();
		seasonRewardType_ = other.seasonRewardType_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MonsterHuntRankTable Clone()
	{
		return new MonsterHuntRankTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as MonsterHuntRankTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonsterHuntRankTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && !(RankNameTextId != other.RankNameTextId) && Ranking == other.Ranking && seasonRewardCount_.Equals(other.seasonRewardCount_) && seasonRewardId_.Equals(other.seasonRewardId_) && seasonRewardType_.Equals(other.seasonRewardType_))
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
		if (RankNameTextId.Length != 0)
		{
			num ^= RankNameTextId.GetHashCode();
		}
		if (Ranking != 0)
		{
			num ^= Ranking.GetHashCode();
		}
		num ^= seasonRewardCount_.GetHashCode();
		num ^= seasonRewardId_.GetHashCode();
		num ^= seasonRewardType_.GetHashCode();
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
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (RankNameTextId.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(RankNameTextId);
		}
		if (Ranking != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Ranking);
		}
		seasonRewardCount_.WriteTo(ref output, _repeated_seasonRewardCount_codec);
		seasonRewardId_.WriteTo(ref output, _repeated_seasonRewardId_codec);
		seasonRewardType_.WriteTo(ref output, _repeated_seasonRewardType_codec);
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
		if (RankNameTextId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(RankNameTextId);
		}
		if (Ranking != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Ranking);
		}
		num += seasonRewardCount_.CalculateSize(_repeated_seasonRewardCount_codec);
		num += seasonRewardId_.CalculateSize(_repeated_seasonRewardId_codec);
		num += seasonRewardType_.CalculateSize(_repeated_seasonRewardType_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonsterHuntRankTable other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.RankNameTextId.Length != 0)
			{
				RankNameTextId = other.RankNameTextId;
			}
			if (other.Ranking != 0)
			{
				Ranking = other.Ranking;
			}
			seasonRewardCount_.Add(other.seasonRewardCount_);
			seasonRewardId_.Add(other.seasonRewardId_);
			seasonRewardType_.Add(other.seasonRewardType_);
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
			case 48u:
			case 50u:
				seasonRewardType_.AddEntriesFrom(ref input, _repeated_seasonRewardType_codec);
				break;
			case 40u:
			case 42u:
				seasonRewardId_.AddEntriesFrom(ref input, _repeated_seasonRewardId_codec);
				break;
			case 8u:
				Id = input.ReadInt32();
				break;
			case 18u:
				RankNameTextId = input.ReadString();
				break;
			case 24u:
				Ranking = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 32u:
			case 34u:
				seasonRewardCount_.AddEntriesFrom(ref input, _repeated_seasonRewardCount_codec);
				break;
			}
		}
	}
}
