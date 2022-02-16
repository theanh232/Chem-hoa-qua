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

        transform.position = new Vector3(Random.Range(-4, 4), -6);

        targetRb.AddTorque(Random.Range(-10, 10), Random.Range(-10,10), Random.Range(-10, 10),ForceMode.Impulse);


    }

    private void OnMouseDown()
    {
        Destroy(gameObject);

    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

    void Update()
    {
        destroygameobject();
    }
    public void destroygameobject()
    {
        if(transform.position.y < -16 )
        {
            Destroy(gameObject);
        }    
    }    
}
