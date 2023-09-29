using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionary : MonoBehaviour
{

    //아이템 처음에 못 들어가게 하기.
    // 클릭한 아이템만 들어가게 하기. 
   
    
    public List<Item> items;
    Item _itme;
   

    [SerializeField] private Transform slotParent;
    [SerializeField] Slot[] slots;
    
    ObjectItem objectItem;
    int clickcount = 0;
    
    private void Awake()
    {
        objectItem = GetComponent<ObjectItem>();
      
        
    }

    private void OnValidate()
    {       
        slots = slotParent.GetComponentsInChildren<Slot>();
    }
  

    public void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);

            if(hit.collider!=null)
            {

               
                HitClickObject(hit);
                
            }
            
        }
    }

    void HitClickObject(RaycastHit2D hit)
    {
        IObjectItem clickInterface = hit.transform.gameObject.GetComponent<IObjectItem>();
        if(clickInterface!=null)
        {
            clickcount++;
            Debug.Log(clickcount);
            Item item = clickInterface.clickTime();
            
            AddItem(_itme);

        }
       

    }


    public void FreshSlot()
    {
        int i = 0;
        if(i<clickcount)
        {
            slots[i].item = items[i];
        }
       for(; i<slots.Length;i++)
        {
            slots[i].item = null;
        }
        
    }

    private void AddItem(Item _item)
    {
        if(items.Count<slots.Length)
        {
            
            items.Add(_item);
            FreshSlot();


        }
     
        else
        {
            Debug.Log("꽉참");
        }
    }

}
