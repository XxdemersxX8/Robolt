using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformUp : MonoBehaviour {

    public bool dirUp = true;
    public float speed = 2.5f;
    public Vector3 Startpos;
    public float upperlimit = 4.0f;
    public float lowerlimit = 4.0f;

    // Use this for initialization
    void Start()
    {
        Startpos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {


        // Moving the platform depending on it's limit
        if (dirUp)
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        else
            transform.Translate(-Vector2.up * speed * Time.deltaTime);

        if (transform.position.y >= Startpos.y + upperlimit)
        {
            dirUp = false;
        }

        if (transform.position.y <= Startpos.y + lowerlimit)
        {
            dirUp = true;
        }

    }
}
