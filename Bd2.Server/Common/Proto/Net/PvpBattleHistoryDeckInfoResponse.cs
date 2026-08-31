using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PvpBattleHistoryDeckInfoResponse : IMessage<PvpBattleHistoryDeckInfoResponse>, IMessage, IEquatable<PvpBattleHistoryDeckInfoResponse>, IDeepCloneable<PvpBattleHistoryDeckInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<PvpBattleHistoryDeckInfoResponse> _parser = new MessageParser<PvpBattleHistoryDeckInfoResponse>(() => new PvpBattleHistoryDeckInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int UserDeckFullInfoFieldNumber = 1;

	private PvpBattleUserDeckFullInfo userDeckFullInfo_;

	public const int EnemyDeckFullInfoFieldNumber = 2;

	private PvpBattleUserDeckFullInfo enemyDeckFullInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PvpBattleHistoryDeckInfoResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => PvpBattleHistoryDeckInfoResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PvpBattleUserDeckFullInfo UserDeckFullInfo
	{
		get
		{
			return userDeckFullInfo_;
		}
		set
		{
			userDeckFullInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleUserDeckFullInfo EnemyDeckFullInfo
	{
		get
		{
			return enemyDeckFullInfo_;
		}
		set
		{
			enemyDeckFullInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleHistoryDeckInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleHistoryDeckInfoResponse(PvpBattleHistoryDeckInfoResponse other)
		: this()
	{
		userDeckFullInfo_ = ((other.userDeckFullInfo_ != null) ? other.userDeckFullInfo_.Clone() : null);
		enemyDeckFullInfo_ = ((other.enemyDeckFullInfo_ != null) ? other.enemyDeckFullInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PvpBattleHistoryDeckInfoResponse Clone()
	{
		return new PvpBattleHistoryDeckInfoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PvpBattleHistoryDeckInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PvpBattleHistoryDeckInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(UserDeckFullInfo, other.UserDeckFullInfo) && object.Equals(EnemyDeckFullInfo, other.EnemyDeckFullInfo))
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
		if (userDeckFullInfo_ != null)
		{
			num ^= UserDeckFullInfo.GetHashCode();
		}
		if (enemyDeckFullInfo_ != null)
		{
			num ^= EnemyDeckFullInfo.GetHashCode();
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
		if (userDeckFullInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(UserDeckFullInfo);
		}
		if (enemyDeckFullInfo_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(EnemyDeckFullInfo);
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
		if (userDeckFullInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(UserDeckFullInfo);
		}
		if (enemyDeckFullInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EnemyDeckFullInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PvpBattleHistoryDeckInfoResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.userDeckFullInfo_ != null)
		{
			if (userDeckFullInfo_ == null)
			{
				UserDeckFullInfo = new PvpBattleUserDeckFullInfo();
			}
			UserDeckFullInfo.MergeFrom(other.UserDeckFullInfo);
		}
		if (other.enemyDeckFullInfo_ != null)
		{
			if (enemyDeckFullInfo_ == null)
			{
				EnemyDeckFullInfo = new PvpBattleUserDeckFullInfo();
			}
			EnemyDeckFullInfo.MergeFrom(other.EnemyDeckFullInfo);
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
			case 18u:
				if (enemyDeckFullInfo_ == null)
				{
					EnemyDeckFullInfo = new PvpBattleUserDeckFullInfo();
				}
				input.ReadMessage(EnemyDeckFullInfo);
				break;
			case 10u:
				if (userDeckFullInfo_ == null)
				{
					UserDeckFullInfo = new PvpBattleUserDeckFullInfo();
				}
				input.ReadMessage(UserDeckFullInfo);
				break;
			}
		}
	}
}
