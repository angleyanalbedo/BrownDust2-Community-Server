using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class SkyWayDBInfo : IMessage<SkyWayDBInfo>, IMessage, IEquatable<SkyWayDBInfo>, IDeepCloneable<SkyWayDBInfo>, IBufferMessage
{
	private static readonly MessageParser<SkyWayDBInfo> _parser = new MessageParser<SkyWayDBInfo>(() => new SkyWayDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int IsAutoFieldNumber = 1;

	private bool isAuto_;

	public const int GroupIdFieldNumber = 2;

	private int groupId_;

	public const int CurrentIdFieldNumber = 3;

	private int currentId_;

	public const int MaxClearLevelFieldNumber = 4;

	private int maxClearLevel_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<SkyWayDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SkyWayDBInfoReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsAuto
	{
		get
		{
			return isAuto_;
		}
		set
		{
			isAuto_ = value;
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CurrentId
	{
		get
		{
			return currentId_;
		}
		set
		{
			currentId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MaxClearLevel
	{
		get
		{
			return maxClearLevel_;
		}
		set
		{
			maxClearLevel_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SkyWayDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SkyWayDBInfo(SkyWayDBInfo other)
		: this()
	{
		isAuto_ = other.isAuto_;
		groupId_ = other.groupId_;
		currentId_ = other.currentId_;
		maxClearLevel_ = other.maxClearLevel_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SkyWayDBInfo Clone()
	{
		return new SkyWayDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SkyWayDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SkyWayDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (IsAuto == other.IsAuto && GroupId == other.GroupId && CurrentId == other.CurrentId && MaxClearLevel == other.MaxClearLevel)
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
		if (IsAuto)
		{
			num ^= IsAuto.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (CurrentId != 0)
		{
			num ^= CurrentId.GetHashCode();
		}
		if (MaxClearLevel != 0)
		{
			num ^= MaxClearLevel.GetHashCode();
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
		if (IsAuto)
		{
			output.WriteRawTag(8);
			output.WriteBool(IsAuto);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(GroupId);
		}
		if (CurrentId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(CurrentId);
		}
		if (MaxClearLevel != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(MaxClearLevel);
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
		if (IsAuto)
		{
			num += 2;
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (CurrentId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CurrentId);
		}
		if (MaxClearLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxClearLevel);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SkyWayDBInfo other)
	{
		if (other != null)
		{
			if (other.IsAuto)
			{
				IsAuto = other.IsAuto;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.CurrentId != 0)
			{
				CurrentId = other.CurrentId;
			}
			if (other.MaxClearLevel != 0)
			{
				MaxClearLevel = other.MaxClearLevel;
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
				IsAuto = input.ReadBool();
				break;
			case 16u:
				GroupId = input.ReadInt32();
				break;
			case 24u:
				CurrentId = input.ReadInt32();
				break;
			case 32u:
				MaxClearLevel = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
