using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOSpawn : MonoBehaviour
{
    public GameObject UFO;
    public float createDelay=5f;
    public bool noUFO=true;

    public bool spawnStart=true;

    // Start is called before the first frame update
    
    void Start()
    {
        noUFO=true;
        spawnStart=true;

    }

    void Update()
    {
        if (noUFO)
        StartCoroutine(Spawn());

        if (GameObject.FindWithTag("UFO")==null && !spawnStart) noUFO=true;
        
    }

    // Update is called once per frame
    private IEnumerator Spawn()
    {
        noUFO=false;
        spawnStart=true;
        yield return new WaitForSeconds(createDelay);
        Instantiate(UFO,transform.position,Quaternion.identity);
        spawnStart=false;


    }
}
