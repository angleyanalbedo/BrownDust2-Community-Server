using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class BuffImmuneGroupTable : IMessage<BuffImmuneGroupTable>, IMessage, IEquatable<BuffImmuneGroupTable>, IDeepCloneable<BuffImmuneGroupTable>, IBufferMessage
{
	private static readonly MessageParser<BuffImmuneGroupTable> _parser = new MessageParser<BuffImmuneGroupTable>(() => new BuffImmuneGroupTable());

	private UnknownFieldSet _unknownFields;

	public const int BuffClassTypeFieldNumber = 1;

	private static readonly FieldCodec<string> _repeated_buffClassType_codec = FieldCodec.ForString(10u);

	private readonly RepeatedField<string> buffClassType_ = new RepeatedField<string>();

	public const int BuffGroupTypeFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_buffGroupType_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> buffGroupType_ = new RepeatedField<int>();

	public const int BuffImmuneApplySkillTextIdFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_buffImmuneApplySkillTextId_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> buffImmuneApplySkillTextId_ = new RepeatedField<int>();

	public const int BuffSubTypeFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_buffSubType_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> buffSubType_ = new RepeatedField<int>();

	public const int IdFieldNumber = 5;

	private int id_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BuffImmuneGroupTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => BuffImmuneGroupTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<string> BuffClassType => buffClassType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> BuffGroupType => buffGroupType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> BuffImmuneApplySkillTextId => buffImmuneApplySkillTextId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> BuffSubType => buffSubType_;

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
	public BuffImmuneGroupTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BuffImmuneGroupTable(BuffImmuneGroupTable other)
		: this()
	{
		buffClassType_ = other.buffClassType_.Clone();
		buffGroupType_ = other.buffGroupType_.Clone();
		buffImmuneApplySkillTextId_ = other.buffImmuneApplySkillTextId_.Clone();
		buffSubType_ = other.buffSubType_.Clone();
		id_ = other.id_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BuffImmuneGroupTable Clone()
	{
		return new BuffImmuneGroupTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BuffImmuneGroupTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BuffImmuneGroupTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (buffClassType_.Equals(other.buffClassType_) && buffGroupType_.Equals(other.buffGroupType_) && buffImmuneApplySkillTextId_.Equals(other.buffImmuneApplySkillTextId_) && buffSubType_.Equals(other.buffSubType_) && Id == other.Id)
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
		num ^= buffClassType_.GetHashCode();
		num ^= buffGroupType_.GetHashCode();
		num ^= buffImmuneApplySkillTextId_.GetHashCode();
		num ^= buffSubType_.GetHashCode();
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
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
		buffClassType_.WriteTo(ref output, _repeated_buffClassType_codec);
		buffGroupType_.WriteTo(ref output, _repeated_buffGroupType_codec);
		buffImmuneApplySkillTextId_.WriteTo(ref output, _repeated_buffImmuneApplySkillTextId_codec);
		buffSubType_.WriteTo(ref output, _repeated_buffSubType_codec);
		if (Id != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Id);
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
		num += buffClassType_.CalculateSize(_repeated_buffClassType_codec);
		num += buffGroupType_.CalculateSize(_repeated_buffGroupType_codec);
		num += buffImmuneApplySkillTextId_.CalculateSize(_repeated_buffImmuneApplySkillTextId_codec);
		num += buffSubType_.CalculateSize(_repeated_buffSubType_codec);
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BuffImmuneGroupTable other)
	{
		if (other != null)
		{
			buffClassType_.Add(other.buffClassType_);
			buffGroupType_.Add(other.buffGroupType_);
			buffImmuneApplySkillTextId_.Add(other.buffImmuneApplySkillTextId_);
			buffSubType_.Add(other.buffSubType_);
			if (other.Id != 0)
			{
				Id = other.Id;
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
			case 10u:
				buffClassType_.AddEntriesFrom(ref input, _repeated_buffClassType_codec);
				break;
			case 16u:
			case 18u:
				buffGroupType_.AddEntriesFrom(ref input, _repeated_buffGroupType_codec);
				break;
			case 40u:
				Id = input.ReadInt32();
				break;
			case 32u:
			case 34u:
				buffSubType_.AddEntriesFrom(ref input, _repeated_buffSubType_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 24u:
			case 26u:
				buffImmuneApplySkillTextId_.AddEntriesFrom(ref input, _repeated_buffImmuneApplySkillTextId_codec);
				break;
			}
		}
	}
}
