using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    static public GameObject POI; //static point of interest

    [Header("Set Dynamically")]

    public float camZ; //desired z pos of camera 

    void Awake()
    {
        camZ = this.transform.position.z;
        
    }

    [Header("Set in Inspector")]
    public float easing = 0.05f;
    public Vector2 minXY = Vector2.zero;
    void FixedUpdate()
    {

  Vector3 destination;

  if (POI == null)
        {
            destination = Vector3.zero;
        } else
        {
            destination = POI.transform.position;

            if (POI.tag == "Projectile")
            {
                if (POI.GetComponent<Rigidbody>().IsSleeping())
                {
                    POI = null;
                    return;
                }
            }
        }

        destination = Vector3.Lerp(transform.position,
            destination, easing);

        destination.z = camZ;
        //set camera to the destination

        transform.position = destination;

        destination.x = Mathf.Max(minXY.x, destination.x);
        destination.y = Mathf.Max(minXY.y, destination.y);

        Camera.main.orthographicSize = destination.y + 10;
        

    }
}
