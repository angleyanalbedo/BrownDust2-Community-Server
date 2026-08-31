using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class OverwhelmResponse : IMessage<OverwhelmResponse>, IMessage, IEquatable<OverwhelmResponse>, IDeepCloneable<OverwhelmResponse>, IBufferMessage
{
	private static readonly MessageParser<OverwhelmResponse> _parser = new MessageParser<OverwhelmResponse>(() => new OverwhelmResponse());

	private UnknownFieldSet _unknownFields;

	public const int MonsterInfoFieldNumber = 1;

	private static readonly FieldCodec<MonsterDBInfo> _repeated_monsterInfo_codec = FieldCodec.ForMessage(10u, MonsterDBInfo.Parser);

	private readonly RepeatedField<MonsterDBInfo> monsterInfo_ = new RepeatedField<MonsterDBInfo>();

	public const int UpdateQuestIdFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_updateQuestId_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> updateQuestId_ = new RepeatedField<int>();

	public const int RewardBundleFieldNumber = 3;

	private RewardDBInfoBundle rewardBundle_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OverwhelmResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OverwhelmResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MonsterDBInfo> MonsterInfo => monsterInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> UpdateQuestId => updateQuestId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RewardDBInfoBundle RewardBundle
	{
		get
		{
			return rewardBundle_;
		}
		set
		{
			rewardBundle_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OverwhelmResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OverwhelmResponse(OverwhelmResponse other)
		: this()
	{
		monsterInfo_ = other.monsterInfo_.Clone();
		updateQuestId_ = other.updateQuestId_.Clone();
		rewardBundle_ = ((other.rewardBundle_ != null) ? other.rewardBundle_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OverwhelmResponse Clone()
	{
		return new OverwhelmResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OverwhelmResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OverwhelmResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (monsterInfo_.Equals(other.monsterInfo_) && updateQuestId_.Equals(other.updateQuestId_) && object.Equals(RewardBundle, other.RewardBundle))
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
		num ^= monsterInfo_.GetHashCode();
		num ^= updateQuestId_.GetHashCode();
		if (rewardBundle_ != null)
		{
			num ^= RewardBundle.GetHashCode();
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
		monsterInfo_.WriteTo(ref output, _repeated_monsterInfo_codec);
		updateQuestId_.WriteTo(ref output, _repeated_updateQuestId_codec);
		if (rewardBundle_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(RewardBundle);
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
		num += monsterInfo_.CalculateSize(_repeated_monsterInfo_codec);
		num += updateQuestId_.CalculateSize(_repeated_updateQuestId_codec);
		if (rewardBundle_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RewardBundle);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(OverwhelmResponse other)
	{
		if (other == null)
		{
			return;
		}
		monsterInfo_.Add(other.monsterInfo_);
		updateQuestId_.Add(other.updateQuestId_);
		if (other.rewardBundle_ != null)
		{
			if (rewardBundle_ == null)
			{
				RewardBundle = new RewardDBInfoBundle();
			}
			RewardBundle.MergeFrom(other.RewardBundle);
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
				monsterInfo_.AddEntriesFrom(ref input, _repeated_monsterInfo_codec);
				break;
			case 26u:
				if (rewardBundle_ == null)
				{
					RewardBundle = new RewardDBInfoBundle();
				}
				input.ReadMessage(RewardBundle);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 16u:
			case 18u:
				updateQuestId_.AddEntriesFrom(ref input, _repeated_updateQuestId_codec);
				break;
			}
		}
	}
}
