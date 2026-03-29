# Kütüphane Takip

C# WinForms ile geliştirilmiş masaüstü kütüphane yönetim sistemi. Kitap ve okuyucu kayıtlarını SQL Server veritabanında tutar, ödünç verme işlemlerini yönetir.

## Öne Çıkanlar
- Merkezi bağlantı yönetimi için ayrı `Baglanti` sınıfı — her formdan tekrar bağlantı yazmak yerine tek noktadan erişim
- Admin ve kullanıcı için ayrı giriş formları ve yetki seviyeleri
- Kitap ekleme, okuyucu kaydı ve kitap verme işlemleri farklı formlarda yönetiliyor

## Tech Stack
![C#](https://img.shields.io/badge/C%23-239120?style=flat-square&logo=csharp&logoColor=white)
![WinForms](https://img.shields.io/badge/WinForms-512BD4?style=flat-square&logo=dotnet&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?style=flat-square&logo=microsoftsqlserver&logoColor=white)

## Gereksinimler
- Visual Studio
- SQL Server Express
- `Kutuphane` adında bir SQL Server veritabanı

## Kurulum

1. SQL Server'da `Kutuphane` veritabanını oluştur.
2. `Baglanti.cs` içindeki bağlantı stringini kendi SQL Server örneğine göre güncelle.
3. `KutuphaneTakip.sln` dosyasını Visual Studio'da aç ve çalıştır.

## Özellikler
- Admin ve kullanıcı girişi
- Kitap ekleme ve listeleme
- Okuyucu kaydı
- Kitap ödünç verme takibi
