using UnityEngine;
using UnityEngine.Serialization;

public class PlayerBase : PlayerRoot
{
    [FormerlySerializedAs("_animator")]
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
