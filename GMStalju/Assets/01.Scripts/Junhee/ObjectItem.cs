using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectItem : MonoBehaviour, IObjectItem
{
    [Header("������")]
    public Item item;
    [Header("�������̹���")]
    public SpriteRenderer itemImage;

    public Item clickTime()
    {
        if (item == null)
        {

            return this.item;
        }
        else { Debug.Log("�ߺ�üũ"); return null; }
    }
}
