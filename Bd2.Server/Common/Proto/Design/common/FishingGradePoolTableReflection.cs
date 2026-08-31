using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007C90 RID: 31888
	public static class FishingGradePoolTableReflection
	{
		// Token: 0x1701121F RID: 70175
		// (get) Token: 0x06046C7A RID: 289914 RVA: 0x01136CC6 File Offset: 0x01134EC6
		public static FileDescriptor Descriptor
		{
			get
			{
				return FishingGradePoolTableReflection.descriptor;
			}
		}

		// Token: 0x0402EAEA RID: 191210
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CjZjb21tb24uZGIvRmlzaGluZ19fX+uCmuyLnC9GaXNoaW5nR3JhZGVQb29s", "VGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24iYgoVRmlzaGluZ0dy", "YWRlUG9vbFRhYmxlEhEKCWJ1ZmZWYWx1ZRgBIAEoBRINCgVncmFkZRgCIAMo", "BRIKCgJpZBgDIAEoBRINCgVyYXRpbxgEIAMoBRIMCgR0eXBlGAUgASgFQkRC", "E1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9u", "qgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z" })), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FishingGradePoolTable), FishingGradePoolTable.Parser, new string[] { "BuffValue", "Grade", "Id", "Ratio", "Type" }, null, null, null, null)
		}));
	}
}
