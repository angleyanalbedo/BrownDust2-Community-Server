using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PvpBattleRankingResponse : IMessage<PvpBattleRankingResponse>, IMessage, IEquatable<PvpBattleRankingResponse>, IDeepCloneable<PvpBattleRankingResponse>, IBufferMessage
{
	private static readonly MessageParser<PvpBattleRankingResponse> _parser = new MessageParser<PvpBattleRankingResponse>(() => new PvpBattleRankingResponse());

	private UnknownFieldSet _unknownFields;

	public const int UserRankingInfoFieldNumber = 1;

	private static readonly FieldCodec<PvpBattleRankUserInfo> _repeated_userRankingInfo_codec = FieldCodec.ForMessage(10u, PvpBattleRankUserInfo.Parser);

	private readonly RepeatedField<PvpBattleRankUserInfo> userRankingInfo_ = new RepeatedField<PvpBattleRankUserInfo>();

	public const int MyRankingInfoFieldNumber = 2;

	private PvpBattleRankUserInfo myRankingInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PvpBattleRankingResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PvpBattleRankingResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PvpBattleRankUserInfo> UserRankingInfo => userRankingInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleRankUserInfo MyRankingInfo
	{
		get
		{
			return myRankingInfo_;
		}
		set
		{
			myRankingInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PvpBattleRankingResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleRankingResponse(PvpBattleRankingResponse other)
		: this()
	{
		userRankingInfo_ = other.userRankingInfo_.Clone();
		myRankingInfo_ = ((other.myRankingInfo_ != null) ? other.myRankingInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleRankingResponse Clone()
	{
		return new PvpBattleRankingResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PvpBattleRankingResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PvpBattleRankingResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (userRankingInfo_.Equals(other.userRankingInfo_) && object.Equals(MyRankingInfo, other.MyRankingInfo))
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
		num ^= userRankingInfo_.GetHashCode();
		if (myRankingInfo_ != null)
		{
			num ^= MyRankingInfo.GetHashCode();
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
		userRankingInfo_.WriteTo(ref output, _repeated_userRankingInfo_codec);
		if (myRankingInfo_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(MyRankingInfo);
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
		num += userRankingInfo_.CalculateSize(_repeated_userRankingInfo_codec);
		if (myRankingInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MyRankingInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PvpBattleRankingResponse other)
	{
		if (other == null)
		{
			return;
		}
		userRankingInfo_.Add(other.userRankingInfo_);
		if (other.myRankingInfo_ != null)
		{
			if (myRankingInfo_ == null)
			{
				MyRankingInfo = new PvpBattleRankUserInfo();
			}
			MyRankingInfo.MergeFrom(other.MyRankingInfo);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				if (myRankingInfo_ == null)
				{
					MyRankingInfo = new PvpBattleRankUserInfo();
				}
				input.ReadMessage(MyRankingInfo);
				break;
			case 10u:
				userRankingInfo_.AddEntriesFrom(ref input, _repeated_userRankingInfo_codec);
				break;
			}
		}
	}
}
