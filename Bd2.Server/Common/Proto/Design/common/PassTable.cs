using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class PassTable : IMessage<PassTable>, IMessage, IEquatable<PassTable>, IDeepCloneable<PassTable>, IBufferMessage
{
	private static readonly MessageParser<PassTable> _parser = new MessageParser<PassTable>(() => new PassTable());

	private UnknownFieldSet _unknownFields;

	public const int BannerFontLocalTextIdFieldNumber = 1;

	private int bannerFontLocalTextId_;

	public const int CoreRewardCountFieldNumber = 2;

	private int coreRewardCount_;

	public const int CoreRewardIdFieldNumber = 3;

	private int coreRewardId_;

	public const int CoreRewardTypeFieldNumber = 4;

	private int coreRewardType_;

	public const int ExpEventMissionGroupIdFieldNumber = 5;

	private int expEventMissionGroupId_;

	public const int IdFieldNumber = 6;

	private int id_;

	public const int IsNewbiePassFieldNumber = 7;

	private int isNewbiePass_;

	public const int IsShowCoreRewardFieldNumber = 8;

	private int isShowCoreReward_;

	public const int MainBannerNameFieldNumber = 9;

	private string mainBannerName_ = "";

	public const int NewbiePassStepFieldNumber = 10;

	private int newbiePassStep_;

	public const int PassLevelGroupIdFieldNumber = 11;

	private int passLevelGroupId_;

	public const int PassNameTextIdFieldNumber = 12;

	private int passNameTextId_;

	public const int PassTypeFieldNumber = 13;

	private int passType_;

	public const int PrefabNameFieldNumber = 14;

	private string prefabName_ = "";

	public const int ScheduleTypeFieldNumber = 15;

	private int scheduleType_;

	public const int SortIdFieldNumber = 16;

	private int sortId_;

	public const int SubBannerNameFieldNumber = 17;

	private string subBannerName_ = "";

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PassTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => PassTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public int CoreRewardCount
	{
		get
		{
			return coreRewardCount_;
		}
		set
		{
			coreRewardCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CoreRewardId
	{
		get
		{
			return coreRewardId_;
		}
		set
		{
			coreRewardId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CoreRewardType
	{
		get
		{
			return coreRewardType_;
		}
		set
		{
			coreRewardType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ExpEventMissionGroupId
	{
		get
		{
			return expEventMissionGroupId_;
		}
		set
		{
			expEventMissionGroupId_ = value;
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
	public int IsNewbiePass
	{
		get
		{
			return isNewbiePass_;
		}
		set
		{
			isNewbiePass_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int IsShowCoreReward
	{
		get
		{
			return isShowCoreReward_;
		}
		set
		{
			isShowCoreReward_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string MainBannerName
	{
		get
		{
			return mainBannerName_;
		}
		set
		{
			mainBannerName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int NewbiePassStep
	{
		get
		{
			return newbiePassStep_;
		}
		set
		{
			newbiePassStep_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PassLevelGroupId
	{
		get
		{
			return passLevelGroupId_;
		}
		set
		{
			passLevelGroupId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PassNameTextId
	{
		get
		{
			return passNameTextId_;
		}
		set
		{
			passNameTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PassType
	{
		get
		{
			return passType_;
		}
		set
		{
			passType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string PrefabName
	{
		get
		{
			return prefabName_;
		}
		set
		{
			prefabName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string SubBannerName
	{
		get
		{
			return subBannerName_;
		}
		set
		{
			subBannerName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PassTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PassTable(PassTable other)
		: this()
	{
		bannerFontLocalTextId_ = other.bannerFontLocalTextId_;
		coreRewardCount_ = other.coreRewardCount_;
		coreRewardId_ = other.coreRewardId_;
		coreRewardType_ = other.coreRewardType_;
		expEventMissionGroupId_ = other.expEventMissionGroupId_;
		id_ = other.id_;
		isNewbiePass_ = other.isNewbiePass_;
		isShowCoreReward_ = other.isShowCoreReward_;
		mainBannerName_ = other.mainBannerName_;
		newbiePassStep_ = other.newbiePassStep_;
		passLevelGroupId_ = other.passLevelGroupId_;
		passNameTextId_ = other.passNameTextId_;
		passType_ = other.passType_;
		prefabName_ = other.prefabName_;
		scheduleType_ = other.scheduleType_;
		sortId_ = other.sortId_;
		subBannerName_ = other.subBannerName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PassTable Clone()
	{
		return new PassTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as PassTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PassTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (BannerFontLocalTextId == other.BannerFontLocalTextId && CoreRewardCount == other.CoreRewardCount && CoreRewardId == other.CoreRewardId && CoreRewardType == other.CoreRewardType && ExpEventMissionGroupId == other.ExpEventMissionGroupId && Id == other.Id && IsNewbiePass == other.IsNewbiePass && IsShowCoreReward == other.IsShowCoreReward && !(MainBannerName != other.MainBannerName) && NewbiePassStep == other.NewbiePassStep && PassLevelGroupId == other.PassLevelGroupId && PassNameTextId == other.PassNameTextId && PassType == other.PassType && !(PrefabName != other.PrefabName) && ScheduleType == other.ScheduleType && SortId == other.SortId && !(SubBannerName != other.SubBannerName))
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
		if (BannerFontLocalTextId != 0)
		{
			num ^= BannerFontLocalTextId.GetHashCode();
		}
		if (CoreRewardCount != 0)
		{
			num ^= CoreRewardCount.GetHashCode();
		}
		if (CoreRewardId != 0)
		{
			num ^= CoreRewardId.GetHashCode();
		}
		if (CoreRewardType != 0)
		{
			num ^= CoreRewardType.GetHashCode();
		}
		if (ExpEventMissionGroupId != 0)
		{
			num ^= ExpEventMissionGroupId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (IsNewbiePass != 0)
		{
			num ^= IsNewbiePass.GetHashCode();
		}
		if (IsShowCoreReward != 0)
		{
			num ^= IsShowCoreReward.GetHashCode();
		}
		if (MainBannerName.Length != 0)
		{
			num ^= MainBannerName.GetHashCode();
		}
		if (NewbiePassStep != 0)
		{
			num ^= NewbiePassStep.GetHashCode();
		}
		if (PassLevelGroupId != 0)
		{
			num ^= PassLevelGroupId.GetHashCode();
		}
		if (PassNameTextId != 0)
		{
			num ^= PassNameTextId.GetHashCode();
		}
		if (PassType != 0)
		{
			num ^= PassType.GetHashCode();
		}
		if (PrefabName.Length != 0)
		{
			num ^= PrefabName.GetHashCode();
		}
		if (ScheduleType != 0)
		{
			num ^= ScheduleType.GetHashCode();
		}
		if (SortId != 0)
		{
			num ^= SortId.GetHashCode();
		}
		if (SubBannerName.Length != 0)
		{
			num ^= SubBannerName.GetHashCode();
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
		if (BannerFontLocalTextId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BannerFontLocalTextId);
		}
		if (CoreRewardCount != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(CoreRewardCount);
		}
		if (CoreRewardId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(CoreRewardId);
		}
		if (CoreRewardType != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(CoreRewardType);
		}
		if (ExpEventMissionGroupId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(ExpEventMissionGroupId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(Id);
		}
		if (IsNewbiePass != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(IsNewbiePass);
		}
		if (IsShowCoreReward != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(IsShowCoreReward);
		}
		if (MainBannerName.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(MainBannerName);
		}
		if (NewbiePassStep != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(NewbiePassStep);
		}
		if (PassLevelGroupId != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(PassLevelGroupId);
		}
		if (PassNameTextId != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(PassNameTextId);
		}
		if (PassType != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(PassType);
		}
		if (PrefabName.Length != 0)
		{
			output.WriteRawTag(114);
			output.WriteString(PrefabName);
		}
		if (ScheduleType != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(ScheduleType);
		}
		if (SortId != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(SortId);
		}
		if (SubBannerName.Length != 0)
		{
			output.WriteRawTag(138, 1);
			output.WriteString(SubBannerName);
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
		if (BannerFontLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BannerFontLocalTextId);
		}
		if (CoreRewardCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CoreRewardCount);
		}
		if (CoreRewardId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CoreRewardId);
		}
		if (CoreRewardType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CoreRewardType);
		}
		if (ExpEventMissionGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ExpEventMissionGroupId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (IsNewbiePass != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IsNewbiePass);
		}
		if (IsShowCoreReward != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IsShowCoreReward);
		}
		if (MainBannerName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MainBannerName);
		}
		if (NewbiePassStep != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NewbiePassStep);
		}
		if (PassLevelGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PassLevelGroupId);
		}
		if (PassNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PassNameTextId);
		}
		if (PassType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PassType);
		}
		if (PrefabName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PrefabName);
		}
		if (ScheduleType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ScheduleType);
		}
		if (SortId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SortId);
		}
		if (SubBannerName.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(SubBannerName);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PassTable other)
	{
		if (other != null)
		{
			if (other.BannerFontLocalTextId != 0)
			{
				BannerFontLocalTextId = other.BannerFontLocalTextId;
			}
			if (other.CoreRewardCount != 0)
			{
				CoreRewardCount = other.CoreRewardCount;
			}
			if (other.CoreRewardId != 0)
			{
				CoreRewardId = other.CoreRewardId;
			}
			if (other.CoreRewardType != 0)
			{
				CoreRewardType = other.CoreRewardType;
			}
			if (other.ExpEventMissionGroupId != 0)
			{
				ExpEventMissionGroupId = other.ExpEventMissionGroupId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.IsNewbiePass != 0)
			{
				IsNewbiePass = other.IsNewbiePass;
			}
			if (other.IsShowCoreReward != 0)
			{
				IsShowCoreReward = other.IsShowCoreReward;
			}
			if (other.MainBannerName.Length != 0)
			{
				MainBannerName = other.MainBannerName;
			}
			if (other.NewbiePassStep != 0)
			{
				NewbiePassStep = other.NewbiePassStep;
			}
			if (other.PassLevelGroupId != 0)
			{
				PassLevelGroupId = other.PassLevelGroupId;
			}
			if (other.PassNameTextId != 0)
			{
				PassNameTextId = other.PassNameTextId;
			}
			if (other.PassType != 0)
			{
				PassType = other.PassType;
			}
			if (other.PrefabName.Length != 0)
			{
				PrefabName = other.PrefabName;
			}
			if (other.ScheduleType != 0)
			{
				ScheduleType = other.ScheduleType;
			}
			if (other.SortId != 0)
			{
				SortId = other.SortId;
			}
			if (other.SubBannerName.Length != 0)
			{
				SubBannerName = other.SubBannerName;
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
			switch (num)
			{
			case 8u:
				BannerFontLocalTextId = input.ReadInt32();
				break;
			case 16u:
				CoreRewardCount = input.ReadInt32();
				break;
			case 24u:
				CoreRewardId = input.ReadInt32();
				break;
			case 32u:
				CoreRewardType = input.ReadInt32();
				break;
			case 40u:
				ExpEventMissionGroupId = input.ReadInt32();
				break;
			case 48u:
				Id = input.ReadInt32();
				break;
			case 56u:
				IsNewbiePass = input.ReadInt32();
				break;
			case 64u:
				IsShowCoreReward = input.ReadInt32();
				break;
			case 74u:
				MainBannerName = input.ReadString();
				break;
			case 80u:
				NewbiePassStep = input.ReadInt32();
				break;
			case 88u:
				PassLevelGroupId = input.ReadInt32();
				break;
			case 96u:
				PassNameTextId = input.ReadInt32();
				break;
			case 104u:
				PassType = input.ReadInt32();
				break;
			case 114u:
				PrefabName = input.ReadString();
				break;
			case 120u:
				ScheduleType = input.ReadInt32();
				break;
			case 128u:
				SortId = input.ReadInt32();
				break;
			case 138u:
				SubBannerName = input.ReadString();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
