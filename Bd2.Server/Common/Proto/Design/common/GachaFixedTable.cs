using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class GachaFixedTable : IMessage<GachaFixedTable>, IMessage, IEquatable<GachaFixedTable>, IDeepCloneable<GachaFixedTable>, IBufferMessage
{
	private static readonly MessageParser<GachaFixedTable> _parser = new MessageParser<GachaFixedTable>(() => new GachaFixedTable());

	private UnknownFieldSet _unknownFields;

	public const int G3EquipFixedCountFieldNumber = 1;

	private int g3EquipFixedCount_;

	public const int G4CostumeFixedCountFieldNumber = 2;

	private int g4CostumeFixedCount_;

	public const int G4EquipFixedCountFieldNumber = 3;

	private int g4EquipFixedCount_;

	public const int G5CostumeFixedCountFieldNumber = 4;

	private int g5CostumeFixedCount_;

	public const int IdFieldNumber = 5;

	private int id_;

	public const int IsResetFixedCountFieldNumber = 6;

	private int isResetFixedCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GachaFixedTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GachaFixedTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int G3EquipFixedCount
	{
		get
		{
			return g3EquipFixedCount_;
		}
		set
		{
			g3EquipFixedCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int G4CostumeFixedCount
	{
		get
		{
			return g4CostumeFixedCount_;
		}
		set
		{
			g4CostumeFixedCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int G4EquipFixedCount
	{
		get
		{
			return g4EquipFixedCount_;
		}
		set
		{
			g4EquipFixedCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int G5CostumeFixedCount
	{
		get
		{
			return g5CostumeFixedCount_;
		}
		set
		{
			g5CostumeFixedCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public int IsResetFixedCount
	{
		get
		{
			return isResetFixedCount_;
		}
		set
		{
			isResetFixedCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaFixedTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaFixedTable(GachaFixedTable other)
		: this()
	{
		g3EquipFixedCount_ = other.g3EquipFixedCount_;
		g4CostumeFixedCount_ = other.g4CostumeFixedCount_;
		g4EquipFixedCount_ = other.g4EquipFixedCount_;
		g5CostumeFixedCount_ = other.g5CostumeFixedCount_;
		id_ = other.id_;
		isResetFixedCount_ = other.isResetFixedCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaFixedTable Clone()
	{
		return new GachaFixedTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GachaFixedTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GachaFixedTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (G3EquipFixedCount == other.G3EquipFixedCount && G4CostumeFixedCount == other.G4CostumeFixedCount && G4EquipFixedCount == other.G4EquipFixedCount && G5CostumeFixedCount == other.G5CostumeFixedCount && Id == other.Id && IsResetFixedCount == other.IsResetFixedCount)
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
		if (G3EquipFixedCount != 0)
		{
			num ^= G3EquipFixedCount.GetHashCode();
		}
		if (G4CostumeFixedCount != 0)
		{
			num ^= G4CostumeFixedCount.GetHashCode();
		}
		if (G4EquipFixedCount != 0)
		{
			num ^= G4EquipFixedCount.GetHashCode();
		}
		if (G5CostumeFixedCount != 0)
		{
			num ^= G5CostumeFixedCount.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (IsResetFixedCount != 0)
		{
			num ^= IsResetFixedCount.GetHashCode();
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
		if (G3EquipFixedCount != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(G3EquipFixedCount);
		}
		if (G4CostumeFixedCount != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(G4CostumeFixedCount);
		}
		if (G4EquipFixedCount != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(G4EquipFixedCount);
		}
		if (G5CostumeFixedCount != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(G5CostumeFixedCount);
		}
		if (Id != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Id);
		}
		if (IsResetFixedCount != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(IsResetFixedCount);
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
		if (G3EquipFixedCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(G3EquipFixedCount);
		}
		if (G4CostumeFixedCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(G4CostumeFixedCount);
		}
		if (G4EquipFixedCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(G4EquipFixedCount);
		}
		if (G5CostumeFixedCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(G5CostumeFixedCount);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (IsResetFixedCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IsResetFixedCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GachaFixedTable other)
	{
		if (other != null)
		{
			if (other.G3EquipFixedCount != 0)
			{
				G3EquipFixedCount = other.G3EquipFixedCount;
			}
			if (other.G4CostumeFixedCount != 0)
			{
				G4CostumeFixedCount = other.G4CostumeFixedCount;
			}
			if (other.G4EquipFixedCount != 0)
			{
				G4EquipFixedCount = other.G4EquipFixedCount;
			}
			if (other.G5CostumeFixedCount != 0)
			{
				G5CostumeFixedCount = other.G5CostumeFixedCount;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.IsResetFixedCount != 0)
			{
				IsResetFixedCount = other.IsResetFixedCount;
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
				G3EquipFixedCount = input.ReadInt32();
				break;
			case 16u:
				G4CostumeFixedCount = input.ReadInt32();
				break;
			case 24u:
				G4EquipFixedCount = input.ReadInt32();
				break;
			case 32u:
				G5CostumeFixedCount = input.ReadInt32();
				break;
			case 40u:
				Id = input.ReadInt32();
				break;
			case 48u:
				IsResetFixedCount = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
