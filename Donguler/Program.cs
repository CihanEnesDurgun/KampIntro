using System;

namespace Donguler
{
	class Program
	{
		static void Main(string[] args)
		{

			string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
			string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";

			//array = dizi

			string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlangıç İçin Temel Kurs" , "Java","Python"};

			for (int i = 0; i <kurslar.Length; i++)
				//burda son kısma i++ yazarak veya i=+x yazarak verdiğimiz değer doğrultusunda da sıralayabilirdik.
			{
				Console.WriteLine(kurslar[i]);
				//kursların i'ninci elamını yaz*

			}

			Console.WriteLine("For Bitti");


	
			foreach (string kurs in kurslar)
				//kursları dolaş demek
			{
				Console.WriteLine(kurs);
			}


			Console.WriteLine("Sayfa Sonu - footer");
		}
	}
}
