using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class PackEventHubTable : IMessage<PackEventHubTable>, IMessage, IEquatable<PackEventHubTable>, IDeepCloneable<PackEventHubTable>, IBufferMessage
{
	private static readonly MessageParser<PackEventHubTable> _parser = new MessageParser<PackEventHubTable>(() => new PackEventHubTable());

	private UnknownFieldSet _unknownFields;

	public const int AtlasNameFieldNumber = 1;

	private string atlasName_ = "";

	public const int BgmNameFieldNumber = 2;

	private string bgmName_ = "";

	public const int CollaboIdFieldNumber = 3;

	private int collaboId_;

	public const int EventBgIllustNameFieldNumber = 4;

	private string eventBgIllustName_ = "";

	public const int EventLogoNameFieldNumber = 5;

	private string eventLogoName_ = "";

	public const int EventNameTextIdFieldNumber = 6;

	private int eventNameTextId_;

	public const int EventResourceIdFieldNumber = 7;

	private int eventResourceId_;

	public const int FakePackIdFieldNumber = 8;

	private int fakePackId_;

	public const int GuideDescTextIdFieldNumber = 9;

	private static readonly FieldCodec<int> _repeated_guideDescTextId_codec = FieldCodec.ForInt32(74u);

	private readonly RepeatedField<int> guideDescTextId_ = new RepeatedField<int>();

	public const int GuideTitleTextIdFieldNumber = 10;

	private static readonly FieldCodec<int> _repeated_guideTitleTextId_codec = FieldCodec.ForInt32(82u);

	private readonly RepeatedField<int> guideTitleTextId_ = new RepeatedField<int>();

	public const int IdFieldNumber = 11;

	private int id_;

	public const int IsHUDFieldNumber = 12;

	private int isHUD_;

	public const int LoadingPageNameFieldNumber = 13;

	private string loadingPageName_ = "";

	public const int PackBannerNameFieldNumber = 14;

	private string packBannerName_ = "";

	public const int PackIdFieldNumber = 15;

	private int packId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PackEventHubTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => PackEventHubTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string AtlasName
	{
		get
		{
			return atlasName_;
		}
		set
		{
			atlasName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string BgmName
	{
		get
		{
			return bgmName_;
		}
		set
		{
			bgmName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CollaboId
	{
		get
		{
			return collaboId_;
		}
		set
		{
			collaboId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string EventBgIllustName
	{
		get
		{
			return eventBgIllustName_;
		}
		set
		{
			eventBgIllustName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string EventLogoName
	{
		get
		{
			return eventLogoName_;
		}
		set
		{
			eventLogoName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int EventNameTextId
	{
		get
		{
			return eventNameTextId_;
		}
		set
		{
			eventNameTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EventResourceId
	{
		get
		{
			return eventResourceId_;
		}
		set
		{
			eventResourceId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FakePackId
	{
		get
		{
			return fakePackId_;
		}
		set
		{
			fakePackId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> GuideDescTextId => guideDescTextId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> GuideTitleTextId => guideTitleTextId_;

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
	public int IsHUD
	{
		get
		{
			return isHUD_;
		}
		set
		{
			isHUD_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string LoadingPageName
	{
		get
		{
			return loadingPageName_;
		}
		set
		{
			loadingPageName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string PackBannerName
	{
		get
		{
			return packBannerName_;
		}
		set
		{
			packBannerName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PackId
	{
		get
		{
			return packId_;
		}
		set
		{
			packId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackEventHubTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PackEventHubTable(PackEventHubTable other)
		: this()
	{
		atlasName_ = other.atlasName_;
		bgmName_ = other.bgmName_;
		collaboId_ = other.collaboId_;
		eventBgIllustName_ = other.eventBgIllustName_;
		eventLogoName_ = other.eventLogoName_;
		eventNameTextId_ = other.eventNameTextId_;
		eventResourceId_ = other.eventResourceId_;
		fakePackId_ = other.fakePackId_;
		guideDescTextId_ = other.guideDescTextId_.Clone();
		guideTitleTextId_ = other.guideTitleTextId_.Clone();
		id_ = other.id_;
		isHUD_ = other.isHUD_;
		loadingPageName_ = other.loadingPageName_;
		packBannerName_ = other.packBannerName_;
		packId_ = other.packId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackEventHubTable Clone()
	{
		return new PackEventHubTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PackEventHubTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PackEventHubTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (!(AtlasName != other.AtlasName) && !(BgmName != other.BgmName) && CollaboId == other.CollaboId && !(EventBgIllustName != other.EventBgIllustName) && !(EventLogoName != other.EventLogoName) && EventNameTextId == other.EventNameTextId && EventResourceId == other.EventResourceId && FakePackId == other.FakePackId && guideDescTextId_.Equals(other.guideDescTextId_) && guideTitleTextId_.Equals(other.guideTitleTextId_) && Id == other.Id && IsHUD == other.IsHUD && !(LoadingPageName != other.LoadingPageName) && !(PackBannerName != other.PackBannerName) && PackId == other.PackId)
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
		if (AtlasName.Length != 0)
		{
			num ^= AtlasName.GetHashCode();
		}
		if (BgmName.Length != 0)
		{
			num ^= BgmName.GetHashCode();
		}
		if (CollaboId != 0)
		{
			num ^= CollaboId.GetHashCode();
		}
		if (EventBgIllustName.Length != 0)
		{
			num ^= EventBgIllustName.GetHashCode();
		}
		if (EventLogoName.Length != 0)
		{
			num ^= EventLogoName.GetHashCode();
		}
		if (EventNameTextId != 0)
		{
			num ^= EventNameTextId.GetHashCode();
		}
		if (EventResourceId != 0)
		{
			num ^= EventResourceId.GetHashCode();
		}
		if (FakePackId != 0)
		{
			num ^= FakePackId.GetHashCode();
		}
		num ^= guideDescTextId_.GetHashCode();
		num ^= guideTitleTextId_.GetHashCode();
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (IsHUD != 0)
		{
			num ^= IsHUD.GetHashCode();
		}
		if (LoadingPageName.Length != 0)
		{
			num ^= LoadingPageName.GetHashCode();
		}
		if (PackBannerName.Length != 0)
		{
			num ^= PackBannerName.GetHashCode();
		}
		if (PackId != 0)
		{
			num ^= PackId.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (AtlasName.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(AtlasName);
		}
		if (BgmName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(BgmName);
		}
		if (CollaboId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(CollaboId);
		}
		if (EventBgIllustName.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(EventBgIllustName);
		}
		if (EventLogoName.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(EventLogoName);
		}
		if (EventNameTextId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(EventNameTextId);
		}
		if (EventResourceId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(EventResourceId);
		}
		if (FakePackId != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(FakePackId);
		}
		guideDescTextId_.WriteTo(ref output, _repeated_guideDescTextId_codec);
		guideTitleTextId_.WriteTo(ref output, _repeated_guideTitleTextId_codec);
		if (Id != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(Id);
		}
		if (IsHUD != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(IsHUD);
		}
		if (LoadingPageName.Length != 0)
		{
			output.WriteRawTag(106);
			output.WriteString(LoadingPageName);
		}
		if (PackBannerName.Length != 0)
		{
			output.WriteRawTag(114);
			output.WriteString(PackBannerName);
		}
		if (PackId != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(PackId);
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
		if (AtlasName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AtlasName);
		}
		if (BgmName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BgmName);
		}
		if (CollaboId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CollaboId);
		}
		if (EventBgIllustName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(EventBgIllustName);
		}
		if (EventLogoName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(EventLogoName);
		}
		if (EventNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventNameTextId);
		}
		if (EventResourceId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventResourceId);
		}
		if (FakePackId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FakePackId);
		}
		num += guideDescTextId_.CalculateSize(_repeated_guideDescTextId_codec);
		num += guideTitleTextId_.CalculateSize(_repeated_guideTitleTextId_codec);
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (IsHUD != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IsHUD);
		}
		if (LoadingPageName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LoadingPageName);
		}
		if (PackBannerName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PackBannerName);
		}
		if (PackId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PackId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PackEventHubTable other)
	{
		if (other != null)
		{
			if (other.AtlasName.Length != 0)
			{
				AtlasName = other.AtlasName;
			}
			if (other.BgmName.Length != 0)
			{
				BgmName = other.BgmName;
			}
			if (other.CollaboId != 0)
			{
				CollaboId = other.CollaboId;
			}
			if (other.EventBgIllustName.Length != 0)
			{
				EventBgIllustName = other.EventBgIllustName;
			}
			if (other.EventLogoName.Length != 0)
			{
				EventLogoName = other.EventLogoName;
			}
			if (other.EventNameTextId != 0)
			{
				EventNameTextId = other.EventNameTextId;
			}
			if (other.EventResourceId != 0)
			{
				EventResourceId = other.EventResourceId;
			}
			if (other.FakePackId != 0)
			{
				FakePackId = other.FakePackId;
			}
			guideDescTextId_.Add(other.guideDescTextId_);
			guideTitleTextId_.Add(other.guideTitleTextId_);
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.IsHUD != 0)
			{
				IsHUD = other.IsHUD;
			}
			if (other.LoadingPageName.Length != 0)
			{
				LoadingPageName = other.LoadingPageName;
			}
			if (other.PackBannerName.Length != 0)
			{
				PackBannerName = other.PackBannerName;
			}
			if (other.PackId != 0)
			{
				PackId = other.PackId;
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
			case 10u:
				AtlasName = input.ReadString();
				break;
			case 18u:
				BgmName = input.ReadString();
				break;
			case 24u:
				CollaboId = input.ReadInt32();
				break;
			case 34u:
				EventBgIllustName = input.ReadString();
				break;
			case 42u:
				EventLogoName = input.ReadString();
				break;
			case 48u:
				EventNameTextId = input.ReadInt32();
				break;
			case 56u:
				EventResourceId = input.ReadInt32();
				break;
			case 64u:
				FakePackId = input.ReadInt32();
				break;
			case 72u:
			case 74u:
				guideDescTextId_.AddEntriesFrom(ref input, _repeated_guideDescTextId_codec);
				break;
			case 80u:
			case 82u:
				guideTitleTextId_.AddEntriesFrom(ref input, _repeated_guideTitleTextId_codec);
				break;
			case 88u:
				Id = input.ReadInt32();
				break;
			case 96u:
				IsHUD = input.ReadInt32();
				break;
			case 106u:
				LoadingPageName = input.ReadString();
				break;
			case 114u:
				PackBannerName = input.ReadString();
				break;
			case 120u:
				PackId = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
