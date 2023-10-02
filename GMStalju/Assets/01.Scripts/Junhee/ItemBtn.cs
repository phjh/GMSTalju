using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemBtn : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI ItemName;
    [SerializeField] TextMeshProUGUI ItemExplanationText;
    [SerializeField] string[] Name;
    [SerializeField] string[] explanation;
    public void BtnSetAtive1()
    {
        Debug.Log("±Û¾¾");
        ItemName.text = " " + Name[0];
        ItemExplanationText.text = " " + explanation[0];
    }
    public void BtnSetAtive2()
    {
        Debug.Log("±Û¾¾");
        ItemName.text = " " + Name[1];
        ItemExplanationText.text = " " + explanation[1];
    }
    public void BtnSetAtive3()
    {
        Debug.Log("±Û¾¾");
        ItemName.text = " " + Name[2];
        ItemExplanationText.text = " " + explanation[2];
    }
    public void BtnSetAtive4()
    {
        Debug.Log("±Û¾¾");
        ItemName.text = " " + Name[3];
        ItemExplanationText.text = " " + explanation[3];
    }
    public void BtnSetAtive5()
    {
        Debug.Log("±Û¾¾");
        ItemName.text = " " + Name[4];
        ItemExplanationText.text = " " + explanation[4];
    }

}
