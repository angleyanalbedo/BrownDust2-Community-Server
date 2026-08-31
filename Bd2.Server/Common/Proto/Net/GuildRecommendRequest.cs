using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GuildRecommendRequest : IMessage<GuildRecommendRequest>, IMessage, IEquatable<GuildRecommendRequest>, IDeepCloneable<GuildRecommendRequest>, IBufferMessage
{
	private static readonly MessageParser<GuildRecommendRequest> _parser = new MessageParser<GuildRecommendRequest>(() => new GuildRecommendRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int SearchMinFieldNumber = 2;

	private int searchMin_;

	public const int SearchMaxFieldNumber = 3;

	private int searchMax_;

	public const int JoinTypeFieldNumber = 4;

	private Define_GuildJoinType joinType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildRecommendRequest> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GuildRecommendRequestReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SearchMin
	{
		get
		{
			return searchMin_;
		}
		set
		{
			searchMin_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SearchMax
	{
		get
		{
			return searchMax_;
		}
		set
		{
			searchMax_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Define_GuildJoinType JoinType
	{
		get
		{
			return joinType_;
		}
		set
		{
			joinType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRecommendRequest()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRecommendRequest(GuildRecommendRequest other)
		: this()
	{
		seq_ = other.seq_;
		searchMin_ = other.searchMin_;
		searchMax_ = other.searchMax_;
		joinType_ = other.joinType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRecommendRequest Clone()
	{
		return new GuildRecommendRequest(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GuildRecommendRequest);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildRecommendRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && SearchMin == other.SearchMin && SearchMax == other.SearchMax && JoinType == other.JoinType)
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
		if (SearchMin != 0)
		{
			num ^= SearchMin.GetHashCode();
		}
		if (SearchMax != 0)
		{
			num ^= SearchMax.GetHashCode();
		}
		if (JoinType != Define_GuildJoinType.GuildTypeNone)
		{
			num ^= JoinType.GetHashCode();
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
		if (Seq != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Seq);
		}
		if (SearchMin != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SearchMin);
		}
		if (SearchMax != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(SearchMax);
		}
		if (JoinType != Define_GuildJoinType.GuildTypeNone)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)JoinType);
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
		if (Seq != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Seq);
		}
		if (SearchMin != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SearchMin);
		}
		if (SearchMax != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SearchMax);
		}
		if (JoinType != Define_GuildJoinType.GuildTypeNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)JoinType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildRecommendRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			if (other.SearchMin != 0)
			{
				SearchMin = other.SearchMin;
			}
			if (other.SearchMax != 0)
			{
				SearchMax = other.SearchMax;
			}
			if (other.JoinType != Define_GuildJoinType.GuildTypeNone)
			{
				JoinType = other.JoinType;
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
				Seq = input.ReadInt32();
				break;
			case 16u:
				SearchMin = input.ReadInt32();
				break;
			case 24u:
				SearchMax = input.ReadInt32();
				break;
			case 32u:
				JoinType = (Define_GuildJoinType)input.ReadEnum();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
