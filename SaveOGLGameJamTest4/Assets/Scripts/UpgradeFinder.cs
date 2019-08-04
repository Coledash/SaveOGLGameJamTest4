using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeFinder : MonoBehaviour
{
    public bool cannonCount;
    public int howManyCannons;
    public bool cannonSpeed;
    public float howMuchSpeed;
    public bool cannonPower;
    public float howMuchPower;
    public GameObject[] soundEffects;
    

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
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponentInParent<RobotShoot>().UpgradeCannon(howManyCannons, howMuchSpeed, howMuchPower);

            Instantiate(soundEffects[Random.Range(0, soundEffects.Length)]);
            Destroy(transform.parent.gameObject);
        }
    }

}
