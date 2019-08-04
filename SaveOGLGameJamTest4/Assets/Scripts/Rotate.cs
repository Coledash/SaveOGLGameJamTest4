using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float xRotateSpeed;
    public float yRotateSpeed;
    public float zRotateSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(xRotateSpeed, yRotateSpeed, zRotateSpeed));    
    }
}
