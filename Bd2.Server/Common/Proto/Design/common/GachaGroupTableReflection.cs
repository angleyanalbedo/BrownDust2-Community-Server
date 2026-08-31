using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class GachaGroupTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjJjb21tb24uZGIvR2FjaGFUYWJsZV9f672R6riwL0dhY2hhR3JvdXBUYWJs" + "ZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiKeBQoPR2FjaGFHcm91cFRh" + "YmxlEh0KFWJhbm5lckZvbnRMb2NhbFRleHRJZBgBIAEoBRIVCg1idXlMaW1p" + "dENvdW50GAIgASgFEhcKD2Rlc2NMb2NhbFRleHRJZBgDIAEoBRIXCg9lbmRH" + "ZXRJdGVtQ291bnQYBCABKAUSFAoMZW5kR2V0SXRlbUlkGAUgASgFEhYKDmVu" + "ZEdldEl0ZW1UeXBlGAYgASgFEg8KB2ZpeGVkSWQYByABKAUSFQoNZ2FjaGFC" + "YW5uZXJCZxgIIAEoCRIYChBnYWNoYUJhbm5lckltYWdlGAkgASgJEhcKD2dh" + "Y2hhTmFtZVRleHRJZBgKIAEoBRIUCgxnYWNoYVNwaW5lQmcYCyABKAkSFAoM" + "Z2FjaGFTdWJUeXBlGAwgASgFEhEKCWdhY2hhVHlwZRgNIAEoBRIKCgJpZBgO" + "IAEoBRIhChlpc0Rpc3BsYXlVaU93bkdhY2hhVGlja2V0GA8gASgFEhYKDm9u" + "ZVRpbWVHYWNoYUlkGBAgASgFEhoKEnBpY2tVcEV4Y2hhbmdlQ29zdBgRIAEo" + "BRIUCgxwaWNrVXBJdGVtSWQYEiABKAUSEgoKcG9pbnRDb3VudBgTIAEoBRIU" + "CgxzY2hlZHVsZVR5cGUYFCABKAUSEwoLc2VsZWN0Q291bnQYFSABKAUSGwoT" + "c2VsZWN0aW9uQ2hvaWNlUmF0ZRgWIAEoBRIOCgZzb3J0SWQYFyABKAUSFgoO" + "dGVuVGltZUdhY2hhSWQYGCABKAUSHAoUdXNlQWNjdW11bGF0ZVJhdGVMb2cY" + "GSABKAUSHAoUdXNlR2FjaGFUaWNrZXRPcHRpb24YGiABKAUSIgoadXNlU2Vs" + "ZWN0aW9uT25seUZpeGVkQXBwbHkYGyABKAVCREITUHJvdG8uRGVzaWduLmNv" + "bW1vblABWhUuL1Byb3RvLkRlc2lnbi5jb21tb26qAhNQcm90by5EZXNpZ24u" + "Y29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GachaGroupTable), GachaGroupTable.Parser, new string[27]
		{
			"BannerFontLocalTextId", "BuyLimitCount", "DescLocalTextId", "EndGetItemCount", "EndGetItemId", "EndGetItemType", "FixedId", "GachaBannerBg", "GachaBannerImage", "GachaNameTextId",
			"GachaSpineBg", "GachaSubType", "GachaType", "Id", "IsDisplayUiOwnGachaTicket", "OneTimeGachaId", "PickUpExchangeCost", "PickUpItemId", "PointCount", "ScheduleType",
			"SelectCount", "SelectionChoiceRate", "SortId", "TenTimeGachaId", "UseAccumulateRateLog", "UseGachaTicketOption", "UseSelectionOnlyFixedApply"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
