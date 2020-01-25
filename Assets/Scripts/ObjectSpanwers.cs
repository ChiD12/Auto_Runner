using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpanwers : MonoBehaviour
{

    public GameObject Projectileprefab; //a prefab is an object that is not part of the scene. but within the project

    //used for the area where it will spawn in
    public Vector3 size;
    public Vector3 center;




    // Start is called before the first frame update
    void Start()
    {

        SpawnObjects();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q)) {
            SpawnObjects();
        }
    }

    public void SpawnObjects() //spawns the random flying objects (projectiles, crates, etc)
    {
        Vector3 spawnPos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), 0, Random.Range(-size.z / 2, size.z / 2)); //this gets the exact coordinates that ranges in the cube FOR each axis

        Instantiate(Projectileprefab, spawnPos, Quaternion.identity); //this will spawn the actual object which will be within the randomly generated position 
    
    }


    void OnDrawSpawn() //this is the shape that is used to spawn objects into (i.e, where random objects will spawn)
    {
        Gizmos.color = new Color(1, 0, 0, 0.75f); //color rgb range (3), alpha

        Gizmos.DrawCube(center, size); //draw the cube using these parameters size and center

    }
}
