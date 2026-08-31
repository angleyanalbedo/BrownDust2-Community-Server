using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class RLScoreTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjZjb21tb24uZGIvUm9ndWVsaWtlX+uhnOq3uOudvOydtO2BrC9STFNjb3Jl" + "VGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24irAEKDFJMU2NvcmVU" + "YWJsZRIKCgJpZBgBIAEoBRIbChNzY29yZUNvbmRpdGlvblZhbHVlGAIgASgF" + "EhsKE3Njb3JlRGVzY05hbWVUZXh0SWQYAyABKAUSFwoPc2NvcmVOYW1lVGV4" + "dElkGAQgASgFEhEKCXNjb3JlVHlwZRgFIAEoBRISCgpzY29yZVZhbHVlGAYg" + "ASgFEhYKDnNjb3JlVmFsdWVWZWl3GAcgASgFQkRCE1Byb3RvLkRlc2lnbi5j" + "b21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9uqgITUHJvdG8uRGVzaWdu" + "LmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(RLScoreTable), RLScoreTable.Parser, new string[7] { "Id", "ScoreConditionValue", "ScoreDescNameTextId", "ScoreNameTextId", "ScoreType", "ScoreValue", "ScoreValueVeiw" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
