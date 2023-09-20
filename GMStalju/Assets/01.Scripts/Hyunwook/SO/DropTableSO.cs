using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SO/Table/Drop")]
public class DropTableSO : ScriptableObject
{
    [Header("��� ������")]
    public List<ResourceSO> dropRecource;
    [Header("�� �����ۺ� ��� Ȯ��(��� �����۰� ���� ���߱�)")]
    public List<int> dropPersentList;
}
