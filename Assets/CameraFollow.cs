using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;
    public float smoothSpeed = 0.5f;

    // Update is called once per frame
    void Update()
    {
        if (target.position.y > transform.position.y)
        {
            //transform.position = new Vector3(transform.position.x, target.position.y, transform.position.z);
            //transform.position = Vector3.Lerp(transform.position, newPos, smoothSpeed * Time.deltaTime);

            Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, newPos, smoothSpeed * Time.deltaTime);
        }
    }
}
