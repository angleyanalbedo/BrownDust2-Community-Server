using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_Difficulty
{
	[OriginalName("DIFFICULTY_NORMAL")]
	DifficultyNormal,
	[OriginalName("DIFFICULTY_HARD")]
	DifficultyHard,
	[OriginalName("DIFFICULTY_HARDEST")]
	DifficultyHardest,
	[OriginalName("DIFFICULTY_HELL")]
	DifficultyHell,
	[OriginalName("DIFFICULTY_LEGENDARY")]
	DifficultyLegendary
}
