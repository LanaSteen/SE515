using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture10.Models
{
	internal abstract class Techincs
	{

		public double Engine { get; set; }

		public abstract void Drive(); // სავალდებულოა  "4 ბორბალი მზრაობს" ;
		public virtual void Start()  // ოფშენალია 
		{
			Console.WriteLine("Starting the techincs.");
		}
		public void Rame()
		{
			Console.WriteLine("ok");
		}
	}
}
