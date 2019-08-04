using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotShoot : MonoBehaviour
{
    public float shootingPower = 50f;
    public float shootingSpeed = 0.25f;
    float lastShot;
    int shootingCount;
    public Transform cannonEnd;
    public GameObject bullet;
    public Vector3 cannonEndVector3;
    public GameObject[] myCannons;
    public Transform[] myCannonEnds;
    public int currentColor;
    public int cannonCount = 1;
    public GameObject[] shootSounds;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i<myCannons.Length; i++)
        {
            myCannons[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0) && Time.time - lastShot >= shootingSpeed)
        {
            Shoot();        
        }

        for(int i = 0; i<cannonCount; i++)
        {
            myCannons[i].SetActive(true);
        }

    }

    void Shoot()
    {
        lastShot = Time.time;

        for(int i = 0; i < cannonCount; i++)
        {
            myCannons[i].transform.Rotate(0, 0, 25, Space.Self);
            GameObject myBullet = Instantiate(bullet, myCannonEnds[i].transform.position, myCannonEnds[i].transform.rotation);
            currentColor++;
            if(currentColor == 7)
                currentColor = 0;
            myBullet.GetComponent<BulletMain>().myColor = currentColor;
            myBullet.GetComponent<BulletMain>().moveSpeed = shootingPower;
            Instantiate(shootSounds[Random.Range(0, shootSounds.Length)]);
            
        }

    }

    public void UpgradeCannon(int cannon, float cannonSpeed, float cannonPower)
    {           
        if(cannonCount < 4)
            cannonCount += cannon;
        if(shootingPower < 5000)
            shootingPower += cannonPower;
        if(shootingSpeed > 0.05)
            shootingSpeed *= cannonSpeed;
    }



}
