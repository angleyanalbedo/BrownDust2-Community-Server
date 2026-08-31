using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MonsterHuntDeckInfoResponse : IMessage<MonsterHuntDeckInfoResponse>, IMessage, IEquatable<MonsterHuntDeckInfoResponse>, IDeepCloneable<MonsterHuntDeckInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<MonsterHuntDeckInfoResponse> _parser = new MessageParser<MonsterHuntDeckInfoResponse>(() => new MonsterHuntDeckInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int MonsterHuntDeckInfoFieldNumber = 1;

	private static readonly FieldCodec<MonsterHuntDeckDBInfo> _repeated_monsterHuntDeckInfo_codec = FieldCodec.ForMessage(10u, MonsterHuntDeckDBInfo.Parser);

	private readonly RepeatedField<MonsterHuntDeckDBInfo> monsterHuntDeckInfo_ = new RepeatedField<MonsterHuntDeckDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonsterHuntDeckInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonsterHuntDeckInfoResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<MonsterHuntDeckDBInfo> MonsterHuntDeckInfo => monsterHuntDeckInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterHuntDeckInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterHuntDeckInfoResponse(MonsterHuntDeckInfoResponse other)
		: this()
	{
		monsterHuntDeckInfo_ = other.monsterHuntDeckInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterHuntDeckInfoResponse Clone()
	{
		return new MonsterHuntDeckInfoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonsterHuntDeckInfoResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MonsterHuntDeckInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (monsterHuntDeckInfo_.Equals(other.monsterHuntDeckInfo_))
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
		num ^= monsterHuntDeckInfo_.GetHashCode();
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
		monsterHuntDeckInfo_.WriteTo(ref output, _repeated_monsterHuntDeckInfo_codec);
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
		num += monsterHuntDeckInfo_.CalculateSize(_repeated_monsterHuntDeckInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(MonsterHuntDeckInfoResponse other)
	{
		if (other != null)
		{
			monsterHuntDeckInfo_.Add(other.monsterHuntDeckInfo_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				monsterHuntDeckInfo_.AddEntriesFrom(ref input, _repeated_monsterHuntDeckInfo_codec);
			}
		}
	}
}
