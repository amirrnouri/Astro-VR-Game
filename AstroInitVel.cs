using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroInitVel : MonoBehaviour
{
    public float initVel = 0.03f;
    private Rigidbody rb;
    private GameObject Earth;
    // Start is called before the first frame update
    void Start()
    {
        Earth=GameObject.Find("Earth");
        Vector3 earthpPos= Earth.transform.position;
        Vector3 velDir=earthpPos-transform.position;
        rb=GetComponent<Rigidbody>();
        rb.velocity=velDir*initVel; 
    }


}
