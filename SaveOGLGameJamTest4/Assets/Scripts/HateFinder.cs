using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HateFinder : MonoBehaviour
{
    public GameObject myParent;

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
        if(other.gameObject.tag == "Hate" && myParent.GetComponent<Health>().happy)
        {
            myParent.GetComponent<Health>().ChangeFeeling(0);
            Destroy(other.gameObject);
        }
    }
}
