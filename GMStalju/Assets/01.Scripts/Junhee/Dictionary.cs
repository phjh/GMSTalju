using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Dictionary : MonoBehaviour
{
    public static Dictionary instance = null;

    //������ ó���� �� ���� �ϱ�.
    // Ŭ���� �����۸� ���� �ϱ�. 

    
    public List<Item> items;
    
    Item _itme;
    
 


    [SerializeField] private Transform slotParent;
    [SerializeField] Slot[] slots;
   
    ObjectItem objectItem;
    
    private void Awake()
    {

        instance = this;
        objectItem = GetComponent<ObjectItem>();
        
    }

    private void OnValidate()
    {       
        slots = slotParent.GetComponentsInChildren<Slot>();
        
    }
    

    public void Update()
    {
        /*if(Input.GetMouseButtonDown(0))
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);

            if(hit.collider!=null)
            {             
                HitClickObject(hit);                 
            }       
        }*/


         
    }

 
   

    public void AddItem(Item _item)
    {
        if(items.Count<slots.Length)
        {
            
            items.Add(_item);
           


        }
     
        else
        {
            Debug.Log("����");
        }
    }

}
