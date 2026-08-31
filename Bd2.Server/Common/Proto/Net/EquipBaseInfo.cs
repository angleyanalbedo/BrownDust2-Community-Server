using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EquipBaseInfo : IMessage<EquipBaseInfo>, IMessage, IEquatable<EquipBaseInfo>, IDeepCloneable<EquipBaseInfo>, IBufferMessage
{
	private static readonly MessageParser<EquipBaseInfo> _parser = new MessageParser<EquipBaseInfo>(() => new EquipBaseInfo());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int LevelFieldNumber = 2;

	private int level_;

	public const int MainOptionFieldNumber = 3;

	private static readonly FieldCodec<EquipOptionInfo> _repeated_mainOption_codec = FieldCodec.ForMessage(26u, EquipOptionInfo.Parser);

	private readonly RepeatedField<EquipOptionInfo> mainOption_ = new RepeatedField<EquipOptionInfo>();

	public const int SubOptionFieldNumber = 4;

	private static readonly FieldCodec<EquipOptionInfo> _repeated_subOption_codec = FieldCodec.ForMessage(34u, EquipOptionInfo.Parser);

	private readonly RepeatedField<EquipOptionInfo> subOption_ = new RepeatedField<EquipOptionInfo>();

	public const int PrivateOptionFieldNumber = 5;

	private EquipOptionInfo privateOption_;

	public const int RankFieldNumber = 6;

	private static readonly FieldCodec<int> _repeated_rank_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> rank_ = new RepeatedField<int>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EquipBaseInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EquipBaseInfoReflection.Descriptor.MessageTypes[0];

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
	public int Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<EquipOptionInfo> MainOption => mainOption_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<EquipOptionInfo> SubOption => subOption_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipOptionInfo PrivateOption
	{
		get
		{
			return privateOption_;
		}
		set
		{
			privateOption_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> Rank => rank_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipBaseInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipBaseInfo(EquipBaseInfo other)
		: this()
	{
		id_ = other.id_;
		level_ = other.level_;
		mainOption_ = other.mainOption_.Clone();
		subOption_ = other.subOption_.Clone();
		privateOption_ = ((other.privateOption_ != null) ? other.privateOption_.Clone() : null);
		rank_ = other.rank_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EquipBaseInfo Clone()
	{
		return new EquipBaseInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EquipBaseInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EquipBaseInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && Level == other.Level && mainOption_.Equals(other.mainOption_) && subOption_.Equals(other.subOption_) && object.Equals(PrivateOption, other.PrivateOption) && rank_.Equals(other.rank_))
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
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		num ^= mainOption_.GetHashCode();
		num ^= subOption_.GetHashCode();
		if (privateOption_ != null)
		{
			num ^= PrivateOption.GetHashCode();
		}
		num ^= rank_.GetHashCode();
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
		if (Level != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Level);
		}
		mainOption_.WriteTo(ref output, _repeated_mainOption_codec);
		subOption_.WriteTo(ref output, _repeated_subOption_codec);
		if (privateOption_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(PrivateOption);
		}
		rank_.WriteTo(ref output, _repeated_rank_codec);
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
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Level);
		}
		num += mainOption_.CalculateSize(_repeated_mainOption_codec);
		num += subOption_.CalculateSize(_repeated_subOption_codec);
		if (privateOption_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PrivateOption);
		}
		num += rank_.CalculateSize(_repeated_rank_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EquipBaseInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Id != 0)
		{
			Id = other.Id;
		}
		if (other.Level != 0)
		{
			Level = other.Level;
		}
		mainOption_.Add(other.mainOption_);
		subOption_.Add(other.subOption_);
		if (other.privateOption_ != null)
		{
			if (privateOption_ == null)
			{
				PrivateOption = new EquipOptionInfo();
			}
			PrivateOption.MergeFrom(other.PrivateOption);
		}
		rank_.Add(other.rank_);
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				Id = input.ReadInt32();
				break;
			case 16u:
				Level = input.ReadInt32();
				break;
			case 26u:
				mainOption_.AddEntriesFrom(ref input, _repeated_mainOption_codec);
				break;
			case 34u:
				subOption_.AddEntriesFrom(ref input, _repeated_subOption_codec);
				break;
			case 42u:
				if (privateOption_ == null)
				{
					PrivateOption = new EquipOptionInfo();
				}
				input.ReadMessage(PrivateOption);
				break;
			case 48u:
			case 50u:
				rank_.AddEntriesFrom(ref input, _repeated_rank_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
