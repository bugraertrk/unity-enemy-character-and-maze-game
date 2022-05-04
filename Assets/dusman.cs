using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusman : MonoBehaviour
{
    void OnCollisionEnter(Collision obj)
    {
        Destroy(obj.gameObject);
    }

    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
