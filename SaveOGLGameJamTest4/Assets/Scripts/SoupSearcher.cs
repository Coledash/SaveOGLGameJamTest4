﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoupSearcher : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Hate")
        {
            Destroy(other.gameObject);
            Destroy(transform.parent.gameObject);
            
        }

        if(other.gameObject.GetComponent<Health>())
        {
            other.gameObject.GetComponent<Health>().myHealth -= 1;
            //Destroy(transform.parent.gameObject);
        }

    }
}
