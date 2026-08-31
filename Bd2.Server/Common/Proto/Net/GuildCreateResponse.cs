using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GuildCreateResponse : IMessage<GuildCreateResponse>, IMessage, IEquatable<GuildCreateResponse>, IDeepCloneable<GuildCreateResponse>, IBufferMessage
{
	private static readonly MessageParser<GuildCreateResponse> _parser = new MessageParser<GuildCreateResponse>(() => new GuildCreateResponse());

	private UnknownFieldSet _unknownFields;

	public const int GuildInfoFieldNumber = 1;

	private GuildDBInfo guildInfo_;

	public const int TopPercentFieldNumber = 2;

	private double topPercent_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildCreateResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => GuildCreateResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildDBInfo GuildInfo
	{
		get
		{
			return guildInfo_;
		}
		set
		{
			guildInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double TopPercent
	{
		get
		{
			return topPercent_;
		}
		set
		{
			topPercent_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildCreateResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildCreateResponse(GuildCreateResponse other)
		: this()
	{
		guildInfo_ = ((other.guildInfo_ != null) ? other.guildInfo_.Clone() : null);
		topPercent_ = other.topPercent_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildCreateResponse Clone()
	{
		return new GuildCreateResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GuildCreateResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildCreateResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(GuildInfo, other.GuildInfo) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TopPercent, other.TopPercent))
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
		if (guildInfo_ != null)
		{
			num ^= GuildInfo.GetHashCode();
		}
		if (TopPercent != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TopPercent);
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
		if (guildInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(GuildInfo);
		}
		if (TopPercent != 0.0)
		{
			output.WriteRawTag(17);
			output.WriteDouble(TopPercent);
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
		if (guildInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GuildInfo);
		}
		if (TopPercent != 0.0)
		{
			num += 9;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildCreateResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.guildInfo_ != null)
		{
			if (guildInfo_ == null)
			{
				GuildInfo = new GuildDBInfo();
			}
			GuildInfo.MergeFrom(other.GuildInfo);
		}
		if (other.TopPercent != 0.0)
		{
			TopPercent = other.TopPercent;
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 17u:
				TopPercent = input.ReadDouble();
				break;
			case 10u:
				if (guildInfo_ == null)
				{
					GuildInfo = new GuildDBInfo();
				}
				input.ReadMessage(GuildInfo);
				break;
			}
		}
	}
}
