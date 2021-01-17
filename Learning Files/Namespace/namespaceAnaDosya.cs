using UnityEngine;
using dusmanyonetimi;
using puankontrol;


public class namespaceAnaDosya : MonoBehaviour
{

    dusman dusman = new dusman();
    PuanKontrolClassim puan = new PuanKontrolClassim();
  
    void Start()
    {
        dusman.saglik(50);
        puan.kontrol("deneme");
       
    }

   
}
