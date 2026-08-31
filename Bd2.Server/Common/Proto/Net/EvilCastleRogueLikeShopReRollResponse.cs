using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EvilCastleRogueLikeShopReRollResponse : IMessage<EvilCastleRogueLikeShopReRollResponse>, IMessage, IEquatable<EvilCastleRogueLikeShopReRollResponse>, IDeepCloneable<EvilCastleRogueLikeShopReRollResponse>, IBufferMessage
{
	private static readonly MessageParser<EvilCastleRogueLikeShopReRollResponse> _parser = new MessageParser<EvilCastleRogueLikeShopReRollResponse>(() => new EvilCastleRogueLikeShopReRollResponse());

	private UnknownFieldSet _unknownFields;

	public const int ShopInfoFieldNumber = 1;

	private EvilCastleRogueLikeShopDBInfo shopInfo_;

	public const int UsedGoldFieldNumber = 2;

	private int usedGold_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EvilCastleRogueLikeShopReRollResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EvilCastleRogueLikeShopReRollResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeShopDBInfo ShopInfo
	{
		get
		{
			return shopInfo_;
		}
		set
		{
			shopInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int UsedGold
	{
		get
		{
			return usedGold_;
		}
		set
		{
			usedGold_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeShopReRollResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeShopReRollResponse(EvilCastleRogueLikeShopReRollResponse other)
		: this()
	{
		shopInfo_ = ((other.shopInfo_ != null) ? other.shopInfo_.Clone() : null);
		usedGold_ = other.usedGold_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeShopReRollResponse Clone()
	{
		return new EvilCastleRogueLikeShopReRollResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EvilCastleRogueLikeShopReRollResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EvilCastleRogueLikeShopReRollResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(ShopInfo, other.ShopInfo) && UsedGold == other.UsedGold)
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
		if (shopInfo_ != null)
		{
			num ^= ShopInfo.GetHashCode();
		}
		if (UsedGold != 0)
		{
			num ^= UsedGold.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (shopInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(ShopInfo);
		}
		if (UsedGold != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(UsedGold);
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
		if (shopInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ShopInfo);
		}
		if (UsedGold != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UsedGold);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EvilCastleRogueLikeShopReRollResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.shopInfo_ != null)
		{
			if (shopInfo_ == null)
			{
				ShopInfo = new EvilCastleRogueLikeShopDBInfo();
			}
			ShopInfo.MergeFrom(other.ShopInfo);
		}
		if (other.UsedGold != 0)
		{
			UsedGold = other.UsedGold;
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
			case 16u:
				UsedGold = input.ReadInt32();
				break;
			case 10u:
				if (shopInfo_ == null)
				{
					ShopInfo = new EvilCastleRogueLikeShopDBInfo();
				}
				input.ReadMessage(ShopInfo);
				break;
			}
		}
	}
}
