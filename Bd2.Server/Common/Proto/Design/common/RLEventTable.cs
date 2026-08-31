using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class RLEventTable : IMessage<RLEventTable>, IMessage, IEquatable<RLEventTable>, IDeepCloneable<RLEventTable>, IBufferMessage
{
	private static readonly MessageParser<RLEventTable> _parser = new MessageParser<RLEventTable>(() => new RLEventTable());

	private UnknownFieldSet _unknownFields;

	public const int Choice1EffectIdFieldNumber = 1;

	private static readonly FieldCodec<int> _repeated_choice1EffectId_codec = FieldCodec.ForInt32(10u);

	private readonly RepeatedField<int> choice1EffectId_ = new RepeatedField<int>();

	public const int Choice1FailEffectIdFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_choice1FailEffectId_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> choice1FailEffectId_ = new RepeatedField<int>();

	public const int Choice2EffectIdFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_choice2EffectId_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> choice2EffectId_ = new RepeatedField<int>();

	public const int ChoiceDescNameTextIdFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_choiceDescNameTextId_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> choiceDescNameTextId_ = new RepeatedField<int>();

	public const int ChoiceFailResultNameTextIdFieldNumber = 5;

	private static readonly FieldCodec<int> _repeated_choiceFailResultNameTextId_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> choiceFailResultNameTextId_ = new RepeatedField<int>();

	public const int ChoiceResultNameTextIdFieldNumber = 6;

	private static readonly FieldCodec<int> _repeated_choiceResultNameTextId_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> choiceResultNameTextId_ = new RepeatedField<int>();

	public const int ChoiceTypeFieldNumber = 7;

	private static readonly FieldCodec<int> _repeated_choiceType_codec = FieldCodec.ForInt32(58u);

	private readonly RepeatedField<int> choiceType_ = new RepeatedField<int>();

	public const int EventDescNameTextIdFieldNumber = 8;

	private int eventDescNameTextId_;

	public const int EventNameTextIdFieldNumber = 9;

	private int eventNameTextId_;

	public const int EventSuccessRateFieldNumber = 10;

	private static readonly FieldCodec<int> _repeated_eventSuccessRate_codec = FieldCodec.ForInt32(82u);

	private readonly RepeatedField<int> eventSuccessRate_ = new RepeatedField<int>();

	public const int ExitChoiceSwitchFieldNumber = 11;

	private int exitChoiceSwitch_;

	public const int ExitDescNameTextIdFieldNumber = 12;

	private int exitDescNameTextId_;

	public const int GroupIdFieldNumber = 13;

	private int groupId_;

	public const int IdFieldNumber = 14;

	private int id_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RLEventTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RLEventTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> Choice1EffectId => choice1EffectId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> Choice1FailEffectId => choice1FailEffectId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> Choice2EffectId => choice2EffectId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> ChoiceDescNameTextId => choiceDescNameTextId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> ChoiceFailResultNameTextId => choiceFailResultNameTextId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> ChoiceResultNameTextId => choiceResultNameTextId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> ChoiceType => choiceType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EventDescNameTextId
	{
		get
		{
			return eventDescNameTextId_;
		}
		set
		{
			eventDescNameTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EventNameTextId
	{
		get
		{
			return eventNameTextId_;
		}
		set
		{
			eventNameTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> EventSuccessRate => eventSuccessRate_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ExitChoiceSwitch
	{
		get
		{
			return exitChoiceSwitch_;
		}
		set
		{
			exitChoiceSwitch_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ExitDescNameTextId
	{
		get
		{
			return exitDescNameTextId_;
		}
		set
		{
			exitDescNameTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
		}
	}

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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RLEventTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RLEventTable(RLEventTable other)
		: this()
	{
		choice1EffectId_ = other.choice1EffectId_.Clone();
		choice1FailEffectId_ = other.choice1FailEffectId_.Clone();
		choice2EffectId_ = other.choice2EffectId_.Clone();
		choiceDescNameTextId_ = other.choiceDescNameTextId_.Clone();
		choiceFailResultNameTextId_ = other.choiceFailResultNameTextId_.Clone();
		choiceResultNameTextId_ = other.choiceResultNameTextId_.Clone();
		choiceType_ = other.choiceType_.Clone();
		eventDescNameTextId_ = other.eventDescNameTextId_;
		eventNameTextId_ = other.eventNameTextId_;
		eventSuccessRate_ = other.eventSuccessRate_.Clone();
		exitChoiceSwitch_ = other.exitChoiceSwitch_;
		exitDescNameTextId_ = other.exitDescNameTextId_;
		groupId_ = other.groupId_;
		id_ = other.id_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RLEventTable Clone()
	{
		return new RLEventTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RLEventTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RLEventTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (choice1EffectId_.Equals(other.choice1EffectId_) && choice1FailEffectId_.Equals(other.choice1FailEffectId_) && choice2EffectId_.Equals(other.choice2EffectId_) && choiceDescNameTextId_.Equals(other.choiceDescNameTextId_) && choiceFailResultNameTextId_.Equals(other.choiceFailResultNameTextId_) && choiceResultNameTextId_.Equals(other.choiceResultNameTextId_) && choiceType_.Equals(other.choiceType_) && EventDescNameTextId == other.EventDescNameTextId && EventNameTextId == other.EventNameTextId && eventSuccessRate_.Equals(other.eventSuccessRate_) && ExitChoiceSwitch == other.ExitChoiceSwitch && ExitDescNameTextId == other.ExitDescNameTextId && GroupId == other.GroupId && Id == other.Id)
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
		num ^= choice1EffectId_.GetHashCode();
		num ^= choice1FailEffectId_.GetHashCode();
		num ^= choice2EffectId_.GetHashCode();
		num ^= choiceDescNameTextId_.GetHashCode();
		num ^= choiceFailResultNameTextId_.GetHashCode();
		num ^= choiceResultNameTextId_.GetHashCode();
		num ^= choiceType_.GetHashCode();
		if (EventDescNameTextId != 0)
		{
			num ^= EventDescNameTextId.GetHashCode();
		}
		if (EventNameTextId != 0)
		{
			num ^= EventNameTextId.GetHashCode();
		}
		num ^= eventSuccessRate_.GetHashCode();
		if (ExitChoiceSwitch != 0)
		{
			num ^= ExitChoiceSwitch.GetHashCode();
		}
		if (ExitDescNameTextId != 0)
		{
			num ^= ExitDescNameTextId.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
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
		choice1EffectId_.WriteTo(ref output, _repeated_choice1EffectId_codec);
		choice1FailEffectId_.WriteTo(ref output, _repeated_choice1FailEffectId_codec);
		choice2EffectId_.WriteTo(ref output, _repeated_choice2EffectId_codec);
		choiceDescNameTextId_.WriteTo(ref output, _repeated_choiceDescNameTextId_codec);
		choiceFailResultNameTextId_.WriteTo(ref output, _repeated_choiceFailResultNameTextId_codec);
		choiceResultNameTextId_.WriteTo(ref output, _repeated_choiceResultNameTextId_codec);
		choiceType_.WriteTo(ref output, _repeated_choiceType_codec);
		if (EventDescNameTextId != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(EventDescNameTextId);
		}
		if (EventNameTextId != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(EventNameTextId);
		}
		eventSuccessRate_.WriteTo(ref output, _repeated_eventSuccessRate_codec);
		if (ExitChoiceSwitch != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(ExitChoiceSwitch);
		}
		if (ExitDescNameTextId != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(ExitDescNameTextId);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(GroupId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(112);
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
		num += choice1EffectId_.CalculateSize(_repeated_choice1EffectId_codec);
		num += choice1FailEffectId_.CalculateSize(_repeated_choice1FailEffectId_codec);
		num += choice2EffectId_.CalculateSize(_repeated_choice2EffectId_codec);
		num += choiceDescNameTextId_.CalculateSize(_repeated_choiceDescNameTextId_codec);
		num += choiceFailResultNameTextId_.CalculateSize(_repeated_choiceFailResultNameTextId_codec);
		num += choiceResultNameTextId_.CalculateSize(_repeated_choiceResultNameTextId_codec);
		num += choiceType_.CalculateSize(_repeated_choiceType_codec);
		if (EventDescNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventDescNameTextId);
		}
		if (EventNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventNameTextId);
		}
		num += eventSuccessRate_.CalculateSize(_repeated_eventSuccessRate_codec);
		if (ExitChoiceSwitch != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ExitChoiceSwitch);
		}
		if (ExitDescNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ExitDescNameTextId);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RLEventTable other)
	{
		if (other != null)
		{
			choice1EffectId_.Add(other.choice1EffectId_);
			choice1FailEffectId_.Add(other.choice1FailEffectId_);
			choice2EffectId_.Add(other.choice2EffectId_);
			choiceDescNameTextId_.Add(other.choiceDescNameTextId_);
			choiceFailResultNameTextId_.Add(other.choiceFailResultNameTextId_);
			choiceResultNameTextId_.Add(other.choiceResultNameTextId_);
			choiceType_.Add(other.choiceType_);
			if (other.EventDescNameTextId != 0)
			{
				EventDescNameTextId = other.EventDescNameTextId;
			}
			if (other.EventNameTextId != 0)
			{
				EventNameTextId = other.EventNameTextId;
			}
			eventSuccessRate_.Add(other.eventSuccessRate_);
			if (other.ExitChoiceSwitch != 0)
			{
				ExitChoiceSwitch = other.ExitChoiceSwitch;
			}
			if (other.ExitDescNameTextId != 0)
			{
				ExitDescNameTextId = other.ExitDescNameTextId;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
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
			switch (num)
			{
			case 8u:
			case 10u:
				choice1EffectId_.AddEntriesFrom(ref input, _repeated_choice1EffectId_codec);
				break;
			case 16u:
			case 18u:
				choice1FailEffectId_.AddEntriesFrom(ref input, _repeated_choice1FailEffectId_codec);
				break;
			case 32u:
			case 34u:
				choiceDescNameTextId_.AddEntriesFrom(ref input, _repeated_choiceDescNameTextId_codec);
				break;
			case 40u:
			case 42u:
				choiceFailResultNameTextId_.AddEntriesFrom(ref input, _repeated_choiceFailResultNameTextId_codec);
				break;
			case 24u:
			case 26u:
				choice2EffectId_.AddEntriesFrom(ref input, _repeated_choice2EffectId_codec);
				break;
			case 64u:
				EventDescNameTextId = input.ReadInt32();
				break;
			case 72u:
				EventNameTextId = input.ReadInt32();
				break;
			case 56u:
			case 58u:
				choiceType_.AddEntriesFrom(ref input, _repeated_choiceType_codec);
				break;
			case 80u:
			case 82u:
				eventSuccessRate_.AddEntriesFrom(ref input, _repeated_eventSuccessRate_codec);
				break;
			case 88u:
				ExitChoiceSwitch = input.ReadInt32();
				break;
			case 96u:
				ExitDescNameTextId = input.ReadInt32();
				break;
			case 104u:
				GroupId = input.ReadInt32();
				break;
			case 112u:
				Id = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 48u:
			case 50u:
				choiceResultNameTextId_.AddEntriesFrom(ref input, _repeated_choiceResultNameTextId_codec);
				break;
			}
		}
	}
}
