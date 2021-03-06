﻿using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarDailyInValid = "Günlük ücret geçersiz";

        public static string CarAdded = "Araba eklendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarListed = "Arabalar listelendi";

        public static string BrandListed = "Markalar listelendi";
        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";

        public static string ColorUpdated = "renk güncellendi";
        public static string ColorAdded = "renk eklendi";
        public static string ColorDeleted = "renk silindi";
        public static string ColorListed = "renkler listelendi";

        public static string CustomerListed = "Müşteriler listelendi";
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";

        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UserDeleted = "Kullanıcı silndi";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserListed = "Kullanıcılar listelendi";

        public static string RentalListed = "Kiralanan Arabalar Listelendi";
        public static string RentalAdded = "Araba Kiralama işlemi baraşıyla gerçekleştii";
        public static string RentalDeleted = "Araba Kiralama işlemi iptal edildi";
        public static string RentalUpdated = "Araba Kiralama işlemi güncellendi";
        public static string RentalFailedAddOrUpdate = "Bu araba henüz teslim edilmediği için kiralayamazsınız";
        public static string RentalReturned = "Kiraladığınız araç teslim edildi";

        public static string CarImageLimitExceeded = "Bir araca ait beşten fazla görsel olamaz";


        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kullanıcı kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Yanlış parola";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı zaten kayıtlı";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
