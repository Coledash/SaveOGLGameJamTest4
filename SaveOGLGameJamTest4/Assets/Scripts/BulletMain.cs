using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMain : MonoBehaviour
{
    Rigidbody rb;
    public float moveSpeed; 
    public float forceMult = 200;
    public Material[] myMaterials;
    public int myColor;
    public bool rainbow;

    // Start is called before the first frame update
    void Start()
    {
        if(rainbow)
            GetComponent<MeshRenderer>().material = myMaterials[myColor];
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * moveSpeed * Time.deltaTime;
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
