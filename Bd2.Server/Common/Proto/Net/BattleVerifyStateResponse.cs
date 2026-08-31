using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class BattleVerifyStateResponse : IMessage<BattleVerifyStateResponse>, IMessage, IEquatable<BattleVerifyStateResponse>, IDeepCloneable<BattleVerifyStateResponse>, IBufferMessage
{
	private static readonly MessageParser<BattleVerifyStateResponse> _parser = new MessageParser<BattleVerifyStateResponse>(() => new BattleVerifyStateResponse());

	private UnknownFieldSet _unknownFields;

	public const int StateFieldNumber = 1;

	private int state_;

	public const int TeamTypeFieldNumber = 2;

	private Define_TeamType teamType_;

	public const int RedCharInfoFieldNumber = 3;

	private static readonly FieldCodec<BattleCharDBInfo> _repeated_redCharInfo_codec = FieldCodec.ForMessage(26u, BattleCharDBInfo.Parser);

	private readonly RepeatedField<BattleCharDBInfo> redCharInfo_ = new RepeatedField<BattleCharDBInfo>();

	public const int BlueCharInfoFieldNumber = 4;

	private static readonly FieldCodec<BattleCharDBInfo> _repeated_blueCharInfo_codec = FieldCodec.ForMessage(34u, BattleCharDBInfo.Parser);

	private readonly RepeatedField<BattleCharDBInfo> blueCharInfo_ = new RepeatedField<BattleCharDBInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<BattleVerifyStateResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => BattleVerifyStateResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int State
	{
		get
		{
			return state_;
		}
		set
		{
			state_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Define_TeamType TeamType
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BattleCharDBInfo> RedCharInfo => redCharInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BattleCharDBInfo> BlueCharInfo => blueCharInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BattleVerifyStateResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleVerifyStateResponse(BattleVerifyStateResponse other)
		: this()
	{
		state_ = other.state_;
		teamType_ = other.teamType_;
		redCharInfo_ = other.redCharInfo_.Clone();
		blueCharInfo_ = other.blueCharInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BattleVerifyStateResponse Clone()
	{
		return new BattleVerifyStateResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as BattleVerifyStateResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BattleVerifyStateResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (State == other.State && TeamType == other.TeamType && redCharInfo_.Equals(other.redCharInfo_) && blueCharInfo_.Equals(other.blueCharInfo_))
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
		if (State != 0)
		{
			num ^= State.GetHashCode();
		}
		if (TeamType != Define_TeamType.TtNone)
		{
			num ^= TeamType.GetHashCode();
		}
		num ^= redCharInfo_.GetHashCode();
		num ^= blueCharInfo_.GetHashCode();
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
		if (State != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(State);
		}
		if (TeamType != Define_TeamType.TtNone)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)TeamType);
		}
		redCharInfo_.WriteTo(ref output, _repeated_redCharInfo_codec);
		blueCharInfo_.WriteTo(ref output, _repeated_blueCharInfo_codec);
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
		if (State != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(State);
		}
		if (TeamType != Define_TeamType.TtNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)TeamType);
		}
		num += redCharInfo_.CalculateSize(_repeated_redCharInfo_codec);
		num += blueCharInfo_.CalculateSize(_repeated_blueCharInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BattleVerifyStateResponse other)
	{
		if (other != null)
		{
			if (other.State != 0)
			{
				State = other.State;
			}
			if (other.TeamType != Define_TeamType.TtNone)
			{
				TeamType = other.TeamType;
			}
			redCharInfo_.Add(other.redCharInfo_);
			blueCharInfo_.Add(other.blueCharInfo_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
				State = input.ReadInt32();
				break;
			case 16u:
				TeamType = (Define_TeamType)input.ReadEnum();
				break;
			case 26u:
				redCharInfo_.AddEntriesFrom(ref input, _repeated_redCharInfo_codec);
				break;
			case 34u:
				blueCharInfo_.AddEntriesFrom(ref input, _repeated_blueCharInfo_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
