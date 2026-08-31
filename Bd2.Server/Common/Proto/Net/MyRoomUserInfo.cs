using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MyRoomUserInfo : IMessage<MyRoomUserInfo>, IMessage, IEquatable<MyRoomUserInfo>, IDeepCloneable<MyRoomUserInfo>, IBufferMessage
{
	private static readonly MessageParser<MyRoomUserInfo> _parser = new MessageParser<MyRoomUserInfo>(() => new MyRoomUserInfo());

	private UnknownFieldSet _unknownFields;

	public const int OwnerIndexFieldNumber = 1;

	private long ownerIndex_;

	public const int UserIdFieldNumber = 2;

	private string userId_ = "";

	public const int PortraitCostumeIdFieldNumber = 3;

	private int portraitCostumeId_;

	public const int PrimaryMyRoomIdFieldNumber = 4;

	private int primaryMyRoomId_;

	public const int ItemInfoFieldNumber = 5;

	private static readonly FieldCodec<ItemDBInfo> _repeated_itemInfo_codec = FieldCodec.ForMessage(42u, ItemDBInfo.Parser);

	private readonly RepeatedField<ItemDBInfo> itemInfo_ = new RepeatedField<ItemDBInfo>();

	public const int CostumeInfoFieldNumber = 6;

	private static readonly FieldCodec<CostumeDBInfo> _repeated_costumeInfo_codec = FieldCodec.ForMessage(50u, CostumeDBInfo.Parser);

	private readonly RepeatedField<CostumeDBInfo> costumeInfo_ = new RepeatedField<CostumeDBInfo>();

	public const int TrophyInfoFieldNumber = 7;

	private static readonly FieldCodec<MyRoomTrophyDBInfo> _repeated_trophyInfo_codec = FieldCodec.ForMessage(58u, MyRoomTrophyDBInfo.Parser);

	private readonly RepeatedField<MyRoomTrophyDBInfo> trophyInfo_ = new RepeatedField<MyRoomTrophyDBInfo>();

	public const int MyRoomFieldNumber = 8;

	private static readonly FieldCodec<MyRoomDBInfo> _repeated_myRoom_codec = FieldCodec.ForMessage(66u, MyRoomDBInfo.Parser);

	private readonly RepeatedField<MyRoomDBInfo> myRoom_ = new RepeatedField<MyRoomDBInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MyRoomUserInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MyRoomUserInfoReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long OwnerIndex
	{
		get
		{
			return ownerIndex_;
		}
		set
		{
			ownerIndex_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string UserId
	{
		get
		{
			return userId_;
		}
		set
		{
			userId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PortraitCostumeId
	{
		get
		{
			return portraitCostumeId_;
		}
		set
		{
			portraitCostumeId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PrimaryMyRoomId
	{
		get
		{
			return primaryMyRoomId_;
		}
		set
		{
			primaryMyRoomId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ItemDBInfo> ItemInfo => itemInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<CostumeDBInfo> CostumeInfo => costumeInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MyRoomTrophyDBInfo> TrophyInfo => trophyInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<MyRoomDBInfo> MyRoom => myRoom_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MyRoomUserInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MyRoomUserInfo(MyRoomUserInfo other)
		: this()
	{
		ownerIndex_ = other.ownerIndex_;
		userId_ = other.userId_;
		portraitCostumeId_ = other.portraitCostumeId_;
		primaryMyRoomId_ = other.primaryMyRoomId_;
		itemInfo_ = other.itemInfo_.Clone();
		costumeInfo_ = other.costumeInfo_.Clone();
		trophyInfo_ = other.trophyInfo_.Clone();
		myRoom_ = other.myRoom_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MyRoomUserInfo Clone()
	{
		return new MyRoomUserInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MyRoomUserInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MyRoomUserInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (OwnerIndex == other.OwnerIndex && !(UserId != other.UserId) && PortraitCostumeId == other.PortraitCostumeId && PrimaryMyRoomId == other.PrimaryMyRoomId && itemInfo_.Equals(other.itemInfo_) && costumeInfo_.Equals(other.costumeInfo_) && trophyInfo_.Equals(other.trophyInfo_) && myRoom_.Equals(other.myRoom_))
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
		if (OwnerIndex != 0L)
		{
			num ^= OwnerIndex.GetHashCode();
		}
		if (UserId.Length != 0)
		{
			num ^= UserId.GetHashCode();
		}
		if (PortraitCostumeId != 0)
		{
			num ^= PortraitCostumeId.GetHashCode();
		}
		if (PrimaryMyRoomId != 0)
		{
			num ^= PrimaryMyRoomId.GetHashCode();
		}
		num ^= itemInfo_.GetHashCode();
		num ^= costumeInfo_.GetHashCode();
		num ^= trophyInfo_.GetHashCode();
		num ^= myRoom_.GetHashCode();
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
		if (OwnerIndex != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(OwnerIndex);
		}
		if (UserId.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(UserId);
		}
		if (PortraitCostumeId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(PortraitCostumeId);
		}
		if (PrimaryMyRoomId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(PrimaryMyRoomId);
		}
		itemInfo_.WriteTo(ref output, _repeated_itemInfo_codec);
		costumeInfo_.WriteTo(ref output, _repeated_costumeInfo_codec);
		trophyInfo_.WriteTo(ref output, _repeated_trophyInfo_codec);
		myRoom_.WriteTo(ref output, _repeated_myRoom_codec);
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
		if (OwnerIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(OwnerIndex);
		}
		if (UserId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UserId);
		}
		if (PortraitCostumeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PortraitCostumeId);
		}
		if (PrimaryMyRoomId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PrimaryMyRoomId);
		}
		num += itemInfo_.CalculateSize(_repeated_itemInfo_codec);
		num += costumeInfo_.CalculateSize(_repeated_costumeInfo_codec);
		num += trophyInfo_.CalculateSize(_repeated_trophyInfo_codec);
		num += myRoom_.CalculateSize(_repeated_myRoom_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MyRoomUserInfo other)
	{
		if (other != null)
		{
			if (other.OwnerIndex != 0L)
			{
				OwnerIndex = other.OwnerIndex;
			}
			if (other.UserId.Length != 0)
			{
				UserId = other.UserId;
			}
			if (other.PortraitCostumeId != 0)
			{
				PortraitCostumeId = other.PortraitCostumeId;
			}
			if (other.PrimaryMyRoomId != 0)
			{
				PrimaryMyRoomId = other.PrimaryMyRoomId;
			}
			itemInfo_.Add(other.itemInfo_);
			costumeInfo_.Add(other.costumeInfo_);
			trophyInfo_.Add(other.trophyInfo_);
			myRoom_.Add(other.myRoom_);
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
				OwnerIndex = input.ReadInt64();
				break;
			case 18u:
				UserId = input.ReadString();
				break;
			case 24u:
				PortraitCostumeId = input.ReadInt32();
				break;
			case 32u:
				PrimaryMyRoomId = input.ReadInt32();
				break;
			case 42u:
				itemInfo_.AddEntriesFrom(ref input, _repeated_itemInfo_codec);
				break;
			case 50u:
				costumeInfo_.AddEntriesFrom(ref input, _repeated_costumeInfo_codec);
				break;
			case 58u:
				trophyInfo_.AddEntriesFrom(ref input, _repeated_trophyInfo_codec);
				break;
			case 66u:
				myRoom_.AddEntriesFrom(ref input, _repeated_myRoom_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
