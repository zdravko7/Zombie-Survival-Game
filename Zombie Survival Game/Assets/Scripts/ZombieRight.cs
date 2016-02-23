using UnityEngine;
using System.Collections;

public class ZombieRight : MonoBehaviour {

    
    public string direction = "right";

    void Start () {
	
    }
	
    void Update () {

        int movementSpeed = 5;
	    //transform.position = Vector3.Lerp(transform.position, new Vector3(0, 0, transform.position.z), movementSpeed);
        transform.Translate(Vector2.right * Time.deltaTime * movementSpeed);
    }
}
