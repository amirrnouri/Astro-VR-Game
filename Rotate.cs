using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotationSpeedX=10;
    public float rotationSpeedY=10;
    public float rotationSpeedZ=10;

    public bool randomSpeed=false;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (randomSpeed)
        {
            rotationSpeedX+=Random.Range(-10,10);
            rotationSpeedY+=Random.Range(-10,10);
            rotationSpeedZ+=Random.Range(-10,10);

        }

        transform.Rotate(rotationSpeedX*Time.deltaTime,rotationSpeedY*Time.deltaTime,rotationSpeedZ*Time.deltaTime);
    }
}
