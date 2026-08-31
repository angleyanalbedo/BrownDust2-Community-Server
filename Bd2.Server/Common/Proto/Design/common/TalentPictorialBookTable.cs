using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class TalentPictorialBookTable : IMessage<TalentPictorialBookTable>, IMessage, IEquatable<TalentPictorialBookTable>, IDeepCloneable<TalentPictorialBookTable>, IBufferMessage
{
	private static readonly MessageParser<TalentPictorialBookTable> _parser = new MessageParser<TalentPictorialBookTable>(() => new TalentPictorialBookTable());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int TalentIdFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_talentId_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> talentId_ = new RepeatedField<int>();

	public const int TalentPictorialDescLocalTextIdFieldNumber = 3;

	private int talentPictorialDescLocalTextId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TalentPictorialBookTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => TalentPictorialBookTableReflection.Descriptor.MessageTypes[0];

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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> TalentId => talentId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TalentPictorialDescLocalTextId
	{
		get
		{
			return talentPictorialDescLocalTextId_;
		}
		set
		{
			talentPictorialDescLocalTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TalentPictorialBookTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TalentPictorialBookTable(TalentPictorialBookTable other)
		: this()
	{
		id_ = other.id_;
		talentId_ = other.talentId_.Clone();
		talentPictorialDescLocalTextId_ = other.talentPictorialDescLocalTextId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TalentPictorialBookTable Clone()
	{
		return new TalentPictorialBookTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as TalentPictorialBookTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TalentPictorialBookTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && talentId_.Equals(other.talentId_) && TalentPictorialDescLocalTextId == other.TalentPictorialDescLocalTextId)
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
		num ^= talentId_.GetHashCode();
		if (TalentPictorialDescLocalTextId != 0)
		{
			num ^= TalentPictorialDescLocalTextId.GetHashCode();
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
		talentId_.WriteTo(ref output, _repeated_talentId_codec);
		if (TalentPictorialDescLocalTextId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(TalentPictorialDescLocalTextId);
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
		num += talentId_.CalculateSize(_repeated_talentId_codec);
		if (TalentPictorialDescLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TalentPictorialDescLocalTextId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(TalentPictorialBookTable other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			talentId_.Add(other.talentId_);
			if (other.TalentPictorialDescLocalTextId != 0)
			{
				TalentPictorialDescLocalTextId = other.TalentPictorialDescLocalTextId;
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
			case 24u:
				TalentPictorialDescLocalTextId = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 16u:
			case 18u:
				talentId_.AddEntriesFrom(ref input, _repeated_talentId_codec);
				break;
			}
		}
	}
}
