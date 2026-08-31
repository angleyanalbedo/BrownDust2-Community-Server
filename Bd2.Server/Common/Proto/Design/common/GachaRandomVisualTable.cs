using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class GachaRandomVisualTable : IMessage<GachaRandomVisualTable>, IMessage, IEquatable<GachaRandomVisualTable>, IDeepCloneable<GachaRandomVisualTable>, IBufferMessage
{
	private static readonly MessageParser<GachaRandomVisualTable> _parser = new MessageParser<GachaRandomVisualTable>(() => new GachaRandomVisualTable());

	private UnknownFieldSet _unknownFields;

	public const int GradeFieldNumber = 1;

	private int grade_;

	public const int IdFieldNumber = 2;

	private int id_;

	public const int RandomVisualIdFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_randomVisualId_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> randomVisualId_ = new RepeatedField<int>();

	public const int RatioFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_ratio_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> ratio_ = new RepeatedField<int>();

	public const int TypeFieldNumber = 5;

	private int type_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GachaRandomVisualTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => GachaRandomVisualTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Grade
	{
		get
		{
			return grade_;
		}
		set
		{
			grade_ = value;
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> RandomVisualId => randomVisualId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> Ratio => ratio_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public GachaRandomVisualTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaRandomVisualTable(GachaRandomVisualTable other)
		: this()
	{
		grade_ = other.grade_;
		id_ = other.id_;
		randomVisualId_ = other.randomVisualId_.Clone();
		ratio_ = other.ratio_.Clone();
		type_ = other.type_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaRandomVisualTable Clone()
	{
		return new GachaRandomVisualTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as GachaRandomVisualTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GachaRandomVisualTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Grade == other.Grade && Id == other.Id && randomVisualId_.Equals(other.randomVisualId_) && ratio_.Equals(other.ratio_) && Type == other.Type)
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
		if (Grade != 0)
		{
			num ^= Grade.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		num ^= randomVisualId_.GetHashCode();
		num ^= ratio_.GetHashCode();
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
		if (Grade != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Grade);
		}
		if (Id != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Id);
		}
		randomVisualId_.WriteTo(ref output, _repeated_randomVisualId_codec);
		ratio_.WriteTo(ref output, _repeated_ratio_codec);
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
		if (Grade != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Grade);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		num += randomVisualId_.CalculateSize(_repeated_randomVisualId_codec);
		num += ratio_.CalculateSize(_repeated_ratio_codec);
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
	public void MergeFrom(GachaRandomVisualTable other)
	{
		if (other != null)
		{
			if (other.Grade != 0)
			{
				Grade = other.Grade;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			randomVisualId_.Add(other.randomVisualId_);
			ratio_.Add(other.ratio_);
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			case 40u:
				Type = input.ReadInt32();
				break;
			case 32u:
			case 34u:
				ratio_.AddEntriesFrom(ref input, _repeated_ratio_codec);
				break;
			case 8u:
				Grade = input.ReadInt32();
				break;
			case 16u:
				Id = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 24u:
			case 26u:
				randomVisualId_.AddEntriesFrom(ref input, _repeated_randomVisualId_codec);
				break;
			}
		}
	}
}
