using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunsonu : MonoBehaviour
{

    void OnCollisionEnter(Collision obj)
    {
        Destroy(obj.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
