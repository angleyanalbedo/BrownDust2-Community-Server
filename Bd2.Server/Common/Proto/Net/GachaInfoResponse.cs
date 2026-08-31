using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GachaInfoResponse : IMessage<GachaInfoResponse>, IMessage, IEquatable<GachaInfoResponse>, IDeepCloneable<GachaInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<GachaInfoResponse> _parser = new MessageParser<GachaInfoResponse>(() => new GachaInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int ScheduleInfoFieldNumber = 1;

	private static readonly FieldCodec<GachaScheduleDBInfo> _repeated_scheduleInfo_codec = FieldCodec.ForMessage(10u, GachaScheduleDBInfo.Parser);

	private readonly RepeatedField<GachaScheduleDBInfo> scheduleInfo_ = new RepeatedField<GachaScheduleDBInfo>();

	public const int GachaUserInfoFieldNumber = 2;

	private static readonly FieldCodec<GachaUserDBInfo> _repeated_gachaUserInfo_codec = FieldCodec.ForMessage(18u, GachaUserDBInfo.Parser);

	private readonly RepeatedField<GachaUserDBInfo> gachaUserInfo_ = new RepeatedField<GachaUserDBInfo>();

	public const int ScheduleEndExchangePointFieldNumber = 3;

	private int scheduleEndExchangePoint_;

	public const int GachaFixedInfoFieldNumber = 4;

	private static readonly FieldCodec<GachaFixedDBInfo> _repeated_gachaFixedInfo_codec = FieldCodec.ForMessage(34u, GachaFixedDBInfo.Parser);

	private readonly RepeatedField<GachaFixedDBInfo> gachaFixedInfo_ = new RepeatedField<GachaFixedDBInfo>();

	public const int GachaSelectionInfoFieldNumber = 5;

	private static readonly FieldCodec<GachaSelectionDBInfo> _repeated_gachaSelectionInfo_codec = FieldCodec.ForMessage(42u, GachaSelectionDBInfo.Parser);

	private readonly RepeatedField<GachaSelectionDBInfo> gachaSelectionInfo_ = new RepeatedField<GachaSelectionDBInfo>();

	public const int StepUpScheduleInfoFieldNumber = 6;

	private static readonly FieldCodec<GachaStepUpScheduleDBInfo> _repeated_stepUpScheduleInfo_codec = FieldCodec.ForMessage(50u, GachaStepUpScheduleDBInfo.Parser);

	private readonly RepeatedField<GachaStepUpScheduleDBInfo> stepUpScheduleInfo_ = new RepeatedField<GachaStepUpScheduleDBInfo>();

	public const int StepUpUserInfoFieldNumber = 7;

	private static readonly FieldCodec<GachaStepUpUserDBInfo> _repeated_stepUpUserInfo_codec = FieldCodec.ForMessage(58u, GachaStepUpUserDBInfo.Parser);

	private readonly RepeatedField<GachaStepUpUserDBInfo> stepUpUserInfo_ = new RepeatedField<GachaStepUpUserDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GachaInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GachaInfoResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GachaScheduleDBInfo> ScheduleInfo => scheduleInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<GachaUserDBInfo> GachaUserInfo => gachaUserInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ScheduleEndExchangePoint
	{
		get
		{
			return scheduleEndExchangePoint_;
		}
		set
		{
			scheduleEndExchangePoint_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GachaFixedDBInfo> GachaFixedInfo => gachaFixedInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<GachaSelectionDBInfo> GachaSelectionInfo => gachaSelectionInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GachaStepUpScheduleDBInfo> StepUpScheduleInfo => stepUpScheduleInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GachaStepUpUserDBInfo> StepUpUserInfo => stepUpUserInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GachaInfoResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GachaInfoResponse(GachaInfoResponse other)
		: this()
	{
		scheduleInfo_ = other.scheduleInfo_.Clone();
		gachaUserInfo_ = other.gachaUserInfo_.Clone();
		scheduleEndExchangePoint_ = other.scheduleEndExchangePoint_;
		gachaFixedInfo_ = other.gachaFixedInfo_.Clone();
		gachaSelectionInfo_ = other.gachaSelectionInfo_.Clone();
		stepUpScheduleInfo_ = other.stepUpScheduleInfo_.Clone();
		stepUpUserInfo_ = other.stepUpUserInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaInfoResponse Clone()
	{
		return new GachaInfoResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as GachaInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GachaInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (scheduleInfo_.Equals(other.scheduleInfo_) && gachaUserInfo_.Equals(other.gachaUserInfo_) && ScheduleEndExchangePoint == other.ScheduleEndExchangePoint && gachaFixedInfo_.Equals(other.gachaFixedInfo_) && gachaSelectionInfo_.Equals(other.gachaSelectionInfo_) && stepUpScheduleInfo_.Equals(other.stepUpScheduleInfo_) && stepUpUserInfo_.Equals(other.stepUpUserInfo_))
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
		num ^= scheduleInfo_.GetHashCode();
		num ^= gachaUserInfo_.GetHashCode();
		if (ScheduleEndExchangePoint != 0)
		{
			num ^= ScheduleEndExchangePoint.GetHashCode();
		}
		num ^= gachaFixedInfo_.GetHashCode();
		num ^= gachaSelectionInfo_.GetHashCode();
		num ^= stepUpScheduleInfo_.GetHashCode();
		num ^= stepUpUserInfo_.GetHashCode();
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
		scheduleInfo_.WriteTo(ref output, _repeated_scheduleInfo_codec);
		gachaUserInfo_.WriteTo(ref output, _repeated_gachaUserInfo_codec);
		if (ScheduleEndExchangePoint != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ScheduleEndExchangePoint);
		}
		gachaFixedInfo_.WriteTo(ref output, _repeated_gachaFixedInfo_codec);
		gachaSelectionInfo_.WriteTo(ref output, _repeated_gachaSelectionInfo_codec);
		stepUpScheduleInfo_.WriteTo(ref output, _repeated_stepUpScheduleInfo_codec);
		stepUpUserInfo_.WriteTo(ref output, _repeated_stepUpUserInfo_codec);
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
		num += scheduleInfo_.CalculateSize(_repeated_scheduleInfo_codec);
		num += gachaUserInfo_.CalculateSize(_repeated_gachaUserInfo_codec);
		if (ScheduleEndExchangePoint != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ScheduleEndExchangePoint);
		}
		num += gachaFixedInfo_.CalculateSize(_repeated_gachaFixedInfo_codec);
		num += gachaSelectionInfo_.CalculateSize(_repeated_gachaSelectionInfo_codec);
		num += stepUpScheduleInfo_.CalculateSize(_repeated_stepUpScheduleInfo_codec);
		num += stepUpUserInfo_.CalculateSize(_repeated_stepUpUserInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GachaInfoResponse other)
	{
		if (other != null)
		{
			scheduleInfo_.Add(other.scheduleInfo_);
			gachaUserInfo_.Add(other.gachaUserInfo_);
			if (other.ScheduleEndExchangePoint != 0)
			{
				ScheduleEndExchangePoint = other.ScheduleEndExchangePoint;
			}
			gachaFixedInfo_.Add(other.gachaFixedInfo_);
			gachaSelectionInfo_.Add(other.gachaSelectionInfo_);
			stepUpScheduleInfo_.Add(other.stepUpScheduleInfo_);
			stepUpUserInfo_.Add(other.stepUpUserInfo_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			case 10u:
				scheduleInfo_.AddEntriesFrom(ref input, _repeated_scheduleInfo_codec);
				break;
			case 18u:
				gachaUserInfo_.AddEntriesFrom(ref input, _repeated_gachaUserInfo_codec);
				break;
			case 24u:
				ScheduleEndExchangePoint = input.ReadInt32();
				break;
			case 34u:
				gachaFixedInfo_.AddEntriesFrom(ref input, _repeated_gachaFixedInfo_codec);
				break;
			case 42u:
				gachaSelectionInfo_.AddEntriesFrom(ref input, _repeated_gachaSelectionInfo_codec);
				break;
			case 50u:
				stepUpScheduleInfo_.AddEntriesFrom(ref input, _repeated_stepUpScheduleInfo_codec);
				break;
			case 58u:
				stepUpUserInfo_.AddEntriesFrom(ref input, _repeated_stepUpUserInfo_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
