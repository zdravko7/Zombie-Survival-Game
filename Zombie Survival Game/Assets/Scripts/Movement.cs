using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public Sprite spriteLeft;
    public Sprite spriteRight;
    public Sprite spriteUp;
    public Sprite spriteDown;

	// Use this for initialization
	void Start () {

        //sprite = Resources.Load("Models/hero.png") as Sprite;
                
	}
	
	// Update is called once per frame
	void Update () {

        //keyboard input
        InputHandler();    
	}




    public void InputHandler()
    {
        //keyboard input
        if (Input.GetKey("right"))
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = spriteRight;
            transform.Translate(Vector2.right * Time.deltaTime * 5);
        }
        else if (Input.GetKey("left"))
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = spriteLeft;
            transform.Translate(Vector2.left * Time.deltaTime * 5);
        }
        else if (Input.GetKey("up"))
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = spriteUp;
            transform.Translate(Vector2.up * Time.deltaTime * 5);
        }
        else if (Input.GetKey("down"))
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = spriteDown;
            transform.Translate(Vector2.down * Time.deltaTime * 5);
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


