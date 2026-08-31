using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class DispatchTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjhjb21tb24uZGIvVGFsZW50VGFibGVfX1/snqzriqXsiqTtgqwvRGlzcGF0" + "Y2hUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiLYAQoNRGlzcGF0" + "Y2hUYWJsZRIeChZkaXNwYXRjaEVuZExvY2FsVGV4dElkGAEgASgFEhUKDWRp" + "c3BhdGNoTGV2ZWwYAiABKAUSGwoTZGlzcGF0Y2hMb2NhbFRleHRJZBgDIAEo" + "BRIUCgxkaXNwYXRjaFRpbWUYBCABKAUSCgoCaWQYBSABKAUSEgoKbmFtZVRl" + "eHRJZBgGIAEoBRISCgpwcmVmYWJOYW1lGAcgASgJEhUKDXJld2FyZEdyb3Vw" + "SWQYCCABKAUSEgoKc3ByaXRlTmFtZRgJIAEoCUJEQhNQcm90by5EZXNpZ24u" + "Y29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1vbqoCE1Byb3RvLkRlc2ln" + "bi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(DispatchTable), DispatchTable.Parser, new string[9] { "DispatchEndLocalTextId", "DispatchLevel", "DispatchLocalTextId", "DispatchTime", "Id", "NameTextId", "PrefabName", "RewardGroupId", "SpriteName" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
