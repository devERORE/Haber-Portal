using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberSistemi.Data.Model
{
    [Table("Kullanici")]
    public class Kullanıcı
    {

        [Key]
        public int ID { get; set; }
        [MaxLength(100, ErrorMessage = "Lütfen 100 karakterden az girin")]
        [Display(Name = "Ad Soyad")]

        public String AdSoyad { get; set; }
        [Display(Name = "E-mail")]
        [Required]
        [RegularExpression("^[0-9]{10}$|(^+{2}s+[0-9]{ 2}[0-9]{ 8}$)|(^[0-9]{ 3}-[0-9]{ 4}-[0-9]{ 4}$", ErrorMessage = "Geçerli bir mail adresi giriniz")]
        public String Email { get; set; }
        [Display(Name = "Sifre")]
        [DataType(DataType.Password)]
        [Required]
        [MaxLength(16, ErrorMessage = "Lütfen 16 karakterden fazla girmeyiniz")]

        public String Sifre { get; set; }


        public DateTime KayitTarihi { get; set; }
        [Display(Name = "Aktif")]

        public bool Aktif { get; set; }
        public virtual Rol Rol { get; set; }



    }
}
