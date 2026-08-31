using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class Notify : IMessage<Notify>, IMessage, IEquatable<Notify>, IDeepCloneable<Notify>, IBufferMessage
{
	private static readonly MessageParser<Notify> _parser = new MessageParser<Notify>(() => new Notify());

	private UnknownFieldSet _unknownFields;

	public const int IsNewMailFieldNumber = 1;

	private bool isNewMail_;

	public const int AchievementUpdateInfoFieldNumber = 2;

	private static readonly MapField<int, int>.Codec _map_achievementUpdateInfo_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8u, 0), FieldCodec.ForInt32(16u, 0), 18u);

	private readonly MapField<int, int> achievementUpdateInfo_ = new MapField<int, int>();

	public const int MissionUpdateInfoFieldNumber = 3;

	private static readonly MapField<int, MissionUpdateInfoMap>.Codec _map_missionUpdateInfo_codec = new MapField<int, MissionUpdateInfoMap>.Codec(FieldCodec.ForInt32(8u, 0), FieldCodec.ForMessage(18u, MissionUpdateInfoMap.Parser), 26u);

	private readonly MapField<int, MissionUpdateInfoMap> missionUpdateInfo_ = new MapField<int, MissionUpdateInfoMap>();

	public const int EventMissionUpdateInfoFieldNumber = 4;

	private static readonly MapField<int, EventMissionInfoMap>.Codec _map_eventMissionUpdateInfo_codec = new MapField<int, EventMissionInfoMap>.Codec(FieldCodec.ForInt32(8u, 0), FieldCodec.ForMessage(18u, EventMissionInfoMap.Parser), 34u);

	private readonly MapField<int, EventMissionInfoMap> eventMissionUpdateInfo_ = new MapField<int, EventMissionInfoMap>();

	public const int LlTypeFieldNumber = 5;

	private string llType_ = "";

	public const int IsPurchasingDisabledFieldNumber = 6;

	private bool isPurchasingDisabled_;

	public const int MaintenanceStartDateFieldNumber = 7;

	private long maintenanceStartDate_;

	public const int NoticeLastSeqFieldNumber = 8;

	private int noticeLastSeq_;

	public const int ActiveLoginEventFieldNumber = 9;

	private static readonly FieldCodec<int> _repeated_activeLoginEvent_codec = FieldCodec.ForInt32(74u);

	private readonly RepeatedField<int> activeLoginEvent_ = new RepeatedField<int>();

	public const int ActiveContentsInfoFieldNumber = 10;

	private static readonly FieldCodec<ActiveContentsInfo> _repeated_activeContentsInfo_codec = FieldCodec.ForMessage(82u, Bd2.Server.Common.Proto.Net.ActiveContentsInfo.Parser);

	private readonly RepeatedField<ActiveContentsInfo> activeContentsInfo_ = new RepeatedField<ActiveContentsInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<Notify> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => NotifyReflection.Descriptor.MessageTypes[3];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsNewMail
	{
		get
		{
			return isNewMail_;
		}
		set
		{
			isNewMail_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MapField<int, int> AchievementUpdateInfo => achievementUpdateInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MapField<int, MissionUpdateInfoMap> MissionUpdateInfo => missionUpdateInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MapField<int, EventMissionInfoMap> EventMissionUpdateInfo => eventMissionUpdateInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string LlType
	{
		get
		{
			return llType_;
		}
		set
		{
			llType_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsPurchasingDisabled
	{
		get
		{
			return isPurchasingDisabled_;
		}
		set
		{
			isPurchasingDisabled_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long MaintenanceStartDate
	{
		get
		{
			return maintenanceStartDate_;
		}
		set
		{
			maintenanceStartDate_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int NoticeLastSeq
	{
		get
		{
			return noticeLastSeq_;
		}
		set
		{
			noticeLastSeq_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> ActiveLoginEvent => activeLoginEvent_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ActiveContentsInfo> ActiveContentsInfo => activeContentsInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Notify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Notify(Notify other)
		: this()
	{
		isNewMail_ = other.isNewMail_;
		achievementUpdateInfo_ = other.achievementUpdateInfo_.Clone();
		missionUpdateInfo_ = other.missionUpdateInfo_.Clone();
		eventMissionUpdateInfo_ = other.eventMissionUpdateInfo_.Clone();
		llType_ = other.llType_;
		isPurchasingDisabled_ = other.isPurchasingDisabled_;
		maintenanceStartDate_ = other.maintenanceStartDate_;
		noticeLastSeq_ = other.noticeLastSeq_;
		activeLoginEvent_ = other.activeLoginEvent_.Clone();
		activeContentsInfo_ = other.activeContentsInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Notify Clone()
	{
		return new Notify(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Notify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(Notify other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (IsNewMail == other.IsNewMail && AchievementUpdateInfo.Equals(other.AchievementUpdateInfo) && MissionUpdateInfo.Equals(other.MissionUpdateInfo) && EventMissionUpdateInfo.Equals(other.EventMissionUpdateInfo) && !(LlType != other.LlType) && IsPurchasingDisabled == other.IsPurchasingDisabled && MaintenanceStartDate == other.MaintenanceStartDate && NoticeLastSeq == other.NoticeLastSeq && activeLoginEvent_.Equals(other.activeLoginEvent_) && activeContentsInfo_.Equals(other.activeContentsInfo_))
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
		if (IsNewMail)
		{
			num ^= IsNewMail.GetHashCode();
		}
		num ^= AchievementUpdateInfo.GetHashCode();
		num ^= MissionUpdateInfo.GetHashCode();
		num ^= EventMissionUpdateInfo.GetHashCode();
		if (LlType.Length != 0)
		{
			num ^= LlType.GetHashCode();
		}
		if (IsPurchasingDisabled)
		{
			num ^= IsPurchasingDisabled.GetHashCode();
		}
		if (MaintenanceStartDate != 0L)
		{
			num ^= MaintenanceStartDate.GetHashCode();
		}
		if (NoticeLastSeq != 0)
		{
			num ^= NoticeLastSeq.GetHashCode();
		}
		num ^= activeLoginEvent_.GetHashCode();
		num ^= activeContentsInfo_.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (IsNewMail)
		{
			output.WriteRawTag(8);
			output.WriteBool(IsNewMail);
		}
		achievementUpdateInfo_.WriteTo(ref output, _map_achievementUpdateInfo_codec);
		missionUpdateInfo_.WriteTo(ref output, _map_missionUpdateInfo_codec);
		eventMissionUpdateInfo_.WriteTo(ref output, _map_eventMissionUpdateInfo_codec);
		if (LlType.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(LlType);
		}
		if (IsPurchasingDisabled)
		{
			output.WriteRawTag(48);
			output.WriteBool(IsPurchasingDisabled);
		}
		if (MaintenanceStartDate != 0L)
		{
			output.WriteRawTag(56);
			output.WriteInt64(MaintenanceStartDate);
		}
		if (NoticeLastSeq != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(NoticeLastSeq);
		}
		activeLoginEvent_.WriteTo(ref output, _repeated_activeLoginEvent_codec);
		activeContentsInfo_.WriteTo(ref output, _repeated_activeContentsInfo_codec);
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
		if (IsNewMail)
		{
			num += 2;
		}
		num += achievementUpdateInfo_.CalculateSize(_map_achievementUpdateInfo_codec);
		num += missionUpdateInfo_.CalculateSize(_map_missionUpdateInfo_codec);
		num += eventMissionUpdateInfo_.CalculateSize(_map_eventMissionUpdateInfo_codec);
		if (LlType.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LlType);
		}
		if (IsPurchasingDisabled)
		{
			num += 2;
		}
		if (MaintenanceStartDate != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(MaintenanceStartDate);
		}
		if (NoticeLastSeq != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NoticeLastSeq);
		}
		num += activeLoginEvent_.CalculateSize(_repeated_activeLoginEvent_codec);
		num += activeContentsInfo_.CalculateSize(_repeated_activeContentsInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(Notify other)
	{
		if (other != null)
		{
			if (other.IsNewMail)
			{
				IsNewMail = other.IsNewMail;
			}
			achievementUpdateInfo_.Add(other.achievementUpdateInfo_);
			missionUpdateInfo_.Add(other.missionUpdateInfo_);
			eventMissionUpdateInfo_.Add(other.eventMissionUpdateInfo_);
			if (other.LlType.Length != 0)
			{
				LlType = other.LlType;
			}
			if (other.IsPurchasingDisabled)
			{
				IsPurchasingDisabled = other.IsPurchasingDisabled;
			}
			if (other.MaintenanceStartDate != 0L)
			{
				MaintenanceStartDate = other.MaintenanceStartDate;
			}
			if (other.NoticeLastSeq != 0)
			{
				NoticeLastSeq = other.NoticeLastSeq;
			}
			activeLoginEvent_.Add(other.activeLoginEvent_);
			activeContentsInfo_.Add(other.activeContentsInfo_);
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
				IsNewMail = input.ReadBool();
				break;
			case 18u:
				achievementUpdateInfo_.AddEntriesFrom(ref input, _map_achievementUpdateInfo_codec);
				break;
			case 26u:
				missionUpdateInfo_.AddEntriesFrom(ref input, _map_missionUpdateInfo_codec);
				break;
			case 34u:
				eventMissionUpdateInfo_.AddEntriesFrom(ref input, _map_eventMissionUpdateInfo_codec);
				break;
			case 42u:
				LlType = input.ReadString();
				break;
			case 48u:
				IsPurchasingDisabled = input.ReadBool();
				break;
			case 56u:
				MaintenanceStartDate = input.ReadInt64();
				break;
			case 64u:
				NoticeLastSeq = input.ReadInt32();
				break;
			case 72u:
			case 74u:
				activeLoginEvent_.AddEntriesFrom(ref input, _repeated_activeLoginEvent_codec);
				break;
			case 82u:
				activeContentsInfo_.AddEntriesFrom(ref input, _repeated_activeContentsInfo_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
