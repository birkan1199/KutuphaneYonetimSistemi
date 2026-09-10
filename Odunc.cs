using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimSistemi
{
    internal class Odunc
    {
        public Kitap Kitap { get; set; }
        public Uye Uye { get; set; }

        public DateTime AlisTarihi { get; set; }
        public DateTime SonTeslimTarihi { get; set; }
        public DateTime? TeslimTarihi { get; set; }
    }
}
