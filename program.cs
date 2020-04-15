using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2855
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan = new Karyawan(190302123, "iis", 5000000);
            Karyawan karyawan2 = new Karyawan(190302124, "bambang", 4000000);


            Console.WriteLine("NIK \t Nama \t\t Gaji");
            Console.WriteLine("-------------------------------");
            karyawan.showKaryawan();
            karyawan2.showKaryawan();

            Console.WriteLine(" Alhamdulillah kenaikan gaji !!");

            Console.WriteLine("NIK \t Nama \t\t Gaji");
            Console.WriteLine("-------------------------------");
            karyawan.naikGaji();
            karyawan2.naikGaji();

            Console.ReadKey();
        }
    }

    class Karyawan
    {
        public int nik { get; set; }
        public string nama { get; set; }
        public int gajibulanan { get; set; }

        public Karyawan(int nik, string nama, int gaji)
        {
            this.nik = nik;
            this.nama = nama;

            if (gaji < 0)
            {
                this.gajibulanan = 0;
            }
            else
            {
                this.gajibulanan = gaji;
            }
        }

        public void showKaryawan()
        {
            Console.WriteLine("{0} \t {1} \t {2}", nik, nama, gajibulanan);
        }

        public void naikGaji()
        {
            double tmp = 0;
            tmp = 0.1 * gajibulanan;
            gajibulanan += Convert.ToInt32(tmp);
            Console.WriteLine("{0} \t {1} \t {2}", nik, nama, gajibulanan);
        }
    }
}