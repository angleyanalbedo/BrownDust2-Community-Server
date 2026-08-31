using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class StandingTalkTable : IMessage<StandingTalkTable>, IMessage, IEquatable<StandingTalkTable>, IDeepCloneable<StandingTalkTable>, IBufferMessage
{
	private static readonly MessageParser<StandingTalkTable> _parser = new MessageParser<StandingTalkTable>(() => new StandingTalkTable());

	private UnknownFieldSet _unknownFields;

	public const int BackgroundImgNameFieldNumber = 1;

	private string backgroundImgName_ = "";

	public const int DialogTextIdFieldNumber = 2;

	private int dialogTextId_;

	public const int GroupIdFieldNumber = 3;

	private int groupId_;

	public const int IdFieldNumber = 4;

	private int id_;

	public const int IllustCharAnimationFieldNumber = 5;

	private static readonly FieldCodec<string> _repeated_illustCharAnimation_codec = FieldCodec.ForString(42u);

	private readonly RepeatedField<string> illustCharAnimation_ = new RepeatedField<string>();

	public const int IllustUniqueCharIdFieldNumber = 6;

	private static readonly FieldCodec<int> _repeated_illustUniqueCharId_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> illustUniqueCharId_ = new RepeatedField<int>();

	public const int StateFieldNumber = 7;

	private int state_;

	public const int TalkCharIndexFieldNumber = 8;

	private int talkCharIndex_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<StandingTalkTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => StandingTalkTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string BackgroundImgName
	{
		get
		{
			return backgroundImgName_;
		}
		set
		{
			backgroundImgName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DialogTextId
	{
		get
		{
			return dialogTextId_;
		}
		set
		{
			dialogTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public RepeatedField<string> IllustCharAnimation => illustCharAnimation_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> IllustUniqueCharId => illustUniqueCharId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int State
	{
		get
		{
			return state_;
		}
		set
		{
			state_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TalkCharIndex
	{
		get
		{
			return talkCharIndex_;
		}
		set
		{
			talkCharIndex_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StandingTalkTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StandingTalkTable(StandingTalkTable other)
		: this()
	{
		backgroundImgName_ = other.backgroundImgName_;
		dialogTextId_ = other.dialogTextId_;
		groupId_ = other.groupId_;
		id_ = other.id_;
		illustCharAnimation_ = other.illustCharAnimation_.Clone();
		illustUniqueCharId_ = other.illustUniqueCharId_.Clone();
		state_ = other.state_;
		talkCharIndex_ = other.talkCharIndex_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public StandingTalkTable Clone()
	{
		return new StandingTalkTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as StandingTalkTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(StandingTalkTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (!(BackgroundImgName != other.BackgroundImgName) && DialogTextId == other.DialogTextId && GroupId == other.GroupId && Id == other.Id && illustCharAnimation_.Equals(other.illustCharAnimation_) && illustUniqueCharId_.Equals(other.illustUniqueCharId_) && State == other.State && TalkCharIndex == other.TalkCharIndex)
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
		if (BackgroundImgName.Length != 0)
		{
			num ^= BackgroundImgName.GetHashCode();
		}
		if (DialogTextId != 0)
		{
			num ^= DialogTextId.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		num ^= illustCharAnimation_.GetHashCode();
		num ^= illustUniqueCharId_.GetHashCode();
		if (State != 0)
		{
			num ^= State.GetHashCode();
		}
		if (TalkCharIndex != 0)
		{
			num ^= TalkCharIndex.GetHashCode();
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
		if (BackgroundImgName.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(BackgroundImgName);
		}
		if (DialogTextId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(DialogTextId);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(GroupId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Id);
		}
		illustCharAnimation_.WriteTo(ref output, _repeated_illustCharAnimation_codec);
		illustUniqueCharId_.WriteTo(ref output, _repeated_illustUniqueCharId_codec);
		if (State != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(State);
		}
		if (TalkCharIndex != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(TalkCharIndex);
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
		if (BackgroundImgName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BackgroundImgName);
		}
		if (DialogTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DialogTextId);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		num += illustCharAnimation_.CalculateSize(_repeated_illustCharAnimation_codec);
		num += illustUniqueCharId_.CalculateSize(_repeated_illustUniqueCharId_codec);
		if (State != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(State);
		}
		if (TalkCharIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TalkCharIndex);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(StandingTalkTable other)
	{
		if (other != null)
		{
			if (other.BackgroundImgName.Length != 0)
			{
				BackgroundImgName = other.BackgroundImgName;
			}
			if (other.DialogTextId != 0)
			{
				DialogTextId = other.DialogTextId;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			illustCharAnimation_.Add(other.illustCharAnimation_);
			illustUniqueCharId_.Add(other.illustUniqueCharId_);
			if (other.State != 0)
			{
				State = other.State;
			}
			if (other.TalkCharIndex != 0)
			{
				TalkCharIndex = other.TalkCharIndex;
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
			case 42u:
				illustCharAnimation_.AddEntriesFrom(ref input, _repeated_illustCharAnimation_codec);
				break;
			case 56u:
				State = input.ReadInt32();
				break;
			case 64u:
				TalkCharIndex = input.ReadInt32();
				break;
			case 48u:
			case 50u:
				illustUniqueCharId_.AddEntriesFrom(ref input, _repeated_illustUniqueCharId_codec);
				break;
			case 10u:
				BackgroundImgName = input.ReadString();
				break;
			case 16u:
				DialogTextId = input.ReadInt32();
				break;
			case 24u:
				GroupId = input.ReadInt32();
				break;
			case 32u:
				Id = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
