using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class ItemBtn : MonoBehaviour
{
    [SerializeField] GameObject Dictionary;
    [SerializeField] GameObject SpriteImageCanvas;
    [SerializeField] GameObject ImageCanvas;
    [SerializeField] GameObject StonePanel;
    [SerializeField] GameObject ToolPanel;
    [SerializeField] TextMeshProUGUI ItemName;
    [SerializeField] TextMeshProUGUI ItemExplanationText;
    [SerializeField] string[] Name;
    [SerializeField] string[] explanation;
    [SerializeField] Image image;
    [SerializeField] Sprite[] changesprite;


    private void Awake()
    {
        image = GetComponentInChildren<Image>();
    }
    private void Start()
    {
        SpriteImageCanvas.SetActive(false);
        Dictionary.SetActive(false);
        ImageCanvas.SetActive(false);
        
        
    }

    public void BtnSetAtive1()
    {
        
        ItemName.text = " " + Name[0];
        ItemExplanationText.text = " " + explanation[0];
        image.sprite = changesprite[0];
      
    }
    public void BtnSetAtive2()
    {
      
        ItemName.text = " " + Name[1];
        ItemExplanationText.text = " " + explanation[1];
        image.sprite = changesprite[1];

    }
    public void BtnSetAtive3()
    {
        
        ItemName.text = " " + Name[2];
        ItemExplanationText.text = " " + explanation[2];
        image.sprite = changesprite[2];
    }
    public void BtnSetAtive4()
    {
        
        ItemName.text = " " + Name[3];
        ItemExplanationText.text = " " + explanation[3];
        image.sprite = changesprite[3];
    }
    public void BtnSetAtive5()
    {
       
        ItemName.text = " " + Name[4];
        ItemExplanationText.text = " " + explanation[4];
        image.sprite = changesprite[4];
    }

    public void OpenBtn()
    {
        Dictionary.SetActive(true);
        SpriteImageCanvas.SetActive(true);
        ImageCanvas.SetActive(true);
    }
    public void ExitBtn()
    {
        Dictionary.SetActive(false);
        SpriteImageCanvas.SetActive(false);
        ImageCanvas.SetActive(false);
    }

    public void ToolBtn()
    {
        ToolPanel.SetActive(true);
        StonePanel.SetActive(false);
    }
    public void StoneBtn()
    {
        ToolPanel.SetActive(false);
        StonePanel.SetActive(true);
    }

}
