using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004F4E RID: 20302
	public static class UpdateAgeGateRequestReflection
	{
		// Token: 0x17004536 RID: 17718
		// (get) Token: 0x060214EE RID: 136430 RVA: 0x0089C458 File Offset: 0x0089A658
		public static FileDescriptor Descriptor
		{
			get
			{
				return UpdateAgeGateRequestReflection.descriptor;
			}
		}

		// Token: 0x04017960 RID: 96608
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSZXF1ZXN0L1VwZGF0ZUFnZUdhdGVSZXF1ZXN0LnByb3RvEglwcm90by5u" + "ZXQiXAoUVXBkYXRlQWdlR2F0ZVJlcXVlc3QSCwoDc2VxGAEgASgFEg0KBWlz" + "X2pwGAIgASgIEgwKBHllYXIYAyABKAUSDQoFbW9udGgYBCABKAUSCwoDZGF5" + "GAUgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(UpdateAgeGateRequest), UpdateAgeGateRequest.Parser, new string[] { "Seq", "IsJp", "Year", "Month", "Day" }, null, null, null, null)
		}));
	}
}
