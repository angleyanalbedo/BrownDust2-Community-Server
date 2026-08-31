using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class CharGrowthTable : IMessage<CharGrowthTable>, IMessage, IEquatable<CharGrowthTable>, IDeepCloneable<CharGrowthTable>, IBufferMessage
{
	private static readonly MessageParser<CharGrowthTable> _parser = new MessageParser<CharGrowthTable>(() => new CharGrowthTable());

	private UnknownFieldSet _unknownFields;

	public const int CharLevelGroupIdFieldNumber = 1;

	private int charLevelGroupId_;

	public const int ClassupItemCountFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_classupItemCount_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> classupItemCount_ = new RepeatedField<int>();

	public const int ClassupItemIdFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_classupItemId_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> classupItemId_ = new RepeatedField<int>();

	public const int ClassupItemTypeFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_classupItemType_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> classupItemType_ = new RepeatedField<int>();

	public const int DismissItemCountFieldNumber = 5;

	private static readonly FieldCodec<int> _repeated_dismissItemCount_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> dismissItemCount_ = new RepeatedField<int>();

	public const int DismissItemIdFieldNumber = 6;

	private static readonly FieldCodec<int> _repeated_dismissItemId_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> dismissItemId_ = new RepeatedField<int>();

	public const int DismissItemTypeFieldNumber = 7;

	private static readonly FieldCodec<int> _repeated_dismissItemType_codec = FieldCodec.ForInt32(58u);

	private readonly RepeatedField<int> dismissItemType_ = new RepeatedField<int>();

	public const int IdFieldNumber = 8;

	private int id_;

	public const int MaxLevelFieldNumber = 9;

	private int maxLevel_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CharGrowthTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => CharGrowthTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CharLevelGroupId
	{
		get
		{
			return charLevelGroupId_;
		}
		set
		{
			charLevelGroupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> ClassupItemCount => classupItemCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> ClassupItemId => classupItemId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> ClassupItemType => classupItemType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> DismissItemCount => dismissItemCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> DismissItemId => dismissItemId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> DismissItemType => dismissItemType_;

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
	public int MaxLevel
	{
		get
		{
			return maxLevel_;
		}
		set
		{
			maxLevel_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharGrowthTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharGrowthTable(CharGrowthTable other)
		: this()
	{
		charLevelGroupId_ = other.charLevelGroupId_;
		classupItemCount_ = other.classupItemCount_.Clone();
		classupItemId_ = other.classupItemId_.Clone();
		classupItemType_ = other.classupItemType_.Clone();
		dismissItemCount_ = other.dismissItemCount_.Clone();
		dismissItemId_ = other.dismissItemId_.Clone();
		dismissItemType_ = other.dismissItemType_.Clone();
		id_ = other.id_;
		maxLevel_ = other.maxLevel_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharGrowthTable Clone()
	{
		return new CharGrowthTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CharGrowthTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharGrowthTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (CharLevelGroupId == other.CharLevelGroupId && classupItemCount_.Equals(other.classupItemCount_) && classupItemId_.Equals(other.classupItemId_) && classupItemType_.Equals(other.classupItemType_) && dismissItemCount_.Equals(other.dismissItemCount_) && dismissItemId_.Equals(other.dismissItemId_) && dismissItemType_.Equals(other.dismissItemType_) && Id == other.Id && MaxLevel == other.MaxLevel)
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
		if (CharLevelGroupId != 0)
		{
			num ^= CharLevelGroupId.GetHashCode();
		}
		num ^= classupItemCount_.GetHashCode();
		num ^= classupItemId_.GetHashCode();
		num ^= classupItemType_.GetHashCode();
		num ^= dismissItemCount_.GetHashCode();
		num ^= dismissItemId_.GetHashCode();
		num ^= dismissItemType_.GetHashCode();
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (MaxLevel != 0)
		{
			num ^= MaxLevel.GetHashCode();
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
		if (CharLevelGroupId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(CharLevelGroupId);
		}
		classupItemCount_.WriteTo(ref output, _repeated_classupItemCount_codec);
		classupItemId_.WriteTo(ref output, _repeated_classupItemId_codec);
		classupItemType_.WriteTo(ref output, _repeated_classupItemType_codec);
		dismissItemCount_.WriteTo(ref output, _repeated_dismissItemCount_codec);
		dismissItemId_.WriteTo(ref output, _repeated_dismissItemId_codec);
		dismissItemType_.WriteTo(ref output, _repeated_dismissItemType_codec);
		if (Id != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(Id);
		}
		if (MaxLevel != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(MaxLevel);
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
		if (CharLevelGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CharLevelGroupId);
		}
		num += classupItemCount_.CalculateSize(_repeated_classupItemCount_codec);
		num += classupItemId_.CalculateSize(_repeated_classupItemId_codec);
		num += classupItemType_.CalculateSize(_repeated_classupItemType_codec);
		num += dismissItemCount_.CalculateSize(_repeated_dismissItemCount_codec);
		num += dismissItemId_.CalculateSize(_repeated_dismissItemId_codec);
		num += dismissItemType_.CalculateSize(_repeated_dismissItemType_codec);
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (MaxLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxLevel);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharGrowthTable other)
	{
		if (other != null)
		{
			if (other.CharLevelGroupId != 0)
			{
				CharLevelGroupId = other.CharLevelGroupId;
			}
			classupItemCount_.Add(other.classupItemCount_);
			classupItemId_.Add(other.classupItemId_);
			classupItemType_.Add(other.classupItemType_);
			dismissItemCount_.Add(other.dismissItemCount_);
			dismissItemId_.Add(other.dismissItemId_);
			dismissItemType_.Add(other.dismissItemType_);
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.MaxLevel != 0)
			{
				MaxLevel = other.MaxLevel;
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
				CharLevelGroupId = input.ReadInt32();
				break;
			case 16u:
			case 18u:
				classupItemCount_.AddEntriesFrom(ref input, _repeated_classupItemCount_codec);
				break;
			case 24u:
			case 26u:
				classupItemId_.AddEntriesFrom(ref input, _repeated_classupItemId_codec);
				break;
			case 32u:
			case 34u:
				classupItemType_.AddEntriesFrom(ref input, _repeated_classupItemType_codec);
				break;
			case 40u:
			case 42u:
				dismissItemCount_.AddEntriesFrom(ref input, _repeated_dismissItemCount_codec);
				break;
			case 48u:
			case 50u:
				dismissItemId_.AddEntriesFrom(ref input, _repeated_dismissItemId_codec);
				break;
			case 56u:
			case 58u:
				dismissItemType_.AddEntriesFrom(ref input, _repeated_dismissItemType_codec);
				break;
			case 64u:
				Id = input.ReadInt32();
				break;
			case 72u:
				MaxLevel = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
