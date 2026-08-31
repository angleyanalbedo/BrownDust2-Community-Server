using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GuildMemberDBInfo : IMessage<GuildMemberDBInfo>, IMessage, IEquatable<GuildMemberDBInfo>, IDeepCloneable<GuildMemberDBInfo>, IBufferMessage
{
	private static readonly MessageParser<GuildMemberDBInfo> _parser = new MessageParser<GuildMemberDBInfo>(() => new GuildMemberDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private long id_;

	public const int OwnerIndexFieldNumber = 2;

	private long ownerIndex_;

	public const int UserIdFieldNumber = 3;

	private string userId_ = "";

	public const int TitleIdFieldNumber = 4;

	private int titleId_;

	public const int PortraitCostumeIdFieldNumber = 5;

	private int portraitCostumeId_;

	public const int RoleFieldNumber = 6;

	private Define_GuildMemberRole role_;

	public const int PointFieldNumber = 7;

	private int point_;

	public const int SupporterInfoFieldNumber = 8;

	private static readonly FieldCodec<CostumeBaseDBInfo> _repeated_supporterInfo_codec = FieldCodec.ForMessage(66u, CostumeBaseDBInfo.Parser);

	private readonly RepeatedField<CostumeBaseDBInfo> supporterInfo_ = new RepeatedField<CostumeBaseDBInfo>();

	public const int LastLoginDateFieldNumber = 9;

	private long lastLoginDate_;

	public const int UpdateDateFieldNumber = 10;

	private long updateDate_;

	public const int DateFieldNumber = 11;

	private long date_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildMemberDBInfo> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => GuildMemberDBInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Id
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
	public int TitleId
	{
		get
		{
			return titleId_;
		}
		set
		{
			titleId_ = value;
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
	public Define_GuildMemberRole Role
	{
		get
		{
			return role_;
		}
		set
		{
			role_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Point
	{
		get
		{
			return point_;
		}
		set
		{
			point_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CostumeBaseDBInfo> SupporterInfo => supporterInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long LastLoginDate
	{
		get
		{
			return lastLoginDate_;
		}
		set
		{
			lastLoginDate_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long UpdateDate
	{
		get
		{
			return updateDate_;
		}
		set
		{
			updateDate_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Date
	{
		get
		{
			return date_;
		}
		set
		{
			date_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildMemberDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildMemberDBInfo(GuildMemberDBInfo other)
		: this()
	{
		id_ = other.id_;
		ownerIndex_ = other.ownerIndex_;
		userId_ = other.userId_;
		titleId_ = other.titleId_;
		portraitCostumeId_ = other.portraitCostumeId_;
		role_ = other.role_;
		point_ = other.point_;
		supporterInfo_ = other.supporterInfo_.Clone();
		lastLoginDate_ = other.lastLoginDate_;
		updateDate_ = other.updateDate_;
		date_ = other.date_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildMemberDBInfo Clone()
	{
		return new GuildMemberDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GuildMemberDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildMemberDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && OwnerIndex == other.OwnerIndex && !(UserId != other.UserId) && TitleId == other.TitleId && PortraitCostumeId == other.PortraitCostumeId && Role == other.Role && Point == other.Point && supporterInfo_.Equals(other.supporterInfo_) && LastLoginDate == other.LastLoginDate && UpdateDate == other.UpdateDate && Date == other.Date)
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
		if (Id != 0L)
		{
			num ^= Id.GetHashCode();
		}
		if (OwnerIndex != 0L)
		{
			num ^= OwnerIndex.GetHashCode();
		}
		if (UserId.Length != 0)
		{
			num ^= UserId.GetHashCode();
		}
		if (TitleId != 0)
		{
			num ^= TitleId.GetHashCode();
		}
		if (PortraitCostumeId != 0)
		{
			num ^= PortraitCostumeId.GetHashCode();
		}
		if (Role != Define_GuildMemberRole.GuildRoleNone)
		{
			num ^= Role.GetHashCode();
		}
		if (Point != 0)
		{
			num ^= Point.GetHashCode();
		}
		num ^= supporterInfo_.GetHashCode();
		if (LastLoginDate != 0L)
		{
			num ^= LastLoginDate.GetHashCode();
		}
		if (UpdateDate != 0L)
		{
			num ^= UpdateDate.GetHashCode();
		}
		if (Date != 0L)
		{
			num ^= Date.GetHashCode();
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
		if (Id != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(Id);
		}
		if (OwnerIndex != 0L)
		{
			output.WriteRawTag(16);
			output.WriteInt64(OwnerIndex);
		}
		if (UserId.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(UserId);
		}
		if (TitleId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(TitleId);
		}
		if (PortraitCostumeId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(PortraitCostumeId);
		}
		if (Role != Define_GuildMemberRole.GuildRoleNone)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)Role);
		}
		if (Point != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(Point);
		}
		supporterInfo_.WriteTo(ref output, _repeated_supporterInfo_codec);
		if (LastLoginDate != 0L)
		{
			output.WriteRawTag(72);
			output.WriteInt64(LastLoginDate);
		}
		if (UpdateDate != 0L)
		{
			output.WriteRawTag(80);
			output.WriteInt64(UpdateDate);
		}
		if (Date != 0L)
		{
			output.WriteRawTag(88);
			output.WriteInt64(Date);
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
		if (Id != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(Id);
		}
		if (OwnerIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(OwnerIndex);
		}
		if (UserId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UserId);
		}
		if (TitleId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TitleId);
		}
		if (PortraitCostumeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PortraitCostumeId);
		}
		if (Role != Define_GuildMemberRole.GuildRoleNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Role);
		}
		if (Point != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Point);
		}
		num += supporterInfo_.CalculateSize(_repeated_supporterInfo_codec);
		if (LastLoginDate != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(LastLoginDate);
		}
		if (UpdateDate != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(UpdateDate);
		}
		if (Date != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(Date);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildMemberDBInfo other)
	{
		if (other != null)
		{
			if (other.Id != 0L)
			{
				Id = other.Id;
			}
			if (other.OwnerIndex != 0L)
			{
				OwnerIndex = other.OwnerIndex;
			}
			if (other.UserId.Length != 0)
			{
				UserId = other.UserId;
			}
			if (other.TitleId != 0)
			{
				TitleId = other.TitleId;
			}
			if (other.PortraitCostumeId != 0)
			{
				PortraitCostumeId = other.PortraitCostumeId;
			}
			if (other.Role != Define_GuildMemberRole.GuildRoleNone)
			{
				Role = other.Role;
			}
			if (other.Point != 0)
			{
				Point = other.Point;
			}
			supporterInfo_.Add(other.supporterInfo_);
			if (other.LastLoginDate != 0L)
			{
				LastLoginDate = other.LastLoginDate;
			}
			if (other.UpdateDate != 0L)
			{
				UpdateDate = other.UpdateDate;
			}
			if (other.Date != 0L)
			{
				Date = other.Date;
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
				Id = input.ReadInt64();
				break;
			case 16u:
				OwnerIndex = input.ReadInt64();
				break;
			case 26u:
				UserId = input.ReadString();
				break;
			case 32u:
				TitleId = input.ReadInt32();
				break;
			case 40u:
				PortraitCostumeId = input.ReadInt32();
				break;
			case 48u:
				Role = (Define_GuildMemberRole)input.ReadEnum();
				break;
			case 56u:
				Point = input.ReadInt32();
				break;
			case 66u:
				supporterInfo_.AddEntriesFrom(ref input, _repeated_supporterInfo_codec);
				break;
			case 72u:
				LastLoginDate = input.ReadInt64();
				break;
			case 80u:
				UpdateDate = input.ReadInt64();
				break;
			case 88u:
				Date = input.ReadInt64();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
