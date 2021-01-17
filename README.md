# Unity C# Learning
## C# Learning Files

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
classAdi degisken = new classAdi(); tanımlaması yapılmalıdır. ve diger class'in methodunu kullanabilmek için degisken.methodAdi(); kullanılır.




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




