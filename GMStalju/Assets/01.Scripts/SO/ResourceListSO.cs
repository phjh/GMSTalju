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
    [Header("���� ������ �ִ� �ڿ�/����")]
    public List<ResourceValue> resourceList = new List<ResourceValue>();
}
