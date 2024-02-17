using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float moveSpeed=5;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb=gameObject.GetComponent<Rigidbody>();
        rb.velocity = transform.forward * moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
