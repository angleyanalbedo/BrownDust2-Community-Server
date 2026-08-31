using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MiniGameBingoLineInfo : IMessage<MiniGameBingoLineInfo>, IMessage, IEquatable<MiniGameBingoLineInfo>, IDeepCloneable<MiniGameBingoLineInfo>, IBufferMessage
{
	private static readonly MessageParser<MiniGameBingoLineInfo> _parser = new MessageParser<MiniGameBingoLineInfo>(() => new MiniGameBingoLineInfo());

	private UnknownFieldSet _unknownFields;

	public const int LineTypeFieldNumber = 1;

	private Define_MiniGameBingoLineType lineType_;

	public const int LineIndexFieldNumber = 2;

	private int lineIndex_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MiniGameBingoLineInfo> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MiniGameBingoDBInfoReflection.Descriptor.MessageTypes[1];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Define_MiniGameBingoLineType LineType
	{
		get
		{
			return lineType_;
		}
		set
		{
			lineType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int LineIndex
	{
		get
		{
			return lineIndex_;
		}
		set
		{
			lineIndex_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameBingoLineInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameBingoLineInfo(MiniGameBingoLineInfo other)
		: this()
	{
		lineType_ = other.lineType_;
		lineIndex_ = other.lineIndex_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameBingoLineInfo Clone()
	{
		return new MiniGameBingoLineInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MiniGameBingoLineInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MiniGameBingoLineInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (LineType == other.LineType && LineIndex == other.LineIndex)
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
		if (LineType != Define_MiniGameBingoLineType.BingoLineDiagonal)
		{
			num ^= LineType.GetHashCode();
		}
		if (LineIndex != 0)
		{
			num ^= LineIndex.GetHashCode();
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
		if (LineType != Define_MiniGameBingoLineType.BingoLineDiagonal)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)LineType);
		}
		if (LineIndex != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(LineIndex);
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
		if (LineType != Define_MiniGameBingoLineType.BingoLineDiagonal)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)LineType);
		}
		if (LineIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LineIndex);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MiniGameBingoLineInfo other)
	{
		if (other != null)
		{
			if (other.LineType != Define_MiniGameBingoLineType.BingoLineDiagonal)
			{
				LineType = other.LineType;
			}
			if (other.LineIndex != 0)
			{
				LineIndex = other.LineIndex;
			}
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
			case 16u:
				LineIndex = input.ReadInt32();
				break;
			case 8u:
				LineType = (Define_MiniGameBingoLineType)input.ReadEnum();
				break;
			}
		}
	}
}
