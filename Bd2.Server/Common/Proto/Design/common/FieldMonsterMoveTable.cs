using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class FieldMonsterMoveTable : IMessage<FieldMonsterMoveTable>, IMessage, IEquatable<FieldMonsterMoveTable>, IDeepCloneable<FieldMonsterMoveTable>, IBufferMessage
{
	private static readonly MessageParser<FieldMonsterMoveTable> _parser = new MessageParser<FieldMonsterMoveTable>(() => new FieldMonsterMoveTable());

	private UnknownFieldSet _unknownFields;

	public const int DetectionAngleFieldNumber = 1;

	private double detectionAngle_;

	public const int DetectionDistanceFieldNumber = 2;

	private double detectionDistance_;

	public const int DetectionIgnoreWallFieldNumber = 3;

	private int detectionIgnoreWall_;

	public const int DetectionTypeFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_detectionType_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> detectionType_ = new RepeatedField<int>();

	public const int DistanceChaseFieldNumber = 5;

	private double distanceChase_;

	public const int DistanceDefaultFieldNumber = 6;

	private double distanceDefault_;

	public const int DistanceRunFieldNumber = 7;

	private double distanceRun_;

	public const int EncounterAngleFieldNumber = 8;

	private double encounterAngle_;

	public const int EncounterDistanceFieldNumber = 9;

	private double encounterDistance_;

	public const int IdFieldNumber = 10;

	private int id_;

	public const int LasttimeChaseFieldNumber = 11;

	private double lasttimeChase_;

	public const int LvFieldNumber = 12;

	private int lv_;

	public const int MoveIgnoreWallFieldNumber = 13;

	private int moveIgnoreWall_;

	public const int MovingFieldNumber = 14;

	private int moving_;

	public const int SpeedChaseFieldNumber = 15;

	private double speedChase_;

	public const int SpeedDefaultFieldNumber = 16;

	private double speedDefault_;

	public const int SpeedRunFieldNumber = 17;

	private double speedRun_;

	public const int TimeChaseFieldNumber = 18;

	private double timeChase_;

	public const int TimeDefaultFieldNumber = 19;

	private double timeDefault_;

	public const int TimeDiscoveryFieldNumber = 20;

	private double timeDiscovery_;

	public const int TimeRunFieldNumber = 21;

	private double timeRun_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FieldMonsterMoveTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FieldMonsterMoveTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double DetectionAngle
	{
		get
		{
			return detectionAngle_;
		}
		set
		{
			detectionAngle_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double DetectionDistance
	{
		get
		{
			return detectionDistance_;
		}
		set
		{
			detectionDistance_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DetectionIgnoreWall
	{
		get
		{
			return detectionIgnoreWall_;
		}
		set
		{
			detectionIgnoreWall_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> DetectionType => detectionType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double DistanceChase
	{
		get
		{
			return distanceChase_;
		}
		set
		{
			distanceChase_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double DistanceDefault
	{
		get
		{
			return distanceDefault_;
		}
		set
		{
			distanceDefault_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double DistanceRun
	{
		get
		{
			return distanceRun_;
		}
		set
		{
			distanceRun_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double EncounterAngle
	{
		get
		{
			return encounterAngle_;
		}
		set
		{
			encounterAngle_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double EncounterDistance
	{
		get
		{
			return encounterDistance_;
		}
		set
		{
			encounterDistance_ = value;
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double LasttimeChase
	{
		get
		{
			return lasttimeChase_;
		}
		set
		{
			lasttimeChase_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Lv
	{
		get
		{
			return lv_;
		}
		set
		{
			lv_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MoveIgnoreWall
	{
		get
		{
			return moveIgnoreWall_;
		}
		set
		{
			moveIgnoreWall_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Moving
	{
		get
		{
			return moving_;
		}
		set
		{
			moving_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double SpeedChase
	{
		get
		{
			return speedChase_;
		}
		set
		{
			speedChase_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double SpeedDefault
	{
		get
		{
			return speedDefault_;
		}
		set
		{
			speedDefault_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double SpeedRun
	{
		get
		{
			return speedRun_;
		}
		set
		{
			speedRun_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double TimeChase
	{
		get
		{
			return timeChase_;
		}
		set
		{
			timeChase_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double TimeDefault
	{
		get
		{
			return timeDefault_;
		}
		set
		{
			timeDefault_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double TimeDiscovery
	{
		get
		{
			return timeDiscovery_;
		}
		set
		{
			timeDiscovery_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double TimeRun
	{
		get
		{
			return timeRun_;
		}
		set
		{
			timeRun_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FieldMonsterMoveTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FieldMonsterMoveTable(FieldMonsterMoveTable other)
		: this()
	{
		detectionAngle_ = other.detectionAngle_;
		detectionDistance_ = other.detectionDistance_;
		detectionIgnoreWall_ = other.detectionIgnoreWall_;
		detectionType_ = other.detectionType_.Clone();
		distanceChase_ = other.distanceChase_;
		distanceDefault_ = other.distanceDefault_;
		distanceRun_ = other.distanceRun_;
		encounterAngle_ = other.encounterAngle_;
		encounterDistance_ = other.encounterDistance_;
		id_ = other.id_;
		lasttimeChase_ = other.lasttimeChase_;
		lv_ = other.lv_;
		moveIgnoreWall_ = other.moveIgnoreWall_;
		moving_ = other.moving_;
		speedChase_ = other.speedChase_;
		speedDefault_ = other.speedDefault_;
		speedRun_ = other.speedRun_;
		timeChase_ = other.timeChase_;
		timeDefault_ = other.timeDefault_;
		timeDiscovery_ = other.timeDiscovery_;
		timeRun_ = other.timeRun_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FieldMonsterMoveTable Clone()
	{
		return new FieldMonsterMoveTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FieldMonsterMoveTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(FieldMonsterMoveTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(DetectionAngle, other.DetectionAngle) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(DetectionDistance, other.DetectionDistance) && DetectionIgnoreWall == other.DetectionIgnoreWall && detectionType_.Equals(other.detectionType_) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(DistanceChase, other.DistanceChase) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(DistanceDefault, other.DistanceDefault) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(DistanceRun, other.DistanceRun) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(EncounterAngle, other.EncounterAngle) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(EncounterDistance, other.EncounterDistance) && Id == other.Id && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(LasttimeChase, other.LasttimeChase) && Lv == other.Lv && MoveIgnoreWall == other.MoveIgnoreWall && Moving == other.Moving && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(SpeedChase, other.SpeedChase) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(SpeedDefault, other.SpeedDefault) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(SpeedRun, other.SpeedRun) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TimeChase, other.TimeChase) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TimeDefault, other.TimeDefault) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TimeDiscovery, other.TimeDiscovery) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TimeRun, other.TimeRun))
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
		if (DetectionAngle != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(DetectionAngle);
		}
		if (DetectionDistance != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(DetectionDistance);
		}
		if (DetectionIgnoreWall != 0)
		{
			num ^= DetectionIgnoreWall.GetHashCode();
		}
		num ^= detectionType_.GetHashCode();
		if (DistanceChase != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(DistanceChase);
		}
		if (DistanceDefault != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(DistanceDefault);
		}
		if (DistanceRun != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(DistanceRun);
		}
		if (EncounterAngle != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(EncounterAngle);
		}
		if (EncounterDistance != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(EncounterDistance);
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (LasttimeChase != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(LasttimeChase);
		}
		if (Lv != 0)
		{
			num ^= Lv.GetHashCode();
		}
		if (MoveIgnoreWall != 0)
		{
			num ^= MoveIgnoreWall.GetHashCode();
		}
		if (Moving != 0)
		{
			num ^= Moving.GetHashCode();
		}
		if (SpeedChase != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(SpeedChase);
		}
		if (SpeedDefault != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(SpeedDefault);
		}
		if (SpeedRun != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(SpeedRun);
		}
		if (TimeChase != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TimeChase);
		}
		if (TimeDefault != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TimeDefault);
		}
		if (TimeDiscovery != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TimeDiscovery);
		}
		if (TimeRun != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TimeRun);
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (DetectionAngle != 0.0)
		{
			output.WriteRawTag(9);
			output.WriteDouble(DetectionAngle);
		}
		if (DetectionDistance != 0.0)
		{
			output.WriteRawTag(17);
			output.WriteDouble(DetectionDistance);
		}
		if (DetectionIgnoreWall != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(DetectionIgnoreWall);
		}
		detectionType_.WriteTo(ref output, _repeated_detectionType_codec);
		if (DistanceChase != 0.0)
		{
			output.WriteRawTag(41);
			output.WriteDouble(DistanceChase);
		}
		if (DistanceDefault != 0.0)
		{
			output.WriteRawTag(49);
			output.WriteDouble(DistanceDefault);
		}
		if (DistanceRun != 0.0)
		{
			output.WriteRawTag(57);
			output.WriteDouble(DistanceRun);
		}
		if (EncounterAngle != 0.0)
		{
			output.WriteRawTag(65);
			output.WriteDouble(EncounterAngle);
		}
		if (EncounterDistance != 0.0)
		{
			output.WriteRawTag(73);
			output.WriteDouble(EncounterDistance);
		}
		if (Id != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(Id);
		}
		if (LasttimeChase != 0.0)
		{
			output.WriteRawTag(89);
			output.WriteDouble(LasttimeChase);
		}
		if (Lv != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(Lv);
		}
		if (MoveIgnoreWall != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(MoveIgnoreWall);
		}
		if (Moving != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(Moving);
		}
		if (SpeedChase != 0.0)
		{
			output.WriteRawTag(121);
			output.WriteDouble(SpeedChase);
		}
		if (SpeedDefault != 0.0)
		{
			output.WriteRawTag(129, 1);
			output.WriteDouble(SpeedDefault);
		}
		if (SpeedRun != 0.0)
		{
			output.WriteRawTag(137, 1);
			output.WriteDouble(SpeedRun);
		}
		if (TimeChase != 0.0)
		{
			output.WriteRawTag(145, 1);
			output.WriteDouble(TimeChase);
		}
		if (TimeDefault != 0.0)
		{
			output.WriteRawTag(153, 1);
			output.WriteDouble(TimeDefault);
		}
		if (TimeDiscovery != 0.0)
		{
			output.WriteRawTag(161, 1);
			output.WriteDouble(TimeDiscovery);
		}
		if (TimeRun != 0.0)
		{
			output.WriteRawTag(169, 1);
			output.WriteDouble(TimeRun);
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
		if (DetectionAngle != 0.0)
		{
			num += 9;
		}
		if (DetectionDistance != 0.0)
		{
			num += 9;
		}
		if (DetectionIgnoreWall != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DetectionIgnoreWall);
		}
		num += detectionType_.CalculateSize(_repeated_detectionType_codec);
		if (DistanceChase != 0.0)
		{
			num += 9;
		}
		if (DistanceDefault != 0.0)
		{
			num += 9;
		}
		if (DistanceRun != 0.0)
		{
			num += 9;
		}
		if (EncounterAngle != 0.0)
		{
			num += 9;
		}
		if (EncounterDistance != 0.0)
		{
			num += 9;
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (LasttimeChase != 0.0)
		{
			num += 9;
		}
		if (Lv != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Lv);
		}
		if (MoveIgnoreWall != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MoveIgnoreWall);
		}
		if (Moving != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Moving);
		}
		if (SpeedChase != 0.0)
		{
			num += 9;
		}
		if (SpeedDefault != 0.0)
		{
			num += 10;
		}
		if (SpeedRun != 0.0)
		{
			num += 10;
		}
		if (TimeChase != 0.0)
		{
			num += 10;
		}
		if (TimeDefault != 0.0)
		{
			num += 10;
		}
		if (TimeDiscovery != 0.0)
		{
			num += 10;
		}
		if (TimeRun != 0.0)
		{
			num += 10;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FieldMonsterMoveTable other)
	{
		if (other != null)
		{
			if (other.DetectionAngle != 0.0)
			{
				DetectionAngle = other.DetectionAngle;
			}
			if (other.DetectionDistance != 0.0)
			{
				DetectionDistance = other.DetectionDistance;
			}
			if (other.DetectionIgnoreWall != 0)
			{
				DetectionIgnoreWall = other.DetectionIgnoreWall;
			}
			detectionType_.Add(other.detectionType_);
			if (other.DistanceChase != 0.0)
			{
				DistanceChase = other.DistanceChase;
			}
			if (other.DistanceDefault != 0.0)
			{
				DistanceDefault = other.DistanceDefault;
			}
			if (other.DistanceRun != 0.0)
			{
				DistanceRun = other.DistanceRun;
			}
			if (other.EncounterAngle != 0.0)
			{
				EncounterAngle = other.EncounterAngle;
			}
			if (other.EncounterDistance != 0.0)
			{
				EncounterDistance = other.EncounterDistance;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.LasttimeChase != 0.0)
			{
				LasttimeChase = other.LasttimeChase;
			}
			if (other.Lv != 0)
			{
				Lv = other.Lv;
			}
			if (other.MoveIgnoreWall != 0)
			{
				MoveIgnoreWall = other.MoveIgnoreWall;
			}
			if (other.Moving != 0)
			{
				Moving = other.Moving;
			}
			if (other.SpeedChase != 0.0)
			{
				SpeedChase = other.SpeedChase;
			}
			if (other.SpeedDefault != 0.0)
			{
				SpeedDefault = other.SpeedDefault;
			}
			if (other.SpeedRun != 0.0)
			{
				SpeedRun = other.SpeedRun;
			}
			if (other.TimeChase != 0.0)
			{
				TimeChase = other.TimeChase;
			}
			if (other.TimeDefault != 0.0)
			{
				TimeDefault = other.TimeDefault;
			}
			if (other.TimeDiscovery != 0.0)
			{
				TimeDiscovery = other.TimeDiscovery;
			}
			if (other.TimeRun != 0.0)
			{
				TimeRun = other.TimeRun;
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
			case 9u:
				DetectionAngle = input.ReadDouble();
				break;
			case 17u:
				DetectionDistance = input.ReadDouble();
				break;
			case 24u:
				DetectionIgnoreWall = input.ReadInt32();
				break;
			case 32u:
			case 34u:
				detectionType_.AddEntriesFrom(ref input, _repeated_detectionType_codec);
				break;
			case 41u:
				DistanceChase = input.ReadDouble();
				break;
			case 49u:
				DistanceDefault = input.ReadDouble();
				break;
			case 57u:
				DistanceRun = input.ReadDouble();
				break;
			case 65u:
				EncounterAngle = input.ReadDouble();
				break;
			case 73u:
				EncounterDistance = input.ReadDouble();
				break;
			case 80u:
				Id = input.ReadInt32();
				break;
			case 89u:
				LasttimeChase = input.ReadDouble();
				break;
			case 96u:
				Lv = input.ReadInt32();
				break;
			case 104u:
				MoveIgnoreWall = input.ReadInt32();
				break;
			case 112u:
				Moving = input.ReadInt32();
				break;
			case 121u:
				SpeedChase = input.ReadDouble();
				break;
			case 129u:
				SpeedDefault = input.ReadDouble();
				break;
			case 137u:
				SpeedRun = input.ReadDouble();
				break;
			case 145u:
				TimeChase = input.ReadDouble();
				break;
			case 153u:
				TimeDefault = input.ReadDouble();
				break;
			case 161u:
				TimeDiscovery = input.ReadDouble();
				break;
			case 169u:
				TimeRun = input.ReadDouble();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
