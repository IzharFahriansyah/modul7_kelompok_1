using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MODUL7
{
    public class DataMahasiswa1302220080
    {
        public class Mahasiswa1302220080
        {
            public Name nama { get; set; }

            public int nim { get; set; }
            public string fakultas { get; set; }

        }

        public class Name
        {
            public string depan { get; set; }
            public string belakang { get; set; }
        }

        public vooid ReadJSON()
        {
            string filePath = "C:\\Konstruksi Perangkat Lunak\\modul7_kelompok_1\\MODUL7\\jurnal7_1_1302220080";
            string jsonString = File.ReadAllText(filePath);

            Mahasiswa1302220080 mahasiswa = JsonSerializer.Deserialize<Mahasiswa1302220080>(jsonString);
            Console.WriteLine($"Nama : {mahasiswa.nama.depan} {mahasiswa.nama.belakang}");
            Console.WriteLine($"NIM : {mahasiswa.nim}");
            Console.WriteLine($"Fakultas : {mahasiswa.fakultas}");
            Console.WriteLine();
        }
    }
}