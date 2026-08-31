using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FieldTrapDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1Db21tb25zL0ZpZWxkVHJhcERCSW5mby5wcm90bxIJcHJvdG8ubmV0ImwKD0ZpZWxkVHJhcERCSW5mbxIPCgdwYWNrX2lkGAEgASgFEg4KBm1hcF9pZBgCIAEoBRIPCgd0cmFwX2lkGAMgASgFEg0KBXN0YXRlGAQgASgFEhgKEHN3aXRjaF9vYmplY3RfaWQYBSADKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FieldTrapDBInfo), FieldTrapDBInfo.Parser, new string[5] { "PackId", "MapId", "TrapId", "State", "SwitchObjectId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
