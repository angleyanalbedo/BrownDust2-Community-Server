using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class StatueDBInfo : IMessage<StatueDBInfo>, IMessage, IEquatable<StatueDBInfo>, IDeepCloneable<StatueDBInfo>, IBufferMessage
{
	private static readonly MessageParser<StatueDBInfo> _parser = new MessageParser<StatueDBInfo>(() => new StatueDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int SeasonFieldNumber = 2;

	private int season_;

	public const int StatueRankFieldNumber = 3;

	private int statueRank_;

	public const int OwnerIndexFieldNumber = 4;

	private int ownerIndex_;

	public const int UserIdFieldNumber = 5;

	private string userId_ = "";

	public const int PortraitCostumeIdFieldNumber = 6;

	private int portraitCostumeId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<StatueDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => StatueDBInfoReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public int Season
	{
		get
		{
			return season_;
		}
		set
		{
			season_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int StatueRank
	{
		get
		{
			return statueRank_;
		}
		set
		{
			statueRank_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int OwnerIndex
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public StatueDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StatueDBInfo(StatueDBInfo other)
		: this()
	{
		id_ = other.id_;
		season_ = other.season_;
		statueRank_ = other.statueRank_;
		ownerIndex_ = other.ownerIndex_;
		userId_ = other.userId_;
		portraitCostumeId_ = other.portraitCostumeId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public StatueDBInfo Clone()
	{
		return new StatueDBInfo(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as StatueDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(StatueDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && Season == other.Season && StatueRank == other.StatueRank && OwnerIndex == other.OwnerIndex && !(UserId != other.UserId) && PortraitCostumeId == other.PortraitCostumeId)
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
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (Season != 0)
		{
			num ^= Season.GetHashCode();
		}
		if (StatueRank != 0)
		{
			num ^= StatueRank.GetHashCode();
		}
		if (OwnerIndex != 0)
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
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (Season != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Season);
		}
		if (StatueRank != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(StatueRank);
		}
		if (OwnerIndex != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(OwnerIndex);
		}
		if (UserId.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(UserId);
		}
		if (PortraitCostumeId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(PortraitCostumeId);
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
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (Season != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Season);
		}
		if (StatueRank != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StatueRank);
		}
		if (OwnerIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OwnerIndex);
		}
		if (UserId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UserId);
		}
		if (PortraitCostumeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PortraitCostumeId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(StatueDBInfo other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Season != 0)
			{
				Season = other.Season;
			}
			if (other.StatueRank != 0)
			{
				StatueRank = other.StatueRank;
			}
			if (other.OwnerIndex != 0)
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
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
			case 8u:
				Id = input.ReadInt32();
				break;
			case 16u:
				Season = input.ReadInt32();
				break;
			case 24u:
				StatueRank = input.ReadInt32();
				break;
			case 32u:
				OwnerIndex = input.ReadInt32();
				break;
			case 42u:
				UserId = input.ReadString();
				break;
			case 48u:
				PortraitCostumeId = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
