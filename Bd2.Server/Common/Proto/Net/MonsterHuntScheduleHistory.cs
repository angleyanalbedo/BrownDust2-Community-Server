using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MonsterHuntScheduleHistory : IMessage<MonsterHuntScheduleHistory>, IMessage, IEquatable<MonsterHuntScheduleHistory>, IDeepCloneable<MonsterHuntScheduleHistory>, IBufferMessage
{
	private static readonly MessageParser<MonsterHuntScheduleHistory> _parser = new MessageParser<MonsterHuntScheduleHistory>(() => new MonsterHuntScheduleHistory());

	private UnknownFieldSet _unknownFields;

	public const int SeasonFieldNumber = 1;

	private int season_;

	public const int MonsterHuntIdFieldNumber = 2;

	private int monsterHuntId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonsterHuntScheduleHistory> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SchduleInfoReflection.Descriptor.MessageTypes[3];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Season
	{
		get
		{
			return season_;
		}
		set
		{
			season_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public MonsterHuntScheduleHistory()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterHuntScheduleHistory(MonsterHuntScheduleHistory other)
		: this()
	{
		season_ = other.season_;
		monsterHuntId_ = other.monsterHuntId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MonsterHuntScheduleHistory Clone()
	{
		return new MonsterHuntScheduleHistory(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonsterHuntScheduleHistory);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonsterHuntScheduleHistory other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Season == other.Season && MonsterHuntId == other.MonsterHuntId)
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
		if (Season != 0)
		{
			num ^= Season.GetHashCode();
		}
		if (MonsterHuntId != 0)
		{
			num ^= MonsterHuntId.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (Season != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Season);
		}
		if (MonsterHuntId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(MonsterHuntId);
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
		if (Season != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Season);
		}
		if (MonsterHuntId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MonsterHuntId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonsterHuntScheduleHistory other)
	{
		if (other != null)
		{
			if (other.Season != 0)
			{
				Season = other.Season;
			}
			if (other.MonsterHuntId != 0)
			{
				MonsterHuntId = other.MonsterHuntId;
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 16u:
				MonsterHuntId = input.ReadInt32();
				break;
			case 8u:
				Season = input.ReadInt32();
				break;
			}
		}
	}
}
