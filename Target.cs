using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public Rigidbody targetRb;

    void Start()
    {
        targetRb = GetComponent<Rigidbody>();

        targetRb.AddForce(Vector3.up*Random.Range(12,16),ForceMode.Impulse); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
