using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages // static verilen class newlenemez gerek yok
    {
        public static string ProductAdded = "Ürün Eklendi!"; // private bir field olsaydı camel case
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz!";
        public static string MaintenanceTime = "Bakım Zamanı!";
        public static string ProductsListed = "Ürün Listelendi!";
        public static string ProductCountOfCategoryError = "Kategori limiti aşımı!";
        public static string ProductNameAlreadyExists = "Ürün ismi kullanılmış!";
        public static string CategoryLimitExceded = "Kategori limiti aşımı!";
        public static string AuthorizationDenied = "Yetkiniz yok!";
        public static string UserRegistered = "Kullanıcı kayıt oldu!";
        public static string UserNotFound = "Kullanıcı bulunamadı!";
        public static string PasswordError = "Paraloda bir hata gözüküyor!";
        public static string SuccessfulLogin = "Başarıyla giriş yapıldı!";
        public static string UserAlreadyExists = "Bu kullanıcı sistemde bulunuyor1";
        public static string AccessTokenCreated = "Erişim tokeni yaratıldı!";
    }
}
