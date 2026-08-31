using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class CostumeDBInfo : IMessage<CostumeDBInfo>, IMessage, IEquatable<CostumeDBInfo>, IDeepCloneable<CostumeDBInfo>, IBufferMessage
{
	private static readonly MessageParser<CostumeDBInfo> _parser = new MessageParser<CostumeDBInfo>(() => new CostumeDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int InvenIndexFieldNumber = 1;

	private long invenIndex_;

	public const int IdFieldNumber = 2;

	private int id_;

	public const int LevelFieldNumber = 3;

	private int level_;

	public const int UseCharFieldNumber = 4;

	private long useChar_;

	public const int PictorialbookInfoFieldNumber = 5;

	private static readonly FieldCodec<PictorialBookDBInfo> _repeated_pictorialbookInfo_codec = FieldCodec.ForMessage(42u, PictorialBookDBInfo.Parser);

	private readonly RepeatedField<PictorialBookDBInfo> pictorialbookInfo_ = new RepeatedField<PictorialBookDBInfo>();

	public const int SortIdFieldNumber = 6;

	private int sortId_;

	public const int UseMyRoomCountFieldNumber = 7;

	private int useMyRoomCount_;

	public const int PotentialIdFieldNumber = 8;

	private static readonly FieldCodec<int> _repeated_potentialId_codec = FieldCodec.ForInt32(66u);

	private readonly RepeatedField<int> potentialId_ = new RepeatedField<int>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CostumeDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CostumeDBInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long InvenIndex
	{
		get
		{
			return invenIndex_;
		}
		set
		{
			invenIndex_ = value;
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long UseChar
	{
		get
		{
			return useChar_;
		}
		set
		{
			useChar_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PictorialBookDBInfo> PictorialbookInfo => pictorialbookInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SortId
	{
		get
		{
			return sortId_;
		}
		set
		{
			sortId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int UseMyRoomCount
	{
		get
		{
			return useMyRoomCount_;
		}
		set
		{
			useMyRoomCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> PotentialId => potentialId_;

	public bool IsNew { get; set; }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CostumeDBInfo()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CostumeDBInfo(CostumeDBInfo other)
		: this()
	{
		invenIndex_ = other.invenIndex_;
		id_ = other.id_;
		level_ = other.level_;
		useChar_ = other.useChar_;
		pictorialbookInfo_ = other.pictorialbookInfo_.Clone();
		sortId_ = other.sortId_;
		useMyRoomCount_ = other.useMyRoomCount_;
		potentialId_ = other.potentialId_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CostumeDBInfo Clone()
	{
		return new CostumeDBInfo(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as CostumeDBInfo);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CostumeDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (InvenIndex == other.InvenIndex && Id == other.Id && Level == other.Level && UseChar == other.UseChar && pictorialbookInfo_.Equals(other.pictorialbookInfo_) && SortId == other.SortId && UseMyRoomCount == other.UseMyRoomCount && potentialId_.Equals(other.potentialId_))
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
		if (InvenIndex != 0L)
		{
			num ^= InvenIndex.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (UseChar != 0L)
		{
			num ^= UseChar.GetHashCode();
		}
		num ^= pictorialbookInfo_.GetHashCode();
		if (SortId != 0)
		{
			num ^= SortId.GetHashCode();
		}
		if (UseMyRoomCount != 0)
		{
			num ^= UseMyRoomCount.GetHashCode();
		}
		num ^= potentialId_.GetHashCode();
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
		if (InvenIndex != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(InvenIndex);
		}
		if (Id != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Id);
		}
		if (Level != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Level);
		}
		if (UseChar != 0L)
		{
			output.WriteRawTag(32);
			output.WriteInt64(UseChar);
		}
		pictorialbookInfo_.WriteTo(ref output, _repeated_pictorialbookInfo_codec);
		if (SortId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(SortId);
		}
		if (UseMyRoomCount != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(UseMyRoomCount);
		}
		potentialId_.WriteTo(ref output, _repeated_potentialId_codec);
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
		if (InvenIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(InvenIndex);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Level);
		}
		if (UseChar != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(UseChar);
		}
		num += pictorialbookInfo_.CalculateSize(_repeated_pictorialbookInfo_codec);
		if (SortId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SortId);
		}
		if (UseMyRoomCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UseMyRoomCount);
		}
		num += potentialId_.CalculateSize(_repeated_potentialId_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CostumeDBInfo other)
	{
		if (other != null)
		{
			if (other.InvenIndex != 0L)
			{
				InvenIndex = other.InvenIndex;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.UseChar != 0L)
			{
				UseChar = other.UseChar;
			}
			pictorialbookInfo_.Add(other.pictorialbookInfo_);
			if (other.SortId != 0)
			{
				SortId = other.SortId;
			}
			if (other.UseMyRoomCount != 0)
			{
				UseMyRoomCount = other.UseMyRoomCount;
			}
			potentialId_.Add(other.potentialId_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			case 8u:
				InvenIndex = input.ReadInt64();
				break;
			case 16u:
				Id = input.ReadInt32();
				break;
			case 24u:
				Level = input.ReadInt32();
				break;
			case 32u:
				UseChar = input.ReadInt64();
				break;
			case 42u:
				pictorialbookInfo_.AddEntriesFrom(ref input, _repeated_pictorialbookInfo_codec);
				break;
			case 48u:
				SortId = input.ReadInt32();
				break;
			case 56u:
				UseMyRoomCount = input.ReadInt32();
				break;
			case 64u:
			case 66u:
				potentialId_.AddEntriesFrom(ref input, _repeated_potentialId_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
