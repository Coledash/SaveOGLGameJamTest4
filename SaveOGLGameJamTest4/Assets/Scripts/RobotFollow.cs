using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotFollow : MonoBehaviour
{
    public Transform target;
    Vector3 distance;

    // Start is called before the first frame update
    void Start()
    {
        distance = transform.position - target.position;
    }

    void LateUpdate()
    {
        transform.position = target.position + distance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
