using UnityEngine;
using System.Collections;

public class ZombieDown : MonoBehaviour
{

    public string direction = "down";

    void Start()
    {

    }

    void Update()
    {
        int movementSpeed = 5;
        //transform.position = Vector3.Lerp(transform.position, new Vector3(0, 0, transform.position.z), movementSpeed);
        transform.Translate(Vector2.down * Time.deltaTime * movementSpeed);
    }
}
