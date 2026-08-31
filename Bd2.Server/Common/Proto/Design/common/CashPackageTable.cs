using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class CashPackageTable : IMessage<CashPackageTable>, IMessage, IEquatable<CashPackageTable>, IDeepCloneable<CashPackageTable>, IBufferMessage
{
	private static readonly MessageParser<CashPackageTable> _parser = new MessageParser<CashPackageTable>(() => new CashPackageTable());

	private UnknownFieldSet _unknownFields;

	public const int BannerFontLocalTextIdFieldNumber = 1;

	private int bannerFontLocalTextId_;

	public const int CategoryResourceNameFieldNumber = 2;

	private string categoryResourceName_ = "";

	public const int ContentsGroupIdFieldNumber = 3;

	private int contentsGroupId_;

	public const int ContentsLocalTextIdFieldNumber = 4;

	private int contentsLocalTextId_;

	public const int ContentsResourceNameFieldNumber = 5;

	private string contentsResourceName_ = "";

	public const int ContentsSortIdFieldNumber = 6;

	private int contentsSortId_;

	public const int GroupIdFieldNumber = 7;

	private int groupId_;

	public const int IdFieldNumber = 8;

	private int id_;

	public const int IsActiveOnEnterFieldNumber = 9;

	private int isActiveOnEnter_;

	public const int PackageTypeFieldNumber = 10;

	private int packageType_;

	public const int PriorityFieldNumber = 11;

	private int priority_;

	public const int ResourceNameFieldNumber = 12;

	private string resourceName_ = "";

	public const int SaleGroupFieldNumber = 13;

	private int saleGroup_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CashPackageTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => CashPackageTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BannerFontLocalTextId
	{
		get
		{
			return bannerFontLocalTextId_;
		}
		set
		{
			bannerFontLocalTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string CategoryResourceName
	{
		get
		{
			return categoryResourceName_;
		}
		set
		{
			categoryResourceName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ContentsGroupId
	{
		get
		{
			return contentsGroupId_;
		}
		set
		{
			contentsGroupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ContentsLocalTextId
	{
		get
		{
			return contentsLocalTextId_;
		}
		set
		{
			contentsLocalTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string ContentsResourceName
	{
		get
		{
			return contentsResourceName_;
		}
		set
		{
			contentsResourceName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ContentsSortId
	{
		get
		{
			return contentsSortId_;
		}
		set
		{
			contentsSortId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
		}
	}

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
	public int IsActiveOnEnter
	{
		get
		{
			return isActiveOnEnter_;
		}
		set
		{
			isActiveOnEnter_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PackageType
	{
		get
		{
			return packageType_;
		}
		set
		{
			packageType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Priority
	{
		get
		{
			return priority_;
		}
		set
		{
			priority_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string ResourceName
	{
		get
		{
			return resourceName_;
		}
		set
		{
			resourceName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SaleGroup
	{
		get
		{
			return saleGroup_;
		}
		set
		{
			saleGroup_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CashPackageTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CashPackageTable(CashPackageTable other)
		: this()
	{
		bannerFontLocalTextId_ = other.bannerFontLocalTextId_;
		categoryResourceName_ = other.categoryResourceName_;
		contentsGroupId_ = other.contentsGroupId_;
		contentsLocalTextId_ = other.contentsLocalTextId_;
		contentsResourceName_ = other.contentsResourceName_;
		contentsSortId_ = other.contentsSortId_;
		groupId_ = other.groupId_;
		id_ = other.id_;
		isActiveOnEnter_ = other.isActiveOnEnter_;
		packageType_ = other.packageType_;
		priority_ = other.priority_;
		resourceName_ = other.resourceName_;
		saleGroup_ = other.saleGroup_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CashPackageTable Clone()
	{
		return new CashPackageTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CashPackageTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CashPackageTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (BannerFontLocalTextId == other.BannerFontLocalTextId && !(CategoryResourceName != other.CategoryResourceName) && ContentsGroupId == other.ContentsGroupId && ContentsLocalTextId == other.ContentsLocalTextId && !(ContentsResourceName != other.ContentsResourceName) && ContentsSortId == other.ContentsSortId && GroupId == other.GroupId && Id == other.Id && IsActiveOnEnter == other.IsActiveOnEnter && PackageType == other.PackageType && Priority == other.Priority && !(ResourceName != other.ResourceName) && SaleGroup == other.SaleGroup)
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
		if (BannerFontLocalTextId != 0)
		{
			num ^= BannerFontLocalTextId.GetHashCode();
		}
		if (CategoryResourceName.Length != 0)
		{
			num ^= CategoryResourceName.GetHashCode();
		}
		if (ContentsGroupId != 0)
		{
			num ^= ContentsGroupId.GetHashCode();
		}
		if (ContentsLocalTextId != 0)
		{
			num ^= ContentsLocalTextId.GetHashCode();
		}
		if (ContentsResourceName.Length != 0)
		{
			num ^= ContentsResourceName.GetHashCode();
		}
		if (ContentsSortId != 0)
		{
			num ^= ContentsSortId.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (IsActiveOnEnter != 0)
		{
			num ^= IsActiveOnEnter.GetHashCode();
		}
		if (PackageType != 0)
		{
			num ^= PackageType.GetHashCode();
		}
		if (Priority != 0)
		{
			num ^= Priority.GetHashCode();
		}
		if (ResourceName.Length != 0)
		{
			num ^= ResourceName.GetHashCode();
		}
		if (SaleGroup != 0)
		{
			num ^= SaleGroup.GetHashCode();
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
		if (BannerFontLocalTextId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BannerFontLocalTextId);
		}
		if (CategoryResourceName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(CategoryResourceName);
		}
		if (ContentsGroupId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ContentsGroupId);
		}
		if (ContentsLocalTextId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ContentsLocalTextId);
		}
		if (ContentsResourceName.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(ContentsResourceName);
		}
		if (ContentsSortId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(ContentsSortId);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(GroupId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(Id);
		}
		if (IsActiveOnEnter != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(IsActiveOnEnter);
		}
		if (PackageType != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(PackageType);
		}
		if (Priority != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(Priority);
		}
		if (ResourceName.Length != 0)
		{
			output.WriteRawTag(98);
			output.WriteString(ResourceName);
		}
		if (SaleGroup != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(SaleGroup);
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
		if (BannerFontLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BannerFontLocalTextId);
		}
		if (CategoryResourceName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(CategoryResourceName);
		}
		if (ContentsGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ContentsGroupId);
		}
		if (ContentsLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ContentsLocalTextId);
		}
		if (ContentsResourceName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ContentsResourceName);
		}
		if (ContentsSortId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ContentsSortId);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (IsActiveOnEnter != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IsActiveOnEnter);
		}
		if (PackageType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PackageType);
		}
		if (Priority != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Priority);
		}
		if (ResourceName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ResourceName);
		}
		if (SaleGroup != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SaleGroup);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CashPackageTable other)
	{
		if (other != null)
		{
			if (other.BannerFontLocalTextId != 0)
			{
				BannerFontLocalTextId = other.BannerFontLocalTextId;
			}
			if (other.CategoryResourceName.Length != 0)
			{
				CategoryResourceName = other.CategoryResourceName;
			}
			if (other.ContentsGroupId != 0)
			{
				ContentsGroupId = other.ContentsGroupId;
			}
			if (other.ContentsLocalTextId != 0)
			{
				ContentsLocalTextId = other.ContentsLocalTextId;
			}
			if (other.ContentsResourceName.Length != 0)
			{
				ContentsResourceName = other.ContentsResourceName;
			}
			if (other.ContentsSortId != 0)
			{
				ContentsSortId = other.ContentsSortId;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.IsActiveOnEnter != 0)
			{
				IsActiveOnEnter = other.IsActiveOnEnter;
			}
			if (other.PackageType != 0)
			{
				PackageType = other.PackageType;
			}
			if (other.Priority != 0)
			{
				Priority = other.Priority;
			}
			if (other.ResourceName.Length != 0)
			{
				ResourceName = other.ResourceName;
			}
			if (other.SaleGroup != 0)
			{
				SaleGroup = other.SaleGroup;
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
				BannerFontLocalTextId = input.ReadInt32();
				break;
			case 18u:
				CategoryResourceName = input.ReadString();
				break;
			case 24u:
				ContentsGroupId = input.ReadInt32();
				break;
			case 32u:
				ContentsLocalTextId = input.ReadInt32();
				break;
			case 42u:
				ContentsResourceName = input.ReadString();
				break;
			case 48u:
				ContentsSortId = input.ReadInt32();
				break;
			case 56u:
				GroupId = input.ReadInt32();
				break;
			case 64u:
				Id = input.ReadInt32();
				break;
			case 72u:
				IsActiveOnEnter = input.ReadInt32();
				break;
			case 80u:
				PackageType = input.ReadInt32();
				break;
			case 88u:
				Priority = input.ReadInt32();
				break;
			case 98u:
				ResourceName = input.ReadString();
				break;
			case 104u:
				SaleGroup = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
