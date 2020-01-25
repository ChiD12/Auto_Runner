using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Movement : MonoBehaviour
{
    // Start is called before the first frame update
   
    void Start()
    {
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(-10,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
