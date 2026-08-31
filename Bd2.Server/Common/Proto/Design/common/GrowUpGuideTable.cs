using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class GrowUpGuideTable : IMessage<GrowUpGuideTable>, IMessage, IEquatable<GrowUpGuideTable>, IDeepCloneable<GrowUpGuideTable>, IBufferMessage
{
	private static readonly MessageParser<GrowUpGuideTable> _parser = new MessageParser<GrowUpGuideTable>(() => new GrowUpGuideTable());

	private UnknownFieldSet _unknownFields;

	public const int CategoryFieldNumber = 1;

	private int category_;

	public const int CategoryIdFieldNumber = 2;

	private int categoryId_;

	public const int DescTextFieldNumber = 3;

	private int descText_;

	public const int GroupIdFieldNumber = 4;

	private int groupId_;

	public const int GuideTutorialIdFieldNumber = 5;

	private static readonly FieldCodec<int> _repeated_guideTutorialId_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> guideTutorialId_ = new RepeatedField<int>();

	public const int ShortCutIdFieldNumber = 6;

	private int shortCutId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GrowUpGuideTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => GrowUpGuideTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Category
	{
		get
		{
			return category_;
		}
		set
		{
			category_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CategoryId
	{
		get
		{
			return categoryId_;
		}
		set
		{
			categoryId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DescText
	{
		get
		{
			return descText_;
		}
		set
		{
			descText_ = value;
		}
	}

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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> GuideTutorialId => guideTutorialId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ShortCutId
	{
		get
		{
			return shortCutId_;
		}
		set
		{
			shortCutId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GrowUpGuideTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GrowUpGuideTable(GrowUpGuideTable other)
		: this()
	{
		category_ = other.category_;
		categoryId_ = other.categoryId_;
		descText_ = other.descText_;
		groupId_ = other.groupId_;
		guideTutorialId_ = other.guideTutorialId_.Clone();
		shortCutId_ = other.shortCutId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GrowUpGuideTable Clone()
	{
		return new GrowUpGuideTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GrowUpGuideTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GrowUpGuideTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Category == other.Category && CategoryId == other.CategoryId && DescText == other.DescText && GroupId == other.GroupId && guideTutorialId_.Equals(other.guideTutorialId_) && ShortCutId == other.ShortCutId)
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
		if (Category != 0)
		{
			num ^= Category.GetHashCode();
		}
		if (CategoryId != 0)
		{
			num ^= CategoryId.GetHashCode();
		}
		if (DescText != 0)
		{
			num ^= DescText.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		num ^= guideTutorialId_.GetHashCode();
		if (ShortCutId != 0)
		{
			num ^= ShortCutId.GetHashCode();
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (Category != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Category);
		}
		if (CategoryId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(CategoryId);
		}
		if (DescText != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(DescText);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(GroupId);
		}
		guideTutorialId_.WriteTo(ref output, _repeated_guideTutorialId_codec);
		if (ShortCutId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(ShortCutId);
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
		if (Category != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Category);
		}
		if (CategoryId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CategoryId);
		}
		if (DescText != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DescText);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		num += guideTutorialId_.CalculateSize(_repeated_guideTutorialId_codec);
		if (ShortCutId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ShortCutId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GrowUpGuideTable other)
	{
		if (other != null)
		{
			if (other.Category != 0)
			{
				Category = other.Category;
			}
			if (other.CategoryId != 0)
			{
				CategoryId = other.CategoryId;
			}
			if (other.DescText != 0)
			{
				DescText = other.DescText;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			guideTutorialId_.Add(other.guideTutorialId_);
			if (other.ShortCutId != 0)
			{
				ShortCutId = other.ShortCutId;
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
			case 32u:
				GroupId = input.ReadInt32();
				break;
			case 48u:
				ShortCutId = input.ReadInt32();
				break;
			case 40u:
			case 42u:
				guideTutorialId_.AddEntriesFrom(ref input, _repeated_guideTutorialId_codec);
				break;
			case 8u:
				Category = input.ReadInt32();
				break;
			case 16u:
				CategoryId = input.ReadInt32();
				break;
			case 24u:
				DescText = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
