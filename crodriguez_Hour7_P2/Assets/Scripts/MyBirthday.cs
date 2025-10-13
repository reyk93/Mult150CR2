using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int DecemberDays = 1;

        while (DecemberDays <= 31) 
        {
            Debug.Log(DecemberDays);
            DecemberDays++;

            if (DecemberDays == 30)
            {
                Debug.Log("Its my Birthday!");

            }
        

            


        }
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
