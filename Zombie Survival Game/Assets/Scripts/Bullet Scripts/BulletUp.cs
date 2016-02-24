using UnityEngine;
using System.Collections;

public class BulletUp : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int shootingSpeed = 35;
        transform.Translate(Vector2.up * Time.deltaTime * shootingSpeed);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Zombie")
        {
            Destroy(gameObject);
        }
    }
}
