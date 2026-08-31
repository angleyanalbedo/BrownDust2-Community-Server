using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class EvilCastleGreedTowerTable : IMessage<EvilCastleGreedTowerTable>, IMessage, IEquatable<EvilCastleGreedTowerTable>, IDeepCloneable<EvilCastleGreedTowerTable>, IBufferMessage
{
	private static readonly MessageParser<EvilCastleGreedTowerTable> _parser = new MessageParser<EvilCastleGreedTowerTable>(() => new EvilCastleGreedTowerTable());

	private UnknownFieldSet _unknownFields;

	public const int BattleDeckIdFieldNumber = 1;

	private int battleDeckId_;

	public const int BattlePowerFieldNumber = 2;

	private int battlePower_;

	public const int IdFieldNumber = 3;

	private int id_;

	public const int IsFixedCameraFieldNumber = 4;

	private int isFixedCamera_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<EvilCastleGreedTowerTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => EvilCastleGreedTowerTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BattleDeckId
	{
		get
		{
			return battleDeckId_;
		}
		set
		{
			battleDeckId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BattlePower
	{
		get
		{
			return battlePower_;
		}
		set
		{
			battlePower_ = value;
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
	public int IsFixedCamera
	{
		get
		{
			return isFixedCamera_;
		}
		set
		{
			isFixedCamera_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleGreedTowerTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleGreedTowerTable(EvilCastleGreedTowerTable other)
		: this()
	{
		battleDeckId_ = other.battleDeckId_;
		battlePower_ = other.battlePower_;
		id_ = other.id_;
		isFixedCamera_ = other.isFixedCamera_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleGreedTowerTable Clone()
	{
		return new EvilCastleGreedTowerTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EvilCastleGreedTowerTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EvilCastleGreedTowerTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (BattleDeckId == other.BattleDeckId && BattlePower == other.BattlePower && Id == other.Id && IsFixedCamera == other.IsFixedCamera)
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
		if (BattleDeckId != 0)
		{
			num ^= BattleDeckId.GetHashCode();
		}
		if (BattlePower != 0)
		{
			num ^= BattlePower.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (IsFixedCamera != 0)
		{
			num ^= IsFixedCamera.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (BattleDeckId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BattleDeckId);
		}
		if (BattlePower != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BattlePower);
		}
		if (Id != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Id);
		}
		if (IsFixedCamera != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(IsFixedCamera);
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
		if (BattleDeckId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleDeckId);
		}
		if (BattlePower != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattlePower);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (IsFixedCamera != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IsFixedCamera);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(EvilCastleGreedTowerTable other)
	{
		if (other != null)
		{
			if (other.BattleDeckId != 0)
			{
				BattleDeckId = other.BattleDeckId;
			}
			if (other.BattlePower != 0)
			{
				BattlePower = other.BattlePower;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.IsFixedCamera != 0)
			{
				IsFixedCamera = other.IsFixedCamera;
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
				BattleDeckId = input.ReadInt32();
				break;
			case 16u:
				BattlePower = input.ReadInt32();
				break;
			case 24u:
				Id = input.ReadInt32();
				break;
			case 32u:
				IsFixedCamera = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
