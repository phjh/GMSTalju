using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectItem : MonoBehaviour
{
    [Header("아이템")]
    public Item item;
    [Header("아이템이미지")]
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
