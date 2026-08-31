using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class BuffConditionTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CkFjb21tb24uZGIvQ2hhclRhYmxlX19fQ2hhcl9Db3N0dW1lX1NraWxsL0J1" + "ZmZDb25kaXRpb25UYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiLR" + "AQoSQnVmZkNvbmRpdGlvblRhYmxlEhIKCmF0dGFja1R5cGUYASADKAUSEQoJ" + "YnVmZkdyb3VwGAIgAygFEhEKCWNoYWluTGVzcxgDIAEoBRIRCgljaGFpbk1v" + "cmUYBCABKAUSFQoNY2hhaW5NdWx0aXBsZRgFIAEoBRIPCgdlbGVtZW50GAYg" + "AygFEgoKAmlkGAcgASgFEhMKC2xvZ2ljYWxUeXBlGAggASgFEhIKCm1haW5U" + "YXJnZXQYCSABKAUSEQoJc3ViVGFyZ2V0GAogASgFQkRCE1Byb3RvLkRlc2ln" + "bi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9uqgITUHJvdG8uRGVz" + "aWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(BuffConditionTable), BuffConditionTable.Parser, new string[10] { "AttackType", "BuffGroup", "ChainLess", "ChainMore", "ChainMultiple", "Element", "Id", "LogicalType", "MainTarget", "SubTarget" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
