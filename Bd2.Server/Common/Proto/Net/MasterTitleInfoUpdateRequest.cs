using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MasterTitleInfoUpdateRequest : IMessage<MasterTitleInfoUpdateRequest>, IMessage, IEquatable<MasterTitleInfoUpdateRequest>, IDeepCloneable<MasterTitleInfoUpdateRequest>, IBufferMessage
{
	private static readonly MessageParser<MasterTitleInfoUpdateRequest> _parser = new MessageParser<MasterTitleInfoUpdateRequest>(() => new MasterTitleInfoUpdateRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;
	private int seq_;
	public const int NameFieldNumber = 2;
	private string name_ = "";
	public const int MonthFieldNumber = 3;
	private int month_;
	public const int DayFieldNumber = 4;
	private int day_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MasterTitleInfoUpdateRequest> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MasterTitleInfoUpdateRequestReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Seq
	{
		get => seq_;
		set => seq_ = value;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name
	{
		get => name_;
		set => name_ = ProtoPreconditions.CheckNotNull(value, "value");
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Month
	{
		get => month_;
		set => month_ = value;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Day
	{
		get => day_;
		set => day_ = value;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MasterTitleInfoUpdateRequest() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MasterTitleInfoUpdateRequest(MasterTitleInfoUpdateRequest other) : this()
	{
		seq_ = other.seq_;
		name_ = other.name_;
		month_ = other.month_;
		day_ = other.day_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MasterTitleInfoUpdateRequest Clone() => new(this);

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other) => Equals(other as MasterTitleInfoUpdateRequest);

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MasterTitleInfoUpdateRequest other) =>
		other != null && (ReferenceEquals(other, this) ||
		(Seq == other.Seq && Name == other.Name && Month == other.Month && Day == other.Day &&
		object.Equals(_unknownFields, other._unknownFields)));

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (Seq != 0) num ^= Seq.GetHashCode();
		if (Name.Length != 0) num ^= Name.GetHashCode();
		if (Month != 0) num ^= Month.GetHashCode();
		if (Day != 0) num ^= Day.GetHashCode();
		if (_unknownFields != null) num ^= _unknownFields.GetHashCode();
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString() => JsonFormatter.ToDiagnosticString(this);

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output) => output.WriteRawMessage(this);

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (Seq != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Seq);
		}
		if (Name.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Name);
		}
		if (Month != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Month);
		}
		if (Day != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Day);
		}
		_unknownFields?.WriteTo(ref output);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (Seq != 0) num += 1 + CodedOutputStream.ComputeInt32Size(Seq);
		if (Name.Length != 0) num += 1 + CodedOutputStream.ComputeStringSize(Name);
		if (Month != 0) num += 1 + CodedOutputStream.ComputeInt32Size(Month);
		if (Day != 0) num += 1 + CodedOutputStream.ComputeInt32Size(Day);
		if (_unknownFields != null) num += _unknownFields.CalculateSize();
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MasterTitleInfoUpdateRequest other)
	{
		if (other == null) return;
		if (other.Seq != 0) Seq = other.Seq;
		if (other.Name.Length != 0) Name = other.Name;
		if (other.Month != 0) Month = other.Month;
		if (other.Day != 0) Day = other.Day;
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input) => input.ReadRawMessage(this);

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint tag;
		while ((tag = input.ReadTag()) != 0)
		{
			switch (tag)
			{
				case 8: Seq = input.ReadInt32(); break;
				case 18: Name = input.ReadString(); break;
				case 24: Month = input.ReadInt32(); break;
				case 32: Day = input.ReadInt32(); break;
				default: _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input); break;
			}
		}
	}
}
