using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MonsterHuntChangeTeamRequest : IMessage<MonsterHuntChangeTeamRequest>, IMessage, IEquatable<MonsterHuntChangeTeamRequest>, IDeepCloneable<MonsterHuntChangeTeamRequest>, IBufferMessage
{
	private static readonly MessageParser<MonsterHuntChangeTeamRequest> _parser = new MessageParser<MonsterHuntChangeTeamRequest>(() => new MonsterHuntChangeTeamRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int MonsterHuntDeckInfoFieldNumber = 2;

	private MonsterHuntDeckDBInfo monsterHuntDeckInfo_;

	public const int IsChangeManualFieldNumber = 3;

	private bool isChangeManual_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonsterHuntChangeTeamRequest> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonsterHuntChangeTeamRequestReflection.Descriptor.MessageTypes[0];

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
	public MonsterHuntDeckDBInfo MonsterHuntDeckInfo
	{
		get
		{
			return monsterHuntDeckInfo_;
		}
		set
		{
			monsterHuntDeckInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsChangeManual
	{
		get
		{
			return isChangeManual_;
		}
		set
		{
			isChangeManual_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterHuntChangeTeamRequest()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterHuntChangeTeamRequest(MonsterHuntChangeTeamRequest other)
		: this()
	{
		seq_ = other.seq_;
		monsterHuntDeckInfo_ = ((other.monsterHuntDeckInfo_ != null) ? other.monsterHuntDeckInfo_.Clone() : null);
		isChangeManual_ = other.isChangeManual_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterHuntChangeTeamRequest Clone()
	{
		return new MonsterHuntChangeTeamRequest(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonsterHuntChangeTeamRequest);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MonsterHuntChangeTeamRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && object.Equals(MonsterHuntDeckInfo, other.MonsterHuntDeckInfo) && IsChangeManual == other.IsChangeManual)
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
		if (Seq != 0)
		{
			num ^= Seq.GetHashCode();
		}
		if (monsterHuntDeckInfo_ != null)
		{
			num ^= MonsterHuntDeckInfo.GetHashCode();
		}
		if (IsChangeManual)
		{
			num ^= IsChangeManual.GetHashCode();
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
		if (monsterHuntDeckInfo_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(MonsterHuntDeckInfo);
		}
		if (IsChangeManual)
		{
			output.WriteRawTag(24);
			output.WriteBool(IsChangeManual);
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
		if (monsterHuntDeckInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MonsterHuntDeckInfo);
		}
		if (IsChangeManual)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonsterHuntChangeTeamRequest other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Seq != 0)
		{
			Seq = other.Seq;
		}
		if (other.monsterHuntDeckInfo_ != null)
		{
			if (monsterHuntDeckInfo_ == null)
			{
				MonsterHuntDeckInfo = new MonsterHuntDeckDBInfo();
			}
			MonsterHuntDeckInfo.MergeFrom(other.MonsterHuntDeckInfo);
		}
		if (other.IsChangeManual)
		{
			IsChangeManual = other.IsChangeManual;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 24u:
				IsChangeManual = input.ReadBool();
				break;
			case 18u:
				if (monsterHuntDeckInfo_ == null)
				{
					MonsterHuntDeckInfo = new MonsterHuntDeckDBInfo();
				}
				input.ReadMessage(MonsterHuntDeckInfo);
				break;
			case 8u:
				Seq = input.ReadInt32();
				break;
			}
		}
	}
}
