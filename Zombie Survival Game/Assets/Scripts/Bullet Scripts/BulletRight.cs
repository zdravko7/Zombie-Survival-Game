using UnityEngine;
using System.Collections;

public class BulletRight : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        int movementSpeed = 5;

        transform.Translate(Vector2.right * Time.deltaTime * movementSpeed);

	}
}
