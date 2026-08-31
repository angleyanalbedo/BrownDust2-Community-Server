using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_QuestConditionType
{
	[OriginalName("TALK")]
	Talk,
	[OriginalName("HUNT")]
	Hunt,
	[OriginalName("COLLECTION")]
	Collection,
	[OriginalName("TARGET_BATTLE")]
	TargetBattle,
	[OriginalName("USE_TALENT_SKILL")]
	UseTalentSkill,
	[OriginalName("PUZZLE_INORDER")]
	PuzzleInorder,
	[OriginalName("PUZZLE")]
	Puzzle,
	[OriginalName("GATE_SPOT")]
	GateSpot,
	[OriginalName("RANDOM_BATTLE")]
	RandomBattle,
	[OriginalName("OBJECT_MOVE")]
	ObjectMove,
	[OriginalName("OBJECT_MOVE_AND_INTERACT")]
	ObjectMoveAndInteract,
	[OriginalName("CLICK_TALENT_SKILL")]
	ClickTalentSkill,
	[OriginalName("UI_INTERACTION")]
	UiInteraction,
	[OriginalName("TARGET_MAP_MOVE")]
	TargetMapMove,
	[OriginalName("PVP_DECK_SAVE")]
	PvpDeckSave,
	[OriginalName("MINI_GAME")]
	MiniGame,
	[OriginalName("GLOBAL_FIELD_REWARD")]
	GlobalFieldReward,
	[OriginalName("GLOBAL_FIELD_OBJECT_CRASH")]
	GlobalFieldObjectCrash,
	[OriginalName("FIELD_RESEARCH_OBJECT")]
	FieldResearchObject,
	[OriginalName("TALK_MANUAL")]
	TalkManual
}
