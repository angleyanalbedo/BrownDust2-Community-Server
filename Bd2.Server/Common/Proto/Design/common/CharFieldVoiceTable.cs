using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class CharFieldVoiceTable : IMessage<CharFieldVoiceTable>, IMessage, IEquatable<CharFieldVoiceTable>, IDeepCloneable<CharFieldVoiceTable>, IBufferMessage
{
	private static readonly MessageParser<CharFieldVoiceTable> _parser = new MessageParser<CharFieldVoiceTable>(() => new CharFieldVoiceTable());

	private UnknownFieldSet _unknownFields;

	public const int DamageVoiceNameFieldNumber = 1;

	private string damageVoiceName_ = "";

	public const int DashVoiceNameFieldNumber = 2;

	private string dashVoiceName_ = "";

	public const int IdFieldNumber = 3;

	private int id_;

	public const int LiftVoiceNameFieldNumber = 4;

	private string liftVoiceName_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CharFieldVoiceTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CharFieldVoiceTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string DamageVoiceName
	{
		get
		{
			return damageVoiceName_;
		}
		set
		{
			damageVoiceName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string DashVoiceName
	{
		get
		{
			return dashVoiceName_;
		}
		set
		{
			dashVoiceName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

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
	public string LiftVoiceName
	{
		get
		{
			return liftVoiceName_;
		}
		set
		{
			liftVoiceName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharFieldVoiceTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharFieldVoiceTable(CharFieldVoiceTable other)
		: this()
	{
		damageVoiceName_ = other.damageVoiceName_;
		dashVoiceName_ = other.dashVoiceName_;
		id_ = other.id_;
		liftVoiceName_ = other.liftVoiceName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharFieldVoiceTable Clone()
	{
		return new CharFieldVoiceTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as CharFieldVoiceTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CharFieldVoiceTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (!(DamageVoiceName != other.DamageVoiceName) && !(DashVoiceName != other.DashVoiceName) && Id == other.Id && !(LiftVoiceName != other.LiftVoiceName))
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
		if (DamageVoiceName.Length != 0)
		{
			num ^= DamageVoiceName.GetHashCode();
		}
		if (DashVoiceName.Length != 0)
		{
			num ^= DashVoiceName.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (LiftVoiceName.Length != 0)
		{
			num ^= LiftVoiceName.GetHashCode();
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
		if (DamageVoiceName.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(DamageVoiceName);
		}
		if (DashVoiceName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(DashVoiceName);
		}
		if (Id != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Id);
		}
		if (LiftVoiceName.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(LiftVoiceName);
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
		if (DamageVoiceName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DamageVoiceName);
		}
		if (DashVoiceName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DashVoiceName);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (LiftVoiceName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LiftVoiceName);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharFieldVoiceTable other)
	{
		if (other != null)
		{
			if (other.DamageVoiceName.Length != 0)
			{
				DamageVoiceName = other.DamageVoiceName;
			}
			if (other.DashVoiceName.Length != 0)
			{
				DashVoiceName = other.DashVoiceName;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.LiftVoiceName.Length != 0)
			{
				LiftVoiceName = other.LiftVoiceName;
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
				DamageVoiceName = input.ReadString();
				break;
			case 18u:
				DashVoiceName = input.ReadString();
				break;
			case 24u:
				Id = input.ReadInt32();
				break;
			case 34u:
				LiftVoiceName = input.ReadString();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
