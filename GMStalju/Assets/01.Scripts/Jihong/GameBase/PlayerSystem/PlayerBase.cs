using UnityEngine;
using UnityEngine.Serialization;

public class PlayerBase : PlayerRoot
{
    [FormerlySerializedAs("_animator")]
    [Header("��������")]
    [SerializeField]
    protected Animator animator;
    [SerializeField]
    protected Rigidbody2D rb;

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
