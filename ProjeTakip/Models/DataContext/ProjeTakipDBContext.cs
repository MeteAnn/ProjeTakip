using ProjeTakip.Models.Personel;
using ProjeTakip.Models.ProjeTakip;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace ProjeTakip.Models.DataContext
{
    public class ProjeTakipDBContext:DbContext
    {


        public ProjeTakipDBContext(): base("ProjeTakipDB") //Bu, ProjeTakipDBContext sınıfının kurucu (constructor) metodu. Bu kurucu metodun içinde veritabanı bağlantısını yapılandırır. base("ProjeTakipDB") ifadesi, veritabanının adını belirtir. Bu ad genellikle veritabanı bağlantı dizesinin bir parçası olarak kullanılır. Bu sınıf, "ProjeTakipDB" adlı bir veritabanına bağlanacaktır.

        {

          



        }


        public DbSet<PersonelBilgileri> PersonelBilgileris { get; set; } // Bu kod, PersonelBilgileri sınıfını temsil eden bir DbSet tanımlar. DbSet, veritabanı sorgularını çalıştırmak ve sonuçları almak için kullanılır. Bu DbSet, "PersonelBilgileris" adını taşır ve veritabanında "PersonelBilgileri" adlı tabloya karşılık gelir.

        public DbSet<PersonelProjeleri> personelProjeleris { get; set; } //PersonelProjeleri sınıfını temsil eden bir DbSet tanımlar. DbSet, veritabanındaki "PersonelProjeleri" adlı tabloya erişimi sağlar.



    }
}