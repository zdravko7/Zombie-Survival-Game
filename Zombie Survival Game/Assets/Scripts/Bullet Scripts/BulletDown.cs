using UnityEngine;
using System.Collections;

public class BulletDown : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int movementSpeed = 5;
        transform.Translate(Vector2.down * Time.deltaTime * movementSpeed);

    }
}
