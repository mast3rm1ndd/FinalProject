using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class tblDersler
    {
        [Key]
        public int DersID { get; set; }
        public string DersKod { get; set; }
        public string DersAd { get; set; }
        public virtual ICollection<tblOgrenciDers> tblOgrenciDers { get; set; }
    }
}
