using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ItemSOHolder : PoolableMono
{

	public override void Init()
	{
        button = GetComponent<Button>();
		manager = FindObjectOfType<UIManager>().GetComponent<UIManager>();
        
        button.onClick.AddListener(delegate{ReturnItemData(thisResourcData); });
	}

    private Button button;
    
    public UIManager manager;
    public ResourceSO thisResourcData;

    public void ReturnItemData(ResourceSO itemData)
    {
        manager.ItemImage.sprite = itemData.resourceImage;
        manager.ItemInfo.text = itemData.resourceExplain;
        manager.ItemName.text = itemData.resourceName;
    }
}
