using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    public event EventHandler OnExperienceChanged;
    public event EventHandler OnLevelChanged;
    private int level;
    private int experience; //°æÇèÄ¡
    private int nextlevel;
    
    public Level()
    {
        level = 0;
        experience = 0;
        nextlevel = 100;
    }
    public void Addexperience(int amount)
    {
        experience += amount;
        if(experience >= nextlevel)
        {
            level++;
            experience -= nextlevel;
            if (OnLevelChanged != null) OnLevelChanged(this, EventArgs.Empty);
        }
        if (OnExperienceChanged != null) OnExperienceChanged(this, EventArgs.Empty);
    }
    public int GetlevelNum()
    {
        return level;
    }
    public float GetexperienceNomerlized()
    {
        return (float)experience / nextlevel;
    }
}
