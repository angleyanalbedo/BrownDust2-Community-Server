using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class ScheduleDBInfo : IMessage<ScheduleDBInfo>, IMessage, IEquatable<ScheduleDBInfo>, IDeepCloneable<ScheduleDBInfo>, IBufferMessage
{
	private static readonly MessageParser<ScheduleDBInfo> _parser = new MessageParser<ScheduleDBInfo>(() => new ScheduleDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int ContentIdFieldNumber = 1;

	private int contentId_;

	public const int CurrentSeasonFieldNumber = 2;

	private SeasonInfo currentSeason_;

	public const int NextSeasonFieldNumber = 3;

	private SeasonInfo nextSeason_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ScheduleDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SchduleInfoReflection.Descriptor.MessageTypes[1];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ContentId
	{
		get
		{
			return contentId_;
		}
		set
		{
			contentId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SeasonInfo CurrentSeason
	{
		get
		{
			return currentSeason_;
		}
		set
		{
			currentSeason_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SeasonInfo NextSeason
	{
		get
		{
			return nextSeason_;
		}
		set
		{
			nextSeason_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ScheduleDBInfo()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ScheduleDBInfo(ScheduleDBInfo other)
		: this()
	{
		contentId_ = other.contentId_;
		currentSeason_ = ((other.currentSeason_ != null) ? other.currentSeason_.Clone() : null);
		nextSeason_ = ((other.nextSeason_ != null) ? other.nextSeason_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ScheduleDBInfo Clone()
	{
		return new ScheduleDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ScheduleDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ScheduleDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (ContentId == other.ContentId && object.Equals(CurrentSeason, other.CurrentSeason) && object.Equals(NextSeason, other.NextSeason))
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
		if (ContentId != 0)
		{
			num ^= ContentId.GetHashCode();
		}
		if (currentSeason_ != null)
		{
			num ^= CurrentSeason.GetHashCode();
		}
		if (nextSeason_ != null)
		{
			num ^= NextSeason.GetHashCode();
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
		if (ContentId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ContentId);
		}
		if (currentSeason_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(CurrentSeason);
		}
		if (nextSeason_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(NextSeason);
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
		if (ContentId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ContentId);
		}
		if (currentSeason_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CurrentSeason);
		}
		if (nextSeason_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NextSeason);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ScheduleDBInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ContentId != 0)
		{
			ContentId = other.ContentId;
		}
		if (other.currentSeason_ != null)
		{
			if (currentSeason_ == null)
			{
				CurrentSeason = new SeasonInfo();
			}
			CurrentSeason.MergeFrom(other.CurrentSeason);
		}
		if (other.nextSeason_ != null)
		{
			if (nextSeason_ == null)
			{
				NextSeason = new SeasonInfo();
			}
			NextSeason.MergeFrom(other.NextSeason);
		}
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 26u:
				if (nextSeason_ == null)
				{
					NextSeason = new SeasonInfo();
				}
				input.ReadMessage(NextSeason);
				break;
			case 18u:
				if (currentSeason_ == null)
				{
					CurrentSeason = new SeasonInfo();
				}
				input.ReadMessage(CurrentSeason);
				break;
			case 8u:
				ContentId = input.ReadInt32();
				break;
			}
		}
	}
}
