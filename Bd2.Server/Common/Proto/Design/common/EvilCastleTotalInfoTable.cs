using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class EvilCastleTotalInfoTable : IMessage<EvilCastleTotalInfoTable>, IMessage, IEquatable<EvilCastleTotalInfoTable>, IDeepCloneable<EvilCastleTotalInfoTable>, IBufferMessage
{
	private static readonly MessageParser<EvilCastleTotalInfoTable> _parser = new MessageParser<EvilCastleTotalInfoTable>(() => new EvilCastleTotalInfoTable());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int LobbyBackGroudImagePathFieldNumber = 2;

	private string lobbyBackGroudImagePath_ = "";

	public const int LobbyIconPathFieldNumber = 3;

	private string lobbyIconPath_ = "";

	public const int LobbyIllustPathFieldNumber = 4;

	private string lobbyIllustPath_ = "";

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<EvilCastleTotalInfoTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => EvilCastleTotalInfoTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public string LobbyBackGroudImagePath
	{
		get
		{
			return lobbyBackGroudImagePath_;
		}
		set
		{
			lobbyBackGroudImagePath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string LobbyIconPath
	{
		get
		{
			return lobbyIconPath_;
		}
		set
		{
			lobbyIconPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string LobbyIllustPath
	{
		get
		{
			return lobbyIllustPath_;
		}
		set
		{
			lobbyIllustPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleTotalInfoTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleTotalInfoTable(EvilCastleTotalInfoTable other)
		: this()
	{
		id_ = other.id_;
		lobbyBackGroudImagePath_ = other.lobbyBackGroudImagePath_;
		lobbyIconPath_ = other.lobbyIconPath_;
		lobbyIllustPath_ = other.lobbyIllustPath_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleTotalInfoTable Clone()
	{
		return new EvilCastleTotalInfoTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EvilCastleTotalInfoTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(EvilCastleTotalInfoTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && !(LobbyBackGroudImagePath != other.LobbyBackGroudImagePath) && !(LobbyIconPath != other.LobbyIconPath) && !(LobbyIllustPath != other.LobbyIllustPath))
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
		if (LobbyBackGroudImagePath.Length != 0)
		{
			num ^= LobbyBackGroudImagePath.GetHashCode();
		}
		if (LobbyIconPath.Length != 0)
		{
			num ^= LobbyIconPath.GetHashCode();
		}
		if (LobbyIllustPath.Length != 0)
		{
			num ^= LobbyIllustPath.GetHashCode();
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
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (LobbyBackGroudImagePath.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(LobbyBackGroudImagePath);
		}
		if (LobbyIconPath.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(LobbyIconPath);
		}
		if (LobbyIllustPath.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(LobbyIllustPath);
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
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (LobbyBackGroudImagePath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LobbyBackGroudImagePath);
		}
		if (LobbyIconPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LobbyIconPath);
		}
		if (LobbyIllustPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LobbyIllustPath);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EvilCastleTotalInfoTable other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.LobbyBackGroudImagePath.Length != 0)
			{
				LobbyBackGroudImagePath = other.LobbyBackGroudImagePath;
			}
			if (other.LobbyIconPath.Length != 0)
			{
				LobbyIconPath = other.LobbyIconPath;
			}
			if (other.LobbyIllustPath.Length != 0)
			{
				LobbyIllustPath = other.LobbyIllustPath;
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
				Id = input.ReadInt32();
				break;
			case 18u:
				LobbyBackGroudImagePath = input.ReadString();
				break;
			case 26u:
				LobbyIconPath = input.ReadString();
				break;
			case 34u:
				LobbyIllustPath = input.ReadString();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
