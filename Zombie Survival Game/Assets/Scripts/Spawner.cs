using System;
using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public System.Random directionRandom = new System.Random();
    public Transform zombie;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {

        int newDirection = directionRandom.Next(1,5);
        string direction = "";

        //1 = up
        //2 = right
        //3 = down
        //4 = left

        switch (newDirection)
        {      
            case 1:
                direction = "up";

                Instantiate(zombie, new Vector3(5, 0, 3), new Quaternion());

                break;

            case 2:
                

                direction = "right";
                Instantiate(zombie, new Vector3(5,0,3), new Quaternion());
               
                break;


            case 3:
                direction = "down";
                Instantiate(zombie, new Vector3(5, 0, 3), new Quaternion());


                break;


            case 4:
                direction = "left";
                Instantiate(zombie, new Vector3(5, 0, 3), new Quaternion());

                break;
        }

        Debug.Log(newDirection.ToString());

	}
}
