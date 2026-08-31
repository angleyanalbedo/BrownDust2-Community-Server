using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class CommonSoundTable : IMessage<CommonSoundTable>, IMessage, IEquatable<CommonSoundTable>, IDeepCloneable<CommonSoundTable>, IBufferMessage
{
	private static readonly MessageParser<CommonSoundTable> _parser = new MessageParser<CommonSoundTable>(() => new CommonSoundTable());

	private UnknownFieldSet _unknownFields;

	public const int BgmPlayerHiddenFieldNumber = 1;

	private int bgmPlayerHidden_;

	public const int ContentTicketIdFieldNumber = 2;

	private int contentTicketId_;

	public const int IdFieldNumber = 3;

	private int id_;

	public const int PackIdFieldNumber = 4;

	private int packId_;

	public const int SortIdFieldNumber = 5;

	private int sortId_;

	public const int SoundNameTextIdFieldNumber = 6;

	private int soundNameTextId_;

	public const int SoundPathFieldNumber = 7;

	private string soundPath_ = "";

	public const int SoundSourceNameTextIdFieldNumber = 8;

	private int soundSourceNameTextId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CommonSoundTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => CommonSoundTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BgmPlayerHidden
	{
		get
		{
			return bgmPlayerHidden_;
		}
		set
		{
			bgmPlayerHidden_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ContentTicketId
	{
		get
		{
			return contentTicketId_;
		}
		set
		{
			contentTicketId_ = value;
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
	public int SortId
	{
		get
		{
			return sortId_;
		}
		set
		{
			sortId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SoundNameTextId
	{
		get
		{
			return soundNameTextId_;
		}
		set
		{
			soundNameTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string SoundPath
	{
		get
		{
			return soundPath_;
		}
		set
		{
			soundPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SoundSourceNameTextId
	{
		get
		{
			return soundSourceNameTextId_;
		}
		set
		{
			soundSourceNameTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CommonSoundTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CommonSoundTable(CommonSoundTable other)
		: this()
	{
		bgmPlayerHidden_ = other.bgmPlayerHidden_;
		contentTicketId_ = other.contentTicketId_;
		id_ = other.id_;
		packId_ = other.packId_;
		sortId_ = other.sortId_;
		soundNameTextId_ = other.soundNameTextId_;
		soundPath_ = other.soundPath_;
		soundSourceNameTextId_ = other.soundSourceNameTextId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CommonSoundTable Clone()
	{
		return new CommonSoundTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CommonSoundTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CommonSoundTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (BgmPlayerHidden == other.BgmPlayerHidden && ContentTicketId == other.ContentTicketId && Id == other.Id && PackId == other.PackId && SortId == other.SortId && SoundNameTextId == other.SoundNameTextId && !(SoundPath != other.SoundPath) && SoundSourceNameTextId == other.SoundSourceNameTextId)
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
		if (BgmPlayerHidden != 0)
		{
			num ^= BgmPlayerHidden.GetHashCode();
		}
		if (ContentTicketId != 0)
		{
			num ^= ContentTicketId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (PackId != 0)
		{
			num ^= PackId.GetHashCode();
		}
		if (SortId != 0)
		{
			num ^= SortId.GetHashCode();
		}
		if (SoundNameTextId != 0)
		{
			num ^= SoundNameTextId.GetHashCode();
		}
		if (SoundPath.Length != 0)
		{
			num ^= SoundPath.GetHashCode();
		}
		if (SoundSourceNameTextId != 0)
		{
			num ^= SoundSourceNameTextId.GetHashCode();
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
		if (BgmPlayerHidden != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BgmPlayerHidden);
		}
		if (ContentTicketId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ContentTicketId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Id);
		}
		if (PackId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(PackId);
		}
		if (SortId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(SortId);
		}
		if (SoundNameTextId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(SoundNameTextId);
		}
		if (SoundPath.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(SoundPath);
		}
		if (SoundSourceNameTextId != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(SoundSourceNameTextId);
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
		if (BgmPlayerHidden != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BgmPlayerHidden);
		}
		if (ContentTicketId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ContentTicketId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (PackId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PackId);
		}
		if (SortId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SortId);
		}
		if (SoundNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SoundNameTextId);
		}
		if (SoundPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SoundPath);
		}
		if (SoundSourceNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SoundSourceNameTextId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CommonSoundTable other)
	{
		if (other != null)
		{
			if (other.BgmPlayerHidden != 0)
			{
				BgmPlayerHidden = other.BgmPlayerHidden;
			}
			if (other.ContentTicketId != 0)
			{
				ContentTicketId = other.ContentTicketId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.PackId != 0)
			{
				PackId = other.PackId;
			}
			if (other.SortId != 0)
			{
				SortId = other.SortId;
			}
			if (other.SoundNameTextId != 0)
			{
				SoundNameTextId = other.SoundNameTextId;
			}
			if (other.SoundPath.Length != 0)
			{
				SoundPath = other.SoundPath;
			}
			if (other.SoundSourceNameTextId != 0)
			{
				SoundSourceNameTextId = other.SoundSourceNameTextId;
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
				BgmPlayerHidden = input.ReadInt32();
				break;
			case 16u:
				ContentTicketId = input.ReadInt32();
				break;
			case 24u:
				Id = input.ReadInt32();
				break;
			case 32u:
				PackId = input.ReadInt32();
				break;
			case 40u:
				SortId = input.ReadInt32();
				break;
			case 48u:
				SoundNameTextId = input.ReadInt32();
				break;
			case 58u:
				SoundPath = input.ReadString();
				break;
			case 64u:
				SoundSourceNameTextId = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
