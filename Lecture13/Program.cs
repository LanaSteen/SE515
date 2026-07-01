using Lecture13.Helpers;
using Lecture13.Models;

namespace Lecture13
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] arrNew = [50, 20, 30];

			int num = ArrayHelper.ConvertCustom<int,string>("10");
			Console.WriteLine(num+5);

			string str = ArrayHelper.ConvertCustom<string, int>(10);
			int[] arr = [50,30,15,75];


			int num2 =ArrayHelper.FintElementAnyType<int, string>(arrNew, "50");
			Console.WriteLine(num2);


			int[] arrEmpty = new int[0];

			Student[] students = new Student[5] { new Student("Lalisa", 20), new Student("Jennie", 21), new Student("Jisoo", 21), new Student("Rose", 22), new Student("Jennie", 21) };

			Student newStudent = new Student("Lalisa", 20);







			//Console.WriteLine(ArrayHelper.GetFirstElement1(arr));
			//Console.WriteLine(ArrayHelper.GetFirstElement1(arrEmpty));

			Console.WriteLine(ArrayHelper.GetLastElement1(arr));
			Console.WriteLine(ArrayHelper.CustomContains(arr, 15));  // true
			Console.WriteLine(ArrayHelper.CustomContains(arr, 10));  // false

			Console.WriteLine(ArrayHelper.CustomContains(students, newStudent));



			int[] arr5 = [50, 30, 20];  // [100, 30, 20]
			int[] arr6 = arr5; // [100, 30, 20]

			arr6[0] = 100;


			//int decimal float long bool   - სტრუქტურები
			//სტრინგი Array   ფუნქციები  სხვა ობიექტები    -  კლასები


			Money m1 = new();

			m1.Value = 100;

			m1++;
			m1++;
			m1--;
			Console.WriteLine(m1.Value);

		}

}

	public class Money
	{
		public decimal Value;


		public static Money operator ++(Money m)
		{
			m.Value += 1;
			return m;
		}

		public static Money operator --(Money m)
		{
			m.Value -= 1;
			return m;
		}


		public static Money operator +(Money m, Money m2)
		{
			//Money m3 = new Money();
			//m3.Value = m.Value + m2.Value;

			//return m3;

			m2.Value += m.Value;
			return m2;

		}
		public static Money operator -(Money m1, Money m2)
		{
			//Money m3 = new Money();
			//m3.Value = m.Value + m2.Value;

			//return m3;

			m1.Value -= m2.Value;
			return m1;

		}

		public static bool operator ==(Money m1, Money m2)
		{
			
			return m1.Value == m2.Value ; 

		}
		public static bool operator !=(Money m1, Money m2)
		{

			return m1.Value != m2.Value;

		}


		public static bool operator >(Money m1, Money m2)
		{
			return m1.Value >  m2.Value;
		}
		public static bool operator <(Money m1, Money m2)
		{
			return m1.Value < m2.Value;
		}

		public static bool operator <=(Money m1, Money m2)
		{
			return m1.Value <= m2.Value;
		}
		public static bool operator >=(Money m1, Money m2)
		{
			return m1.Value <= m2.Value;
		}
		public static Money operator %(Money m1, Money m2)
		{
			m1.Value = m1.Value % m2.Value;
			return m1;
		}

	}


	//public class Number 
	//{
	//	public int Value;
	//}


	//public struct NumberStruct 
	//{
	//  public int Value;
	//}
}
