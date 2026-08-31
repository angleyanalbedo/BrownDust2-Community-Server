using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class DeckSaveResponse : IMessage<DeckSaveResponse>, IMessage, IEquatable<DeckSaveResponse>, IDeepCloneable<DeckSaveResponse>, IBufferMessage
{
	private static readonly MessageParser<DeckSaveResponse> _parser = new MessageParser<DeckSaveResponse>(() => new DeckSaveResponse());

	private UnknownFieldSet _unknownFields;

	public const int DeckInfoFieldNumber = 1;

	private DeckDBInfo deckInfo_;

	public const int CharInfoFieldNumber = 2;

	private CharDBInfo charInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<DeckSaveResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => DeckSaveResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public DeckDBInfo DeckInfo
	{
		get
		{
			return deckInfo_;
		}
		set
		{
			deckInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharDBInfo CharInfo
	{
		get
		{
			return charInfo_;
		}
		set
		{
			charInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public DeckSaveResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public DeckSaveResponse(DeckSaveResponse other)
		: this()
	{
		deckInfo_ = ((other.deckInfo_ != null) ? other.deckInfo_.Clone() : null);
		charInfo_ = ((other.charInfo_ != null) ? other.charInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DeckSaveResponse Clone()
	{
		return new DeckSaveResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DeckSaveResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(DeckSaveResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(DeckInfo, other.DeckInfo) && object.Equals(CharInfo, other.CharInfo))
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
		if (deckInfo_ != null)
		{
			num ^= DeckInfo.GetHashCode();
		}
		if (charInfo_ != null)
		{
			num ^= CharInfo.GetHashCode();
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
		if (deckInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(DeckInfo);
		}
		if (charInfo_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(CharInfo);
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
		if (deckInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DeckInfo);
		}
		if (charInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CharInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(DeckSaveResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.deckInfo_ != null)
		{
			if (deckInfo_ == null)
			{
				DeckInfo = new DeckDBInfo();
			}
			DeckInfo.MergeFrom(other.DeckInfo);
		}
		if (other.charInfo_ != null)
		{
			if (charInfo_ == null)
			{
				CharInfo = new CharDBInfo();
			}
			CharInfo.MergeFrom(other.CharInfo);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 18u:
				if (charInfo_ == null)
				{
					CharInfo = new CharDBInfo();
				}
				input.ReadMessage(CharInfo);
				break;
			case 10u:
				if (deckInfo_ == null)
				{
					DeckInfo = new DeckDBInfo();
				}
				input.ReadMessage(DeckInfo);
				break;
			}
		}
	}
}
