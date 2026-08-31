using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class FieldObjectPositionUpdateRequest : IMessage<FieldObjectPositionUpdateRequest>, IMessage, IEquatable<FieldObjectPositionUpdateRequest>, IDeepCloneable<FieldObjectPositionUpdateRequest>, IBufferMessage
{
	private static readonly MessageParser<FieldObjectPositionUpdateRequest> _parser = new MessageParser<FieldObjectPositionUpdateRequest>(() => new FieldObjectPositionUpdateRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int PackIdFieldNumber = 2;

	private int packId_;

	public const int GroupIdFieldNumber = 3;

	private int groupId_;

	public const int ObjectIdFieldNumber = 4;

	private int objectId_;

	public const int PositionFieldNumber = 5;

	private FieldObjectPositionDBInfo position_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FieldObjectPositionUpdateRequest> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => FieldObjectPositionUpdateRequestReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public int ObjectId
	{
		get
		{
			return objectId_;
		}
		set
		{
			objectId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FieldObjectPositionDBInfo Position
	{
		get
		{
			return position_;
		}
		set
		{
			position_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FieldObjectPositionUpdateRequest()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FieldObjectPositionUpdateRequest(FieldObjectPositionUpdateRequest other)
		: this()
	{
		seq_ = other.seq_;
		packId_ = other.packId_;
		groupId_ = other.groupId_;
		objectId_ = other.objectId_;
		position_ = ((other.position_ != null) ? other.position_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FieldObjectPositionUpdateRequest Clone()
	{
		return new FieldObjectPositionUpdateRequest(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FieldObjectPositionUpdateRequest);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FieldObjectPositionUpdateRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && PackId == other.PackId && GroupId == other.GroupId && ObjectId == other.ObjectId && object.Equals(Position, other.Position))
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
		if (Seq != 0)
		{
			num ^= Seq.GetHashCode();
		}
		if (PackId != 0)
		{
			num ^= PackId.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (ObjectId != 0)
		{
			num ^= ObjectId.GetHashCode();
		}
		if (position_ != null)
		{
			num ^= Position.GetHashCode();
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
		if (Seq != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Seq);
		}
		if (PackId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(PackId);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(GroupId);
		}
		if (ObjectId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ObjectId);
		}
		if (position_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(Position);
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
		if (Seq != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Seq);
		}
		if (PackId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PackId);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (ObjectId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ObjectId);
		}
		if (position_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Position);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FieldObjectPositionUpdateRequest other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Seq != 0)
		{
			Seq = other.Seq;
		}
		if (other.PackId != 0)
		{
			PackId = other.PackId;
		}
		if (other.GroupId != 0)
		{
			GroupId = other.GroupId;
		}
		if (other.ObjectId != 0)
		{
			ObjectId = other.ObjectId;
		}
		if (other.position_ != null)
		{
			if (position_ == null)
			{
				Position = new FieldObjectPositionDBInfo();
			}
			Position.MergeFrom(other.Position);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
				Seq = input.ReadInt32();
				break;
			case 16u:
				PackId = input.ReadInt32();
				break;
			case 24u:
				GroupId = input.ReadInt32();
				break;
			case 32u:
				ObjectId = input.ReadInt32();
				break;
			case 42u:
				if (position_ == null)
				{
					Position = new FieldObjectPositionDBInfo();
				}
				input.ReadMessage(Position);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
