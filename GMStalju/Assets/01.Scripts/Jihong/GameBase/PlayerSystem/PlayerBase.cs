using System.Collections;
using UnityEngine;
using DG.Tweening;

public class PlayerBase : PlayerRoot
{
    [Header("참조변수")]
    [SerializeField]
    protected Animator animator;
    [SerializeField]
    protected Rigidbody2D rb;

    [Header("값 설정 변수")]
    [SerializeField]
    protected int leftMovements;
    [SerializeField]
    protected int level;
    [SerializeField]
    protected Vector2 recallPos;
    [SerializeField]
    protected float speed = 2f;

    [Header("디버깅 변수")]
    [SerializeField]
    protected int positionAsTilemap;
    [SerializeField]
    protected MoveDir moveDir;

    [SerializeField]
    protected bool isMoving = false;

    private void Start()
    {
        Recallcoord += RecallEvent;
    }

    private void RecallEvent(Vector2 value)
    {
        transform.position = value;
    }

    protected void Move(Vector2 pos)
    {
        Ray2D ray;
        if (!Physics2D.BoxCast(transform.localPosition, transform.localScale, 45 * (float)moveDir, Vector2.up, TileSystem.tileSystem.multiplied))
        {
            
        }
        
    }

    IEnumerator MoveTo(Vector2 pos)
    {
        isMoving = true;
        yield return transform.DOMove(pos, Vector2.Distance(transform.position, pos) / speed, false);
        isMoving = false;
    }

}
