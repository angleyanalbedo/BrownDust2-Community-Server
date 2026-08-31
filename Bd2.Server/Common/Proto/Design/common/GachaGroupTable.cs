using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class GachaGroupTable : IMessage<GachaGroupTable>, IMessage, IEquatable<GachaGroupTable>, IDeepCloneable<GachaGroupTable>, IBufferMessage
{
	private static readonly MessageParser<GachaGroupTable> _parser = new MessageParser<GachaGroupTable>(() => new GachaGroupTable());

	private UnknownFieldSet _unknownFields;

	public const int BannerFontLocalTextIdFieldNumber = 1;

	private int bannerFontLocalTextId_;

	public const int BuyLimitCountFieldNumber = 2;

	private int buyLimitCount_;

	public const int DescLocalTextIdFieldNumber = 3;

	private int descLocalTextId_;

	public const int EndGetItemCountFieldNumber = 4;

	private int endGetItemCount_;

	public const int EndGetItemIdFieldNumber = 5;

	private int endGetItemId_;

	public const int EndGetItemTypeFieldNumber = 6;

	private int endGetItemType_;

	public const int FixedIdFieldNumber = 7;

	private int fixedId_;

	public const int GachaBannerBgFieldNumber = 8;

	private string gachaBannerBg_ = "";

	public const int GachaBannerImageFieldNumber = 9;

	private string gachaBannerImage_ = "";

	public const int GachaNameTextIdFieldNumber = 10;

	private int gachaNameTextId_;

	public const int GachaSpineBgFieldNumber = 11;

	private string gachaSpineBg_ = "";

	public const int GachaSubTypeFieldNumber = 12;

	private int gachaSubType_;

	public const int GachaTypeFieldNumber = 13;

	private int gachaType_;

	public const int IdFieldNumber = 14;

	private int id_;

	public const int IsDisplayUiOwnGachaTicketFieldNumber = 15;

	private int isDisplayUiOwnGachaTicket_;

	public const int OneTimeGachaIdFieldNumber = 16;

	private int oneTimeGachaId_;

	public const int PickUpExchangeCostFieldNumber = 17;

	private int pickUpExchangeCost_;

	public const int PickUpItemIdFieldNumber = 18;

	private int pickUpItemId_;

	public const int PointCountFieldNumber = 19;

	private int pointCount_;

	public const int ScheduleTypeFieldNumber = 20;

	private int scheduleType_;

	public const int SelectCountFieldNumber = 21;

	private int selectCount_;

	public const int SelectionChoiceRateFieldNumber = 22;

	private int selectionChoiceRate_;

	public const int SortIdFieldNumber = 23;

	private int sortId_;

	public const int TenTimeGachaIdFieldNumber = 24;

	private int tenTimeGachaId_;

	public const int UseAccumulateRateLogFieldNumber = 25;

	private int useAccumulateRateLog_;

	public const int UseGachaTicketOptionFieldNumber = 26;

	private int useGachaTicketOption_;

	public const int UseSelectionOnlyFixedApplyFieldNumber = 27;

	private int useSelectionOnlyFixedApply_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GachaGroupTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GachaGroupTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public int BuyLimitCount
	{
		get
		{
			return buyLimitCount_;
		}
		set
		{
			buyLimitCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DescLocalTextId
	{
		get
		{
			return descLocalTextId_;
		}
		set
		{
			descLocalTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EndGetItemCount
	{
		get
		{
			return endGetItemCount_;
		}
		set
		{
			endGetItemCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EndGetItemId
	{
		get
		{
			return endGetItemId_;
		}
		set
		{
			endGetItemId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int EndGetItemType
	{
		get
		{
			return endGetItemType_;
		}
		set
		{
			endGetItemType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FixedId
	{
		get
		{
			return fixedId_;
		}
		set
		{
			fixedId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string GachaBannerBg
	{
		get
		{
			return gachaBannerBg_;
		}
		set
		{
			gachaBannerBg_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string GachaBannerImage
	{
		get
		{
			return gachaBannerImage_;
		}
		set
		{
			gachaBannerImage_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GachaNameTextId
	{
		get
		{
			return gachaNameTextId_;
		}
		set
		{
			gachaNameTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string GachaSpineBg
	{
		get
		{
			return gachaSpineBg_;
		}
		set
		{
			gachaSpineBg_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int GachaSubType
	{
		get
		{
			return gachaSubType_;
		}
		set
		{
			gachaSubType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GachaType
	{
		get
		{
			return gachaType_;
		}
		set
		{
			gachaType_ = value;
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int IsDisplayUiOwnGachaTicket
	{
		get
		{
			return isDisplayUiOwnGachaTicket_;
		}
		set
		{
			isDisplayUiOwnGachaTicket_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int OneTimeGachaId
	{
		get
		{
			return oneTimeGachaId_;
		}
		set
		{
			oneTimeGachaId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PickUpExchangeCost
	{
		get
		{
			return pickUpExchangeCost_;
		}
		set
		{
			pickUpExchangeCost_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PickUpItemId
	{
		get
		{
			return pickUpItemId_;
		}
		set
		{
			pickUpItemId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PointCount
	{
		get
		{
			return pointCount_;
		}
		set
		{
			pointCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ScheduleType
	{
		get
		{
			return scheduleType_;
		}
		set
		{
			scheduleType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SelectCount
	{
		get
		{
			return selectCount_;
		}
		set
		{
			selectCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SelectionChoiceRate
	{
		get
		{
			return selectionChoiceRate_;
		}
		set
		{
			selectionChoiceRate_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SortId
	{
		get
		{
			return sortId_;
		}
		set
		{
			sortId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TenTimeGachaId
	{
		get
		{
			return tenTimeGachaId_;
		}
		set
		{
			tenTimeGachaId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int UseAccumulateRateLog
	{
		get
		{
			return useAccumulateRateLog_;
		}
		set
		{
			useAccumulateRateLog_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int UseGachaTicketOption
	{
		get
		{
			return useGachaTicketOption_;
		}
		set
		{
			useGachaTicketOption_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int UseSelectionOnlyFixedApply
	{
		get
		{
			return useSelectionOnlyFixedApply_;
		}
		set
		{
			useSelectionOnlyFixedApply_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GachaGroupTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaGroupTable(GachaGroupTable other)
		: this()
	{
		bannerFontLocalTextId_ = other.bannerFontLocalTextId_;
		buyLimitCount_ = other.buyLimitCount_;
		descLocalTextId_ = other.descLocalTextId_;
		endGetItemCount_ = other.endGetItemCount_;
		endGetItemId_ = other.endGetItemId_;
		endGetItemType_ = other.endGetItemType_;
		fixedId_ = other.fixedId_;
		gachaBannerBg_ = other.gachaBannerBg_;
		gachaBannerImage_ = other.gachaBannerImage_;
		gachaNameTextId_ = other.gachaNameTextId_;
		gachaSpineBg_ = other.gachaSpineBg_;
		gachaSubType_ = other.gachaSubType_;
		gachaType_ = other.gachaType_;
		id_ = other.id_;
		isDisplayUiOwnGachaTicket_ = other.isDisplayUiOwnGachaTicket_;
		oneTimeGachaId_ = other.oneTimeGachaId_;
		pickUpExchangeCost_ = other.pickUpExchangeCost_;
		pickUpItemId_ = other.pickUpItemId_;
		pointCount_ = other.pointCount_;
		scheduleType_ = other.scheduleType_;
		selectCount_ = other.selectCount_;
		selectionChoiceRate_ = other.selectionChoiceRate_;
		sortId_ = other.sortId_;
		tenTimeGachaId_ = other.tenTimeGachaId_;
		useAccumulateRateLog_ = other.useAccumulateRateLog_;
		useGachaTicketOption_ = other.useGachaTicketOption_;
		useSelectionOnlyFixedApply_ = other.useSelectionOnlyFixedApply_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GachaGroupTable Clone()
	{
		return new GachaGroupTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GachaGroupTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GachaGroupTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (BannerFontLocalTextId == other.BannerFontLocalTextId && BuyLimitCount == other.BuyLimitCount && DescLocalTextId == other.DescLocalTextId && EndGetItemCount == other.EndGetItemCount && EndGetItemId == other.EndGetItemId && EndGetItemType == other.EndGetItemType && FixedId == other.FixedId && !(GachaBannerBg != other.GachaBannerBg) && !(GachaBannerImage != other.GachaBannerImage) && GachaNameTextId == other.GachaNameTextId && !(GachaSpineBg != other.GachaSpineBg) && GachaSubType == other.GachaSubType && GachaType == other.GachaType && Id == other.Id && IsDisplayUiOwnGachaTicket == other.IsDisplayUiOwnGachaTicket && OneTimeGachaId == other.OneTimeGachaId && PickUpExchangeCost == other.PickUpExchangeCost && PickUpItemId == other.PickUpItemId && PointCount == other.PointCount && ScheduleType == other.ScheduleType && SelectCount == other.SelectCount && SelectionChoiceRate == other.SelectionChoiceRate && SortId == other.SortId && TenTimeGachaId == other.TenTimeGachaId && UseAccumulateRateLog == other.UseAccumulateRateLog && UseGachaTicketOption == other.UseGachaTicketOption && UseSelectionOnlyFixedApply == other.UseSelectionOnlyFixedApply)
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
		if (BannerFontLocalTextId != 0)
		{
			num ^= BannerFontLocalTextId.GetHashCode();
		}
		if (BuyLimitCount != 0)
		{
			num ^= BuyLimitCount.GetHashCode();
		}
		if (DescLocalTextId != 0)
		{
			num ^= DescLocalTextId.GetHashCode();
		}
		if (EndGetItemCount != 0)
		{
			num ^= EndGetItemCount.GetHashCode();
		}
		if (EndGetItemId != 0)
		{
			num ^= EndGetItemId.GetHashCode();
		}
		if (EndGetItemType != 0)
		{
			num ^= EndGetItemType.GetHashCode();
		}
		if (FixedId != 0)
		{
			num ^= FixedId.GetHashCode();
		}
		if (GachaBannerBg.Length != 0)
		{
			num ^= GachaBannerBg.GetHashCode();
		}
		if (GachaBannerImage.Length != 0)
		{
			num ^= GachaBannerImage.GetHashCode();
		}
		if (GachaNameTextId != 0)
		{
			num ^= GachaNameTextId.GetHashCode();
		}
		if (GachaSpineBg.Length != 0)
		{
			num ^= GachaSpineBg.GetHashCode();
		}
		if (GachaSubType != 0)
		{
			num ^= GachaSubType.GetHashCode();
		}
		if (GachaType != 0)
		{
			num ^= GachaType.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (IsDisplayUiOwnGachaTicket != 0)
		{
			num ^= IsDisplayUiOwnGachaTicket.GetHashCode();
		}
		if (OneTimeGachaId != 0)
		{
			num ^= OneTimeGachaId.GetHashCode();
		}
		if (PickUpExchangeCost != 0)
		{
			num ^= PickUpExchangeCost.GetHashCode();
		}
		if (PickUpItemId != 0)
		{
			num ^= PickUpItemId.GetHashCode();
		}
		if (PointCount != 0)
		{
			num ^= PointCount.GetHashCode();
		}
		if (ScheduleType != 0)
		{
			num ^= ScheduleType.GetHashCode();
		}
		if (SelectCount != 0)
		{
			num ^= SelectCount.GetHashCode();
		}
		if (SelectionChoiceRate != 0)
		{
			num ^= SelectionChoiceRate.GetHashCode();
		}
		if (SortId != 0)
		{
			num ^= SortId.GetHashCode();
		}
		if (TenTimeGachaId != 0)
		{
			num ^= TenTimeGachaId.GetHashCode();
		}
		if (UseAccumulateRateLog != 0)
		{
			num ^= UseAccumulateRateLog.GetHashCode();
		}
		if (UseGachaTicketOption != 0)
		{
			num ^= UseGachaTicketOption.GetHashCode();
		}
		if (UseSelectionOnlyFixedApply != 0)
		{
			num ^= UseSelectionOnlyFixedApply.GetHashCode();
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
		if (BannerFontLocalTextId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BannerFontLocalTextId);
		}
		if (BuyLimitCount != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BuyLimitCount);
		}
		if (DescLocalTextId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(DescLocalTextId);
		}
		if (EndGetItemCount != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(EndGetItemCount);
		}
		if (EndGetItemId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(EndGetItemId);
		}
		if (EndGetItemType != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(EndGetItemType);
		}
		if (FixedId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(FixedId);
		}
		if (GachaBannerBg.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(GachaBannerBg);
		}
		if (GachaBannerImage.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(GachaBannerImage);
		}
		if (GachaNameTextId != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(GachaNameTextId);
		}
		if (GachaSpineBg.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(GachaSpineBg);
		}
		if (GachaSubType != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(GachaSubType);
		}
		if (GachaType != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(GachaType);
		}
		if (Id != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(Id);
		}
		if (IsDisplayUiOwnGachaTicket != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(IsDisplayUiOwnGachaTicket);
		}
		if (OneTimeGachaId != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(OneTimeGachaId);
		}
		if (PickUpExchangeCost != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(PickUpExchangeCost);
		}
		if (PickUpItemId != 0)
		{
			output.WriteRawTag(144, 1);
			output.WriteInt32(PickUpItemId);
		}
		if (PointCount != 0)
		{
			output.WriteRawTag(152, 1);
			output.WriteInt32(PointCount);
		}
		if (ScheduleType != 0)
		{
			output.WriteRawTag(160, 1);
			output.WriteInt32(ScheduleType);
		}
		if (SelectCount != 0)
		{
			output.WriteRawTag(168, 1);
			output.WriteInt32(SelectCount);
		}
		if (SelectionChoiceRate != 0)
		{
			output.WriteRawTag(176, 1);
			output.WriteInt32(SelectionChoiceRate);
		}
		if (SortId != 0)
		{
			output.WriteRawTag(184, 1);
			output.WriteInt32(SortId);
		}
		if (TenTimeGachaId != 0)
		{
			output.WriteRawTag(192, 1);
			output.WriteInt32(TenTimeGachaId);
		}
		if (UseAccumulateRateLog != 0)
		{
			output.WriteRawTag(200, 1);
			output.WriteInt32(UseAccumulateRateLog);
		}
		if (UseGachaTicketOption != 0)
		{
			output.WriteRawTag(208, 1);
			output.WriteInt32(UseGachaTicketOption);
		}
		if (UseSelectionOnlyFixedApply != 0)
		{
			output.WriteRawTag(216, 1);
			output.WriteInt32(UseSelectionOnlyFixedApply);
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
		if (BannerFontLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BannerFontLocalTextId);
		}
		if (BuyLimitCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuyLimitCount);
		}
		if (DescLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DescLocalTextId);
		}
		if (EndGetItemCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EndGetItemCount);
		}
		if (EndGetItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EndGetItemId);
		}
		if (EndGetItemType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EndGetItemType);
		}
		if (FixedId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FixedId);
		}
		if (GachaBannerBg.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GachaBannerBg);
		}
		if (GachaBannerImage.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GachaBannerImage);
		}
		if (GachaNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GachaNameTextId);
		}
		if (GachaSpineBg.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GachaSpineBg);
		}
		if (GachaSubType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GachaSubType);
		}
		if (GachaType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GachaType);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (IsDisplayUiOwnGachaTicket != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IsDisplayUiOwnGachaTicket);
		}
		if (OneTimeGachaId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(OneTimeGachaId);
		}
		if (PickUpExchangeCost != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PickUpExchangeCost);
		}
		if (PickUpItemId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PickUpItemId);
		}
		if (PointCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PointCount);
		}
		if (ScheduleType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ScheduleType);
		}
		if (SelectCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SelectCount);
		}
		if (SelectionChoiceRate != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SelectionChoiceRate);
		}
		if (SortId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SortId);
		}
		if (TenTimeGachaId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TenTimeGachaId);
		}
		if (UseAccumulateRateLog != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(UseAccumulateRateLog);
		}
		if (UseGachaTicketOption != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(UseGachaTicketOption);
		}
		if (UseSelectionOnlyFixedApply != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(UseSelectionOnlyFixedApply);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GachaGroupTable other)
	{
		if (other != null)
		{
			if (other.BannerFontLocalTextId != 0)
			{
				BannerFontLocalTextId = other.BannerFontLocalTextId;
			}
			if (other.BuyLimitCount != 0)
			{
				BuyLimitCount = other.BuyLimitCount;
			}
			if (other.DescLocalTextId != 0)
			{
				DescLocalTextId = other.DescLocalTextId;
			}
			if (other.EndGetItemCount != 0)
			{
				EndGetItemCount = other.EndGetItemCount;
			}
			if (other.EndGetItemId != 0)
			{
				EndGetItemId = other.EndGetItemId;
			}
			if (other.EndGetItemType != 0)
			{
				EndGetItemType = other.EndGetItemType;
			}
			if (other.FixedId != 0)
			{
				FixedId = other.FixedId;
			}
			if (other.GachaBannerBg.Length != 0)
			{
				GachaBannerBg = other.GachaBannerBg;
			}
			if (other.GachaBannerImage.Length != 0)
			{
				GachaBannerImage = other.GachaBannerImage;
			}
			if (other.GachaNameTextId != 0)
			{
				GachaNameTextId = other.GachaNameTextId;
			}
			if (other.GachaSpineBg.Length != 0)
			{
				GachaSpineBg = other.GachaSpineBg;
			}
			if (other.GachaSubType != 0)
			{
				GachaSubType = other.GachaSubType;
			}
			if (other.GachaType != 0)
			{
				GachaType = other.GachaType;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.IsDisplayUiOwnGachaTicket != 0)
			{
				IsDisplayUiOwnGachaTicket = other.IsDisplayUiOwnGachaTicket;
			}
			if (other.OneTimeGachaId != 0)
			{
				OneTimeGachaId = other.OneTimeGachaId;
			}
			if (other.PickUpExchangeCost != 0)
			{
				PickUpExchangeCost = other.PickUpExchangeCost;
			}
			if (other.PickUpItemId != 0)
			{
				PickUpItemId = other.PickUpItemId;
			}
			if (other.PointCount != 0)
			{
				PointCount = other.PointCount;
			}
			if (other.ScheduleType != 0)
			{
				ScheduleType = other.ScheduleType;
			}
			if (other.SelectCount != 0)
			{
				SelectCount = other.SelectCount;
			}
			if (other.SelectionChoiceRate != 0)
			{
				SelectionChoiceRate = other.SelectionChoiceRate;
			}
			if (other.SortId != 0)
			{
				SortId = other.SortId;
			}
			if (other.TenTimeGachaId != 0)
			{
				TenTimeGachaId = other.TenTimeGachaId;
			}
			if (other.UseAccumulateRateLog != 0)
			{
				UseAccumulateRateLog = other.UseAccumulateRateLog;
			}
			if (other.UseGachaTicketOption != 0)
			{
				UseGachaTicketOption = other.UseGachaTicketOption;
			}
			if (other.UseSelectionOnlyFixedApply != 0)
			{
				UseSelectionOnlyFixedApply = other.UseSelectionOnlyFixedApply;
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
				BannerFontLocalTextId = input.ReadInt32();
				break;
			case 16u:
				BuyLimitCount = input.ReadInt32();
				break;
			case 24u:
				DescLocalTextId = input.ReadInt32();
				break;
			case 32u:
				EndGetItemCount = input.ReadInt32();
				break;
			case 40u:
				EndGetItemId = input.ReadInt32();
				break;
			case 48u:
				EndGetItemType = input.ReadInt32();
				break;
			case 56u:
				FixedId = input.ReadInt32();
				break;
			case 66u:
				GachaBannerBg = input.ReadString();
				break;
			case 74u:
				GachaBannerImage = input.ReadString();
				break;
			case 80u:
				GachaNameTextId = input.ReadInt32();
				break;
			case 90u:
				GachaSpineBg = input.ReadString();
				break;
			case 96u:
				GachaSubType = input.ReadInt32();
				break;
			case 104u:
				GachaType = input.ReadInt32();
				break;
			case 112u:
				Id = input.ReadInt32();
				break;
			case 120u:
				IsDisplayUiOwnGachaTicket = input.ReadInt32();
				break;
			case 128u:
				OneTimeGachaId = input.ReadInt32();
				break;
			case 136u:
				PickUpExchangeCost = input.ReadInt32();
				break;
			case 144u:
				PickUpItemId = input.ReadInt32();
				break;
			case 152u:
				PointCount = input.ReadInt32();
				break;
			case 160u:
				ScheduleType = input.ReadInt32();
				break;
			case 168u:
				SelectCount = input.ReadInt32();
				break;
			case 176u:
				SelectionChoiceRate = input.ReadInt32();
				break;
			case 184u:
				SortId = input.ReadInt32();
				break;
			case 192u:
				TenTimeGachaId = input.ReadInt32();
				break;
			case 200u:
				UseAccumulateRateLog = input.ReadInt32();
				break;
			case 208u:
				UseGachaTicketOption = input.ReadInt32();
				break;
			case 216u:
				UseSelectionOnlyFixedApply = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
