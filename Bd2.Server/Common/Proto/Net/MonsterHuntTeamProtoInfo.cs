using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MonsterHuntTeamProtoInfo : IMessage<MonsterHuntTeamProtoInfo>, IMessage, IEquatable<MonsterHuntTeamProtoInfo>, IDeepCloneable<MonsterHuntTeamProtoInfo>, IBufferMessage
{
	private static readonly MessageParser<MonsterHuntTeamProtoInfo> _parser = new MessageParser<MonsterHuntTeamProtoInfo>(() => new MonsterHuntTeamProtoInfo());

	private UnknownFieldSet _unknownFields;

	public const int BlueCharProtoFieldNumber = 1;

	private string blueCharProto_ = "";

	public const int BlueEquipProtoFieldNumber = 2;

	private string blueEquipProto_ = "";

	public const int BlueBuffProtoFieldNumber = 3;

	private string blueBuffProto_ = "";

	public const int BlueCostumeProtoFieldNumber = 4;

	private string blueCostumeProto_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonsterHuntTeamProtoInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BattleRetryPreviousTurnResponseReflection.Descriptor.MessageTypes[1];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string BlueCharProto
	{
		get
		{
			return blueCharProto_;
		}
		set
		{
			blueCharProto_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string BlueEquipProto
	{
		get
		{
			return blueEquipProto_;
		}
		set
		{
			blueEquipProto_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string BlueBuffProto
	{
		get
		{
			return blueBuffProto_;
		}
		set
		{
			blueBuffProto_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string BlueCostumeProto
	{
		get
		{
			return blueCostumeProto_;
		}
		set
		{
			blueCostumeProto_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterHuntTeamProtoInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterHuntTeamProtoInfo(MonsterHuntTeamProtoInfo other)
		: this()
	{
		blueCharProto_ = other.blueCharProto_;
		blueEquipProto_ = other.blueEquipProto_;
		blueBuffProto_ = other.blueBuffProto_;
		blueCostumeProto_ = other.blueCostumeProto_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterHuntTeamProtoInfo Clone()
	{
		return new MonsterHuntTeamProtoInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonsterHuntTeamProtoInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonsterHuntTeamProtoInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (!(BlueCharProto != other.BlueCharProto) && !(BlueEquipProto != other.BlueEquipProto) && !(BlueBuffProto != other.BlueBuffProto) && !(BlueCostumeProto != other.BlueCostumeProto))
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
		if (BlueCharProto.Length != 0)
		{
			num ^= BlueCharProto.GetHashCode();
		}
		if (BlueEquipProto.Length != 0)
		{
			num ^= BlueEquipProto.GetHashCode();
		}
		if (BlueBuffProto.Length != 0)
		{
			num ^= BlueBuffProto.GetHashCode();
		}
		if (BlueCostumeProto.Length != 0)
		{
			num ^= BlueCostumeProto.GetHashCode();
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (BlueCharProto.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(BlueCharProto);
		}
		if (BlueEquipProto.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(BlueEquipProto);
		}
		if (BlueBuffProto.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(BlueBuffProto);
		}
		if (BlueCostumeProto.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(BlueCostumeProto);
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
		if (BlueCharProto.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BlueCharProto);
		}
		if (BlueEquipProto.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BlueEquipProto);
		}
		if (BlueBuffProto.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BlueBuffProto);
		}
		if (BlueCostumeProto.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BlueCostumeProto);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonsterHuntTeamProtoInfo other)
	{
		if (other != null)
		{
			if (other.BlueCharProto.Length != 0)
			{
				BlueCharProto = other.BlueCharProto;
			}
			if (other.BlueEquipProto.Length != 0)
			{
				BlueEquipProto = other.BlueEquipProto;
			}
			if (other.BlueBuffProto.Length != 0)
			{
				BlueBuffProto = other.BlueBuffProto;
			}
			if (other.BlueCostumeProto.Length != 0)
			{
				BlueCostumeProto = other.BlueCostumeProto;
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
			case 10u:
				BlueCharProto = input.ReadString();
				break;
			case 18u:
				BlueEquipProto = input.ReadString();
				break;
			case 26u:
				BlueBuffProto = input.ReadString();
				break;
			case 34u:
				BlueCostumeProto = input.ReadString();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
