using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class SkyWayEnterResponse : IMessage<SkyWayEnterResponse>, IMessage, IEquatable<SkyWayEnterResponse>, IDeepCloneable<SkyWayEnterResponse>, IBufferMessage
{
	private static readonly MessageParser<SkyWayEnterResponse> _parser = new MessageParser<SkyWayEnterResponse>(() => new SkyWayEnterResponse());

	private UnknownFieldSet _unknownFields;

	public const int MonsterInfoFieldNumber = 1;

	private static readonly FieldCodec<MonsterDBInfo> _repeated_monsterInfo_codec = FieldCodec.ForMessage(10u, MonsterDBInfo.Parser);

	private readonly RepeatedField<MonsterDBInfo> monsterInfo_ = new RepeatedField<MonsterDBInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<SkyWayEnterResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => SkyWayEnterResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<MonsterDBInfo> MonsterInfo => monsterInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SkyWayEnterResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SkyWayEnterResponse(SkyWayEnterResponse other)
		: this()
	{
		monsterInfo_ = other.monsterInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SkyWayEnterResponse Clone()
	{
		return new SkyWayEnterResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SkyWayEnterResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(SkyWayEnterResponse other)
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public void MergeFrom(SkyWayEnterResponse other)
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
				monsterInfo_.AddEntriesFrom(ref input, _repeated_monsterInfo_codec);
			}
		}
	}
}
