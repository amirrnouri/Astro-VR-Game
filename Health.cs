using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameState gameState;
    public float maxHealth;
    public float damagePower;
    public float destroyScore;

    public Dictionary<string, float> gameObjectData = new Dictionary<string, float>();

    void Start()
    {
        gameObjectData["AstroBigMaxHealth"] = 100f;
        gameObjectData["AstroBigDamagePower"] = 100f;
        gameObjectData["AstroBigScore"] = 100f;

        gameObjectData["AstroMedMaxHealth"] = 50f;
        gameObjectData["AstroMedDamagePower"] = 50f;
        gameObjectData["AstroMedScore"] = 50f;

        gameObjectData["AstroLilMaxHealth"] = 50f;
        gameObjectData["AstroLilDamagePower"] = 50f;
        gameObjectData["AstroLilScore"] = 50f;

        gameObjectData["UFOMaxHealth"] = 50f;
        gameObjectData["UFOScore"] = 50f;
        gameObjectData["UFOBulletPower"] = 10f;

        gameObjectData["PlayerBulletPower"] = 50f;

        gameObjectData["EarthMaxHealth"] = 1000f;
        gameObjectData["EarthDamagePower"] = 1000f;

        maxHealth=gameObjectData[gameObject.tag+"MaxHealth"];
        damagePower=gameObjectData[gameObject.tag+"DamagePower"];

        if(gameObjectData.ContainsKey(gameObject.tag+"Score"))
        {
        destroyScore=gameObjectData[gameObject.tag+"Score"];

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
