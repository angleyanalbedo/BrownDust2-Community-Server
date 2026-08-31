using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class TalentObjectDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBDb21tb25zL1RhbGVudE9iamVjdERCSW5mby5wcm90bxIJcHJvdG8ubmV0IjwKElRhbGVudE9iamVjdERCSW5mbxITCgt0YWxlbnRfdHlwZRgBIAEoBRIRCglvYmplY3RfaWQYAiABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(TalentObjectDBInfo), TalentObjectDBInfo.Parser, new string[2] { "TalentType", "ObjectId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
