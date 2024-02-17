using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantAstro : MonoBehaviour
{
    public GameObject Astro;
    public float randomSide=1;




    // Update is called once per frame
    public void InstantiateAstro()
    {
        Quaternion angle=Quaternion.Euler(Random.Range(0f,360f),Random.Range(0f,360f),Random.Range(0f,360f));
        Vector3 position=transform.position+new Vector3 (Random.Range(0,randomSide),Random.Range(0,randomSide),Random.Range(0,randomSide));
        Instantiate(Astro,position,angle);
    }
}
