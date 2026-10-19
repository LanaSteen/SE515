using HotelApp.Data;
using HotelApp.Models.Entities;

namespace HotelApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var context = new HotelDbContex();



			var hotels = context.Hotels.ToList();
			foreach (var item in hotels)
			{
				Console.Write($"{item.Id}: {item.Name} - {item.Location}");
				Console.Write(" Rooms :  ");

				var rooms = context.Rooms.Where(r => r.HotelId == item.Id).ToList();
				foreach (var room in rooms)
				{
					Console.Write($" , {room.RoomNumber}");
				}


				Console.WriteLine();

			}




			//var hotel = new Hotel {
			//	Name = "Hotel California",
			//	Location = "Beverly Hills"
			//};

			//context.Hotels.Add(hotel);
			//context.SaveChanges();



			//int id = context.Hotels.First().Id;

			//var room = new Room {
			//	RoomNumber = 101,
			//	HotelId = id
			//};

			//context.Rooms.Add(room);
			//context.SaveChanges(); /// aucilebelia


		}
	}
}
