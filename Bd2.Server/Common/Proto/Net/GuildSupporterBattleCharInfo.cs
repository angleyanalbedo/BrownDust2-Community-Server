using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GuildSupporterBattleCharInfo : IMessage<GuildSupporterBattleCharInfo>, IMessage, IEquatable<GuildSupporterBattleCharInfo>, IDeepCloneable<GuildSupporterBattleCharInfo>, IBufferMessage
{
	private static readonly MessageParser<GuildSupporterBattleCharInfo> _parser = new MessageParser<GuildSupporterBattleCharInfo>(() => new GuildSupporterBattleCharInfo());

	private UnknownFieldSet _unknownFields;

	public const int CharInfoFieldNumber = 1;

	private CharDBInfo charInfo_;

	public const int CostumeInfoFieldNumber = 2;

	private static readonly FieldCodec<CostumeDBInfo> _repeated_costumeInfo_codec = FieldCodec.ForMessage(18u, CostumeDBInfo.Parser);

	private readonly RepeatedField<CostumeDBInfo> costumeInfo_ = new RepeatedField<CostumeDBInfo>();

	public const int EquipInfoFieldNumber = 3;

	private static readonly FieldCodec<EquipDBInfo> _repeated_equipInfo_codec = FieldCodec.ForMessage(26u, EquipDBInfo.Parser);

	private readonly RepeatedField<EquipDBInfo> equipInfo_ = new RepeatedField<EquipDBInfo>();

	public const int AwakeInfoFieldNumber = 4;

	private CharAwakeDBInfo awakeInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildSupporterBattleCharInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GuildSupporterInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<CostumeDBInfo> CostumeInfo => costumeInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EquipDBInfo> EquipInfo => equipInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharAwakeDBInfo AwakeInfo
	{
		get
		{
			return awakeInfo_;
		}
		set
		{
			awakeInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildSupporterBattleCharInfo()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildSupporterBattleCharInfo(GuildSupporterBattleCharInfo other)
		: this()
	{
		charInfo_ = ((other.charInfo_ != null) ? other.charInfo_.Clone() : null);
		costumeInfo_ = other.costumeInfo_.Clone();
		equipInfo_ = other.equipInfo_.Clone();
		awakeInfo_ = ((other.awakeInfo_ != null) ? other.awakeInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildSupporterBattleCharInfo Clone()
	{
		return new GuildSupporterBattleCharInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GuildSupporterBattleCharInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildSupporterBattleCharInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(CharInfo, other.CharInfo) && costumeInfo_.Equals(other.costumeInfo_) && equipInfo_.Equals(other.equipInfo_) && object.Equals(AwakeInfo, other.AwakeInfo))
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
		if (charInfo_ != null)
		{
			num ^= CharInfo.GetHashCode();
		}
		num ^= costumeInfo_.GetHashCode();
		num ^= equipInfo_.GetHashCode();
		if (awakeInfo_ != null)
		{
			num ^= AwakeInfo.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (charInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(CharInfo);
		}
		costumeInfo_.WriteTo(ref output, _repeated_costumeInfo_codec);
		equipInfo_.WriteTo(ref output, _repeated_equipInfo_codec);
		if (awakeInfo_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(AwakeInfo);
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
		if (charInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CharInfo);
		}
		num += costumeInfo_.CalculateSize(_repeated_costumeInfo_codec);
		num += equipInfo_.CalculateSize(_repeated_equipInfo_codec);
		if (awakeInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AwakeInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GuildSupporterBattleCharInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.charInfo_ != null)
		{
			if (charInfo_ == null)
			{
				CharInfo = new CharDBInfo();
			}
			CharInfo.MergeFrom(other.CharInfo);
		}
		costumeInfo_.Add(other.costumeInfo_);
		equipInfo_.Add(other.equipInfo_);
		if (other.awakeInfo_ != null)
		{
			if (awakeInfo_ == null)
			{
				AwakeInfo = new CharAwakeDBInfo();
			}
			AwakeInfo.MergeFrom(other.AwakeInfo);
		}
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
			case 10u:
				if (charInfo_ == null)
				{
					CharInfo = new CharDBInfo();
				}
				input.ReadMessage(CharInfo);
				break;
			case 18u:
				costumeInfo_.AddEntriesFrom(ref input, _repeated_costumeInfo_codec);
				break;
			case 26u:
				equipInfo_.AddEntriesFrom(ref input, _repeated_equipInfo_codec);
				break;
			case 34u:
				if (awakeInfo_ == null)
				{
					AwakeInfo = new CharAwakeDBInfo();
				}
				input.ReadMessage(AwakeInfo);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
