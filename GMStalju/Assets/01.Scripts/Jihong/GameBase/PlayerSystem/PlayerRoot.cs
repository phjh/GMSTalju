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
    //�̺�Ʈ��
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

    protected Vector2 Inverter(MoveDir dir)
    {
        switch (dir)
        {
            case MoveDir.UP:
                return Vector2.up;
            case MoveDir.RIGHTUP:
                return Vector2.up + Vector2.right;
            case MoveDir.RIGHT:
                return Vector2.right;
            case MoveDir.RIGHTDOWN:
                return Vector2.down + Vector2.right;
            case MoveDir.DOWN:
                return Vector2.down;
            case MoveDir.LEFTDOWN:
                return Vector2.down + Vector2.left;
            case MoveDir.LEFT:
                return Vector2.left;
            case MoveDir.LEFTUP:
                return Vector2.left + Vector2.up;
            default:
                return Vector2.zero;
        }
    }
    
}
