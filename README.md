# 🏨 BookingRapidApi - Otel Listeleme Uygulaması


## 📌 Proje Açıklaması  
Bu proje, **RapidAPI** üzerinden **Booking API** kullanılarak geliştirilmiş bir **otel listeleme uygulamasıdır**.  
Kullanıcılar belirledikleri kriterlere göre otelleri filtreleyebilir ve en uygun seçenekleri listeleyebilirler.  

---

## 🔍 Kullanıcı Deneyimi  

**Kullanıcıdan alınan bilgiler:**  
✅ 🗺️ **Şehir** → Filtrelemek istedikleri destinasyon  
✅ 📅 **Giriş Tarihi** → Konaklama başlangıç tarihi  
✅ 📅 **Çıkış Tarihi** → Konaklama bitiş tarihi  
✅ 👤 **Yetişkin Sayısı**  
✅ 🧒 **Çocuk Sayısı**  

💡 **Listeleme sonucunda kullanıcının erişebileceği bilgiler:**  
🏠 **Otel Adı**  
⭐ **Otel Puanı**  
## 🚀 Kullanılan Teknolojiler  

🔹 **ASP.NET Core (6.0)** ile geliştirildi  
🔹 **Tek katmanlı mimari** kullanıldı  
🔹 **Booking API'nin iki farklı endpoint'i** entegre edildi  

📌 **Search Hotel Destination Endpoint:**  
Kullanıcının girdiği şehir adına karşılık gelen **şehir ID’si** elde edildi.  

📌 **Search Hotels Endpoint:**  
Şehir ID’si ve diğer filtreleme kriterleri kullanılarak **uygun oteller listelendi**.  
📌 **Proje İçerisinden Görüntüler:**
![screencapture-localhost-7083-BookingView-Home-2025-02-02-00_46_42](https://github.com/user-attachments/assets/fc945d89-cf09-440b-89cd-ac1fc2812551)
![screencapture-localhost-7083-BookingView-BookingHotelSearch-2025-02-02-00_47_15](https://github.com/user-attachments/assets/40778e2f-131a-48ca-b313-4001c7512aab)
