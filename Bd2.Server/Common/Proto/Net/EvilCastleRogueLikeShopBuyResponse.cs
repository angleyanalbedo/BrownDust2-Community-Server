using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EvilCastleRogueLikeShopBuyResponse : IMessage<EvilCastleRogueLikeShopBuyResponse>, IMessage, IEquatable<EvilCastleRogueLikeShopBuyResponse>, IDeepCloneable<EvilCastleRogueLikeShopBuyResponse>, IBufferMessage
{
	private static readonly MessageParser<EvilCastleRogueLikeShopBuyResponse> _parser = new MessageParser<EvilCastleRogueLikeShopBuyResponse>(() => new EvilCastleRogueLikeShopBuyResponse());

	private UnknownFieldSet _unknownFields;

	public const int CharInfoFieldNumber = 1;

	private static readonly FieldCodec<CharDBInfo> _repeated_charInfo_codec = FieldCodec.ForMessage(10u, CharDBInfo.Parser);

	private readonly RepeatedField<CharDBInfo> charInfo_ = new RepeatedField<CharDBInfo>();

	public const int CostumeInfoFieldNumber = 2;

	private CostumeDBInfo costumeInfo_;

	public const int RelicInfoFieldNumber = 3;

	private RelicDBInfo relicInfo_;

	public const int UsedGoldFieldNumber = 4;

	private int usedGold_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EvilCastleRogueLikeShopBuyResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EvilCastleRogueLikeShopBuyResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CharDBInfo> CharInfo => charInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CostumeDBInfo CostumeInfo
	{
		get
		{
			return costumeInfo_;
		}
		set
		{
			costumeInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicDBInfo RelicInfo
	{
		get
		{
			return relicInfo_;
		}
		set
		{
			relicInfo_ = value;
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
	public EvilCastleRogueLikeShopBuyResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeShopBuyResponse(EvilCastleRogueLikeShopBuyResponse other)
		: this()
	{
		charInfo_ = other.charInfo_.Clone();
		costumeInfo_ = ((other.costumeInfo_ != null) ? other.costumeInfo_.Clone() : null);
		relicInfo_ = ((other.relicInfo_ != null) ? other.relicInfo_.Clone() : null);
		usedGold_ = other.usedGold_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeShopBuyResponse Clone()
	{
		return new EvilCastleRogueLikeShopBuyResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EvilCastleRogueLikeShopBuyResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EvilCastleRogueLikeShopBuyResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (charInfo_.Equals(other.charInfo_) && object.Equals(CostumeInfo, other.CostumeInfo) && object.Equals(RelicInfo, other.RelicInfo) && UsedGold == other.UsedGold)
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
		num ^= charInfo_.GetHashCode();
		if (costumeInfo_ != null)
		{
			num ^= CostumeInfo.GetHashCode();
		}
		if (relicInfo_ != null)
		{
			num ^= RelicInfo.GetHashCode();
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
		charInfo_.WriteTo(ref output, _repeated_charInfo_codec);
		if (costumeInfo_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(CostumeInfo);
		}
		if (relicInfo_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(RelicInfo);
		}
		if (UsedGold != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(UsedGold);
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
		num += charInfo_.CalculateSize(_repeated_charInfo_codec);
		if (costumeInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CostumeInfo);
		}
		if (relicInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RelicInfo);
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(EvilCastleRogueLikeShopBuyResponse other)
	{
		if (other == null)
		{
			return;
		}
		charInfo_.Add(other.charInfo_);
		if (other.costumeInfo_ != null)
		{
			if (costumeInfo_ == null)
			{
				CostumeInfo = new CostumeDBInfo();
			}
			CostumeInfo.MergeFrom(other.CostumeInfo);
		}
		if (other.relicInfo_ != null)
		{
			if (relicInfo_ == null)
			{
				RelicInfo = new RelicDBInfo();
			}
			RelicInfo.MergeFrom(other.RelicInfo);
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			case 10u:
				charInfo_.AddEntriesFrom(ref input, _repeated_charInfo_codec);
				break;
			case 18u:
				if (costumeInfo_ == null)
				{
					CostumeInfo = new CostumeDBInfo();
				}
				input.ReadMessage(CostumeInfo);
				break;
			case 26u:
				if (relicInfo_ == null)
				{
					RelicInfo = new RelicDBInfo();
				}
				input.ReadMessage(RelicInfo);
				break;
			case 32u:
				UsedGold = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
