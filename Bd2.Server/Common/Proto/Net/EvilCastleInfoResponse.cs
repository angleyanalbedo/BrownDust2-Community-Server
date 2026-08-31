using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EvilCastleInfoResponse : IMessage<EvilCastleInfoResponse>, IMessage, IEquatable<EvilCastleInfoResponse>, IDeepCloneable<EvilCastleInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<EvilCastleInfoResponse> _parser = new MessageParser<EvilCastleInfoResponse>(() => new EvilCastleInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int EvilCastleInfoFieldNumber = 1;

	private static readonly FieldCodec<EvilCastleDBInfo> _repeated_evilCastleInfo_codec = FieldCodec.ForMessage(10u, EvilCastleDBInfo.Parser);

	private readonly RepeatedField<EvilCastleDBInfo> evilCastleInfo_ = new RepeatedField<EvilCastleDBInfo>();

	public const int EvilCastleTotalInfoFieldNumber = 2;

	private EvilCastleTotalDBInfo evilCastleTotalInfo_;

	public const int SeasonFieldNumber = 3;

	private int season_;

	public const int RegularSeasonFieldNumber = 4;

	private int regularSeason_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<EvilCastleInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EvilCastleInfoResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EvilCastleDBInfo> EvilCastleInfo => evilCastleInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleTotalDBInfo EvilCastleTotalInfo
	{
		get
		{
			return evilCastleTotalInfo_;
		}
		set
		{
			evilCastleTotalInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Season
	{
		get
		{
			return season_;
		}
		set
		{
			season_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RegularSeason
	{
		get
		{
			return regularSeason_;
		}
		set
		{
			regularSeason_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleInfoResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleInfoResponse(EvilCastleInfoResponse other)
		: this()
	{
		evilCastleInfo_ = other.evilCastleInfo_.Clone();
		evilCastleTotalInfo_ = ((other.evilCastleTotalInfo_ != null) ? other.evilCastleTotalInfo_.Clone() : null);
		season_ = other.season_;
		regularSeason_ = other.regularSeason_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleInfoResponse Clone()
	{
		return new EvilCastleInfoResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as EvilCastleInfoResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(EvilCastleInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (evilCastleInfo_.Equals(other.evilCastleInfo_) && object.Equals(EvilCastleTotalInfo, other.EvilCastleTotalInfo) && Season == other.Season && RegularSeason == other.RegularSeason)
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
		num ^= evilCastleInfo_.GetHashCode();
		if (evilCastleTotalInfo_ != null)
		{
			num ^= EvilCastleTotalInfo.GetHashCode();
		}
		if (Season != 0)
		{
			num ^= Season.GetHashCode();
		}
		if (RegularSeason != 0)
		{
			num ^= RegularSeason.GetHashCode();
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
		evilCastleInfo_.WriteTo(ref output, _repeated_evilCastleInfo_codec);
		if (evilCastleTotalInfo_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(EvilCastleTotalInfo);
		}
		if (Season != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Season);
		}
		if (RegularSeason != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(RegularSeason);
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
		num += evilCastleInfo_.CalculateSize(_repeated_evilCastleInfo_codec);
		if (evilCastleTotalInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EvilCastleTotalInfo);
		}
		if (Season != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Season);
		}
		if (RegularSeason != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RegularSeason);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EvilCastleInfoResponse other)
	{
		if (other == null)
		{
			return;
		}
		evilCastleInfo_.Add(other.evilCastleInfo_);
		if (other.evilCastleTotalInfo_ != null)
		{
			if (evilCastleTotalInfo_ == null)
			{
				EvilCastleTotalInfo = new EvilCastleTotalDBInfo();
			}
			EvilCastleTotalInfo.MergeFrom(other.EvilCastleTotalInfo);
		}
		if (other.Season != 0)
		{
			Season = other.Season;
		}
		if (other.RegularSeason != 0)
		{
			RegularSeason = other.RegularSeason;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 10u:
				evilCastleInfo_.AddEntriesFrom(ref input, _repeated_evilCastleInfo_codec);
				break;
			case 18u:
				if (evilCastleTotalInfo_ == null)
				{
					EvilCastleTotalInfo = new EvilCastleTotalDBInfo();
				}
				input.ReadMessage(EvilCastleTotalInfo);
				break;
			case 24u:
				Season = input.ReadInt32();
				break;
			case 32u:
				RegularSeason = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
