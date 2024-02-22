using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed = 1;
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if(transform.position.x <= -10.4f)
        {

            transform.position = new Vector3(x: 3.02f, y: 0, z: 0);

        }
    }
}
