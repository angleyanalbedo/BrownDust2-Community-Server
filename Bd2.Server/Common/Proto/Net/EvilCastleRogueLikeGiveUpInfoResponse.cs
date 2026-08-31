using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EvilCastleRogueLikeGiveUpInfoResponse : IMessage<EvilCastleRogueLikeGiveUpInfoResponse>, IMessage, IEquatable<EvilCastleRogueLikeGiveUpInfoResponse>, IDeepCloneable<EvilCastleRogueLikeGiveUpInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<EvilCastleRogueLikeGiveUpInfoResponse> _parser = new MessageParser<EvilCastleRogueLikeGiveUpInfoResponse>(() => new EvilCastleRogueLikeGiveUpInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int ObsidianFieldNumber = 1;

	private int obsidian_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EvilCastleRogueLikeGiveUpInfoResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => EvilCastleRogueLikeGiveUpInfoResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Obsidian
	{
		get
		{
			return obsidian_;
		}
		set
		{
			obsidian_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeGiveUpInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeGiveUpInfoResponse(EvilCastleRogueLikeGiveUpInfoResponse other)
		: this()
	{
		obsidian_ = other.obsidian_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleRogueLikeGiveUpInfoResponse Clone()
	{
		return new EvilCastleRogueLikeGiveUpInfoResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as EvilCastleRogueLikeGiveUpInfoResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(EvilCastleRogueLikeGiveUpInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Obsidian == other.Obsidian)
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
		if (Obsidian != 0)
		{
			num ^= Obsidian.GetHashCode();
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
		if (Obsidian != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Obsidian);
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
		if (Obsidian != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Obsidian);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EvilCastleRogueLikeGiveUpInfoResponse other)
	{
		if (other != null)
		{
			if (other.Obsidian != 0)
			{
				Obsidian = other.Obsidian;
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
				Obsidian = input.ReadInt32();
			}
		}
	}
}
