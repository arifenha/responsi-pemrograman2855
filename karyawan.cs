using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2855
{
    class Karyawan
    {
        public string NIK { get; set; }
        public string Nama { get; set; }
        public int gajibulanan { get; set; }

        public Karyawan(string nik, string nama, int gajibulanan)
        {
            this.NIK = nik;
            this.Nama = nama;
            if (gajibulanan < 0)
            {
                this.gajibulanan = 0;
            }
            else
            {
                this.gajibulanan = gajibulanan;
            }
        }


    }
}