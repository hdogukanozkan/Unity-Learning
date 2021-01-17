using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class degiskenler : MonoBehaviour
{
    /*
     string  // metinsel verileri içerir.
     int     // sayısal değerleri
     float // kayan sayılar 3.1014
     double // daha büyük kayan sayı 3.21414124241
     Boolean // herhangi bir şeyi aktif veya pasif olmasını kontrol eder. true / false
     
         */

    /*
            // class içerisinde değer tanımlama
        string metnim = "Merhaba Olcay";
        int yas = 80;
        float kusurat = 3.10f;
        double kusurat2 = 3.2120;
        bool acikmi = false;
           // class içerisinde değer tanımlama
           */
    // sadece değişkenlerin isimlerini ve türlerini belirliyorum
    string metnim;
    int yas;
    float kusurat;
    double kusurat2;
    bool acikmi;
    // sadece değişkenlerin isimlerini ve türlerini belirliyorum

    void Start()
    {
        // işlemler yaptım sorgular yaptım ve değişkenin değeri şu an oluştu

        metnim = "iceriden";

        Debug.Log(metnim);
        Debug.Log(yas);
        Debug.Log(kusurat);
        Debug.Log(kusurat2);
        Debug.Log(acikmi);
    }

  
}
