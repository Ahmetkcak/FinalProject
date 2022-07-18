using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductListed = "Ürünler listelendi";
        public static string ProductDeleted = "Ürün silindi";
        public static string ProductUpdated = "Ürün güncellendi";

        public static string CategoryListed = "Kategori listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExist = "Bu isim zaten başka bir ürün var";
        public static string CategoryLimitExceded="Kategori limiyi aşıldığı için yeni ürün eklenemeiyor";
        public static string AuthorizationDenied = "Yetkiniz yok";
    }
}
