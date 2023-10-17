using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ItemSOHolder : MonoBehaviour
{
    private Button button;
    
    public UIManager manager;
    public ResourceSO thisResourcData;

    public TextMeshProUGUI ItemCount;
	public Image ItemImage;

	private void Start()
	{
		button = GetComponent<Button>();
		manager = FindObjectOfType<UIManager>().GetComponent<UIManager>();
		ItemImage.sprite = thisResourcData.resourceImage;
		button.onClick.AddListener(delegate { ReturnItemData(thisResourcData); });
	}

	public void UpdateCount(int count)
	{
		ItemCount.text = $"{count}";
	}

	public void ReturnItemData(ResourceSO itemData)
    {
        manager.ItemImage.sprite = itemData.resourceImage;
        manager.ItemInfo.text = itemData.resourceExplain;
        manager.ItemName.text = itemData.resourceName;
    }
}
