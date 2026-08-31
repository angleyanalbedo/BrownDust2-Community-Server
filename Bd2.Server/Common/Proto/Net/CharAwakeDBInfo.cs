using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class CharAwakeDBInfo : IMessage<CharAwakeDBInfo>, IMessage, IEquatable<CharAwakeDBInfo>, IDeepCloneable<CharAwakeDBInfo>, IBufferMessage
{
	private static readonly MessageParser<CharAwakeDBInfo> _parser = new MessageParser<CharAwakeDBInfo>(() => new CharAwakeDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int UniqueCharIdFieldNumber = 1;

	private int uniqueCharId_;

	public const int ImprintSlot1LevelFieldNumber = 2;

	private int imprintSlot1Level_;

	public const int ImprintSlot2LevelFieldNumber = 3;

	private int imprintSlot2Level_;

	public const int ImprintSlot3LevelFieldNumber = 4;

	private int imprintSlot3Level_;

	public const int IsAwakeFieldNumber = 5;

	private bool isAwake_;

	public const int OwnerIndexFieldNumber = 6;

	private long ownerIndex_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CharAwakeDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CharAwakeDBInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int UniqueCharId
	{
		get
		{
			return uniqueCharId_;
		}
		set
		{
			uniqueCharId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ImprintSlot1Level
	{
		get
		{
			return imprintSlot1Level_;
		}
		set
		{
			imprintSlot1Level_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ImprintSlot2Level
	{
		get
		{
			return imprintSlot2Level_;
		}
		set
		{
			imprintSlot2Level_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ImprintSlot3Level
	{
		get
		{
			return imprintSlot3Level_;
		}
		set
		{
			imprintSlot3Level_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsAwake
	{
		get
		{
			return isAwake_;
		}
		set
		{
			isAwake_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long OwnerIndex
	{
		get
		{
			return ownerIndex_;
		}
		set
		{
			ownerIndex_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharAwakeDBInfo()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharAwakeDBInfo(CharAwakeDBInfo other)
		: this()
	{
		uniqueCharId_ = other.uniqueCharId_;
		imprintSlot1Level_ = other.imprintSlot1Level_;
		imprintSlot2Level_ = other.imprintSlot2Level_;
		imprintSlot3Level_ = other.imprintSlot3Level_;
		isAwake_ = other.isAwake_;
		ownerIndex_ = other.ownerIndex_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharAwakeDBInfo Clone()
	{
		return new CharAwakeDBInfo(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as CharAwakeDBInfo);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CharAwakeDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (UniqueCharId == other.UniqueCharId && ImprintSlot1Level == other.ImprintSlot1Level && ImprintSlot2Level == other.ImprintSlot2Level && ImprintSlot3Level == other.ImprintSlot3Level && IsAwake == other.IsAwake && OwnerIndex == other.OwnerIndex)
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
		if (UniqueCharId != 0)
		{
			num ^= UniqueCharId.GetHashCode();
		}
		if (ImprintSlot1Level != 0)
		{
			num ^= ImprintSlot1Level.GetHashCode();
		}
		if (ImprintSlot2Level != 0)
		{
			num ^= ImprintSlot2Level.GetHashCode();
		}
		if (ImprintSlot3Level != 0)
		{
			num ^= ImprintSlot3Level.GetHashCode();
		}
		if (IsAwake)
		{
			num ^= IsAwake.GetHashCode();
		}
		if (OwnerIndex != 0L)
		{
			num ^= OwnerIndex.GetHashCode();
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
		if (UniqueCharId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(UniqueCharId);
		}
		if (ImprintSlot1Level != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ImprintSlot1Level);
		}
		if (ImprintSlot2Level != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ImprintSlot2Level);
		}
		if (ImprintSlot3Level != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ImprintSlot3Level);
		}
		if (IsAwake)
		{
			output.WriteRawTag(40);
			output.WriteBool(IsAwake);
		}
		if (OwnerIndex != 0L)
		{
			output.WriteRawTag(48);
			output.WriteInt64(OwnerIndex);
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
		if (UniqueCharId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UniqueCharId);
		}
		if (ImprintSlot1Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ImprintSlot1Level);
		}
		if (ImprintSlot2Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ImprintSlot2Level);
		}
		if (ImprintSlot3Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ImprintSlot3Level);
		}
		if (IsAwake)
		{
			num += 2;
		}
		if (OwnerIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(OwnerIndex);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CharAwakeDBInfo other)
	{
		if (other != null)
		{
			if (other.UniqueCharId != 0)
			{
				UniqueCharId = other.UniqueCharId;
			}
			if (other.ImprintSlot1Level != 0)
			{
				ImprintSlot1Level = other.ImprintSlot1Level;
			}
			if (other.ImprintSlot2Level != 0)
			{
				ImprintSlot2Level = other.ImprintSlot2Level;
			}
			if (other.ImprintSlot3Level != 0)
			{
				ImprintSlot3Level = other.ImprintSlot3Level;
			}
			if (other.IsAwake)
			{
				IsAwake = other.IsAwake;
			}
			if (other.OwnerIndex != 0L)
			{
				OwnerIndex = other.OwnerIndex;
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
				UniqueCharId = input.ReadInt32();
				break;
			case 16u:
				ImprintSlot1Level = input.ReadInt32();
				break;
			case 24u:
				ImprintSlot2Level = input.ReadInt32();
				break;
			case 32u:
				ImprintSlot3Level = input.ReadInt32();
				break;
			case 40u:
				IsAwake = input.ReadBool();
				break;
			case 48u:
				OwnerIndex = input.ReadInt64();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
