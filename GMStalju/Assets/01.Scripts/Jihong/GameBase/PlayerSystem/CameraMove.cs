using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] 
    private GameObject player;

    private void Update()
    {
        transform.position = player.transform.position - new Vector3(0, 5.5f, 5.5f);
    }
}
