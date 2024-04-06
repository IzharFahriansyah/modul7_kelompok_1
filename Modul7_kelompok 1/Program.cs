using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace Modul7_kelompok1
{
    public class DataMahasiswa1302220004
    {
        public string firstName { set; get; }

        public string lastName { set; get; }

        public string gender { set; get; }

        public int age { set; get; }

        public Address address { set; get; }

        public List<Courses> courses { set; get; }

        public class Address
        {
            public string streetAddress { set; get; }

            public string city { set; get; }

            public string state { set; get; }
        }

        public class Courses
        {
            public string code { set; get; }

            public string name { set; get; }
        }

        public void ReadJSON()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string jsonString = File.ReadAllText(path + "/jurnal7_1_1302220093.json");

            DataMahasiswa1302220004 mhs = JsonSerializer.Deserialize<DataMahasiswa1302220004>(jsonString);
            Console.WriteLine($"Nama : {mhs.firstName} {mhs.lastName}");
            Console.WriteLine($"Jenis Kelamin : {mhs.gender}");
            Console.WriteLine($"Usia : {mhs.age}");
            Console.WriteLine($"Alamat : {mhs.address.streetAddress}, {mhs.address.city}, {mhs.address.state}");
            foreach (Courses course in courses)
            {
                Console.WriteLine($"Code: {course.code}, Name: {course.name}");
            }
        }
    }
}