using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class EventCoinExchangeGroupTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CkFjb21tb24uZGIvRXZlbnRUYWJsZV9f7J2067Kk7Yq4L0V2ZW50Q29pbkV4" + "Y2hhbmdlR3JvdXBUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiLI" + "AgobRXZlbnRDb2luRXhjaGFuZ2VHcm91cFRhYmxlEhEKCWVuZFBhZ2VJZBgB" + "IAEoBRIcChRldmVudE5hbWVMb2NhbFRleHRJZBgCIAEoBRIYChBmaXJzdEJ1" + "dHRvbkNvdW50GAMgASgFEhwKFGd1aWRlRGVzY0xvY2FsVGV4dElkGAQgAygF" + "Eh0KFWd1aWRlVGl0bGVMb2NhbFRleHRJZBgFIAMoBRIKCgJpZBgGIAEoBRIa" + "ChJpc1JlcGVhdGFibGVSZXdhcmQYByABKAUSEQoJaXRlbUNvdW50GAggASgF" + "Eg4KBml0ZW1JZBgJIAEoBRIQCghpdGVtVHlwZRgKIAEoBRIUCgxyYXRpb1dl" + "YkxpbmsYCyABKAUSGQoRc2Vjb25kQnV0dG9uQ291bnQYDCABKAUSEwoLc3Rh" + "cnRQYWdlSWQYDSABKAVCREITUHJvdG8uRGVzaWduLmNvbW1vblABWhUuL1By" + "b3RvLkRlc2lnbi5jb21tb26qAhNQcm90by5EZXNpZ24uY29tbW9uYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EventCoinExchangeGroupTable), EventCoinExchangeGroupTable.Parser, new string[13]
		{
			"EndPageId", "EventNameLocalTextId", "FirstButtonCount", "GuideDescLocalTextId", "GuideTitleLocalTextId", "Id", "IsRepeatableReward", "ItemCount", "ItemId", "ItemType",
			"RatioWebLink", "SecondButtonCount", "StartPageId"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
