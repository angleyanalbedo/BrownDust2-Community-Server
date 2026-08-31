using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MaintenanceInfoResponse : IMessage<MaintenanceInfoResponse>, IMessage, IEquatable<MaintenanceInfoResponse>, IDeepCloneable<MaintenanceInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<MaintenanceInfoResponse> _parser = new MessageParser<MaintenanceInfoResponse>(() => new MaintenanceInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int MarketInfoFieldNumber = 1;

	private MaintenanceInfo marketInfo_;

	public const int ServerConnectInfoFieldNumber = 2;

	private string serverConnectInfo_ = "";

	public const int ConnectTypeFieldNumber = 3;

	private int connectType_;

	public const int UserTypeFieldNumber = 4;

	private int userType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MaintenanceInfoResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MaintenanceInfoResponseReflection.Descriptor.MessageTypes[1];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MaintenanceInfo MarketInfo
	{
		get
		{
			return marketInfo_;
		}
		set
		{
			marketInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string ServerConnectInfo
	{
		get
		{
			return serverConnectInfo_;
		}
		set
		{
			serverConnectInfo_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ConnectType
	{
		get
		{
			return connectType_;
		}
		set
		{
			connectType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int UserType
	{
		get
		{
			return userType_;
		}
		set
		{
			userType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MaintenanceInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MaintenanceInfoResponse(MaintenanceInfoResponse other)
		: this()
	{
		marketInfo_ = ((other.marketInfo_ != null) ? other.marketInfo_.Clone() : null);
		serverConnectInfo_ = other.serverConnectInfo_;
		connectType_ = other.connectType_;
		userType_ = other.userType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MaintenanceInfoResponse Clone()
	{
		return new MaintenanceInfoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MaintenanceInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MaintenanceInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(MarketInfo, other.MarketInfo) && !(ServerConnectInfo != other.ServerConnectInfo) && ConnectType == other.ConnectType && UserType == other.UserType)
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
		if (marketInfo_ != null)
		{
			num ^= MarketInfo.GetHashCode();
		}
		if (ServerConnectInfo.Length != 0)
		{
			num ^= ServerConnectInfo.GetHashCode();
		}
		if (ConnectType != 0)
		{
			num ^= ConnectType.GetHashCode();
		}
		if (UserType != 0)
		{
			num ^= UserType.GetHashCode();
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
		if (marketInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(MarketInfo);
		}
		if (ServerConnectInfo.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(ServerConnectInfo);
		}
		if (ConnectType != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ConnectType);
		}
		if (UserType != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(UserType);
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
		if (marketInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MarketInfo);
		}
		if (ServerConnectInfo.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ServerConnectInfo);
		}
		if (ConnectType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConnectType);
		}
		if (UserType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UserType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(MaintenanceInfoResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.marketInfo_ != null)
		{
			if (marketInfo_ == null)
			{
				MarketInfo = new MaintenanceInfo();
			}
			MarketInfo.MergeFrom(other.MarketInfo);
		}
		if (other.ServerConnectInfo.Length != 0)
		{
			ServerConnectInfo = other.ServerConnectInfo;
		}
		if (other.ConnectType != 0)
		{
			ConnectType = other.ConnectType;
		}
		if (other.UserType != 0)
		{
			UserType = other.UserType;
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
			case 10u:
				if (marketInfo_ == null)
				{
					MarketInfo = new MaintenanceInfo();
				}
				input.ReadMessage(MarketInfo);
				break;
			case 18u:
				ServerConnectInfo = input.ReadString();
				break;
			case 24u:
				ConnectType = input.ReadInt32();
				break;
			case 32u:
				UserType = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
