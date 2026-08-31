using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MyRoomTrophyDBInfo : IMessage<MyRoomTrophyDBInfo>, IMessage, IEquatable<MyRoomTrophyDBInfo>, IDeepCloneable<MyRoomTrophyDBInfo>, IBufferMessage
{
	private static readonly MessageParser<MyRoomTrophyDBInfo> _parser = new MessageParser<MyRoomTrophyDBInfo>(() => new MyRoomTrophyDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int InvenIndexFieldNumber = 1;

	private long invenIndex_;

	public const int IdFieldNumber = 2;

	private int id_;

	public const int ContentsTypeFieldNumber = 3;

	private int contentsType_;

	public const int SeasonFieldNumber = 4;

	private int season_;

	public const int UseCountFieldNumber = 5;

	private int useCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MyRoomTrophyDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MyRoomTrophyDBInfoReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public int ContentsType
	{
		get
		{
			return contentsType_;
		}
		set
		{
			contentsType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Season
	{
		get
		{
			return season_;
		}
		set
		{
			season_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int UseCount
	{
		get
		{
			return useCount_;
		}
		set
		{
			useCount_ = value;
		}
	}

	public bool IsNew { get; set; }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MyRoomTrophyDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MyRoomTrophyDBInfo(MyRoomTrophyDBInfo other)
		: this()
	{
		invenIndex_ = other.invenIndex_;
		id_ = other.id_;
		contentsType_ = other.contentsType_;
		season_ = other.season_;
		useCount_ = other.useCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MyRoomTrophyDBInfo Clone()
	{
		return new MyRoomTrophyDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MyRoomTrophyDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MyRoomTrophyDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (InvenIndex == other.InvenIndex && Id == other.Id && ContentsType == other.ContentsType && Season == other.Season && UseCount == other.UseCount)
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
		if (InvenIndex != 0L)
		{
			num ^= InvenIndex.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (ContentsType != 0)
		{
			num ^= ContentsType.GetHashCode();
		}
		if (Season != 0)
		{
			num ^= Season.GetHashCode();
		}
		if (UseCount != 0)
		{
			num ^= UseCount.GetHashCode();
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
		if (InvenIndex != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(InvenIndex);
		}
		if (Id != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Id);
		}
		if (ContentsType != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ContentsType);
		}
		if (Season != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Season);
		}
		if (UseCount != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(UseCount);
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
		if (InvenIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(InvenIndex);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (ContentsType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ContentsType);
		}
		if (Season != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Season);
		}
		if (UseCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UseCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(MyRoomTrophyDBInfo other)
	{
		if (other != null)
		{
			if (other.InvenIndex != 0L)
			{
				InvenIndex = other.InvenIndex;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.ContentsType != 0)
			{
				ContentsType = other.ContentsType;
			}
			if (other.Season != 0)
			{
				Season = other.Season;
			}
			if (other.UseCount != 0)
			{
				UseCount = other.UseCount;
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
			case 8u:
				InvenIndex = input.ReadInt64();
				break;
			case 16u:
				Id = input.ReadInt32();
				break;
			case 24u:
				ContentsType = input.ReadInt32();
				break;
			case 32u:
				Season = input.ReadInt32();
				break;
			case 40u:
				UseCount = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
