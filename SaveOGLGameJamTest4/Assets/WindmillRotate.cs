using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindmillRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = GameManager.instance.lovers/10;
       
            transform.Rotate(new Vector3(0, 0, x)); 
    }
}
