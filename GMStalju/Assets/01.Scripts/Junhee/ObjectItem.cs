using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectItem : MonoBehaviour
{
    [Header("������")]
    public Item item;
    [Header("�������̹���")]
    public SpriteRenderer itemImage;



    public interface objectItem
    {
        Item clickTime();
    }





    public Item ClickItem()
    {
        return this.item;
    }
    

}
