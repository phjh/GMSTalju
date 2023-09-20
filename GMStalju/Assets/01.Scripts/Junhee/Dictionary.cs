using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionary : MonoBehaviour
{
    public List<Item> items;
    Item _itme;

    [SerializeField] private Transform slotParent;
    [SerializeField] Slot[] slots;

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
        ObjectItem clickInterface = hit.transform.gameObject.GetComponent<ObjectItem>();
        if(clickInterface!=null)
        {
            Item item = clickInterface.ClickItem();
            Debug.Log($"{item},{item.name}");
            AddItem(item);
            FreshSlot();
        }

    }


    public void FreshSlot()
    {
        int i = 0;
       for(; i<items.Count&&i<slots.Length;i++)
        {
            slots[i].item = items[i];
        }
       for(;i<slots.Length;i++)
        {
            slots[i].item = null;
        }
        
    }

    private void AddItem(Item _item)
    {
        if(items.Count<slots.Length)
        {
            items.Add(_item);

        }
        else
        {
            Debug.Log("²ËÂü");
        }
    }
}
