using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = ("SO/Resource/List"))]
public class ResourceListSO : ScriptableObject
{
    [Header("현재 가지고 있는 자원/수량")]
    public List<ResourceValue> resourceList = new List<ResourceValue>();

    public void AddToList(ResourceValue resourceValue, int index)
    {
	    if(resourceList.Find(r => r.resourceMain == resourceValue.resourceMain) == null) resourceList.Add(resourceValue);
        resourceList[index].resourceCount = 0;
	}

    public bool RemoveToList(ResourceValue resourceValue, int index)
    {
		if (resourceList.Find(r => r.resourceMain == resourceValue.resourceMain) != null)
		{
			if (resourceList[index].resourceCount >= resourceValue.resourceCount)
			{
				resourceList[index].resourceCount -= resourceValue.resourceCount;
				if (resourceList[index].resourceCount == 0) resourceList.Remove(resourceValue);
				return true;
			}
			else return false;
		}
		else if (resourceList.Find(r => r.resourceMain == resourceValue.resourceMain) == null) return false;
		return false;
    }
}
