using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_PictorialBookMainId
{
	[OriginalName("PICTORIAL_BOOK_MAIN_NONE")]
	PictorialBookMainNone,
	[OriginalName("PICTORIAL_BOOK_MAIN_CHAR")]
	PictorialBookMainChar,
	[OriginalName("PICTORIAL_BOOK_MAIN_TALENT")]
	PictorialBookMainTalent,
	[OriginalName("PICTORIAL_BOOK_MAIN_EQUIP")]
	PictorialBookMainEquip,
	[OriginalName("PICTORIAL_BOOK_MAIN_COOKING_RECIPE")]
	PictorialBookMainCookingRecipe,
	[OriginalName("PICTORIAL_BOOK_MAIN_COLLECTION_QUEST")]
	PictorialBookMainCollectionQuest,
	[OriginalName("PICTORIAL_BOOK_MAIN_RESOURCE")]
	PictorialBookMainResource,
	[OriginalName("PICTORIAL_BOOK_MAIN_COSTUME")]
	PictorialBookMainCostume
}
