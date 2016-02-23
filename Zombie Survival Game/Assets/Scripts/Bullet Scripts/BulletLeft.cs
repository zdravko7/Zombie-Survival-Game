using UnityEngine;
using System.Collections;

public class BulletLeft : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        int movementSpeed = 5;

        transform.Translate(Vector2.left * Time.deltaTime * movementSpeed);

    }
}
