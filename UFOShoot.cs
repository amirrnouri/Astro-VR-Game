using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOShoot : MonoBehaviour
{

    public float startShootDelay=8f;
    public float shootDelay=0.5f;
    public GameObject enemyBullet;
    public bool canShoot=false;
    // Start is called before the first frame update
    void Start()
    {
        canShoot=false;
        Invoke("StartShoot",startShootDelay);




    }

    // Update is called once per frame
    void Update()
    {
    }

    void Shoot()
    {
        Instantiate(enemyBullet,transform.position,transform.rotation);
    }

    void StartShoot()
    {
        canShoot=true;
        InvokeRepeating("Shoot", 0f, shootDelay);

    }
}
