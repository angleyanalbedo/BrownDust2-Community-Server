using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EvilCastleRogueLikeRankInfoResponse : IMessage<EvilCastleRogueLikeRankInfoResponse>, IMessage, IEquatable<EvilCastleRogueLikeRankInfoResponse>, IDeepCloneable<EvilCastleRogueLikeRankInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<EvilCastleRogueLikeRankInfoResponse> _parser = new MessageParser<EvilCastleRogueLikeRankInfoResponse>(() => new EvilCastleRogueLikeRankInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int UserRankInfoFieldNumber = 1;

	private static readonly FieldCodec<EvilCastleRogueLikeRankUserInfo> _repeated_userRankInfo_codec = FieldCodec.ForMessage(10u, EvilCastleRogueLikeRankUserInfo.Parser);

	private readonly RepeatedField<EvilCastleRogueLikeRankUserInfo> userRankInfo_ = new RepeatedField<EvilCastleRogueLikeRankUserInfo>();

	public const int MyRankInfoFieldNumber = 2;

	private EvilCastleRogueLikeRankUserInfo myRankInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EvilCastleRogueLikeRankInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EvilCastleRogueLikeRankInfoResponseReflection.Descriptor.MessageTypes[1];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EvilCastleRogueLikeRankUserInfo> UserRankInfo => userRankInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeRankUserInfo MyRankInfo
	{
		get
		{
			return myRankInfo_;
		}
		set
		{
			myRankInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeRankInfoResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleRogueLikeRankInfoResponse(EvilCastleRogueLikeRankInfoResponse other)
		: this()
	{
		userRankInfo_ = other.userRankInfo_.Clone();
		myRankInfo_ = ((other.myRankInfo_ != null) ? other.myRankInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleRogueLikeRankInfoResponse Clone()
	{
		return new EvilCastleRogueLikeRankInfoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EvilCastleRogueLikeRankInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EvilCastleRogueLikeRankInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (userRankInfo_.Equals(other.userRankInfo_) && object.Equals(MyRankInfo, other.MyRankInfo))
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
		num ^= userRankInfo_.GetHashCode();
		if (myRankInfo_ != null)
		{
			num ^= MyRankInfo.GetHashCode();
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
		userRankInfo_.WriteTo(ref output, _repeated_userRankInfo_codec);
		if (myRankInfo_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(MyRankInfo);
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
		num += userRankInfo_.CalculateSize(_repeated_userRankInfo_codec);
		if (myRankInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MyRankInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EvilCastleRogueLikeRankInfoResponse other)
	{
		if (other == null)
		{
			return;
		}
		userRankInfo_.Add(other.userRankInfo_);
		if (other.myRankInfo_ != null)
		{
			if (myRankInfo_ == null)
			{
				MyRankInfo = new EvilCastleRogueLikeRankUserInfo();
			}
			MyRankInfo.MergeFrom(other.MyRankInfo);
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
				if (myRankInfo_ == null)
				{
					MyRankInfo = new EvilCastleRogueLikeRankUserInfo();
				}
				input.ReadMessage(MyRankInfo);
				break;
			case 10u:
				userRankInfo_.AddEntriesFrom(ref input, _repeated_userRankInfo_codec);
				break;
			}
		}
	}
}
