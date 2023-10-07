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
        Invoke("DropApple", 2f);
    }

    void DropApple()
    {
        GameObject Apple =

        Instantiate<GameObject>(ApplePrefab);

        Apple.transform.position =

            transform.position;

        Invoke("DropApple", secondsBetweenAppleDrops);

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

        pos.x += speed * Time.deltaTime;
        pos.x += 1.0f * 0.04f;
        pos.x += 0.04f;
            //Changing Direction
            if (pos.x < -leftandRightEdge)
            {                   //a
                speed = Mathf.Abs(speed); //Move right
                                          //b
            }
            else if (pos.x > leftandRightEdge)
            {       //c
                speed = -Mathf.Abs(speed); //Move left
                                           //c
            }
            else if (Random.value < chanceToChangeDirections)
            {


                speed *= -1;


            }
        }

}

