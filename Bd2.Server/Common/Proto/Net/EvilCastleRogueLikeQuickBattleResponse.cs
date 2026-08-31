using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EvilCastleRogueLikeQuickBattleResponse : IMessage<EvilCastleRogueLikeQuickBattleResponse>, IMessage, IEquatable<EvilCastleRogueLikeQuickBattleResponse>, IDeepCloneable<EvilCastleRogueLikeQuickBattleResponse>, IBufferMessage
{
	private static readonly MessageParser<EvilCastleRogueLikeQuickBattleResponse> _parser = new MessageParser<EvilCastleRogueLikeQuickBattleResponse>(() => new EvilCastleRogueLikeQuickBattleResponse());

	private UnknownFieldSet _unknownFields;

	public const int ScoreInfoFieldNumber = 1;

	private EvilCastleRogueLikeScoreInfo scoreInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EvilCastleRogueLikeQuickBattleResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EvilCastleRogueLikeQuickBattleResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleRogueLikeScoreInfo ScoreInfo
	{
		get
		{
			return scoreInfo_;
		}
		set
		{
			scoreInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeQuickBattleResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeQuickBattleResponse(EvilCastleRogueLikeQuickBattleResponse other)
		: this()
	{
		scoreInfo_ = ((other.scoreInfo_ != null) ? other.scoreInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleRogueLikeQuickBattleResponse Clone()
	{
		return new EvilCastleRogueLikeQuickBattleResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EvilCastleRogueLikeQuickBattleResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EvilCastleRogueLikeQuickBattleResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(ScoreInfo, other.ScoreInfo))
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
		if (scoreInfo_ != null)
		{
			num ^= ScoreInfo.GetHashCode();
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
		if (scoreInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(ScoreInfo);
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
		if (scoreInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ScoreInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(EvilCastleRogueLikeQuickBattleResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.scoreInfo_ != null)
		{
			if (scoreInfo_ == null)
			{
				ScoreInfo = new EvilCastleRogueLikeScoreInfo();
			}
			ScoreInfo.MergeFrom(other.ScoreInfo);
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (scoreInfo_ == null)
			{
				ScoreInfo = new EvilCastleRogueLikeScoreInfo();
			}
			input.ReadMessage(ScoreInfo);
		}
	}
}
