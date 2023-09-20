using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking.PlayerConnection;

public class PlayerBase : PlayerRoot
{
    [Header("참조변수")]
    [SerializeField]
    protected Animator _animator;
    [SerializeField]
    protected Rigidbody2D _rb;

    [Header("값 설정 변수")]
    [SerializeField]
    protected int leftMovements;
    [SerializeField]
    protected int level;
    [SerializeField]
    protected Vector2 recallPos;

    [Header("디버깅 변수")]
    [SerializeField]
    protected int positionAsTilemap;

    private void Start()
    {
        Recallcoord += RecallEvent;
    }

    private void RecallEvent(Vector2 value)
    {
        transform.position = value;
    }

}
