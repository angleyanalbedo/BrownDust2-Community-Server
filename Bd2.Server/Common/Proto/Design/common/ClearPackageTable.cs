using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class ClearPackageTable : IMessage<ClearPackageTable>, IMessage, IEquatable<ClearPackageTable>, IDeepCloneable<ClearPackageTable>, IBufferMessage
{
	private static readonly MessageParser<ClearPackageTable> _parser = new MessageParser<ClearPackageTable>(() => new ClearPackageTable());

	private UnknownFieldSet _unknownFields;

	public const int ContentsTicketIdFieldNumber = 1;

	private int contentsTicketId_;

	public const int GroupIdFieldNumber = 2;

	private int groupId_;

	public const int PackIdFieldNumber = 3;

	private int packId_;

	public const int RewardRandomBoxIdFieldNumber = 4;

	private int rewardRandomBoxId_;

	public const int TypeFieldNumber = 5;

	private int type_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ClearPackageTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => ClearPackageTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ContentsTicketId
	{
		get
		{
			return contentsTicketId_;
		}
		set
		{
			contentsTicketId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RewardRandomBoxId
	{
		get
		{
			return rewardRandomBoxId_;
		}
		set
		{
			rewardRandomBoxId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClearPackageTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClearPackageTable(ClearPackageTable other)
		: this()
	{
		contentsTicketId_ = other.contentsTicketId_;
		groupId_ = other.groupId_;
		packId_ = other.packId_;
		rewardRandomBoxId_ = other.rewardRandomBoxId_;
		type_ = other.type_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClearPackageTable Clone()
	{
		return new ClearPackageTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ClearPackageTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ClearPackageTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (ContentsTicketId == other.ContentsTicketId && GroupId == other.GroupId && PackId == other.PackId && RewardRandomBoxId == other.RewardRandomBoxId && Type == other.Type)
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
		if (ContentsTicketId != 0)
		{
			num ^= ContentsTicketId.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (PackId != 0)
		{
			num ^= PackId.GetHashCode();
		}
		if (RewardRandomBoxId != 0)
		{
			num ^= RewardRandomBoxId.GetHashCode();
		}
		if (Type != 0)
		{
			num ^= Type.GetHashCode();
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
		if (ContentsTicketId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ContentsTicketId);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(GroupId);
		}
		if (PackId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(PackId);
		}
		if (RewardRandomBoxId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(RewardRandomBoxId);
		}
		if (Type != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Type);
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
		if (ContentsTicketId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ContentsTicketId);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (PackId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PackId);
		}
		if (RewardRandomBoxId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RewardRandomBoxId);
		}
		if (Type != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Type);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ClearPackageTable other)
	{
		if (other != null)
		{
			if (other.ContentsTicketId != 0)
			{
				ContentsTicketId = other.ContentsTicketId;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.PackId != 0)
			{
				PackId = other.PackId;
			}
			if (other.RewardRandomBoxId != 0)
			{
				RewardRandomBoxId = other.RewardRandomBoxId;
			}
			if (other.Type != 0)
			{
				Type = other.Type;
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
				ContentsTicketId = input.ReadInt32();
				break;
			case 16u:
				GroupId = input.ReadInt32();
				break;
			case 24u:
				PackId = input.ReadInt32();
				break;
			case 32u:
				RewardRandomBoxId = input.ReadInt32();
				break;
			case 40u:
				Type = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
