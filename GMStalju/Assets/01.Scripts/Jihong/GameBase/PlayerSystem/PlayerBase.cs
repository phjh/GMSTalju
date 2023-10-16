using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Tilemaps;

public class PlayerBase : PlayerRoot
{
    [Header("참조 컴포넌트")] 
    [SerializeField]
    protected GameObject moveUI;
    [SerializeField] 
    protected Tilemap _tilemap;
    [SerializeField] 
    protected List<GameObject> moveUIs;
    //[SerializeField]
    //protected Animator animator;
    //[SerializeField]
    //protected Rigidbody2D rb;

    [Header("값 설정 변수")] 
    [SerializeField] 
    protected int maxMovements = 50;
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

    private float degreeInverter(float f) => f <= 0 ? 360 + f : f;

    private bool CanMove(MoveDir md) => (!Physics2D.BoxCast(transform.localPosition,
                                   transform.localScale - (new Vector3(0.3f, 0.3f, 0.3f)), 45 * (float)md, Inverter(md),
                                   TileSystem.tileSystem.multiplied)
                               && leftMovements > 0 &&
                               _tilemap.GetTile(new Vector3Int((int)(transform.position.x-0.5f) + (int)Inverter(md).x, (int)(transform.position.y-0.5f) + (int)Inverter(md).y,
                                   0)) != null);
    
    
    private void Start()
    {
        Recallcoord += RecallEvent;
    }

    private void RecallEvent(Vector2 value)
    {
        transform.position = value;
        leftMovements = maxMovements;
    }

    protected void Move(Vector2 dir)
    {
        Ray2D ray;
        if (leftMovements == 0)
        {
            RecallPlayer(recallPos);
        }
        if (CanMove(moveDir))
        {
            leftMovements--;
            StartCoroutine(MoveTo(new Vector2(transform.position.x + dir.x, transform.position.y + dir.y)));
            MoveEvent();
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
        SetEnableNextMoveUI();
    }

    void SetEnableNextMoveUI()
    {
        foreach (var v in moveUIs)
        {
            v.SetActive(true);
        }
        
        for (int i = 0; i < 8; i++)
        {
            if (!CanMove((MoveDir)i))
            {
                moveUIs[i].SetActive(false);
            }
        }
    }
    
    public void NextMove(int dir)
    {
        moveDir = (MoveDir)dir;
        Move(Inverter(moveDir));
    }
    
}
