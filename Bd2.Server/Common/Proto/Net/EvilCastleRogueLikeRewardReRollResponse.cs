using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EvilCastleRogueLikeRewardReRollResponse : IMessage<EvilCastleRogueLikeRewardReRollResponse>, IMessage, IEquatable<EvilCastleRogueLikeRewardReRollResponse>, IDeepCloneable<EvilCastleRogueLikeRewardReRollResponse>, IBufferMessage
{
	private static readonly MessageParser<EvilCastleRogueLikeRewardReRollResponse> _parser = new MessageParser<EvilCastleRogueLikeRewardReRollResponse>(() => new EvilCastleRogueLikeRewardReRollResponse());

	private UnknownFieldSet _unknownFields;

	public const int CountFieldNumber = 1;

	private int count_;

	public const int ChoiceInfoFieldNumber = 2;

	private EvilCastleRogueLikeChoiceInfo choiceInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EvilCastleRogueLikeRewardReRollResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EvilCastleRogueLikeRewardReRollResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Count
	{
		get
		{
			return count_;
		}
		set
		{
			count_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleRogueLikeChoiceInfo ChoiceInfo
	{
		get
		{
			return choiceInfo_;
		}
		set
		{
			choiceInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleRogueLikeRewardReRollResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeRewardReRollResponse(EvilCastleRogueLikeRewardReRollResponse other)
		: this()
	{
		count_ = other.count_;
		choiceInfo_ = ((other.choiceInfo_ != null) ? other.choiceInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeRewardReRollResponse Clone()
	{
		return new EvilCastleRogueLikeRewardReRollResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EvilCastleRogueLikeRewardReRollResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EvilCastleRogueLikeRewardReRollResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Count == other.Count && object.Equals(ChoiceInfo, other.ChoiceInfo))
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
		if (Count != 0)
		{
			num ^= Count.GetHashCode();
		}
		if (choiceInfo_ != null)
		{
			num ^= ChoiceInfo.GetHashCode();
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
		if (Count != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Count);
		}
		if (choiceInfo_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(ChoiceInfo);
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
		if (Count != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Count);
		}
		if (choiceInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ChoiceInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EvilCastleRogueLikeRewardReRollResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Count != 0)
		{
			Count = other.Count;
		}
		if (other.choiceInfo_ != null)
		{
			if (choiceInfo_ == null)
			{
				ChoiceInfo = new EvilCastleRogueLikeChoiceInfo();
			}
			ChoiceInfo.MergeFrom(other.ChoiceInfo);
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
				if (choiceInfo_ == null)
				{
					ChoiceInfo = new EvilCastleRogueLikeChoiceInfo();
				}
				input.ReadMessage(ChoiceInfo);
				break;
			case 8u:
				Count = input.ReadInt32();
				break;
			}
		}
	}
}
