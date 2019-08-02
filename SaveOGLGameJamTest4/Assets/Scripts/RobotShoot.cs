using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotShoot : MonoBehaviour
{
    public LineRenderer[] cannons;
    public float shootingPower = 50f;
    public float shootingDistance = 12f;
    public float shootingSpeed = 0.25f;
    public float laserRaySpeed = 50f;
    float lastShot;
    int shootingCount;
    public Transform cannonEnd;
    public GameObject bullet;
    public Vector3 cannonEndVector3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0) && Time.time - lastShot >= shootingSpeed)
        {
            Shoot();        
        }

    }

    void Shoot()
    {
        lastShot = Time.time;
        Instantiate(bullet, cannonEnd.transform.position, cannonEnd.transform.rotation);
        // LineRenderer cannon = cannons[++shootingCount % 2];
        // Ray ray = new Ray(cannon.transform.position, cannon.transform.forward);
        // RaycastHit hit;
        // Vector3 endPoint;
        // if(Physics.Raycast(ray, out hit, shootingDistance))
        // {
        //     endPoint = hit.point;
        //     if(hit.transform.CompareTag("Enemy"))
        //     {
                
        //     }
        // }
        // else
        // {
        //     endPoint = ray.origin + ray.direction * shootingDistance;
        // }
        // cannon.SetPositions(new Vector3[] {ray.origin, endPoint});
        // cannon.enabled = true;
        // lastShot = Time.time;

    }

}
