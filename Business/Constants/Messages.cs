using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductAddError = "Ürün ekleme hatası";
        public static string ProductUpdated = "Ürün güncellendi";
        public static string ProductNameExists = "Aynı isimde ürün mevcut";
        public static string CategoryLimitExceeded = "Kategorideki ürün limiti doldu";

        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string ProductCountOfCategoryError = "Kategorideki ürün sayısı 10'un üzerinde olduğunda yeni ürün girilemez";
        public static string AuthorizationDenied = "Authorization Denied";
        public static string UserRegistered = "User Registered";
        public static string UserNotFound = "User Not Found";
        public static string PasswordError = "Wrong Password";
        public static string SuccessfulLogin = "You are in";
        public static string UserAlreadyExists = "User Already Exists";
        public static string AccessTokenCreated = "Access Token Created";

    }
}
