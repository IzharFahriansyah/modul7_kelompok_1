using System;
using System.Text.Json;

public class DataMahasiswa1302220056
{
		public string firstName { set; get; }
		public string lastName { set; get; }
		public string gender { set; get; }
		public int age { set; get; }
		public Address address { set; get; }
		public Course[] courses { set; get; }

	public class Address
	{
		public string streetAddress { set; get; }
		public string city { set; get; }
		public string state { set; get; }
	}

	public class Course
	{
		public string code { set; get; }
		public string name { set; get; }
	}

	public void ReadJSON()
	{
		string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
		string jsonString = File.ReadAllText(path + "/jurnal7_1_1302220056.json");

		DataMahasiswa1302220056 mhs = JsonSerializer.Deserialize<DataMahasiswa1302220056>(jsonString);
		Console.WriteLine($"Nama : {mhs.firstName}{mhs.lastName}");
		Console.WriteLine($"Jenis Kelamin : {mhs.gender}");
		Console.WriteLine($"Usia : {mhs.age}");
		Console.WriteLine($"Alamat : {mhs.address.streetAddress}, {mhs.address.city}, {mhs.address.state}");
		foreach (Course course in mhs.courses)
		{
			Console.WriteLine($"Code : {course.code}, Name : {course.name}");
		}
	}
}

		




	

