using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;

            //number = 4.85;

            //Console.WriteLine(number);

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---Elma Birim Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("---Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("---Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("---Patates Birim Fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine("---Domates Birim Fiyatı: " + tomatoPrice + "  TL");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice);

            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice);

            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice);

            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice);

            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutarı: " + shoppingTotalPrice + " TL");


            #endregion

            #region Char Değişkenler

            //" yerine ' kullanılır

            //char symbol;

            //symbol = 'f';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişi
            //Console.WriteLine("*** Yolcu Bilgileri ***");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("TC No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("-------------------");
            //Console.WriteLine("Yolcu: " + passengerName + " " + passengerSurname + " " + passengerDistrict + " " + passengerCity + " " + passengerAge + " " + passengerIdentityNumber);
            #endregion

            #region klavyeden tam sayı girişi

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Ayakkabı sayısı: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Bilgisayar sayısı: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Sandalye sayısı: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Tv sayısı: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.Write("Toplam ödenmesi gereken: " + totalPrice);

            #endregion

            #region Klavyeden ondalıklı sayı
            //double exam1, exam2, exam3, result;

            //Console.Write("1. sınav notu: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("2. sınav notu: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("3. sınav notu: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav ortalaması " + result);
            #endregion

            #region Klavyeden karakter girişi
            //char gender;
            //Console.Write("cinsiyeti giriniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("seçtiğiniz cinsiyet: " + gender);
            #endregion

            Console.Read();
        }
    }
}
