# Unity C# Learning
## C# Learning Files

### Değişkenler 

```C#
int i = 0; //tam sayılar
string ad ="dogukan"; //metinler
float yaş = 20.5f; //virgüllü küsüratlı sayılar
bool dogrumu = true; //doğru yanlış
```

### Döngüler

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

### Diziler

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

### Switch Case

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

### Listeler

#### ArrayList ve List vardır.

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

### Class ve Fonksiyon(Method)
Namespace ise sınıfları kapsar.
Class = sınıfları temsil eder içerisinde method'lar bulunur.
Fonksiyon = Method'lar dır aynı anlama gelirler.
Örnek: 
Namespace okulun adi.>class sınıfın adları.>fonksiyon da öğrenci adları.

### Erişim (Public Private Protected)
- Public(Erişilebilir dışarıdan): örnek unity içerisinden değer vermek için falan kullanılabiliyor.
- Private(Dışarıdan erişim olamaz):Sadece kod dosyasında kullanılır o sınıf dışında kullanılamaz.
- Protected : Methoda protected erişimi verirsek. Miras almayı yaptığımızda direk kullanım için sadece methodAdi(); kullanılabilir.
- Miras alma olayı :Başka dosyadı classın içinde ki methodları kullanmak için kullanılan yöntemdir. monobehaviour yazan kısma diğer dosyanın class adı yazılır.
<p>classAdi degisken = new classAdi(); tanımlaması yapılmalıdır. ve diger class'in methodunu kullanabilmek için degisken.methodAdi(); kullanılır.</p>

### Temel Fonksiyonlar

#### Start Fonksiyonları
- Awake():İlk çalışan fonksiyon
- OnEnable():İkinci çalışan fonksiyondur.Obje Aktif ise çalışacak fonksiyondur.1 KERE
- Start():üçüncü çalışan fonksiyondur sırayla çalışırlar ve start fonksiyonları birer kere çalışmaktadır.

#### Güncelleme Fonksiyonları   (sürekli çalışırlar durmaksızın)
- FixedUpdate(): Update fonksiyonundan daha çok çalışır daha hızlı çalışır hız olarak 0.2 salisede tekrar çalışır update ise 1 saniye.
- Update(): Sürekli çalışan fonksiyondur.Sürekli çalışması sistemleri çok yorar dikkatli kullanılması gerekmektedir.
- LateUpdate(): Lateupdate ise bütün update bütün fonksiyonlar çalıştıktan sonra en son çalışır. Bütün fonksiyonların bitmesini bekler.
- OnDisable():Obje pasif ise çalışacak fonksiyondur.1 KERE

### Using ve Namespace 

- Namespace nedir? : Class ve methodların çakışmasını önlemek için kullanılır. Verimliliği çok yüksektir. Gruplama için kullanılır. Kod çakışmaları önlenir  gruplama ile önceden hazırlanan kodlar daha rahat çekilir ve kolaylık sağlanır. Namespace ile class havuzu oluşturabiliriz. Sınırsız işlem yapılabilir.
- Namespace kullanmak için usinge eklenmesi gerekir.  Using NamespaceAdı diye eklenir. Sınıf tanımlamak için de ClassAdi degisken = new ClassAdi();
- Sınıf methodunu çapırmak için ise degisken.method();
- NOT: Methodlara dışarıdan değer verme işlemi. String ,int ,float vs.
- Using : Hazırlanmış kodları çekmek için kullanılan kütüphanelerdir diyebiliriz.



### MonoBehaviour > Invoke Method !

- Invoke: bir defa kullanım için. zamanlayıcı ayarlanır.
- InvokeRepating : Sürekli çalışması gereken metotu belirli sürelerle çalıştırmak için kullanılır ve durdurmak için kullanılır.
- Invoke var mı? kontrol için if( IsInvokeing("metot") )
- Durdurmak için CancelInvoke(); Kullanılır

### GETCOMPONENT  VE GETCOMPONENTS 
<p>Objelerin componentlerinde script kodları ile değişiklik yapmak için kullanılanGetCompoenet komutunu gördük.</p>
<p>GetComponents ise 1 den fazla component ayar için kullanılır. Aynı componentlerin değişiklikleri için kullanılır 2 adet Capsül Colider varsa veya 2 adet ses varsa bunların ayarlarını aynı yapabiliriz. </p>

```C#
- GetComponent<CapsuleCollider>(); // burada ki tanımlamamız da  objelerin ayarlarına giriş colliderında değişiklik yapabiliriz. 
- GetComponent<CapsuleCollider>().enabled = false; //pasif hale gelir veya triggerini aç kapa yapabiliriz
```

#### örnek kullanım için:
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

### Obje Yakalama Değişiklik yapma.

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
###  GameObject ve gameObject farkı

<p> GameObject ve gameObject farklıdır. küçük ile başlayan içinde bulunduğumuz scriptin objesi anlamına gelir.

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

### OBJELERİ AKTİF PASİF YAPMA

```C#

gameObject.SetActive(false); // pasif yapar
gameObject.SetActive(true); // aktif yapar
if(gameObject.activeSelf) // objenin durumunu öğrenmek için kullanılır aktif mi pasif mi 
if ( gameObject.CompareTag("dusman")) // tagı düşman ise şunları şunları yap diye biliyoruz burada
Rigidbody rigidekle= gameObject.AddComponent<Rigidbody>() as Rigidbody; // objeye component eklemek için kullanılabilir.
rigidekle.isKinematic=true; // ve componentin ayarlarını yapabiliyoruz.

```

### Message BroadCast - Send Message

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
### Obje yok etme silme 

<p> objeleri yok etmek silmek için kullanılan script kodunu göreceğiz destroy komutunu kullanırız.Süreli destroy içinde kullanılır.</p>

```C#

Destroy(gameObject); // komut çalıştığında direk script dosyasının bulunduğu obje silinir.
Destroy(gameObject,2f); // 2 saniye sonra silinir.
Destroy(this); // this bu demek yani bu komut script dosyasını silmek için kullanılır.

```

#### Component silmek script dosyası ile

```C# 

Destroy(GetComponent<CapsuleCollider>());

```

### Prefab Oluşturma

<p> Yeni sahne oluşturmak için File kısmından new Scane oluşturuyoruz ctrl s ile kaydediyoruz isim veriyoruz. Sahneler arası obje vs script dosyası taşıma işlemini prefab deniyor.  Objeyi örneklendirmek(prefab yapmak) için  objeyi tutup aşşağıda proje kısmında dosyalar kısmına bırakıyoruz ve artık prefab oldu. Artık çağırılabilir kalıp haline geldi Sahneler arası kullanabilir Ve bütün özellikleri geldi .</p>
<p> Prefab güncellemek için tüm sahnelerde open prefab yazısına tıklayıp değiştirebiliriz veya objeler kısmında küçük ok tuşuna basabiliriz. </p>

### Transform translate ayarları

transform işlemleri  için script dosyası oluşturuyoruz.

transform adresleri position , rotation ve scale değerlerini alabilmek öğrenmek için ;

```C#

Debug.Log(transform.position);

Debug.Log(transform.rotation);

Debug.Log(transform.localScale);

```

#### Vector nedir ?

herhangi bir objenin yönlerini ve pozisyonlarını değiştirmemizi sağlıyor.Float türünde değerler alırlar.

#### Vector tanımlama

```C#

Vector3 pozisyon1; //vector tanımlamak
Vector3 pozisyon2;
pozisyon1 = new Vector3(1f, 2f, 1f);
pozisyon2 = new Vector3(1f, 2f, 1f);

```

#### Vector tanımlama 2

``` C#

   Vector2 sa;  // 2boyutlu oyunlar için varsayılan floattır int olması için vector2int kullanılır  vektor 2 de z yoktur bu yüzden 2 boyut
   Vector3 sa1; // 3boyutlu oyunlar için 3 boyutlu içinde aynı kural geçerlidir vector3int.
   Vector4 asd; // modellemeydi sanırım bölgelendirmeler 
   Quaternion d; //  objeler arası mesafe için

```
<p>
Quaternion : Objelerin arasında ki mesafeyi ölçüyoruz bilmek önemli.
Transform değerlerini değiştirmek için de ;
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

#### Vector konum kontrol

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

### Static Methodlar - Vector3 

<p>

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

### Transform Özellikleri - Methodlar

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