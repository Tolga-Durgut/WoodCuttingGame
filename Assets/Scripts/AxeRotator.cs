using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AxeRotator : MonoBehaviour
{
    bool rotate = false;
    bool stop = true;
    [SerializeField] float rotationSpeed = 0.2f;
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rotate = true;
        }

        if (rotate)
        {
            transform.Rotate(Vector3.forward * -rotationSpeed * Time.deltaTime);
        }
        else if(!rotate && !stop)
        {
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
            
        }
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.tag == "Stopper")
        {
            stop = true;
        }
        else if (other.gameObject.tag == "Log")
        {
            rotate = false;
            stop = false;
        }
        
    }
}

