using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GuildRaidNormalBattleInfoResponse : IMessage<GuildRaidNormalBattleInfoResponse>, IMessage, IEquatable<GuildRaidNormalBattleInfoResponse>, IDeepCloneable<GuildRaidNormalBattleInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<GuildRaidNormalBattleInfoResponse> _parser = new MessageParser<GuildRaidNormalBattleInfoResponse>(() => new GuildRaidNormalBattleInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int InfoFieldNumber = 1;

	private static readonly FieldCodec<GuildRaidNormalBattleDBInfo> _repeated_info_codec = FieldCodec.ForMessage(10u, GuildRaidNormalBattleDBInfo.Parser);

	private readonly RepeatedField<GuildRaidNormalBattleDBInfo> info_ = new RepeatedField<GuildRaidNormalBattleDBInfo>();

	public const int GolemLevelFieldNumber = 2;

	private int golemLevel_;

	public const int GolemExpFieldNumber = 3;

	private int golemExp_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildRaidNormalBattleInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GuildRaidNormalBattleInfoResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GuildRaidNormalBattleDBInfo> Info => info_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GolemLevel
	{
		get
		{
			return golemLevel_;
		}
		set
		{
			golemLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GolemExp
	{
		get
		{
			return golemExp_;
		}
		set
		{
			golemExp_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildRaidNormalBattleInfoResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildRaidNormalBattleInfoResponse(GuildRaidNormalBattleInfoResponse other)
		: this()
	{
		info_ = other.info_.Clone();
		golemLevel_ = other.golemLevel_;
		golemExp_ = other.golemExp_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildRaidNormalBattleInfoResponse Clone()
	{
		return new GuildRaidNormalBattleInfoResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as GuildRaidNormalBattleInfoResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildRaidNormalBattleInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (info_.Equals(other.info_) && GolemLevel == other.GolemLevel && GolemExp == other.GolemExp)
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
		num ^= info_.GetHashCode();
		if (GolemLevel != 0)
		{
			num ^= GolemLevel.GetHashCode();
		}
		if (GolemExp != 0)
		{
			num ^= GolemExp.GetHashCode();
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
		info_.WriteTo(ref output, _repeated_info_codec);
		if (GolemLevel != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(GolemLevel);
		}
		if (GolemExp != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(GolemExp);
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
		num += info_.CalculateSize(_repeated_info_codec);
		if (GolemLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GolemLevel);
		}
		if (GolemExp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GolemExp);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildRaidNormalBattleInfoResponse other)
	{
		if (other != null)
		{
			info_.Add(other.info_);
			if (other.GolemLevel != 0)
			{
				GolemLevel = other.GolemLevel;
			}
			if (other.GolemExp != 0)
			{
				GolemExp = other.GolemExp;
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 24u:
				GolemExp = input.ReadInt32();
				break;
			case 16u:
				GolemLevel = input.ReadInt32();
				break;
			case 10u:
				info_.AddEntriesFrom(ref input, _repeated_info_codec);
				break;
			}
		}
	}
}
