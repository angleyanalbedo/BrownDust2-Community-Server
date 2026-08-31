using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class WaypointUseRequest : IMessage<WaypointUseRequest>, IMessage, IEquatable<WaypointUseRequest>, IDeepCloneable<WaypointUseRequest>, IBufferMessage
{
	private static readonly MessageParser<WaypointUseRequest> _parser = new MessageParser<WaypointUseRequest>(() => new WaypointUseRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int PackIdFieldNumber = 2;

	private int packId_;

	public const int StartWaypointIdFieldNumber = 3;

	private int startWaypointId_;

	public const int EndWaypointIdFieldNumber = 4;

	private int endWaypointId_;

	public const int MovePointFieldNumber = 5;

	private int movePoint_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<WaypointUseRequest> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => WaypointUseRequestReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Seq
	{
		get
		{
			return seq_;
		}
		set
		{
			seq_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PackId
	{
		get
		{
			return packId_;
		}
		set
		{
			packId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int StartWaypointId
	{
		get
		{
			return startWaypointId_;
		}
		set
		{
			startWaypointId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EndWaypointId
	{
		get
		{
			return endWaypointId_;
		}
		set
		{
			endWaypointId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MovePoint
	{
		get
		{
			return movePoint_;
		}
		set
		{
			movePoint_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public WaypointUseRequest()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public WaypointUseRequest(WaypointUseRequest other)
		: this()
	{
		seq_ = other.seq_;
		packId_ = other.packId_;
		startWaypointId_ = other.startWaypointId_;
		endWaypointId_ = other.endWaypointId_;
		movePoint_ = other.movePoint_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public WaypointUseRequest Clone()
	{
		return new WaypointUseRequest(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as WaypointUseRequest);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(WaypointUseRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && PackId == other.PackId && StartWaypointId == other.StartWaypointId && EndWaypointId == other.EndWaypointId && MovePoint == other.MovePoint)
				{
					return object.Equals(_unknownFields, other._unknownFields);
				}
				return false;
			}
			return true;
		}
		return false;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (Seq != 0)
		{
			num ^= Seq.GetHashCode();
		}
		if (PackId != 0)
		{
			num ^= PackId.GetHashCode();
		}
		if (StartWaypointId != 0)
		{
			num ^= StartWaypointId.GetHashCode();
		}
		if (EndWaypointId != 0)
		{
			num ^= EndWaypointId.GetHashCode();
		}
		if (MovePoint != 0)
		{
			num ^= MovePoint.GetHashCode();
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
		if (Seq != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Seq);
		}
		if (PackId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(PackId);
		}
		if (StartWaypointId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(StartWaypointId);
		}
		if (EndWaypointId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(EndWaypointId);
		}
		if (MovePoint != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(MovePoint);
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
		if (Seq != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Seq);
		}
		if (PackId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PackId);
		}
		if (StartWaypointId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StartWaypointId);
		}
		if (EndWaypointId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EndWaypointId);
		}
		if (MovePoint != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MovePoint);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(WaypointUseRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			if (other.PackId != 0)
			{
				PackId = other.PackId;
			}
			if (other.StartWaypointId != 0)
			{
				StartWaypointId = other.StartWaypointId;
			}
			if (other.EndWaypointId != 0)
			{
				EndWaypointId = other.EndWaypointId;
			}
			if (other.MovePoint != 0)
			{
				MovePoint = other.MovePoint;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
			case 8u:
				Seq = input.ReadInt32();
				break;
			case 16u:
				PackId = input.ReadInt32();
				break;
			case 24u:
				StartWaypointId = input.ReadInt32();
				break;
			case 32u:
				EndWaypointId = input.ReadInt32();
				break;
			case 40u:
				MovePoint = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
