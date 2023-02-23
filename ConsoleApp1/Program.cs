using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bulunmasını istediğiniz genleri giriniz:");
            int cocuk = Convert.ToInt32(Console.ReadLine());
            for (int a = 1; ; a++ )
            {

                
                Console.WriteLine("{0}.İterasyon:", a);
                
                string mutasyon;
                Random rnd = new Random();
                int[] anne = new int[4];
                Console.Write("Annenin genleri:");
                for (int i = 0; i < anne.Length; i++)
                {
                    anne[i] = rnd.Next(0, 2);
                    Console.Write(anne[i]);
                }
                Console.WriteLine();
                int[] baba = new int[4];
                Console.Write("Babanın genleri:");
                for (int i = 0; i < baba.Length; i++)
                {
                    baba[i] = rnd.Next(0, 2);
                    Console.Write(baba[i]);
                }
                Console.WriteLine();
                Console.WriteLine("Çaprazlama:{0}{1}{2}{3}", anne[0], anne[1], baba[2], baba[3]);
                int x = rnd.Next(0, 4);
                if (x == 0)
                {
                    if (anne[0] == 0)
                    {
                        anne[0] = 1;
                    }
                    else
                    {
                        anne[0] = 0;
                    }
                }
                if (x == 1)
                {
                    if (anne[1] == 0)
                    {
                        anne[1] = 1;
                    }
                    else
                    {
                        anne[1] = 0;
                    }
                }
                if (x == 2)
                {
                    if (baba[2] == 0)
                    {
                        baba[2] = 1;
                    }
                    else
                    {
                        baba[2] = 0;
                    }
                }
                if (x == 3)
                {
                    if (baba[3] == 0)
                    {
                        baba[3] = 1;
                    }
                    else
                    {
                        baba[3] = 0;
                    }
                }
                Console.WriteLine("Mutasyon:{0}{1}{2}{3}", anne[0], anne[1], baba[2], baba[3]);
                string anne0 = Convert.ToString(anne[0]);
                string anne1 = Convert.ToString(anne[1]);
                string baba2 = Convert.ToString(baba[2]);
                string baba3 = Convert.ToString(baba[3]);
                mutasyon = anne0 + anne1 + baba2 + baba3;
                int mutasyon2 = Convert.ToInt32(mutasyon);
                if (mutasyon2 == cocuk)
                {
                    Console.WriteLine("İstenen gen bulundu.");
                    break;
                 
                }
                else
                { Console.WriteLine("İstenen gen bulunamadı.");
                   
                }
                

            }
            

                


            
           
        }
    }
}
