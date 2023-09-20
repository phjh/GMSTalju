using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionary : MonoBehaviour
{
    public List<Item> items;

    [SerializeField] private Transform slotParent;
    [SerializeField] Slot[] slots;

    private void OnValidate()
    {       
        slots = slotParent.GetComponentsInChildren<Slot>();
    }
    private void Awake()
    {
        FreshSlot();
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
            FreshSlot();
        }
        else
        {
            Debug.Log("²ËÂü");
        }
    }
}
