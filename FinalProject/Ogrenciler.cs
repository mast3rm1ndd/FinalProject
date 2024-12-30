using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Ogrenciler
    {
        [Key]
        public int OgrenciID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Numara { get; set; }
        public int SinifID { get; set; }
        public virtual tblSiniflar Sinif { get; set; }  
        public virtual ICollection<tblOgrenciDers> tblOgrenciDers { get; set; }
    }
}
