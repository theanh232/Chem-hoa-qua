using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanagers : MonoBehaviour
{
    public List<GameObject> target;
   private float spawnRate = 1.0f;
    void Start()

    {

        StartCoroutine(SqawnTarget());
        
    }

    
    void Update()
    {
        
    }
    IEnumerator  SqawnTarget()
    {
        while(true)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, target.Count);
            Instantiate(target[index]);

        }

    }
}
