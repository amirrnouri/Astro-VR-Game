using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotationSpeedX=10;
    public float rotationSpeedY=10;
    public float rotationSpeedZ=10;

    public bool randomSpeed=false;

    public float randomRange=5f;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (randomSpeed)
        {
            rotationSpeedX+=Random.Range(-randomRange,randomRange);
            rotationSpeedY+=Random.Range(-randomRange,randomRange);
            rotationSpeedZ+=Random.Range(-randomRange,randomRange);

        }

        transform.Rotate(rotationSpeedX*Time.deltaTime,rotationSpeedY*Time.deltaTime,rotationSpeedZ*Time.deltaTime);
    }
}
