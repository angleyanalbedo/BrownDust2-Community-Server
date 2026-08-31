using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GachaBuyResponse : IMessage<GachaBuyResponse>, IMessage, IEquatable<GachaBuyResponse>, IDeepCloneable<GachaBuyResponse>, IBufferMessage
{
	private static readonly MessageParser<GachaBuyResponse> _parser = new MessageParser<GachaBuyResponse>(() => new GachaBuyResponse());

	private UnknownFieldSet _unknownFields;

	public const int RewardInfoBundleFieldNumber = 1;

	private RewardDBInfoBundle rewardInfoBundle_;

	public const int GetPointFieldNumber = 2;

	private int getPoint_;

	public const int GachaFixedInfoFieldNumber = 3;

	private static readonly FieldCodec<GachaFixedDBInfo> _repeated_gachaFixedInfo_codec = FieldCodec.ForMessage(26u, GachaFixedDBInfo.Parser);

	private readonly RepeatedField<GachaFixedDBInfo> gachaFixedInfo_ = new RepeatedField<GachaFixedDBInfo>();

	public const int SelectionApplySortIdFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_selectionApplySortId_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> selectionApplySortId_ = new RepeatedField<int>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GachaBuyResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GachaBuyResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public int GetPoint
	{
		get
		{
			return getPoint_;
		}
		set
		{
			getPoint_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GachaFixedDBInfo> GachaFixedInfo => gachaFixedInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> SelectionApplySortId => selectionApplySortId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaBuyResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaBuyResponse(GachaBuyResponse other)
		: this()
	{
		rewardInfoBundle_ = ((other.rewardInfoBundle_ != null) ? other.rewardInfoBundle_.Clone() : null);
		getPoint_ = other.getPoint_;
		gachaFixedInfo_ = other.gachaFixedInfo_.Clone();
		selectionApplySortId_ = other.selectionApplySortId_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaBuyResponse Clone()
	{
		return new GachaBuyResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GachaBuyResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GachaBuyResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(RewardInfoBundle, other.RewardInfoBundle) && GetPoint == other.GetPoint && gachaFixedInfo_.Equals(other.gachaFixedInfo_) && selectionApplySortId_.Equals(other.selectionApplySortId_))
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
		if (GetPoint != 0)
		{
			num ^= GetPoint.GetHashCode();
		}
		num ^= gachaFixedInfo_.GetHashCode();
		num ^= selectionApplySortId_.GetHashCode();
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
		if (rewardInfoBundle_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(RewardInfoBundle);
		}
		if (GetPoint != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(GetPoint);
		}
		gachaFixedInfo_.WriteTo(ref output, _repeated_gachaFixedInfo_codec);
		selectionApplySortId_.WriteTo(ref output, _repeated_selectionApplySortId_codec);
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
		if (rewardInfoBundle_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RewardInfoBundle);
		}
		if (GetPoint != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GetPoint);
		}
		num += gachaFixedInfo_.CalculateSize(_repeated_gachaFixedInfo_codec);
		num += selectionApplySortId_.CalculateSize(_repeated_selectionApplySortId_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GachaBuyResponse other)
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
		if (other.GetPoint != 0)
		{
			GetPoint = other.GetPoint;
		}
		gachaFixedInfo_.Add(other.gachaFixedInfo_);
		selectionApplySortId_.Add(other.selectionApplySortId_);
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
				if (rewardInfoBundle_ == null)
				{
					RewardInfoBundle = new RewardDBInfoBundle();
				}
				input.ReadMessage(RewardInfoBundle);
				break;
			case 16u:
				GetPoint = input.ReadInt32();
				break;
			case 26u:
				gachaFixedInfo_.AddEntriesFrom(ref input, _repeated_gachaFixedInfo_codec);
				break;
			case 32u:
			case 34u:
				selectionApplySortId_.AddEntriesFrom(ref input, _repeated_selectionApplySortId_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
