using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppEntriPemasukanPengeluaran
{
    public class Nasabah
    {
        public string NomorRekening { get; set; }
        public string NamaNasabah { get; set; }
        public DateTime TanggalTransaksi { get; set; }
        public int Nominal { get; set; }
        public int JenisTransaksi { get; set; }
    }
}
