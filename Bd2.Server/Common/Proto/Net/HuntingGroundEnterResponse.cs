using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class HuntingGroundEnterResponse : IMessage<HuntingGroundEnterResponse>, IMessage, IEquatable<HuntingGroundEnterResponse>, IDeepCloneable<HuntingGroundEnterResponse>, IBufferMessage
{
	private static readonly MessageParser<HuntingGroundEnterResponse> _parser = new MessageParser<HuntingGroundEnterResponse>(() => new HuntingGroundEnterResponse());

	private UnknownFieldSet _unknownFields;

	public const int MonsterInfoFieldNumber = 1;

	private static readonly FieldCodec<MonsterDBInfo> _repeated_monsterInfo_codec = FieldCodec.ForMessage(10u, MonsterDBInfo.Parser);

	private readonly RepeatedField<MonsterDBInfo> monsterInfo_ = new RepeatedField<MonsterDBInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<HuntingGroundEnterResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => HuntingGroundEnterResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MonsterDBInfo> MonsterInfo => monsterInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HuntingGroundEnterResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HuntingGroundEnterResponse(HuntingGroundEnterResponse other)
		: this()
	{
		monsterInfo_ = other.monsterInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HuntingGroundEnterResponse Clone()
	{
		return new HuntingGroundEnterResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HuntingGroundEnterResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HuntingGroundEnterResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (monsterInfo_.Equals(other.monsterInfo_))
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
		num ^= monsterInfo_.GetHashCode();
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
		monsterInfo_.WriteTo(ref output, _repeated_monsterInfo_codec);
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
		num += monsterInfo_.CalculateSize(_repeated_monsterInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HuntingGroundEnterResponse other)
	{
		if (other != null)
		{
			monsterInfo_.Add(other.monsterInfo_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				monsterInfo_.AddEntriesFrom(ref input, _repeated_monsterInfo_codec);
			}
		}
	}
}
