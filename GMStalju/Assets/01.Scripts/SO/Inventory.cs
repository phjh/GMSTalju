using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour, IItemContainer
{
    [SerializeField] private ResourceListSO _Inventory;

    public int ItemCount(ResourceSO resource)
    {
        return 0;
    }

    public bool AddResource(ResourceSO resource)
    {
		return false;
    }

    public bool ContainsResource(ResourceSO resource)
    {
        throw new System.NotImplementedException();
    }

    public bool IsFull()
    {
        throw new System.NotImplementedException();
    }

    public bool RemoveResource(ResourceSO resource)
    {
        throw new System.NotImplementedException();
    }
}
