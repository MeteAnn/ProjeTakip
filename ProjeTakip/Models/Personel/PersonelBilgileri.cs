using ProjeTakip.Models.ProjeTakip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjeTakip.Models.Personel
{
    public class PersonelBilgileri
    {

        public PersonelBilgileri() 
        { 
        
            
            this.PersonelProjeleris = new HashSet<PersonelProjeleri>();
            
        
        }

        [Key] //Bu anahtar demektir. Bunu kullanmamızın sebebi aşağıdaki tablonun bu ıdye ait olmasını belirtmek için...
        public int PersonelBilgileriId { get; set; }


        [DisplayName("E-POSTA")] //Label kısmında yani isimlendirme kısmında gözükecek olan budur. Yani View de kullanıcının gördüğü kısım olduğu için istediğimiz string ifadeyi girebiliriz.
        public string Eposta { get; set; }

        [DisplayName("ŞİFRE")]
        [StringLength(25, ErrorMessage ="Maximum uzunluk 25 karakterden fazla olamaz")] //veritabanında en fazla 25 karakter yer kaplasın demektir ve mesaj gösteririrz kullanıcıya bununla ilgili
        public string Sifre { get; set; }

        [DisplayName("Yetki")]
        [StringLength(15, ErrorMessage = "Maximum uzunluk 15 karakterden fazla olamaz")]
        public string Yetki { get; set; }

        [DisplayName("AD SOYAD")]
        [StringLength(50, ErrorMessage = "Maximum uzunluk 50 karakterden fazla olamaz")]
        public string AdSoyad { get; set; }

        [DisplayName("TC KİMLİK NO")]
        [StringLength(15, ErrorMessage = "Maximum uzunluk 15 karakterden fazla olamaz")]
        public string TCNO { get; set; }

        [DisplayName("DEPARTMANI")]
        [StringLength(25, ErrorMessage = "Maximum uzunluk 25 karakterden fazla olamaz")]
        public string Departman { get; set; }

        [DisplayName("GÖREVİ")]
        [StringLength(25, ErrorMessage = "Maximum uzunluk 25 karakterden fazla olamaz")]
        public string Gorev { get; set; }

        [DisplayName("AÇIKLAMA")]
        public string PozisyonAciklama { get; set; }

        [DisplayName("TELEFON NUMARASI")]
        [StringLength(15, ErrorMessage = "Maximum uzunluk 15 karakterden fazla olamaz")]
        public string TelNo { get; set; }

        [DisplayName("ADRES BİLGİLERİ")]
        public string Adres { get; set; }

        [DisplayName("MEDENİ HAL")]
        [StringLength(25, ErrorMessage = "Maximum uzunluk 25 karakterden fazla olamaz")]
        public string MedeniHal { get; set; }

        [DisplayName("YAKINLIK BİLGİSİ")]
        [StringLength(25, ErrorMessage = "Maximum uzunluk 25 karakterden fazla olamaz")]
        public string YakinBilgisi { get; set; }

        [DisplayName("YAKIN TC NO")]
        [StringLength(25, ErrorMessage = "Maximum uzunluk 25 karakterden fazla olamaz")]
        public string YakinTC { get; set; }

        [DisplayName("YAKIN AD SOYAD")]
        [StringLength(25, ErrorMessage = "Maximum uzunluk 25 karakterden fazla olamaz")]
        public string YakinAdSoyad { get; set; }

        [DisplayName("YAKIN TELEFON")]
        [StringLength(25, ErrorMessage = "Maximum uzunluk 25 karakterden fazla olamaz")]
        public string YakinTel { get; set; }


        [DisplayName("DOĞUM TARİHİ")]
        public DateTime DogumTarihi { get; set; }

        [DisplayName("İŞE GİRİŞ TARİHİ")]

        public DateTime? IseGirisTarihi { get; set; } //Soru İşareti boş olabilir manasına gelir.


        public virtual ICollection<PersonelProjeleri> PersonelProjeleris { get; set; } 

    }
}