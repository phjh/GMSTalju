using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerBase : PlayerRoot
{
    [Header("���� ������Ʈ")] 
    [SerializeField]
    protected GameObject moveUI;
    //[SerializeField]
    //protected Animator animator;
    //[SerializeField]
    //protected Rigidbody2D rb;

    [Header("�� ���� ����")]
    [SerializeField]
    protected int leftMovements;
    [SerializeField]
    protected int level;
    [SerializeField]
    protected Vector2 recallPos;
    [SerializeField]
    protected float speed = 2f;

    [Header("����� ����")]
    [SerializeField]
    protected int positionAsTilemap;
    [SerializeField]
    protected MoveDir moveDir;

    [SerializeField]
    protected bool isMoving = false;

    private float degreeInverter(float f) => f <= 0 ? 360 + f : f;
    
    private void Start()
    {
        Recallcoord += RecallEvent;
    }

    private void RecallEvent(Vector2 value)
    {
        transform.position = value;
    }

    protected void Move(Vector2 dir)
    {
        Ray2D ray;
        if (!Physics2D.BoxCast(transform.localPosition, transform.localScale - (new Vector3(0.5f,0.5f,0.5f)), 45 * (float)moveDir, dir, TileSystem.tileSystem.multiplied) && leftMovements > 0)
        {
            leftMovements--;
            StartCoroutine(MoveTo(new Vector2(transform.position.x + dir.x, transform.position.y + dir.y)));
        }
    }

    IEnumerator MoveTo(Vector2 pos)
    {
        isMoving = true;
        moveUI.SetActive(false);
        Quaternion rot = Quaternion.Euler(0, 0, 180 - ((int)moveDir * 45));
        Quaternion nowrot = transform.rotation;
        yield return transform.DORotate(rot.eulerAngles,Mathf.Abs(degreeInverter(nowrot.z) - degreeInverter(rot.z))/180f);
        yield return transform.DOMove(pos, Vector2.Distance(transform.position, pos) / speed, false);
        yield return new WaitForSeconds(Mathf.Min(Mathf.Max(Mathf.Abs(degreeInverter(nowrot.z) - degreeInverter(rot.z))/45f,Vector2.Distance(transform.position, pos) / speed) + 0.45f,2.5f));
        moveUI.transform.rotation = Quaternion.Euler(0,0,0);
        moveUI.SetActive(true);
        isMoving = false;
    }

    public void NextMove(int dir)
    {
        moveDir = (MoveDir)dir;
        Move(Inverter(moveDir));
    }
    
}
