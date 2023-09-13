using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = ("SO/Resource/Resource"))]
public class ResourceSO : ScriptableObject
{
    public string resourceName = "NULL";
    public Sprite resourceImage = null;
    public string resourceExplain = "There is no explian";
}
