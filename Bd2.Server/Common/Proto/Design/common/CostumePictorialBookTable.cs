using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class CostumePictorialBookTable : IMessage<CostumePictorialBookTable>, IMessage, IEquatable<CostumePictorialBookTable>, IDeepCloneable<CostumePictorialBookTable>, IBufferMessage
{
	private static readonly MessageParser<CostumePictorialBookTable> _parser = new MessageParser<CostumePictorialBookTable>(() => new CostumePictorialBookTable());

	private UnknownFieldSet _unknownFields;

	public const int ChaUniqueIdFieldNumber = 1;

	private int chaUniqueId_;

	public const int CollectionBuffIdFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_collectionBuffId_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> collectionBuffId_ = new RepeatedField<int>();

	public const int CostumeIDFieldNumber = 3;

	private int costumeID_;

	public const int EnhanceValueFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_enhanceValue_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> enhanceValue_ = new RepeatedField<int>();

	public const int IdFieldNumber = 5;

	private int id_;

	public const int TabTypeFieldNumber = 6;

	private int tabType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CostumePictorialBookTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CostumePictorialBookTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ChaUniqueId
	{
		get
		{
			return chaUniqueId_;
		}
		set
		{
			chaUniqueId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> CollectionBuffId => collectionBuffId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CostumeID
	{
		get
		{
			return costumeID_;
		}
		set
		{
			costumeID_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> EnhanceValue => enhanceValue_;

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
	public int TabType
	{
		get
		{
			return tabType_;
		}
		set
		{
			tabType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CostumePictorialBookTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CostumePictorialBookTable(CostumePictorialBookTable other)
		: this()
	{
		chaUniqueId_ = other.chaUniqueId_;
		collectionBuffId_ = other.collectionBuffId_.Clone();
		costumeID_ = other.costumeID_;
		enhanceValue_ = other.enhanceValue_.Clone();
		id_ = other.id_;
		tabType_ = other.tabType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CostumePictorialBookTable Clone()
	{
		return new CostumePictorialBookTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CostumePictorialBookTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CostumePictorialBookTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (ChaUniqueId == other.ChaUniqueId && collectionBuffId_.Equals(other.collectionBuffId_) && CostumeID == other.CostumeID && enhanceValue_.Equals(other.enhanceValue_) && Id == other.Id && TabType == other.TabType)
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
		if (ChaUniqueId != 0)
		{
			num ^= ChaUniqueId.GetHashCode();
		}
		num ^= collectionBuffId_.GetHashCode();
		if (CostumeID != 0)
		{
			num ^= CostumeID.GetHashCode();
		}
		num ^= enhanceValue_.GetHashCode();
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (TabType != 0)
		{
			num ^= TabType.GetHashCode();
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
		if (ChaUniqueId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ChaUniqueId);
		}
		collectionBuffId_.WriteTo(ref output, _repeated_collectionBuffId_codec);
		if (CostumeID != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(CostumeID);
		}
		enhanceValue_.WriteTo(ref output, _repeated_enhanceValue_codec);
		if (Id != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Id);
		}
		if (TabType != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(TabType);
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
		if (ChaUniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ChaUniqueId);
		}
		num += collectionBuffId_.CalculateSize(_repeated_collectionBuffId_codec);
		if (CostumeID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CostumeID);
		}
		num += enhanceValue_.CalculateSize(_repeated_enhanceValue_codec);
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (TabType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TabType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CostumePictorialBookTable other)
	{
		if (other != null)
		{
			if (other.ChaUniqueId != 0)
			{
				ChaUniqueId = other.ChaUniqueId;
			}
			collectionBuffId_.Add(other.collectionBuffId_);
			if (other.CostumeID != 0)
			{
				CostumeID = other.CostumeID;
			}
			enhanceValue_.Add(other.enhanceValue_);
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.TabType != 0)
			{
				TabType = other.TabType;
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
				ChaUniqueId = input.ReadInt32();
				break;
			case 24u:
				CostumeID = input.ReadInt32();
				break;
			case 16u:
			case 18u:
				collectionBuffId_.AddEntriesFrom(ref input, _repeated_collectionBuffId_codec);
				break;
			case 32u:
			case 34u:
				enhanceValue_.AddEntriesFrom(ref input, _repeated_enhanceValue_codec);
				break;
			case 40u:
				Id = input.ReadInt32();
				break;
			case 48u:
				TabType = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
