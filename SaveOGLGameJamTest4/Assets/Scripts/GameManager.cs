using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    public Transform[] agentDestinations;
    public float lovers;

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
