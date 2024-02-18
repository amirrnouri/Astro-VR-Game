using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public GameState gameState;
    public float maxHealth;
    public float currentHealth;

    public float damagePower;
    public float destroyScore;

    public UnityEvent OnDestroy;

    public Dictionary<string, float> gameObjectData = new Dictionary<string, float>();

    void Start()
    {
        gameObjectData["AstroBigMaxHealth"] = 100f;
        gameObjectData["AstroBigDamagePower"] = 100f;
        gameObjectData["AstroBigScore"] = 100f;

        gameObjectData["AstroMedMaxHealth"] = 50f;
        gameObjectData["AstroMedDamagePower"] = 50f;
        gameObjectData["AstroMedScore"] = 50f;

        gameObjectData["AstroSmalMaxHealth"] = 50f;
        gameObjectData["AstroSmalDamagePower"] = 50f;
        gameObjectData["AstroSmalScore"] = 50f;

        gameObjectData["UFOMaxHealth"] = 50f;
        gameObjectData["UFOScore"] = 50f;
        gameObjectData["UFOBulletPower"] = 10f;

        gameObjectData["PlayerBulletPower"] = 50f;

        gameObjectData["EarthMaxHealth"] = 1000f;
        gameObjectData["EarthDamagePower"] = 1000f;

        gameObjectData["PlayerMaxHealth"] = 500f;
        gameObjectData["PlayerDamagePower"] = 1000f;

        gameObjectData["BulletMaxHealth"] = 1f;
        gameObjectData["BulletDamagePower"] = 50f;

        gameObjectData["EnemyBulletMaxHealth"] = 1f;
        gameObjectData["EnemyBulletDamagePower"] = 5;
        gameObjectData["EnemyBulletScore"] = 0f;


        gameObjectData["UFOMaxHealth"] = 50f;
        gameObjectData["UFODamagePower"] = 50f;
        gameObjectData["UFOScore"] = 200f;




        maxHealth=gameObjectData[gameObject.tag+"MaxHealth"];
        damagePower=gameObjectData[gameObject.tag+"DamagePower"];
        currentHealth=maxHealth;

        if(gameObjectData.ContainsKey(gameObject.tag+"Score"))
        {
        destroyScore=gameObjectData[gameObject.tag+"Score"];


        //gameState = GetComponent<GameState>();

        }

    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth>maxHealth)
        {
            currentHealth=maxHealth;
        }

        if (currentHealth<=0)
        {
            Destroy(gameObject);
            
            OnDestroy?.Invoke();

            if (gameObject.tag!="Player" && gameObject.tag!="Bullet" && gameObject.tag!="Earth" && gameObject.tag!="UFOBullet" )
            {
            gameState.IncreaseScore(gameObjectData[gameObject.tag+"Score"]);
            }
        }


        
    }

    void OnTriggerEnter(Collider collider)
    {
        if (gameObject.tag=="Player" && collider.tag=="Bullet") return;
        if (gameObject.tag=="Bullet" && collider.tag=="Player") return;

        if (collider.TryGetComponent<Health>(out Health colliderHealth)) 
        {
            currentHealth -= colliderHealth.gameObjectData[collider.tag + "DamagePower"];
        }
    }

    

}
