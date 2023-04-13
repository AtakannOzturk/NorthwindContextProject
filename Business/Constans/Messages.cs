using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constans
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi Geçersiz";
        public static string MaintenanceTime="Sistem Bakımda...";
        public static string ProductsListed="Ürünler Listelendi";
        public static string ProductDeleted = "Ürün Silindi";
        public static string ProductModified = "Ürün Güncellendi";
        public static string UnitPriceInvalid;
        public static string ProductCountOfCategoryError = "Ürünler Kategoriye göre Listelend";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
    }
}
