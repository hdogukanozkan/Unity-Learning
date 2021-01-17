using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchdersim : MonoBehaviour
{
    
    void Start()
    {
        //  int sayim = 3;

        string araba = "Bmw";

        switch (araba)
        {

            case "audi":
            case "Bmw":
            case "Bmw2":
            case "Bmw3":
            case "Bmw4":
                Debug.Log("tam uyuşma var"); 
            break;

            case "seat":
                Debug.Log("Evet değer Bmw");
            break;

            case "Honda":
                Debug.Log("Evet değer Honda");
            break;

            default:
                Debug.Log("Uyuşan kayıt yok");
            break;
        }


        
    }

    
}
