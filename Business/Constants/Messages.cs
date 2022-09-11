using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
