using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EatFoodAutoRequest : IMessage<EatFoodAutoRequest>, IMessage, IEquatable<EatFoodAutoRequest>, IDeepCloneable<EatFoodAutoRequest>, IBufferMessage
{
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		public sealed class FoodUseInfo : IMessage<FoodUseInfo>, IMessage, IEquatable<FoodUseInfo>, IDeepCloneable<FoodUseInfo>, IBufferMessage
		{
			private static readonly MessageParser<FoodUseInfo> _parser = new MessageParser<FoodUseInfo>(() => new FoodUseInfo());

			private UnknownFieldSet _unknownFields;

			public const int InvenIndexFieldNumber = 1;

			private long invenIndex_;

			public const int ItemInfoFieldNumber = 2;

			private static readonly FieldCodec<ItemDBInfo> _repeated_itemInfo_codec = FieldCodec.ForMessage(18u, ItemDBInfo.Parser);

			private readonly RepeatedField<ItemDBInfo> itemInfo_ = new RepeatedField<ItemDBInfo>();

			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<FoodUseInfo> Parser => _parser;

			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor => EatFoodAutoRequest.Descriptor.NestedTypes[0];

			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			MessageDescriptor IMessage.Descriptor => Descriptor;

			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long InvenIndex
			{
				get
				{
					return invenIndex_;
				}
				set
				{
					invenIndex_ = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public RepeatedField<ItemDBInfo> ItemInfo => itemInfo_;

			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public FoodUseInfo()
			{
			}

			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public FoodUseInfo(FoodUseInfo other)
				: this()
			{
				invenIndex_ = other.invenIndex_;
				itemInfo_ = other.itemInfo_.Clone();
				_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
			}

			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public FoodUseInfo Clone()
			{
				return new FoodUseInfo(this);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return Equals(other as FoodUseInfo);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(FoodUseInfo other)
			{
				if (other != null)
				{
					if (other != this)
					{
						if (InvenIndex == other.InvenIndex && itemInfo_.Equals(other.itemInfo_))
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
				if (InvenIndex != 0L)
				{
					num ^= InvenIndex.GetHashCode();
				}
				num ^= itemInfo_.GetHashCode();
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

			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
				output.WriteRawMessage(this);
			}

			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			void IBufferMessage.InternalWriteTo(ref WriteContext output)
			{
				if (InvenIndex != 0L)
				{
					output.WriteRawTag(8);
					output.WriteInt64(InvenIndex);
				}
				itemInfo_.WriteTo(ref output, _repeated_itemInfo_codec);
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
				if (InvenIndex != 0L)
				{
					num += 1 + CodedOutputStream.ComputeInt64Size(InvenIndex);
				}
				num += itemInfo_.CalculateSize(_repeated_itemInfo_codec);
				if (_unknownFields != null)
				{
					num += _unknownFields.CalculateSize();
				}
				return num;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(FoodUseInfo other)
			{
				if (other != null)
				{
					if (other.InvenIndex != 0L)
					{
						InvenIndex = other.InvenIndex;
					}
					itemInfo_.Add(other.itemInfo_);
					_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
				}
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
					default:
						_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
						break;
					case 18u:
						itemInfo_.AddEntriesFrom(ref input, _repeated_itemInfo_codec);
						break;
					case 8u:
						InvenIndex = input.ReadInt64();
						break;
					}
				}
			}
		}
	}
	private static readonly MessageParser<EatFoodAutoRequest> _parser = new MessageParser<EatFoodAutoRequest>(() => new EatFoodAutoRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int EatFoodInfoFieldNumber = 2;

	private static readonly FieldCodec<Types.FoodUseInfo> _repeated_eatFoodInfo_codec = FieldCodec.ForMessage(18u, Types.FoodUseInfo.Parser);

	private readonly RepeatedField<Types.FoodUseInfo> eatFoodInfo_ = new RepeatedField<Types.FoodUseInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<EatFoodAutoRequest> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => EatFoodAutoRequestReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Seq
	{
		get
		{
			return seq_;
		}
		set
		{
			seq_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<Types.FoodUseInfo> EatFoodInfo => eatFoodInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EatFoodAutoRequest()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EatFoodAutoRequest(EatFoodAutoRequest other)
		: this()
	{
		seq_ = other.seq_;
		eatFoodInfo_ = other.eatFoodInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EatFoodAutoRequest Clone()
	{
		return new EatFoodAutoRequest(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EatFoodAutoRequest);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EatFoodAutoRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && eatFoodInfo_.Equals(other.eatFoodInfo_))
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
		if (Seq != 0)
		{
			num ^= Seq.GetHashCode();
		}
		num ^= eatFoodInfo_.GetHashCode();
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
		if (Seq != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Seq);
		}
		eatFoodInfo_.WriteTo(ref output, _repeated_eatFoodInfo_codec);
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
		if (Seq != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Seq);
		}
		num += eatFoodInfo_.CalculateSize(_repeated_eatFoodInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EatFoodAutoRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			eatFoodInfo_.Add(other.eatFoodInfo_);
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 18u:
				eatFoodInfo_.AddEntriesFrom(ref input, _repeated_eatFoodInfo_codec);
				break;
			case 8u:
				Seq = input.ReadInt32();
				break;
			}
		}
		}
	}
