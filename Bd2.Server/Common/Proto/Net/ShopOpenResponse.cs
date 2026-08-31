using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class ShopOpenResponse : IMessage<ShopOpenResponse>, IMessage, IEquatable<ShopOpenResponse>, IDeepCloneable<ShopOpenResponse>, IBufferMessage
{
	private static readonly MessageParser<ShopOpenResponse> _parser = new MessageParser<ShopOpenResponse>(() => new ShopOpenResponse());

	private UnknownFieldSet _unknownFields;

	public const int ReputationStateFieldNumber = 1;

	private int reputationState_;

	public const int IsTalentSkillDiscountFieldNumber = 2;

	private bool isTalentSkillDiscount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ShopOpenResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ShopOpenResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ReputationState
	{
		get
		{
			return reputationState_;
		}
		set
		{
			reputationState_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsTalentSkillDiscount
	{
		get
		{
			return isTalentSkillDiscount_;
		}
		set
		{
			isTalentSkillDiscount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ShopOpenResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShopOpenResponse(ShopOpenResponse other)
		: this()
	{
		reputationState_ = other.reputationState_;
		isTalentSkillDiscount_ = other.isTalentSkillDiscount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShopOpenResponse Clone()
	{
		return new ShopOpenResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as ShopOpenResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ShopOpenResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (ReputationState == other.ReputationState && IsTalentSkillDiscount == other.IsTalentSkillDiscount)
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
		if (ReputationState != 0)
		{
			num ^= ReputationState.GetHashCode();
		}
		if (IsTalentSkillDiscount)
		{
			num ^= IsTalentSkillDiscount.GetHashCode();
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
		if (ReputationState != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ReputationState);
		}
		if (IsTalentSkillDiscount)
		{
			output.WriteRawTag(16);
			output.WriteBool(IsTalentSkillDiscount);
		}
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
		if (ReputationState != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ReputationState);
		}
		if (IsTalentSkillDiscount)
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
	public void MergeFrom(ShopOpenResponse other)
	{
		if (other != null)
		{
			if (other.ReputationState != 0)
			{
				ReputationState = other.ReputationState;
			}
			if (other.IsTalentSkillDiscount)
			{
				IsTalentSkillDiscount = other.IsTalentSkillDiscount;
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
			case 16u:
				IsTalentSkillDiscount = input.ReadBool();
				break;
			case 8u:
				ReputationState = input.ReadInt32();
				break;
			}
		}
	}
}
