using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class MercenaryScoutTable : IMessage<MercenaryScoutTable>, IMessage, IEquatable<MercenaryScoutTable>, IDeepCloneable<MercenaryScoutTable>, IBufferMessage
{
	private static readonly MessageParser<MercenaryScoutTable> _parser = new MessageParser<MercenaryScoutTable>(() => new MercenaryScoutTable());

	private UnknownFieldSet _unknownFields;

	public const int AppearProbFieldNumber = 1;

	private int appearProb_;

	public const int CostumeIdFieldNumber = 2;

	private int costumeId_;

	public const int IdFieldNumber = 3;

	private int id_;

	public const int PackIdFieldNumber = 4;

	private int packId_;

	public const int PresentItemCountFieldNumber = 5;

	private static readonly FieldCodec<int> _repeated_presentItemCount_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> presentItemCount_ = new RepeatedField<int>();

	public const int PresentItemIdFieldNumber = 6;

	private static readonly FieldCodec<int> _repeated_presentItemId_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> presentItemId_ = new RepeatedField<int>();

	public const int PresentItemTypeFieldNumber = 7;

	private static readonly FieldCodec<int> _repeated_presentItemType_codec = FieldCodec.ForInt32(58u);

	private readonly RepeatedField<int> presentItemType_ = new RepeatedField<int>();

	public const int TalkGroupIdFieldNumber = 8;

	private int talkGroupId_;

	public const int TypeFieldNumber = 9;

	private int type_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MercenaryScoutTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MercenaryScoutTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AppearProb
	{
		get
		{
			return appearProb_;
		}
		set
		{
			appearProb_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CostumeId
	{
		get
		{
			return costumeId_;
		}
		set
		{
			costumeId_ = value;
		}
	}

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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PackId
	{
		get
		{
			return packId_;
		}
		set
		{
			packId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> PresentItemCount => presentItemCount_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> PresentItemId => presentItemId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> PresentItemType => presentItemType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TalkGroupId
	{
		get
		{
			return talkGroupId_;
		}
		set
		{
			talkGroupId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public MercenaryScoutTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MercenaryScoutTable(MercenaryScoutTable other)
		: this()
	{
		appearProb_ = other.appearProb_;
		costumeId_ = other.costumeId_;
		id_ = other.id_;
		packId_ = other.packId_;
		presentItemCount_ = other.presentItemCount_.Clone();
		presentItemId_ = other.presentItemId_.Clone();
		presentItemType_ = other.presentItemType_.Clone();
		talkGroupId_ = other.talkGroupId_;
		type_ = other.type_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MercenaryScoutTable Clone()
	{
		return new MercenaryScoutTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MercenaryScoutTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MercenaryScoutTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (AppearProb == other.AppearProb && CostumeId == other.CostumeId && Id == other.Id && PackId == other.PackId && presentItemCount_.Equals(other.presentItemCount_) && presentItemId_.Equals(other.presentItemId_) && presentItemType_.Equals(other.presentItemType_) && TalkGroupId == other.TalkGroupId && Type == other.Type)
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
		if (AppearProb != 0)
		{
			num ^= AppearProb.GetHashCode();
		}
		if (CostumeId != 0)
		{
			num ^= CostumeId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (PackId != 0)
		{
			num ^= PackId.GetHashCode();
		}
		num ^= presentItemCount_.GetHashCode();
		num ^= presentItemId_.GetHashCode();
		num ^= presentItemType_.GetHashCode();
		if (TalkGroupId != 0)
		{
			num ^= TalkGroupId.GetHashCode();
		}
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
		if (AppearProb != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(AppearProb);
		}
		if (CostumeId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(CostumeId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Id);
		}
		if (PackId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(PackId);
		}
		presentItemCount_.WriteTo(ref output, _repeated_presentItemCount_codec);
		presentItemId_.WriteTo(ref output, _repeated_presentItemId_codec);
		presentItemType_.WriteTo(ref output, _repeated_presentItemType_codec);
		if (TalkGroupId != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(TalkGroupId);
		}
		if (Type != 0)
		{
			output.WriteRawTag(72);
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
		if (AppearProb != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AppearProb);
		}
		if (CostumeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CostumeId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (PackId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PackId);
		}
		num += presentItemCount_.CalculateSize(_repeated_presentItemCount_codec);
		num += presentItemId_.CalculateSize(_repeated_presentItemId_codec);
		num += presentItemType_.CalculateSize(_repeated_presentItemType_codec);
		if (TalkGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TalkGroupId);
		}
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
	public void MergeFrom(MercenaryScoutTable other)
	{
		if (other != null)
		{
			if (other.AppearProb != 0)
			{
				AppearProb = other.AppearProb;
			}
			if (other.CostumeId != 0)
			{
				CostumeId = other.CostumeId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.PackId != 0)
			{
				PackId = other.PackId;
			}
			presentItemCount_.Add(other.presentItemCount_);
			presentItemId_.Add(other.presentItemId_);
			presentItemType_.Add(other.presentItemType_);
			if (other.TalkGroupId != 0)
			{
				TalkGroupId = other.TalkGroupId;
			}
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			case 48u:
			case 50u:
				presentItemId_.AddEntriesFrom(ref input, _repeated_presentItemId_codec);
				break;
			case 64u:
				TalkGroupId = input.ReadInt32();
				break;
			case 72u:
				Type = input.ReadInt32();
				break;
			case 56u:
			case 58u:
				presentItemType_.AddEntriesFrom(ref input, _repeated_presentItemType_codec);
				break;
			case 8u:
				AppearProb = input.ReadInt32();
				break;
			case 16u:
				CostumeId = input.ReadInt32();
				break;
			case 24u:
				Id = input.ReadInt32();
				break;
			case 32u:
				PackId = input.ReadInt32();
				break;
			case 40u:
			case 42u:
				presentItemCount_.AddEntriesFrom(ref input, _repeated_presentItemCount_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
