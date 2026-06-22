using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture9
{
	public class Product
	{

		private decimal _price;
		public Product()
		{
		}

		public Product(int id, string name, bool nuts, string image, bool vegeterian, int spiciness, string category, decimal price)
		{
			Id = id;
			Name = name;
			Nuts = nuts;
			Image = image;
			Vegeterian = vegeterian;
			Spiciness = spiciness;
			Category = category;
			Price = price;
		}

		public Product(string name, bool nuts, string category)
		{
			Name = name;
			Nuts = nuts;
			Category = category;
		}

		//public Product() { }

		//public Product(string name, decimal price)
		//{
		//	Name = name;
		//	Price = price;
		//}

		public Product(string name, decimal price, bool nuts)
		{
			Name = name;
			Price = price;
			Nuts = nuts;
		}


		//კონსტრუქტორი, მშენებელი


		//public int Id;       ////field
		//public string Name;
		//public decimal Price;  // -50
		//public bool Nuts;
		//public string Image;
		//public bool Vegeterian;
		//public int Spiciness;
		//public string Category;


		// prop   შორთქათი

		public int Id { get; set; }       ////property
		public string Name { get; set; }
		//public decimal Price { get; set; }  // -50
		public bool Nuts { get; set; }
		public string Image { get; set; }  // "     "
		public bool Vegeterian { get; set; }
		public int Spiciness { get; set; }
		public string Category { get; set; }

		public decimal Price
		{
			get { return _price; }
			set
			{
				if (value < 0)
				{
					Console.WriteLine("invalid price");
					return;

				}
				_price = value;




			}  // -50
		}



		public void Print()
		{

			Console.WriteLine($"Name: {Name}, Price: {Price}, Nuts: {Nuts}, Image: {Image}, Vegeterian: {Vegeterian}, Spiciness: {Spiciness}, Category: {Category}");
		}



		public bool IsNutAndVegeterian()
		{

			return Nuts && Vegeterian; // true / false

		}

		/// full prpoerty

		//propfull

		public string Model;  // field
		public int MyProperty1 { get; set; }

		private int myVar;

		public int MyProperty // property
		{
			get { return myVar; }
			set { myVar = value; }
		}

		


	}

}
