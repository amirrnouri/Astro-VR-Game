using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShoot : MonoBehaviour
{
    public GameObject objectToCreat;
    public float bulletSpeed=5f;
    public bool canShoot;
    public float shootDelay=0.3f;


    // Start is called before the first frame update
    void Start()
    {
        canShoot=true;
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetMouseButtonDown(0)&& canShoot)
        {
            StartCoroutine("Shoot");
            canShoot=false;
        }

    }

    IEnumerator Shoot()
    {
        Instantiate(objectToCreat,transform.position,Quaternion.identity);
        
        yield return new WaitForSeconds(shootDelay);
        canShoot=true;
    }
}
