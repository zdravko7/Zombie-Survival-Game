﻿using UnityEngine;
using System.Collections;

public class ZombieRight : MonoBehaviour {

    public string direction = "right";
    public float movementSpeed;
    

    void Start () {
        decimal timePassed = GameObject.Find("TimeKeeper").GetComponent<Timer>().timer;
        movementSpeed += (float)timePassed / 5;
    }
	
    void Update () {

        movementSpeed += 0.01f;
	    //transform.position = Vector3.Lerp(transform.position, new Vector3(0, 0, transform.position.z), movementSpeed);
        transform.Translate(Vector2.right * Time.deltaTime * movementSpeed);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player" || col.gameObject.tag == "Projectile")
        {
            Destroy(gameObject);
            if (col.gameObject.tag == "Projectile")
            {
                GameObject.Find("ScoreKeeper").GetComponent<ScoreKeeper>().score += 1000;
            }
        }
    }
}
