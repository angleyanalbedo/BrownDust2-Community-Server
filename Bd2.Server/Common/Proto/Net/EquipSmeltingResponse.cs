using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EquipSmeltingResponse : IMessage<EquipSmeltingResponse>, IMessage, IEquatable<EquipSmeltingResponse>, IDeepCloneable<EquipSmeltingResponse>, IBufferMessage
{
	private static readonly MessageParser<EquipSmeltingResponse> _parser = new MessageParser<EquipSmeltingResponse>(() => new EquipSmeltingResponse());

	private UnknownFieldSet _unknownFields;

	public const int EquipInfoFieldNumber = 1;

	private EquipDBInfo equipInfo_;

	public const int CharInfoFieldNumber = 2;

	private CharDBInfo charInfo_;

	public const int ResultTypeFieldNumber = 3;

	private Define_EquipUpgradeResultType resultType_;

	public const int ResultGradeFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_resultGrade_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> resultGrade_ = new RepeatedField<int>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EquipSmeltingResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EquipSmeltingResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipDBInfo EquipInfo
	{
		get
		{
			return equipInfo_;
		}
		set
		{
			equipInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharDBInfo CharInfo
	{
		get
		{
			return charInfo_;
		}
		set
		{
			charInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Define_EquipUpgradeResultType ResultType
	{
		get
		{
			return resultType_;
		}
		set
		{
			resultType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> ResultGrade => resultGrade_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipSmeltingResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipSmeltingResponse(EquipSmeltingResponse other)
		: this()
	{
		equipInfo_ = ((other.equipInfo_ != null) ? other.equipInfo_.Clone() : null);
		charInfo_ = ((other.charInfo_ != null) ? other.charInfo_.Clone() : null);
		resultType_ = other.resultType_;
		resultGrade_ = other.resultGrade_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipSmeltingResponse Clone()
	{
		return new EquipSmeltingResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EquipSmeltingResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EquipSmeltingResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(EquipInfo, other.EquipInfo) && object.Equals(CharInfo, other.CharInfo) && ResultType == other.ResultType && resultGrade_.Equals(other.resultGrade_))
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
		if (equipInfo_ != null)
		{
			num ^= EquipInfo.GetHashCode();
		}
		if (charInfo_ != null)
		{
			num ^= CharInfo.GetHashCode();
		}
		if (ResultType != Define_EquipUpgradeResultType.UpgradeSuccess)
		{
			num ^= ResultType.GetHashCode();
		}
		num ^= resultGrade_.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (equipInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(EquipInfo);
		}
		if (charInfo_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(CharInfo);
		}
		if (ResultType != Define_EquipUpgradeResultType.UpgradeSuccess)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)ResultType);
		}
		resultGrade_.WriteTo(ref output, _repeated_resultGrade_codec);
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
		if (equipInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EquipInfo);
		}
		if (charInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CharInfo);
		}
		if (ResultType != Define_EquipUpgradeResultType.UpgradeSuccess)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ResultType);
		}
		num += resultGrade_.CalculateSize(_repeated_resultGrade_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EquipSmeltingResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.equipInfo_ != null)
		{
			if (equipInfo_ == null)
			{
				EquipInfo = new EquipDBInfo();
			}
			EquipInfo.MergeFrom(other.EquipInfo);
		}
		if (other.charInfo_ != null)
		{
			if (charInfo_ == null)
			{
				CharInfo = new CharDBInfo();
			}
			CharInfo.MergeFrom(other.CharInfo);
		}
		if (other.ResultType != Define_EquipUpgradeResultType.UpgradeSuccess)
		{
			ResultType = other.ResultType;
		}
		resultGrade_.Add(other.resultGrade_);
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
			case 10u:
				if (equipInfo_ == null)
				{
					EquipInfo = new EquipDBInfo();
				}
				input.ReadMessage(EquipInfo);
				break;
			case 18u:
				if (charInfo_ == null)
				{
					CharInfo = new CharDBInfo();
				}
				input.ReadMessage(CharInfo);
				break;
			case 24u:
				ResultType = (Define_EquipUpgradeResultType)input.ReadEnum();
				break;
			case 32u:
			case 34u:
				resultGrade_.AddEntriesFrom(ref input, _repeated_resultGrade_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
