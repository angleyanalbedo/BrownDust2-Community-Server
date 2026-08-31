using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class LobbyCutsceneTable : IMessage<LobbyCutsceneTable>, IMessage, IEquatable<LobbyCutsceneTable>, IDeepCloneable<LobbyCutsceneTable>, IBufferMessage
{
	private static readonly MessageParser<LobbyCutsceneTable> _parser = new MessageParser<LobbyCutsceneTable>(() => new LobbyCutsceneTable());

	private UnknownFieldSet _unknownFields;

	public const int CostumeConceptInfoTextEnumCountFieldNumber = 1;

	private static readonly FieldCodec<int> _repeated_costumeConceptInfoTextEnumCount_codec = FieldCodec.ForInt32(10u);

	private readonly RepeatedField<int> costumeConceptInfoTextEnumCount_ = new RepeatedField<int>();

	public const int CostumeConceptInfoTextTypeFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_costumeConceptInfoTextType_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> costumeConceptInfoTextType_ = new RepeatedField<int>();

	public const int CostumeConceptInfoVoiceEnumCountFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_costumeConceptInfoVoiceEnumCount_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> costumeConceptInfoVoiceEnumCount_ = new RepeatedField<int>();

	public const int CostumeConceptInfoVoiceTypeFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_costumeConceptInfoVoiceType_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> costumeConceptInfoVoiceType_ = new RepeatedField<int>();

	public const int CostumeIdFieldNumber = 5;

	private int costumeId_;

	public const int IdFieldNumber = 6;

	private int id_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LobbyCutsceneTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LobbyCutsceneTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> CostumeConceptInfoTextEnumCount => costumeConceptInfoTextEnumCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> CostumeConceptInfoTextType => costumeConceptInfoTextType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> CostumeConceptInfoVoiceEnumCount => costumeConceptInfoVoiceEnumCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> CostumeConceptInfoVoiceType => costumeConceptInfoVoiceType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CostumeId
	{
		get
		{
			return costumeId_;
		}
		set
		{
			costumeId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyCutsceneTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public LobbyCutsceneTable(LobbyCutsceneTable other)
		: this()
	{
		costumeConceptInfoTextEnumCount_ = other.costumeConceptInfoTextEnumCount_.Clone();
		costumeConceptInfoTextType_ = other.costumeConceptInfoTextType_.Clone();
		costumeConceptInfoVoiceEnumCount_ = other.costumeConceptInfoVoiceEnumCount_.Clone();
		costumeConceptInfoVoiceType_ = other.costumeConceptInfoVoiceType_.Clone();
		costumeId_ = other.costumeId_;
		id_ = other.id_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyCutsceneTable Clone()
	{
		return new LobbyCutsceneTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LobbyCutsceneTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LobbyCutsceneTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (costumeConceptInfoTextEnumCount_.Equals(other.costumeConceptInfoTextEnumCount_) && costumeConceptInfoTextType_.Equals(other.costumeConceptInfoTextType_) && costumeConceptInfoVoiceEnumCount_.Equals(other.costumeConceptInfoVoiceEnumCount_) && costumeConceptInfoVoiceType_.Equals(other.costumeConceptInfoVoiceType_) && CostumeId == other.CostumeId && Id == other.Id)
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
		num ^= costumeConceptInfoTextEnumCount_.GetHashCode();
		num ^= costumeConceptInfoTextType_.GetHashCode();
		num ^= costumeConceptInfoVoiceEnumCount_.GetHashCode();
		num ^= costumeConceptInfoVoiceType_.GetHashCode();
		if (CostumeId != 0)
		{
			num ^= CostumeId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
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
		costumeConceptInfoTextEnumCount_.WriteTo(ref output, _repeated_costumeConceptInfoTextEnumCount_codec);
		costumeConceptInfoTextType_.WriteTo(ref output, _repeated_costumeConceptInfoTextType_codec);
		costumeConceptInfoVoiceEnumCount_.WriteTo(ref output, _repeated_costumeConceptInfoVoiceEnumCount_codec);
		costumeConceptInfoVoiceType_.WriteTo(ref output, _repeated_costumeConceptInfoVoiceType_codec);
		if (CostumeId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(CostumeId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(Id);
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
		num += costumeConceptInfoTextEnumCount_.CalculateSize(_repeated_costumeConceptInfoTextEnumCount_codec);
		num += costumeConceptInfoTextType_.CalculateSize(_repeated_costumeConceptInfoTextType_codec);
		num += costumeConceptInfoVoiceEnumCount_.CalculateSize(_repeated_costumeConceptInfoVoiceEnumCount_codec);
		num += costumeConceptInfoVoiceType_.CalculateSize(_repeated_costumeConceptInfoVoiceType_codec);
		if (CostumeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CostumeId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(LobbyCutsceneTable other)
	{
		if (other != null)
		{
			costumeConceptInfoTextEnumCount_.Add(other.costumeConceptInfoTextEnumCount_);
			costumeConceptInfoTextType_.Add(other.costumeConceptInfoTextType_);
			costumeConceptInfoVoiceEnumCount_.Add(other.costumeConceptInfoVoiceEnumCount_);
			costumeConceptInfoVoiceType_.Add(other.costumeConceptInfoVoiceType_);
			if (other.CostumeId != 0)
			{
				CostumeId = other.CostumeId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
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
			case 40u:
				CostumeId = input.ReadInt32();
				break;
			case 48u:
				Id = input.ReadInt32();
				break;
			case 32u:
			case 34u:
				costumeConceptInfoVoiceType_.AddEntriesFrom(ref input, _repeated_costumeConceptInfoVoiceType_codec);
				break;
			case 8u:
			case 10u:
				costumeConceptInfoTextEnumCount_.AddEntriesFrom(ref input, _repeated_costumeConceptInfoTextEnumCount_codec);
				break;
			case 16u:
			case 18u:
				costumeConceptInfoTextType_.AddEntriesFrom(ref input, _repeated_costumeConceptInfoTextType_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 24u:
			case 26u:
				costumeConceptInfoVoiceEnumCount_.AddEntriesFrom(ref input, _repeated_costumeConceptInfoVoiceEnumCount_codec);
				break;
			}
		}
	}
}
