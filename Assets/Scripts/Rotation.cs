using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rotation : MonoBehaviour {

    public float speed = 1.0f;
    public float max = 45f;
    public float min = 315f;

    public float angleX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotation = speed * Input.GetAxis("Mouse X");
        transform.Rotate(rotation, 0, 0);

        angleX = transform.eulerAngles.x;

        Vector3 rot = transform.eulerAngles;
        

        if (rot.x > max && rot.x < 180) {
            rot.x = max;
            transform.eulerAngles = rot;
        }
        if (rot.x < min && rot.x > 270) {
            rot.x = min;
            transform.eulerAngles = rot;
        }
    }

}