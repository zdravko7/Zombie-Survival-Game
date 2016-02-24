using UnityEngine;
using System.Collections;

public class ZombieLeft : MonoBehaviour
{
    public string direction = "left";
    public float movementSpeed;

    void Start()
    {
        movementSpeed = 5;
    }

    void Update()
    {
        movementSpeed += 0.01f;
        //transform.position = Vector3.Lerp(transform.position, new Vector3(0, 0, transform.position.z), movementSpeed);
        transform.Translate(Vector2.left * Time.deltaTime * movementSpeed);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(gameObject);
    }
}
