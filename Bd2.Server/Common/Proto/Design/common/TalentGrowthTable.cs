using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class TalentGrowthTable : IMessage<TalentGrowthTable>, IMessage, IEquatable<TalentGrowthTable>, IDeepCloneable<TalentGrowthTable>, IBufferMessage
{
	private static readonly MessageParser<TalentGrowthTable> _parser = new MessageParser<TalentGrowthTable>(() => new TalentGrowthTable());

	private UnknownFieldSet _unknownFields;

	public const int GroupIdFieldNumber = 1;

	private int groupId_;

	public const int GrowthItemCountFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_growthItemCount_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> growthItemCount_ = new RepeatedField<int>();

	public const int GrowthItemIdFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_growthItemId_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> growthItemId_ = new RepeatedField<int>();

	public const int GrowthItemTypeFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_growthItemType_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> growthItemType_ = new RepeatedField<int>();

	public const int IdFieldNumber = 5;

	private int id_;

	public const int NeedExpFieldNumber = 6;

	private int needExp_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TalentGrowthTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => TalentGrowthTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> GrowthItemCount => growthItemCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> GrowthItemId => growthItemId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> GrowthItemType => growthItemType_;

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
	public int NeedExp
	{
		get
		{
			return needExp_;
		}
		set
		{
			needExp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TalentGrowthTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TalentGrowthTable(TalentGrowthTable other)
		: this()
	{
		groupId_ = other.groupId_;
		growthItemCount_ = other.growthItemCount_.Clone();
		growthItemId_ = other.growthItemId_.Clone();
		growthItemType_ = other.growthItemType_.Clone();
		id_ = other.id_;
		needExp_ = other.needExp_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TalentGrowthTable Clone()
	{
		return new TalentGrowthTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as TalentGrowthTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TalentGrowthTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (GroupId == other.GroupId && growthItemCount_.Equals(other.growthItemCount_) && growthItemId_.Equals(other.growthItemId_) && growthItemType_.Equals(other.growthItemType_) && Id == other.Id && NeedExp == other.NeedExp)
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
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		num ^= growthItemCount_.GetHashCode();
		num ^= growthItemId_.GetHashCode();
		num ^= growthItemType_.GetHashCode();
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (NeedExp != 0)
		{
			num ^= NeedExp.GetHashCode();
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
		if (GroupId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(GroupId);
		}
		growthItemCount_.WriteTo(ref output, _repeated_growthItemCount_codec);
		growthItemId_.WriteTo(ref output, _repeated_growthItemId_codec);
		growthItemType_.WriteTo(ref output, _repeated_growthItemType_codec);
		if (Id != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Id);
		}
		if (NeedExp != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(NeedExp);
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
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		num += growthItemCount_.CalculateSize(_repeated_growthItemCount_codec);
		num += growthItemId_.CalculateSize(_repeated_growthItemId_codec);
		num += growthItemType_.CalculateSize(_repeated_growthItemType_codec);
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (NeedExp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NeedExp);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TalentGrowthTable other)
	{
		if (other != null)
		{
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			growthItemCount_.Add(other.growthItemCount_);
			growthItemId_.Add(other.growthItemId_);
			growthItemType_.Add(other.growthItemType_);
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.NeedExp != 0)
			{
				NeedExp = other.NeedExp;
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
				GroupId = input.ReadInt32();
				break;
			case 16u:
			case 18u:
				growthItemCount_.AddEntriesFrom(ref input, _repeated_growthItemCount_codec);
				break;
			case 40u:
				Id = input.ReadInt32();
				break;
			case 48u:
				NeedExp = input.ReadInt32();
				break;
			case 32u:
			case 34u:
				growthItemType_.AddEntriesFrom(ref input, _repeated_growthItemType_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 24u:
			case 26u:
				growthItemId_.AddEntriesFrom(ref input, _repeated_growthItemId_codec);
				break;
			}
		}
	}
}
