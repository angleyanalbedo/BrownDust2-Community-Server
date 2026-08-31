using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class CharRecoveryTable : IMessage<CharRecoveryTable>, IMessage, IEquatable<CharRecoveryTable>, IDeepCloneable<CharRecoveryTable>, IBufferMessage
{
	private static readonly MessageParser<CharRecoveryTable> _parser = new MessageParser<CharRecoveryTable>(() => new CharRecoveryTable());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int RecoveryAddItemCountFieldNumber = 2;

	private int recoveryAddItemCount_;

	public const int RecoveryItemCountFieldNumber = 3;

	private int recoveryItemCount_;

	public const int RecoveryItemTypeFieldNumber = 4;

	private int recoveryItemType_;

	public const int RecoverySquadLevelFieldNumber = 5;

	private int recoverySquadLevel_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CharRecoveryTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CharRecoveryTableReflection.Descriptor.MessageTypes[0];

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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RecoveryAddItemCount
	{
		get
		{
			return recoveryAddItemCount_;
		}
		set
		{
			recoveryAddItemCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RecoveryItemCount
	{
		get
		{
			return recoveryItemCount_;
		}
		set
		{
			recoveryItemCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RecoveryItemType
	{
		get
		{
			return recoveryItemType_;
		}
		set
		{
			recoveryItemType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RecoverySquadLevel
	{
		get
		{
			return recoverySquadLevel_;
		}
		set
		{
			recoverySquadLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharRecoveryTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharRecoveryTable(CharRecoveryTable other)
		: this()
	{
		id_ = other.id_;
		recoveryAddItemCount_ = other.recoveryAddItemCount_;
		recoveryItemCount_ = other.recoveryItemCount_;
		recoveryItemType_ = other.recoveryItemType_;
		recoverySquadLevel_ = other.recoverySquadLevel_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharRecoveryTable Clone()
	{
		return new CharRecoveryTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as CharRecoveryTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CharRecoveryTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && RecoveryAddItemCount == other.RecoveryAddItemCount && RecoveryItemCount == other.RecoveryItemCount && RecoveryItemType == other.RecoveryItemType && RecoverySquadLevel == other.RecoverySquadLevel)
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
		if (RecoveryAddItemCount != 0)
		{
			num ^= RecoveryAddItemCount.GetHashCode();
		}
		if (RecoveryItemCount != 0)
		{
			num ^= RecoveryItemCount.GetHashCode();
		}
		if (RecoveryItemType != 0)
		{
			num ^= RecoveryItemType.GetHashCode();
		}
		if (RecoverySquadLevel != 0)
		{
			num ^= RecoverySquadLevel.GetHashCode();
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
		if (RecoveryAddItemCount != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(RecoveryAddItemCount);
		}
		if (RecoveryItemCount != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(RecoveryItemCount);
		}
		if (RecoveryItemType != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(RecoveryItemType);
		}
		if (RecoverySquadLevel != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(RecoverySquadLevel);
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
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (RecoveryAddItemCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RecoveryAddItemCount);
		}
		if (RecoveryItemCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RecoveryItemCount);
		}
		if (RecoveryItemType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RecoveryItemType);
		}
		if (RecoverySquadLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RecoverySquadLevel);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharRecoveryTable other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.RecoveryAddItemCount != 0)
			{
				RecoveryAddItemCount = other.RecoveryAddItemCount;
			}
			if (other.RecoveryItemCount != 0)
			{
				RecoveryItemCount = other.RecoveryItemCount;
			}
			if (other.RecoveryItemType != 0)
			{
				RecoveryItemType = other.RecoveryItemType;
			}
			if (other.RecoverySquadLevel != 0)
			{
				RecoverySquadLevel = other.RecoverySquadLevel;
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
				Id = input.ReadInt32();
				break;
			case 16u:
				RecoveryAddItemCount = input.ReadInt32();
				break;
			case 24u:
				RecoveryItemCount = input.ReadInt32();
				break;
			case 32u:
				RecoveryItemType = input.ReadInt32();
				break;
			case 40u:
				RecoverySquadLevel = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
