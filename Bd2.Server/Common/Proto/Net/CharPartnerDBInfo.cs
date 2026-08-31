using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class CharPartnerDBInfo : IMessage<CharPartnerDBInfo>, IMessage, IEquatable<CharPartnerDBInfo>, IDeepCloneable<CharPartnerDBInfo>, IBufferMessage
{
	private static readonly MessageParser<CharPartnerDBInfo> _parser = new MessageParser<CharPartnerDBInfo>(() => new CharPartnerDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int MainUniqueIdFieldNumber = 1;

	private int mainUniqueId_;

	public const int SubUniqueIdFieldNumber = 2;

	private int subUniqueId_;

	public const int PointFieldNumber = 3;

	private int point_;

	public const int RewardFieldNumber = 4;

	private int reward_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CharPartnerDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CharPartnerDBInfoReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MainUniqueId
	{
		get
		{
			return mainUniqueId_;
		}
		set
		{
			mainUniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SubUniqueId
	{
		get
		{
			return subUniqueId_;
		}
		set
		{
			subUniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Point
	{
		get
		{
			return point_;
		}
		set
		{
			point_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Reward
	{
		get
		{
			return reward_;
		}
		set
		{
			reward_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharPartnerDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharPartnerDBInfo(CharPartnerDBInfo other)
		: this()
	{
		mainUniqueId_ = other.mainUniqueId_;
		subUniqueId_ = other.subUniqueId_;
		point_ = other.point_;
		reward_ = other.reward_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharPartnerDBInfo Clone()
	{
		return new CharPartnerDBInfo(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as CharPartnerDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharPartnerDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (MainUniqueId == other.MainUniqueId && SubUniqueId == other.SubUniqueId && Point == other.Point && Reward == other.Reward)
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
		if (MainUniqueId != 0)
		{
			num ^= MainUniqueId.GetHashCode();
		}
		if (SubUniqueId != 0)
		{
			num ^= SubUniqueId.GetHashCode();
		}
		if (Point != 0)
		{
			num ^= Point.GetHashCode();
		}
		if (Reward != 0)
		{
			num ^= Reward.GetHashCode();
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
		if (MainUniqueId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(MainUniqueId);
		}
		if (SubUniqueId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SubUniqueId);
		}
		if (Point != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Point);
		}
		if (Reward != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Reward);
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
		if (MainUniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MainUniqueId);
		}
		if (SubUniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SubUniqueId);
		}
		if (Point != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Point);
		}
		if (Reward != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Reward);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CharPartnerDBInfo other)
	{
		if (other != null)
		{
			if (other.MainUniqueId != 0)
			{
				MainUniqueId = other.MainUniqueId;
			}
			if (other.SubUniqueId != 0)
			{
				SubUniqueId = other.SubUniqueId;
			}
			if (other.Point != 0)
			{
				Point = other.Point;
			}
			if (other.Reward != 0)
			{
				Reward = other.Reward;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
				MainUniqueId = input.ReadInt32();
				break;
			case 16u:
				SubUniqueId = input.ReadInt32();
				break;
			case 24u:
				Point = input.ReadInt32();
				break;
			case 32u:
				Reward = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
