using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PvpBattleUserDeckFullInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidDb21tb25zL1B2cEJhdHRsZVVzZXJEZWNrRnVsbEluZm8ucHJvdG8SCXBy" + "b3RvLm5ldBojQ29tbW9ucy9QdnBCYXR0bGVVc2VyRGVja0luZm8ucHJvdG8a" + "GENvbW1vbnMvQ2hhckRCSW5mby5wcm90bxobQ29tbW9ucy9Db3N0dW1lREJJ" + "bmZvLnByb3RvGhlDb21tb25zL0VxdWlwREJJbmZvLnByb3RvGiVDb21tb25z" + "L1BpY3RvcmlhbEJ1ZmZTdGF0REJJbmZvLnByb3RvGh1Db21tb25zL0NoYXJB" + "d2FrZURCSW5mby5wcm90byLCAgoZUHZwQmF0dGxlVXNlckRlY2tGdWxsSW5m" + "bxIzCglkZWNrX2luZm8YASADKAsyIC5wcm90by5uZXQuUHZwQmF0dGxlVXNl" + "ckRlY2tJbmZvEigKCWNoYXJfaW5mbxgCIAMoCzIVLnByb3RvLm5ldC5DaGFy" + "REJJbmZvEi4KDGNvc3R1bWVfaW5mbxgDIAMoCzIYLnByb3RvLm5ldC5Db3N0" + "dW1lREJJbmZvEioKCmVxdWlwX2luZm8YBCADKAsyFi5wcm90by5uZXQuRXF1" + "aXBEQkluZm8SOgoOYnVmZl9zdGF0X2luZm8YBSADKAsyIi5wcm90by5uZXQu" + "UGljdG9yaWFsQnVmZlN0YXREQkluZm8SLgoKYXdha2VfaW5mbxgGIAMoCzIa" + "LnByb3RvLm5ldC5DaGFyQXdha2VEQkluZm9iBnByb3RvMw=="), new FileDescriptor[6]
	{
		PvpBattleUserDeckInfoReflection.Descriptor,
		CharDBInfoReflection.Descriptor,
		CostumeDBInfoReflection.Descriptor,
		EquipDBInfoReflection.Descriptor,
		PictorialBuffStatDBInfoReflection.Descriptor,
		CharAwakeDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PvpBattleUserDeckFullInfo), PvpBattleUserDeckFullInfo.Parser, new string[6] { "DeckInfo", "CharInfo", "CostumeInfo", "EquipInfo", "BuffStatInfo", "AwakeInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
