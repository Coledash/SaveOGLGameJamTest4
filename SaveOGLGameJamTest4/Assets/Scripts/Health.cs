using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float myHealth;
    public GameObject[] myFaces;
    public Sprite happyFace;
    public Sprite angryFace;
    public bool happy;
    public float hateSpeed;
    float lastHate;
    public GameObject hate;

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

    }

    public void ChangeFeeling(int feeling)
    {
        if(feeling == 1)
        {
            happy = true;
            for(int i = 0; i<myFaces.Length; i++)
            {
                myFaces[i].GetComponent<SpriteRenderer>().sprite = happyFace;
            }
        }
        else
        {
            happy = false;
            for(int i = 0; i<myFaces.Length; i++)
            {
                myFaces[i].GetComponent<SpriteRenderer>().sprite = angryFace;
            }
        }
    }

}
