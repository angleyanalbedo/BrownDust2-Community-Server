using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EquipOptionReRollConfirmRequest : IMessage<EquipOptionReRollConfirmRequest>, IMessage, IEquatable<EquipOptionReRollConfirmRequest>, IDeepCloneable<EquipOptionReRollConfirmRequest>, IBufferMessage
{
	private static readonly MessageParser<EquipOptionReRollConfirmRequest> _parser = new MessageParser<EquipOptionReRollConfirmRequest>(() => new EquipOptionReRollConfirmRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int EquipInvenIndexFieldNumber = 2;

	private long equipInvenIndex_;

	public const int IsConfirmFieldNumber = 3;

	private bool isConfirm_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EquipOptionReRollConfirmRequest> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EquipOptionReRollConfirmRequestReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Seq
	{
		get
		{
			return seq_;
		}
		set
		{
			seq_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long EquipInvenIndex
	{
		get
		{
			return equipInvenIndex_;
		}
		set
		{
			equipInvenIndex_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsConfirm
	{
		get
		{
			return isConfirm_;
		}
		set
		{
			isConfirm_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EquipOptionReRollConfirmRequest()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipOptionReRollConfirmRequest(EquipOptionReRollConfirmRequest other)
		: this()
	{
		seq_ = other.seq_;
		equipInvenIndex_ = other.equipInvenIndex_;
		isConfirm_ = other.isConfirm_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipOptionReRollConfirmRequest Clone()
	{
		return new EquipOptionReRollConfirmRequest(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as EquipOptionReRollConfirmRequest);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(EquipOptionReRollConfirmRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && EquipInvenIndex == other.EquipInvenIndex && IsConfirm == other.IsConfirm)
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
		if (Seq != 0)
		{
			num ^= Seq.GetHashCode();
		}
		if (EquipInvenIndex != 0L)
		{
			num ^= EquipInvenIndex.GetHashCode();
		}
		if (IsConfirm)
		{
			num ^= IsConfirm.GetHashCode();
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
		if (Seq != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Seq);
		}
		if (EquipInvenIndex != 0L)
		{
			output.WriteRawTag(16);
			output.WriteInt64(EquipInvenIndex);
		}
		if (IsConfirm)
		{
			output.WriteRawTag(24);
			output.WriteBool(IsConfirm);
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
		if (Seq != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Seq);
		}
		if (EquipInvenIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(EquipInvenIndex);
		}
		if (IsConfirm)
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
	public void MergeFrom(EquipOptionReRollConfirmRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			if (other.EquipInvenIndex != 0L)
			{
				EquipInvenIndex = other.EquipInvenIndex;
			}
			if (other.IsConfirm)
			{
				IsConfirm = other.IsConfirm;
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 24u:
				IsConfirm = input.ReadBool();
				break;
			case 16u:
				EquipInvenIndex = input.ReadInt64();
				break;
			case 8u:
				Seq = input.ReadInt32();
				break;
			}
		}
	}
}
