using System;
using JetBrains.Annotations;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour

{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        /* string currentWeapon = "Bow";

        switch (currentWeapon)
        {
            case "Sword":
                Debug.Log("You have a " + currentWeapon);
                break;
            
            case "Bow":
                Debug.Log("You have a " + currentWeapon);
                break;
            
             case "Axe":
                Debug.Log("You have a " + currentWeapon);
                break;

                            
             case "Shield":
                Debug.Log("You have a " + currentWeapon);
                break;
                
        }
        


        switch (selectedWeapon)
        {
            case WeaponType.Sword:
                Debug.Log("You have a " + selectedWeapon);
                break;

            case WeaponType.Bow:
                Debug.Log("You have a " + selectedWeapon);
                break;

            case WeaponType.Axe:
                Debug.Log("You have a " + selectedWeapon);
                break;


            case WeaponType.Shield:
                Debug.Log("You have a " + selectedWeapon);
                break;

        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown("1"))
        {
            selectedWeapon = WeaponType.Sword;
            Debug.Log("You have a " + selectedWeapon);
        }

        if (Input.GetKeyDown("2"))
        {
            selectedWeapon = WeaponType.Bow;
            Debug.Log("You have a " + selectedWeapon);
        }

        if (Input.GetKeyDown("3"))
        {
            selectedWeapon = WeaponType.Axe;
            Debug.Log("You have a " + selectedWeapon);
        }

        if (Input.GetKeyDown("4"))
        {
            selectedWeapon = WeaponType.Shield;
            Debug.Log("You have a " + selectedWeapon);
        }
    }

    public enum WeaponType { Sword, Bow, Axe, Shield }

    public WeaponType selectedWeapon = WeaponType.Sword;
    

}
