using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSOHolder : MonoBehaviour
{
    private Button button;
    
    public UIManager manager;
    public ResourceSO thisResourcData;

    public ResourceSO ReturnItemData()
    {
        return thisResourcData;
    }

	private void Start()
	{
        manager = FindObjectOfType<UIManager>().GetComponent<UIManager>();
	}
}
