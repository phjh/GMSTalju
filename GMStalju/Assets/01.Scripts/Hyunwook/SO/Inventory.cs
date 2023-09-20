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

	private void Awake()
	{
		if(Path.Combine(Application.dataPath, "InventoryData.json") != null)
		{
			string path = Path.Combine(Application.dataPath, "InventoryData.json");
			string jsonData = File.ReadAllText(path);
			inventoryListSO = JsonUtility.FromJson<ResourceListSO>(jsonData);
		}
	}

	public void AddResource(ResourceSO resource, int count)
	{
		ResourceValue addValue = new ResourceValue();
		addValue.resourceMain = resource;
		addValue.resourceCount = count;
		int index = inventoryListSO.resourceList.FindIndex(r => r.resourceMain == addValue.resourceMain);
		inventoryListSO.AddToList(addValue, index);
	}

	public bool RemoveResource(ResourceSO resource, int count)
	{
		if (count <= 0) return false;
		ResourceValue removeValue = new ResourceValue();
		removeValue.resourceMain = resource;
		removeValue.resourceCount = count;
		int index = inventoryListSO.resourceList.FindIndex(r => r.resourceMain == removeValue.resourceMain);
		return inventoryListSO.RemoveToList(removeValue, index);
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

	[ContextMenu("To Json Data")]
	public void SavePlayerInventory()
	{
		string jsonData = JsonUtility.ToJson(inventoryListSO, true);
		string path = Path.Combine(Application.dataPath, "InventoryData.json");
		File.WriteAllText(path, jsonData);
	}
}
