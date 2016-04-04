using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public Sprite spriteLeft;
    public Sprite spriteRight;
    public Sprite spriteUp;
    public Sprite spriteDown;

    public Transform bulletRight;
    public Transform bulletLeft;
    public Transform bulletUp;
    public Transform bulletDown;

    public float timeBetweenAttacks;
    private ulong timer;

	// Use this for initialization
	void Start () {                
	}
	
	// Update is called once per frame
	void Update () {

        timer++;
        timeBetweenAttacks /= 1.0000001f;

        InputHandler();    
	}

    //keyboard input
    public void InputHandler()
    {    
        if (Input.GetKeyDown("right") && timer > timeBetweenAttacks * 60)
        {
            
            gameObject.GetComponent<SpriteRenderer>().sprite = spriteRight;
            Instantiate(bulletRight, new Vector3(0, 0.6f, 0), new Quaternion(0, 0, 0, 0));

            timer = 0;
        }
        else if (Input.GetKeyDown("left") && timer > timeBetweenAttacks*60)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = spriteLeft;
            Instantiate(bulletLeft, new Vector3(0, 0.74f, 0), new Quaternion());

            timer = 0;
        }
        else if (Input.GetKeyDown("up") && timer > timeBetweenAttacks * 60)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = spriteUp;
            Instantiate(bulletUp, new Vector3(0.3f, 0.75f, 0), new Quaternion());

            timer = 0;

        }
        else if (Input.GetKeyDown("down") && timer > timeBetweenAttacks * 60)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = spriteDown;
            Instantiate(bulletDown, new Vector3(-0.2f, 0.5f, 0), new Quaternion());
            timer = 0;

        }      
    }
}


