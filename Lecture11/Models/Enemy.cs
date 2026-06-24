using Lecture11.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture11.Models
{
	internal class Enemy : Sprite, IMovable, IDemegable, IComparable
	{


		public int HP { get; set; }

		public int Damage { get; set; }


		public int CompareTo(object? obj) // todo
		{
			Enemy enemy = (Enemy)obj;
			return Damage.CompareTo(enemy.Damage);
			//return Damage.CompareTo(obj);
		}

		public void Move(int x, int y)
		{
			Console.WriteLine("Enemy mooves on x and y");
		}


		public void OnCollision(Player player)
		{
			if(X == player.X && Y == player.Y)
			{
				if(HP > player.HP)
				{

					player.HP -= Damage;
				}
				else
				{

					HP =0;
				}

			}
			
		}

	
	}
}


//როგორია  
//რა შეუძლია 




//  IComparable
//	IEnumerable
//	IDisposable