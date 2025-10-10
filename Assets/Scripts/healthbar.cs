using System;
using UnityEngine;

public class healthbar : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int Health = 24;

        if (Health > 80)
        {
            Debug.Log("Excellent health!");
        } else if(Health > 50 && Health < 80){
            Debug.Log("Good health!");
        } else if(Health > 20 && Health < 50){
            Debug.Log("Critical: Very low health!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
