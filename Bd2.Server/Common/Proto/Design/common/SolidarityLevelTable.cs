using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class SolidarityLevelTable : IMessage<SolidarityLevelTable>, IMessage, IEquatable<SolidarityLevelTable>, IDeepCloneable<SolidarityLevelTable>, IBufferMessage
{
	private static readonly MessageParser<SolidarityLevelTable> _parser = new MessageParser<SolidarityLevelTable>(() => new SolidarityLevelTable());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int RewardCountFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_rewardCount_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> rewardCount_ = new RepeatedField<int>();

	public const int RewardIdFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_rewardId_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> rewardId_ = new RepeatedField<int>();

	public const int RewardTypeFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_rewardType_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> rewardType_ = new RepeatedField<int>();

	public const int SolidarityLevelRequireFieldNumber = 5;

	private int solidarityLevelRequire_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SolidarityLevelTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => SolidarityLevelTableReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<int> RewardCount => rewardCount_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> RewardId => rewardId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> RewardType => rewardType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SolidarityLevelRequire
	{
		get
		{
			return solidarityLevelRequire_;
		}
		set
		{
			solidarityLevelRequire_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SolidarityLevelTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SolidarityLevelTable(SolidarityLevelTable other)
		: this()
	{
		id_ = other.id_;
		rewardCount_ = other.rewardCount_.Clone();
		rewardId_ = other.rewardId_.Clone();
		rewardType_ = other.rewardType_.Clone();
		solidarityLevelRequire_ = other.solidarityLevelRequire_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SolidarityLevelTable Clone()
	{
		return new SolidarityLevelTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SolidarityLevelTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(SolidarityLevelTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && rewardCount_.Equals(other.rewardCount_) && rewardId_.Equals(other.rewardId_) && rewardType_.Equals(other.rewardType_) && SolidarityLevelRequire == other.SolidarityLevelRequire)
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
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		num ^= rewardCount_.GetHashCode();
		num ^= rewardId_.GetHashCode();
		num ^= rewardType_.GetHashCode();
		if (SolidarityLevelRequire != 0)
		{
			num ^= SolidarityLevelRequire.GetHashCode();
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
		rewardCount_.WriteTo(ref output, _repeated_rewardCount_codec);
		rewardId_.WriteTo(ref output, _repeated_rewardId_codec);
		rewardType_.WriteTo(ref output, _repeated_rewardType_codec);
		if (SolidarityLevelRequire != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(SolidarityLevelRequire);
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
		num += rewardCount_.CalculateSize(_repeated_rewardCount_codec);
		num += rewardId_.CalculateSize(_repeated_rewardId_codec);
		num += rewardType_.CalculateSize(_repeated_rewardType_codec);
		if (SolidarityLevelRequire != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SolidarityLevelRequire);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SolidarityLevelTable other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			rewardCount_.Add(other.rewardCount_);
			rewardId_.Add(other.rewardId_);
			rewardType_.Add(other.rewardType_);
			if (other.SolidarityLevelRequire != 0)
			{
				SolidarityLevelRequire = other.SolidarityLevelRequire;
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
				Id = input.ReadInt32();
				break;
			case 16u:
			case 18u:
				rewardCount_.AddEntriesFrom(ref input, _repeated_rewardCount_codec);
				break;
			case 40u:
				SolidarityLevelRequire = input.ReadInt32();
				break;
			case 32u:
			case 34u:
				rewardType_.AddEntriesFrom(ref input, _repeated_rewardType_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 24u:
			case 26u:
				rewardId_.AddEntriesFrom(ref input, _repeated_rewardId_codec);
				break;
			}
		}
	}
}
