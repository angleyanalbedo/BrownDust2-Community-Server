using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class ClearDataTable : IMessage<ClearDataTable>, IMessage, IEquatable<ClearDataTable>, IDeepCloneable<ClearDataTable>, IBufferMessage
{
	private static readonly MessageParser<ClearDataTable> _parser = new MessageParser<ClearDataTable>(() => new ClearDataTable());

	private UnknownFieldSet _unknownFields;

	public const int DeleteCostumeIDFieldNumber = 1;

	private static readonly FieldCodec<int> _repeated_deleteCostumeID_codec = FieldCodec.ForInt32(10u);

	private readonly RepeatedField<int> deleteCostumeID_ = new RepeatedField<int>();

	public const int DeletePackIDFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_deletePackID_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> deletePackID_ = new RepeatedField<int>();

	public const int IdFieldNumber = 3;

	private int id_;

	public const int VersionFieldNumber = 4;

	private string version_ = "";

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ClearDataTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => ClearDataTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> DeleteCostumeID => deleteCostumeID_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> DeletePackID => deletePackID_;

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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Version
	{
		get
		{
			return version_;
		}
		set
		{
			version_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ClearDataTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClearDataTable(ClearDataTable other)
		: this()
	{
		deleteCostumeID_ = other.deleteCostumeID_.Clone();
		deletePackID_ = other.deletePackID_.Clone();
		id_ = other.id_;
		version_ = other.version_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClearDataTable Clone()
	{
		return new ClearDataTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ClearDataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ClearDataTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (deleteCostumeID_.Equals(other.deleteCostumeID_) && deletePackID_.Equals(other.deletePackID_) && Id == other.Id && !(Version != other.Version))
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
		num ^= deleteCostumeID_.GetHashCode();
		num ^= deletePackID_.GetHashCode();
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (Version.Length != 0)
		{
			num ^= Version.GetHashCode();
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
		deleteCostumeID_.WriteTo(ref output, _repeated_deleteCostumeID_codec);
		deletePackID_.WriteTo(ref output, _repeated_deletePackID_codec);
		if (Id != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Id);
		}
		if (Version.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(Version);
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
		num += deleteCostumeID_.CalculateSize(_repeated_deleteCostumeID_codec);
		num += deletePackID_.CalculateSize(_repeated_deletePackID_codec);
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (Version.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Version);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ClearDataTable other)
	{
		if (other != null)
		{
			deleteCostumeID_.Add(other.deleteCostumeID_);
			deletePackID_.Add(other.deletePackID_);
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Version.Length != 0)
			{
				Version = other.Version;
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
			case 10u:
				deleteCostumeID_.AddEntriesFrom(ref input, _repeated_deleteCostumeID_codec);
				break;
			case 24u:
				Id = input.ReadInt32();
				break;
			case 34u:
				Version = input.ReadString();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 16u:
			case 18u:
				deletePackID_.AddEntriesFrom(ref input, _repeated_deletePackID_codec);
				break;
			}
		}
	}
}
