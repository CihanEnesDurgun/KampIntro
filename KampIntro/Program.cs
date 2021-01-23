using System;

namespace KampIntro
{
	class Program
	{
		static void Main(string[] args)
		{
			//type safety = tip güvenliği
			// do not repeat yourself = kendini tekrarlama
			//alias = değer tutucu
			
			string kategoriEtiketi = "Kategori";
			 //stirng = yazıları tutar
			int ogrenciSayisi = 32000;
		     //int = tam sayıları tutar
			double faizOrani = 1.45;
			//double = ondalıklı sayıları tutar
			bool sistemeGirisYapmisMi = true;
			double dolarDun = 7.35;
			double dolarBugun = 7.45;

			if (dolarDun > dolarBugun)
			{
				Console.WriteLine("Azalış Butonu");
			}
			else if (dolarBugun < dolarDun)
			{
				Console.WriteLine("Artış Butonu");
			}
			else
			{
				Console.WriteLine("Değişmedi Butonu");
			}




			if (sistemeGirisYapmisMi == true)
			{
				Console.WriteLine("Kullanıcı Ayarları Butonu");
			}
			else
			{
				Console.WriteLine("Giriş Yap Butonu");
			}
			Console.WriteLine(kategoriEtiketi);



		}
	}
}
