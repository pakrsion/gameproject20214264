using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public float destructionDelay = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, destructionDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
