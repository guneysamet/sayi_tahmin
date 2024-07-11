using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int sayi1 = r.Next(1, 10);
            int sayi2, sayi3, sayi4;
            sayi2 = 0;
            sayi3 = 0;
            sayi4 = 0;
            int i = 0;

            while (i < 1)
            {
                sayi2 = r.Next(0, 10);
                sayi3 = r.Next(0, 10);
                sayi4 = r.Next(0, 10);
                if (sayi1 != sayi2 && sayi1 != sayi3 && sayi1 != sayi4 && sayi2 != sayi3 && sayi2 != sayi4 && sayi3 != sayi4)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(sayi1 + "" + sayi2 + "" + sayi3 + "" + sayi4);
                    Console.ResetColor();
                    i++;
                }
            }
            string sayi_1 = sayi1.ToString();
            string sayi_2 = sayi2.ToString();
            string sayi_3 = sayi3.ToString();
            string sayi_4 = sayi4.ToString();
            int a = 0;
            while (a <= 4)
            {
                Console.Write("sayı : ");
                string sayi = Console.ReadLine();
                while (sayi.Length > 4 || sayi.Length < 4)
                {
                    Console.WriteLine("4 haneli olmalı!\n");
                    Console.Write("sayı : ");
                    sayi = Console.ReadLine();
                    while (sayi.Substring(0, 1) == sayi.Substring(1, 1) || sayi.Substring(2, 1) == sayi.Substring(3, 1) || sayi.Substring(1, 1) == sayi.Substring(3, 1) || sayi.Substring(0, 1) == sayi.Substring(3, 1) || sayi.Substring(1, 1) == sayi.Substring(2, 1))
                    {
                        Console.WriteLine("rakamları birbirinden farklı olmalı!\n");
                        Console.Write("sayı : ");
                        sayi = Console.ReadLine();
                    }
                }
                while (sayi.Substring(0, 1) == sayi.Substring(1, 1) || sayi.Substring(2, 1) == sayi.Substring(3, 1) || sayi.Substring(1, 1) == sayi.Substring(3, 1) || sayi.Substring(0, 1) == sayi.Substring(3, 1) || sayi.Substring(1, 1) == sayi.Substring(2, 1))
                {
                    Console.WriteLine("rakamları birbirinden farklı olmalı!\n");
                    Console.Write("sayı : ");
                    sayi = Console.ReadLine();
                    while (sayi.Length > 4 || sayi.Length < 4)
                    {
                        Console.WriteLine("4 haneli olmalı!\n");
                        Console.Write("sayı : ");
                        sayi = Console.ReadLine();
                    }
                }
                string bir, iki, uc, dort;
                bir = sayi.Substring(0, 1);
                iki = sayi.Substring(1, 1);
                uc = sayi.Substring(2, 1);
                dort = sayi.Substring(3, 1);
                int b = 0;
                if (bir == sayi_1 || bir == sayi_2 || bir == sayi_3 || bir == sayi_4)
                {
                    if (bir == sayi_1)
                    {
                        a++;
                    }
                    else
                    {
                        b--;
                    }
                }
                if (iki == sayi_1 || iki == sayi_2 || iki == sayi_3 || iki == sayi_4)
                {
                    if (iki == sayi_2)
                    {
                        a++;
                    }
                    else
                    {
                        b--;
                    }
                }
                if (uc == sayi_1 || uc == sayi_2 || uc == sayi_3 || uc == sayi_4)
                {
                    if (uc == sayi_3)
                    {
                        a++;
                    }
                    else
                    {
                        b--;
                    }
                }
                if (dort == sayi_1 || dort == sayi_2 || dort == sayi_3 || dort == sayi_4)
                {
                    if (dort == sayi_4)
                    {
                        a++;
                    }
                    else
                    {
                        b--;
                    }
                }
                if (a != 0)
                {
                    Console.WriteLine("+" + a);
                }
                if (b != 0)
                {
                    Console.WriteLine(b);
                }
                if (a == 4)
                {
                    Console.WriteLine("kazandın!");
                    break;
                }
                a = 0; b = 0;
            }
            Console.ReadLine();
        }
    }
}
