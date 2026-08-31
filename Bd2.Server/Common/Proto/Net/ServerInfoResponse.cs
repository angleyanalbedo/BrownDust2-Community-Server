using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class ServerInfoResponse : IMessage<ServerInfoResponse>, IMessage, IEquatable<ServerInfoResponse>, IDeepCloneable<ServerInfoResponse>, IBufferMessage
{
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		public sealed class ServerInfo : IMessage<ServerInfo>, IMessage, IEquatable<ServerInfo>, IDeepCloneable<ServerInfo>, IBufferMessage
		{
			private static readonly MessageParser<ServerInfo> _parser = new MessageParser<ServerInfo>(() => new ServerInfo());

			private UnknownFieldSet _unknownFields;

			public const int RegionFieldNumber = 1;

			private int region_;

			public const int GameServerInfoFieldNumber = 2;

			private string gameServerInfo_ = "";

			public const int CdnInfoFieldNumber = 3;

			private string cdnInfo_ = "";

			public const int OpenFlagFieldNumber = 4;

			private int openFlag_;

			public const int LogServerInfoFieldNumber = 5;

			private string logServerInfo_ = "";

			public const int CharServerInfoFieldNumber = 6;

			private string charServerInfo_ = "";

			public const int CouponWebInfoFieldNumber = 7;

			private string couponWebInfo_ = "";

			public const int GameDataInfoFieldNumber = 8;

			private string gameDataInfo_ = "";

			public const int GameDataVersionFieldNumber = 9;

			private string gameDataVersion_ = "";

			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<ServerInfo> Parser => _parser;

			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor => ServerInfoResponse.Descriptor.NestedTypes[0];

			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			MessageDescriptor IMessage.Descriptor => Descriptor;

			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int Region
			{
				get
				{
					return region_;
				}
				set
				{
					region_ = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public string GameServerInfo
			{
				get
				{
					return gameServerInfo_;
				}
				set
				{
					gameServerInfo_ = ProtoPreconditions.CheckNotNull(value, "value");
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public string CdnInfo
			{
				get
				{
					return cdnInfo_;
				}
				set
				{
					cdnInfo_ = ProtoPreconditions.CheckNotNull(value, "value");
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int OpenFlag
			{
				get
				{
					return openFlag_;
				}
				set
				{
					openFlag_ = value;
				}
			}

			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public string LogServerInfo
			{
				get
				{
					return logServerInfo_;
				}
				set
				{
					logServerInfo_ = ProtoPreconditions.CheckNotNull(value, "value");
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public string CharServerInfo
			{
				get
				{
					return charServerInfo_;
				}
				set
				{
					charServerInfo_ = ProtoPreconditions.CheckNotNull(value, "value");
				}
			}

			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public string CouponWebInfo
			{
				get
				{
					return couponWebInfo_;
				}
				set
				{
					couponWebInfo_ = ProtoPreconditions.CheckNotNull(value, "value");
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public string GameDataInfo
			{
				get
				{
					return gameDataInfo_;
				}
				set
				{
					gameDataInfo_ = ProtoPreconditions.CheckNotNull(value, "value");
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public string GameDataVersion
			{
				get
				{
					return gameDataVersion_;
				}
				set
				{
					gameDataVersion_ = ProtoPreconditions.CheckNotNull(value, "value");
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ServerInfo()
			{
			}

			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ServerInfo(ServerInfo other)
				: this()
			{
				region_ = other.region_;
				gameServerInfo_ = other.gameServerInfo_;
				cdnInfo_ = other.cdnInfo_;
				openFlag_ = other.openFlag_;
				logServerInfo_ = other.logServerInfo_;
				charServerInfo_ = other.charServerInfo_;
				couponWebInfo_ = other.couponWebInfo_;
				gameDataInfo_ = other.gameDataInfo_;
				gameDataVersion_ = other.gameDataVersion_;
				_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ServerInfo Clone()
			{
				return new ServerInfo(this);
			}

			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return Equals(other as ServerInfo);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(ServerInfo other)
			{
				if (other != null)
				{
					if (other != this)
					{
						if (Region == other.Region && !(GameServerInfo != other.GameServerInfo) && !(CdnInfo != other.CdnInfo) && OpenFlag == other.OpenFlag && !(LogServerInfo != other.LogServerInfo) && !(CharServerInfo != other.CharServerInfo) && !(CouponWebInfo != other.CouponWebInfo) && !(GameDataInfo != other.GameDataInfo) && !(GameDataVersion != other.GameDataVersion))
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
				if (Region != 0)
				{
					num ^= Region.GetHashCode();
				}
				if (GameServerInfo.Length != 0)
				{
					num ^= GameServerInfo.GetHashCode();
				}
				if (CdnInfo.Length != 0)
				{
					num ^= CdnInfo.GetHashCode();
				}
				if (OpenFlag != 0)
				{
					num ^= OpenFlag.GetHashCode();
				}
				if (LogServerInfo.Length != 0)
				{
					num ^= LogServerInfo.GetHashCode();
				}
				if (CharServerInfo.Length != 0)
				{
					num ^= CharServerInfo.GetHashCode();
				}
				if (CouponWebInfo.Length != 0)
				{
					num ^= CouponWebInfo.GetHashCode();
				}
				if (GameDataInfo.Length != 0)
				{
					num ^= GameDataInfo.GetHashCode();
				}
				if (GameDataVersion.Length != 0)
				{
					num ^= GameDataVersion.GetHashCode();
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
				if (Region != 0)
				{
					output.WriteRawTag(8);
					output.WriteSInt32(Region);
				}
				if (GameServerInfo.Length != 0)
				{
					output.WriteRawTag(18);
					output.WriteString(GameServerInfo);
				}
				if (CdnInfo.Length != 0)
				{
					output.WriteRawTag(26);
					output.WriteString(CdnInfo);
				}
				if (OpenFlag != 0)
				{
					output.WriteRawTag(32);
					output.WriteSInt32(OpenFlag);
				}
				if (LogServerInfo.Length != 0)
				{
					output.WriteRawTag(42);
					output.WriteString(LogServerInfo);
				}
				if (CharServerInfo.Length != 0)
				{
					output.WriteRawTag(50);
					output.WriteString(CharServerInfo);
				}
				if (CouponWebInfo.Length != 0)
				{
					output.WriteRawTag(58);
					output.WriteString(CouponWebInfo);
				}
				if (GameDataInfo.Length != 0)
				{
					output.WriteRawTag(66);
					output.WriteString(GameDataInfo);
				}
				if (GameDataVersion.Length != 0)
				{
					output.WriteRawTag(74);
					output.WriteString(GameDataVersion);
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
				if (Region != 0)
				{
					num += 1 + CodedOutputStream.ComputeSInt32Size(Region);
				}
				if (GameServerInfo.Length != 0)
				{
					num += 1 + CodedOutputStream.ComputeStringSize(GameServerInfo);
				}
				if (CdnInfo.Length != 0)
				{
					num += 1 + CodedOutputStream.ComputeStringSize(CdnInfo);
				}
				if (OpenFlag != 0)
				{
					num += 1 + CodedOutputStream.ComputeSInt32Size(OpenFlag);
				}
				if (LogServerInfo.Length != 0)
				{
					num += 1 + CodedOutputStream.ComputeStringSize(LogServerInfo);
				}
				if (CharServerInfo.Length != 0)
				{
					num += 1 + CodedOutputStream.ComputeStringSize(CharServerInfo);
				}
				if (CouponWebInfo.Length != 0)
				{
					num += 1 + CodedOutputStream.ComputeStringSize(CouponWebInfo);
				}
				if (GameDataInfo.Length != 0)
				{
					num += 1 + CodedOutputStream.ComputeStringSize(GameDataInfo);
				}
				if (GameDataVersion.Length != 0)
				{
					num += 1 + CodedOutputStream.ComputeStringSize(GameDataVersion);
				}
				if (_unknownFields != null)
				{
					num += _unknownFields.CalculateSize();
				}
				return num;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(ServerInfo other)
			{
				if (other != null)
				{
					if (other.Region != 0)
					{
						Region = other.Region;
					}
					if (other.GameServerInfo.Length != 0)
					{
						GameServerInfo = other.GameServerInfo;
					}
					if (other.CdnInfo.Length != 0)
					{
						CdnInfo = other.CdnInfo;
					}
					if (other.OpenFlag != 0)
					{
						OpenFlag = other.OpenFlag;
					}
					if (other.LogServerInfo.Length != 0)
					{
						LogServerInfo = other.LogServerInfo;
					}
					if (other.CharServerInfo.Length != 0)
					{
						CharServerInfo = other.CharServerInfo;
					}
					if (other.CouponWebInfo.Length != 0)
					{
						CouponWebInfo = other.CouponWebInfo;
					}
					if (other.GameDataInfo.Length != 0)
					{
						GameDataInfo = other.GameDataInfo;
					}
					if (other.GameDataVersion.Length != 0)
					{
						GameDataVersion = other.GameDataVersion;
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
						Region = input.ReadSInt32();
						break;
					case 18u:
						GameServerInfo = input.ReadString();
						break;
					case 26u:
						CdnInfo = input.ReadString();
						break;
					case 32u:
						OpenFlag = input.ReadSInt32();
						break;
					case 42u:
						LogServerInfo = input.ReadString();
						break;
					case 50u:
						CharServerInfo = input.ReadString();
						break;
					case 58u:
						CouponWebInfo = input.ReadString();
						break;
					case 66u:
						GameDataInfo = input.ReadString();
						break;
					case 74u:
						GameDataVersion = input.ReadString();
						break;
					default:
						_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
						break;
					}
				}
			}
		}
	}
	private static readonly MessageParser<ServerInfoResponse> _parser = new MessageParser<ServerInfoResponse>(() => new ServerInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int InfoListFieldNumber = 1;

	private static readonly FieldCodec<Types.ServerInfo> _repeated_infoList_codec = FieldCodec.ForMessage(10u, Types.ServerInfo.Parser);

	private readonly RepeatedField<Types.ServerInfo> infoList_ = new RepeatedField<Types.ServerInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ServerInfoResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => ServerInfoResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<Types.ServerInfo> InfoList => infoList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ServerInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ServerInfoResponse(ServerInfoResponse other)
		: this()
	{
		infoList_ = other.infoList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ServerInfoResponse Clone()
	{
		return new ServerInfoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ServerInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ServerInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (infoList_.Equals(other.infoList_))
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
		num ^= infoList_.GetHashCode();
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
		infoList_.WriteTo(ref output, _repeated_infoList_codec);
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
		num += infoList_.CalculateSize(_repeated_infoList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ServerInfoResponse other)
	{
		if (other != null)
		{
			infoList_.Add(other.infoList_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				infoList_.AddEntriesFrom(ref input, _repeated_infoList_codec);
			}
		}
		}
	}
