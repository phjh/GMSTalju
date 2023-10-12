using UnityEngine;
using System.IO;

[System.Serializable]
public class ResourceValue
{
	public ResourceSO resourceMain;
	[Range(0, 999)]
	public int resourceCount;
}

public class Inventory : MonoBehaviour
{

	[SerializeField] private ResourceListSO inventoryListSO;
	[HideInInspector] public int listLength = 0;

	[SerializeField] private GameObject ItemIconPrefab;
	public GameObject iconParent;

	private void Awake()
	{
		if (Path.Combine(Application.dataPath, "InventoryData.json") != null)
		{
			string path = Path.Combine(Application.dataPath, "InventoryData.json");
			string jsonData = File.ReadAllText(path);
			inventoryListSO = JsonUtility.FromJson<ResourceListSO>(jsonData);
			listLength = inventoryListSO.resourceList.Count;
		}
	}

	public void AddResource(ResourceSO resource, int count)
	{
		ResourceValue addValue = new ResourceValue();
		addValue.resourceMain = resource;
		addValue.resourceCount = count;
		int index = inventoryListSO.resourceList.FindIndex(r => r.resourceMain == addValue.resourceMain);
		if (index == -1) inventoryListSO.AddToList(addValue, listLength);
		else
		{
			inventoryListSO.AddToList(addValue, index);
			listLength++;
		}
	}

	public bool RemoveResource(ResourceSO resource, int count)
	{
		if (count <= 0) return false;
		ResourceValue removeValue = new ResourceValue();
		removeValue.resourceMain = resource;
		removeValue.resourceCount = count;
		int index = inventoryListSO.resourceList.FindIndex(r => r.resourceMain == removeValue.resourceMain);
		if (index == -1) return false;
		if (removeValue.resourceCount - count > 0)
		{
			inventoryListSO.resourceList[index].resourceCount = removeValue.resourceCount - count;
			return true;
		}
		else if (removeValue.resourceCount - count < 0) return false;
		else if (removeValue.resourceCount - count == 0)
		{
			listLength--;
			inventoryListSO.RemoveToList(removeValue, index);
			return true;
		}
		return false;
	}

	public int ItemCount(ResourceSO resource)
	{
		if (inventoryListSO.resourceList.Find(r => r.resourceMain == resource) != null)
		{
			int index = inventoryListSO.resourceList.FindIndex(r => r.resourceMain == resource);
			return inventoryListSO.resourceList[index].resourceCount;
		}
		return 0;
	}

	#region Return Item Values
	public Sprite ReturnItemIamge(int itemNum)
	{
		return inventoryListSO.resourceList[itemNum].resourceMain.resourceImage;
	}
	public int ReturnItemCount(int itemNum)
	{
		return inventoryListSO.resourceList[itemNum].resourceCount;
	}
	public string ReturnItemName(int itemNum)
	{
		return inventoryListSO.resourceList[itemNum].resourceMain.resourceName;
	}
	public string ReturnItemInfo(int itemNum)
	{
		return inventoryListSO.resourceList[itemNum].resourceMain.resourceExplain;
	}
	#endregion

	[ContextMenu("To Json Data")]
	public void SavePlayerInventory()
	{
		string jsonData = JsonUtility.ToJson(inventoryListSO, true);
		string path = Path.Combine(Application.dataPath, "InventoryData.json");
		File.WriteAllText(path, jsonData);
	}

	#region Add To UI
	public void AddInventoryIcon(ResourceSO addResource)
	{
		var itemIcon = Instantiate(ItemIconPrefab, Vector3.one, Quaternion.identity);
		if (itemIcon.GetComponent<ItemSOHolder>() == null)
			itemIcon.AddComponent<ItemSOHolder>();
		ItemSOHolder holder = itemIcon.GetComponent<ItemSOHolder>();
		holder.thisResourcData = addResource;
		itemIcon.transform.parent = iconParent.transform;
	}
	#endregion
}
