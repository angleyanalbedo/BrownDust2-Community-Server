using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MyRoomItemPositionInfo : IMessage<MyRoomItemPositionInfo>, IMessage, IEquatable<MyRoomItemPositionInfo>, IDeepCloneable<MyRoomItemPositionInfo>, IBufferMessage
{
	private static readonly MessageParser<MyRoomItemPositionInfo> _parser = new MessageParser<MyRoomItemPositionInfo>(() => new MyRoomItemPositionInfo());

	private UnknownFieldSet _unknownFields;

	public const int InvenIndexFieldNumber = 1;

	private long invenIndex_;

	public const int ObjectTypeFieldNumber = 2;

	private int objectType_;

	public const int PositionTypeFieldNumber = 3;

	private int positionType_;

	public const int XFieldNumber = 4;

	private int x_;

	public const int YFieldNumber = 5;

	private int y_;

	public const int RotateFieldNumber = 6;

	private int rotate_;

	public const int InteractFieldNumber = 7;

	private int interact_;

	public const int ItemAnimationFieldNumber = 8;

	private int itemAnimation_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MyRoomItemPositionInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MyRoomItemPositionInfoReflection.Descriptor.MessageTypes[0];

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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ObjectType
	{
		get
		{
			return objectType_;
		}
		set
		{
			objectType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PositionType
	{
		get
		{
			return positionType_;
		}
		set
		{
			positionType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int X
	{
		get
		{
			return x_;
		}
		set
		{
			x_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Y
	{
		get
		{
			return y_;
		}
		set
		{
			y_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Rotate
	{
		get
		{
			return rotate_;
		}
		set
		{
			rotate_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Interact
	{
		get
		{
			return interact_;
		}
		set
		{
			interact_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ItemAnimation
	{
		get
		{
			return itemAnimation_;
		}
		set
		{
			itemAnimation_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MyRoomItemPositionInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MyRoomItemPositionInfo(MyRoomItemPositionInfo other)
		: this()
	{
		invenIndex_ = other.invenIndex_;
		objectType_ = other.objectType_;
		positionType_ = other.positionType_;
		x_ = other.x_;
		y_ = other.y_;
		rotate_ = other.rotate_;
		interact_ = other.interact_;
		itemAnimation_ = other.itemAnimation_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MyRoomItemPositionInfo Clone()
	{
		return new MyRoomItemPositionInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MyRoomItemPositionInfo);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MyRoomItemPositionInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (InvenIndex == other.InvenIndex && ObjectType == other.ObjectType && PositionType == other.PositionType && X == other.X && Y == other.Y && Rotate == other.Rotate && Interact == other.Interact && ItemAnimation == other.ItemAnimation)
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
		if (ObjectType != 0)
		{
			num ^= ObjectType.GetHashCode();
		}
		if (PositionType != 0)
		{
			num ^= PositionType.GetHashCode();
		}
		if (X != 0)
		{
			num ^= X.GetHashCode();
		}
		if (Y != 0)
		{
			num ^= Y.GetHashCode();
		}
		if (Rotate != 0)
		{
			num ^= Rotate.GetHashCode();
		}
		if (Interact != 0)
		{
			num ^= Interact.GetHashCode();
		}
		if (ItemAnimation != 0)
		{
			num ^= ItemAnimation.GetHashCode();
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
		if (InvenIndex != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(InvenIndex);
		}
		if (ObjectType != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ObjectType);
		}
		if (PositionType != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(PositionType);
		}
		if (X != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(X);
		}
		if (Y != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Y);
		}
		if (Rotate != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(Rotate);
		}
		if (Interact != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(Interact);
		}
		if (ItemAnimation != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(ItemAnimation);
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
		if (InvenIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(InvenIndex);
		}
		if (ObjectType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ObjectType);
		}
		if (PositionType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PositionType);
		}
		if (X != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(X);
		}
		if (Y != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Y);
		}
		if (Rotate != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Rotate);
		}
		if (Interact != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Interact);
		}
		if (ItemAnimation != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemAnimation);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MyRoomItemPositionInfo other)
	{
		if (other != null)
		{
			if (other.InvenIndex != 0L)
			{
				InvenIndex = other.InvenIndex;
			}
			if (other.ObjectType != 0)
			{
				ObjectType = other.ObjectType;
			}
			if (other.PositionType != 0)
			{
				PositionType = other.PositionType;
			}
			if (other.X != 0)
			{
				X = other.X;
			}
			if (other.Y != 0)
			{
				Y = other.Y;
			}
			if (other.Rotate != 0)
			{
				Rotate = other.Rotate;
			}
			if (other.Interact != 0)
			{
				Interact = other.Interact;
			}
			if (other.ItemAnimation != 0)
			{
				ItemAnimation = other.ItemAnimation;
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
				InvenIndex = input.ReadInt64();
				break;
			case 16u:
				ObjectType = input.ReadInt32();
				break;
			case 24u:
				PositionType = input.ReadInt32();
				break;
			case 32u:
				X = input.ReadInt32();
				break;
			case 40u:
				Y = input.ReadInt32();
				break;
			case 48u:
				Rotate = input.ReadInt32();
				break;
			case 56u:
				Interact = input.ReadInt32();
				break;
			case 64u:
				ItemAnimation = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
