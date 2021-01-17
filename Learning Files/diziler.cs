using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diziler : MonoBehaviour
{
   
    void Start()
    {
        /*
        int[] sayilarim = new int[5];
        string[] yazilarim = new string[2];
        */

        /* int[] sayilarim = new int[] {1,2,56,8,9,4};

         Debug.Log(sayilarim[4]);*/
        /*
        int[] sayilarim= { 1, 2, 56, 8, 9, 4 };*/

        string[][] arabalar = new string[3][];

        arabalar[0] = new string[] { "Bmw", "Audi", "Seat" };
        arabalar[1] = new string[] { "2010", "2009", "2006" , "2002" };
        arabalar[2] = new string[] { "140hp", "100hp", "90hp" };

        Debug.Log(arabalar[0][1]); // audi
        Debug.Log(arabalar[1][0]); // audi




    }


}
