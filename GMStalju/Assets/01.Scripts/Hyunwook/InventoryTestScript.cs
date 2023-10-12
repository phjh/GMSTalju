using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryTestScript : MonoBehaviour
{
    private Inventory inventory;
	[SerializeField]private ResourceSO add;

	private void Awake()
	{
		inventory = GetComponent<Inventory>();
	}

	private void Update()
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			inventory.AddResource(add, 10);
		}
	}
}
