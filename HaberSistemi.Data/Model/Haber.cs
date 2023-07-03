using Bogus.DataSets;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberSistemi.Data.Model
{
    [Table("Haber")]
    public class Haber
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Haber Baslik")]
        [MaxLength(100, ErrorMessage = "Lütfen 100 karakterden az girin")]
        public String Baslik { get; set; }
        [Display(Name = "Kısa Aciklama")]
        public String KısaAciklama { get; set; }
        [Display(Name = "Aciklama")]
        public int Okuma { get; set; }
        public String Aciklama { get; set; }
        [Display(Name = "Aktif")]
        public bool Aktifmi { get; set; }
        [Display(Name = "EklenmeTarihi")]
        public DateTime EklemeTarihi { get; set; }

        public virtual Kullanıcı Kullanıcı { get; set; }
        [Display(Name = "Resim")]

        [MaxLength(200, ErrorMessage = "Lütfen 200 karakterden az girin")]
        public string Resim { get; set; }
        public virtual ICollection<Resim> Resims { get; set; }
        public virtual Kategori Kategori { get; set; }





    }
}
