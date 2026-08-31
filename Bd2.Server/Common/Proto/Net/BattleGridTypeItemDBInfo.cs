using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class BattleGridTypeItemDBInfo : IMessage<BattleGridTypeItemDBInfo>, IMessage, IEquatable<BattleGridTypeItemDBInfo>, IDeepCloneable<BattleGridTypeItemDBInfo>, IBufferMessage
{
	private static readonly MessageParser<BattleGridTypeItemDBInfo> _parser = new MessageParser<BattleGridTypeItemDBInfo>(() => new BattleGridTypeItemDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int TeamTypeFieldNumber = 1;

	private int teamType_;

	public const int GridIndexFieldNumber = 2;

	private int gridIndex_;

	public const int BuffIdFieldNumber = 3;

	private int buffId_;

	public const int IsInfiniteFieldNumber = 4;

	private bool isInfinite_;

	public const int BuffTurnFieldNumber = 5;

	private int buffTurn_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BattleGridTypeItemDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BattleGridTypeItemDBInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TeamType
	{
		get
		{
			return teamType_;
		}
		set
		{
			teamType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int GridIndex
	{
		get
		{
			return gridIndex_;
		}
		set
		{
			gridIndex_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BuffId
	{
		get
		{
			return buffId_;
		}
		set
		{
			buffId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsInfinite
	{
		get
		{
			return isInfinite_;
		}
		set
		{
			isInfinite_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BuffTurn
	{
		get
		{
			return buffTurn_;
		}
		set
		{
			buffTurn_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleGridTypeItemDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleGridTypeItemDBInfo(BattleGridTypeItemDBInfo other)
		: this()
	{
		teamType_ = other.teamType_;
		gridIndex_ = other.gridIndex_;
		buffId_ = other.buffId_;
		isInfinite_ = other.isInfinite_;
		buffTurn_ = other.buffTurn_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleGridTypeItemDBInfo Clone()
	{
		return new BattleGridTypeItemDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BattleGridTypeItemDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BattleGridTypeItemDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (TeamType == other.TeamType && GridIndex == other.GridIndex && BuffId == other.BuffId && IsInfinite == other.IsInfinite && BuffTurn == other.BuffTurn)
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
		if (TeamType != 0)
		{
			num ^= TeamType.GetHashCode();
		}
		if (GridIndex != 0)
		{
			num ^= GridIndex.GetHashCode();
		}
		if (BuffId != 0)
		{
			num ^= BuffId.GetHashCode();
		}
		if (IsInfinite)
		{
			num ^= IsInfinite.GetHashCode();
		}
		if (BuffTurn != 0)
		{
			num ^= BuffTurn.GetHashCode();
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
		if (TeamType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(TeamType);
		}
		if (GridIndex != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(GridIndex);
		}
		if (BuffId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(BuffId);
		}
		if (IsInfinite)
		{
			output.WriteRawTag(32);
			output.WriteBool(IsInfinite);
		}
		if (BuffTurn != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(BuffTurn);
		}
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
		if (TeamType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TeamType);
		}
		if (GridIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GridIndex);
		}
		if (BuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffId);
		}
		if (IsInfinite)
		{
			num += 2;
		}
		if (BuffTurn != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffTurn);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(BattleGridTypeItemDBInfo other)
	{
		if (other != null)
		{
			if (other.TeamType != 0)
			{
				TeamType = other.TeamType;
			}
			if (other.GridIndex != 0)
			{
				GridIndex = other.GridIndex;
			}
			if (other.BuffId != 0)
			{
				BuffId = other.BuffId;
			}
			if (other.IsInfinite)
			{
				IsInfinite = other.IsInfinite;
			}
			if (other.BuffTurn != 0)
			{
				BuffTurn = other.BuffTurn;
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
				TeamType = input.ReadInt32();
				break;
			case 16u:
				GridIndex = input.ReadInt32();
				break;
			case 24u:
				BuffId = input.ReadInt32();
				break;
			case 32u:
				IsInfinite = input.ReadBool();
				break;
			case 40u:
				BuffTurn = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
