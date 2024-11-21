using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UKOMSM2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string males = "\n======================================================\nBunuh musuhmu sebelum dia membunuhmu!\ninput 'X' untuk melancarkan serangan\n======================================================\n";

            //Pembukaan 
            Console.WriteLine("Selamat datang Pemburu! Perkenalkan namamu! :");
            string a = Console.ReadLine();
            Console.WriteLine($"=====================\nSelamat datang di kerajaan Seykond, Pemburu {a}!\n\nPilih senjatamu untuk memusnahkan musuh! :\n1. Sword\t2.Bow/Arrow\t3. Magic");
            string b = Console.ReadLine();

            //pilihan pedang
            if (b == "1" || b.ToLower() == "sword")
            {
                Console.WriteLine("Anda memilih Sword! Mari kita mulai petualangan kita!");
            }

            //pilihan busur/panah
            else if (b == "2" || b.ToLower() == "bow" || b.ToLower() == "arrow" || b.ToLower() == "bow/arrow")
            {
                Console.WriteLine("Anda memilih Bow/Arrow! Mari kita mulai petualangan kita!");
            }

            //oilihan sihir
            else if (b == "3" || b.ToLower() == "magic")
            {
                Console.WriteLine("Anda memilih Magic! Mari kita mulai petualangan kita!");
            }

            //tidak memilih apapun
            else
            {
                Console.WriteLine("\nPilihan tidak valid");
            }

            //==========================================================================================================================================================================

            Console.WriteLine("\n=====================\nmau kemana kita?\n1.Hutan\t2.Rawa\t3.Goa");
            string c = Console.ReadLine();

            //hutan
            if (c == "1" || c.ToLower() == "hutan")
            {
                int hpA = 15;
                int hpB = 15;

                Console.WriteLine("Kamu memilih Hutan\n=====================\nKamu bertemu musuh!\nWolf (Health : 15)" + males);


                do
                {
                    Console.WriteLine("\nGiliranmu, Serang!");
                    string d = Console.ReadLine();

                    if (d == "X")
                    {
                        hpA -= 10;
                        Console.WriteLine($"=====================\nDamage : 10\n=====================\nDarah musuh sekarang {hpA}\n=====================");
                    }

                    else
                    {
                        hpB -= 5;
                        Console.WriteLine($"=====================\nSalah Pencet!\nMelancarkan serangan dengan 5 damage!\nDarahmu sekarang {hpB}\n=====================\nDarah musuh sekarang {hpA}\n=====================");
                    }

                } while (hpA > 0 && hpB > 0);

                if (hpB > 0)
                {
                    Console.WriteLine("Kamu menang!!!");
                }

                else
                {
                    Console.WriteLine("Kamu kalah :C");
                }

            }


            //rawa
            else if (c == "2" || c.ToLower() == "rawa")
            {
                int hpA = 20;
                int hpB = 15;

                Console.WriteLine("Kamu memilih Rawa\n=====================\nKamu bertemu musuh!\nCrocs (Health : 20)" + males);


                do
                {
                    Console.WriteLine("\nGiliranmu, Serang!");
                    string d = Console.ReadLine();

                    if (d == "X")
                    {
                        hpA -= 10;
                        Console.WriteLine($"=====================\nDamage : 10\n=====================\nDarah musuh sekarang {hpA}\n=====================");
                    }

                    else
                    {
                        hpB -= 7;
                        Console.WriteLine($"=====================\nSalah Pencet!\nMelancarkan serangan dengan 7 damage!\nDarahmu sekarang {hpB}\n=====================\nDarah musuh sekarang {hpA}\n=====================");
                    }

                } while (hpA > 0 && hpB > 0);

                if (hpB > 0)
                {
                    Console.WriteLine("Kamu menang!!!");
                }

                else
                {
                    Console.WriteLine("Kamu kalah :C");
                }
            }

            //goa
            else if (c == "3" || c.ToLower() == "goa")
            {
                int hpA = 10;
                int hpB = 15;

                Console.WriteLine("Kamu memilih Goa\n=====================\nKamu bertemu musuh!\nBat (Health : 10)" + males);


                do
                {
                    Console.WriteLine("\nGiliranmu, Serang!");
                    string d = Console.ReadLine();

                    if (d == "X")
                    {
                        hpA -= 10;
                        Console.WriteLine($"=====================\nDamage : 10\n=====================\nDarah musuh sekarang {hpA}\n=====================");
                    }

                    else
                    {
                        hpB -= 3;
                        Console.WriteLine($"=====================\nSalah Pencet!\nMelancarkan serangan dengan 3 damage!\nDarahmu sekarang {hpB}\n=====================\nDarah musuh sekarang {hpA}\n=====================");
                    }

                } while (hpA > 0 && hpB > 0);

                if (hpB > 0)
                {
                    Console.WriteLine("Kamu menang!!!");
                }

                else
                {
                    Console.WriteLine("Kamu kalah :C");
                }
            }

            //Penutup
            Console.WriteLine("\n[GAME OVER]\n");
        }
    }
}

//owalah gitu toh..