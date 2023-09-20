using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
