using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroSpawner : MonoBehaviour
{
    public GameObject Astro;
    public float spawnDelay=5f;
    public float randomBoxSide=2f;
    public GameState gameState;
    void Start()
    {
        StartCoroutine("Spawn");
    }

    // Update is called once per frame
   IEnumerator Spawn()
   {
        Quaternion randomRot = Quaternion.Euler(Random.Range(0f, 360f), Random.Range(0f, 360f), Random.Range(0f, 360f)); 

        Instantiate(Astro,transform.position+ new Vector3(0f,0f,-5f),randomRot);

        while(!gameState.GameOver)
        {
             yield return new WaitForSeconds(spawnDelay);

            float randomX = Random.Range(0f, 360f);
            float randomY = Random.Range(0f, 360f);
            float randomZ = Random.Range(0f, 360f);
            randomRot = Quaternion.Euler(randomX, randomY, randomZ); 

            Vector3 spawnPos= transform.position+new Vector3(Random.Range(-randomBoxSide,+randomBoxSide),
            Random.Range(-randomBoxSide,+randomBoxSide),
            Random.Range(-randomBoxSide,+randomBoxSide));
            Instantiate(Astro,spawnPos,randomRot);
        }
   }
}
