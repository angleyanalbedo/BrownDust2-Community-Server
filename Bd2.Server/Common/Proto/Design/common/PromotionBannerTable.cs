using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class PromotionBannerTable : IMessage<PromotionBannerTable>, IMessage, IEquatable<PromotionBannerTable>, IDeepCloneable<PromotionBannerTable>, IBufferMessage
{
	private static readonly MessageParser<PromotionBannerTable> _parser = new MessageParser<PromotionBannerTable>(() => new PromotionBannerTable());

	private UnknownFieldSet _unknownFields;

	public const int BannerCategoryFieldNumber = 1;

	private int bannerCategory_;

	public const int BannerFontLocalTextIdFieldNumber = 2;

	private int bannerFontLocalTextId_;

	public const int BannerNameFieldNumber = 3;

	private string bannerName_ = "";

	public const int IdFieldNumber = 4;

	private int id_;

	public const int MagicGroupIdFieldNumber = 5;

	private int magicGroupId_;

	public const int MagicIdFieldNumber = 6;

	private int magicId_;

	public const int OrderIdFieldNumber = 7;

	private int orderId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PromotionBannerTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PromotionBannerTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BannerCategory
	{
		get
		{
			return bannerCategory_;
		}
		set
		{
			bannerCategory_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BannerFontLocalTextId
	{
		get
		{
			return bannerFontLocalTextId_;
		}
		set
		{
			bannerFontLocalTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string BannerName
	{
		get
		{
			return bannerName_;
		}
		set
		{
			bannerName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MagicGroupId
	{
		get
		{
			return magicGroupId_;
		}
		set
		{
			magicGroupId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MagicId
	{
		get
		{
			return magicId_;
		}
		set
		{
			magicId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int OrderId
	{
		get
		{
			return orderId_;
		}
		set
		{
			orderId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PromotionBannerTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PromotionBannerTable(PromotionBannerTable other)
		: this()
	{
		bannerCategory_ = other.bannerCategory_;
		bannerFontLocalTextId_ = other.bannerFontLocalTextId_;
		bannerName_ = other.bannerName_;
		id_ = other.id_;
		magicGroupId_ = other.magicGroupId_;
		magicId_ = other.magicId_;
		orderId_ = other.orderId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PromotionBannerTable Clone()
	{
		return new PromotionBannerTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PromotionBannerTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PromotionBannerTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (BannerCategory == other.BannerCategory && BannerFontLocalTextId == other.BannerFontLocalTextId && !(BannerName != other.BannerName) && Id == other.Id && MagicGroupId == other.MagicGroupId && MagicId == other.MagicId && OrderId == other.OrderId)
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
		if (BannerCategory != 0)
		{
			num ^= BannerCategory.GetHashCode();
		}
		if (BannerFontLocalTextId != 0)
		{
			num ^= BannerFontLocalTextId.GetHashCode();
		}
		if (BannerName.Length != 0)
		{
			num ^= BannerName.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (MagicGroupId != 0)
		{
			num ^= MagicGroupId.GetHashCode();
		}
		if (MagicId != 0)
		{
			num ^= MagicId.GetHashCode();
		}
		if (OrderId != 0)
		{
			num ^= OrderId.GetHashCode();
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
		if (BannerCategory != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BannerCategory);
		}
		if (BannerFontLocalTextId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BannerFontLocalTextId);
		}
		if (BannerName.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(BannerName);
		}
		if (Id != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Id);
		}
		if (MagicGroupId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(MagicGroupId);
		}
		if (MagicId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(MagicId);
		}
		if (OrderId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(OrderId);
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
		if (BannerCategory != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BannerCategory);
		}
		if (BannerFontLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BannerFontLocalTextId);
		}
		if (BannerName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BannerName);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (MagicGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MagicGroupId);
		}
		if (MagicId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MagicId);
		}
		if (OrderId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OrderId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PromotionBannerTable other)
	{
		if (other != null)
		{
			if (other.BannerCategory != 0)
			{
				BannerCategory = other.BannerCategory;
			}
			if (other.BannerFontLocalTextId != 0)
			{
				BannerFontLocalTextId = other.BannerFontLocalTextId;
			}
			if (other.BannerName.Length != 0)
			{
				BannerName = other.BannerName;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.MagicGroupId != 0)
			{
				MagicGroupId = other.MagicGroupId;
			}
			if (other.MagicId != 0)
			{
				MagicId = other.MagicId;
			}
			if (other.OrderId != 0)
			{
				OrderId = other.OrderId;
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
			case 8u:
				BannerCategory = input.ReadInt32();
				break;
			case 16u:
				BannerFontLocalTextId = input.ReadInt32();
				break;
			case 26u:
				BannerName = input.ReadString();
				break;
			case 32u:
				Id = input.ReadInt32();
				break;
			case 40u:
				MagicGroupId = input.ReadInt32();
				break;
			case 48u:
				MagicId = input.ReadInt32();
				break;
			case 56u:
				OrderId = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
