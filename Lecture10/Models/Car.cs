using Lecture10.Enums;



namespace Lecture10.Models
{
	//internal მხოლოდ მოცეულ პროექტსში ჩანს
	//public ყველაგნ ჩანს


	//object 
	//ToString
	//GetHashCode
	//Equals


	internal class Car   : Techincs
	{

		public override void Drive()
		{
			Console.WriteLine("Driving a car.");
		}

		public Car()
		{
		}

		public Car(string maker, string model, int year, decimal price, Color color)
		{
			Maker = maker;
			Model = model;
			Year = year;
			Price = price;
			Color = color;
		}


		private string _maker;

		public string Maker
		{
			get { return _maker; }
			set 
			{
			   if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) 
				{
					Console.WriteLine("Invalid maker.");
					return;
				}

			   _maker = value;
			}
		}


		private string _model;

		public string Model
		{
			get { return _model; }
			set 
			{

				if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
				{
					Console.WriteLine("Invalid maker.");
					return;
				}

				_model = value; 
			
			}
		}


		private int _year;

		public int Year
		{
			get { return _year; }
			set 
			{ 
			  if(value <DateTime.Now.Year -100|| value > DateTime.Now.Year)
				{
					Console.WriteLine("Invalid year.");
					return;
				}

			  _year = value;
			
			}
		}



		private decimal _price;

	

		public decimal Price
		{
			get { return _price; }
			set { _price = value; }
		}


		public Color Color { get; set; }




		public bool IsNew()
		{
			return Year == DateTime.Now.Year;
		}
		public bool IsExpencive()
		{
			return Price > 100000;
		}


		//[], model

		public Car FindcaarByModel(Car[] cars, string model)
		{
			foreach (var item in cars)
			{
				if(item.Model == model)
				{
					return item;
				}
			}

			//return new Car();
			return null;

		}


		//public void Print()
		//{
		//	Console.WriteLine($"Maker: {Maker}, Model: {Model}, Year: {Year}, Price: {Price}, Color: {Color}");
		//}

		public override string? ToString()  // გადაფარვა 
		{
			return $"Maker: {Maker}, Model: {Model}, Year: {Year}, Price: {Price}, Color: {Color}";
		}

		public override bool Equals(object? other)
		{
			if (other is Car car)
			{
				return Maker == car.Maker && Model == car.Model && Year == car.Year && Price == car.Price && Color == car.Color;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Maker, Model, Year, Price, Color);  // 1232154654
		}
	}







}

//override  გადაფარვა  მშობლის მეთოდის








//Toyota, Corolla,2022,25000, White   