using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class CancelLeaveUserRequest : IMessage<CancelLeaveUserRequest>, IMessage, IEquatable<CancelLeaveUserRequest>, IDeepCloneable<CancelLeaveUserRequest>, IBufferMessage
{
	private static readonly MessageParser<CancelLeaveUserRequest> _parser = new MessageParser<CancelLeaveUserRequest>(() => new CancelLeaveUserRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int AccessTokenFieldNumber = 2;

	private string accessToken_ = "";

	public const int EnvInfoFieldNumber = 3;

	private EnvInfo envInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CancelLeaveUserRequest> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => CancelLeaveUserRequestReflection.Descriptor.MessageTypes[0];

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
	public string AccessToken
	{
		get
		{
			return accessToken_;
		}
		set
		{
			accessToken_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EnvInfo EnvInfo
	{
		get
		{
			return envInfo_;
		}
		set
		{
			envInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CancelLeaveUserRequest()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CancelLeaveUserRequest(CancelLeaveUserRequest other)
		: this()
	{
		seq_ = other.seq_;
		accessToken_ = other.accessToken_;
		envInfo_ = ((other.envInfo_ != null) ? other.envInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CancelLeaveUserRequest Clone()
	{
		return new CancelLeaveUserRequest(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as CancelLeaveUserRequest);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CancelLeaveUserRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && !(AccessToken != other.AccessToken) && object.Equals(EnvInfo, other.EnvInfo))
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
		if (Seq != 0)
		{
			num ^= Seq.GetHashCode();
		}
		if (AccessToken.Length != 0)
		{
			num ^= AccessToken.GetHashCode();
		}
		if (envInfo_ != null)
		{
			num ^= EnvInfo.GetHashCode();
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
		if (Seq != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Seq);
		}
		if (AccessToken.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(AccessToken);
		}
		if (envInfo_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(EnvInfo);
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
		if (AccessToken.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AccessToken);
		}
		if (envInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EnvInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CancelLeaveUserRequest other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Seq != 0)
		{
			Seq = other.Seq;
		}
		if (other.AccessToken.Length != 0)
		{
			AccessToken = other.AccessToken;
		}
		if (other.envInfo_ != null)
		{
			if (envInfo_ == null)
			{
				EnvInfo = new EnvInfo();
			}
			EnvInfo.MergeFrom(other.EnvInfo);
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
				if (envInfo_ == null)
				{
					EnvInfo = new EnvInfo();
				}
				input.ReadMessage(EnvInfo);
				break;
			case 18u:
				AccessToken = input.ReadString();
				break;
			case 8u:
				Seq = input.ReadInt32();
				break;
			}
		}
	}
}
