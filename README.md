# Inheritance Örnek Projesi

Bu proje, C# dilinde kalıtım (inheritance) kavramını açıklamak için basit bir örnek sunmaktadır. Projede iki sınıf bulunur: `Ogrenci` ve `Ogretmen`, her ikisi de `BaseKisi` adlı temel sınıftan kalıtım alır.

## Sınıflar

### 1. BaseKisi
`BaseKisi`, ortak özellikleri ve davranışları içeren temel bir sınıftır. Aşağıdaki üyeleri içerir:

- **FirstName**: Kişinin adı
- **LastName**: Kişinin soyadı
- **YazdirAdSoyad()**: Ad ve soyad bilgisini konsola yazdırır.

### 2. Ogrenci
`Ogrenci` sınıfı, `BaseKisi` sınıfından kalıtım alır ve aşağıdaki ek üyeleri içerir:

- **StudentNumber**: Öğrenci numarası
- **YazdirOgrenciBilgileri()**: Öğrenciye ait tüm bilgileri konsola yazdırır (ad, soyad, öğrenci numarası).

### 3. Ogretmen
`Ogretmen` sınıfı da `BaseKisi` sınıfından kalıtım alır ve aşağıdaki ek üyeleri içerir:

- **Pay**: Öğretmenin maaşı
- **YazdirOgretmenBilgileri()**: Öğretmene ait tüm bilgileri konsola yazdırır (ad, soyad, maaş).

## Kullanım

Ana program, iki örnek oluşturur: bir `Ogretmen` ve bir `Ogrenci`. Her bir nesne için bilgileri yazdıran ilgili fonksiyonlar çağrılır.

### Örnek Çıktı:

```plaintext
Öğretmenimizin bilgileri aşağıdaki gibidir:
Ad: Ayşe, Soyad: Öztürk
Maaş bilgisi: 30000
-------------------------------------------------------
Öğrencimizin bilgileri aşağıdaki gibidir:
Ad: İrem, Soyad: Rakıcı
Öğrenci Numarası: 227




