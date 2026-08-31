using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MiniGameFieldScoreResponse : IMessage<MiniGameFieldScoreResponse>, IMessage, IEquatable<MiniGameFieldScoreResponse>, IDeepCloneable<MiniGameFieldScoreResponse>, IBufferMessage
{
	private static readonly MessageParser<MiniGameFieldScoreResponse> _parser = new MessageParser<MiniGameFieldScoreResponse>(() => new MiniGameFieldScoreResponse());

	private UnknownFieldSet _unknownFields;

	public const int CurrentScoreFieldNumber = 1;

	private int currentScore_;

	public const int CurrentHpFieldNumber = 2;

	private int currentHp_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MiniGameFieldScoreResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MiniGameFieldScoreResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CurrentScore
	{
		get
		{
			return currentScore_;
		}
		set
		{
			currentScore_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CurrentHp
	{
		get
		{
			return currentHp_;
		}
		set
		{
			currentHp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameFieldScoreResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameFieldScoreResponse(MiniGameFieldScoreResponse other)
		: this()
	{
		currentScore_ = other.currentScore_;
		currentHp_ = other.currentHp_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MiniGameFieldScoreResponse Clone()
	{
		return new MiniGameFieldScoreResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as MiniGameFieldScoreResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MiniGameFieldScoreResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (CurrentScore == other.CurrentScore && CurrentHp == other.CurrentHp)
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
		if (CurrentScore != 0)
		{
			num ^= CurrentScore.GetHashCode();
		}
		if (CurrentHp != 0)
		{
			num ^= CurrentHp.GetHashCode();
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
		if (CurrentScore != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(CurrentScore);
		}
		if (CurrentHp != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(CurrentHp);
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
		if (CurrentScore != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CurrentScore);
		}
		if (CurrentHp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CurrentHp);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MiniGameFieldScoreResponse other)
	{
		if (other != null)
		{
			if (other.CurrentScore != 0)
			{
				CurrentScore = other.CurrentScore;
			}
			if (other.CurrentHp != 0)
			{
				CurrentHp = other.CurrentHp;
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 16u:
				CurrentHp = input.ReadInt32();
				break;
			case 8u:
				CurrentScore = input.ReadInt32();
				break;
			}
		}
	}
}
