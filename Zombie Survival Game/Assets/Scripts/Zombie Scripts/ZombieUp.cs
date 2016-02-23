using UnityEngine;
using System.Collections;

public class ZombieUp : MonoBehaviour
{
    public string direction = "up";

    void Start()
    {

    }

    void Update()
    {
        int movementSpeed = 5;
        //transform.position = Vector3.Lerp(transform.position, new Vector3(0, 0, transform.position.z), movementSpeed);
        transform.Translate(Vector2.up * Time.deltaTime * movementSpeed);
    }
}
