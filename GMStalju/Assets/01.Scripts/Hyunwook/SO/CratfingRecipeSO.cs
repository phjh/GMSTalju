using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct ResourceAmount
{
	public ResourceSO resource;
	[Range(1, 999)]
	public int amount;
}

[CreateAssetMenu(menuName = "SO/Resource/Crafting")]
public class CraftingRecipeSO : ScriptableObject
{
	public List<ResourceAmount> Materials;
	public ResourceAmount Result;

	public bool CanCraft(Inventory inventory)
	{
		foreach (ResourceAmount ra in Materials)
		{
			if (inventory.ItemCount(ra.resource) < ra.amount)
			{
				return false;
			}
		}
		return true;
	}

	public void Craft(Inventory inventory)
	{
		if (CanCraft(inventory))
		{
			foreach (ResourceAmount ra in Materials)
			{
				inventory.RemoveResource(ra.resource, ra.amount);
			}
			inventory.AddResource(Result.resource, Result.amount);
		}
	}
}
