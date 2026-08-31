using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MasterTitleInfoUpdateResponse : IMessage<MasterTitleInfoUpdateResponse>, IMessage, IEquatable<MasterTitleInfoUpdateResponse>, IDeepCloneable<MasterTitleInfoUpdateResponse>, IBufferMessage
{
	private static readonly MessageParser<MasterTitleInfoUpdateResponse> _parser = new(() => new MasterTitleInfoUpdateResponse());

	private UnknownFieldSet _unknownFields;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MasterTitleInfoUpdateResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MasterTitleInfoUpdateResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MasterTitleInfoUpdateResponse() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MasterTitleInfoUpdateResponse(MasterTitleInfoUpdateResponse other) : this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MasterTitleInfoUpdateResponse Clone() => new(this);

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other) => Equals(other as MasterTitleInfoUpdateResponse);

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MasterTitleInfoUpdateResponse other) =>
		other != null && (ReferenceEquals(other, this) || object.Equals(_unknownFields, other._unknownFields));

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
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
		_unknownFields?.WriteTo(ref output);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (_unknownFields != null) num += _unknownFields.CalculateSize();
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MasterTitleInfoUpdateResponse other)
	{
		if (other == null) return;
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input) => input.ReadRawMessage(this);

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		while (input.ReadTag() != 0)
		{
			_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
		}
	}
}
