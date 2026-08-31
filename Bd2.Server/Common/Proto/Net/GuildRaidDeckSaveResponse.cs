using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GuildRaidDeckSaveResponse : IMessage<GuildRaidDeckSaveResponse>, IMessage, IEquatable<GuildRaidDeckSaveResponse>, IDeepCloneable<GuildRaidDeckSaveResponse>, IBufferMessage
{
	private static readonly MessageParser<GuildRaidDeckSaveResponse> _parser = new MessageParser<GuildRaidDeckSaveResponse>(() => new GuildRaidDeckSaveResponse());

	private UnknownFieldSet _unknownFields;

	public const int IsSupporterUpdateFieldNumber = 1;

	private bool isSupporterUpdate_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildRaidDeckSaveResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GuildRaidDeckSaveResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsSupporterUpdate
	{
		get
		{
			return isSupporterUpdate_;
		}
		set
		{
			isSupporterUpdate_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRaidDeckSaveResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRaidDeckSaveResponse(GuildRaidDeckSaveResponse other)
		: this()
	{
		isSupporterUpdate_ = other.isSupporterUpdate_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRaidDeckSaveResponse Clone()
	{
		return new GuildRaidDeckSaveResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GuildRaidDeckSaveResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildRaidDeckSaveResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (IsSupporterUpdate == other.IsSupporterUpdate)
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
		if (IsSupporterUpdate)
		{
			num ^= IsSupporterUpdate.GetHashCode();
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
		if (IsSupporterUpdate)
		{
			output.WriteRawTag(8);
			output.WriteBool(IsSupporterUpdate);
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
		if (IsSupporterUpdate)
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
	public void MergeFrom(GuildRaidDeckSaveResponse other)
	{
		if (other != null)
		{
			if (other.IsSupporterUpdate)
			{
				IsSupporterUpdate = other.IsSupporterUpdate;
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
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				IsSupporterUpdate = input.ReadBool();
			}
		}
	}
}
