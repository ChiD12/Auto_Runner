using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collision : MonoBehaviour
{
    // Start is called before the first frame update
    public Text score;
    int intScore;
    void Start()
    {
        intScore =0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Collectable") {
            intScore++;
            score.text = "Score: " + intScore; 
            Debug.Log(intScore);
            Destroy(other.gameObject);
        }
     }
}
