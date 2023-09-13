using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SO/Table/Drop")]
public class DropTableSO : ScriptableObject
{
    [Header("드랍 아이템")]
    public List<ResourceSO> dropRecource;
    [Header("각 아이템별 드랍 확률(드랍 아이템과 수량 맞추기)")]
    public List<int> dropPersentList;
}
