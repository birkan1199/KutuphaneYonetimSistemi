# 📚 Kütüphane Yönetim Sistemi

Bu proje, C# kullanılarak geliştirilmiş konsol tabanlı bir **Kütüphane Yönetim Sistemi** uygulamasıdır.

Projenin amacı; kitapların ve üyelerin yönetilmesi, kitapların ödünç verilmesi ve iade edilmesi gibi temel kütüphane işlemlerini nesne yönelimli programlama (OOP) mantığıyla gerçekleştirmektir.

## 🚀 Özellikler

- Kitap ekleme
- Kitap silme
- Kitap listeleme
- Kitap arama
- Üye ekleme
- Üye silme
- Üye arama
- Kitap ödünç alma
- Kitap iade etme
- Ödünç geçmişini görüntüleme
- Gecikme cezası hesaplama
- Aynı ISBN numarasına sahip kitabın tekrar eklenmesini engelleme
- Aynı ID numarasına sahip üyenin tekrar eklenmesini engelleme
- Ödünçte olan kitabın tekrar ödünç alınmasını engelleme

## 🧱 Kullanılan Class'lar

### Kitap

Kütüphanede bulunan kitapların bilgilerini tutar.

Kitap içerisinde:

- ISBN
- Kitap başlığı
- Yazar
- Yayın yılı
- Yayınevi
- Ödünç durumu

bilgileri tutulmaktadır.

### Uye

Kütüphaneye kayıtlı üyelerin bilgilerini tutar.

Üye içerisinde:

- Üye ID
- Ad Soyad
- Telefon

bilgileri tutulmaktadır.

### Odunc

Kitapların hangi üye tarafından ödünç alındığını ve ödünç işlemiyle ilgili tarih bilgilerini tutar.

Ödünç içerisinde:

- Kitap
- Üye
- Alış tarihi
- Son teslim tarihi
- Teslim tarihi

bilgileri tutulmaktadır.

## 🔗 Class İlişkileri

Projede `Odunc` class'ı, `Kitap` ve `Uye` class'ları arasında bağlantı kurmaktadır.

Bir ödünç işlemi gerçekleştirildiğinde:

- Hangi kitabın ödünç alındığı
- Hangi üyenin kitabı aldığı
- Kitabın ne zaman alındığı
- Son teslim tarihi
- Kitabın ne zaman iade edildiği

`Odunc` nesnesi içerisinde saklanır.

Bu sayede kitap, üye ve ödünç işlemleri birbiriyle ilişkilendirilmiştir.

## ⏰ Ödünç Alma ve Gecikme Sistemi

Bir kitap ödünç alındığında son teslim tarihi otomatik olarak **14 gün sonrası** olarak belirlenir.

Kitap son teslim tarihinden sonra iade edilirse geciken gün sayısı hesaplanır.

Her geciken gün için:

**5 TL gecikme cezası** uygulanır.

## 🛠️ Kullanılan Teknolojiler

- C#
- .NET
- Console Application
- LINQ
- List
- Nesne Yönelimli Programlama (OOP)

## ▶️ Kullanım

Program çalıştırıldığında kullanıcı aşağıdaki menü üzerinden işlem yapabilir:

1. Kitap Ekle
2. Kitap Sil
3. Kitap Listele
4. Üye Ekle
5. Üye Sil
6. Üye Ara
7. Kitap Ödünç Alma
8. Kitap İade Et
9. Kitap Ara
10. Ödünç Geçmişi
11. Çıkış

Kullanıcı yapmak istediği işlemin numarasını girerek ilgili işlemi gerçekleştirebilir.

## 👨‍💻 Geliştirici

**Arda Birkan Berker**

Yazılım Mühendisliği
