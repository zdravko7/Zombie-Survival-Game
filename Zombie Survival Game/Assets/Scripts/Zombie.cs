using UnityEngine;
using System.Collections;

public class Zombie : MonoBehaviour {

    public int movementSpeed;
    public string direction;
    

    public Zombie(string direction, int movementSpeed)
    {
        this.movementSpeed = movementSpeed;
        this.direction = direction;
    }

	// Use this for initialization
    //void Start () {
	
    //}
	
    //// Update is called once per frame
    //void Update () {
	
    //}
}
