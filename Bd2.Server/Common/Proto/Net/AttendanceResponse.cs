using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class AttendanceResponse : IMessage<AttendanceResponse>, IMessage, IEquatable<AttendanceResponse>, IDeepCloneable<AttendanceResponse>, IBufferMessage
{
	private static readonly MessageParser<AttendanceResponse> _parser = new MessageParser<AttendanceResponse>(() => new AttendanceResponse());

	private UnknownFieldSet _unknownFields;

	public const int AttendanceAlwaysInfoFieldNumber = 1;

	private static readonly FieldCodec<AttendanceAlwaysInfo> _repeated_attendanceAlwaysInfo_codec = FieldCodec.ForMessage(10u, Bd2.Server.Common.Proto.Net.AttendanceAlwaysInfo.Parser);

	private readonly RepeatedField<AttendanceAlwaysInfo> attendanceAlwaysInfo_ = new RepeatedField<AttendanceAlwaysInfo>();

	public const int AttendanceLimitInfoFieldNumber = 2;

	private static readonly FieldCodec<AttendanceLimitGroup> _repeated_attendanceLimitInfo_codec = FieldCodec.ForMessage(18u, AttendanceLimitGroup.Parser);

	private readonly RepeatedField<AttendanceLimitGroup> attendanceLimitInfo_ = new RepeatedField<AttendanceLimitGroup>();

	public const int StandardAttendanceInfoFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_standardAttendanceInfo_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> standardAttendanceInfo_ = new RepeatedField<int>();

	public const int PremiumAttendanceInfoFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_premiumAttendanceInfo_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> premiumAttendanceInfo_ = new RepeatedField<int>();

	public const int Monthly1AttendanceInfoFieldNumber = 5;

	private static readonly FieldCodec<int> _repeated_monthly1AttendanceInfo_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> monthly1AttendanceInfo_ = new RepeatedField<int>();

	public const int Monthly2AttendanceInfoFieldNumber = 6;

	private static readonly FieldCodec<int> _repeated_monthly2AttendanceInfo_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> monthly2AttendanceInfo_ = new RepeatedField<int>();

	public const int SubscribeAttendanceInfoFieldNumber = 7;

	private static readonly FieldCodec<SubscribeAttendanceInfo> _repeated_subscribeAttendanceInfo_codec = FieldCodec.ForMessage(58u, Bd2.Server.Common.Proto.Net.SubscribeAttendanceInfo.Parser);

	private readonly RepeatedField<SubscribeAttendanceInfo> subscribeAttendanceInfo_ = new RepeatedField<SubscribeAttendanceInfo>();

	public const int AttendancePackageInfoFieldNumber = 8;

	private static readonly FieldCodec<AttendancePackageInfo> _repeated_attendancePackageInfo_codec = FieldCodec.ForMessage(66u, Bd2.Server.Common.Proto.Net.AttendancePackageInfo.Parser);

	private readonly RepeatedField<AttendancePackageInfo> attendancePackageInfo_ = new RepeatedField<AttendancePackageInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AttendanceResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => AttendanceResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<AttendanceAlwaysInfo> AttendanceAlwaysInfo => attendanceAlwaysInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AttendanceLimitGroup> AttendanceLimitInfo => attendanceLimitInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> StandardAttendanceInfo => standardAttendanceInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> PremiumAttendanceInfo => premiumAttendanceInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> Monthly1AttendanceInfo => monthly1AttendanceInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> Monthly2AttendanceInfo => monthly2AttendanceInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<SubscribeAttendanceInfo> SubscribeAttendanceInfo => subscribeAttendanceInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<AttendancePackageInfo> AttendancePackageInfo => attendancePackageInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AttendanceResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AttendanceResponse(AttendanceResponse other)
		: this()
	{
		attendanceAlwaysInfo_ = other.attendanceAlwaysInfo_.Clone();
		attendanceLimitInfo_ = other.attendanceLimitInfo_.Clone();
		standardAttendanceInfo_ = other.standardAttendanceInfo_.Clone();
		premiumAttendanceInfo_ = other.premiumAttendanceInfo_.Clone();
		monthly1AttendanceInfo_ = other.monthly1AttendanceInfo_.Clone();
		monthly2AttendanceInfo_ = other.monthly2AttendanceInfo_.Clone();
		subscribeAttendanceInfo_ = other.subscribeAttendanceInfo_.Clone();
		attendancePackageInfo_ = other.attendancePackageInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AttendanceResponse Clone()
	{
		return new AttendanceResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AttendanceResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AttendanceResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (attendanceAlwaysInfo_.Equals(other.attendanceAlwaysInfo_) && attendanceLimitInfo_.Equals(other.attendanceLimitInfo_) && standardAttendanceInfo_.Equals(other.standardAttendanceInfo_) && premiumAttendanceInfo_.Equals(other.premiumAttendanceInfo_) && monthly1AttendanceInfo_.Equals(other.monthly1AttendanceInfo_) && monthly2AttendanceInfo_.Equals(other.monthly2AttendanceInfo_) && subscribeAttendanceInfo_.Equals(other.subscribeAttendanceInfo_) && attendancePackageInfo_.Equals(other.attendancePackageInfo_))
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
		num ^= attendanceAlwaysInfo_.GetHashCode();
		num ^= attendanceLimitInfo_.GetHashCode();
		num ^= standardAttendanceInfo_.GetHashCode();
		num ^= premiumAttendanceInfo_.GetHashCode();
		num ^= monthly1AttendanceInfo_.GetHashCode();
		num ^= monthly2AttendanceInfo_.GetHashCode();
		num ^= subscribeAttendanceInfo_.GetHashCode();
		num ^= attendancePackageInfo_.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		attendanceAlwaysInfo_.WriteTo(ref output, _repeated_attendanceAlwaysInfo_codec);
		attendanceLimitInfo_.WriteTo(ref output, _repeated_attendanceLimitInfo_codec);
		standardAttendanceInfo_.WriteTo(ref output, _repeated_standardAttendanceInfo_codec);
		premiumAttendanceInfo_.WriteTo(ref output, _repeated_premiumAttendanceInfo_codec);
		monthly1AttendanceInfo_.WriteTo(ref output, _repeated_monthly1AttendanceInfo_codec);
		monthly2AttendanceInfo_.WriteTo(ref output, _repeated_monthly2AttendanceInfo_codec);
		subscribeAttendanceInfo_.WriteTo(ref output, _repeated_subscribeAttendanceInfo_codec);
		attendancePackageInfo_.WriteTo(ref output, _repeated_attendancePackageInfo_codec);
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
		num += attendanceAlwaysInfo_.CalculateSize(_repeated_attendanceAlwaysInfo_codec);
		num += attendanceLimitInfo_.CalculateSize(_repeated_attendanceLimitInfo_codec);
		num += standardAttendanceInfo_.CalculateSize(_repeated_standardAttendanceInfo_codec);
		num += premiumAttendanceInfo_.CalculateSize(_repeated_premiumAttendanceInfo_codec);
		num += monthly1AttendanceInfo_.CalculateSize(_repeated_monthly1AttendanceInfo_codec);
		num += monthly2AttendanceInfo_.CalculateSize(_repeated_monthly2AttendanceInfo_codec);
		num += subscribeAttendanceInfo_.CalculateSize(_repeated_subscribeAttendanceInfo_codec);
		num += attendancePackageInfo_.CalculateSize(_repeated_attendancePackageInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AttendanceResponse other)
	{
		if (other != null)
		{
			attendanceAlwaysInfo_.Add(other.attendanceAlwaysInfo_);
			attendanceLimitInfo_.Add(other.attendanceLimitInfo_);
			standardAttendanceInfo_.Add(other.standardAttendanceInfo_);
			premiumAttendanceInfo_.Add(other.premiumAttendanceInfo_);
			monthly1AttendanceInfo_.Add(other.monthly1AttendanceInfo_);
			monthly2AttendanceInfo_.Add(other.monthly2AttendanceInfo_);
			subscribeAttendanceInfo_.Add(other.subscribeAttendanceInfo_);
			attendancePackageInfo_.Add(other.attendancePackageInfo_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
				attendanceAlwaysInfo_.AddEntriesFrom(ref input, _repeated_attendanceAlwaysInfo_codec);
				break;
			case 18u:
				attendanceLimitInfo_.AddEntriesFrom(ref input, _repeated_attendanceLimitInfo_codec);
				break;
			case 32u:
			case 34u:
				premiumAttendanceInfo_.AddEntriesFrom(ref input, _repeated_premiumAttendanceInfo_codec);
				break;
			case 24u:
			case 26u:
				standardAttendanceInfo_.AddEntriesFrom(ref input, _repeated_standardAttendanceInfo_codec);
				break;
			case 40u:
			case 42u:
				monthly1AttendanceInfo_.AddEntriesFrom(ref input, _repeated_monthly1AttendanceInfo_codec);
				break;
			case 58u:
				subscribeAttendanceInfo_.AddEntriesFrom(ref input, _repeated_subscribeAttendanceInfo_codec);
				break;
			case 66u:
				attendancePackageInfo_.AddEntriesFrom(ref input, _repeated_attendancePackageInfo_codec);
				break;
			case 48u:
			case 50u:
				monthly2AttendanceInfo_.AddEntriesFrom(ref input, _repeated_monthly2AttendanceInfo_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
