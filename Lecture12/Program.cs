using Lecture12.Helpers;
using Lecture12.Models;

namespace Lecture12
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//			დავალება 1
			//შექმენით IOutput2 ინტერფეისი.ის უნდა შეიცავდეს ორ მეთოდს:
			//void ShowEven() -აჩვენებს ლუწ მნიშვნელობებს მონაცემთა კონტეინერიდან;
			//			void ShowOdd() -აჩვენებს კენტ მნიშვნელობებს მონაცემთა კონტეინერიდან;
			//			კლასმა “Array”-მ, იმპლემენტირება უნდა გაუკეთოს IOutput2 ინტერფეისს.
			//ShowEven მეთოდი ნებისმიერი მასივიდან ლუწ მნიშვნელობებს აჩვენებს.
			//ShowOdd მეთოდი ნებისმერი მასივიდან კენტ მნიშვნელობებს აჩვენებს.
			//დაწერეთ კოდი მიღებული ფუნქციონალის ტესტირებისათვის.


			int[] arr = [50,60,0,0, 30,11,77,30,30];
			string[] arrStr = ["dsdfdsfg", "DSdd"];
			Student[] students = new Student[] {new Student( 50, "John"), new Student( 60, "James") };

			//ArrayHelper.PrintArray(arr);



			ArrayHelper.PrintArray<int>(arr);
			ArrayHelper.PrintArray<string>(arrStr);

			ArrayHelper.PrintArray<int>(arr);
			ArrayHelper.PrintArray(arrStr);
			ArrayHelper.PrintArray(students); // 


			//Array1 arr1 = new Array1(arr);

			//arr1.ShowEven();
			//arr1.ShowOdd();

			//Console.WriteLine(arr1.EqualToValue(30));
			//Console.WriteLine(arr1.EqualToValue(0));
			//Console.WriteLine(arr1.CountDistinct());

			//Array1 arr2 = new Array1([ 50, 60, 30 ]);
			//Array1 arr3 = new Array1(new int[] { 50, 60, 30 });


			//2 | P a g e
			//დავალება 2
			//შექმენით ICalc2 ინტერფეისი.ის უნდა შეიცავდეს ორ მეთოდს:
			//int CountDistinct() -აბრუნებს კონტეინერში არსებული უნიკალური მნიშვნელობების რაოდენობას.
			//int EqualToValue(int valueToCompare) -აბრუნებს მნიშვნელობების რაოდენეობას, რომელიც ტოლია valueToCompare-ისა.
			//კლასმა “Array”-მ, იმპლემენტირება უნდა გაუკეთოს ICalc2 ინტერფეისს.
			//CountDistinct მეთოდი აბრუნებს მასივში არსებული უნიკალური მნიშვნელობების რაოდენობას.
			//EqualToValue მეთოდი აბრუნებს მასივში არსებული მნიშვნელობების რაოდენობებს, რომელიც ტოლია ‘valueToCompare’-ისა.
			//დაწერეთ კოდი მიღებული ფუნქციონალის ტესტირებისათვის.




			ArrayHelper.PrintArray(students);



		}
	}
}



//ToString - object  ის მეთდიაა და ნებისმიერ კლასს შუძლია ოვერრაიდი გაუკეთოს
//static - კლასიდან გამოიძახება - ობიექტის შექმნა არ სჭირდება
//override - გადაფარვა  - შეგვიძლია გავაკეთოთ მშობლის მეთოდი ვირტუალია (ოფშენალია) ან აბსტრაქტული (აუცილებელია)
//overload - გადატვირთვა - როდეასც მეთოდს ერთი სახელი აქვს და პარამეტრები განსხვავებული
//generic -  მეთოდი როელიც მუშაობს ზოგადი ტიპზე. მეთოდის იმპლემენტაციის დროს არ ვუთითებთ რა ტიპია და გამოყენების დროს ვუთითებთ



