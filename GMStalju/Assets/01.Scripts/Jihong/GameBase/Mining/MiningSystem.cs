using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MiningSystem : PlayerRoot
{
    [SerializeField] private Tilemap mineTilemap;
    [SerializeField] private TextMeshProUGUI tmp;
    
    private Vector3Int nowPos;
    private List<Vector3Int> checkPos;
    private List<Vector3Int> mineablething;

    private int pointing = 0;
    private void Start()
    {
        //detection += ;
    }

    private bool detecting()
    {
        foreach (var positions in checkPos)
        {
            if (mineTilemap.GetTile(positions) != null)
            {
                mineablething.Add(positions);
                return true;
            }
        }

        return false;
    }

    void Mining()
    {
        
    }
    
    
    private void OnMovement()
    {
        nowPos = new Vector3Int((int)transform.position.x, (int)transform.position.y,0);
        
    }


}
