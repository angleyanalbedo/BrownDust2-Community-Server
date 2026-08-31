using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class BattlePowerTable : IMessage<BattlePowerTable>, IMessage, IEquatable<BattlePowerTable>, IDeepCloneable<BattlePowerTable>, IBufferMessage
{
	private static readonly MessageParser<BattlePowerTable> _parser = new MessageParser<BattlePowerTable>(() => new BattlePowerTable());

	private UnknownFieldSet _unknownFields;

	public const int CostumeGradePowerFieldNumber = 1;

	private int costumeGradePower_;

	public const int CostumePowerFieldNumber = 2;

	private int costumePower_;

	public const int IdFieldNumber = 3;

	private int id_;

	public const int LevelValuePowerFieldNumber = 4;

	private int levelValuePower_;

	public const int PotentialConnectionNodePowerFieldNumber = 5;

	private int potentialConnectionNodePower_;

	public const int PotentialPublicNodePowerFieldNumber = 6;

	private int potentialPublicNodePower_;

	public const int PotentialSkillNodePowerFieldNumber = 7;

	private int potentialSkillNodePower_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BattlePowerTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BattlePowerTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CostumeGradePower
	{
		get
		{
			return costumeGradePower_;
		}
		set
		{
			costumeGradePower_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CostumePower
	{
		get
		{
			return costumePower_;
		}
		set
		{
			costumePower_ = value;
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int LevelValuePower
	{
		get
		{
			return levelValuePower_;
		}
		set
		{
			levelValuePower_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PotentialConnectionNodePower
	{
		get
		{
			return potentialConnectionNodePower_;
		}
		set
		{
			potentialConnectionNodePower_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PotentialPublicNodePower
	{
		get
		{
			return potentialPublicNodePower_;
		}
		set
		{
			potentialPublicNodePower_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PotentialSkillNodePower
	{
		get
		{
			return potentialSkillNodePower_;
		}
		set
		{
			potentialSkillNodePower_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BattlePowerTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattlePowerTable(BattlePowerTable other)
		: this()
	{
		costumeGradePower_ = other.costumeGradePower_;
		costumePower_ = other.costumePower_;
		id_ = other.id_;
		levelValuePower_ = other.levelValuePower_;
		potentialConnectionNodePower_ = other.potentialConnectionNodePower_;
		potentialPublicNodePower_ = other.potentialPublicNodePower_;
		potentialSkillNodePower_ = other.potentialSkillNodePower_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattlePowerTable Clone()
	{
		return new BattlePowerTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BattlePowerTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BattlePowerTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (CostumeGradePower == other.CostumeGradePower && CostumePower == other.CostumePower && Id == other.Id && LevelValuePower == other.LevelValuePower && PotentialConnectionNodePower == other.PotentialConnectionNodePower && PotentialPublicNodePower == other.PotentialPublicNodePower && PotentialSkillNodePower == other.PotentialSkillNodePower)
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
		if (CostumeGradePower != 0)
		{
			num ^= CostumeGradePower.GetHashCode();
		}
		if (CostumePower != 0)
		{
			num ^= CostumePower.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (LevelValuePower != 0)
		{
			num ^= LevelValuePower.GetHashCode();
		}
		if (PotentialConnectionNodePower != 0)
		{
			num ^= PotentialConnectionNodePower.GetHashCode();
		}
		if (PotentialPublicNodePower != 0)
		{
			num ^= PotentialPublicNodePower.GetHashCode();
		}
		if (PotentialSkillNodePower != 0)
		{
			num ^= PotentialSkillNodePower.GetHashCode();
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
		if (CostumeGradePower != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(CostumeGradePower);
		}
		if (CostumePower != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(CostumePower);
		}
		if (Id != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Id);
		}
		if (LevelValuePower != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(LevelValuePower);
		}
		if (PotentialConnectionNodePower != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(PotentialConnectionNodePower);
		}
		if (PotentialPublicNodePower != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(PotentialPublicNodePower);
		}
		if (PotentialSkillNodePower != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(PotentialSkillNodePower);
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
		if (CostumeGradePower != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CostumeGradePower);
		}
		if (CostumePower != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CostumePower);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (LevelValuePower != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LevelValuePower);
		}
		if (PotentialConnectionNodePower != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PotentialConnectionNodePower);
		}
		if (PotentialPublicNodePower != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PotentialPublicNodePower);
		}
		if (PotentialSkillNodePower != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PotentialSkillNodePower);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BattlePowerTable other)
	{
		if (other != null)
		{
			if (other.CostumeGradePower != 0)
			{
				CostumeGradePower = other.CostumeGradePower;
			}
			if (other.CostumePower != 0)
			{
				CostumePower = other.CostumePower;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.LevelValuePower != 0)
			{
				LevelValuePower = other.LevelValuePower;
			}
			if (other.PotentialConnectionNodePower != 0)
			{
				PotentialConnectionNodePower = other.PotentialConnectionNodePower;
			}
			if (other.PotentialPublicNodePower != 0)
			{
				PotentialPublicNodePower = other.PotentialPublicNodePower;
			}
			if (other.PotentialSkillNodePower != 0)
			{
				PotentialSkillNodePower = other.PotentialSkillNodePower;
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
				CostumeGradePower = input.ReadInt32();
				break;
			case 16u:
				CostumePower = input.ReadInt32();
				break;
			case 24u:
				Id = input.ReadInt32();
				break;
			case 32u:
				LevelValuePower = input.ReadInt32();
				break;
			case 40u:
				PotentialConnectionNodePower = input.ReadInt32();
				break;
			case 48u:
				PotentialPublicNodePower = input.ReadInt32();
				break;
			case 56u:
				PotentialSkillNodePower = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
