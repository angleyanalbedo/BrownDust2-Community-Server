namespace Bd2.Server.DAO.Data;

public class EquipmentData
{
	public int Id { get; set; }

	public int Grade { get; set; }

	public string Name { get; set; }

	public int[] MainOptionGroupId { get; set; }

	public int[] SubOptionGroupId { get; set; }

	public int[] PrivateUniqueOptionGroupId { get; set; }

	public int PrivateUniqueCharId { get; set; }

	public int SlotType { get; set; }
}
