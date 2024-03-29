﻿using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba Eklendi";
        public static string CarDeleted = "Araba Silindi";
        public static string CarUpdated = "Araba Guncellendi";
        public static string CarNameUnvalid = "Araba Ismi Gecersiz";
        public static string MaintenanceTime = "Bakim Zamani";
        public static string CarsListed = "Arabalar Listelendi";
        public static string BrandAdded = "Marka Eklendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandUpdated = "Marka Guncellendi";
        public static string ColorAdded = "Renk Eklendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorUpdated = "Renk Guncellendi";
        public static string CustomerAdded = "Musteri Eklendi";
        public static string CustomerDeleted = "Musteri Silindi";
        public static string CustomerUpdated = "Musteri Guncellendi";
        public static string CustomersListed = "Musteri Listelendi";
        public static string UserAdded = "Kullanici Eklendi";
        public static string UserDeleted = "Kullanici Silindi";
        public static string UserUpdated = "Kullanici Guncellendi";
        public static string UsersListed = "Kullanici Listelendi";
        public static string CarRented = "Araba Kiralandi";
        public static string CarDelivered = "Araba Teslim Edildi";
        public static string CarNotDelivered = "Araba Teslim Edilmedi";
        public static string CarCanBeRented = "Araba Kiralanabilir";
        public static string CarCanNotBeRented = "Araba Kiralanamaz";
        public static string ImageLimitExceeded = "En Fazla 5 Adet Resim Eklenebilir";
        public static string AuthorizationDenied = "Yetkiniz Yok";
        public static string UserRegistered = "Kullanici Kaydedildi";
        public static string UserNotFound = "Kullanici Bulunamadi";
        public static string PasswordError = "Parola Hatali";
        public static string SuccessfulLogin = "Basarili Giris";
        public static string UserAlreadyExists = "Mevcut Kisi Kayitli";
        public static string AccessTokenCreated = "Token Olusturuldu";
        public static string BrandsListed = "Markalar Listelendi";
        public static string ColorsListed = "Renkler Listelendi";
        public static string RentalDetailsListed = "Kiralama Detaylari Listelendi";
    }
}
