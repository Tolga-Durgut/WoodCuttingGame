using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{
    [SerializeField] float cloudSpeed = 2f;
    [SerializeField] float cloudTreshhold = 4f;
    float distance;
    void Update()
    {

        transform.Translate(Vector2.left * Time.deltaTime * cloudSpeed);

        if (transform.position.x <= -cloudTreshhold)
        {
            distance = Vector2.Distance(transform.position ,new Vector2( -cloudTreshhold , transform.position.y));
            transform.position = new Vector2(cloudTreshhold - distance, transform.position.y);
        }
        
    }
}
