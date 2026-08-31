using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PopularCostumeInfoRequest : IMessage<PopularCostumeInfoRequest>, IMessage, IEquatable<PopularCostumeInfoRequest>, IDeepCloneable<PopularCostumeInfoRequest>, IBufferMessage
{
	private static readonly MessageParser<PopularCostumeInfoRequest> _parser = new MessageParser<PopularCostumeInfoRequest>(() => new PopularCostumeInfoRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int ContentTypeFieldNumber = 2;

	private int contentType_;

	public const int DeckTypeFieldNumber = 3;

	private int deckType_;

	public const int ReservedOrderFieldNumber = 4;

	private int reservedOrder_;

	public const int RankGroupIdFieldNumber = 5;

	private int rankGroupId_;

	public const int StageIdFieldNumber = 6;

	private int stageId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PopularCostumeInfoRequest> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => PopularCostumeInfoRequestReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Seq
	{
		get
		{
			return seq_;
		}
		set
		{
			seq_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ContentType
	{
		get
		{
			return contentType_;
		}
		set
		{
			contentType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DeckType
	{
		get
		{
			return deckType_;
		}
		set
		{
			deckType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ReservedOrder
	{
		get
		{
			return reservedOrder_;
		}
		set
		{
			reservedOrder_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RankGroupId
	{
		get
		{
			return rankGroupId_;
		}
		set
		{
			rankGroupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int StageId
	{
		get
		{
			return stageId_;
		}
		set
		{
			stageId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PopularCostumeInfoRequest()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PopularCostumeInfoRequest(PopularCostumeInfoRequest other)
		: this()
	{
		seq_ = other.seq_;
		contentType_ = other.contentType_;
		deckType_ = other.deckType_;
		reservedOrder_ = other.reservedOrder_;
		rankGroupId_ = other.rankGroupId_;
		stageId_ = other.stageId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PopularCostumeInfoRequest Clone()
	{
		return new PopularCostumeInfoRequest(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as PopularCostumeInfoRequest);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PopularCostumeInfoRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && ContentType == other.ContentType && DeckType == other.DeckType && ReservedOrder == other.ReservedOrder && RankGroupId == other.RankGroupId && StageId == other.StageId)
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
		if (Seq != 0)
		{
			num ^= Seq.GetHashCode();
		}
		if (ContentType != 0)
		{
			num ^= ContentType.GetHashCode();
		}
		if (DeckType != 0)
		{
			num ^= DeckType.GetHashCode();
		}
		if (ReservedOrder != 0)
		{
			num ^= ReservedOrder.GetHashCode();
		}
		if (RankGroupId != 0)
		{
			num ^= RankGroupId.GetHashCode();
		}
		if (StageId != 0)
		{
			num ^= StageId.GetHashCode();
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
		if (Seq != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Seq);
		}
		if (ContentType != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ContentType);
		}
		if (DeckType != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(DeckType);
		}
		if (ReservedOrder != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ReservedOrder);
		}
		if (RankGroupId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(RankGroupId);
		}
		if (StageId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(StageId);
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
		if (Seq != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Seq);
		}
		if (ContentType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ContentType);
		}
		if (DeckType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DeckType);
		}
		if (ReservedOrder != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ReservedOrder);
		}
		if (RankGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RankGroupId);
		}
		if (StageId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StageId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PopularCostumeInfoRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			if (other.ContentType != 0)
			{
				ContentType = other.ContentType;
			}
			if (other.DeckType != 0)
			{
				DeckType = other.DeckType;
			}
			if (other.ReservedOrder != 0)
			{
				ReservedOrder = other.ReservedOrder;
			}
			if (other.RankGroupId != 0)
			{
				RankGroupId = other.RankGroupId;
			}
			if (other.StageId != 0)
			{
				StageId = other.StageId;
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
				Seq = input.ReadInt32();
				break;
			case 16u:
				ContentType = input.ReadInt32();
				break;
			case 24u:
				DeckType = input.ReadInt32();
				break;
			case 32u:
				ReservedOrder = input.ReadInt32();
				break;
			case 40u:
				RankGroupId = input.ReadInt32();
				break;
			case 48u:
				StageId = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
