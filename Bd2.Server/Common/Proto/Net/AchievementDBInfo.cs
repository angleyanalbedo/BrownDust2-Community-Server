using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class AchievementDBInfo : IMessage<AchievementDBInfo>, IMessage, IEquatable<AchievementDBInfo>, IDeepCloneable<AchievementDBInfo>, IBufferMessage
{
	private static readonly MessageParser<AchievementDBInfo> _parser = new MessageParser<AchievementDBInfo>(() => new AchievementDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int GroupIdFieldNumber = 1;

	private int groupId_;

	public const int ValueFieldNumber = 2;

	private long value_;

	public const int MaxClearIdFieldNumber = 3;

	private int maxClearId_;

	public const int ContentsGroupFieldNumber = 4;

	private int contentsGroup_;

	public int Id { get; set; }

	public bool IsNeedNotice { get; set; }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AchievementDBInfo> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => AchievementDBInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public long Value
	{
		get
		{
			return value_;
		}
		set
		{
			value_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MaxClearId
	{
		get
		{
			return maxClearId_;
		}
		set
		{
			maxClearId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ContentsGroup
	{
		get
		{
			return contentsGroup_;
		}
		set
		{
			contentsGroup_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AchievementDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AchievementDBInfo(AchievementDBInfo other)
		: this()
	{
		groupId_ = other.groupId_;
		value_ = other.value_;
		maxClearId_ = other.maxClearId_;
		contentsGroup_ = other.contentsGroup_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AchievementDBInfo Clone()
	{
		return new AchievementDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AchievementDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AchievementDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (GroupId == other.GroupId && Value == other.Value && MaxClearId == other.MaxClearId && ContentsGroup == other.ContentsGroup)
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
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (Value != 0L)
		{
			num ^= Value.GetHashCode();
		}
		if (MaxClearId != 0)
		{
			num ^= MaxClearId.GetHashCode();
		}
		if (ContentsGroup != 0)
		{
			num ^= ContentsGroup.GetHashCode();
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
		if (GroupId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(GroupId);
		}
		if (Value != 0L)
		{
			output.WriteRawTag(16);
			output.WriteInt64(Value);
		}
		if (MaxClearId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(MaxClearId);
		}
		if (ContentsGroup != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ContentsGroup);
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
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (Value != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(Value);
		}
		if (MaxClearId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxClearId);
		}
		if (ContentsGroup != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ContentsGroup);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AchievementDBInfo other)
	{
		if (other != null)
		{
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.Value != 0L)
			{
				Value = other.Value;
			}
			if (other.MaxClearId != 0)
			{
				MaxClearId = other.MaxClearId;
			}
			if (other.ContentsGroup != 0)
			{
				ContentsGroup = other.ContentsGroup;
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
				GroupId = input.ReadInt32();
				break;
			case 16u:
				Value = input.ReadInt64();
				break;
			case 24u:
				MaxClearId = input.ReadInt32();
				break;
			case 32u:
				ContentsGroup = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
