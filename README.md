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



