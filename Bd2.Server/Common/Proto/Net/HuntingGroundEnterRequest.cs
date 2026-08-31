using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class HuntingGroundEnterRequest : IMessage<HuntingGroundEnterRequest>, IMessage, IEquatable<HuntingGroundEnterRequest>, IDeepCloneable<HuntingGroundEnterRequest>, IBufferMessage
{
	private static readonly MessageParser<HuntingGroundEnterRequest> _parser = new MessageParser<HuntingGroundEnterRequest>(() => new HuntingGroundEnterRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int PackIdFieldNumber = 2;

	private int packId_;

	public const int HuntingGroundIdFieldNumber = 3;

	private int huntingGroundId_;

	public const int IsAutoFieldNumber = 5;

	private bool isAuto_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HuntingGroundEnterRequest> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => HuntingGroundEnterRequestReflection.Descriptor.MessageTypes[0];

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
	public int PackId
	{
		get
		{
			return packId_;
		}
		set
		{
			packId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int HuntingGroundId
	{
		get
		{
			return huntingGroundId_;
		}
		set
		{
			huntingGroundId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsAuto
	{
		get
		{
			return isAuto_;
		}
		set
		{
			isAuto_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HuntingGroundEnterRequest()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HuntingGroundEnterRequest(HuntingGroundEnterRequest other)
		: this()
	{
		seq_ = other.seq_;
		packId_ = other.packId_;
		huntingGroundId_ = other.huntingGroundId_;
		isAuto_ = other.isAuto_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HuntingGroundEnterRequest Clone()
	{
		return new HuntingGroundEnterRequest(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HuntingGroundEnterRequest);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HuntingGroundEnterRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && PackId == other.PackId && HuntingGroundId == other.HuntingGroundId && IsAuto == other.IsAuto)
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
		if (Seq != 0)
		{
			num ^= Seq.GetHashCode();
		}
		if (PackId != 0)
		{
			num ^= PackId.GetHashCode();
		}
		if (HuntingGroundId != 0)
		{
			num ^= HuntingGroundId.GetHashCode();
		}
		if (IsAuto)
		{
			num ^= IsAuto.GetHashCode();
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
		if (PackId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(PackId);
		}
		if (HuntingGroundId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(HuntingGroundId);
		}
		if (IsAuto)
		{
			output.WriteRawTag(40);
			output.WriteBool(IsAuto);
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
		if (PackId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PackId);
		}
		if (HuntingGroundId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HuntingGroundId);
		}
		if (IsAuto)
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
	public void MergeFrom(HuntingGroundEnterRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			if (other.PackId != 0)
			{
				PackId = other.PackId;
			}
			if (other.HuntingGroundId != 0)
			{
				HuntingGroundId = other.HuntingGroundId;
			}
			if (other.IsAuto)
			{
				IsAuto = other.IsAuto;
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
				Seq = input.ReadInt32();
				break;
			case 16u:
				PackId = input.ReadInt32();
				break;
			case 24u:
				HuntingGroundId = input.ReadInt32();
				break;
			case 40u:
				IsAuto = input.ReadBool();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
