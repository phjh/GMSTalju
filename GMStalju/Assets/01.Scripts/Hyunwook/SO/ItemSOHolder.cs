using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ItemSOHolder : MonoBehaviour
{
    private Button button;
    
    public UIManager manager;
    public ResourceSO thisResourcData;

	private void Start()
	{
		button = GetComponent<Button>();
		manager = FindObjectOfType<UIManager>().GetComponent<UIManager>();

		button.onClick.AddListener(delegate { ReturnItemData(thisResourcData); });
	}

	public void ReturnItemData(ResourceSO itemData)
    {
        manager.ItemImage.sprite = itemData.resourceImage;
        manager.ItemInfo.text = itemData.resourceExplain;
        manager.ItemName.text = itemData.resourceName;
    }
}
