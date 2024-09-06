# School Database Application

Bu C# uygulaması, bir okul veritabanında öğrenci ve sınıf bilgilerini yönetir ve LINQ kullanarak öğrencileri sınıflara göre gruplandırır.


## Proje Açıklaması

Bu uygulama, iki temel sınıfı içerir:
- `Student`: Öğrenci bilgilerini temsil eder (`StudentId`, `StudentName`, `ClassId`).
- `Class`: Sınıf bilgilerini temsil eder (`ClassId`, `ClassName`).

Uygulama, LINQ kullanarak her sınıfın altında o sınıfa ait öğrencilerin listelendiği bir sonuç elde eder.


### Proje Kurulumu
1. Projeyi klonlayın:
   ```bash
   git clone https://github.com/kullanici-adiniz/school-database-application.git
