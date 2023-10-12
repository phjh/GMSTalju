using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
	[SerializeField] private GameObject[] UIRoots;

	[SerializeField] private TextMeshProUGUI itemName;
	[SerializeField] private Image itemImage;
	[SerializeField] private TextMeshProUGUI itemInfo;

	public GameObject Player;
	private Inventory inventory;	
	private UIManager instance;
    public UIManager Instance
	{
		get
		{
			return instance;
		}
		set
		{
			instance = value;
		}
	}

	private void Awake()
	{
		if (instance == null) instance = this;
	}

	private void Start()
	{
		Player = GameObject.Find("Player");
		inventory = Player.GetComponent<Inventory>();
	}

	#region UI Method
	private int tempUI;

	public void ShowUI(int number)
	{
		tempUI = number;
		UIRoots[number].SetActive(true);
	}

	public void BackUI()
	{
		UIRoots[tempUI].SetActive(false);
		switch (tempUI)
		{
			case 1:
			case 2:
				tempUI = 0;
				ShowUI(tempUI);
				break;
			default: 
				break;
		}
	}

	public void ClickItem(ItemSOHolder holder)
	{
		ResourceSO clickItemData =  holder.ReturnItemData();
		itemName.text = clickItemData.resourceName;
		itemImage.sprite = clickItemData.resourceImage;
		itemInfo.text = clickItemData.resourceExplain;
	}

	#endregion

}
