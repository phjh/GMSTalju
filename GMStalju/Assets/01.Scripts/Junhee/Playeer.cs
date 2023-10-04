using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playeer : MonoBehaviour
{
    Rigidbody2D rigid;
    int speed = 5;


    private void Update()
    {
        float dir = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(dir, 0, 0) * speed * Time.deltaTime;
    }
}
