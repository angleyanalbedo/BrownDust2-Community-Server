using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EvilCastleRogueLikeAllUserScoreInfoResponse : IMessage<EvilCastleRogueLikeAllUserScoreInfoResponse>, IMessage, IEquatable<EvilCastleRogueLikeAllUserScoreInfoResponse>, IDeepCloneable<EvilCastleRogueLikeAllUserScoreInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<EvilCastleRogueLikeAllUserScoreInfoResponse> _parser = new MessageParser<EvilCastleRogueLikeAllUserScoreInfoResponse>(() => new EvilCastleRogueLikeAllUserScoreInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int AllUserTotalScoreFieldNumber = 1;

	private long allUserTotalScore_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<EvilCastleRogueLikeAllUserScoreInfoResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => EvilCastleRogueLikeAllUserScoreInfoResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long AllUserTotalScore
	{
		get
		{
			return allUserTotalScore_;
		}
		set
		{
			allUserTotalScore_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeAllUserScoreInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeAllUserScoreInfoResponse(EvilCastleRogueLikeAllUserScoreInfoResponse other)
		: this()
	{
		allUserTotalScore_ = other.allUserTotalScore_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleRogueLikeAllUserScoreInfoResponse Clone()
	{
		return new EvilCastleRogueLikeAllUserScoreInfoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EvilCastleRogueLikeAllUserScoreInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EvilCastleRogueLikeAllUserScoreInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (AllUserTotalScore == other.AllUserTotalScore)
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
		if (AllUserTotalScore != 0L)
		{
			num ^= AllUserTotalScore.GetHashCode();
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
		if (AllUserTotalScore != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(AllUserTotalScore);
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
		if (AllUserTotalScore != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(AllUserTotalScore);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EvilCastleRogueLikeAllUserScoreInfoResponse other)
	{
		if (other != null)
		{
			if (other.AllUserTotalScore != 0L)
			{
				AllUserTotalScore = other.AllUserTotalScore;
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
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				AllUserTotalScore = input.ReadInt64();
			}
		}
	}
}
