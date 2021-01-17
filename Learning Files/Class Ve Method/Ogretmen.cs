using System;
using UnityEngine;

public class Ogretmen : Ogrenci
{
   
    protected void OgrenciveOgretmenAdiniYollar(string ogretmenad, string ogrenciad)
    {
        Ogrenciadiver(ogrenciad);
        Debug.Log("Öğretmen adı " + ogretmenad);

    }
}
