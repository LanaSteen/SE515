using Lecture11.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture11.Models
{
	internal class Player : Sprite, IMovable, IDemegable
	{

		//public int HP { get; set; }

		public int Score { get; set; }
		public int HP { get; set; }

		public Gun[] Inventory { get; set; }


		public void Move(int x, int y)
		{
			Console.WriteLine("player moves");
		}


	}
}
