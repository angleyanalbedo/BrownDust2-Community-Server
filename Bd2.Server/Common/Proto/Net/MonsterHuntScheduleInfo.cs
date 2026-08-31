using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MonsterHuntScheduleInfo : IMessage<MonsterHuntScheduleInfo>, IMessage, IEquatable<MonsterHuntScheduleInfo>, IDeepCloneable<MonsterHuntScheduleInfo>, IBufferMessage
{
	private static readonly MessageParser<MonsterHuntScheduleInfo> _parser = new MessageParser<MonsterHuntScheduleInfo>(() => new MonsterHuntScheduleInfo());

	private UnknownFieldSet _unknownFields;

	public const int SeasonInfoFieldNumber = 1;

	private SeasonInfo seasonInfo_;

	public const int MonsterHuntIdFieldNumber = 2;

	private int monsterHuntId_;

	public const int InfoOpenDayFieldNumber = 3;

	private int infoOpenDay_;

	public const int CalculateEndDateFieldNumber = 4;

	private long calculateEndDate_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonsterHuntScheduleInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SchduleInfoReflection.Descriptor.MessageTypes[2];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SeasonInfo SeasonInfo
	{
		get
		{
			return seasonInfo_;
		}
		set
		{
			seasonInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MonsterHuntId
	{
		get
		{
			return monsterHuntId_;
		}
		set
		{
			monsterHuntId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int InfoOpenDay
	{
		get
		{
			return infoOpenDay_;
		}
		set
		{
			infoOpenDay_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long CalculateEndDate
	{
		get
		{
			return calculateEndDate_;
		}
		set
		{
			calculateEndDate_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterHuntScheduleInfo()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MonsterHuntScheduleInfo(MonsterHuntScheduleInfo other)
		: this()
	{
		seasonInfo_ = ((other.seasonInfo_ != null) ? other.seasonInfo_.Clone() : null);
		monsterHuntId_ = other.monsterHuntId_;
		infoOpenDay_ = other.infoOpenDay_;
		calculateEndDate_ = other.calculateEndDate_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterHuntScheduleInfo Clone()
	{
		return new MonsterHuntScheduleInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonsterHuntScheduleInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonsterHuntScheduleInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(SeasonInfo, other.SeasonInfo) && MonsterHuntId == other.MonsterHuntId && InfoOpenDay == other.InfoOpenDay && CalculateEndDate == other.CalculateEndDate)
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
		if (seasonInfo_ != null)
		{
			num ^= SeasonInfo.GetHashCode();
		}
		if (MonsterHuntId != 0)
		{
			num ^= MonsterHuntId.GetHashCode();
		}
		if (InfoOpenDay != 0)
		{
			num ^= InfoOpenDay.GetHashCode();
		}
		if (CalculateEndDate != 0L)
		{
			num ^= CalculateEndDate.GetHashCode();
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
		if (seasonInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(SeasonInfo);
		}
		if (MonsterHuntId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(MonsterHuntId);
		}
		if (InfoOpenDay != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(InfoOpenDay);
		}
		if (CalculateEndDate != 0L)
		{
			output.WriteRawTag(32);
			output.WriteInt64(CalculateEndDate);
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
		if (seasonInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SeasonInfo);
		}
		if (MonsterHuntId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MonsterHuntId);
		}
		if (InfoOpenDay != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(InfoOpenDay);
		}
		if (CalculateEndDate != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(CalculateEndDate);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonsterHuntScheduleInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.seasonInfo_ != null)
		{
			if (seasonInfo_ == null)
			{
				SeasonInfo = new SeasonInfo();
			}
			SeasonInfo.MergeFrom(other.SeasonInfo);
		}
		if (other.MonsterHuntId != 0)
		{
			MonsterHuntId = other.MonsterHuntId;
		}
		if (other.InfoOpenDay != 0)
		{
			InfoOpenDay = other.InfoOpenDay;
		}
		if (other.CalculateEndDate != 0L)
		{
			CalculateEndDate = other.CalculateEndDate;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 10u:
				if (seasonInfo_ == null)
				{
					SeasonInfo = new SeasonInfo();
				}
				input.ReadMessage(SeasonInfo);
				break;
			case 16u:
				MonsterHuntId = input.ReadInt32();
				break;
			case 24u:
				InfoOpenDay = input.ReadInt32();
				break;
			case 32u:
				CalculateEndDate = input.ReadInt64();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
