using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EatFoodAutoResponse : IMessage<EatFoodAutoResponse>, IMessage, IEquatable<EatFoodAutoResponse>, IDeepCloneable<EatFoodAutoResponse>, IBufferMessage
{
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		public sealed class RecoveryCharInfo : IMessage<RecoveryCharInfo>, IMessage, IEquatable<RecoveryCharInfo>, IDeepCloneable<RecoveryCharInfo>, IBufferMessage
		{
			private static readonly MessageParser<RecoveryCharInfo> _parser = new MessageParser<RecoveryCharInfo>(() => new RecoveryCharInfo());

			private UnknownFieldSet _unknownFields;

			public const int CharInvenIndexFieldNumber = 1;

			private long charInvenIndex_;

			public const int HpFieldNumber = 2;

			private long hp_;

			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<RecoveryCharInfo> Parser => _parser;

			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor => EatFoodAutoResponse.Descriptor.NestedTypes[0];

			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			MessageDescriptor IMessage.Descriptor => Descriptor;

			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public long CharInvenIndex
			{
				get
				{
					return charInvenIndex_;
				}
				set
				{
					charInvenIndex_ = value;
				}
			}

			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public long Hp
			{
				get
				{
					return hp_;
				}
				set
				{
					hp_ = value;
				}
			}

			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public RecoveryCharInfo()
			{
			}

			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public RecoveryCharInfo(RecoveryCharInfo other)
				: this()
			{
				charInvenIndex_ = other.charInvenIndex_;
				hp_ = other.hp_;
				_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
			}

			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public RecoveryCharInfo Clone()
			{
				return new RecoveryCharInfo(this);
			}

			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return Equals(other as RecoveryCharInfo);
			}

			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(RecoveryCharInfo other)
			{
				if (other != null)
				{
					if (other != this)
					{
						if (CharInvenIndex == other.CharInvenIndex && Hp == other.Hp)
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
				if (CharInvenIndex != 0L)
				{
					num ^= CharInvenIndex.GetHashCode();
				}
				if (Hp != 0L)
				{
					num ^= Hp.GetHashCode();
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

			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
				output.WriteRawMessage(this);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			void IBufferMessage.InternalWriteTo(ref WriteContext output)
			{
				if (CharInvenIndex != 0L)
				{
					output.WriteRawTag(8);
					output.WriteInt64(CharInvenIndex);
				}
				if (Hp != 0L)
				{
					output.WriteRawTag(16);
					output.WriteInt64(Hp);
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
				if (CharInvenIndex != 0L)
				{
					num += 1 + CodedOutputStream.ComputeInt64Size(CharInvenIndex);
				}
				if (Hp != 0L)
				{
					num += 1 + CodedOutputStream.ComputeInt64Size(Hp);
				}
				if (_unknownFields != null)
				{
					num += _unknownFields.CalculateSize();
				}
				return num;
			}

			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(RecoveryCharInfo other)
			{
				if (other != null)
				{
					if (other.CharInvenIndex != 0L)
					{
						CharInvenIndex = other.CharInvenIndex;
					}
					if (other.Hp != 0L)
					{
						Hp = other.Hp;
					}
					_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
				}
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
					default:
						_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
						break;
					case 16u:
						Hp = input.ReadInt64();
						break;
					case 8u:
						CharInvenIndex = input.ReadInt64();
						break;
					}
				}
			}
		}
	}
	private static readonly MessageParser<EatFoodAutoResponse> _parser = new MessageParser<EatFoodAutoResponse>(() => new EatFoodAutoResponse());

	private UnknownFieldSet _unknownFields;

	public const int RecoveryCharInfoFieldNumber = 1;

	private static readonly FieldCodec<Types.RecoveryCharInfo> _repeated_recoveryCharInfo_codec = FieldCodec.ForMessage(10u, Types.RecoveryCharInfo.Parser);

	private readonly RepeatedField<Types.RecoveryCharInfo> recoveryCharInfo_ = new RepeatedField<Types.RecoveryCharInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EatFoodAutoResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => EatFoodAutoResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<Types.RecoveryCharInfo> RecoveryCharInfo => recoveryCharInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EatFoodAutoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EatFoodAutoResponse(EatFoodAutoResponse other)
		: this()
	{
		recoveryCharInfo_ = other.recoveryCharInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EatFoodAutoResponse Clone()
	{
		return new EatFoodAutoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EatFoodAutoResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(EatFoodAutoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (recoveryCharInfo_.Equals(other.recoveryCharInfo_))
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
		num ^= recoveryCharInfo_.GetHashCode();
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
		recoveryCharInfo_.WriteTo(ref output, _repeated_recoveryCharInfo_codec);
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
		num += recoveryCharInfo_.CalculateSize(_repeated_recoveryCharInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EatFoodAutoResponse other)
	{
		if (other != null)
		{
			recoveryCharInfo_.Add(other.recoveryCharInfo_);
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				recoveryCharInfo_.AddEntriesFrom(ref input, _repeated_recoveryCharInfo_codec);
			}
		}
		}
	}
