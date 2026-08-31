using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class FieldMonsterBuffTable : IMessage<FieldMonsterBuffTable>, IMessage, IEquatable<FieldMonsterBuffTable>, IDeepCloneable<FieldMonsterBuffTable>, IBufferMessage
{
	private static readonly MessageParser<FieldMonsterBuffTable> _parser = new MessageParser<FieldMonsterBuffTable>(() => new FieldMonsterBuffTable());

	private UnknownFieldSet _unknownFields;

	public const int AlertDetectionAngleFieldNumber = 1;

	private double alertDetectionAngle_;

	public const int AlertDetectionDistanceFieldNumber = 2;

	private double alertDetectionDistance_;

	public const int BuffTImeFieldNumber = 3;

	private double buffTIme_;

	public const int DetectionIgnoreWallFieldNumber = 4;

	private int detectionIgnoreWall_;

	public const int DetectionTypeFieldNumber = 5;

	private static readonly FieldCodec<int> _repeated_detectionType_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> detectionType_ = new RepeatedField<int>();

	public const int DistanceChaseFieldNumber = 6;

	private double distanceChase_;

	public const int IdFieldNumber = 7;

	private int id_;

	public const int MoveSpeedFieldNumber = 8;

	private double moveSpeed_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FieldMonsterBuffTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FieldMonsterBuffTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double AlertDetectionAngle
	{
		get
		{
			return alertDetectionAngle_;
		}
		set
		{
			alertDetectionAngle_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double AlertDetectionDistance
	{
		get
		{
			return alertDetectionDistance_;
		}
		set
		{
			alertDetectionDistance_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double BuffTIme
	{
		get
		{
			return buffTIme_;
		}
		set
		{
			buffTIme_ = value;
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public double MoveSpeed
	{
		get
		{
			return moveSpeed_;
		}
		set
		{
			moveSpeed_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FieldMonsterBuffTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FieldMonsterBuffTable(FieldMonsterBuffTable other)
		: this()
	{
		alertDetectionAngle_ = other.alertDetectionAngle_;
		alertDetectionDistance_ = other.alertDetectionDistance_;
		buffTIme_ = other.buffTIme_;
		detectionIgnoreWall_ = other.detectionIgnoreWall_;
		detectionType_ = other.detectionType_.Clone();
		distanceChase_ = other.distanceChase_;
		id_ = other.id_;
		moveSpeed_ = other.moveSpeed_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FieldMonsterBuffTable Clone()
	{
		return new FieldMonsterBuffTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FieldMonsterBuffTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FieldMonsterBuffTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(AlertDetectionAngle, other.AlertDetectionAngle) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(AlertDetectionDistance, other.AlertDetectionDistance) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(BuffTIme, other.BuffTIme) && DetectionIgnoreWall == other.DetectionIgnoreWall && detectionType_.Equals(other.detectionType_) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(DistanceChase, other.DistanceChase) && Id == other.Id && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(MoveSpeed, other.MoveSpeed))
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
		if (AlertDetectionAngle != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(AlertDetectionAngle);
		}
		if (AlertDetectionDistance != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(AlertDetectionDistance);
		}
		if (BuffTIme != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(BuffTIme);
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
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (MoveSpeed != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(MoveSpeed);
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
		if (AlertDetectionAngle != 0.0)
		{
			output.WriteRawTag(9);
			output.WriteDouble(AlertDetectionAngle);
		}
		if (AlertDetectionDistance != 0.0)
		{
			output.WriteRawTag(17);
			output.WriteDouble(AlertDetectionDistance);
		}
		if (BuffTIme != 0.0)
		{
			output.WriteRawTag(25);
			output.WriteDouble(BuffTIme);
		}
		if (DetectionIgnoreWall != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(DetectionIgnoreWall);
		}
		detectionType_.WriteTo(ref output, _repeated_detectionType_codec);
		if (DistanceChase != 0.0)
		{
			output.WriteRawTag(49);
			output.WriteDouble(DistanceChase);
		}
		if (Id != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(Id);
		}
		if (MoveSpeed != 0.0)
		{
			output.WriteRawTag(65);
			output.WriteDouble(MoveSpeed);
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
		if (AlertDetectionAngle != 0.0)
		{
			num += 9;
		}
		if (AlertDetectionDistance != 0.0)
		{
			num += 9;
		}
		if (BuffTIme != 0.0)
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
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (MoveSpeed != 0.0)
		{
			num += 9;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(FieldMonsterBuffTable other)
	{
		if (other != null)
		{
			if (other.AlertDetectionAngle != 0.0)
			{
				AlertDetectionAngle = other.AlertDetectionAngle;
			}
			if (other.AlertDetectionDistance != 0.0)
			{
				AlertDetectionDistance = other.AlertDetectionDistance;
			}
			if (other.BuffTIme != 0.0)
			{
				BuffTIme = other.BuffTIme;
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
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.MoveSpeed != 0.0)
			{
				MoveSpeed = other.MoveSpeed;
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
				AlertDetectionAngle = input.ReadDouble();
				break;
			case 17u:
				AlertDetectionDistance = input.ReadDouble();
				break;
			case 25u:
				BuffTIme = input.ReadDouble();
				break;
			case 32u:
				DetectionIgnoreWall = input.ReadInt32();
				break;
			case 40u:
			case 42u:
				detectionType_.AddEntriesFrom(ref input, _repeated_detectionType_codec);
				break;
			case 49u:
				DistanceChase = input.ReadDouble();
				break;
			case 56u:
				Id = input.ReadInt32();
				break;
			case 65u:
				MoveSpeed = input.ReadDouble();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
