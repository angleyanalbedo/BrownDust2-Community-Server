using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GachaScheduleDBInfo : IMessage<GachaScheduleDBInfo>, IMessage, IEquatable<GachaScheduleDBInfo>, IDeepCloneable<GachaScheduleDBInfo>, IBufferMessage
{
	private static readonly MessageParser<GachaScheduleDBInfo> _parser = new MessageParser<GachaScheduleDBInfo>(() => new GachaScheduleDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int GroupIdFieldNumber = 1;

	private int groupId_;

	public const int StartTimeFieldNumber = 2;

	private long startTime_;

	public const int EndTimeFieldNumber = 3;

	private long endTime_;

	public const int IsGachaFreeCountBonusFieldNumber = 4;

	private bool isGachaFreeCountBonus_;

	public const int IsGachaCashCountBonusFieldNumber = 5;

	private bool isGachaCashCountBonus_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GachaScheduleDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GachaScheduleDBInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long StartTime
	{
		get
		{
			return startTime_;
		}
		set
		{
			startTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long EndTime
	{
		get
		{
			return endTime_;
		}
		set
		{
			endTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsGachaFreeCountBonus
	{
		get
		{
			return isGachaFreeCountBonus_;
		}
		set
		{
			isGachaFreeCountBonus_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsGachaCashCountBonus
	{
		get
		{
			return isGachaCashCountBonus_;
		}
		set
		{
			isGachaCashCountBonus_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaScheduleDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaScheduleDBInfo(GachaScheduleDBInfo other)
		: this()
	{
		groupId_ = other.groupId_;
		startTime_ = other.startTime_;
		endTime_ = other.endTime_;
		isGachaFreeCountBonus_ = other.isGachaFreeCountBonus_;
		isGachaCashCountBonus_ = other.isGachaCashCountBonus_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaScheduleDBInfo Clone()
	{
		return new GachaScheduleDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GachaScheduleDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GachaScheduleDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (GroupId == other.GroupId && StartTime == other.StartTime && EndTime == other.EndTime && IsGachaFreeCountBonus == other.IsGachaFreeCountBonus && IsGachaCashCountBonus == other.IsGachaCashCountBonus)
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
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (StartTime != 0L)
		{
			num ^= StartTime.GetHashCode();
		}
		if (EndTime != 0L)
		{
			num ^= EndTime.GetHashCode();
		}
		if (IsGachaFreeCountBonus)
		{
			num ^= IsGachaFreeCountBonus.GetHashCode();
		}
		if (IsGachaCashCountBonus)
		{
			num ^= IsGachaCashCountBonus.GetHashCode();
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
		if (GroupId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(GroupId);
		}
		if (StartTime != 0L)
		{
			output.WriteRawTag(16);
			output.WriteInt64(StartTime);
		}
		if (EndTime != 0L)
		{
			output.WriteRawTag(24);
			output.WriteInt64(EndTime);
		}
		if (IsGachaFreeCountBonus)
		{
			output.WriteRawTag(32);
			output.WriteBool(IsGachaFreeCountBonus);
		}
		if (IsGachaCashCountBonus)
		{
			output.WriteRawTag(40);
			output.WriteBool(IsGachaCashCountBonus);
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
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (StartTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(StartTime);
		}
		if (EndTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(EndTime);
		}
		if (IsGachaFreeCountBonus)
		{
			num += 2;
		}
		if (IsGachaCashCountBonus)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GachaScheduleDBInfo other)
	{
		if (other != null)
		{
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.StartTime != 0L)
			{
				StartTime = other.StartTime;
			}
			if (other.EndTime != 0L)
			{
				EndTime = other.EndTime;
			}
			if (other.IsGachaFreeCountBonus)
			{
				IsGachaFreeCountBonus = other.IsGachaFreeCountBonus;
			}
			if (other.IsGachaCashCountBonus)
			{
				IsGachaCashCountBonus = other.IsGachaCashCountBonus;
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
				GroupId = input.ReadInt32();
				break;
			case 16u:
				StartTime = input.ReadInt64();
				break;
			case 24u:
				EndTime = input.ReadInt64();
				break;
			case 32u:
				IsGachaFreeCountBonus = input.ReadBool();
				break;
			case 40u:
				IsGachaCashCountBonus = input.ReadBool();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
