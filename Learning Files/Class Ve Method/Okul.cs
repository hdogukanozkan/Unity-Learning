using UnityEngine;

public class Okul : Ogretmen
{
    public void OgrenciveOgretmenAdiniYollarVeOkulunadi(string ad,int yas,float maas,string ogretmenad, string ogrenciad)
    {
        OgrenciveOgretmenAdiniYollar(ogretmenad, ogrenciad);
        Debug.Log("Okulun adı " + ad + " Yaşı : " + yas + " Maaş :" + maas);

    }
}
