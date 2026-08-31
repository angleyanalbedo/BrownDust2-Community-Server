using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EnvInfo : IMessage<EnvInfo>, IMessage, IEquatable<EnvInfo>, IDeepCloneable<EnvInfo>, IBufferMessage
{
	private static readonly MessageParser<EnvInfo> _parser = new MessageParser<EnvInfo>(() => new EnvInfo());

	private UnknownFieldSet _unknownFields;

	public const int IsLiveFieldNumber = 1;

	private bool isLive_;

	public const int UseSdkFieldNumber = 2;

	private bool useSdk_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<EnvInfo> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => EnvInfoReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsLive
	{
		get
		{
			return isLive_;
		}
		set
		{
			isLive_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool UseSdk
	{
		get
		{
			return useSdk_;
		}
		set
		{
			useSdk_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EnvInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnvInfo(EnvInfo other)
		: this()
	{
		isLive_ = other.isLive_;
		useSdk_ = other.useSdk_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnvInfo Clone()
	{
		return new EnvInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EnvInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EnvInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (IsLive == other.IsLive && UseSdk == other.UseSdk)
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
		if (IsLive)
		{
			num ^= IsLive.GetHashCode();
		}
		if (UseSdk)
		{
			num ^= UseSdk.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (IsLive)
		{
			output.WriteRawTag(8);
			output.WriteBool(IsLive);
		}
		if (UseSdk)
		{
			output.WriteRawTag(16);
			output.WriteBool(UseSdk);
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
		if (IsLive)
		{
			num += 2;
		}
		if (UseSdk)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EnvInfo other)
	{
		if (other != null)
		{
			if (other.IsLive)
			{
				IsLive = other.IsLive;
			}
			if (other.UseSdk)
			{
				UseSdk = other.UseSdk;
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 16u:
				UseSdk = input.ReadBool();
				break;
			case 8u:
				IsLive = input.ReadBool();
				break;
			}
		}
	}
}
