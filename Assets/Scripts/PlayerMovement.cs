using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float x;
    public float y;
    public float z;
    Vector3 move;
    void Start()
    {
        move = new Vector3(x,y,z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = move;
    }
}
