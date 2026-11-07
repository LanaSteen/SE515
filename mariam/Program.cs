namespace mariam
{
	internal class Program
	{
		static void Main(string[] args)
		{


			string path = @"C:\Users\l4nst\Desktop\new515\mariam\data\employees.csv";

			string[] lines = File.ReadAllLines(path);

			List<Employee> employees = new List<Employee>();

			foreach (var item in lines)
			{


				var parts = item.Split(",");

				var employee = new Employee
				{
					Id = int.Parse(parts[0]),
					Name = parts[1],
					WorkingHours = int.Parse(parts[2])
				};

				employees.Add(employee);

			}

			var sallaryInHour = 100;


			foreach (var item in employees)
			{
				Console.WriteLine(item.WorkingHours * sallaryInHour);
			}


		}
	}
}
