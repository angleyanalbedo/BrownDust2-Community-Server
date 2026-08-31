using System.Collections.Generic;

namespace Bd2.Server.Common.Proto.Net;

public class GachaHistoryLogDBInfo
{
	public int GachaGroupId;

	public int GachaId;

	public Define_GachaBuyType BuyType;

	public int GachaCount;

	public int GetPoint;

	public Define_GachaType GachaType;

	public int PickupItemId;

	public IList<GachaFixedDBInfo> GachaFixedInfos;

	public IList<ItemAutoExchangeInfo> AutoExchangeItemInfos;

	public IList<int> NewSort;

	public IList<int> SelectionSort;

	public IList<ItemMaterialInfo> DecreaseItemInfo;

	public long LogTime;
}
