using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]
    // Prefab for instantiating apples
    public GameObject ApplePrefab;

    //Speed at which AppleTree moves
    public float speed = 1f;

    //Distance where AppleTree moves
    public float leftandRightEdge = 10f;

    //Chance that the AppleTree will change directions
    public float chanceToChangeDirections = 0.1f;

    //Rate at which AppleTree will be instantiated
    public float secondsBetweenAppleDrops = 1f;

    // Start is called before the first frame update
    void Start()
    { //Dropping Apples every second 
        
    }

    // Update is called once per frame
    void Update()
    {
        //Basic Movement
        Vector3 pos =
    transform.position;
        pos.x += speed *
    Time.deltaTime;
        transform.position =
    pos;
        //Changing Direction
        if (pos.x < -leftandRightEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos.x > leftandRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }
    }
}
