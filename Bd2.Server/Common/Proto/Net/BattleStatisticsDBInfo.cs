using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class BattleStatisticsDBInfo : IMessage<BattleStatisticsDBInfo>, IMessage, IEquatable<BattleStatisticsDBInfo>, IDeepCloneable<BattleStatisticsDBInfo>, IBufferMessage
{
	private static readonly MessageParser<BattleStatisticsDBInfo> _parser = new MessageParser<BattleStatisticsDBInfo>(() => new BattleStatisticsDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int AttackDamageInfoFieldNumber = 1;

	private static readonly FieldCodec<BattleDamageDBInfo> _repeated_attackDamageInfo_codec = FieldCodec.ForMessage(10u, BattleDamageDBInfo.Parser);

	private readonly RepeatedField<BattleDamageDBInfo> attackDamageInfo_ = new RepeatedField<BattleDamageDBInfo>();

	public const int ReceivedDamageInfoFieldNumber = 2;

	private static readonly FieldCodec<BattleDamageDBInfo> _repeated_receivedDamageInfo_codec = FieldCodec.ForMessage(18u, BattleDamageDBInfo.Parser);

	private readonly RepeatedField<BattleDamageDBInfo> receivedDamageInfo_ = new RepeatedField<BattleDamageDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BattleStatisticsDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BattleStatisticsDBInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BattleDamageDBInfo> AttackDamageInfo => attackDamageInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BattleDamageDBInfo> ReceivedDamageInfo => receivedDamageInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleStatisticsDBInfo()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BattleStatisticsDBInfo(BattleStatisticsDBInfo other)
		: this()
	{
		attackDamageInfo_ = other.attackDamageInfo_.Clone();
		receivedDamageInfo_ = other.receivedDamageInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BattleStatisticsDBInfo Clone()
	{
		return new BattleStatisticsDBInfo(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as BattleStatisticsDBInfo);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(BattleStatisticsDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (attackDamageInfo_.Equals(other.attackDamageInfo_) && receivedDamageInfo_.Equals(other.receivedDamageInfo_))
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
		num ^= attackDamageInfo_.GetHashCode();
		num ^= receivedDamageInfo_.GetHashCode();
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
		attackDamageInfo_.WriteTo(ref output, _repeated_attackDamageInfo_codec);
		receivedDamageInfo_.WriteTo(ref output, _repeated_receivedDamageInfo_codec);
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
		num += attackDamageInfo_.CalculateSize(_repeated_attackDamageInfo_codec);
		num += receivedDamageInfo_.CalculateSize(_repeated_receivedDamageInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BattleStatisticsDBInfo other)
	{
		if (other != null)
		{
			attackDamageInfo_.Add(other.attackDamageInfo_);
			receivedDamageInfo_.Add(other.receivedDamageInfo_);
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
			case 18u:
				receivedDamageInfo_.AddEntriesFrom(ref input, _repeated_receivedDamageInfo_codec);
				break;
			case 10u:
				attackDamageInfo_.AddEntriesFrom(ref input, _repeated_attackDamageInfo_codec);
				break;
			}
		}
	}
}
