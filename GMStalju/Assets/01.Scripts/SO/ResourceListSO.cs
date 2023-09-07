using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ResourceValue
{
    public ResourceSO resourceMain;
    public int resourceCount;
}

[CreateAssetMenu(menuName = ("SO/Resource/List"))]
public class ResourceListSO : ScriptableObject
{
    [Header("현재 가지고 있는 자원/수량")]
    public List<ResourceValue> resourceList = new List<ResourceValue>();
}
