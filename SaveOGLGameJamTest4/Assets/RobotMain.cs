using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMain : MonoBehaviour
{
    Rigidbody rb;
    public float moveSpeed;
    public float rotationSpeed;
    public Transform top;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, 100))
        {
            Vector3 viewDirection = hit.point - transform.position;
            viewDirection.y = 0;
            top.rotation = Quaternion.LookRotation(viewDirection);
        }
    }

    void FixedUpdate()
    {
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 movement = transform.forward * vertical * moveSpeed * Time.deltaTime;
        rb.MovePosition(transform.position + movement);

        float horizontal = Input.GetAxisRaw("Horizontal");
        Quaternion rotation = Quaternion.Euler(0, horizontal * rotationSpeed * Time.deltaTime, 0);
        rb.MoveRotation(rb.rotation * rotation);
    }
}
