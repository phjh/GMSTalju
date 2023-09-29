using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectItem : MonoBehaviour, IObjectItem
{
    [Header("아이템")]
    public Item item;
    [Header("아이템이미지")]
    public SpriteRenderer itemImage;

    public Item clickTime()
    {
        if (item == null)
        {

            return this.item;
        }
        else { Debug.Log("중복체크"); return null; }
    }
}
