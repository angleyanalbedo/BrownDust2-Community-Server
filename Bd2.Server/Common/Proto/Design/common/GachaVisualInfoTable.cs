using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class GachaVisualInfoTable : IMessage<GachaVisualInfoTable>, IMessage, IEquatable<GachaVisualInfoTable>, IDeepCloneable<GachaVisualInfoTable>, IBufferMessage
{
	private static readonly MessageParser<GachaVisualInfoTable> _parser = new MessageParser<GachaVisualInfoTable>(() => new GachaVisualInfoTable());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int MerchantIlustNameFieldNumber = 2;

	private string merchantIlustName_ = "";

	public const int MerchantNameTextIDFieldNumber = 3;

	private int merchantNameTextID_;

	public const int MerchantTalkTextIDFieldNumber = 4;

	private int merchantTalkTextID_;

	public const int TypeFieldNumber = 5;

	private int type_;

	public const int VoiceResourceNameFieldNumber = 6;

	private string voiceResourceName_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GachaVisualInfoTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => GachaVisualInfoTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public string MerchantIlustName
	{
		get
		{
			return merchantIlustName_;
		}
		set
		{
			merchantIlustName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MerchantNameTextID
	{
		get
		{
			return merchantNameTextID_;
		}
		set
		{
			merchantNameTextID_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MerchantTalkTextID
	{
		get
		{
			return merchantTalkTextID_;
		}
		set
		{
			merchantTalkTextID_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string VoiceResourceName
	{
		get
		{
			return voiceResourceName_;
		}
		set
		{
			voiceResourceName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaVisualInfoTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaVisualInfoTable(GachaVisualInfoTable other)
		: this()
	{
		id_ = other.id_;
		merchantIlustName_ = other.merchantIlustName_;
		merchantNameTextID_ = other.merchantNameTextID_;
		merchantTalkTextID_ = other.merchantTalkTextID_;
		type_ = other.type_;
		voiceResourceName_ = other.voiceResourceName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GachaVisualInfoTable Clone()
	{
		return new GachaVisualInfoTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as GachaVisualInfoTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GachaVisualInfoTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && !(MerchantIlustName != other.MerchantIlustName) && MerchantNameTextID == other.MerchantNameTextID && MerchantTalkTextID == other.MerchantTalkTextID && Type == other.Type && !(VoiceResourceName != other.VoiceResourceName))
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
		if (MerchantIlustName.Length != 0)
		{
			num ^= MerchantIlustName.GetHashCode();
		}
		if (MerchantNameTextID != 0)
		{
			num ^= MerchantNameTextID.GetHashCode();
		}
		if (MerchantTalkTextID != 0)
		{
			num ^= MerchantTalkTextID.GetHashCode();
		}
		if (Type != 0)
		{
			num ^= Type.GetHashCode();
		}
		if (VoiceResourceName.Length != 0)
		{
			num ^= VoiceResourceName.GetHashCode();
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
		if (MerchantIlustName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(MerchantIlustName);
		}
		if (MerchantNameTextID != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(MerchantNameTextID);
		}
		if (MerchantTalkTextID != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(MerchantTalkTextID);
		}
		if (Type != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Type);
		}
		if (VoiceResourceName.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(VoiceResourceName);
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
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (MerchantIlustName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MerchantIlustName);
		}
		if (MerchantNameTextID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MerchantNameTextID);
		}
		if (MerchantTalkTextID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MerchantTalkTextID);
		}
		if (Type != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Type);
		}
		if (VoiceResourceName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(VoiceResourceName);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GachaVisualInfoTable other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.MerchantIlustName.Length != 0)
			{
				MerchantIlustName = other.MerchantIlustName;
			}
			if (other.MerchantNameTextID != 0)
			{
				MerchantNameTextID = other.MerchantNameTextID;
			}
			if (other.MerchantTalkTextID != 0)
			{
				MerchantTalkTextID = other.MerchantTalkTextID;
			}
			if (other.Type != 0)
			{
				Type = other.Type;
			}
			if (other.VoiceResourceName.Length != 0)
			{
				VoiceResourceName = other.VoiceResourceName;
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
				MerchantIlustName = input.ReadString();
				break;
			case 24u:
				MerchantNameTextID = input.ReadInt32();
				break;
			case 32u:
				MerchantTalkTextID = input.ReadInt32();
				break;
			case 40u:
				Type = input.ReadInt32();
				break;
			case 50u:
				VoiceResourceName = input.ReadString();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
