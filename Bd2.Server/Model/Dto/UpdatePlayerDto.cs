namespace Bd2.Server.Model.Dto;

public class UpdatePlayerDto
{
	public long ownerIndex { get; set; }

	public long? gold { get; set; }

	public long? freeJewelry { get; set; }

	public long? jewelry { get; set; }

	public int? exp { get; set; }

	public long? blockDate { get; set; }

	public int? blockReason { get; set; }
}
