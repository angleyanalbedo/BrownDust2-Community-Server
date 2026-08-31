using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class FieldMonsterEventResponse : IMessage<FieldMonsterEventResponse>, IMessage, IEquatable<FieldMonsterEventResponse>, IDeepCloneable<FieldMonsterEventResponse>, IBufferMessage
{
	private static readonly MessageParser<FieldMonsterEventResponse> _parser = new MessageParser<FieldMonsterEventResponse>(() => new FieldMonsterEventResponse());

	private UnknownFieldSet _unknownFields;

	public const int CharInfoFieldNumber = 1;

	private static readonly FieldCodec<CharDBInfo> _repeated_charInfo_codec = FieldCodec.ForMessage(10u, CharDBInfo.Parser);

	private readonly RepeatedField<CharDBInfo> charInfo_ = new RepeatedField<CharDBInfo>();

	public const int MonsterInfoFieldNumber = 2;

	private MonsterDBInfo monsterInfo_;

	public const int ItemInfoFieldNumber = 3;

	private static readonly FieldCodec<ItemDBInfo> _repeated_itemInfo_codec = FieldCodec.ForMessage(26u, ItemDBInfo.Parser);

	private readonly RepeatedField<ItemDBInfo> itemInfo_ = new RepeatedField<ItemDBInfo>();

	public const int EquipInfoFieldNumber = 4;

	private static readonly FieldCodec<EquipDBInfo> _repeated_equipInfo_codec = FieldCodec.ForMessage(34u, EquipDBInfo.Parser);

	private readonly RepeatedField<EquipDBInfo> equipInfo_ = new RepeatedField<EquipDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FieldMonsterEventResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => FieldMonsterEventResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CharDBInfo> CharInfo => charInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MonsterDBInfo MonsterInfo
	{
		get
		{
			return monsterInfo_;
		}
		set
		{
			monsterInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ItemDBInfo> ItemInfo => itemInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<EquipDBInfo> EquipInfo => equipInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FieldMonsterEventResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FieldMonsterEventResponse(FieldMonsterEventResponse other)
		: this()
	{
		charInfo_ = other.charInfo_.Clone();
		monsterInfo_ = ((other.monsterInfo_ != null) ? other.monsterInfo_.Clone() : null);
		itemInfo_ = other.itemInfo_.Clone();
		equipInfo_ = other.equipInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FieldMonsterEventResponse Clone()
	{
		return new FieldMonsterEventResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FieldMonsterEventResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FieldMonsterEventResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (charInfo_.Equals(other.charInfo_) && object.Equals(MonsterInfo, other.MonsterInfo) && itemInfo_.Equals(other.itemInfo_) && equipInfo_.Equals(other.equipInfo_))
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
		num ^= charInfo_.GetHashCode();
		if (monsterInfo_ != null)
		{
			num ^= MonsterInfo.GetHashCode();
		}
		num ^= itemInfo_.GetHashCode();
		num ^= equipInfo_.GetHashCode();
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
		charInfo_.WriteTo(ref output, _repeated_charInfo_codec);
		if (monsterInfo_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(MonsterInfo);
		}
		itemInfo_.WriteTo(ref output, _repeated_itemInfo_codec);
		equipInfo_.WriteTo(ref output, _repeated_equipInfo_codec);
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
		num += charInfo_.CalculateSize(_repeated_charInfo_codec);
		if (monsterInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MonsterInfo);
		}
		num += itemInfo_.CalculateSize(_repeated_itemInfo_codec);
		num += equipInfo_.CalculateSize(_repeated_equipInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FieldMonsterEventResponse other)
	{
		if (other == null)
		{
			return;
		}
		charInfo_.Add(other.charInfo_);
		if (other.monsterInfo_ != null)
		{
			if (monsterInfo_ == null)
			{
				MonsterInfo = new MonsterDBInfo();
			}
			MonsterInfo.MergeFrom(other.MonsterInfo);
		}
		itemInfo_.Add(other.itemInfo_);
		equipInfo_.Add(other.equipInfo_);
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				charInfo_.AddEntriesFrom(ref input, _repeated_charInfo_codec);
				break;
			case 18u:
				if (monsterInfo_ == null)
				{
					MonsterInfo = new MonsterDBInfo();
				}
				input.ReadMessage(MonsterInfo);
				break;
			case 26u:
				itemInfo_.AddEntriesFrom(ref input, _repeated_itemInfo_codec);
				break;
			case 34u:
				equipInfo_.AddEntriesFrom(ref input, _repeated_equipInfo_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
