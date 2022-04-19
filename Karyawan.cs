using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4355
{
    class Karyawan
    {
        public int NIK { get; set; }
        public string Nama { get; set; }
        public int Gaji { get; set; }
        public int NaikGaji { get; set; }

        public Karyawan(int nik, string nama, int gaji)
        {
            this.NIK = nik;
            this.Nama = nama;

            if (gaji < 0)
            {
                this.Gaji = 0;
                NaikGaji = Convert.ToInt32((Gaji * 1.1));
            }
            else
            {
                this.Gaji = gaji;
                NaikGaji = Convert.ToInt32((Gaji * 1.1));
            }

        }

    }
}
