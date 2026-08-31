using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class CommunityWebLinkTable : IMessage<CommunityWebLinkTable>, IMessage, IEquatable<CommunityWebLinkTable>, IDeepCloneable<CommunityWebLinkTable>, IBufferMessage
{
	private static readonly MessageParser<CommunityWebLinkTable> _parser = new MessageParser<CommunityWebLinkTable>(() => new CommunityWebLinkTable());

	private UnknownFieldSet _unknownFields;

	public const int CommunityRewardCountFieldNumber = 1;

	private static readonly FieldCodec<int> _repeated_communityRewardCount_codec = FieldCodec.ForInt32(10u);

	private readonly RepeatedField<int> communityRewardCount_ = new RepeatedField<int>();

	public const int CommunityRewardIdFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_communityRewardId_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> communityRewardId_ = new RepeatedField<int>();

	public const int CommunityRewardTypeFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_communityRewardType_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> communityRewardType_ = new RepeatedField<int>();

	public const int IdFieldNumber = 4;

	private int id_;

	public const int LinkIconCn1FieldNumber = 5;

	private string linkIconCn1_ = "";

	public const int LinkIconCn2FieldNumber = 6;

	private string linkIconCn2_ = "";

	public const int LinkIconCn3FieldNumber = 7;

	private string linkIconCn3_ = "";

	public const int LinkIconEn1FieldNumber = 8;

	private string linkIconEn1_ = "";

	public const int LinkIconEn2FieldNumber = 9;

	private string linkIconEn2_ = "";

	public const int LinkIconEn3FieldNumber = 10;

	private string linkIconEn3_ = "";

	public const int LinkIconJp1FieldNumber = 11;

	private string linkIconJp1_ = "";

	public const int LinkIconJp2FieldNumber = 12;

	private string linkIconJp2_ = "";

	public const int LinkIconJp3FieldNumber = 13;

	private string linkIconJp3_ = "";

	public const int LinkIconKr1FieldNumber = 14;

	private string linkIconKr1_ = "";

	public const int LinkIconKr2FieldNumber = 15;

	private string linkIconKr2_ = "";

	public const int LinkIconKr3FieldNumber = 16;

	private string linkIconKr3_ = "";

	public const int LinkIconTw1FieldNumber = 17;

	private string linkIconTw1_ = "";

	public const int LinkIconTw2FieldNumber = 18;

	private string linkIconTw2_ = "";

	public const int LinkIconTw3FieldNumber = 19;

	private string linkIconTw3_ = "";

	public const int LinkUrlPathCn1FieldNumber = 20;

	private string linkUrlPathCn1_ = "";

	public const int LinkUrlPathCn2FieldNumber = 21;

	private string linkUrlPathCn2_ = "";

	public const int LinkUrlPathCn3FieldNumber = 22;

	private string linkUrlPathCn3_ = "";

	public const int LinkUrlPathEn1FieldNumber = 23;

	private string linkUrlPathEn1_ = "";

	public const int LinkUrlPathEn2FieldNumber = 24;

	private string linkUrlPathEn2_ = "";

	public const int LinkUrlPathEn3FieldNumber = 25;

	private string linkUrlPathEn3_ = "";

	public const int LinkUrlPathJp1FieldNumber = 26;

	private string linkUrlPathJp1_ = "";

	public const int LinkUrlPathJp2FieldNumber = 27;

	private string linkUrlPathJp2_ = "";

	public const int LinkUrlPathJp3FieldNumber = 28;

	private string linkUrlPathJp3_ = "";

	public const int LinkUrlPathKr1FieldNumber = 29;

	private string linkUrlPathKr1_ = "";

	public const int LinkUrlPathKr2FieldNumber = 30;

	private string linkUrlPathKr2_ = "";

	public const int LinkUrlPathKr3FieldNumber = 31;

	private string linkUrlPathKr3_ = "";

	public const int LinkUrlPathTw1FieldNumber = 32;

	private string linkUrlPathTw1_ = "";

	public const int LinkUrlPathTw2FieldNumber = 33;

	private string linkUrlPathTw2_ = "";

	public const int LinkUrlPathTw3FieldNumber = 34;

	private string linkUrlPathTw3_ = "";

	public const int SurveyRewardCountFieldNumber = 35;

	private static readonly FieldCodec<int> _repeated_surveyRewardCount_codec = FieldCodec.ForInt32(282u);

	private readonly RepeatedField<int> surveyRewardCount_ = new RepeatedField<int>();

	public const int SurveyRewardIdFieldNumber = 36;

	private static readonly FieldCodec<int> _repeated_surveyRewardId_codec = FieldCodec.ForInt32(290u);

	private readonly RepeatedField<int> surveyRewardId_ = new RepeatedField<int>();

	public const int SurveyRewardTypeFieldNumber = 37;

	private static readonly FieldCodec<int> _repeated_surveyRewardType_codec = FieldCodec.ForInt32(298u);

	private readonly RepeatedField<int> surveyRewardType_ = new RepeatedField<int>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CommunityWebLinkTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CommunityWebLinkTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> CommunityRewardCount => communityRewardCount_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> CommunityRewardId => communityRewardId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> CommunityRewardType => communityRewardType_;

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
	public string LinkIconCn1
	{
		get
		{
			return linkIconCn1_;
		}
		set
		{
			linkIconCn1_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string LinkIconCn2
	{
		get
		{
			return linkIconCn2_;
		}
		set
		{
			linkIconCn2_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string LinkIconCn3
	{
		get
		{
			return linkIconCn3_;
		}
		set
		{
			linkIconCn3_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string LinkIconEn1
	{
		get
		{
			return linkIconEn1_;
		}
		set
		{
			linkIconEn1_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string LinkIconEn2
	{
		get
		{
			return linkIconEn2_;
		}
		set
		{
			linkIconEn2_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string LinkIconEn3
	{
		get
		{
			return linkIconEn3_;
		}
		set
		{
			linkIconEn3_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string LinkIconJp1
	{
		get
		{
			return linkIconJp1_;
		}
		set
		{
			linkIconJp1_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string LinkIconJp2
	{
		get
		{
			return linkIconJp2_;
		}
		set
		{
			linkIconJp2_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string LinkIconJp3
	{
		get
		{
			return linkIconJp3_;
		}
		set
		{
			linkIconJp3_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string LinkIconKr1
	{
		get
		{
			return linkIconKr1_;
		}
		set
		{
			linkIconKr1_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string LinkIconKr2
	{
		get
		{
			return linkIconKr2_;
		}
		set
		{
			linkIconKr2_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string LinkIconKr3
	{
		get
		{
			return linkIconKr3_;
		}
		set
		{
			linkIconKr3_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string LinkIconTw1
	{
		get
		{
			return linkIconTw1_;
		}
		set
		{
			linkIconTw1_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string LinkIconTw2
	{
		get
		{
			return linkIconTw2_;
		}
		set
		{
			linkIconTw2_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string LinkIconTw3
	{
		get
		{
			return linkIconTw3_;
		}
		set
		{
			linkIconTw3_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string LinkUrlPathCn1
	{
		get
		{
			return linkUrlPathCn1_;
		}
		set
		{
			linkUrlPathCn1_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string LinkUrlPathCn2
	{
		get
		{
			return linkUrlPathCn2_;
		}
		set
		{
			linkUrlPathCn2_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string LinkUrlPathCn3
	{
		get
		{
			return linkUrlPathCn3_;
		}
		set
		{
			linkUrlPathCn3_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string LinkUrlPathEn1
	{
		get
		{
			return linkUrlPathEn1_;
		}
		set
		{
			linkUrlPathEn1_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string LinkUrlPathEn2
	{
		get
		{
			return linkUrlPathEn2_;
		}
		set
		{
			linkUrlPathEn2_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string LinkUrlPathEn3
	{
		get
		{
			return linkUrlPathEn3_;
		}
		set
		{
			linkUrlPathEn3_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string LinkUrlPathJp1
	{
		get
		{
			return linkUrlPathJp1_;
		}
		set
		{
			linkUrlPathJp1_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string LinkUrlPathJp2
	{
		get
		{
			return linkUrlPathJp2_;
		}
		set
		{
			linkUrlPathJp2_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string LinkUrlPathJp3
	{
		get
		{
			return linkUrlPathJp3_;
		}
		set
		{
			linkUrlPathJp3_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string LinkUrlPathKr1
	{
		get
		{
			return linkUrlPathKr1_;
		}
		set
		{
			linkUrlPathKr1_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string LinkUrlPathKr2
	{
		get
		{
			return linkUrlPathKr2_;
		}
		set
		{
			linkUrlPathKr2_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string LinkUrlPathKr3
	{
		get
		{
			return linkUrlPathKr3_;
		}
		set
		{
			linkUrlPathKr3_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string LinkUrlPathTw1
	{
		get
		{
			return linkUrlPathTw1_;
		}
		set
		{
			linkUrlPathTw1_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string LinkUrlPathTw2
	{
		get
		{
			return linkUrlPathTw2_;
		}
		set
		{
			linkUrlPathTw2_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string LinkUrlPathTw3
	{
		get
		{
			return linkUrlPathTw3_;
		}
		set
		{
			linkUrlPathTw3_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> SurveyRewardCount => surveyRewardCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> SurveyRewardId => surveyRewardId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> SurveyRewardType => surveyRewardType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CommunityWebLinkTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CommunityWebLinkTable(CommunityWebLinkTable other)
		: this()
	{
		communityRewardCount_ = other.communityRewardCount_.Clone();
		communityRewardId_ = other.communityRewardId_.Clone();
		communityRewardType_ = other.communityRewardType_.Clone();
		id_ = other.id_;
		linkIconCn1_ = other.linkIconCn1_;
		linkIconCn2_ = other.linkIconCn2_;
		linkIconCn3_ = other.linkIconCn3_;
		linkIconEn1_ = other.linkIconEn1_;
		linkIconEn2_ = other.linkIconEn2_;
		linkIconEn3_ = other.linkIconEn3_;
		linkIconJp1_ = other.linkIconJp1_;
		linkIconJp2_ = other.linkIconJp2_;
		linkIconJp3_ = other.linkIconJp3_;
		linkIconKr1_ = other.linkIconKr1_;
		linkIconKr2_ = other.linkIconKr2_;
		linkIconKr3_ = other.linkIconKr3_;
		linkIconTw1_ = other.linkIconTw1_;
		linkIconTw2_ = other.linkIconTw2_;
		linkIconTw3_ = other.linkIconTw3_;
		linkUrlPathCn1_ = other.linkUrlPathCn1_;
		linkUrlPathCn2_ = other.linkUrlPathCn2_;
		linkUrlPathCn3_ = other.linkUrlPathCn3_;
		linkUrlPathEn1_ = other.linkUrlPathEn1_;
		linkUrlPathEn2_ = other.linkUrlPathEn2_;
		linkUrlPathEn3_ = other.linkUrlPathEn3_;
		linkUrlPathJp1_ = other.linkUrlPathJp1_;
		linkUrlPathJp2_ = other.linkUrlPathJp2_;
		linkUrlPathJp3_ = other.linkUrlPathJp3_;
		linkUrlPathKr1_ = other.linkUrlPathKr1_;
		linkUrlPathKr2_ = other.linkUrlPathKr2_;
		linkUrlPathKr3_ = other.linkUrlPathKr3_;
		linkUrlPathTw1_ = other.linkUrlPathTw1_;
		linkUrlPathTw2_ = other.linkUrlPathTw2_;
		linkUrlPathTw3_ = other.linkUrlPathTw3_;
		surveyRewardCount_ = other.surveyRewardCount_.Clone();
		surveyRewardId_ = other.surveyRewardId_.Clone();
		surveyRewardType_ = other.surveyRewardType_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CommunityWebLinkTable Clone()
	{
		return new CommunityWebLinkTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as CommunityWebLinkTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CommunityWebLinkTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (communityRewardCount_.Equals(other.communityRewardCount_) && communityRewardId_.Equals(other.communityRewardId_) && communityRewardType_.Equals(other.communityRewardType_) && Id == other.Id && !(LinkIconCn1 != other.LinkIconCn1) && !(LinkIconCn2 != other.LinkIconCn2) && !(LinkIconCn3 != other.LinkIconCn3) && !(LinkIconEn1 != other.LinkIconEn1) && !(LinkIconEn2 != other.LinkIconEn2) && !(LinkIconEn3 != other.LinkIconEn3) && !(LinkIconJp1 != other.LinkIconJp1) && !(LinkIconJp2 != other.LinkIconJp2) && !(LinkIconJp3 != other.LinkIconJp3) && !(LinkIconKr1 != other.LinkIconKr1) && !(LinkIconKr2 != other.LinkIconKr2) && !(LinkIconKr3 != other.LinkIconKr3) && !(LinkIconTw1 != other.LinkIconTw1) && !(LinkIconTw2 != other.LinkIconTw2) && !(LinkIconTw3 != other.LinkIconTw3) && !(LinkUrlPathCn1 != other.LinkUrlPathCn1) && !(LinkUrlPathCn2 != other.LinkUrlPathCn2) && !(LinkUrlPathCn3 != other.LinkUrlPathCn3) && !(LinkUrlPathEn1 != other.LinkUrlPathEn1) && !(LinkUrlPathEn2 != other.LinkUrlPathEn2) && !(LinkUrlPathEn3 != other.LinkUrlPathEn3) && !(LinkUrlPathJp1 != other.LinkUrlPathJp1) && !(LinkUrlPathJp2 != other.LinkUrlPathJp2) && !(LinkUrlPathJp3 != other.LinkUrlPathJp3) && !(LinkUrlPathKr1 != other.LinkUrlPathKr1) && !(LinkUrlPathKr2 != other.LinkUrlPathKr2) && !(LinkUrlPathKr3 != other.LinkUrlPathKr3) && !(LinkUrlPathTw1 != other.LinkUrlPathTw1) && !(LinkUrlPathTw2 != other.LinkUrlPathTw2) && !(LinkUrlPathTw3 != other.LinkUrlPathTw3) && surveyRewardCount_.Equals(other.surveyRewardCount_) && surveyRewardId_.Equals(other.surveyRewardId_) && surveyRewardType_.Equals(other.surveyRewardType_))
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
		num ^= communityRewardCount_.GetHashCode();
		num ^= communityRewardId_.GetHashCode();
		num ^= communityRewardType_.GetHashCode();
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (LinkIconCn1.Length != 0)
		{
			num ^= LinkIconCn1.GetHashCode();
		}
		if (LinkIconCn2.Length != 0)
		{
			num ^= LinkIconCn2.GetHashCode();
		}
		if (LinkIconCn3.Length != 0)
		{
			num ^= LinkIconCn3.GetHashCode();
		}
		if (LinkIconEn1.Length != 0)
		{
			num ^= LinkIconEn1.GetHashCode();
		}
		if (LinkIconEn2.Length != 0)
		{
			num ^= LinkIconEn2.GetHashCode();
		}
		if (LinkIconEn3.Length != 0)
		{
			num ^= LinkIconEn3.GetHashCode();
		}
		if (LinkIconJp1.Length != 0)
		{
			num ^= LinkIconJp1.GetHashCode();
		}
		if (LinkIconJp2.Length != 0)
		{
			num ^= LinkIconJp2.GetHashCode();
		}
		if (LinkIconJp3.Length != 0)
		{
			num ^= LinkIconJp3.GetHashCode();
		}
		if (LinkIconKr1.Length != 0)
		{
			num ^= LinkIconKr1.GetHashCode();
		}
		if (LinkIconKr2.Length != 0)
		{
			num ^= LinkIconKr2.GetHashCode();
		}
		if (LinkIconKr3.Length != 0)
		{
			num ^= LinkIconKr3.GetHashCode();
		}
		if (LinkIconTw1.Length != 0)
		{
			num ^= LinkIconTw1.GetHashCode();
		}
		if (LinkIconTw2.Length != 0)
		{
			num ^= LinkIconTw2.GetHashCode();
		}
		if (LinkIconTw3.Length != 0)
		{
			num ^= LinkIconTw3.GetHashCode();
		}
		if (LinkUrlPathCn1.Length != 0)
		{
			num ^= LinkUrlPathCn1.GetHashCode();
		}
		if (LinkUrlPathCn2.Length != 0)
		{
			num ^= LinkUrlPathCn2.GetHashCode();
		}
		if (LinkUrlPathCn3.Length != 0)
		{
			num ^= LinkUrlPathCn3.GetHashCode();
		}
		if (LinkUrlPathEn1.Length != 0)
		{
			num ^= LinkUrlPathEn1.GetHashCode();
		}
		if (LinkUrlPathEn2.Length != 0)
		{
			num ^= LinkUrlPathEn2.GetHashCode();
		}
		if (LinkUrlPathEn3.Length != 0)
		{
			num ^= LinkUrlPathEn3.GetHashCode();
		}
		if (LinkUrlPathJp1.Length != 0)
		{
			num ^= LinkUrlPathJp1.GetHashCode();
		}
		if (LinkUrlPathJp2.Length != 0)
		{
			num ^= LinkUrlPathJp2.GetHashCode();
		}
		if (LinkUrlPathJp3.Length != 0)
		{
			num ^= LinkUrlPathJp3.GetHashCode();
		}
		if (LinkUrlPathKr1.Length != 0)
		{
			num ^= LinkUrlPathKr1.GetHashCode();
		}
		if (LinkUrlPathKr2.Length != 0)
		{
			num ^= LinkUrlPathKr2.GetHashCode();
		}
		if (LinkUrlPathKr3.Length != 0)
		{
			num ^= LinkUrlPathKr3.GetHashCode();
		}
		if (LinkUrlPathTw1.Length != 0)
		{
			num ^= LinkUrlPathTw1.GetHashCode();
		}
		if (LinkUrlPathTw2.Length != 0)
		{
			num ^= LinkUrlPathTw2.GetHashCode();
		}
		if (LinkUrlPathTw3.Length != 0)
		{
			num ^= LinkUrlPathTw3.GetHashCode();
		}
		num ^= surveyRewardCount_.GetHashCode();
		num ^= surveyRewardId_.GetHashCode();
		num ^= surveyRewardType_.GetHashCode();
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
		communityRewardCount_.WriteTo(ref output, _repeated_communityRewardCount_codec);
		communityRewardId_.WriteTo(ref output, _repeated_communityRewardId_codec);
		communityRewardType_.WriteTo(ref output, _repeated_communityRewardType_codec);
		if (Id != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Id);
		}
		if (LinkIconCn1.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(LinkIconCn1);
		}
		if (LinkIconCn2.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(LinkIconCn2);
		}
		if (LinkIconCn3.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(LinkIconCn3);
		}
		if (LinkIconEn1.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(LinkIconEn1);
		}
		if (LinkIconEn2.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(LinkIconEn2);
		}
		if (LinkIconEn3.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(LinkIconEn3);
		}
		if (LinkIconJp1.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(LinkIconJp1);
		}
		if (LinkIconJp2.Length != 0)
		{
			output.WriteRawTag(98);
			output.WriteString(LinkIconJp2);
		}
		if (LinkIconJp3.Length != 0)
		{
			output.WriteRawTag(106);
			output.WriteString(LinkIconJp3);
		}
		if (LinkIconKr1.Length != 0)
		{
			output.WriteRawTag(114);
			output.WriteString(LinkIconKr1);
		}
		if (LinkIconKr2.Length != 0)
		{
			output.WriteRawTag(122);
			output.WriteString(LinkIconKr2);
		}
		if (LinkIconKr3.Length != 0)
		{
			output.WriteRawTag(130, 1);
			output.WriteString(LinkIconKr3);
		}
		if (LinkIconTw1.Length != 0)
		{
			output.WriteRawTag(138, 1);
			output.WriteString(LinkIconTw1);
		}
		if (LinkIconTw2.Length != 0)
		{
			output.WriteRawTag(146, 1);
			output.WriteString(LinkIconTw2);
		}
		if (LinkIconTw3.Length != 0)
		{
			output.WriteRawTag(154, 1);
			output.WriteString(LinkIconTw3);
		}
		if (LinkUrlPathCn1.Length != 0)
		{
			output.WriteRawTag(162, 1);
			output.WriteString(LinkUrlPathCn1);
		}
		if (LinkUrlPathCn2.Length != 0)
		{
			output.WriteRawTag(170, 1);
			output.WriteString(LinkUrlPathCn2);
		}
		if (LinkUrlPathCn3.Length != 0)
		{
			output.WriteRawTag(178, 1);
			output.WriteString(LinkUrlPathCn3);
		}
		if (LinkUrlPathEn1.Length != 0)
		{
			output.WriteRawTag(186, 1);
			output.WriteString(LinkUrlPathEn1);
		}
		if (LinkUrlPathEn2.Length != 0)
		{
			output.WriteRawTag(194, 1);
			output.WriteString(LinkUrlPathEn2);
		}
		if (LinkUrlPathEn3.Length != 0)
		{
			output.WriteRawTag(202, 1);
			output.WriteString(LinkUrlPathEn3);
		}
		if (LinkUrlPathJp1.Length != 0)
		{
			output.WriteRawTag(210, 1);
			output.WriteString(LinkUrlPathJp1);
		}
		if (LinkUrlPathJp2.Length != 0)
		{
			output.WriteRawTag(218, 1);
			output.WriteString(LinkUrlPathJp2);
		}
		if (LinkUrlPathJp3.Length != 0)
		{
			output.WriteRawTag(226, 1);
			output.WriteString(LinkUrlPathJp3);
		}
		if (LinkUrlPathKr1.Length != 0)
		{
			output.WriteRawTag(234, 1);
			output.WriteString(LinkUrlPathKr1);
		}
		if (LinkUrlPathKr2.Length != 0)
		{
			output.WriteRawTag(242, 1);
			output.WriteString(LinkUrlPathKr2);
		}
		if (LinkUrlPathKr3.Length != 0)
		{
			output.WriteRawTag(250, 1);
			output.WriteString(LinkUrlPathKr3);
		}
		if (LinkUrlPathTw1.Length != 0)
		{
			output.WriteRawTag(130, 2);
			output.WriteString(LinkUrlPathTw1);
		}
		if (LinkUrlPathTw2.Length != 0)
		{
			output.WriteRawTag(138, 2);
			output.WriteString(LinkUrlPathTw2);
		}
		if (LinkUrlPathTw3.Length != 0)
		{
			output.WriteRawTag(146, 2);
			output.WriteString(LinkUrlPathTw3);
		}
		surveyRewardCount_.WriteTo(ref output, _repeated_surveyRewardCount_codec);
		surveyRewardId_.WriteTo(ref output, _repeated_surveyRewardId_codec);
		surveyRewardType_.WriteTo(ref output, _repeated_surveyRewardType_codec);
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
		num += communityRewardCount_.CalculateSize(_repeated_communityRewardCount_codec);
		num += communityRewardId_.CalculateSize(_repeated_communityRewardId_codec);
		num += communityRewardType_.CalculateSize(_repeated_communityRewardType_codec);
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (LinkIconCn1.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LinkIconCn1);
		}
		if (LinkIconCn2.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LinkIconCn2);
		}
		if (LinkIconCn3.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LinkIconCn3);
		}
		if (LinkIconEn1.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LinkIconEn1);
		}
		if (LinkIconEn2.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LinkIconEn2);
		}
		if (LinkIconEn3.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LinkIconEn3);
		}
		if (LinkIconJp1.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LinkIconJp1);
		}
		if (LinkIconJp2.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LinkIconJp2);
		}
		if (LinkIconJp3.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LinkIconJp3);
		}
		if (LinkIconKr1.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LinkIconKr1);
		}
		if (LinkIconKr2.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LinkIconKr2);
		}
		if (LinkIconKr3.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(LinkIconKr3);
		}
		if (LinkIconTw1.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(LinkIconTw1);
		}
		if (LinkIconTw2.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(LinkIconTw2);
		}
		if (LinkIconTw3.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(LinkIconTw3);
		}
		if (LinkUrlPathCn1.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(LinkUrlPathCn1);
		}
		if (LinkUrlPathCn2.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(LinkUrlPathCn2);
		}
		if (LinkUrlPathCn3.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(LinkUrlPathCn3);
		}
		if (LinkUrlPathEn1.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(LinkUrlPathEn1);
		}
		if (LinkUrlPathEn2.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(LinkUrlPathEn2);
		}
		if (LinkUrlPathEn3.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(LinkUrlPathEn3);
		}
		if (LinkUrlPathJp1.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(LinkUrlPathJp1);
		}
		if (LinkUrlPathJp2.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(LinkUrlPathJp2);
		}
		if (LinkUrlPathJp3.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(LinkUrlPathJp3);
		}
		if (LinkUrlPathKr1.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(LinkUrlPathKr1);
		}
		if (LinkUrlPathKr2.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(LinkUrlPathKr2);
		}
		if (LinkUrlPathKr3.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(LinkUrlPathKr3);
		}
		if (LinkUrlPathTw1.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(LinkUrlPathTw1);
		}
		if (LinkUrlPathTw2.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(LinkUrlPathTw2);
		}
		if (LinkUrlPathTw3.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(LinkUrlPathTw3);
		}
		num += surveyRewardCount_.CalculateSize(_repeated_surveyRewardCount_codec);
		num += surveyRewardId_.CalculateSize(_repeated_surveyRewardId_codec);
		num += surveyRewardType_.CalculateSize(_repeated_surveyRewardType_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CommunityWebLinkTable other)
	{
		if (other != null)
		{
			communityRewardCount_.Add(other.communityRewardCount_);
			communityRewardId_.Add(other.communityRewardId_);
			communityRewardType_.Add(other.communityRewardType_);
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.LinkIconCn1.Length != 0)
			{
				LinkIconCn1 = other.LinkIconCn1;
			}
			if (other.LinkIconCn2.Length != 0)
			{
				LinkIconCn2 = other.LinkIconCn2;
			}
			if (other.LinkIconCn3.Length != 0)
			{
				LinkIconCn3 = other.LinkIconCn3;
			}
			if (other.LinkIconEn1.Length != 0)
			{
				LinkIconEn1 = other.LinkIconEn1;
			}
			if (other.LinkIconEn2.Length != 0)
			{
				LinkIconEn2 = other.LinkIconEn2;
			}
			if (other.LinkIconEn3.Length != 0)
			{
				LinkIconEn3 = other.LinkIconEn3;
			}
			if (other.LinkIconJp1.Length != 0)
			{
				LinkIconJp1 = other.LinkIconJp1;
			}
			if (other.LinkIconJp2.Length != 0)
			{
				LinkIconJp2 = other.LinkIconJp2;
			}
			if (other.LinkIconJp3.Length != 0)
			{
				LinkIconJp3 = other.LinkIconJp3;
			}
			if (other.LinkIconKr1.Length != 0)
			{
				LinkIconKr1 = other.LinkIconKr1;
			}
			if (other.LinkIconKr2.Length != 0)
			{
				LinkIconKr2 = other.LinkIconKr2;
			}
			if (other.LinkIconKr3.Length != 0)
			{
				LinkIconKr3 = other.LinkIconKr3;
			}
			if (other.LinkIconTw1.Length != 0)
			{
				LinkIconTw1 = other.LinkIconTw1;
			}
			if (other.LinkIconTw2.Length != 0)
			{
				LinkIconTw2 = other.LinkIconTw2;
			}
			if (other.LinkIconTw3.Length != 0)
			{
				LinkIconTw3 = other.LinkIconTw3;
			}
			if (other.LinkUrlPathCn1.Length != 0)
			{
				LinkUrlPathCn1 = other.LinkUrlPathCn1;
			}
			if (other.LinkUrlPathCn2.Length != 0)
			{
				LinkUrlPathCn2 = other.LinkUrlPathCn2;
			}
			if (other.LinkUrlPathCn3.Length != 0)
			{
				LinkUrlPathCn3 = other.LinkUrlPathCn3;
			}
			if (other.LinkUrlPathEn1.Length != 0)
			{
				LinkUrlPathEn1 = other.LinkUrlPathEn1;
			}
			if (other.LinkUrlPathEn2.Length != 0)
			{
				LinkUrlPathEn2 = other.LinkUrlPathEn2;
			}
			if (other.LinkUrlPathEn3.Length != 0)
			{
				LinkUrlPathEn3 = other.LinkUrlPathEn3;
			}
			if (other.LinkUrlPathJp1.Length != 0)
			{
				LinkUrlPathJp1 = other.LinkUrlPathJp1;
			}
			if (other.LinkUrlPathJp2.Length != 0)
			{
				LinkUrlPathJp2 = other.LinkUrlPathJp2;
			}
			if (other.LinkUrlPathJp3.Length != 0)
			{
				LinkUrlPathJp3 = other.LinkUrlPathJp3;
			}
			if (other.LinkUrlPathKr1.Length != 0)
			{
				LinkUrlPathKr1 = other.LinkUrlPathKr1;
			}
			if (other.LinkUrlPathKr2.Length != 0)
			{
				LinkUrlPathKr2 = other.LinkUrlPathKr2;
			}
			if (other.LinkUrlPathKr3.Length != 0)
			{
				LinkUrlPathKr3 = other.LinkUrlPathKr3;
			}
			if (other.LinkUrlPathTw1.Length != 0)
			{
				LinkUrlPathTw1 = other.LinkUrlPathTw1;
			}
			if (other.LinkUrlPathTw2.Length != 0)
			{
				LinkUrlPathTw2 = other.LinkUrlPathTw2;
			}
			if (other.LinkUrlPathTw3.Length != 0)
			{
				LinkUrlPathTw3 = other.LinkUrlPathTw3;
			}
			surveyRewardCount_.Add(other.surveyRewardCount_);
			surveyRewardId_.Add(other.surveyRewardId_);
			surveyRewardType_.Add(other.surveyRewardType_);
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
				communityRewardCount_.AddEntriesFrom(ref input, _repeated_communityRewardCount_codec);
				break;
			case 16u:
			case 18u:
				communityRewardId_.AddEntriesFrom(ref input, _repeated_communityRewardId_codec);
				break;
			case 32u:
				Id = input.ReadInt32();
				break;
			case 42u:
				LinkIconCn1 = input.ReadString();
				break;
			case 50u:
				LinkIconCn2 = input.ReadString();
				break;
			case 58u:
				LinkIconCn3 = input.ReadString();
				break;
			case 24u:
			case 26u:
				communityRewardType_.AddEntriesFrom(ref input, _repeated_communityRewardType_codec);
				break;
			case 66u:
				LinkIconEn1 = input.ReadString();
				break;
			case 74u:
				LinkIconEn2 = input.ReadString();
				break;
			case 82u:
				LinkIconEn3 = input.ReadString();
				break;
			case 90u:
				LinkIconJp1 = input.ReadString();
				break;
			case 98u:
				LinkIconJp2 = input.ReadString();
				break;
			case 106u:
				LinkIconJp3 = input.ReadString();
				break;
			case 114u:
				LinkIconKr1 = input.ReadString();
				break;
			case 122u:
				LinkIconKr2 = input.ReadString();
				break;
			case 130u:
				LinkIconKr3 = input.ReadString();
				break;
			case 138u:
				LinkIconTw1 = input.ReadString();
				break;
			case 146u:
				LinkIconTw2 = input.ReadString();
				break;
			case 154u:
				LinkIconTw3 = input.ReadString();
				break;
			case 162u:
				LinkUrlPathCn1 = input.ReadString();
				break;
			case 170u:
				LinkUrlPathCn2 = input.ReadString();
				break;
			case 178u:
				LinkUrlPathCn3 = input.ReadString();
				break;
			case 186u:
				LinkUrlPathEn1 = input.ReadString();
				break;
			case 194u:
				LinkUrlPathEn2 = input.ReadString();
				break;
			case 202u:
				LinkUrlPathEn3 = input.ReadString();
				break;
			case 210u:
				LinkUrlPathJp1 = input.ReadString();
				break;
			case 218u:
				LinkUrlPathJp2 = input.ReadString();
				break;
			case 226u:
				LinkUrlPathJp3 = input.ReadString();
				break;
			case 234u:
				LinkUrlPathKr1 = input.ReadString();
				break;
			case 280u:
			case 282u:
				surveyRewardCount_.AddEntriesFrom(ref input, _repeated_surveyRewardCount_codec);
				break;
			case 296u:
			case 298u:
				surveyRewardType_.AddEntriesFrom(ref input, _repeated_surveyRewardType_codec);
				break;
			case 288u:
			case 290u:
				surveyRewardId_.AddEntriesFrom(ref input, _repeated_surveyRewardId_codec);
				break;
			case 242u:
				LinkUrlPathKr2 = input.ReadString();
				break;
			case 250u:
				LinkUrlPathKr3 = input.ReadString();
				break;
			case 258u:
				LinkUrlPathTw1 = input.ReadString();
				break;
			case 266u:
				LinkUrlPathTw2 = input.ReadString();
				break;
			case 274u:
				LinkUrlPathTw3 = input.ReadString();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
