using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invokemethod : MonoBehaviour
{
    // Invoke


    void Start()
    {
        // Invoke("yaziyaz", 3f);      
        InvokeRepeating("yaziyaz", 3f,.8f);
    }

   void yaziyaz()
    {
        Debug.Log("Ben fonksiyondan geliyorum");

    }


    private void Update()
    {

        if (IsInvoking("yaziyaz"))     
            Debug.Log("evet");
        else
            Debug.Log("hayır");



        if (Input.GetKeyDown("space"))
        {
            CancelInvoke();
        }
    }




}
