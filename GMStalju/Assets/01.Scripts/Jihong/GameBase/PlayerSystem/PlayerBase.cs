using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking.PlayerConnection;

public class PlayerBase : PlayerRoot
{
    [Header("��������")]
    [SerializeField]
    protected Animator _animator;
    [SerializeField]
    protected Rigidbody2D _rb;

    [Header("�� ���� ����")]
    [SerializeField]
    protected int leftMovements;
    [SerializeField]
    protected int level;
    [SerializeField]
    protected Vector2 recallPos;

    [Header("����� ����")]
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
