using System;
using System.Collections.Generic;
using System.Text;


//ToString
//GetHashCode
//Equals


namespace Lecture9
{
	internal class ElectroProdct 
	{
		public string Category { get; set; }


		private string _model;
		public string Model {
			get 
			{ 
				return _model;
			}  
			set 
			{
				if(string.IsNullOrWhiteSpace(value))
				{
					Console.WriteLine("Model can not be empty");
				}

				_model = value;


			}
		
		
		}

		private decimal _price;

		public decimal Price
		{
			get { return _price; }
			set 
			{ 
			   if(value < 0)
				{
					Console.WriteLine("Price can not be negative");
					return;


				}

				_price = value;

			}
		}


		private int _year;

		public int Year
		{
			get { return _year; }
			set 
			{
				if ( value > DateTime.Now.Year || value < DateTime.Now.Year-100) 
				{
					Console.WriteLine("Year can not be negative");
					return;
				}

				_year = value;
			}
		}


		public string Color { get; set; }



		public string Print()
		{
			return $"Model: {Model}, Price: {Price}, Year: {Year}, Color: {Color}, Category: {Category}";
		}

		public override string? ToString()
		{
			return $"Model: {Model}, Price: {Price}, Year: {Year}, Color: {Color}, Category: {Category}";
		}
	}


	//Laptop,Dell XPS 13,2023,1200,Silver
}
