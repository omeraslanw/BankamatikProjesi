# Bankamatik Projesi

<p align="center">
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C#">
  <img src="https://img.shields.io/badge/.NET%20Framework-512BD4?style=for-the-badge&logo=.net&logoColor=white" alt=".NET Framework">
  <img src="https://img.shields.io/badge/MS%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white" alt="MS SQL Server">
  <img src="https://img.shields.io/badge/Entity%20Framework-4E267A?style=for-the-badge" alt="Entity Framework">
</p>

## Açıklama

Bu proje, basit bir banka uygulamasının masa üstü simülasyonudur.

## Kullanılan Teknolojiler

- **Platform:** .NET Framework 4.7.2
- **Programlama Dili:** C#
- **Veritabanı:** Microsoft SQL Server
- **ORM (Object-Relational Mapping):** Entity Framework 6 (Database First)
- **Arayüz:** Windows Forms (WinForms)
- **Geliştirme Ortamı:** Visual Studio 2022 (veya kullandığınız sürüm)

## Kurulum Anlatımı

Projeyi yerel makinenizde çalıştırmak için aşağıdaki adımları izleyin.

### Ön Gereksinimler

- Visual Studio (2019, 2022 veya üstü)
- .NET Framework (Proje ile uyumlu versiyon, genellikle Visual Studio ile birlikte gelir)
- Microsoft SQL Server (Express, Developer veya tam sürüm)
- SQL Server Management Studio (SSMS) (Tavsiye edilir)

### Kurulum Adımları

1.  **Projeyi Klonlayın veya İndirin:**
    ```sh
    git clone https://github.com/omeraslanw/BankamatikProjesi.git
    ```

2.  **Veritabanını Oluşturun:**
    * **Yöntem A: SQL Script ile**
        1. Proje içerisindeki `Database` veya `SQL_Scripts` klasöründe bulunan `.sql` uzantılı script dosyasını SSMS ile açın.
        2. Script'i çalıştırarak (`Execute`) veritabanını, tabloları ve (varsa) başlangıç verilerini oluşturun.
    * **Yöntem B: Entity Framework Migrations ile**
        1. Visual Studio'da `Araçlar > NuGet Paket Yöneticisi > Paket Yöneticisi Konsolu` yolunu izleyerek konsolu açın.
        2. Konsolda `Update-Database` komutunu çalıştırın. Bu komut, migration dosyalarına göre veritabanını otomatik olarak oluşturacaktır.

3.  **Bağlantı Dizesini (Connection String) Yapılandırın:**
    1.  Solution Explorer'da projenizin altındaki `App.config` dosyasını açın.
    2.  `<connectionStrings>` etiketi altındaki bağlantı dizesini kendi SQL Server bilgilerinize göre güncelleyin.
        ```xml
        <connectionStrings>
          <add name="VeritabaniContextAdi" 
               connectionString="Data Source=SUNUCU_ADINIZ;Initial Catalog=VERITABANI_ADINIZ;Integrated Security=True;" 
               providerName="System.Data.SqlClient" />
        </connectionStrings>
        ```
        - `SUNUCU_ADINIZ`: Kendi SQL Server sunucu adınız (örn: `DESKTOP-ABC\SQLEXPRESS`).
        - `VERITABANI_ADINIZ`: 2. adımda oluşturduğunuz veritabanının adı.

4.  **Projeyi Çalıştırın:**
    1.  Visual Studio'da projeyi (`.sln` dosyası) açın.
    2.  Gerekli NuGet paketlerinin yüklendiğinden emin olun (Genellikle proje açıldığında otomatik yüklenir).
    3.  Projeyi derleyin (`Build > Build Solution`).
    4.  `Start` butonuna basarak uygulamayı başlatın.

## Uygulama Görselleri

<p align="center">
  <b>Giriş Ekranı</b><br>
  <img src="https://github.com/omeraslanw/BankamatikProjesi/blob/master/giris.png" alt="Uygulama Giriş Ekranı" width="600"/>
</p>

<p align="center">
  <b>Ana Ekran</b><br>
  <img src="https://github.com/omeraslanw/BankamatikProjesi/blob/master/ana%20sayfa.png" alt="Uygulama Ana Ekranı" width="600"/>
</p>

<p align="center">
  <b>Kaydolma Ekranı</b><br>
  <img src="https://github.com/omeraslanw/BankamatikProjesi/blob/master/kaydol.png" alt="Uygulama Kaydolma Ekranı" width="600"/>
</p>
