using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class FieldMonsterRegenResponse : IMessage<FieldMonsterRegenResponse>, IMessage, IEquatable<FieldMonsterRegenResponse>, IDeepCloneable<FieldMonsterRegenResponse>, IBufferMessage
{
	private static readonly MessageParser<FieldMonsterRegenResponse> _parser = new MessageParser<FieldMonsterRegenResponse>(() => new FieldMonsterRegenResponse());

	private UnknownFieldSet _unknownFields;

	public const int MonsterInfoFieldNumber = 1;

	private MonsterDBInfo monsterInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FieldMonsterRegenResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FieldMonsterRegenResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MonsterDBInfo MonsterInfo
	{
		get
		{
			return monsterInfo_;
		}
		set
		{
			monsterInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FieldMonsterRegenResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FieldMonsterRegenResponse(FieldMonsterRegenResponse other)
		: this()
	{
		monsterInfo_ = ((other.monsterInfo_ != null) ? other.monsterInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FieldMonsterRegenResponse Clone()
	{
		return new FieldMonsterRegenResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FieldMonsterRegenResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FieldMonsterRegenResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(MonsterInfo, other.MonsterInfo))
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
		if (monsterInfo_ != null)
		{
			num ^= MonsterInfo.GetHashCode();
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
		if (monsterInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(MonsterInfo);
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
		if (monsterInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MonsterInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(FieldMonsterRegenResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.monsterInfo_ != null)
		{
			if (monsterInfo_ == null)
			{
				MonsterInfo = new MonsterDBInfo();
			}
			MonsterInfo.MergeFrom(other.MonsterInfo);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (monsterInfo_ == null)
			{
				MonsterInfo = new MonsterDBInfo();
			}
			input.ReadMessage(MonsterInfo);
		}
	}
}
