using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class FieldMiniGameSpeedTable : IMessage<FieldMiniGameSpeedTable>, IMessage, IEquatable<FieldMiniGameSpeedTable>, IDeepCloneable<FieldMiniGameSpeedTable>, IBufferMessage
{
	private static readonly MessageParser<FieldMiniGameSpeedTable> _parser = new MessageParser<FieldMiniGameSpeedTable>(() => new FieldMiniGameSpeedTable());

	private UnknownFieldSet _unknownFields;

	public const int BoosterSpeedFieldNumber = 1;

	private double boosterSpeed_;

	public const int BoosterTimeFieldNumber = 2;

	private int boosterTime_;

	public const int ClearTimeFieldNumber = 3;

	private int clearTime_;

	public const int DecreaseValueFieldNumber = 4;

	private int decreaseValue_;

	public const int GhostPositionFieldNumber = 5;

	private int ghostPosition_;

	public const int GhostPrefabFieldNumber = 6;

	private string ghostPrefab_ = "";

	public const int IdFieldNumber = 7;

	private int id_;

	public const int MaxCountFieldNumber = 8;

	private int maxCount_;

	public const int ObjectGroupIdFieldNumber = 9;

	private int objectGroupId_;

	public const int RunCountFieldNumber = 10;

	private static readonly FieldCodec<int> _repeated_runCount_codec = FieldCodec.ForInt32(82u);

	private readonly RepeatedField<int> runCount_ = new RepeatedField<int>();

	public const int RunSpeedFieldNumber = 11;

	private static readonly FieldCodec<float> _repeated_runSpeed_codec = FieldCodec.ForFloat(90u);

	private readonly RepeatedField<float> runSpeed_ = new RepeatedField<float>();

	public const int RunValueFieldNumber = 12;

	private int runValue_;

	public const int StartHpPointFieldNumber = 13;

	private int startHpPoint_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FieldMiniGameSpeedTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FieldMiniGameSpeedTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double BoosterSpeed
	{
		get
		{
			return boosterSpeed_;
		}
		set
		{
			boosterSpeed_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BoosterTime
	{
		get
		{
			return boosterTime_;
		}
		set
		{
			boosterTime_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ClearTime
	{
		get
		{
			return clearTime_;
		}
		set
		{
			clearTime_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int DecreaseValue
	{
		get
		{
			return decreaseValue_;
		}
		set
		{
			decreaseValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GhostPosition
	{
		get
		{
			return ghostPosition_;
		}
		set
		{
			ghostPosition_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string GhostPrefab
	{
		get
		{
			return ghostPrefab_;
		}
		set
		{
			ghostPrefab_ = ProtoPreconditions.CheckNotNull(value, "value");
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
	public int MaxCount
	{
		get
		{
			return maxCount_;
		}
		set
		{
			maxCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ObjectGroupId
	{
		get
		{
			return objectGroupId_;
		}
		set
		{
			objectGroupId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> RunCount => runCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<float> RunSpeed => runSpeed_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RunValue
	{
		get
		{
			return runValue_;
		}
		set
		{
			runValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int StartHpPoint
	{
		get
		{
			return startHpPoint_;
		}
		set
		{
			startHpPoint_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FieldMiniGameSpeedTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FieldMiniGameSpeedTable(FieldMiniGameSpeedTable other)
		: this()
	{
		boosterSpeed_ = other.boosterSpeed_;
		boosterTime_ = other.boosterTime_;
		clearTime_ = other.clearTime_;
		decreaseValue_ = other.decreaseValue_;
		ghostPosition_ = other.ghostPosition_;
		ghostPrefab_ = other.ghostPrefab_;
		id_ = other.id_;
		maxCount_ = other.maxCount_;
		objectGroupId_ = other.objectGroupId_;
		runCount_ = other.runCount_.Clone();
		runSpeed_ = other.runSpeed_.Clone();
		runValue_ = other.runValue_;
		startHpPoint_ = other.startHpPoint_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FieldMiniGameSpeedTable Clone()
	{
		return new FieldMiniGameSpeedTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FieldMiniGameSpeedTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FieldMiniGameSpeedTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(BoosterSpeed, other.BoosterSpeed) && BoosterTime == other.BoosterTime && ClearTime == other.ClearTime && DecreaseValue == other.DecreaseValue && GhostPosition == other.GhostPosition && !(GhostPrefab != other.GhostPrefab) && Id == other.Id && MaxCount == other.MaxCount && ObjectGroupId == other.ObjectGroupId && runCount_.Equals(other.runCount_) && runSpeed_.Equals(other.runSpeed_) && RunValue == other.RunValue && StartHpPoint == other.StartHpPoint)
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
		if (BoosterSpeed != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(BoosterSpeed);
		}
		if (BoosterTime != 0)
		{
			num ^= BoosterTime.GetHashCode();
		}
		if (ClearTime != 0)
		{
			num ^= ClearTime.GetHashCode();
		}
		if (DecreaseValue != 0)
		{
			num ^= DecreaseValue.GetHashCode();
		}
		if (GhostPosition != 0)
		{
			num ^= GhostPosition.GetHashCode();
		}
		if (GhostPrefab.Length != 0)
		{
			num ^= GhostPrefab.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (MaxCount != 0)
		{
			num ^= MaxCount.GetHashCode();
		}
		if (ObjectGroupId != 0)
		{
			num ^= ObjectGroupId.GetHashCode();
		}
		num ^= runCount_.GetHashCode();
		num ^= runSpeed_.GetHashCode();
		if (RunValue != 0)
		{
			num ^= RunValue.GetHashCode();
		}
		if (StartHpPoint != 0)
		{
			num ^= StartHpPoint.GetHashCode();
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
		if (BoosterSpeed != 0.0)
		{
			output.WriteRawTag(9);
			output.WriteDouble(BoosterSpeed);
		}
		if (BoosterTime != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BoosterTime);
		}
		if (ClearTime != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ClearTime);
		}
		if (DecreaseValue != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(DecreaseValue);
		}
		if (GhostPosition != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(GhostPosition);
		}
		if (GhostPrefab.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(GhostPrefab);
		}
		if (Id != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(Id);
		}
		if (MaxCount != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(MaxCount);
		}
		if (ObjectGroupId != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(ObjectGroupId);
		}
		runCount_.WriteTo(ref output, _repeated_runCount_codec);
		runSpeed_.WriteTo(ref output, _repeated_runSpeed_codec);
		if (RunValue != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(RunValue);
		}
		if (StartHpPoint != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(StartHpPoint);
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
		if (BoosterSpeed != 0.0)
		{
			num += 9;
		}
		if (BoosterTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BoosterTime);
		}
		if (ClearTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ClearTime);
		}
		if (DecreaseValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DecreaseValue);
		}
		if (GhostPosition != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GhostPosition);
		}
		if (GhostPrefab.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GhostPrefab);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (MaxCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxCount);
		}
		if (ObjectGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ObjectGroupId);
		}
		num += runCount_.CalculateSize(_repeated_runCount_codec);
		num += runSpeed_.CalculateSize(_repeated_runSpeed_codec);
		if (RunValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RunValue);
		}
		if (StartHpPoint != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StartHpPoint);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(FieldMiniGameSpeedTable other)
	{
		if (other != null)
		{
			if (other.BoosterSpeed != 0.0)
			{
				BoosterSpeed = other.BoosterSpeed;
			}
			if (other.BoosterTime != 0)
			{
				BoosterTime = other.BoosterTime;
			}
			if (other.ClearTime != 0)
			{
				ClearTime = other.ClearTime;
			}
			if (other.DecreaseValue != 0)
			{
				DecreaseValue = other.DecreaseValue;
			}
			if (other.GhostPosition != 0)
			{
				GhostPosition = other.GhostPosition;
			}
			if (other.GhostPrefab.Length != 0)
			{
				GhostPrefab = other.GhostPrefab;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.MaxCount != 0)
			{
				MaxCount = other.MaxCount;
			}
			if (other.ObjectGroupId != 0)
			{
				ObjectGroupId = other.ObjectGroupId;
			}
			runCount_.Add(other.runCount_);
			runSpeed_.Add(other.runSpeed_);
			if (other.RunValue != 0)
			{
				RunValue = other.RunValue;
			}
			if (other.StartHpPoint != 0)
			{
				StartHpPoint = other.StartHpPoint;
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
			case 9u:
				BoosterSpeed = input.ReadDouble();
				break;
			case 16u:
				BoosterTime = input.ReadInt32();
				break;
			case 24u:
				ClearTime = input.ReadInt32();
				break;
			case 32u:
				DecreaseValue = input.ReadInt32();
				break;
			case 40u:
				GhostPosition = input.ReadInt32();
				break;
			case 50u:
				GhostPrefab = input.ReadString();
				break;
			case 56u:
				Id = input.ReadInt32();
				break;
			case 64u:
				MaxCount = input.ReadInt32();
				break;
			case 72u:
				ObjectGroupId = input.ReadInt32();
				break;
			case 80u:
			case 82u:
				runCount_.AddEntriesFrom(ref input, _repeated_runCount_codec);
				break;
			case 90u:
			case 93u:
				runSpeed_.AddEntriesFrom(ref input, _repeated_runSpeed_codec);
				break;
			case 96u:
				RunValue = input.ReadInt32();
				break;
			case 104u:
				StartHpPoint = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
