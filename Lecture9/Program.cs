namespace Lecture9
{
	internal class Program
	{
		static void Main(string[] args)
		{
		


			int x;


			Product product2 = new();
			Product product = new("milk", -10, Convert.ToBoolean(0));

			product.Price = 50;
			//product.Price = 100;

			Console.WriteLine(product.Price);
			product.Print();

			Console.WriteLine(product.IsNutAndVegeterian());






			ElectroProdct elProduct = new ElectroProdct();

			//Console.WriteLine(elProduct);



			//string path = "C:\\Users\\l4nst\\Desktop\\SE515\\Lecture9\\products.txt";

			string path2 = @"../../../products.txt";



			string[] lines = File.ReadAllLines(path2);  /// მთლიან ფაილს კითხავს სტრინგების მასივში   -  stream reader 

			//["Laptop,Dell XPS 13,2023,1200,Silver", "Smartphone,iPhone 15,2024,999,Black"]

			//["Laptop", "Dell XPS 13", "2023"]

			ElectroProdct[] eleprods = new ElectroProdct[lines.Length];

			int index = 0;

			foreach (string line in lines)
			{

				//Console.WriteLine(line);
				string[] parts = line.Split(',');

				ElectroProdct electroProdct = new ElectroProdct();
				electroProdct.Category = parts[0];
				electroProdct.Model = parts[1];
				electroProdct.Year = int.Parse(parts[2]);
				electroProdct.Price = decimal.Parse(parts[3]);
				electroProdct.Color = parts[4];


				eleprods[index] = electroProdct;
				index++;


			}


			foreach (var item in eleprods)
			{
				Console.WriteLine(item);
			}
		}


		//int x;

	
	}

	//oop -- object oriented programming

	//1. ინკაფსულაცია
	//2. მემკვიდრეობა
	//3. პოლიმორფიზმი



	//internal class Product


	//Laptop,Dell XPS 13,2023,1200,Silver

}
