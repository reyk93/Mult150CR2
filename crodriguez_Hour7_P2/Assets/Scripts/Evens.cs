using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int MainNum = 22;

        while (MainNum <= 100) 
        {
            Debug.Log(MainNum);
            MainNum++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
