using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class UserBaseDBInfo : IMessage<UserBaseDBInfo>, IMessage, IEquatable<UserBaseDBInfo>, IDeepCloneable<UserBaseDBInfo>, IBufferMessage
{
	private static readonly MessageParser<UserBaseDBInfo> _parser = new MessageParser<UserBaseDBInfo>(() => new UserBaseDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int OwnerIndexFieldNumber = 1;

	private long ownerIndex_;

	public const int PortraitCostumeIdFieldNumber = 2;

	private int portraitCostumeId_;

	public const int UserIdFieldNumber = 3;

	private string userId_ = "";

	public const int TitleIdFieldNumber = 4;

	private int titleId_;

	public const int DateFieldNumber = 5;

	private long date_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UserBaseDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => UserBaseDBInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public UserBaseDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UserBaseDBInfo(UserBaseDBInfo other)
		: this()
	{
		ownerIndex_ = other.ownerIndex_;
		portraitCostumeId_ = other.portraitCostumeId_;
		userId_ = other.userId_;
		titleId_ = other.titleId_;
		date_ = other.date_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UserBaseDBInfo Clone()
	{
		return new UserBaseDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as UserBaseDBInfo);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(UserBaseDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (OwnerIndex == other.OwnerIndex && PortraitCostumeId == other.PortraitCostumeId && !(UserId != other.UserId) && TitleId == other.TitleId && Date == other.Date)
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
		if (PortraitCostumeId != 0)
		{
			num ^= PortraitCostumeId.GetHashCode();
		}
		if (UserId.Length != 0)
		{
			num ^= UserId.GetHashCode();
		}
		if (TitleId != 0)
		{
			num ^= TitleId.GetHashCode();
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
		if (OwnerIndex != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(OwnerIndex);
		}
		if (PortraitCostumeId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(PortraitCostumeId);
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
		if (Date != 0L)
		{
			output.WriteRawTag(40);
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
		if (OwnerIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(OwnerIndex);
		}
		if (PortraitCostumeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PortraitCostumeId);
		}
		if (UserId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UserId);
		}
		if (TitleId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TitleId);
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
	public void MergeFrom(UserBaseDBInfo other)
	{
		if (other != null)
		{
			if (other.OwnerIndex != 0L)
			{
				OwnerIndex = other.OwnerIndex;
			}
			if (other.PortraitCostumeId != 0)
			{
				PortraitCostumeId = other.PortraitCostumeId;
			}
			if (other.UserId.Length != 0)
			{
				UserId = other.UserId;
			}
			if (other.TitleId != 0)
			{
				TitleId = other.TitleId;
			}
			if (other.Date != 0L)
			{
				Date = other.Date;
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
			case 16u:
				PortraitCostumeId = input.ReadInt32();
				break;
			case 26u:
				UserId = input.ReadString();
				break;
			case 32u:
				TitleId = input.ReadInt32();
				break;
			case 40u:
				Date = input.ReadInt64();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
