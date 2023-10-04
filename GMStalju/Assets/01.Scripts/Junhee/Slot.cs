using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
   public Image image;
   
    private Item _item;
    

   

    public Item item
    {
        get
        {
            return _item;
        }
        set
        {
            _item = value;
            if(_item!=null)
            {
                
                image.sprite = item.itemImage;
                image.color = new Color(1, 1, 1, 1);
            }
            else
            {
                Debug.Log("��");
                //image.color = new Color(1, 1, 1, 0);
            }

        }
    }

}
