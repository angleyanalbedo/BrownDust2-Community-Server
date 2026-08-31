using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class FieldMiniGameStarterTable : IMessage<FieldMiniGameStarterTable>, IMessage, IEquatable<FieldMiniGameStarterTable>, IDeepCloneable<FieldMiniGameStarterTable>, IBufferMessage
{
	private static readonly MessageParser<FieldMiniGameStarterTable> _parser = new MessageParser<FieldMiniGameStarterTable>(() => new FieldMiniGameStarterTable());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int InteactionLocalTextIdFieldNumber = 2;

	private int inteactionLocalTextId_;

	public const int IsAutoInteractionFieldNumber = 3;

	private int isAutoInteraction_;

	public const int MiniGameIdFieldNumber = 4;

	private int miniGameId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FieldMiniGameStarterTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FieldMiniGameStarterTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public int InteactionLocalTextId
	{
		get
		{
			return inteactionLocalTextId_;
		}
		set
		{
			inteactionLocalTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int IsAutoInteraction
	{
		get
		{
			return isAutoInteraction_;
		}
		set
		{
			isAutoInteraction_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MiniGameId
	{
		get
		{
			return miniGameId_;
		}
		set
		{
			miniGameId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FieldMiniGameStarterTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FieldMiniGameStarterTable(FieldMiniGameStarterTable other)
		: this()
	{
		id_ = other.id_;
		inteactionLocalTextId_ = other.inteactionLocalTextId_;
		isAutoInteraction_ = other.isAutoInteraction_;
		miniGameId_ = other.miniGameId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FieldMiniGameStarterTable Clone()
	{
		return new FieldMiniGameStarterTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FieldMiniGameStarterTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FieldMiniGameStarterTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && InteactionLocalTextId == other.InteactionLocalTextId && IsAutoInteraction == other.IsAutoInteraction && MiniGameId == other.MiniGameId)
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
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (InteactionLocalTextId != 0)
		{
			num ^= InteactionLocalTextId.GetHashCode();
		}
		if (IsAutoInteraction != 0)
		{
			num ^= IsAutoInteraction.GetHashCode();
		}
		if (MiniGameId != 0)
		{
			num ^= MiniGameId.GetHashCode();
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
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (InteactionLocalTextId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(InteactionLocalTextId);
		}
		if (IsAutoInteraction != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(IsAutoInteraction);
		}
		if (MiniGameId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(MiniGameId);
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
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (InteactionLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(InteactionLocalTextId);
		}
		if (IsAutoInteraction != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IsAutoInteraction);
		}
		if (MiniGameId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MiniGameId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FieldMiniGameStarterTable other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.InteactionLocalTextId != 0)
			{
				InteactionLocalTextId = other.InteactionLocalTextId;
			}
			if (other.IsAutoInteraction != 0)
			{
				IsAutoInteraction = other.IsAutoInteraction;
			}
			if (other.MiniGameId != 0)
			{
				MiniGameId = other.MiniGameId;
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
				Id = input.ReadInt32();
				break;
			case 16u:
				InteactionLocalTextId = input.ReadInt32();
				break;
			case 24u:
				IsAutoInteraction = input.ReadInt32();
				break;
			case 32u:
				MiniGameId = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
