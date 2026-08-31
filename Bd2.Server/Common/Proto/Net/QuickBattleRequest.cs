using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class QuickBattleRequest : IMessage<QuickBattleRequest>, IMessage, IEquatable<QuickBattleRequest>, IDeepCloneable<QuickBattleRequest>, IBufferMessage
{
	private static readonly MessageParser<QuickBattleRequest> _parser = new MessageParser<QuickBattleRequest>(() => new QuickBattleRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int BattleModeFieldNumber = 2;

	private int battleMode_;

	public const int BattleIndexFieldNumber = 3;

	private int battleIndex_;

	public const int StageMagicGroupIdFieldNumber = 4;

	private int stageMagicGroupId_;

	public const int StageMagicIdFieldNumber = 5;

	private int stageMagicId_;

	public const int BattleCountFieldNumber = 6;

	private int battleCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<QuickBattleRequest> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => QuickBattleRequestReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Seq
	{
		get
		{
			return seq_;
		}
		set
		{
			seq_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BattleMode
	{
		get
		{
			return battleMode_;
		}
		set
		{
			battleMode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BattleIndex
	{
		get
		{
			return battleIndex_;
		}
		set
		{
			battleIndex_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int StageMagicGroupId
	{
		get
		{
			return stageMagicGroupId_;
		}
		set
		{
			stageMagicGroupId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int StageMagicId
	{
		get
		{
			return stageMagicId_;
		}
		set
		{
			stageMagicId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BattleCount
	{
		get
		{
			return battleCount_;
		}
		set
		{
			battleCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public QuickBattleRequest()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuickBattleRequest(QuickBattleRequest other)
		: this()
	{
		seq_ = other.seq_;
		battleMode_ = other.battleMode_;
		battleIndex_ = other.battleIndex_;
		stageMagicGroupId_ = other.stageMagicGroupId_;
		stageMagicId_ = other.stageMagicId_;
		battleCount_ = other.battleCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuickBattleRequest Clone()
	{
		return new QuickBattleRequest(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as QuickBattleRequest);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(QuickBattleRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && BattleMode == other.BattleMode && BattleIndex == other.BattleIndex && StageMagicGroupId == other.StageMagicGroupId && StageMagicId == other.StageMagicId && BattleCount == other.BattleCount)
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
		if (Seq != 0)
		{
			num ^= Seq.GetHashCode();
		}
		if (BattleMode != 0)
		{
			num ^= BattleMode.GetHashCode();
		}
		if (BattleIndex != 0)
		{
			num ^= BattleIndex.GetHashCode();
		}
		if (StageMagicGroupId != 0)
		{
			num ^= StageMagicGroupId.GetHashCode();
		}
		if (StageMagicId != 0)
		{
			num ^= StageMagicId.GetHashCode();
		}
		if (BattleCount != 0)
		{
			num ^= BattleCount.GetHashCode();
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
		if (Seq != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Seq);
		}
		if (BattleMode != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BattleMode);
		}
		if (BattleIndex != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(BattleIndex);
		}
		if (StageMagicGroupId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(StageMagicGroupId);
		}
		if (StageMagicId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(StageMagicId);
		}
		if (BattleCount != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(BattleCount);
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
		if (Seq != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Seq);
		}
		if (BattleMode != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleMode);
		}
		if (BattleIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleIndex);
		}
		if (StageMagicGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StageMagicGroupId);
		}
		if (StageMagicId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StageMagicId);
		}
		if (BattleCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(QuickBattleRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			if (other.BattleMode != 0)
			{
				BattleMode = other.BattleMode;
			}
			if (other.BattleIndex != 0)
			{
				BattleIndex = other.BattleIndex;
			}
			if (other.StageMagicGroupId != 0)
			{
				StageMagicGroupId = other.StageMagicGroupId;
			}
			if (other.StageMagicId != 0)
			{
				StageMagicId = other.StageMagicId;
			}
			if (other.BattleCount != 0)
			{
				BattleCount = other.BattleCount;
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
				Seq = input.ReadInt32();
				break;
			case 16u:
				BattleMode = input.ReadInt32();
				break;
			case 24u:
				BattleIndex = input.ReadInt32();
				break;
			case 32u:
				StageMagicGroupId = input.ReadInt32();
				break;
			case 40u:
				StageMagicId = input.ReadInt32();
				break;
			case 48u:
				BattleCount = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
