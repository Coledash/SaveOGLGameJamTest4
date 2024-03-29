﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float myHealth;
    public GameObject[] myFaces;
    public Sprite happyFace;
    public Sprite angryFace;
    public bool happy;
    public GameObject[] zombieSounds;

    // Love
    public GameObject love;
    public float loveSpeed;
    float lastLove;

    // Hate
    public GameObject hate;
    public float hateSpeed;
    float lastHate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(myHealth <= 0)
        {
            myHealth = 10;
            happy = true; 
            for(int i = 0; i<myFaces.Length; i++)
            {
                myFaces[i].GetComponent<SpriteRenderer>().sprite = happyFace;
            }
        }  

        if(!happy && Time.time - lastHate >= hateSpeed)
        {
            Vector3 location = transform.position + new Vector3(0, 2, 0);
            Instantiate(hate, location, Quaternion.identity);
            lastHate = Time.time;
        }
        else if(happy && Time.time - lastLove >= loveSpeed)
        {
            Vector3 location = transform.position + new Vector3(0, 2, 0);
            Instantiate(love, location, Quaternion.identity);
            lastLove = Time.time;
        }

        if(!happy && Random.Range(0, 4000) == 0)
        {
            Instantiate(zombieSounds[Random.Range(0, zombieSounds.Length)]);
        }

    }

    public void ChangeFeeling(int feeling)
    {
        if(feeling == 1)
        {
            GameManager.instance.lovers++;
            happy = true;
            for(int i = 0; i<myFaces.Length; i++)
            {
                myFaces[i].GetComponent<SpriteRenderer>().sprite = happyFace;
            }
        }
        else
        {
            GameManager.instance.lovers--;
            happy = false;
            for(int i = 0; i<myFaces.Length; i++)
            {
                myFaces[i].GetComponent<SpriteRenderer>().sprite = angryFace;
            }
        }
    }

}
