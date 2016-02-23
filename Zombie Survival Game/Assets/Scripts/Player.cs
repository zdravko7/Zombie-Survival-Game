using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    bool isAlive = true;

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("dead");

        if (col.gameObject.tag == "Zombie")
        {
            isAlive = false;            
        }
    }
}
