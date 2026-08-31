using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class EndStoryDefaultTable : IMessage<EndStoryDefaultTable>, IMessage, IEquatable<EndStoryDefaultTable>, IDeepCloneable<EndStoryDefaultTable>, IBufferMessage
{
	private static readonly MessageParser<EndStoryDefaultTable> _parser = new MessageParser<EndStoryDefaultTable>(() => new EndStoryDefaultTable());

	private UnknownFieldSet _unknownFields;

	public const int EndGuideTableGroupIDFieldNumber = 1;

	private int endGuideTableGroupID_;

	public const int EndPackIdFieldNumber = 2;

	private int endPackId_;

	public const int EndPackTutorialIdFieldNumber = 3;

	private int endPackTutorialId_;

	public const int IdFieldNumber = 4;

	private int id_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<EndStoryDefaultTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => EndStoryDefaultTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int EndGuideTableGroupID
	{
		get
		{
			return endGuideTableGroupID_;
		}
		set
		{
			endGuideTableGroupID_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EndPackId
	{
		get
		{
			return endPackId_;
		}
		set
		{
			endPackId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int EndPackTutorialId
	{
		get
		{
			return endPackTutorialId_;
		}
		set
		{
			endPackTutorialId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EndStoryDefaultTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EndStoryDefaultTable(EndStoryDefaultTable other)
		: this()
	{
		endGuideTableGroupID_ = other.endGuideTableGroupID_;
		endPackId_ = other.endPackId_;
		endPackTutorialId_ = other.endPackTutorialId_;
		id_ = other.id_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EndStoryDefaultTable Clone()
	{
		return new EndStoryDefaultTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EndStoryDefaultTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EndStoryDefaultTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (EndGuideTableGroupID == other.EndGuideTableGroupID && EndPackId == other.EndPackId && EndPackTutorialId == other.EndPackTutorialId && Id == other.Id)
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
		if (EndGuideTableGroupID != 0)
		{
			num ^= EndGuideTableGroupID.GetHashCode();
		}
		if (EndPackId != 0)
		{
			num ^= EndPackId.GetHashCode();
		}
		if (EndPackTutorialId != 0)
		{
			num ^= EndPackTutorialId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
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
		if (EndGuideTableGroupID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(EndGuideTableGroupID);
		}
		if (EndPackId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(EndPackId);
		}
		if (EndPackTutorialId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(EndPackTutorialId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Id);
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
		if (EndGuideTableGroupID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EndGuideTableGroupID);
		}
		if (EndPackId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EndPackId);
		}
		if (EndPackTutorialId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EndPackTutorialId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EndStoryDefaultTable other)
	{
		if (other != null)
		{
			if (other.EndGuideTableGroupID != 0)
			{
				EndGuideTableGroupID = other.EndGuideTableGroupID;
			}
			if (other.EndPackId != 0)
			{
				EndPackId = other.EndPackId;
			}
			if (other.EndPackTutorialId != 0)
			{
				EndPackTutorialId = other.EndPackTutorialId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
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
			case 8u:
				EndGuideTableGroupID = input.ReadInt32();
				break;
			case 16u:
				EndPackId = input.ReadInt32();
				break;
			case 24u:
				EndPackTutorialId = input.ReadInt32();
				break;
			case 32u:
				Id = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
