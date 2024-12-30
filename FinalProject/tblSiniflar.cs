using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class tblSiniflar
    {
        [Key]
        public int SinifID { get; set; }
        public string SinifAd { get; set; }
        public int Kontenjan { get; set; }
        public virtual ICollection<Ogrenciler> Ogrenciler { get; set; }
    }
}
