using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EquipInfoResponse : IMessage<EquipInfoResponse>, IMessage, IEquatable<EquipInfoResponse>, IDeepCloneable<EquipInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<EquipInfoResponse> _parser = new MessageParser<EquipInfoResponse>(() => new EquipInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int EquipInfoFieldNumber = 1;

	private static readonly FieldCodec<EquipDBInfo> _repeated_equipInfo_codec = FieldCodec.ForMessage(10u, EquipDBInfo.Parser);

	private readonly RepeatedField<EquipDBInfo> equipInfo_ = new RepeatedField<EquipDBInfo>();

	public const int EquipOptionReRollInfoFieldNumber = 2;

	private EquipDBInfo equipOptionReRollInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EquipInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EquipInfoResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EquipDBInfo> EquipInfo => equipInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EquipDBInfo EquipOptionReRollInfo
	{
		get
		{
			return equipOptionReRollInfo_;
		}
		set
		{
			equipOptionReRollInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipInfoResponse(EquipInfoResponse other)
		: this()
	{
		equipInfo_ = other.equipInfo_.Clone();
		equipOptionReRollInfo_ = ((other.equipOptionReRollInfo_ != null) ? other.equipOptionReRollInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipInfoResponse Clone()
	{
		return new EquipInfoResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as EquipInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EquipInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (equipInfo_.Equals(other.equipInfo_) && object.Equals(EquipOptionReRollInfo, other.EquipOptionReRollInfo))
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
		num ^= equipInfo_.GetHashCode();
		if (equipOptionReRollInfo_ != null)
		{
			num ^= EquipOptionReRollInfo.GetHashCode();
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
		equipInfo_.WriteTo(ref output, _repeated_equipInfo_codec);
		if (equipOptionReRollInfo_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(EquipOptionReRollInfo);
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
		num += equipInfo_.CalculateSize(_repeated_equipInfo_codec);
		if (equipOptionReRollInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EquipOptionReRollInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EquipInfoResponse other)
	{
		if (other == null)
		{
			return;
		}
		equipInfo_.Add(other.equipInfo_);
		if (other.equipOptionReRollInfo_ != null)
		{
			if (equipOptionReRollInfo_ == null)
			{
				EquipOptionReRollInfo = new EquipDBInfo();
			}
			EquipOptionReRollInfo.MergeFrom(other.EquipOptionReRollInfo);
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
			case 18u:
				if (equipOptionReRollInfo_ == null)
				{
					EquipOptionReRollInfo = new EquipDBInfo();
				}
				input.ReadMessage(EquipOptionReRollInfo);
				break;
			case 10u:
				equipInfo_.AddEntriesFrom(ref input, _repeated_equipInfo_codec);
				break;
			}
		}
	}
}
