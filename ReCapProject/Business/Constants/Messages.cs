using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    //public olan temel field'ları PascalKeys yazıyoruz.
    //Constants : Sabitler //hep new()'lememek için statin yaparız.(. ile çağırırız.)
    public static class Messages
    {
        public static string MaintenanceTime = "System is Under Maintenace";
        //for the CarManager
        public static string CarAdded = "Car Added";
        public static string CarNameInvalid = "Car name must be more than two letters";
        public static string CarListed = "Car Listed";
        public static string CarDeleted = "Car Deleted";
        public static string CarUpdated = "Car Updated";

        //for the BrandManager

        public static string BrandAdded = "Brand Added";
        public static string BrandNameInvalid = "Brand name must be more than two letters";
        public static string BrandListed = "Brand Listed";
        public static string BrandDeleted = "Brand Deleted";
        public static string BrandUpdated = "Brand Updated";

        //for the ColorManager

        public static string ColorAdded = "Color Added";
        public static string ColorNameInvalid = "Color name must be more than two letters";
        public static string ColorListed = "Color Listed";
        public static string ColorDeleted = "Color Deleted";
        public static string ColorUpdated = "Color Updated";
        public static string ColorNameAlreadyExists = "Böyle isimli renk bulunuyor.";


        //for the UserManager

        public static string UserAdded = "User Added!";
        public static string UserDeleted = "User Deleted!";
        public static string UserUpdated = "User Updated!";
        public static string UserListed = "User Listed!";
        public static string UsersListed = "Users Listed!";

        //for the CustomerManager

        public static string CustomerAdded = "Customer Added!";
        public static string CustomerDeleted = "Customer Deleted!";
        public static string CustomerUpdated = "Customer Updated!";
        public static string CustomerListed = "Customer Listed!";
        public static string CustomersListed = "Customers Listed!";
        public static string CustomerNameInvalid = "Customer name must be more than two letters";

        //for the CarImageManager
        public static string CarImageLimitExceeded= "Arabaya resim ekleme limitine ulaşıldı";
        public static string CarImageAdded="Araç resimi eklendi";
        public static string CarImageUpdated="Araç resimi güncellendi";
        public static string ImageNotFound="Resim bulunamadı.";
        public static string CarImageDeleted ="Araç resimi silindi";

        public static string AuthorizationDenied = "Yetkiniz yok.";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
        public static string ProductUpdated = "Ürün başarıyla güncellendi";
    }
}
