using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PresetDeckDBInfo : IMessage<PresetDeckDBInfo>, IMessage, IEquatable<PresetDeckDBInfo>, IDeepCloneable<PresetDeckDBInfo>, IBufferMessage
{
	private static readonly MessageParser<PresetDeckDBInfo> _parser = new MessageParser<PresetDeckDBInfo>(() => new PresetDeckDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int DeckBaseInfoFieldNumber = 1;

	private DeckDBInfo deckBaseInfo_;

	public const int CostumeInvenIndexFieldNumber = 2;

	private long costumeInvenIndex_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PresetDeckDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PresetDeckDBInfoReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public DeckDBInfo DeckBaseInfo
	{
		get
		{
			return deckBaseInfo_;
		}
		set
		{
			deckBaseInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long CostumeInvenIndex
	{
		get
		{
			return costumeInvenIndex_;
		}
		set
		{
			costumeInvenIndex_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetDeckDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetDeckDBInfo(PresetDeckDBInfo other)
		: this()
	{
		deckBaseInfo_ = ((other.deckBaseInfo_ != null) ? other.deckBaseInfo_.Clone() : null);
		costumeInvenIndex_ = other.costumeInvenIndex_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetDeckDBInfo Clone()
	{
		return new PresetDeckDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PresetDeckDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PresetDeckDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(DeckBaseInfo, other.DeckBaseInfo) && CostumeInvenIndex == other.CostumeInvenIndex)
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
		if (deckBaseInfo_ != null)
		{
			num ^= DeckBaseInfo.GetHashCode();
		}
		if (CostumeInvenIndex != 0L)
		{
			num ^= CostumeInvenIndex.GetHashCode();
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
		if (deckBaseInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(DeckBaseInfo);
		}
		if (CostumeInvenIndex != 0L)
		{
			output.WriteRawTag(16);
			output.WriteInt64(CostumeInvenIndex);
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
		if (deckBaseInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DeckBaseInfo);
		}
		if (CostumeInvenIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(CostumeInvenIndex);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PresetDeckDBInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.deckBaseInfo_ != null)
		{
			if (deckBaseInfo_ == null)
			{
				DeckBaseInfo = new DeckDBInfo();
			}
			DeckBaseInfo.MergeFrom(other.DeckBaseInfo);
		}
		if (other.CostumeInvenIndex != 0L)
		{
			CostumeInvenIndex = other.CostumeInvenIndex;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 16u:
				CostumeInvenIndex = input.ReadInt64();
				break;
			case 10u:
				if (deckBaseInfo_ == null)
				{
					DeckBaseInfo = new DeckDBInfo();
				}
				input.ReadMessage(DeckBaseInfo);
				break;
			}
		}
	}
}
