using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthGravity : MonoBehaviour
{
    public float gravityForce=10;
    public GameObject Earth;
    private Rigidbody rb;
    public Vector3 earthPos;
    public Vector3 gravityDir;
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        Earth=GameObject.Find("Earth");
        earthPos=Earth.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        gravityDir=earthPos-transform.position;
        float dirMag=gravityDir.magnitude;
        rb.AddForce(gravityForce*Time.deltaTime*gravityDir.normalized/dirMag/dirMag,ForceMode.Force);
    }
}
