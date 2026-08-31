using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class SeasonRewardDBInfo : IMessage<SeasonRewardDBInfo>, IMessage, IEquatable<SeasonRewardDBInfo>, IDeepCloneable<SeasonRewardDBInfo>, IBufferMessage
{
	private static readonly MessageParser<SeasonRewardDBInfo> _parser = new MessageParser<SeasonRewardDBInfo>(() => new SeasonRewardDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int PackIdFieldNumber = 1;

	private int packId_;

	public const int SeasonFieldNumber = 2;

	private int season_;

	public const int IsRewardReceivedFieldNumber = 3;

	private bool isRewardReceived_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<SeasonRewardDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SeasonRewardDBInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Season
	{
		get
		{
			return season_;
		}
		set
		{
			season_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsRewardReceived
	{
		get
		{
			return isRewardReceived_;
		}
		set
		{
			isRewardReceived_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SeasonRewardDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SeasonRewardDBInfo(SeasonRewardDBInfo other)
		: this()
	{
		packId_ = other.packId_;
		season_ = other.season_;
		isRewardReceived_ = other.isRewardReceived_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SeasonRewardDBInfo Clone()
	{
		return new SeasonRewardDBInfo(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as SeasonRewardDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SeasonRewardDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (PackId == other.PackId && Season == other.Season && IsRewardReceived == other.IsRewardReceived)
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
		if (PackId != 0)
		{
			num ^= PackId.GetHashCode();
		}
		if (Season != 0)
		{
			num ^= Season.GetHashCode();
		}
		if (IsRewardReceived)
		{
			num ^= IsRewardReceived.GetHashCode();
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
		if (PackId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(PackId);
		}
		if (Season != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Season);
		}
		if (IsRewardReceived)
		{
			output.WriteRawTag(24);
			output.WriteBool(IsRewardReceived);
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
		if (PackId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PackId);
		}
		if (Season != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Season);
		}
		if (IsRewardReceived)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SeasonRewardDBInfo other)
	{
		if (other != null)
		{
			if (other.PackId != 0)
			{
				PackId = other.PackId;
			}
			if (other.Season != 0)
			{
				Season = other.Season;
			}
			if (other.IsRewardReceived)
			{
				IsRewardReceived = other.IsRewardReceived;
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 24u:
				IsRewardReceived = input.ReadBool();
				break;
			case 16u:
				Season = input.ReadInt32();
				break;
			case 8u:
				PackId = input.ReadInt32();
				break;
			}
		}
	}
}
