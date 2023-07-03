﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HaberSistemi.Data.Model
{
    [Table("Kategori")]
    public class Kategori
    {
        public int ID;

        [Key] 
        public int Id { get; set; }
        [MinLength(2,ErrorMessage ="{0} karakterden az olamaz."), MaxLength(150,ErrorMessage ="150 karakterden fazla olamaz")]
        public string KategoriAdi { get; set; }

        public int ParentID { get; set; }
        [MinLength(2, ErrorMessage = "{0} karakterden az olamaz."), MaxLength(150, ErrorMessage = "150 karakterden fazla olamaz")]
        public string URL { get; set; }

        public bool AktifMi { get; set; }

        public virtual ICollection<Haber> Haber { get; set; }

    }
}
