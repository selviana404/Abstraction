using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
         Mahasiswa mhs  = new Mahasiswa();
         mhs.Nama       = "Paste Prosmana";
         mhs.Nim        = "19.11.2800";
         mhs.Alamat     = "Jl.tambakboyo no 55";
         mhs.Email      = "paste.prosmana@students.amikom.ac.id";
         mhs.CetakInformasi();
         
         Dosen dosen    = new Dosen();
         dosen.Nama   = "Kamarudin";
         dosen.Nik      = "190302123";
         dosen.NPWP     = "11223344234";
         dosen.Alamat   = "Jl.Wonosari";
         dosen.Email    = "Kamarudin@amikom.ac.id";
         dosen.Nohp     = "0813  12334";
         dosen.CetakInformasi();
        }
    }
}