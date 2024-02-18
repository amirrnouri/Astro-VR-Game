using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOMovement : MonoBehaviour
{
    public float forceMag= 10f;
    public float StartMoveDelay=10;
    public float ShootDelay=10;

    public GameObject Portal;
    public GameObject Player;

    public Vector3 nextPos;

    private Vector3 moveDir;

    private Rigidbody rb ;

    public float movementRange=4f;
    void Start()
    {
        nextPos=new Vector3(Random.Range(-10,10),
        Random.Range(5,10),
        Random.Range(20,30));
        //Invoke("StartMove",StartMoveDelay);
        rb = gameObject.GetComponent<Rigidbody>();

        Player=GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        moveDir=nextPos-transform.position;

        if (moveDir.magnitude>2)
        {
            StartMove();
        }
        else
        {
            nextPos+=new Vector3(Random.Range(-movementRange,movementRange),
            Random.Range(-movementRange,movementRange),
            Random.Range(-movementRange,movementRange));
        }
        
            
        transform.LookAt(Player.transform);


    
    }

    void StartMove()
    {
        
        rb.AddForce(moveDir.normalized*forceMag*Time.deltaTime,ForceMode.Force);
            
        
    }


}
