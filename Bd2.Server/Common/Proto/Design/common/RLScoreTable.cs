using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class RLScoreTable : IMessage<RLScoreTable>, IMessage, IEquatable<RLScoreTable>, IDeepCloneable<RLScoreTable>, IBufferMessage
{
	private static readonly MessageParser<RLScoreTable> _parser = new MessageParser<RLScoreTable>(() => new RLScoreTable());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int ScoreConditionValueFieldNumber = 2;

	private int scoreConditionValue_;

	public const int ScoreDescNameTextIdFieldNumber = 3;

	private int scoreDescNameTextId_;

	public const int ScoreNameTextIdFieldNumber = 4;

	private int scoreNameTextId_;

	public const int ScoreTypeFieldNumber = 5;

	private int scoreType_;

	public const int ScoreValueFieldNumber = 6;

	private int scoreValue_;

	public const int ScoreValueVeiwFieldNumber = 7;

	private int scoreValueVeiw_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RLScoreTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RLScoreTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public int ScoreConditionValue
	{
		get
		{
			return scoreConditionValue_;
		}
		set
		{
			scoreConditionValue_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ScoreDescNameTextId
	{
		get
		{
			return scoreDescNameTextId_;
		}
		set
		{
			scoreDescNameTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ScoreNameTextId
	{
		get
		{
			return scoreNameTextId_;
		}
		set
		{
			scoreNameTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ScoreType
	{
		get
		{
			return scoreType_;
		}
		set
		{
			scoreType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ScoreValue
	{
		get
		{
			return scoreValue_;
		}
		set
		{
			scoreValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ScoreValueVeiw
	{
		get
		{
			return scoreValueVeiw_;
		}
		set
		{
			scoreValueVeiw_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RLScoreTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RLScoreTable(RLScoreTable other)
		: this()
	{
		id_ = other.id_;
		scoreConditionValue_ = other.scoreConditionValue_;
		scoreDescNameTextId_ = other.scoreDescNameTextId_;
		scoreNameTextId_ = other.scoreNameTextId_;
		scoreType_ = other.scoreType_;
		scoreValue_ = other.scoreValue_;
		scoreValueVeiw_ = other.scoreValueVeiw_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RLScoreTable Clone()
	{
		return new RLScoreTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RLScoreTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(RLScoreTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && ScoreConditionValue == other.ScoreConditionValue && ScoreDescNameTextId == other.ScoreDescNameTextId && ScoreNameTextId == other.ScoreNameTextId && ScoreType == other.ScoreType && ScoreValue == other.ScoreValue && ScoreValueVeiw == other.ScoreValueVeiw)
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
		if (ScoreConditionValue != 0)
		{
			num ^= ScoreConditionValue.GetHashCode();
		}
		if (ScoreDescNameTextId != 0)
		{
			num ^= ScoreDescNameTextId.GetHashCode();
		}
		if (ScoreNameTextId != 0)
		{
			num ^= ScoreNameTextId.GetHashCode();
		}
		if (ScoreType != 0)
		{
			num ^= ScoreType.GetHashCode();
		}
		if (ScoreValue != 0)
		{
			num ^= ScoreValue.GetHashCode();
		}
		if (ScoreValueVeiw != 0)
		{
			num ^= ScoreValueVeiw.GetHashCode();
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
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (ScoreConditionValue != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ScoreConditionValue);
		}
		if (ScoreDescNameTextId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ScoreDescNameTextId);
		}
		if (ScoreNameTextId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ScoreNameTextId);
		}
		if (ScoreType != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(ScoreType);
		}
		if (ScoreValue != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(ScoreValue);
		}
		if (ScoreValueVeiw != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(ScoreValueVeiw);
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
		if (ScoreConditionValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ScoreConditionValue);
		}
		if (ScoreDescNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ScoreDescNameTextId);
		}
		if (ScoreNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ScoreNameTextId);
		}
		if (ScoreType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ScoreType);
		}
		if (ScoreValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ScoreValue);
		}
		if (ScoreValueVeiw != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ScoreValueVeiw);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(RLScoreTable other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.ScoreConditionValue != 0)
			{
				ScoreConditionValue = other.ScoreConditionValue;
			}
			if (other.ScoreDescNameTextId != 0)
			{
				ScoreDescNameTextId = other.ScoreDescNameTextId;
			}
			if (other.ScoreNameTextId != 0)
			{
				ScoreNameTextId = other.ScoreNameTextId;
			}
			if (other.ScoreType != 0)
			{
				ScoreType = other.ScoreType;
			}
			if (other.ScoreValue != 0)
			{
				ScoreValue = other.ScoreValue;
			}
			if (other.ScoreValueVeiw != 0)
			{
				ScoreValueVeiw = other.ScoreValueVeiw;
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
				ScoreConditionValue = input.ReadInt32();
				break;
			case 24u:
				ScoreDescNameTextId = input.ReadInt32();
				break;
			case 32u:
				ScoreNameTextId = input.ReadInt32();
				break;
			case 40u:
				ScoreType = input.ReadInt32();
				break;
			case 48u:
				ScoreValue = input.ReadInt32();
				break;
			case 56u:
				ScoreValueVeiw = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
