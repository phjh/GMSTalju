using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class InventoryUI : MonoBehaviour
{
    private UIDocument mainInventoryUI;
    private Inventory inventory;

    public bool isActive = false;

    private void Awake()
    {
        inventory = GetComponent<Inventory>();
        mainInventoryUI = GetComponent<UIDocument>();
    }

    public void ShowUI()
    {
        isActive = true;

    }

    private void OnEnable()
    {
        isActive = true;
        VisualElement root = mainInventoryUI.rootVisualElement;
        Time.timeScale = 0;
        //popup.AddToClassList("on"); //클래스에 on을 붙여준다.
        Time.timeScale = 1;
        //popup.RemoveFromClassList("on");
    }

    private void OnDisable()
    {
        isActive = false;
    }
}
