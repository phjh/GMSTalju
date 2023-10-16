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
        MoveAction += OnMovement;
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
        if (mineablething.Count != 0)
        {
            
        }
    }
    
    
    private void OnMovement()
    {
        nowPos = new Vector3Int((int)(transform.position.x-0.5f), (int)(transform.position.y-0.5f),0);
        
    }


}
