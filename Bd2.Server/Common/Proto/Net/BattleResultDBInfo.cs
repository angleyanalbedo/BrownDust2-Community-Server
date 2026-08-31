using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class BattleResultDBInfo : IMessage<BattleResultDBInfo>, IMessage, IEquatable<BattleResultDBInfo>, IDeepCloneable<BattleResultDBInfo>, IBufferMessage
{
	private static readonly MessageParser<BattleResultDBInfo> _parser = new MessageParser<BattleResultDBInfo>(() => new BattleResultDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int BattleResultFieldNumber = 1;

	private int battleResult_;

	public const int RedCharInfoFieldNumber = 2;

	private static readonly FieldCodec<BattleCharDBInfo> _repeated_redCharInfo_codec = FieldCodec.ForMessage(18u, BattleCharDBInfo.Parser);

	private readonly RepeatedField<BattleCharDBInfo> redCharInfo_ = new RepeatedField<BattleCharDBInfo>();

	public const int BlueCharInfoFieldNumber = 3;

	private static readonly FieldCodec<BattleCharDBInfo> _repeated_blueCharInfo_codec = FieldCodec.ForMessage(26u, BattleCharDBInfo.Parser);

	private readonly RepeatedField<BattleCharDBInfo> blueCharInfo_ = new RepeatedField<BattleCharDBInfo>();

	public const int GridItemFieldNumber = 4;

	private static readonly FieldCodec<BattleGridTypeItemDBInfo> _repeated_gridItem_codec = FieldCodec.ForMessage(34u, BattleGridTypeItemDBInfo.Parser);

	private readonly RepeatedField<BattleGridTypeItemDBInfo> gridItem_ = new RepeatedField<BattleGridTypeItemDBInfo>();

	public const int BattleStatisticsInfoFieldNumber = 5;

	private BattleStatisticsDBInfo battleStatisticsInfo_;

	public const int GolemInfoFieldNumber = 6;

	private BattleGolemDBInfo golemInfo_;

	public const int RedDeckOutCharInfoFieldNumber = 7;

	private static readonly FieldCodec<BattleCharDBInfo> _repeated_redDeckOutCharInfo_codec = FieldCodec.ForMessage(58u, BattleCharDBInfo.Parser);

	private readonly RepeatedField<BattleCharDBInfo> redDeckOutCharInfo_ = new RepeatedField<BattleCharDBInfo>();

	public const int BlueDeckOutCharInfoFieldNumber = 8;

	private static readonly FieldCodec<BattleCharDBInfo> _repeated_blueDeckOutCharInfo_codec = FieldCodec.ForMessage(66u, BattleCharDBInfo.Parser);

	private readonly RepeatedField<BattleCharDBInfo> blueDeckOutCharInfo_ = new RepeatedField<BattleCharDBInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<BattleResultDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BattleResultDBInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BattleResult
	{
		get
		{
			return battleResult_;
		}
		set
		{
			battleResult_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BattleCharDBInfo> RedCharInfo => redCharInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<BattleCharDBInfo> BlueCharInfo => blueCharInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BattleGridTypeItemDBInfo> GridItem => gridItem_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleStatisticsDBInfo BattleStatisticsInfo
	{
		get
		{
			return battleStatisticsInfo_;
		}
		set
		{
			battleStatisticsInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BattleGolemDBInfo GolemInfo
	{
		get
		{
			return golemInfo_;
		}
		set
		{
			golemInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BattleCharDBInfo> RedDeckOutCharInfo => redDeckOutCharInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<BattleCharDBInfo> BlueDeckOutCharInfo => blueDeckOutCharInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BattleResultDBInfo()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BattleResultDBInfo(BattleResultDBInfo other)
		: this()
	{
		battleResult_ = other.battleResult_;
		redCharInfo_ = other.redCharInfo_.Clone();
		blueCharInfo_ = other.blueCharInfo_.Clone();
		gridItem_ = other.gridItem_.Clone();
		battleStatisticsInfo_ = ((other.battleStatisticsInfo_ != null) ? other.battleStatisticsInfo_.Clone() : null);
		golemInfo_ = ((other.golemInfo_ != null) ? other.golemInfo_.Clone() : null);
		redDeckOutCharInfo_ = other.redDeckOutCharInfo_.Clone();
		blueDeckOutCharInfo_ = other.blueDeckOutCharInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BattleResultDBInfo Clone()
	{
		return new BattleResultDBInfo(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as BattleResultDBInfo);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(BattleResultDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (BattleResult == other.BattleResult && redCharInfo_.Equals(other.redCharInfo_) && blueCharInfo_.Equals(other.blueCharInfo_) && gridItem_.Equals(other.gridItem_) && object.Equals(BattleStatisticsInfo, other.BattleStatisticsInfo) && object.Equals(GolemInfo, other.GolemInfo) && redDeckOutCharInfo_.Equals(other.redDeckOutCharInfo_) && blueDeckOutCharInfo_.Equals(other.blueDeckOutCharInfo_))
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
		if (BattleResult != 0)
		{
			num ^= BattleResult.GetHashCode();
		}
		num ^= redCharInfo_.GetHashCode();
		num ^= blueCharInfo_.GetHashCode();
		num ^= gridItem_.GetHashCode();
		if (battleStatisticsInfo_ != null)
		{
			num ^= BattleStatisticsInfo.GetHashCode();
		}
		if (golemInfo_ != null)
		{
			num ^= GolemInfo.GetHashCode();
		}
		num ^= redDeckOutCharInfo_.GetHashCode();
		num ^= blueDeckOutCharInfo_.GetHashCode();
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
		if (BattleResult != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BattleResult);
		}
		redCharInfo_.WriteTo(ref output, _repeated_redCharInfo_codec);
		blueCharInfo_.WriteTo(ref output, _repeated_blueCharInfo_codec);
		gridItem_.WriteTo(ref output, _repeated_gridItem_codec);
		if (battleStatisticsInfo_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(BattleStatisticsInfo);
		}
		if (golemInfo_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(GolemInfo);
		}
		redDeckOutCharInfo_.WriteTo(ref output, _repeated_redDeckOutCharInfo_codec);
		blueDeckOutCharInfo_.WriteTo(ref output, _repeated_blueDeckOutCharInfo_codec);
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
		if (BattleResult != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleResult);
		}
		num += redCharInfo_.CalculateSize(_repeated_redCharInfo_codec);
		num += blueCharInfo_.CalculateSize(_repeated_blueCharInfo_codec);
		num += gridItem_.CalculateSize(_repeated_gridItem_codec);
		if (battleStatisticsInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BattleStatisticsInfo);
		}
		if (golemInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GolemInfo);
		}
		num += redDeckOutCharInfo_.CalculateSize(_repeated_redDeckOutCharInfo_codec);
		num += blueDeckOutCharInfo_.CalculateSize(_repeated_blueDeckOutCharInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BattleResultDBInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.BattleResult != 0)
		{
			BattleResult = other.BattleResult;
		}
		redCharInfo_.Add(other.redCharInfo_);
		blueCharInfo_.Add(other.blueCharInfo_);
		gridItem_.Add(other.gridItem_);
		if (other.battleStatisticsInfo_ != null)
		{
			if (battleStatisticsInfo_ == null)
			{
				BattleStatisticsInfo = new BattleStatisticsDBInfo();
			}
			BattleStatisticsInfo.MergeFrom(other.BattleStatisticsInfo);
		}
		if (other.golemInfo_ != null)
		{
			if (golemInfo_ == null)
			{
				GolemInfo = new BattleGolemDBInfo();
			}
			GolemInfo.MergeFrom(other.GolemInfo);
		}
		redDeckOutCharInfo_.Add(other.redDeckOutCharInfo_);
		blueDeckOutCharInfo_.Add(other.blueDeckOutCharInfo_);
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 8u:
				BattleResult = input.ReadInt32();
				break;
			case 18u:
				redCharInfo_.AddEntriesFrom(ref input, _repeated_redCharInfo_codec);
				break;
			case 26u:
				blueCharInfo_.AddEntriesFrom(ref input, _repeated_blueCharInfo_codec);
				break;
			case 34u:
				gridItem_.AddEntriesFrom(ref input, _repeated_gridItem_codec);
				break;
			case 42u:
				if (battleStatisticsInfo_ == null)
				{
					BattleStatisticsInfo = new BattleStatisticsDBInfo();
				}
				input.ReadMessage(BattleStatisticsInfo);
				break;
			case 50u:
				if (golemInfo_ == null)
				{
					GolemInfo = new BattleGolemDBInfo();
				}
				input.ReadMessage(GolemInfo);
				break;
			case 58u:
				redDeckOutCharInfo_.AddEntriesFrom(ref input, _repeated_redDeckOutCharInfo_codec);
				break;
			case 66u:
				blueDeckOutCharInfo_.AddEntriesFrom(ref input, _repeated_blueDeckOutCharInfo_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
