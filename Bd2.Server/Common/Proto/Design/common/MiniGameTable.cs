using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class MiniGameTable : IMessage<MiniGameTable>, IMessage, IEquatable<MiniGameTable>, IDeepCloneable<MiniGameTable>, IBufferMessage
{
	private static readonly MessageParser<MiniGameTable> _parser = new MessageParser<MiniGameTable>(() => new MiniGameTable());

	private UnknownFieldSet _unknownFields;

	public const int AnswerIndexFieldNumber = 1;

	private static readonly FieldCodec<int> _repeated_answerIndex_codec = FieldCodec.ForInt32(10u);

	private readonly RepeatedField<int> answerIndex_ = new RepeatedField<int>();

	public const int GameTypeFieldNumber = 2;

	private int gameType_;

	public const int IdFieldNumber = 3;

	private int id_;

	public const int PrefabNameFieldNumber = 4;

	private string prefabName_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MiniGameTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MiniGameTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> AnswerIndex => answerIndex_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GameType
	{
		get
		{
			return gameType_;
		}
		set
		{
			gameType_ = value;
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
	public string PrefabName
	{
		get
		{
			return prefabName_;
		}
		set
		{
			prefabName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MiniGameTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameTable(MiniGameTable other)
		: this()
	{
		answerIndex_ = other.answerIndex_.Clone();
		gameType_ = other.gameType_;
		id_ = other.id_;
		prefabName_ = other.prefabName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameTable Clone()
	{
		return new MiniGameTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MiniGameTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MiniGameTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (answerIndex_.Equals(other.answerIndex_) && GameType == other.GameType && Id == other.Id && !(PrefabName != other.PrefabName))
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
		num ^= answerIndex_.GetHashCode();
		if (GameType != 0)
		{
			num ^= GameType.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (PrefabName.Length != 0)
		{
			num ^= PrefabName.GetHashCode();
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
		answerIndex_.WriteTo(ref output, _repeated_answerIndex_codec);
		if (GameType != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(GameType);
		}
		if (Id != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Id);
		}
		if (PrefabName.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(PrefabName);
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
		num += answerIndex_.CalculateSize(_repeated_answerIndex_codec);
		if (GameType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GameType);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (PrefabName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PrefabName);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MiniGameTable other)
	{
		if (other != null)
		{
			answerIndex_.Add(other.answerIndex_);
			if (other.GameType != 0)
			{
				GameType = other.GameType;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.PrefabName.Length != 0)
			{
				PrefabName = other.PrefabName;
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
			case 8u:
			case 10u:
				answerIndex_.AddEntriesFrom(ref input, _repeated_answerIndex_codec);
				break;
			case 16u:
				GameType = input.ReadInt32();
				break;
			case 24u:
				Id = input.ReadInt32();
				break;
			case 34u:
				PrefabName = input.ReadString();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
