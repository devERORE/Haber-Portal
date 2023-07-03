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
    [Table("Rol")]
    public class Rol
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Rol Adı")]
        [MinLength(3, ErrorMessage = "3 haneden fazla girin"), MaxLength(100, ErrorMessage = "Lütfen 100 karakterden az girin")]
        public string RolAdi { get; set; }


    }
}
