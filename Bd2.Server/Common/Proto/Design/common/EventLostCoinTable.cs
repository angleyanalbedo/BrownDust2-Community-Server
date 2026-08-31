using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class EventLostCoinTable : IMessage<EventLostCoinTable>, IMessage, IEquatable<EventLostCoinTable>, IDeepCloneable<EventLostCoinTable>, IBufferMessage
{
	private static readonly MessageParser<EventLostCoinTable> _parser = new MessageParser<EventLostCoinTable>(() => new EventLostCoinTable());

	private UnknownFieldSet _unknownFields;

	public const int EventPackIdFieldNumber = 1;

	private static readonly FieldCodec<int> _repeated_eventPackId_codec = FieldCodec.ForInt32(10u);

	private readonly RepeatedField<int> eventPackId_ = new RepeatedField<int>();

	public const int GuideDescLocalTextIdFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_guideDescLocalTextId_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> guideDescLocalTextId_ = new RepeatedField<int>();

	public const int GuideTitleLocalTextIdFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_guideTitleLocalTextId_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> guideTitleLocalTextId_ = new RepeatedField<int>();

	public const int IdFieldNumber = 4;

	private int id_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<EventLostCoinTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => EventLostCoinTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> EventPackId => eventPackId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> GuideDescLocalTextId => guideDescLocalTextId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> GuideTitleLocalTextId => guideTitleLocalTextId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EventLostCoinTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EventLostCoinTable(EventLostCoinTable other)
		: this()
	{
		eventPackId_ = other.eventPackId_.Clone();
		guideDescLocalTextId_ = other.guideDescLocalTextId_.Clone();
		guideTitleLocalTextId_ = other.guideTitleLocalTextId_.Clone();
		id_ = other.id_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventLostCoinTable Clone()
	{
		return new EventLostCoinTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EventLostCoinTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EventLostCoinTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (eventPackId_.Equals(other.eventPackId_) && guideDescLocalTextId_.Equals(other.guideDescLocalTextId_) && guideTitleLocalTextId_.Equals(other.guideTitleLocalTextId_) && Id == other.Id)
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
		num ^= eventPackId_.GetHashCode();
		num ^= guideDescLocalTextId_.GetHashCode();
		num ^= guideTitleLocalTextId_.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		eventPackId_.WriteTo(ref output, _repeated_eventPackId_codec);
		guideDescLocalTextId_.WriteTo(ref output, _repeated_guideDescLocalTextId_codec);
		guideTitleLocalTextId_.WriteTo(ref output, _repeated_guideTitleLocalTextId_codec);
		if (Id != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Id);
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
		num += eventPackId_.CalculateSize(_repeated_eventPackId_codec);
		num += guideDescLocalTextId_.CalculateSize(_repeated_guideDescLocalTextId_codec);
		num += guideTitleLocalTextId_.CalculateSize(_repeated_guideTitleLocalTextId_codec);
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EventLostCoinTable other)
	{
		if (other != null)
		{
			eventPackId_.Add(other.eventPackId_);
			guideDescLocalTextId_.Add(other.guideDescLocalTextId_);
			guideTitleLocalTextId_.Add(other.guideTitleLocalTextId_);
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
			case 32u:
				Id = input.ReadInt32();
				break;
			case 24u:
			case 26u:
				guideTitleLocalTextId_.AddEntriesFrom(ref input, _repeated_guideTitleLocalTextId_codec);
				break;
			case 8u:
			case 10u:
				eventPackId_.AddEntriesFrom(ref input, _repeated_eventPackId_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 16u:
			case 18u:
				guideDescLocalTextId_.AddEntriesFrom(ref input, _repeated_guideDescLocalTextId_codec);
				break;
			}
		}
	}
}
