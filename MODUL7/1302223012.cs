using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODUL7
{
    internal class _1302223012
    {
 
            public void ReadJSON()
            {
                string jsonData = File.ReadAllText(@"D:\SEMESTER 4\modul7_kelompok_2\MODUL7\jurnal7_1_1302223012.json");
                Mahasiswa mahasiswa = JsonConvert.DeserializeObject<Mahasiswa>(jsonData);

                Console.WriteLine($"{mahasiswa.firstname} {mahasiswa.lastname} {mahasiswa.gender} {mahasiswa.age} {mahasiswa.address.streetAddress} Kota {mahasiswa.address.city} Wilayah {mahasiswa.address.state}");

                foreach (var course in mahasiswa.courses)
                {
                    Console.WriteLine($"Code: {course.code}, {course.name}");
                }
            }



            public class Mahasiswa
            {
                public String firstname { get; set; }
                public String lastname { get; set; }
                public String gender { get; set; }
                public int age { get; set; }
                public Address address { get; set; }
                public List<Courses> courses { get; set; }


            }



            public class Address
            {
                public string streetAddress { get; set; }
                public string city { get; set; }
                public string state { get; set; }
            }

            public class Courses
            {
                public string code { get; set; }
                public string name { get; set; }
            }


        }
    }

