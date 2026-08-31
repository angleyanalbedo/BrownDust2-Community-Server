using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class FieldObjectRewardResponse : IMessage<FieldObjectRewardResponse>, IMessage, IEquatable<FieldObjectRewardResponse>, IDeepCloneable<FieldObjectRewardResponse>, IBufferMessage
{
	private static readonly MessageParser<FieldObjectRewardResponse> _parser = new MessageParser<FieldObjectRewardResponse>(() => new FieldObjectRewardResponse());

	private UnknownFieldSet _unknownFields;

	public const int RewardInfoBundleFieldNumber = 1;

	private RewardDBInfoBundle rewardInfoBundle_;

	public const int FieldBuffInfoFieldNumber = 2;

	private static readonly FieldCodec<FieldBuffDBInfo> _repeated_fieldBuffInfo_codec = FieldCodec.ForMessage(18u, FieldBuffDBInfo.Parser);

	private readonly RepeatedField<FieldBuffDBInfo> fieldBuffInfo_ = new RepeatedField<FieldBuffDBInfo>();

	public const int CharInfoFieldNumber = 3;

	private static readonly FieldCodec<CharDBInfo> _repeated_charInfo_codec = FieldCodec.ForMessage(26u, CharDBInfo.Parser);

	private readonly RepeatedField<CharDBInfo> charInfo_ = new RepeatedField<CharDBInfo>();

	public const int MonsterInfoFieldNumber = 4;

	private MonsterDBInfo monsterInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FieldObjectRewardResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FieldObjectRewardResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RewardDBInfoBundle RewardInfoBundle
	{
		get
		{
			return rewardInfoBundle_;
		}
		set
		{
			rewardInfoBundle_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FieldBuffDBInfo> FieldBuffInfo => fieldBuffInfo_;

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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FieldObjectRewardResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FieldObjectRewardResponse(FieldObjectRewardResponse other)
		: this()
	{
		rewardInfoBundle_ = ((other.rewardInfoBundle_ != null) ? other.rewardInfoBundle_.Clone() : null);
		fieldBuffInfo_ = other.fieldBuffInfo_.Clone();
		charInfo_ = other.charInfo_.Clone();
		monsterInfo_ = ((other.monsterInfo_ != null) ? other.monsterInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FieldObjectRewardResponse Clone()
	{
		return new FieldObjectRewardResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FieldObjectRewardResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FieldObjectRewardResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(RewardInfoBundle, other.RewardInfoBundle) && fieldBuffInfo_.Equals(other.fieldBuffInfo_) && charInfo_.Equals(other.charInfo_) && object.Equals(MonsterInfo, other.MonsterInfo))
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
		if (rewardInfoBundle_ != null)
		{
			num ^= RewardInfoBundle.GetHashCode();
		}
		num ^= fieldBuffInfo_.GetHashCode();
		num ^= charInfo_.GetHashCode();
		if (monsterInfo_ != null)
		{
			num ^= MonsterInfo.GetHashCode();
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
		if (rewardInfoBundle_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(RewardInfoBundle);
		}
		fieldBuffInfo_.WriteTo(ref output, _repeated_fieldBuffInfo_codec);
		charInfo_.WriteTo(ref output, _repeated_charInfo_codec);
		if (monsterInfo_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(MonsterInfo);
		}
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
		if (rewardInfoBundle_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RewardInfoBundle);
		}
		num += fieldBuffInfo_.CalculateSize(_repeated_fieldBuffInfo_codec);
		num += charInfo_.CalculateSize(_repeated_charInfo_codec);
		if (monsterInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MonsterInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(FieldObjectRewardResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.rewardInfoBundle_ != null)
		{
			if (rewardInfoBundle_ == null)
			{
				RewardInfoBundle = new RewardDBInfoBundle();
			}
			RewardInfoBundle.MergeFrom(other.RewardInfoBundle);
		}
		fieldBuffInfo_.Add(other.fieldBuffInfo_);
		charInfo_.Add(other.charInfo_);
		if (other.monsterInfo_ != null)
		{
			if (monsterInfo_ == null)
			{
				MonsterInfo = new MonsterDBInfo();
			}
			MonsterInfo.MergeFrom(other.MonsterInfo);
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
				if (rewardInfoBundle_ == null)
				{
					RewardInfoBundle = new RewardDBInfoBundle();
				}
				input.ReadMessage(RewardInfoBundle);
				break;
			case 18u:
				fieldBuffInfo_.AddEntriesFrom(ref input, _repeated_fieldBuffInfo_codec);
				break;
			case 26u:
				charInfo_.AddEntriesFrom(ref input, _repeated_charInfo_codec);
				break;
			case 34u:
				if (monsterInfo_ == null)
				{
					MonsterInfo = new MonsterDBInfo();
				}
				input.ReadMessage(MonsterInfo);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
