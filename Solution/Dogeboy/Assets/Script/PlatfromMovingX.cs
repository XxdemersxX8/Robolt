using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatfromMovingX : MonoBehaviour {

    public bool dirRight = true;
    public float speed = 2.5f;
    public Vector3 Startpos;
    public float Rightlimit = 4.0f;
    public float Leftlimit = 4.0f;

    // Use this for initialization
    void Start()
    {
        Startpos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {


        // Moving the platform depending on it's limit
        if (dirRight)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        else
            transform.Translate(-Vector2.right * speed * Time.deltaTime);

        if (transform.position.x >= Startpos.x + Rightlimit)
        {
            dirRight = false;
        }

        if (transform.position.x <= Startpos.x + Leftlimit)
        {
            dirRight = true;
        }

    }
}
