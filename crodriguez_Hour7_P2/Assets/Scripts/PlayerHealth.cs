using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float health = 1129.5f;  // increased healht 125.5 to get 1004 on Console
        float PoisonDamage = 125.5f;

        while ( health > 0) 
        {
             health = health -= PoisonDamage;
            Debug.Log(health);

        }

        if (health <= 0)
        {
            Debug.Log("Player has been unalived");

        }

        //health -= PoisonDamage;
        //Debug.Log(health);

        //health -= PoisonDamage;
        //Debug.Log(health);

        //health -= PoisonDamage;
        //Debug.Log(health);

       // health -= PoisonDamage;
        //Debug.Log(health);

        //health -= PoisonDamage;
        //Debug.Log(health);

        //health -= PoisonDamage;
        //Debug.Log(health);

        //health -= PoisonDamage;
        //Debug.Log(health);

        //health -= PoisonDamage;
        //Debug.Log(health);

        //Debug.Log("Player has been unalived!");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
