# Project Management System (Fluent UI and Blazor)

Bu proje, .NET 8 ve Microsoft Fluent UI kullanılarak geliştirilmiş bir **Proje ve Görev Yönetimi** uygulamasıdır. Standart tabanlı yapıdan,  bileşen tabanlı modern bir kullanıcı arayüzü mimarisine geçiş hedeflenerek yapılandırılmıştır.

---

## Technologies and Tools / Kullanılan Teknolojiler ve Araçlar

- **Development Environment / Geliştirme Ortamı:** Visual Studio 2022  
- **Database / Veritabanı:** MSSQL Server  
- **Framework:** .NET 8 / Blazor Web App (Interactive Auto)  
- **UI Library / UI Kütüphanesi:** Microsoft Fluent UI Blazor Components  
- **ORM:** Entity Framework Core (Database First)  

---

## Project Objectives and Implementation / Proje Hedefleri ve Uygulama

### HTML-Free UI / HTML İçermeyen Arayüz
Proje gereksinimleri doğrultusunda, tüm standart HTML öğeleri Fluent UI eşlenikleriyle değiştirilmiştir. Kullanıcı arayüzünde hiçbir ham HTML etiketi bırakılmamıştır.

### Component Mapping / Bileşen Dönüşümü
Standart öğeler şu şekilde Fluent UI bileşenlerine dönüştürülmüştür:

| Standart Element | Fluent UI Component |
|-----------------|------------------|
| `button`        | `FluentButton`   |
| `select`        | `FluentSelect`   |
| `QuickGrid`     | `FluentDataGrid` |
| input alanları  | `FluentTextField`, `FluentNumberField`, vb. |

### CRUD Operations / CRUD Operasyonları
- Ekleme, listeleme, güncelleme ve silme işlemleri, **Fluent UI bileşenleri** kullanılarak gerçekleştirilmiştir.  
- Veritabanı altyapısı, 232 projesinden alınmıştır.

### Scaffolding & Refactoring / Scaffold ve Refactoring
- Visual Studio tarafından otomatik oluşturulan (scaffold) sayfalar, tüm HTML kalıntılarından temizlenmiş ve Fluent UI mimarisine uygun hale getirilmiştir.

---

## Installation and Setup / Kurulum Bilgileri

1. **Environment / Ortam:** Visual Studio 2022 ve MSSQL Server kurulu olmalıdır.  
2. **Fluent UI Setup / Fluent UI Kurulumu:** [Code Setup Guide](#) rehberini takip edin.  
3. **Project Templates / Proje Şablonları:** Fluent UI Blazor Templates paketini yükleyin.  
4. **Database Configuration / Veritabanı Yapılandırması:** `appsettings.json` dosyasındaki bağlantı dizesini yerel veritabanı bilgilerinizle güncelleyin.  

---

**Not:** Bu proje, akademik gereksinimlerle oluşturulmuş olup, tüm kullanıcı arayüzü bileşenleri Fluent UI ile değiştirilmiştir.
