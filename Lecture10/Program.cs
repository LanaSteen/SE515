using Lecture10.Enums;
using Lecture10.Models;

namespace Lecture10
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//string path = "C:\\Users\\l4nst\\Desktop\\SE515\\Lecture10\\CarsData.txt";
			//string path = @"../../../Data/CarsData.txt";

			//string[] lines = File.ReadAllLines(path);  // 10
			//Car[] cars = new Car[lines.Length];



			//for (int i = 0; i < lines.Length; i++)
			//{
			//	string[] parts = lines[i].Split(',');
			//	Car car = new Car();
			//	car.Maker = parts[0];
			//	car.Model = parts[1];
			//	car.Year = int.Parse(parts[2]);
			//	car.Price = decimal.Parse(parts[3]);
			//	car.Color = (Color)Enum.Parse(typeof(Color), parts[4]);


			//	cars[i] = car;
			//}



			//foreach (var item in cars)
			//{
			//	Console.WriteLine(item);
			//}


			//Car c3 = new Car("Toyota", "Corolla", 2022, 25000, Color.Black);  //   1232154654
			//Car c1 = new Car("Toyota", "Corolla", 2022, 25000, Color.White);  //   1232154654
			//Car c2 = new Car("Toyota", "Corolla", 2022, 25000, Color.White);


			////Console.WriteLine(c1 == c2);  // reference equality
			//Console.WriteLine(c1.Equals(c2));   // True 



			//foreach (var item in lines)
			//{
			//	Console.WriteLine(item);

			//	string[] parts = item.Split(',');


			//}



			//Car car = new Car("Toyota", "Corolla", 2022, 25000, Color.White);






			Student student = new Student();
			student.Name = "John";
			student.Age = 20;
			student.GPA = 3.5;

			Teacher teacher = new Teacher();
			teacher.Name = "Jane";
			teacher.Age = 20;
			teacher.Salary = 5000;


			teacher.ShowInfo();




			//Techincs te = new Techincs(); // error 

			Car car = new Car();

		}
	}
}
//Toyota, Corolla,2022,25000, White