using System;
using UnityEngine;

public enum MoveDir
{
    UP = 0,
    RIGHTUP = 1,
    RIGHT = 2,
    RIGHTDOWN = 3,
    DOWN = 4,
    LEFTDOWN = 5,
    LEFT = 6,
    LEFTUP = 7,
};

public abstract class PlayerRoot : MonoBehaviour
{
    //이벤트들
    protected Action<Vector2> NextMove;
    protected Action<Vector2> Recallcoord;
    
    protected void MovePlayer(Vector2 dir)
    {
        NextMove?.Invoke(dir);
    }
    protected void RecallPlayer(Vector2 dir)
    {
        Recallcoord?.Invoke(dir);
    }

}
