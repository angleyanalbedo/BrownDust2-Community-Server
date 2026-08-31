using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PvpBattleUserBaseInfo : IMessage<PvpBattleUserBaseInfo>, IMessage, IEquatable<PvpBattleUserBaseInfo>, IDeepCloneable<PvpBattleUserBaseInfo>, IBufferMessage
{
	private static readonly MessageParser<PvpBattleUserBaseInfo> _parser = new MessageParser<PvpBattleUserBaseInfo>(() => new PvpBattleUserBaseInfo());

	private UnknownFieldSet _unknownFields;

	public const int VpFieldNumber = 1;

	private int vp_;

	public const int RankFieldNumber = 2;

	private int rank_;

	public const int WinCountFieldNumber = 3;

	private int winCount_;

	public const int LoseCountFieldNumber = 4;

	private int loseCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PvpBattleUserBaseInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PvpBattleUserBaseInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Vp
	{
		get
		{
			return vp_;
		}
		set
		{
			vp_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Rank
	{
		get
		{
			return rank_;
		}
		set
		{
			rank_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int WinCount
	{
		get
		{
			return winCount_;
		}
		set
		{
			winCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int LoseCount
	{
		get
		{
			return loseCount_;
		}
		set
		{
			loseCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleUserBaseInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleUserBaseInfo(PvpBattleUserBaseInfo other)
		: this()
	{
		vp_ = other.vp_;
		rank_ = other.rank_;
		winCount_ = other.winCount_;
		loseCount_ = other.loseCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PvpBattleUserBaseInfo Clone()
	{
		return new PvpBattleUserBaseInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PvpBattleUserBaseInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PvpBattleUserBaseInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Vp == other.Vp && Rank == other.Rank && WinCount == other.WinCount && LoseCount == other.LoseCount)
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
		if (Vp != 0)
		{
			num ^= Vp.GetHashCode();
		}
		if (Rank != 0)
		{
			num ^= Rank.GetHashCode();
		}
		if (WinCount != 0)
		{
			num ^= WinCount.GetHashCode();
		}
		if (LoseCount != 0)
		{
			num ^= LoseCount.GetHashCode();
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
		if (Vp != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Vp);
		}
		if (Rank != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Rank);
		}
		if (WinCount != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(WinCount);
		}
		if (LoseCount != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(LoseCount);
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
		if (Vp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Vp);
		}
		if (Rank != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Rank);
		}
		if (WinCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(WinCount);
		}
		if (LoseCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LoseCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PvpBattleUserBaseInfo other)
	{
		if (other != null)
		{
			if (other.Vp != 0)
			{
				Vp = other.Vp;
			}
			if (other.Rank != 0)
			{
				Rank = other.Rank;
			}
			if (other.WinCount != 0)
			{
				WinCount = other.WinCount;
			}
			if (other.LoseCount != 0)
			{
				LoseCount = other.LoseCount;
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
				Vp = input.ReadInt32();
				break;
			case 16u:
				Rank = input.ReadInt32();
				break;
			case 24u:
				WinCount = input.ReadInt32();
				break;
			case 32u:
				LoseCount = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
