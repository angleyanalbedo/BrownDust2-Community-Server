using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("UserInfo")]
public class UserInfoDao
{
	[SugarColumn(ColumnName = "OwnerIndex", IsPrimaryKey = true, ColumnDataType = "INTEGER")]
	public long OwnerIndex { get; set; }

	[SugarColumn(ColumnName = "UserId")]
	public string UserId { get; set; }

	[SugarColumn(ColumnName = "LastPlayPackId")]
	public int LastPlayPackId { get; set; }

	[SugarColumn(ColumnName = "InvenSlot")]
	public int InvenSlot { get; set; }

	[SugarColumn(ColumnName = "StorageSlot")]
	public int StorageSlot { get; set; }

	[SugarColumn(ColumnName = "Gold")]
	public long Gold { get; set; }

	[SugarColumn(ColumnName = "FreeJewelry")]
	public long FreeJewelry { get; set; }

	[SugarColumn(ColumnName = "Jewelry")]
	public long Jewelry { get; set; }

	[SugarColumn(ColumnName = "EquipSlot")]
	public int EquipSlot { get; set; }

	[SugarColumn(ColumnName = "Catalyst")]
	public long Catalyst { get; set; }

	[SugarColumn(ColumnName = "Exp")]
	public int Exp { get; set; }

	[SugarColumn(ColumnName = "LevelReward")]
	public int LevelReward { get; set; }

	[SugarColumn(ColumnName = "PortraitCostumeId")]
	public int PortraitCostumeId { get; set; }

	[SugarColumn(ColumnName = "EquipStorageSlot")]
	public int EquipStorageSlot { get; set; }

	[SugarColumn(ColumnName = "PvpTicket")]
	public int PvpTicket { get; set; }

	[SugarColumn(ColumnName = "Medal")]
	public int Medal { get; set; }

	[SugarColumn(ColumnName = "EvilCastleCoin")]
	public int EvilCastleCoin { get; set; }

	[SugarColumn(ColumnName = "UserType")]
	public int UserType { get; set; }

	[SugarColumn(ColumnName = "FreeHuntingAp")]
	public int FreeHuntingAp { get; set; }

	[SugarColumn(ColumnName = "BonusHuntingAp")]
	public int BonusHuntingAp { get; set; }

	[SugarColumn(ColumnName = "PvpTicketStack")]
	public int PvpTicketStack { get; set; }

	[SugarColumn(ColumnName = "Mileage")]
	public int Mileage { get; set; }

	[SugarColumn(ColumnName = "HopePowder")]
	public int HopePowder { get; set; }

	[SugarColumn(ColumnName = "UnregDate")]
	public long UnregDate { get; set; }

	[SugarColumn(ColumnName = "IsFirstGacha")]
	public int IsFirstGacha { get; set; }

	[SugarColumn(ColumnName = "PresetSlot")]
	public int PresetSlot { get; set; }

	[SugarColumn(ColumnName = "BlockDate")]
	public long BlockDate { get; set; }

	[SugarColumn(ColumnName = "ReturnStatusEndTime")]
	public long ReturnStatusEndTime { get; set; }

	[SugarColumn(ColumnName = "MyRoomSlot")]
	public int MyRoomSlot { get; set; }

	[SugarColumn(ColumnName = "TotalWarPresetSlot")]
	public int TotalWarPresetSlot { get; set; }

	[SugarColumn(ColumnName = "EventApFree")]
	public int EventApFree { get; set; }

	[SugarColumn(ColumnName = "EventApStack")]
	public int EventApStack { get; set; }

	[SugarColumn(ColumnName = "FreeTorchLightAp")]
	public int FreeTorchLightAp { get; set; }

	[SugarColumn(ColumnName = "TorchLightAp")]
	public int TorchLightAp { get; set; }

	[SugarColumn(ColumnName = "JoinTime")]
	public long JoinTime { get; set; }

	[SugarColumn(ColumnName = "NewbiePassStep")]
	public int NewbiePassStep { get; set; }

	[SugarColumn(ColumnName = "BlockReason")]
	public int BlockReason { get; set; }

	[SugarColumn(ColumnName = "RogueLikeAp")]
	public int RogueLikeAp { get; set; }

	[SugarColumn(ColumnName = "RogueLikeApStack")]
	public int RogueLikeApStack { get; set; }

	[SugarColumn(ColumnName = "LoginDate")]
	public long LoginDate { get; set; }
}
