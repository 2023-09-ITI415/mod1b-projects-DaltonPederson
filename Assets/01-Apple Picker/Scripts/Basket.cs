using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket : MonoBehaviour {
    [Header("Set dynamically")]

    public Text scoreGT;    //this has to refer to a legacy Text UI object
                            // be sure to  1) add using TMPro in using block 
                            //             2)change datatype to TextMeshProUGUI in declaration
                            //             3) change GetComponent datatype to TextMeshProUGUI

    // Start is called before the first frame update
    void Start() { 
        //Find a reference to the ScoreCounter GameObject

        GameObject scoreGO =

        GameObject.Find("ScoreCounter");

        scoreGT =

            scoreGO.GetComponent<Text>();

        scoreGT.text = "0";  
        
    }

    // Update is called once per frame
    void Update() {
        //Get the current screen position of the mouse from the input
        Vector3 mousePos2D =
            Input.mousePosition;

        //Camera's z position sets how far to push the mouse into 3D

        mousePos2D.z = -Camera.main.transform.position.z;
        //Convert the point from 2D screen space into 3D game
        //world space 
        Vector3 mousePos3D =
               Camera.main.ScreenToWorldPoint(mousePos2D);

        //Move the x position of this basket to the
        //x position of the mouse

        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;

    }

    void OnCollisionEnter(Collision coll)
        {
            GameObject collidedWith = coll.gameObject;

            if (collidedWith.tag == "Apple")
            {
                Destroy(collidedWith);
            }






            int score =

                        int.Parse(scoreGT.text);

            score += 100;

            scoreGT.text = score.ToString();

            if (score > HighScore.score)
            {
                HighScore.score = score;
            }

        }

    }

