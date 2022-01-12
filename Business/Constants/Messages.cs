using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string BrandListed = "Markalar listelendi";
        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";

        public static string CarAdded = "Araba eklendi";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string CarListed = "Arabalar listelendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";

        public static string ColorListed = "Renkler listelendi";
        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";

        public static string CustomerListed = "Müşteriler listelendi";
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomerDeleted = "Müşteri silindi";

        public static string UserListed = "Kullanıcılar listelendi";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";

        public static string RentalAdded = "Kiralama eklendi";
        public static string RentalListed = "Kiralama listelendi";   
        public static string RentalDeleted = "Kiralama silindi";
        public static string RentalUpdated = "Kiralama güncellendi";


        public static string CarImageAdded = "Araba resmi eklendi";
        public static string CarImageNotFound = "Resim bulunamadı";
        public static string CarImagesUpdated = "Araba resmi yüklendi";
        public static string CarImagesListed = "Araba resimleri listelendi";
        public static string CarImageDeleted = "Araba resmi silindi";
        public static string CarImageLimitExceeded = "Araba resim limiti aşıldı";

        public static string ReturnedDontFromRental = "Araba kiralamada,iade edilmedi";
        public static string CarCountOfBrandError = "Bu modeldeki araba sayısı belirlenen sayıdan fazla";
        public static string CarNAmeAlreadyExists = "Bu isimde bir araba mevcut";
        public static string CarImageCountError = "Araba resim sayısı belirlenen sayıdan fazla";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kullanıcı kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatalı";
        public static string SuccessfulLogin = "Giriş işlemi başarılı";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Access token oluşturuldu";
        
    }
}
