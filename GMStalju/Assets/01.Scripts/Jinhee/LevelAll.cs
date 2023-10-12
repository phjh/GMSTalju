using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.TextCore;
using TMPro;

public class LevelAll : MonoBehaviour
{
    [SerializeField] Button button5;
    [SerializeField] Button button10;
    [SerializeField] Button button50;
    [SerializeField] Button button100;
    public TextMeshProUGUI levelTxt;
    public Image experienceBarimage;
    private Level level;
    
    public void Awake()
    {
        level = GetComponent<Level>();
        levelTxt = transform.Find("levelTxt").GetComponent<TextMeshProUGUI>();
        experienceBarimage = transform.Find("experienceBar").Find("Bar").GetComponent<Image>();
    }
    public void btn5()
    {
        level.Addexperience(5);
    }
    public void btn10()
    {
        level.Addexperience(10);
    }
    public void btn50()
    {
        level.Addexperience(50);
    }
    public void btn100()
    {
        level.Addexperience(100);
    }
    public void SetExperienceBarSize(float experienceNormalized)
    {
        experienceBarimage.fillAmount = experienceNormalized;

    }
    private void SetlevelNumber(int levelNumber)
    {
        levelTxt.text = "Lv " + (levelNumber + 1);
    }
    public void SetlevelSystem(Level level)
    {
        //옵젝지정
        this.level = level;

        //업데이트
        SetlevelNumber(level.GetlevelNum());
        SetExperienceBarSize(level.GetexperienceNomerlized());

        //이벤트 바꾸기
        level.OnExperienceChanged += Level_OnExperienceChanged;
        level.OnLevelChanged += Level_OnLevelChanged;
    }

    private void Level_OnLevelChanged(object sender, System.EventArgs e)
    {
        //레벨 바꾸기 
        SetlevelNumber(level.GetlevelNum());
    }

    private void Level_OnExperienceChanged(object sender, System.EventArgs e)
    {
        //경험치 증가
        SetExperienceBarSize(level.GetexperienceNomerlized());
    }
}
