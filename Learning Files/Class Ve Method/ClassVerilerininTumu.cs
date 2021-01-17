using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassVerilerininTumu :  MonoBehaviour
{

    Okul Okul = new Okul();
    
    void Start()
    {
        // Okul.ad;

        Okul.OgrenciveOgretmenAdiniYollarVeOkulunadi("Kalyon",60,1000f,"Tuğrul","Murat");
        
    }

    
}
