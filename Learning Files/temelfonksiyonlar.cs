using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temelfonksiyonlar : MonoBehaviour
{
   /* private void Awake()
    {
        Debug.Log("Ben awake ile geldim");
    }
    private void OnEnable()
    {
        Debug.Log("Ben OnEnable ile geldim"); 
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Ben Start ile geldim");
    }*/

    // güncelleme fonksiyonlarının sırası
   private void FixedUpdate()
    {
        Debug.Log("Ben FixedUpdate ile sürekli geliyorum");
        // 0.2
    }
    void Update()
    {
        Debug.Log("Ben Update ile sürekli geliyorum");
        // 1 saniye
    }
    private void LateUpdate()
    {
        Debug.Log("Ben LateUpdate ile sürekli geliyorum");
    }
/*
    private void OnDisable()
    {
        Debug.Log("Ben OnDisable ile geldim");
    }*/
}
