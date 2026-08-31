using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class SelectPlatformOtherDataResponse : IMessage<SelectPlatformOtherDataResponse>, IMessage, IEquatable<SelectPlatformOtherDataResponse>, IDeepCloneable<SelectPlatformOtherDataResponse>, IBufferMessage
{
	private static readonly MessageParser<SelectPlatformOtherDataResponse> _parser = new MessageParser<SelectPlatformOtherDataResponse>(() => new SelectPlatformOtherDataResponse());

	private UnknownFieldSet _unknownFields;

	public const int PlatformUserInfoFieldNumber = 1;

	private UserDBInfo platformUserInfo_;

	public const int GuestUserInfoFieldNumber = 2;

	private UserDBInfo guestUserInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<SelectPlatformOtherDataResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => SelectPlatformOtherDataResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public UserDBInfo PlatformUserInfo
	{
		get
		{
			return platformUserInfo_;
		}
		set
		{
			platformUserInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public UserDBInfo GuestUserInfo
	{
		get
		{
			return guestUserInfo_;
		}
		set
		{
			guestUserInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SelectPlatformOtherDataResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SelectPlatformOtherDataResponse(SelectPlatformOtherDataResponse other)
		: this()
	{
		platformUserInfo_ = ((other.platformUserInfo_ != null) ? other.platformUserInfo_.Clone() : null);
		guestUserInfo_ = ((other.guestUserInfo_ != null) ? other.guestUserInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SelectPlatformOtherDataResponse Clone()
	{
		return new SelectPlatformOtherDataResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as SelectPlatformOtherDataResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SelectPlatformOtherDataResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(PlatformUserInfo, other.PlatformUserInfo) && object.Equals(GuestUserInfo, other.GuestUserInfo))
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
		if (platformUserInfo_ != null)
		{
			num ^= PlatformUserInfo.GetHashCode();
		}
		if (guestUserInfo_ != null)
		{
			num ^= GuestUserInfo.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (platformUserInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(PlatformUserInfo);
		}
		if (guestUserInfo_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(GuestUserInfo);
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
		if (platformUserInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PlatformUserInfo);
		}
		if (guestUserInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GuestUserInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SelectPlatformOtherDataResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.platformUserInfo_ != null)
		{
			if (platformUserInfo_ == null)
			{
				PlatformUserInfo = new UserDBInfo();
			}
			PlatformUserInfo.MergeFrom(other.PlatformUserInfo);
		}
		if (other.guestUserInfo_ != null)
		{
			if (guestUserInfo_ == null)
			{
				GuestUserInfo = new UserDBInfo();
			}
			GuestUserInfo.MergeFrom(other.GuestUserInfo);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 18u:
				if (guestUserInfo_ == null)
				{
					GuestUserInfo = new UserDBInfo();
				}
				input.ReadMessage(GuestUserInfo);
				break;
			case 10u:
				if (platformUserInfo_ == null)
				{
					PlatformUserInfo = new UserDBInfo();
				}
				input.ReadMessage(PlatformUserInfo);
				break;
			}
		}
	}
}
