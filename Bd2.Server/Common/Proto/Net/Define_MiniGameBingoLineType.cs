using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_MiniGameBingoLineType
{
	[OriginalName("BINGO_LINE_DIAGONAL")]
	BingoLineDiagonal,
	[OriginalName("BINGO_LINE_ROW")]
	BingoLineRow,
	[OriginalName("BINGO_LINE_COL")]
	BingoLineCol
}
