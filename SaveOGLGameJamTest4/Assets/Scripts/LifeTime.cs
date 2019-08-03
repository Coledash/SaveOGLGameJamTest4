using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTime : MonoBehaviour
{
    public float myLifeTimeMin;
    public float myLifeTimeMax;
    float myLifeTime;

    // Start is called before the first frame update
    void Start()
    {
        myLifeTime = Random.Range(myLifeTimeMin, myLifeTimeMax);
    }

    // Update is called once per frame
    void Update()
    {
        myLifeTime -= Time.deltaTime;
        if(myLifeTime <= 0)
            Destroy(gameObject);
    }
}
