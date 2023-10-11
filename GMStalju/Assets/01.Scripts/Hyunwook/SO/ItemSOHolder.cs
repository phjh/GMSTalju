using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSOHolder : UIManager
{
    private Button button;
    
    public ResourceSO thisResourcData;

    public ResourceSO ReturnItemData()
    {
        return thisResourcData;
    }

	private void Start()
	{
		button.onClick.AddListener(SetClickEvnet);
	}
    
    public void SetClickEvnet()
    {
        Instance.ClickItem(this.GetComponent<ItemSOHolder>());
    }
}
