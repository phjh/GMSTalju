using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectItem : MonoBehaviour, IObjectItem
{
    [Header("������")]
    public Item item;
    [Header("�������̹���")]
    public SpriteRenderer itemImage;


    public bool clicking = false;
   
    public GameObject box;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Debug.Log("�浹");
            clicking = true;
            if(clicking==true)
            {
                box.SetActive(false);
               
                

                
            }
            

        }
        else
        {
           
        }
    }


    public Item clickTime()
    {
        if (item == null)
        { 

            return this.item;
        }
        else { Debug.Log("�ߺ�üũ");  return null; }
    }
}
