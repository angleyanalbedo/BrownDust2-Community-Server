using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class FieldObjectPositionDBInfo : IMessage<FieldObjectPositionDBInfo>, IMessage, IEquatable<FieldObjectPositionDBInfo>, IDeepCloneable<FieldObjectPositionDBInfo>, IBufferMessage
{
	private static readonly MessageParser<FieldObjectPositionDBInfo> _parser = new MessageParser<FieldObjectPositionDBInfo>(() => new FieldObjectPositionDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int MapIdFieldNumber = 1;

	private int mapId_;

	public const int XFieldNumber = 2;

	private float x_;

	public const int YFieldNumber = 3;

	private float y_;

	public const int ZFieldNumber = 4;

	private float z_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FieldObjectPositionDBInfo> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => FieldObjectPositionDBInfoReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MapId
	{
		get
		{
			return mapId_;
		}
		set
		{
			mapId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public float X
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public float Y
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
	public float Z
	{
		get
		{
			return z_;
		}
		set
		{
			z_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FieldObjectPositionDBInfo()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FieldObjectPositionDBInfo(FieldObjectPositionDBInfo other)
		: this()
	{
		mapId_ = other.mapId_;
		x_ = other.x_;
		y_ = other.y_;
		z_ = other.z_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FieldObjectPositionDBInfo Clone()
	{
		return new FieldObjectPositionDBInfo(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as FieldObjectPositionDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FieldObjectPositionDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (MapId == other.MapId && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(X, other.X) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Y, other.Y) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Z, other.Z))
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
		if (MapId != 0)
		{
			num ^= MapId.GetHashCode();
		}
		if (X != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(X);
		}
		if (Y != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Y);
		}
		if (Z != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Z);
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (MapId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(MapId);
		}
		if (X != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(X);
		}
		if (Y != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(Y);
		}
		if (Z != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(Z);
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
		if (MapId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MapId);
		}
		if (X != 0f)
		{
			num += 5;
		}
		if (Y != 0f)
		{
			num += 5;
		}
		if (Z != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FieldObjectPositionDBInfo other)
	{
		if (other != null)
		{
			if (other.MapId != 0)
			{
				MapId = other.MapId;
			}
			if (other.X != 0f)
			{
				X = other.X;
			}
			if (other.Y != 0f)
			{
				Y = other.Y;
			}
			if (other.Z != 0f)
			{
				Z = other.Z;
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
				MapId = input.ReadInt32();
				break;
			case 21u:
				X = input.ReadFloat();
				break;
			case 29u:
				Y = input.ReadFloat();
				break;
			case 37u:
				Z = input.ReadFloat();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
