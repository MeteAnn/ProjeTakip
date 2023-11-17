using ProjeTakip.Models.Personel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjeTakip.Models.ProjeTakip
{
    public class PersonelProjeleri
    {
        public PersonelProjeleri()
        {

            this.PersonelBilgileris = new HashSet<PersonelBilgileri>();


        }//Bu yapıcı metodu kullanmak, sınıfın nesnesini oluştururken ilgili koleksiyonun hemen başlamasını sağlar ve bu koleksiyona erişimi daha güvenli hale getirir. Bu özellikle koleksiyonun null olma ihtimali olabileceği durumlarda önemlidir.


        [Key]
        public int PersonelProjeıd { get; set; }

        [DisplayName("PROJE BAŞLIĞI")]
        [StringLength(150,ErrorMessage ="Maximum uzunluk 150 karakterden fazla olamaz")]

        public string ProjeBaslik { get; set; }

        public string ProjeAciklama { get; set; }

        public DateTime OlusturmaTarihi { get; set; }

        [DisplayName("ONCELİK DURUMU")]
        [StringLength(25, ErrorMessage = "Maximum uzunluk 25 karakterden fazla olamaz")]
        public string OncelikDurumu { get; set; }

        public string TamamlanmaOrani { get; set; }

        public DateTime? TamamlamaTarihi { get; set; }

        public bool TamamlanmaDurumu { get; set; } //Evet/Hayır cinsinden olduğu için bool tuttuk


        public virtual ICollection<PersonelBilgileri> PersonelBilgileris { get; set; } //Yani bize proje takip projesindeki modeller içerisindeki personel klasörünü çağır diyoruz. 


    }
}