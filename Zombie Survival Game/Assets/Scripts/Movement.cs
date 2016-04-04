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

        //sprite = Resources.Load("Models/hero.png") as Sprite;
                
	}
	
	// Update is called once per frame
	void Update () {

        timer++;
        timeBetweenAttacks /= 1.0000001f;

        //keyboard input
        InputHandler();    
	}


    public void InputHandler()
    {
        //keyboard input
        if (Input.GetKeyDown("right") && timer > timeBetweenAttacks * 60)
        {
            
            gameObject.GetComponent<SpriteRenderer>().sprite = spriteRight;
            Instantiate(bulletRight, new Vector3(0, 0.6f, 0), new Quaternion(0, 0, 0, 0));

            timer = 0;

            //transform.Translate(Vector2.right * Time.deltaTime * 5);
        }
        else if (Input.GetKeyDown("left") && timer > timeBetweenAttacks*60)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = spriteLeft;
            Instantiate(bulletLeft, new Vector3(0, 0.74f, 0), new Quaternion());
            //Instantiate(bullet, new Vector3(0, 0, 0), new Quaternion());

            timer = 0;

            //transform.Translate(Vector2.left * Time.deltaTime * 5);
        }
        else if (Input.GetKeyDown("up") && timer > timeBetweenAttacks * 60)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = spriteUp;
            Instantiate(bulletUp, new Vector3(0.3f, 0.75f, 0), new Quaternion());
            //Instantiate(bullet, new Vector3(0, 0, 0), new Quaternion());
            //transform.Translate(Vector2.up * Time.deltaTime * 5);
            timer = 0;

        }
        else if (Input.GetKeyDown("down") && timer > timeBetweenAttacks * 60)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = spriteDown;
            Instantiate(bulletDown, new Vector3(-0.2f, 0.5f, 0), new Quaternion());
            //Instantiate(bullet, new Vector3(0, 0, 0), new Quaternion());
            //transform.Translate(Vector2.down * Time.deltaTime * 5);

            timer = 0;

        }

        
        //mouse input
        if (Input.GetMouseButtonDown(0))
        {
            //shows mouse position
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 10.0f;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            //Debug.Log(mousePos.ToString());

            float x = mousePos.x;
            float y = mousePos.y;

            //Debug.Log(x.ToString());
            //Debug.Log(y.ToString());

            if (IsPointInTriangle(new Vector2(x, y), new Vector2(-11, 7), new Vector2(-11, -5), new Vector2(0, 0)))
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = spriteLeft;
                //Debug.Log("Yes veee");
            }
            if (IsPointInTriangle(new Vector2(x, y), new Vector2(11, 7), new Vector2(11, -5), new Vector2(0, 0)))
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = spriteRight;
                //Debug.Log("Yes veee");
            }
            if (IsPointInTriangle(new Vector2(x, y), new Vector2(-11, 7), new Vector2(11, 7), new Vector2(0, 0)))
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = spriteUp;
                //Debug.Log("Yes veee");
            }
            if (IsPointInTriangle(new Vector2(x, y), new Vector2(-11, -5), new Vector2(11, -5), new Vector2(0, 0)))
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = spriteDown;
                //Debug.Log("Yes veee");
            }


            //now maths
        }
    }

    public bool IsPointInTriangle(Vector2 pt, Vector2 v1, Vector2 v2, Vector2 v3)
    {
      float TotalArea = CalcTriArea(v1, v2, v3);
      float Area1 = CalcTriArea(pt, v2, v3);
      float Area2 = CalcTriArea(pt, v1, v3);
      float Area3 = CalcTriArea(pt, v1, v2);

      if((Area1 + Area2 + Area3) > TotalArea)
        return false;
      else
        return true;
    }

    public float CalcTriArea(Vector2 v1, Vector2 v2, Vector2 v3)
    {
        float det = 0.0f;

        det = System.Math.Abs(((v1.x - v3.x) * (v2.y - v3.y)) - ((v2.x - v3.x) * (v1.y - v3.y)));
        // v1.x * (v2.y - v3.y) + v2.x * (v3.y - v1.y) + v3.x * (v1.y - v2.y);
        //det = ((v1->x - v3->x) * (v2->y - v3->y)) - ((v2->x - v3->x) * (v1->y - v3->y));
        return (det / 2.0f);
    }

}


