using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EvilCastleTowerDBInfo : IMessage<EvilCastleTowerDBInfo>, IMessage, IEquatable<EvilCastleTowerDBInfo>, IDeepCloneable<EvilCastleTowerDBInfo>, IBufferMessage
{
	private static readonly MessageParser<EvilCastleTowerDBInfo> _parser = new MessageParser<EvilCastleTowerDBInfo>(() => new EvilCastleTowerDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int BattleChallengeIndexFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_battleChallengeIndex_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> battleChallengeIndex_ = new RepeatedField<int>();

	public const int BattleModeFieldNumber = 3;

	private int battleMode_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<EvilCastleTowerDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EvilCastleTowerDBInfoReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> BattleChallengeIndex => battleChallengeIndex_;

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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleTowerDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleTowerDBInfo(EvilCastleTowerDBInfo other)
		: this()
	{
		id_ = other.id_;
		battleChallengeIndex_ = other.battleChallengeIndex_.Clone();
		battleMode_ = other.battleMode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleTowerDBInfo Clone()
	{
		return new EvilCastleTowerDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EvilCastleTowerDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EvilCastleTowerDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && battleChallengeIndex_.Equals(other.battleChallengeIndex_) && BattleMode == other.BattleMode)
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
		num ^= battleChallengeIndex_.GetHashCode();
		if (BattleMode != 0)
		{
			num ^= BattleMode.GetHashCode();
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
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		battleChallengeIndex_.WriteTo(ref output, _repeated_battleChallengeIndex_codec);
		if (BattleMode != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(BattleMode);
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
		num += battleChallengeIndex_.CalculateSize(_repeated_battleChallengeIndex_codec);
		if (BattleMode != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleMode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EvilCastleTowerDBInfo other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			battleChallengeIndex_.Add(other.battleChallengeIndex_);
			if (other.BattleMode != 0)
			{
				BattleMode = other.BattleMode;
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
				Id = input.ReadInt32();
				break;
			case 24u:
				BattleMode = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 16u:
			case 18u:
				battleChallengeIndex_.AddEntriesFrom(ref input, _repeated_battleChallengeIndex_codec);
				break;
			}
		}
	}
}
