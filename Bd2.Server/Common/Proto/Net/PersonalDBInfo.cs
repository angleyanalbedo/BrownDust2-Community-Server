using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PersonalDBInfo : IMessage<PersonalDBInfo>, IMessage, IEquatable<PersonalDBInfo>, IDeepCloneable<PersonalDBInfo>, IBufferMessage
{
	private static readonly MessageParser<PersonalDBInfo> _parser = new MessageParser<PersonalDBInfo>(() => new PersonalDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int TitleFieldNumber = 2;

	private string title_ = "";

	public const int UrlFieldNumber = 3;

	private string url_ = "";

	public const int StartDateFieldNumber = 4;

	private long startDate_;

	public const int EndDateFieldNumber = 5;

	private long endDate_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PersonalDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PersonalInfoResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public string Title
	{
		get
		{
			return title_;
		}
		set
		{
			title_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Url
	{
		get
		{
			return url_;
		}
		set
		{
			url_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long StartDate
	{
		get
		{
			return startDate_;
		}
		set
		{
			startDate_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long EndDate
	{
		get
		{
			return endDate_;
		}
		set
		{
			endDate_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PersonalDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PersonalDBInfo(PersonalDBInfo other)
		: this()
	{
		id_ = other.id_;
		title_ = other.title_;
		url_ = other.url_;
		startDate_ = other.startDate_;
		endDate_ = other.endDate_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PersonalDBInfo Clone()
	{
		return new PersonalDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PersonalDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PersonalDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && !(Title != other.Title) && !(Url != other.Url) && StartDate == other.StartDate && EndDate == other.EndDate)
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
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (Title.Length != 0)
		{
			num ^= Title.GetHashCode();
		}
		if (Url.Length != 0)
		{
			num ^= Url.GetHashCode();
		}
		if (StartDate != 0L)
		{
			num ^= StartDate.GetHashCode();
		}
		if (EndDate != 0L)
		{
			num ^= EndDate.GetHashCode();
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
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (Title.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Title);
		}
		if (Url.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Url);
		}
		if (StartDate != 0L)
		{
			output.WriteRawTag(32);
			output.WriteInt64(StartDate);
		}
		if (EndDate != 0L)
		{
			output.WriteRawTag(40);
			output.WriteInt64(EndDate);
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
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (Title.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Title);
		}
		if (Url.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Url);
		}
		if (StartDate != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(StartDate);
		}
		if (EndDate != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(EndDate);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PersonalDBInfo other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Title.Length != 0)
			{
				Title = other.Title;
			}
			if (other.Url.Length != 0)
			{
				Url = other.Url;
			}
			if (other.StartDate != 0L)
			{
				StartDate = other.StartDate;
			}
			if (other.EndDate != 0L)
			{
				EndDate = other.EndDate;
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
				Id = input.ReadInt32();
				break;
			case 18u:
				Title = input.ReadString();
				break;
			case 26u:
				Url = input.ReadString();
				break;
			case 32u:
				StartDate = input.ReadInt64();
				break;
			case 40u:
				EndDate = input.ReadInt64();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
