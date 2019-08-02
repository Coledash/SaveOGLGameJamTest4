using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMain : MonoBehaviour
{
    Rigidbody rb;
    public float moveSpeed; 
    public float forceMult = 200;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * Time.deltaTime * moveSpeed;
        //transform.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        // rb.MovePosition(transform.position + (Vector3.forward * moveSpeed * Time.deltaTime));
    }

}
