
# Temel C#

Değişkenler 
---

```C#
int i = 0; //tam sayılar
string ad ="dogukan"; //metinler
float yaş = 20.5f; //virgüllü küsüratlı sayılar
bool dogrumu = true; //doğru yanlış
```

Döngüler
---

```C#

For(int i=0;i<5;i++)
{
// 5 defa dönmesini sağlar
}

Foreach()
{
//diziler ve listeler  de ki elemanlar için kullanılan döngü sistemi kaç adet varsa çalıştırılır 
}

if(koşul)
{
//koşul doğru ise
}

else
{
// koşul yanlış ise
}

While(true)
{
 // Sonsuz Döngü olur
}

```





# Listeler

Diziler
---

- int[] sayilar= new int[5]; // 5 adet sayiyi bünyesinde barındıran sayılardır

- int[] sayilar= new int[] {0,15,50,100,12,16}; // sayıların adetini yazmamıza gerek yok virgül bunları sayıyor 

- index sayısı 0 dan başlar sayilar[0] yazıp 1. sayıya ulaşabiliriz.

- Debug.Log(sayilar[1]);  // 2. sayıyı verir. 15 

```C#

String[][] arabalar = new string [3][];  //çok boyutlu dizilerdir.

arabalar [0]= new string [] {"Bmw", "Audi", "Seat"};

arabalar [1]= new string [] {"2010", "2009", "2006","2002"};

arabalar [2]= new string [] {"140hp", "100hp", "90hp"};

Debug.Log(arabalar[0][1]);  // audi

``` 

Switch Case
---

- Çok fazla koşul ve sorgu yönteminde kullanılabilir.

```C#
int sayi=5;
switch(sayi)
{
case 1:
Debug.Log("Pazartesi");
break;
case2:
Debug.Log("Salı");
break;
case3:
Debug.Log("Çarşamba");
break;
default: 
Debug.Log("Hatalı uyuşma yok");
break;
}
```

ArrayList ve List vardır.
---

```C#
List<int> yaslar = new List<int>(); //yaslar adinda liste oluşturma.
yaslar.Add(50); // veri ekleme
yaslar.Add(40); // 2.veri
yaslar.insert(1,90); //1.indexe 1.eleman yerine 90 yazılır eski eleman 2. indexe kayar
yaslar.remove(40); // 40 değerine sahip elemanı siler
yaslar.clear(); //tüm elemanları siler
if(yaslar.count>0) // eleman var mı diye kontrol ederiz . varsa ve yoksa olarak işlem yapmak için if else kullanırız.
{}

if(yaslar.contains(50)) // 50 adına sahip eleman var mı  diye kontrol edebiliriz.

Debug.Log(yaslar.count); // eleman sayısı
Debug.Log(yaslar[1]); // elemanı yazdırma
foreach(var item in yaslar)
{
   Debug.Log(item)   // Tüm elemanları listeler
}

for(int i =0;i<yaslar.count;i++)
{
    Debug.Log(yaslar[i]);  // eleman sayısı kadar çalışıp tüm elemanları yazdırır
}

List<string> adlar= new List<string>(); //adlar adinda liste oluşturma.
adlar.Add("ahmet"); // veri ekleme
adlar.Add("mahmut"); // 2.veri
```

# Claslar methodlar ve Erişimler public .Private .Protected

Class ve Fonksiyon(Method)
---
Namespace ise sınıfları kapsar.
Class = sınıfları temsil eder içerisinde method'lar bulunur.
Fonksiyon = Method'lar dır aynı anlama gelirler.
Örnek: 
Namespace okulun adi.>class sınıfın adları.>fonksiyon da öğrenci adları.

Erişim (Public Private Protected)
---

- Public(Erişilebilir dışarıdan): örnek unity içerisinden değer vermek için falan kullanılabiliyor.
- Private(Dışarıdan erişim olamaz):Sadece kod dosyasında kullanılır o sınıf dışında kullanılamaz.
- Protected : Methoda protected erişimi verirsek. Miras almayı yaptığımızda direk kullanım için sadece methodAdi(); kullanılabilir.
- Miras alma olayı :Başka dosyadı classın içinde ki methodları kullanmak için kullanılan yöntemdir. monobehaviour yazan kısma diğer dosyanın class adı yazılır.
<p>classAdi degisken = new classAdi(); tanımlaması yapılmalıdır. ve diger class'in methodunu kullanabilmek için degisken.methodAdi(); kullanılır.</p>

# Temel Fonksiyonlar | Start | Update | Using ...

Start Fonksiyonları
---

- Awake():İlk çalışan fonksiyon
- OnEnable():İkinci çalışan fonksiyondur.Obje Aktif ise çalışacak fonksiyondur.1 KERE
- Start():üçüncü çalışan fonksiyondur sırayla çalışırlar ve start fonksiyonları birer kere çalışmaktadır.

Güncelleme Fonksiyonları   (sürekli çalışırlar durmaksızın)
---

- FixedUpdate(): Update fonksiyonundan daha çok çalışır daha hızlı çalışır hız olarak 0.2 salisede tekrar çalışır update ise 1 saniye.
- Update(): Sürekli çalışan fonksiyondur.Sürekli çalışması sistemleri çok yorar dikkatli kullanılması gerekmektedir.
- LateUpdate(): Lateupdate ise bütün update bütün fonksiyonlar çalıştıktan sonra en son çalışır. Bütün fonksiyonların bitmesini bekler.
- OnDisable():Obje pasif ise çalışacak fonksiyondur.1 KERE

Using ve Namespace 
---

- Namespace nedir? : Class ve methodların çakışmasını önlemek için kullanılır. Verimliliği çok yüksektir. Gruplama için kullanılır. Kod çakışmaları önlenir  gruplama ile önceden hazırlanan kodlar daha rahat çekilir ve kolaylık sağlanır. Namespace ile class havuzu oluşturabiliriz. Sınırsız işlem yapılabilir.
- Namespace kullanmak için usinge eklenmesi gerekir.  Using NamespaceAdı diye eklenir. Sınıf tanımlamak için de ClassAdi degisken = new ClassAdi();
- Sınıf methodunu çapırmak için ise degisken.method();
- NOT: Methodlara dışarıdan değer verme işlemi. String ,int ,float vs.
- Using : Hazırlanmış kodları çekmek için kullanılan kütüphanelerdir diyebiliriz.



MonoBehaviour > Invoke Method !
---

- Invoke: bir defa kullanım için. zamanlayıcı ayarlanır.
- InvokeRepating : Sürekli çalışması gereken metotu belirli sürelerle çalıştırmak için kullanılır ve durdurmak için kullanılır.
- Invoke var mı? kontrol için if( IsInvokeing("metot") )
- Durdurmak için CancelInvoke(); Kullanılır

```C#

public void oc()
    {
        Debug.Log("13");
    }

    InvokeRepeating("oc", 5f, 4f);

```


# GETCOMPONENT  VE GETCOMPONENTS 

<p>Objelerin componentlerinde script kodları ile değişiklik yapmak için kullanılanGetCompoenet komutunu gördük.</p>
<p>GetComponents ise 1 den fazla component ayar için kullanılır. Aynı componentlerin değişiklikleri için kullanılır 2 adet Capsül Colider varsa veya 2 adet ses varsa bunların ayarlarını aynı yapabiliriz. </p>

```C#
- GetComponent<CapsuleCollider>(); // burada ki tanımlamamız da  objelerin ayarlarına giriş colliderında değişiklik yapabiliriz. 
- GetComponent<CapsuleCollider>().enabled = false; //pasif hale gelir veya triggerini aç kapa yapabiliriz
```

örnek kullanım için:
---

```C#
CapsuleCollider Capsulum;
Capsulum =GetComponent<CapsuleCollider>();
Capsulum.enabled = false;
```

```C#
CapsuleCollider[] Capsullerim =GetComponents<CapsuleCollider>
for(int i=0; i < Capsullerim.Length ; i++)
{
      Capsullerim[i].isTrigger = true;  //kapsülün bütün  colider değerlerinde ki trigger aktif oldu.
}
```
- Hiyararşi olarak başka objelerin üst dosyasına ulaşabilmesi için GetComponentInParent<> kullanılır.
```C#
GetComponentInParent<AudioSource>().mute=true;  // GetComponentsInParent<>
``` 
- Hiyararşi olarak başka objelerin alt elemanları yakalamak için kullanılır GetComponentInChildren<> .
```C#
GetComponentInChildren<CapsuleCollider>().trigger=true;  // GetComponentsInChildren<> 
``` 

# Obje Yakalama Değişiklik yapma.

<p> Oyunlarda değişiklik yapmamız GetComponent ' te olduğu gibi bazı component değerlerini açıp kapamamız gerekir örneğin silahtan çıkan mermi adama deydiğinde yok olması tepki vermesi. Topun kaleye girdiğinde kaledeki filelerin tepki vermesi gibi gibi objeler arası etkileşim olması gerekir bazı componentlerin açılıp kapanması gerekir ve çok önemlidir! </p>

```C#
GameObject Ben;
Ben=GameObject.Find("Obje Adi"); // Burada kullanım kolaylığı amacıyla tanımlama yapıyoruz.
Ben.GetComponent<degistirilecek component>()degisken = degisiklik; // gibi tanımlama yapılabilir daha doğru olur.
GameObject.Find("Obje adi").GetComponent<degistirilecek component>()degisken = degisiklik; // obje ara parametresi find'dir. Obje aradık bulduk nokta koyup GetComponent parametresi ile componentlerine erişim ve değişiklik yapıyoruz.
GameObject.Find("Obje adi/alt_obje");  //Hiyararşi düzenin de alt objeler olabilir ulaşmak  için bu yöntem kullanılır.
```
<p>Taglar çoklu kod yazma ve kullanım kolaylığı amacıyla kullanılır düşmanların hepsinde aynı tagı kullanıp 1 kod ile hepsini aynı işlemi gerçekleştirebiliriz</p>

```C#
Ben = GameObject.FindWithTag("Dusman");
Ben.GetComponent<degisiklikyapılacak>().degisken=degistir;  
```

```C#

GameObject[] =cokluobje;
cokluobje=GameObject.FindGameObjectsWithTag("Player");

foreach(var item in cokluobje)
{
     item.GetComponent<degiscekcomponent>().yas=3; // yas degiskenleri bütün player tagına sahip olan objelerde uygulanacak.
}

```
#  GameObject ve gameObject farkı

<p> GameObject ve gameObject farklıdır. küçük ile başlayan içinde bulunduğumuz scriptin objesi anlamına gelir.</p>

```C#

CapsuleCollider capsulum = gameObject.GetComponent(typeof(CapsuleCollider)) as CapsuleCollider;
capsulum.isTrigger = true;
if (gameObject.GetComponent("CapsuleCollider") as CapsuleCollider)
{
   gameObject.name = "Ben değiştirdim"; // eğer obje varsa objenin adını değiştirir.
}

Camera cam = (Camera)FindObjectOfType(typeof(Camera));
if(cam) //değer true ile kıyaslar true ise 
{
    Debug.Log("EVET KAMERA VAR "+cam.name);
}

Light isik = (Light)FindObjectOfType(typeof(Light));
if(Light) //değer true ile kıyaslar true ise 
{
    Debug.Log("EVET IŞIK VAR "+ Light.name);
}

```

# Message BroadCast - Send Message


```C# 

gameObject.SendMessage();  // fonksiyon tetikleyip çağırabiliyoruz.
gameObject.BrodcastMessage();  // kendi sayfasının için de ki dışında kendi alt objelerinde ki fonksiyonlarını da tetikliyor
gameObject.SendMessage("ekranabas"); // 2. yöntem ekranabas(); gibi de çağırabilirdik.Ama önemli olan obje ile oluşacak bir durum da çağırabilmek obje iletişimi ile .
gameObject.BrodcastMessage("ekranabas2");

void ekranabas()
{
   Debug.Log("Selamlar");
}

void ekranabas2()
{
   Debug.Log("Selamlar ben başka script dosyasında ki methodum beni üst objemin scripti çağırıyor");
}

```

# OBJELERİ AKTİF PASİF YAPMA

```C#

gameObject.SetActive(false); // pasif yapar
gameObject.SetActive(true); // aktif yapar
if(gameObject.activeSelf) // objenin durumunu öğrenmek için kullanılır aktif mi pasif mi 
if ( gameObject.CompareTag("dusman")) // tagı düşman ise şunları şunları yap diye biliyoruz burada
Rigidbody rigidekle= gameObject.AddComponent<Rigidbody>() as Rigidbody; // objeye component eklemek için kullanılabilir.
rigidekle.isKinematic=true; // ve componentin ayarlarını yapabiliyoruz.

```


Obje yok etme silme 
---
<p> objeleri yok etmek silmek için kullanılan script kodunu göreceğiz destroy komutunu kullanırız.Süreli destroy içinde kullanılır.</p>

```C#

Destroy(gameObject); // komut çalıştığında direk script dosyasının bulunduğu obje silinir.
Destroy(gameObject,2f); // 2 saniye sonra silinir.
Destroy(this); // this bu demek yani bu komut script dosyasını silmek için kullanılır.

```

Component silmek script dosyası ile
---

```C# 

Destroy(GetComponent<CapsuleCollider>());

```

# Prefab Oluşturma

<p> Yeni sahne oluşturmak için File kısmından new Scane oluşturuyoruz ctrl s ile kaydediyoruz isim veriyoruz. Sahneler arası obje vs script dosyası taşıma işlemini prefab deniyor.  Objeyi örneklendirmek(prefab yapmak) için  objeyi tutup aşşağıda proje kısmında dosyalar kısmına bırakıyoruz ve artık prefab oldu. Artık çağırılabilir kalıp haline geldi Sahneler arası kullanabilir Ve bütün özellikleri geldi .</p>
<p> Prefab güncellemek için tüm sahnelerde open prefab yazısına tıklayıp değiştirebiliriz veya objeler kısmında küçük ok tuşuna basabiliriz. </p>

Transform translate ayarları
---

transform işlemleri  için script dosyası oluşturuyoruz.
<br><br>
transform adresleri position , rotation ve scale değerlerini alabilmek öğrenmek için ;

```C#

Debug.Log(transform.position);

Debug.Log(transform.rotation);

Debug.Log(transform.localScale);

```

# Vector nedir ?

herhangi bir objenin yönlerini ve pozisyonlarını değiştirmemizi sağlıyor.Float türünde değerler alırlar.

Vector tanımlama
---

```C#

Vector3 pozisyon1; //vector tanımlamak
Vector3 pozisyon2;
pozisyon1 = new Vector3(1f, 2f, 1f);
pozisyon2 = new Vector3(1f, 2f, 1f);

```

Vector tanımlama 2
---

``` C#

   Vector2 sa;  // 2boyutlu oyunlar için varsayılan floattır int olması için vector2int kullanılır  vektor 2 de z yoktur bu yüzden 2 boyut
   Vector3 sa1; // 3boyutlu oyunlar için 3 boyutlu içinde aynı kural geçerlidir vector3int.
   Vector4 asd; // modellemeydi sanırım bölgelendirmeler 
   Quaternion d; //  objeler arası mesafe için

```
Quaternion ,Time.deltaTime
---

<p>
Quaternion : Objelerin arasında ki mesafeyi ölçüyoruz bilmek önemli.
<br><br>
Transform değerlerini değiştirmek için de ;
<br><br>
Time.deltaTime: Saniyede işlem yapmak için daha yavaşlatır veya daha hızlanıdırır objeyi kilometre hesabı gibi araçlarda.
</p>

```C#
         transform.Translate(new Vector3Int(3,5,1)); // mantık olarak 2 si de aynıdır.
         transform.Translate(new Vector3(3f,5f,1f)); // - değer ters yöne gitmeyi sağlar
         transform.Translate(new Vector3(3f,5f,1f) * Time.deltaTime); // daha yavaş gider süre ayarlaması yapabiliyoruz yani
         transform.Translate(Vector3.back* 5f * Time.deltaTime); //vector ün içerisinde hazır komutlar vardır back,right,left,'i kullandığımızda geriye doğru gidiyor hızını arttırmak içinde 5f ile çarpabiliriz veya daha fazla sayılar ile hıza bağlı
         Debug.Log(Vector3.Magnitude(transform.position)); //vectorun uzunluğunu ölçen komuttur.
         Debug.Log(Vector3.SqrMagnitude(transform.position)); //gene uzunluğu hesaplar ama karesini alır 2 ise 4 4 ise 16 gibi gibi.
         Debug.Log(transform.position.normalized); // büyüklüğü her zaman 1 değerinde döndürür.
```

Vector konum kontrol:
---

``` C#
 //1.yöntem
         if (Vector3.Equals(pozisyon1, pozisyon2))
        {
            Debug.Log("Konumları aynı");
        }
        else
        {
            Debug.Log("konumları farklı");
        }

        //2.yöntem
        if(pozisyon2 == pozisyon1)
        {
            Debug.Log("Konumları aynı");
        }
        else
        {
            Debug.Log("Aynı değil");
        }
```

# Static Methodlar - Vector3 

ANGLE , açı ,transform :
---

```C#
    public Transform hedef; // dışarıdan alınacak 2 tane transform obje tanımlıyorsunuz
    public Transform hedef2;

    //angle : açı arasında ki farkı yazar.
    Vector3 mesafe = hedef.position - transform.position;  // hedefte tanımladığımız obje ile scriptin olduğu obje arasında mesafeyi ölçer ve mesafe değişkenine tanımlar.
    float angle = Vector3.Angle(mesafe,transform.forward); // açı hesabını yazdırıyor

    if(angle < 5f )
    {
        Debug.Log("Açı sağlandı"); // açı 5 ten ufak olduğunda çalışır
    }

    //distance : vectorler arasındaki farkı yazar 
    float fark = Vector3.Distance(hedef.position,transform.position);
    Debug.Log("Fark şudur "+ fark);

    // lerp : 2 vector arasında doğrusal bir çizgi oluşturulmasını sağlar (görünmeyen çizgi) bu çizgi ile 1 objenin 2.objeye gitmesini sağlayacak
    // lerp 2 obje arasında doğrusal bir çizgi oluşturur görünmeyen yol objeye hareket etmeyi de sağlar.

    public Transform hedef;
    public Transform hedef2;
    private float baslangiczamani;
    
 baslangiczamani = Time.time;
        /*
            Time.time // oyun başladığında geçen zamanı bize verir oyun başladığında süre başlar ve sayar
            Time.deltaTime // kare hızlarını döndüren koddur oyunda ki hızı ayarlar da diyebiliriz sistemin kare hızına göre işlem yapmamızı sağlar
            Time.timeScale // oyunlar kare bandında çalışır oyunun hızını yavaşlatır örnek  Time.timeScale = .5f; zaman yavaş akar ağır çekim . 0f ise pause'tur.
        */

        Vector3 birincipoz = new Vector3(4f,2f,3f);
        Vector3 ikincipoz = new Vector3(2f, 5f, 1f);

        //print ve debug.log aynı işlemi görür..
        print(Vector3.Max(birincipoz, ikincipoz)); // max yüksek sayıları vectorleri döndürür  4,5,3 döndürür
        //Vector3.Min(birincipoz, ikincipoz)  min düşükleri döndürür 2,2,1 döndürür
        //Vector3.Scale(birincipoz,ikincipoz) 2 vectoru çarparak değeri bize döndürür 4*2 = 8  2*5=10 3*1 =3 gibi 8,10,3 döndürür 

        print(birincipoz + ikincipoz); //dönen değerler 6,7,4 çıkar
        print(birincipoz - ikincipoz); //dönen değerler 2,-3,2 çıkar 
        /*Çarpma ve bölme hata verir 
         print(birincipoz * ikincipoz);  
         print(birincipoz / ikincipoz);
        ama şöyle yapılabilir vectorler bölünebilir. */
        print(birincipoz * 3f);
        print(ikincipoz / 2f); //bunlar kullanılabilir
         // lerp bir objeyi hareket ettirmek için kullanılır.
        transform.position = Vector3.Lerp(hedef.position, hedef2.position, (Time.time - baslangiczamani)* .4f); // 4f hızını ayarlar // Time.time geçen süre - baslangıc zamanı yani 0 geçen süreyi gösterir
        
```

# Transform Özellikleri - Methodlar

Transform :
---
<p>
    Transform bir objenin sahnede ki konumunu gösteren ve hareket işlemlerini yapmamızı sağlayandır. Transform component ve hiyararşide ki hareketlerini de kontrol edebiliyoruz. Objenin ışınlanması.
</p>

```C#

    public Transform hedef;
    public Transform hedef2;


        transform.position=new Vector3(2f,3f,5f); // oyun başlar başlamaz objenin yeni pozisyonunu belirtiyoruz oradan başlıyor

        transform.position = new Vector3(transform.position.x,6f,transform.position.z); // sadece y değerini değiştiriyoruz x ve z değerleri sabit aynı kalıyor değişiklik sadece y de oluyor.

        transform.Translate(new Vector3(2f,3f,1f)); // translate sürekli tekrar edecek  komuttur sürekli hareket etmesini sağlar yani aynı birimde sürekli o yönlere hareket eder
        transform.forward; // ileri doğru
        transform.up; // yukarı doğru hareket etmelerini sağlar
        transform.right
        transform.
        transform.

        //kullanımı 
        transform.Translate(transform.forward * Time.deltaTime * 2f); // öne doğru hareket etmeyi sağlayan komuttur

        transform.Rotate(new Vector3(1f,2f,3f)); // objenin eksenlerde dönüşünü sağlar süreekli
        transform.Rotate(new Vector3(1f,0f,0f)*Time.deltaTime * 2f); // hızını ve sadece x ekseninde dönüşünü sağladık

        //DÖNÜŞLERDE WORLD VE SELF KOMUTLARI KULLANILIR.
        transform.Rotate(new Vector3 (90f,0f,0f),Space.Self); //kendini referans alarak
        transform.Rotate(new Vector3 (90f,0f,0f),Space.World); // dünya eksinini referans alarak dönüş yaptırır.
        
        //NEW KULLANIMI HAKKINDA ÖNEMLİ
        
        hedef.transform.Rotate(90f,0f,0f,Space.Self); //Burada new kullanımına gerek yok dışardan public olarak obje alıyoruz.
        hedef2.transform.Rotate(90f,0f,0f,Space.World); // dünya eksinini referans alarak dönüş yaptırır.

        //NEW KULLANIMI HAKKINDA ÖNEMLİ 2
            /*
public Vector3 benimyonum; gibi yaparsak ta new demeden sayfanın istediğimiz yerinde çekebiliriz. 
Mustafanın sorguduğu yazım şekline göre new olmazsa olmaz. Ancak bu şekilde tanımlanırsa sayfa 
içerisinde hitap edebiliriz.

Mesela;
Vector3 benimyonum; diye tanımlama yaptık diyelim ki, bu vectore yeni bir vector değeri atayacaksak eğer;
benimyonum= new Vector(5,2,3); gibi tanımlarız. Yani sayfa içerisinde tanımlanmayan yeni bir vector oluşturacaksak eğer new ekini kullanıyoruz.
Yani olay sadece tanımlama ve çağırma şekliyle alakalı diyebiliriz. İyi dersler dilerim. Sevgiler.            
            */

```

localPosition , localRotation , localScale :
---

```C#

           /* Burada yaptığımız print yönlendirmeleri objelerin konumlarını öğrenmek için kullanıyoruz mevcut pozisyonlarını bize veriyor */
        print(hedef.transform.localPosition);
        print(hedef.transform.localRotation); // ilerde görücez
        print(hedef.transform.localScale);



           /* look at komutu bir objeyi takip etmek için kullanırız */
        hedef2.transform.LookAt(hedef); //bu komut ile objemiz diğer objemize sürekli kafasını çevirerek kontrol eder örnek olarakta güvenlik kamerası gibi düşünebiliriz
        hedef2.transform.LookAt(hedef,Vector3.left); //


        /*Eğer bir objenin alt childlerına ulaşmak için neler yaparız ?*/

        GameObject aramasonuc =  transform.Find("GameObject").gameObject; // burada GameObject adında obje arıyoruz ve aramasonuc degiskenine atıyor.

        aramasonuc.name="Bendegistirdim"; //burada bulduğu objenin adını name ile değiştirdim

        Debug.Log(transform.childCount); // bir objenin altında ki ne kadar çocuk varsa sayısını bana göster diyebiliyoruz. ebevyn sayısını almaz sadece cocuk sayısını hesaplar

        Debug.Log(transform.hierarchyCount); // ebevyn ve altçocuklara kadar tüm her şeyi hesaplar de dahil olmak üzere toplam sayıyı gösterir. çocuk + ebevyn sayısı

        GameObject aramasonuc =  transform.Find("GameObject/yeniobje").gameObject; // burada GameObject altındaki yeniobje adında objeyi yakalıyoruz.

        /* Bütün çocuk objelerin adlarını yazdırmak */
        for(int i = 0;i<transform.childCount;i++)
        {
            Debug.Log(transform.GetChild(i).name); // indis numarasını i olan 0 1 2 3 olarak artan ve indis numarasına göre tüm objelerin name'lerini alıp debuglog ile yazdırıyoruz.

            if(i == 1)
            transform.GetChild(i).GetComponent<CapsuleCollider>().enabled = false; // indis numarası 1 olan objenin görünürlüğünü varlığını pasif yapıyoruz.

            /* VEYA İSME GÖRE OBJEYİ BULMA*/
            if(transform.GetChild(i).name==Kamera)
            transform.GetChild(i).GetComponent<CapsuleCollider>().enabled = false; // Burada ismi kamera olan objenin varlığını görünürlüğünü kapatıyoruz bu en çok kullanılan yöntemdir isimleri taglar çok önemli !

        }



```
SetParent:
---
<p>Burada objelerin hiyararşi ayarlarını yapmayı alt obje eklemeyi görüyoruz bunun için SetParent kullanarak aile hiyararşi oluşturabiliyoruz.</p>

```C#

    public Transform parent;  // parent adında objeyi atıyoruz
    public Gameobject child;  // child adında objeyi atıyoruz.

        child.transform.SetParent(parent); // parent objesinin altına child objesini atıyor parent üstte child alta geçiyor hiyerarşi olarak
        /* Bunu yaptığımızda child objesinin değerleri kendi transform değerlerini kaybediyor ve değerleri 0'lanıyor Eğer değerlerin 0 lan masın olduğu gibi kalsın sadece hiyararşi kurulsun istiyorsak false değerini kullanıcaz */
        child.transform.SetParent(parent,false);

```
Quaternion:
---
<p>Quaternion ; Dönüş işlemlerinde kullanılması tavsiye edilen daha stabil bir koddur.Hataları minimuma indirir. </p>

```C#

 
    public Transform hedef;

            /* Objenin bir objeyi takip etmesi izlemesi*/
        Vector3 fark = hedef.position - transform.position;  // aradaki mesafeyi ölçüyoruz
        transform.rotation = Quaternion.LookRotation(fark,Vector3.up); // burada bizim objemizin transform.rotation değerini quaternion komutunu kullanarak dönüşleri takibini sağlıyoruz sağlıyoruz

        float angle = Quaternion.Angle(transform.rotation , hedef.rotation); //2 vector arasında ki mesafeyi derece olarak verir bize 
        print(angle);

        transform.rotation = Quaternion.Inverse(hedef.rotation); //objenin pozisyonun tam tersini uygular ayna gibi açılarının zıttını alır. Tam tersi hareket inverse komutu ile sağlanır.

        transform.rotation = Quaternion.Euler(90,0,0); // objenin açısı 90 yapar 

        transform.rotation = Quaternion.FromToRotation(Vector3.up,transform.forward); //objenin sürekli dönüşünü sağlayabiliyoruz kendi ekseninde yönünü belirliyoruz 


        Vector3 bizimpozisyon = new Vector3(140,70,90);
        Quaternion yenipozisyon = Quaternion.Euler(bizimpozisyon);

        transform.rotation = yenipozisyon;  // burada 140 70 90 açısını oluşturuyoruz ve oluşturduğumuz vector 3 açısını quaternion komutuyla birleştirip objenin rotation değerlerine atıyoruz ve objenin değerleri 140 70 90 oluyor.

        Quaternion.identity; // dönüş yok rotation yok varsa sıfırla demektir bu kod. 

        transform.rotation = Quaternion.identity; //şuan komut yazdığımız scriptin objesinde ki bütün rotation değerleri 0 0 0 olur sıfırlanır.

```

# Object İnstantiate - obje oluşturma prefabdaki objeleri çekme, prefab objelerini kod ile çağırma

```C#

    public GameObject yarat;  //obje tanıttık ve prefab objeyi yarat değişkenine atadık
    public GameObject yeniobje; 

        Instantiate(yarat); // objeyi orjinal direk çağırır olduğu konumda yaratır 
        Instantiate(yarat, transform); //objeyi çağırır child olarak atar
        Instantiate(yarat, transform.position, transform.rotation); // objeyi yaratır position ve rotation değerlerini şuan ki objemize göre alır üst üste çakışmalı yaratır yani
        Instantiate(yarat, transform.position, Quaternion.identity);// objenin position değerini şuan ki objemize göre veririz quaternion.identity ile rotation değerlerini almayız onlar orjinal neyse prefab haliyle kalır.
        Instantiate(yarat, yeniobje.transform.position, Quaternion.identity); //yeni başka bir objenin position değerine göre atama yaptık başka objeye göre değer alır position
        Instantiate(yarat, new Vector3(2f, 3f, 5f), Quaternion.identity); // position değerini kendimiz 2 3 ve 5 olarak atadık el ile değer girdik
        Instantiate(yarat, new Vector3(transform.position.x, 3f, 2f), Quaternion.identity); // burada x değerini kendi objemin x i ile aynı aldım kalan y ve z değerlerini 3f ve 2f olarak atadım.

        

        //component erişmek ve değişiklikler yapmak için 
        GameObject cube = Instantiate(yarat, new Vector3(transform.position.x, 3f, 2f), Quaternion.identity);  // objeyi cube adında ki değişkene atıyoruz 
        cube.GetComponent<BoxCollider>().enabled = false; // ve objemizin boxcolliderına erişip değişikliğimizi sağlıyoruz

```

# UNİTY MATHF | HİDE FLAGS | ÇEŞİTLİ İPUÇLARI | DEĞİŞKEN METHODLARI 

<p> matematik işlemlerimizi yaparken math sınıfını kullanarak gerçekleştiriyoruz.</p>

```C#

    // Mathf - Matematiksel İşlemler

        print(Mathf.Abs(-2.5f)); //mutlak değerini döndürür

        //Ceil sayıyı daha büyük veya eşit sayıya yuvarlar
        print(Mathf.Ceil(5.0f));  //5
        print(Mathf.Ceil(5.1f));  //6
        print(Mathf.Ceil(5.7f));  //6
        print(Mathf.Ceil(6.0f));  //6
        print(Mathf.Ceil(-5.0f)); //-5
        print(Mathf.Ceil(-5.2f)); //-5

        //Floor sayıyı en küçük-yakın veya eşit sayıya yuvarlar
        print(Mathf.Floor(5.0f));  //5
        print(Mathf.Floor(5.1f));  //5
        print(Mathf.Floor(5.7f));  //5
        print(Mathf.Floor(6.0f));  //6
        print(Mathf.Floor(-5.0f)); //-5
        print(Mathf.Floor(-5.2f)); //-6

        //Round sayıyı .5 olursa bir üst sayıya yuvarlar ama bir üst sayı  
        //eğer tek ise 10.5 => 11.0 yapmaz 10.0 yapar
        //eğer çift ise 11.5 => 12.0 yapar 12.0 cevab olur
        print(Mathf.Round(5.0f));  //5
        print(Mathf.Round(5.1f));  //5
        print(Mathf.Round(5.7f));  //6 

        float saglik = -5;
        print(Mathf.Clamp(saglik,1,100)); // saglık en az 1 en fazla 100 olacak demek  -5 i 1 olarak gösterir.
        print(Mathf.Clamp01(saglik)); // saglik değeri eğer -negatif ise 0 +pozitif ise 1 döndürür.

        print(Mathf.Max(2.4f, 1.8f)); // en yüksek sayıyı bize döndürür
        print(Mathf.Min(2.4f, 1.8f)); // en düşük sayıyı bize döndürür

        float[] degerler = { 1.5f, 2.2f, 9.9f };
        print(Mathf.Max(degerler));
        print(Mathf.Min(degerler));



```

# Değişkenler için çeşitli methodlar- Örnek ve kullanımı

```C#

    private string ad = "olcay";
    private string ad2 = "mehmet";
    private int sayi = 50;

        string kopyalanan =(string) ad.Clone();
        print(kopyalanan);
        print(ad.GetType()); //bize değişkenin tipini yazdırır string diye.


        //ad değişkeninin içinde olay var mı
        if (ad.Equals("Olcay")) 
        {
            print("Doğru");
        }
        else
        {
            print("Yanlış");
        }


        //ad değişkeninin sonunda ki harf ve kelimeyi arar cay - ay - y gibi istediğimizi aratabiliriz
        if (ad.EndsWith("y"))  
        {
            print("Evet sonu y");
        }
        else
        {
            print("hayır değil");
        }

        //ad değişkenin başına bakar  küçük büyük harf duyarlı değil aynı olmak zorunda
        if (ad.EndsWith("ol"))
        {
            print("Evet başı ol");
        }
        else
        {
            print("hayır değil");
        }

        string metin = "Bu Devirde Araba Alınmaz Yeğenim akp oy ver";
        print(metin.ToUpper()); // bütün harfleri büyük yapar
        print(metin.ToLower()); // bütün harfleri küçük yapar

        print(sayi.ToString()); // ilerde türü farklı olduğu için hata verebilir bu yüzden tostring kullanılmalı
        print(metin.Replace(" ","/" )); //metinin içinde 1. parametre arar ve 2. parametre çevirir bütün boşluklara / işareti koyar gibi
        print(metin.Trim()); // başındaki ve sonunda ki boşlukları temizler metinin.
        print(metin.TrimStart());// baştaki boşlukları temizler
        print(metin.TrimEnd()); // metnin sonunda ki boşlukları temizler
        print(metin.Substring(2,10)); //2. indisten başla  10 ileri kadar al yani 0. harfi 1. harfi 2. harften başlar 10 tane ileri kadar alır
        
        string[] parcala = metin.Split(' '); //boşlukları referans alarak her kelimeyi parçalar halinde bölünür
        foreach (var item in parcala)
        {
            print(item);
        }

        // örnek kullanım için
        metin = metin.Trim();
        metin = metin.ToLower();
        metin = metin.Replace(" ", "/");
        metin = metin.TrimStart().TrimEnd(); // çoklu kullanım

```


# Hide Flags Yöntemleri ve Çeşitli İpuçları ! Önemli

```C#

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[AddComponentMenu("Dogukan/kendiscriptdosyam")]  //script dosyasına özel component ve menü oluşturabiliyoruz add component kısmına eklenir.

//Menüye script dosyası eklediğimizden birden fazla componentti de içinde ekleyebiliriz fizik componenti gibi gibi bir script dosyasıyla birden fazla iş yaptırabiliriz.
[RequireComponent(typeof(Rigidbody))] //bu script eklendiğinde bu componenti de ekleyeceksin demek (silinmez !) script dosyasını silmeden silinmez


public class pasabahce : MonoBehaviour
{
    public Color ad1;
    public Texture ad2;
    public AudioClip ad3;

    [Header("Burası karakter ayarları")] //kategorize etmek için
    public string saglik;
    public string para;
    public string level;

    [Header("Burası Düşman ayarları")] //kategorize etmek için
    public string Dusman_saglik;
    public string Dusman_para;
    public string Dusman_level;


    [HideInInspector] // burası da inspector panelinde public şeylerin gözükmemesi için de kullanılabilir bunun altına yazdıklarımız gözükmez 
    public string ad;

    [Range(1, 6)]
    public int deger; // değerimiz 1 ile 6 arasında olacaktır kısıtlanıyor. min 1 max 6 olur

    [Min(5)]
    public int deger2; // minimum değeri 5 olacaktır.

    [Multiline(7)] 
    public string deger3; //string içeriğin yazı kutucuğunu büyültür ve 7 satırlık büyük bir text alanı sağlar

    [Tooltip("Bu benim notum açık mı kapalı mı ayarı buradan")]
    public bool deger4; //bool değişkeninde tik atıp atmama durumlarında bilgi verici metin olur

    [ContextMenu("Benim Menüm")] // Burada prefabların olduğu script dosyamın bulunduğu componentin menüsüne eklenir ve oradan tıklandığında fonksiyon çalışır
   // [ContextMenu("Benim Menüm",false,1)] sırada önceliğini belirler 1 2 3 gibi verilebilir false ve true olayını bilmiyorum.

    void BenimMenüm()
    {
        print("menüden geldim");
    }


    void Start()
    {
        gameObject.hideFlags = HideFlags.HideInHierarchy; // hiyararşide görünmesini engeller işleri bitmiş objeleri kalabalığı önlemek adına kulannılır.
        gameObject.hideFlags = HideFlags.HideInInspector; //inspector panelini tamamen gizler değişiklik yaptırmaz yalnışlıkla değişiklik yapılmasını önlemek adına
        gameObject.hideFlags = HideFlags.NotEditable; // inspector panelini gösterir ama değişiklik yaptırmaya izin vermez
        gameObject.hideFlags = HideFlags.DontSave; //nesnede yaptığımız değişiklikleri kaydetmez
    }

 
}

```

# Fizik İşlemleri  - Collider - RigidBody

<p>
    Box collider , Capsule collider , Sphere collider  Collider bizim görmemiş olduğumuz çevresinde çizgi. 
    <br><br>
    Her objenin kendine özgü collideri olmak zorunda.
    <br><br>
    Terrain kısmı haritamızdır bütün dağlar ağaçlar vs.
    
</p>
<p>
    Wheel Collider araba oyunu için teker yapımına yarayan kullanılan colliderdir. Süspansiyon gibi ince detay teker ayarları yapılır.
<p>
    Character Controller - Karakter kontroller  hazır basit karakterin ön ayarları için kullanılır 
    <br><br>
    1-Slope Limit yokuş yukarı çıkılabilecek açı derecesi
    <br><br>
    2-Step offset basamak 
    <br><br>
    3-skin width ince detay karakterin sıkışması falan sanırım
    <br><br>
    4-min move distance ise titreşimi en aza indiren yerdir
</p>


```C#

/* not1
eğer addan değil tagdan yakalanacaksa obje 

(collision.gameObject.name== "Sphere (1)") 
(collision.CompareTag("dusman"))
(other.gameObject.name == "Sphere (1)")
(other.CompareTag("dusman"))
*/

/* not2
Eğer çarpışma sonrası obje yok etmek istiyorsak 

Destroy(gameObject); BURADA SCRİPT KODUNUN BULUNDUĞU OBJE
Destroy(other.gameObject); veya Destroy(collision.gameObject)  BURADA DA ÇARPTIRDIĞIMIZ OBJELERİN YOK EDİLMESİ

YİNE BU ŞEKİLDE CAN AZALTMA VE MATEMATİKSEL İŞLEMLERİ VEYA SİLME İŞLEMLERİNİ İF İN İÇERİSİNDE YAPIYORUZ !

*/

//Bütün objeler ile etkileşimi gösterir zemin vs tüm objelerle iletişim de etkilenir
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("etkileşim var ");
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Etkileşim sürüyor");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Etkileşim bitti");
    }

// 2. seçenek belirli objeler veya tag grubunda ki objeler arasında etkileşim
 private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name== "Sphere (1)") //adı Sphere (1) olan obje ile iletişimde çalışacak kod
        {
            Debug.Log("etkileşim var ");
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "Sphere (1)") //adı Sphere (1) olan obje ile iletişimde çalışacak kod
        {
            Debug.Log("Etkileşim sürüyor");
        }
        
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Sphere (1)") //adı Sphere (1) olan obje ile iletişimde çalışacak kod
        {
            Debug.Log("Etkileşim bitti");
        }
        
    }

    // Objelerde rigidbody olma zorunluluğumuz kalmadı bu objeler boşta çalışmaz çünkü collider kısmında ki istrigger özelliği açık olmalı 
   //etkileşimleri istrigger özelliği ile bize döndürür. En az 1 tanesi açık olmalı 
   /*
    Eğer objelerde ki rigidBody Komponentlerini kaldırırsak onTrigger özelliği çalışmıyor.

    Yani OnTrigger Metodunun çalışması için etkileşim içinde olan objelerden en az birinde Collider ve RigidBody Komponenti ekli olması gerek.
   */
  private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Sphere (1)") //adı Sphere (1) olan obje ile iletişimde çalışacak kod
        {
            Debug.Log("etkileşim var ");
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Sphere (1)") //adı Sphere (1) olan obje ile iletişimde çalışacak kod
        {
            Debug.Log("Etkileşim sürüyor");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Sphere (1)") //adı Sphere (1) olan obje ile iletişimde çalışacak kod
        {
            Debug.Log("Etkileşim bitti");
        }
    }

```

# 3D | JOİNTLER 1

Fixed Joint
---

<p>
    Fixed Joint(component) kullanıyoruz burada karşımıza 2 şey çıkıyor temel olarak 1.si bağlanacak objeyi seçiyoruz 2.si tam olarak bilemediğim connected articulation body.
    <br><br>
    1. de bir obje seçiyoruz ve bu obje ile aralarından bir bağ oluşuyor bu bağ sayesinde 1. obje hareket ettiğinde 2. obje ona göre takip edebiliyor. Burada bilinmesi gerken
    şey de asıl olarak takip esnasinda yer çekimi ve kütle değerlerine dikkat edilmelidir.
    <br><br>    
    Ayarlar;
    <br><br>
    - Connected Body => kısmına takip edilecek objeyi atıyoruz. RigidBodysi olmak zorundadır.
    <br><br>
    - Break Force => bağlantının kopacağı güç arada ki bağın eklemin kopacağı güç anlamına gelir.
    <br><br>
    - Break Torque => Aynı şekilde ona da bir değer verirsek bağlantıyı koparacaktır. Objelerin işi bittiğinde kod kısmından ulaşıp değer verip bağı koparabiliriz.
    <br><br>
    - Enable Collision => çarpışmaları yakalayabilmek için gerekli olan parametre çarpışma etkin olduğunda tetikleme aktif olur. açmak için tik atmak lazım
    <br><br>
    - Enable Preprocessing => çok hızlı hareket etmelerde arkada çalışan optimizasyonu sağlar
    <br><br>
    - Mass Scale => kütle düşük olunca çok daha rahat hareket eder 
    <br><br>
    - Connected Mass Scale => Bağlantının kütle boyutudur. kütle boyutu düştükçe hareketler ağırlaşıyor yavaş hareket ediyor.
</p>

Hinge Joint
---

<p>
    Hinge Joint(Component) Kapıların menteşesi için kullanılabilir ve gene objeleri birbirine bağlamak için kullanılabilir. Menteşe olayı vardır kapılarda vs genelde kullanılır.
    <br><br>
    NOT : DUVARI rigidBody => Constraints kısmından ayarlarını kitliyoruz kıpırdamasın diye x y z full freezeliyoruz.
    <br><br>
    Ayarlar;  
    <br>
    - Connected Body => buraya kapıya duvarı bağlayacağız yani duvarı buraya yükleyecez rigidbody sini
    <br>
    - Edit Angular Limits => Edit kısmından menteşenin yönünü görüyoruz.
    <br>
    - Anchor => Menteşenin veya eklemin eksenini gösteriyoruz ayarlıyoruz. 
    <br>
    - Axis => ise bize menteşenin yönünü verir ayarlamamızı sağlar.
    <br>
    - Motor => burada objenin sürekli dönmesini sağlıyoruz. Döner kapı vs yapılabilir.
    <br>
    - Motor - Target Velocity => nesnenin konuma hareket edeceği gücü istiyor. 250 
    <br>
    - Motor - Force => Güç  50 gibi değerler verilebilir.
    <br>
    Spring : Kapının yaylanma Sistemi
    <br>
    - Spring => Nesnenin hareket etmek için ileri sürdüğü kuvvet örnk = 10  değer yükseldikçe kapı zorlanacak açılmayacak falan
    <br>
    - Spring - Damper => Kapının uyguladığı fiziksel güç
    <br>
    - Target Position => Varsayılan derece kapının derecesini belirler hep o açıda sabit kalır biraz aralık bırakmak için kullanabiliriz 20 derece gibi.
    <br>
    Limits : Kapının ne kadar açılacağını ne kadar kapanacağını karar veren bölüm.
    <br>
    Min =>  genelde 0
    <br>
    Max => En fazla 10 dediğimizde 10 dereceden ileriye gitmez. En fazla 10 derece açılır.
    <br>
    Bounciness => sekme 1 dediğimizde ufak bir sekme hareketi yapar yumuşatır hareketi.
    <br>
    Bounce Min Velocity => sekme hızı 0.5 deriz kuvvetin gelişine göre minimum değer veririz.
    Contact Distance => Mesafe iletişimi temas halinde yani herhangi bir titreşim olmasını önlemek 
    
</p>

Spring Joint
---

<p>
    Objeler arası yaylanma yapacağımız joint.
    <br>
    Anachor => Eklemin yerini ayarlıyoruz
    <br>
    Spring => yayın hızlı hareket etmesini sağlar.
    <br>
    Damper => O yayın genişliği diye biliriz büyürse yay daha yavaş hareket eder.
    <br>
    Min Distance => minimum mesafe 
    <br>
    Max Distance => maximum mesafe 
    Eğer burada değer verilmezse min max tutarsızlık olur sonsuz bir yaylanma oluşabilir.

</p>

Constant force 
---
<p>
    Roket atmak için hareket ettirmek için kullanılabilir.
    Bir yöne açıya sürekli güç uygulayarak hareket etmesini sağlar.
    <br>
    Force => Bir yöne doğru eksene doğru hareket sağlar. Düz hareket etmesini veya düz açıya göre güç uygular.
    <br>
    Relative Force => Objenin kendi eksinine doğru hareket sağlar
    <br>
    Torque => Objenin kendi etrafından dönmesini sağlar.
    <br>
    Relative Torque => Objenin kendi eksenini esas alarak kendi etrafından dönmesini saplar. Obje kendi etrafında döner.
</p>

# UNİTY GRAFİK | IŞIKLAR | KAMERA | METERİAL | TEXTURE | VS.

<p>
    MESHES : Ana grafik ilkelerindendir.Bir nesnenin şeklini tanımlarlar.İskelet
    <br><br>
    Materials : Objenin ,Renk tonları ve daha fazlasını ekleyerek yüzeyin nasıl oluşturulması gerektiğini tanımlar.Çeşitli türleri vardır. İskeletin üstünü kaplayan boyalar.
    <br>
    Shader : Gölgelendiriciye özel ayarlar mevcut.Çeşitleri var.Oyun platformuna göre ve farklı detaylar yapılabilir.
    <br>
    Albedo : Renk seçimi
    <br><br>
    Shaders : Gölgelendiricilerdir,Objelerin rengini ayarlamak matematiksel işlemler yaparak gölgeyi hesaplar. Gölgeleri ayarlar.
    <br><br>
    Textures : Dokulardır, bir objenin kıyafeti diyebiliriz. Objenin kaplanacak yüzeyini belirlemek için kullanılır. Gölgelendiricler hesaplama yapmak için dokuları kullanabilir.Dokular ahşap masa veya metal masa nın dokusu kıyafeti yani 
    <br>
    textures.com dokuların bulunduğu çok büyük sitelerden biri
    <br>
</p>

# KAMERA AYARLARI  Component

kamerayı sahne ekranında gezerken beğendiğimiz bir açıya getirmek için görüşümüz ile serbesst gezerken ki pozisyona getirmek için GameObject>Align With View(CTRL + SHİFT + F) .
Oyun içerilerinde birden fazla kamera kullanılır ve geçişler olabilir.

Projection - Kamera türü ;
---
Perspektif : büyüklü küçüklü olmaları yakınların yakın gözükmesi uzaktakilerin ufak görünmesi gerçekçiliktir.
Orthographic : sabit hepsinin tek tipte göründüğü kamera açısıdır  uzaktaki de yakında ki de aynı görünür.

![Perstective ve Orthographic](https://docs.unity3d.com/uploads/Main/CameraPerspectiveAndOrtho.jpg)

Clear Flags ;
---
Bu ekranın hangi kısımlarını sileceğini söylüyor.<br>
Solid Color : normal renk verilir<br>
-->Background :Solid arka plan rengi belirleyebiliriz. Sade düz renk<br>
Skybox : Gökyüzü verilir<br>
<br>

Culling Mask :
---
Efektörlerde de vardı. Hangi layerların gösterileceğini seçiyoruz eğer tikleri kaldırırsak o katmana ait objeleri kamera görmez !!! <br>
<br>

Physical Camera :
---
Bunu etkinleştirdiğimiz zaman gerçek dünyada ki kamerayı taklit ediyor. Dhafazla ayarlar oluşuyor sensörler mercekler milimetreler.<br>
--> Focal Length : Merceğini ayarlıyoruz .<br>
--> Sensor Type : Milimetreler ve türler var 70mm dediğimizde çapı değişiyor. Ayarlar yapıp tercihlerde bulunabilir<br>
--> Sensor Size : boyutunu ayarlıyoruz<br>
--> Lens Shift : Merceğin merkezden yatay veya dikey kaldırılması.<br>
--> Gate Fit :vectical horizantal merceğin boyutunu ve çözünürlüğünü ayarlıyoruz.<br>

<br>

Clipping Planes ;
---
Kameranın gösterecek olduğu menzil kırpma işlemide yapılıyor. <br>
--> Near : yakında ki kesilecek kısım<br>
--> Far : en uzak kesilecek kısım<br>
<br>

Viewport Rect ;
---
Bu kameranın ekran görüntüsünün nereye çekileceğini gösteriyo kameranın genişliğini ve yüksekliğini ayarlıyoruz.<br>
<br>

Depth ;
---
makinenin çizim sırasında ki konumu birden fazla kamera varsa kullanılır.<br>
<br>

## GRAFİK AYARLARI
<p>
project Settings > Graphics <br>
Platforma özel ayarlay yapabiliriz.Default ayarlar hariç değiştirmeler yapabiliriz. 
</p>

### Rendering Path ;
Kamera tarafından hangi görüntü oluşturma yönteminin seçileceği kısımdır.<br>
foward: kendi bölgeleri her şey spesifik olacaktır kameranın gördüğü objeler.<br>
Deferred: 
Legacy vertex Lit : Gölgeler normal haritalar tamamen kapatılacak gözükmeyecek.<br>
Legacy Deferred light prepass : Tüm nesneler ışıklandırılarak birlikte oluşturuluyor.<br>
<br>

### Target Texture ;
Kameramızın görüntüsünün çıktısını alabileceğimizi sağlar. Render texture da kameranın dokusu gibi düşünebiliriz değişiklik yapılıyor. Render Texture kullanılıyor daha sonra tekrar işleyeceğiz.<br>
<br>

### Occlusion Culling ; 
Birşeyin arkasında ki objenin çizilmemesi sağlanıyor sistemi yormuyor <br>
<br>

### HDR ;
Görüntülerin daha gerçekçi ve güçlü olmasını sağlıyor. Mobilde çok farkını görmüyoruz.<br>
Dezavantaj daha yüksek kaynak tüketimi ekran kartını çok daha fazla tüketiyor.<br>
<br>

### MSAA ;
Objelerimize çok yaklaştığımız zaman tırtıklar olur.İşte bu tırtıklı halleri ortadan kaldırıyor ve azaltıyor. Kullanılmadığında tırtıklı ve kötü görüntü ortaya çıkar. Aktif olması önemlidir görüntüde Yumuşatma sağlar.<br>
<br>

### Allow Dynamic Resol ;
Dinamik çözünürlüğü ayarlıyor. Dinamik olarak kare hızı fps azaldığında bunun yerine tutarlı kare hızını korumak için yavaşça azaltır donmalara engel olur.Fps'in anlık düşüşlerini yumuşatır.<br>
<br>

### Target Eye ;
Vr projeler için bakış açısı için kullanılıyor.<br>
<br>

# Birden fazla kamera | Script Dosyası ile Yönetmek 

Birden fazla kamera oluşturuyoruz ve bunları bir boş gameobjenin scripti ile yönetiyoruz.

```C#

    public Camera Ana_Camera;
    public Camera kure_Camera;
    public Camera kare_Camera;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ana_Camera.enabled = false;
            kare_Camera.enabled = false;
            kure_Camera.enabled = true;
            kure_Camera.fieldOfView = 10f; //BUNUN Gibi componentte düzenlemeler yapabiliriz.
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Ana_Camera.enabled = true;
            kare_Camera.enabled = false;
            kure_Camera.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            Ana_Camera.enabled = false;
            kare_Camera.enabled = true;
            kure_Camera.enabled = false;
        }
    }


```

# Occlusion Culling | Frustum Culling Sistemi

Occlusion Culling ;
---
Bu culling objelerin arkasında kalan görünmeyen objelerin ekran kartına gitmesi engeller ve performans arttırımı sağlar. Camera objesinin içinde bulunur.
<br><br>
Objeler eğer saklayabilirse arkasında obje tutabilirse statik yerine => Occluder static duvarlar örnek olabilir.
<br>
Eğer obje saklanıyorsa gizleniyorsa => Occludee Static Masa sandalye duvar arkasında kalan şeyler örnek olabilir.
<br><br>
Occluder Static = Arkalarında kalan objeleri gizleyen büyük objelerdir, Duvarlar mesela
<br>
Occludee Static =Bir duvarın yani  Occluder Static olarak ayarladığımız bir objenin  arkasında kalınca gizlenen objelerdir.
<br><br>
Obje hem saklanabilir hemde saklanabilen objeler içinde 2 si de verilecektir. Örneğin masanın altında kitaplar da saklanabilir gibi.<br>

<br>
Windows> Rendering kısmından occlusion culling açılır.AYARLARI TAM ANLAYAMADIM AMA DENEME YANILMA VEYA TEKNİK DETAY OLUYOR O YÜZDEN BİLEN BİRİNDEN DESTEK ALINABİLİR ve bake edilir ki optimizasyon sağlansın  ölçümler yapılır.


# Light

Point Light
---
Ortam ışığı olabilir. Ateş yakarken kullanılan ışık. Veya odaları aydınlatırken kullanılabilecek ışıklardandır.<br>
<br>
type : türü ışık türlerini değiştiririz <br>
range : menzili ayarlar <br>
Color : rengini ayarlarız <br>
mode :  önemli  <br>
1- baked derlemesi gerekiyor hesaplaması gerekiyor ve performansı arttırıyor bizim için.<br>
2- realtime gerçek zamanlı her kareye göre hesaplıyor ve çalışıyor oyun çalışırken sürekli konumları tekrar tekrar hesaplanıyor. Gerçek zamana göre... Bu çok daha performans harcıyor. (Hareketli ışıklar için kullanılmalıdır genelde)<br>
3- mixed realtime ve baked karışımı bir şeydir.hem Performans hem gerçek zamana uygun kullanılır.<br><br>
İnstensity : Parlaklık<br>
İndirect Multiplier : Dolaylı ışık aydınlatması bir yere çarptıktan sonra yansıtmasıdır.<br>
Shadow type : Işığın çarptığı objelerde gölge olup olmayacağını. Hard / Soft genelde soft(Yumuşak) kullanılır. <br>
Cookie : Texture da da cookie vardı.Biz ışığı istediğimiz bir şekile sokabiliyoruz.<br>
Draw Halo : Güneş yaparken kullanılır. <br>
Render Mode : Seçilen ışığın oluşturma önceliğini ayarlıyoruz. Daha önemli ışıklar var örneğin güneş ışığı.<br>
Culling Mask Işığın alması için layerları seçiyoruz.
<br>

Spot Light
---
Daha çok belli bölgeyi oval noktayı aydınlatmak için kullanılır. El feneri , sahne konuşmacısı ışığı gibi kullanılabilir.

Area Light
---
Otomatik hesaplamayı açman lazım auto generate lighting off u on yapmak lazım.<br>
Ortam ışıklandırması oda gibi daha çok kare olarak kullanılan ışık türüdür.Statik değişmeyecek obje yapabiliriz.Objelerinde üzerine ışık vurması için statik obje olmasını sağlarız ve ek olarak area light biraz daha beklemeli ve render etmeli bir obje.

Reflection Probe (Light Probe Group grup çoklu halidir genelde group kullanılır.)
---
ANLAMADIM :) 


Lighting Paneli
---
window > rendering > lighting  <br>
<br>

# Efekt
<p>
    Kıvılcım efekti alev efekti bunların anlatıldığı bölümdür.
</p> 

Component efektleri:
---
1- Trail Renderer :<br>
<p>
    Bu bir objenin arkasında bırakacağı iz olarak düşünebiliriz.
</p>
Bir grafik var burada efektin boyutunu kalınlığını ayarlıyabiliyoruz add key ile birden fazla key ekleyip uzunluğun sonunu ve başını isteğimize göre tasarlayabiliyoruz boyutunu.<br>
time: efektin yaşam ömrünü belirler<br>
autodestruckt : efekt bittiğinde bağlı objeyi yok eder. // trail efektinde bir den fazla efektin birikmesi objelerin durması şişmeye sebep olur silmek etkili olabilir...<br>
emmiting : tamamen çizgiyi iptal eder tiki tekrar attığımızda çizgi devam eder.<br>
Color: ize renk veriyoruz <br>
Comer Vertices köşelerin daha koşeli olması yuvarlağımsı yumuşak yapar.<br>
End Cap Vertices : objenin ilk çıktı kısımında ki efekti izi düz değil de oval yapar. <br>
Alignment :Çizginin baktığı yönü değiştiriyor.<br><br>
Texture Mode : <br>
Skretch : Çizginin üzerine bütün texture yayar.<br>
Tile : texture yani Duman ufaksa küçük küçük tekrarlar sağlar. <br>
Distribute Per Segment : Tüm köşeleri eşit aralıklarla hizalar.<br>
Repeat Per Segment :Dokunun iz boyunca tekrarlamasını sağlar<br><br>

Generate Lighting Data : Işık datası oluşturur bunu başka yerde kullanmamız içinde datayı saklar .<br>
Shadow Bias : Gölge sapmasıdır yere vurduğunda gölgenin yayılmasını sağlar.<br>
<br><br>
Meterials Kısmı <br><br>
<p>

</p>
<br><br>
Lighting Kısmı <br><br>
Cast Shadows :gölgelendirme olup olmayacağını seçebiliyoruz on off ile two sided arkadan gelen efektinde gölgesini görürüz daha gerçekçi olur shadows only ise sadece gölge görürüz çizgi yok olur.<br>
Receive Shadows : efektin üstüne gölge etki edecek mi etmeyecek mi seçiyoruz binanın altında kalırsa gölgeden etkilenir ama etkilenmesini istemiyorsak gibi seçenekler var.<br>
<br><br>
Probes Kısmı <br><br>
Light Probes :<br>
Reflection Probes :<br>
<br><br>
Additional Settings Kısmı<br><br>
Motion Vectors : probes lar ile ilgili kısım <br>
Dynamic Occlusion : hesaplama yaparken obje statik yapılmışken dahil olmasını sağlar.<br>
Sorting Layer :birden fazla efekt varsa sıralamasını yaparız<br>
Order İn Layer:<br>
<br><br><br>

2- Line Renderer :<br>
<p>
    Burada bir obje ile nokta arasında çizgi çizmeyi sağlayan efekti göreceğiz ışın silahıyla lazer yapan efekt budur.<br>
    Editleme bölümü var burada ki noktacıklarla istediğimiz gibi boyutlandırabiliyoruz şekillendiriyoruz.<br>
    + ya bastığımızda mouse position bastığımız noktaya uygular.
</p>
<br>
Use World Space :  tiksiz olduğunda mesela silahı hareket ettirdiğimde ışında gönderdiğim ışında silaha bağlı olarak hareket eder ancak tik atarsak use world space diyerek dünyayı kullan dediğimizde ise obje ile ışın arasında ki bağ kopar .<br>
<br><br>

3- Halo :<br>
<p>
    Sis perdesi olarak kullanılabilir çok detayı yok.
</p>
<br><br><br>

4- Line Flare :<br>
<p>
    Yıldızdaki parlama olarak yapılabilir bir veya farklı yerlerde kullanılabilir güneş ışığını aldığı sürece çalışır.
</p>
<br><br><br>
5- Projector :<br>
<p>
    Projeksiyon aleti işlevi görür bir görüntüyü yansıtmak için kullanılabilir. reklamlar için kullanılabilir etkili bir yöntemdir.
</p>
<br><br><br>
6- Line Renderer :<br>

<br><br><br>

# Efektler

Particle system:
---
Genelde hazır yapılar kullanılır.
Kamp ateşi gibi kompleks yapılır için kullanılır bunlar için genel olarak hazır assetler bulunuyor veya benzerlerini internetten bakarak yapılabilir.
<br>
<br>

Visual Graphic 
---
Daha az güç isteyen ekran kartı üzerinde çalışan bir efekttir sistemi çok yormaz bunun için > Packeage Manager kısmından Visual effect graph indirilir.<br>

Daha sonrada  Dosyalar yani project kısmına creat > Visual Efekt > visual effect graph' a tıklıyoruz. <br>

Bize genel olarak bir şablon veriliyor.<br>
Spawn system kısmı çıkma oranı belirleniyor yoğunluğu.<br>
<br>
system kısmına geliyoruz.<br>
<br>
set velocity random : güç uyugluyoruz belirlediğimiz yöne doğru.
<br>
lifetime:efektlerin yaşam ömrünü belirleriz.
<br>
<br>
update particle:günceleme döngüsü oluşturulan parçacıkların sürekli işlenmesi çalışması.
<br>
output particle quad:
