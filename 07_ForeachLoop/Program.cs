using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region foreach_kullanım
            //int[] numbers = { 45, 22, 365, 88, 99 };

            //foreach (int i in numbers)
            //{
            //    if(i % 2 == 0) { 
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region Örnek_Sınav_uygulaması
            Console.Write("****SINAV UYGULAMASI");
            Console.WriteLine();

            //Öğrenci sayısını alma
            Console.Write("Sınıfınızda kaç öğrenci var: ");
            int studentCount=int.Parse(Console.ReadLine());
            Console.WriteLine("-------------");

            //Öğrenci isimleri
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for(int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her öğrenci için 3 sınav notu girişi
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value=double.Parse(Console.ReadLine());
                    totalExamResult += value;//notları topla
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;

               

            }
            //Sınav ortalamaları
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

                //Öğrencileri ortalaması, geçip kalma durumu
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci geçti");
                }else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci kaldı");
                }
            }



            #endregion

            Console.Read();
        }
    }
}
