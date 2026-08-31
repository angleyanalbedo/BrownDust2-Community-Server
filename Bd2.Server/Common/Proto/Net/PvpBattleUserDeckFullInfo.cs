using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PvpBattleUserDeckFullInfo : IMessage<PvpBattleUserDeckFullInfo>, IMessage, IEquatable<PvpBattleUserDeckFullInfo>, IDeepCloneable<PvpBattleUserDeckFullInfo>, IBufferMessage
{
	private static readonly MessageParser<PvpBattleUserDeckFullInfo> _parser = new MessageParser<PvpBattleUserDeckFullInfo>(() => new PvpBattleUserDeckFullInfo());

	private UnknownFieldSet _unknownFields;

	public const int DeckInfoFieldNumber = 1;

	private static readonly FieldCodec<PvpBattleUserDeckInfo> _repeated_deckInfo_codec = FieldCodec.ForMessage(10u, PvpBattleUserDeckInfo.Parser);

	private readonly RepeatedField<PvpBattleUserDeckInfo> deckInfo_ = new RepeatedField<PvpBattleUserDeckInfo>();

	public const int CharInfoFieldNumber = 2;

	private static readonly FieldCodec<CharDBInfo> _repeated_charInfo_codec = FieldCodec.ForMessage(18u, CharDBInfo.Parser);

	private readonly RepeatedField<CharDBInfo> charInfo_ = new RepeatedField<CharDBInfo>();

	public const int CostumeInfoFieldNumber = 3;

	private static readonly FieldCodec<CostumeDBInfo> _repeated_costumeInfo_codec = FieldCodec.ForMessage(26u, CostumeDBInfo.Parser);

	private readonly RepeatedField<CostumeDBInfo> costumeInfo_ = new RepeatedField<CostumeDBInfo>();

	public const int EquipInfoFieldNumber = 4;

	private static readonly FieldCodec<EquipDBInfo> _repeated_equipInfo_codec = FieldCodec.ForMessage(34u, EquipDBInfo.Parser);

	private readonly RepeatedField<EquipDBInfo> equipInfo_ = new RepeatedField<EquipDBInfo>();

	public const int BuffStatInfoFieldNumber = 5;

	private static readonly FieldCodec<PictorialBuffStatDBInfo> _repeated_buffStatInfo_codec = FieldCodec.ForMessage(42u, PictorialBuffStatDBInfo.Parser);

	private readonly RepeatedField<PictorialBuffStatDBInfo> buffStatInfo_ = new RepeatedField<PictorialBuffStatDBInfo>();

	public const int AwakeInfoFieldNumber = 6;

	private static readonly FieldCodec<CharAwakeDBInfo> _repeated_awakeInfo_codec = FieldCodec.ForMessage(50u, CharAwakeDBInfo.Parser);

	private readonly RepeatedField<CharAwakeDBInfo> awakeInfo_ = new RepeatedField<CharAwakeDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PvpBattleUserDeckFullInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PvpBattleUserDeckFullInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PvpBattleUserDeckInfo> DeckInfo => deckInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CharDBInfo> CharInfo => charInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CostumeDBInfo> CostumeInfo => costumeInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EquipDBInfo> EquipInfo => equipInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<PictorialBuffStatDBInfo> BuffStatInfo => buffStatInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<CharAwakeDBInfo> AwakeInfo => awakeInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleUserDeckFullInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleUserDeckFullInfo(PvpBattleUserDeckFullInfo other)
		: this()
	{
		deckInfo_ = other.deckInfo_.Clone();
		charInfo_ = other.charInfo_.Clone();
		costumeInfo_ = other.costumeInfo_.Clone();
		equipInfo_ = other.equipInfo_.Clone();
		buffStatInfo_ = other.buffStatInfo_.Clone();
		awakeInfo_ = other.awakeInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleUserDeckFullInfo Clone()
	{
		return new PvpBattleUserDeckFullInfo(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as PvpBattleUserDeckFullInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PvpBattleUserDeckFullInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (deckInfo_.Equals(other.deckInfo_) && charInfo_.Equals(other.charInfo_) && costumeInfo_.Equals(other.costumeInfo_) && equipInfo_.Equals(other.equipInfo_) && buffStatInfo_.Equals(other.buffStatInfo_) && awakeInfo_.Equals(other.awakeInfo_))
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
		num ^= deckInfo_.GetHashCode();
		num ^= charInfo_.GetHashCode();
		num ^= costumeInfo_.GetHashCode();
		num ^= equipInfo_.GetHashCode();
		num ^= buffStatInfo_.GetHashCode();
		num ^= awakeInfo_.GetHashCode();
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
		deckInfo_.WriteTo(ref output, _repeated_deckInfo_codec);
		charInfo_.WriteTo(ref output, _repeated_charInfo_codec);
		costumeInfo_.WriteTo(ref output, _repeated_costumeInfo_codec);
		equipInfo_.WriteTo(ref output, _repeated_equipInfo_codec);
		buffStatInfo_.WriteTo(ref output, _repeated_buffStatInfo_codec);
		awakeInfo_.WriteTo(ref output, _repeated_awakeInfo_codec);
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
		num += deckInfo_.CalculateSize(_repeated_deckInfo_codec);
		num += charInfo_.CalculateSize(_repeated_charInfo_codec);
		num += costumeInfo_.CalculateSize(_repeated_costumeInfo_codec);
		num += equipInfo_.CalculateSize(_repeated_equipInfo_codec);
		num += buffStatInfo_.CalculateSize(_repeated_buffStatInfo_codec);
		num += awakeInfo_.CalculateSize(_repeated_awakeInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PvpBattleUserDeckFullInfo other)
	{
		if (other != null)
		{
			deckInfo_.Add(other.deckInfo_);
			charInfo_.Add(other.charInfo_);
			costumeInfo_.Add(other.costumeInfo_);
			equipInfo_.Add(other.equipInfo_);
			buffStatInfo_.Add(other.buffStatInfo_);
			awakeInfo_.Add(other.awakeInfo_);
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
			case 10u:
				deckInfo_.AddEntriesFrom(ref input, _repeated_deckInfo_codec);
				break;
			case 18u:
				charInfo_.AddEntriesFrom(ref input, _repeated_charInfo_codec);
				break;
			case 26u:
				costumeInfo_.AddEntriesFrom(ref input, _repeated_costumeInfo_codec);
				break;
			case 34u:
				equipInfo_.AddEntriesFrom(ref input, _repeated_equipInfo_codec);
				break;
			case 42u:
				buffStatInfo_.AddEntriesFrom(ref input, _repeated_buffStatInfo_codec);
				break;
			case 50u:
				awakeInfo_.AddEntriesFrom(ref input, _repeated_awakeInfo_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
