using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    [SerializeField] private LevelAll levelAll;
    private void Awake()
    {
        Level level = new Level();
        
        levelAll.SetlevelSystem(level);
    }
}
