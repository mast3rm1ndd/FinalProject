using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class tblOgrenciDers
    {
        public int DersID { get; set; }
        public int OgrenciID { get; set; }
        public virtual Ogrenciler Ogrenci { get; set; }
        public virtual tblDersler Ders { get; set; }
    }
}
