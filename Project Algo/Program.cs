using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project_Algo
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger var = new BigInteger();
            //readFiles();
            Final();
        }

        public static void readFiles()
        {
            while (true)
            {
                Console.WriteLine("[1] Addition\n[2] Subtraction\n[3] Multiblication");
                Console.Write("\nEnter your choice [1-3]: ");
                char choice = (char)Console.ReadLine()[0];

                if (choice == '1')
                {
                    long totalTime = 0;
                    BigInteger var = new BigInteger();
                    FileStream file = new FileStream("AddTestCases.txt", FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(file);
                    int cases = int.Parse(sr.ReadLine());
                    string ignor_line = sr.ReadLine();
                    FileStream fileout = new FileStream("YourOutput_Add.txt", FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fileout);
                    for (int a = 0; a < cases; a++)
                    {
                        string first_number = sr.ReadLine();
                        string second_number = sr.ReadLine();
                        ignor_line = sr.ReadLine();

                        long timeBefore = System.Environment.TickCount;
                        string result = var.Addtion(first_number, second_number);
                        long timeAfter = System.Environment.TickCount;
                        totalTime += (timeAfter - timeBefore);
                        sw.Write(result);
                        if (a < cases - 1)
                        {
                            sw.WriteLine("\n");
                        }
                    }
                    sw.Close();
                    fileout.Close();
                    Console.WriteLine("Time limit exceed for Addtion: " + totalTime);
                    sr.Close();
                    file.Close();
                }
                else if (choice == '2')
                {
                    long totalTime = 0;
                    BigInteger var = new BigInteger();
                    FileStream file = new FileStream("SubtractTestCases.txt", FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(file);
                    int cases = int.Parse(sr.ReadLine());
                    string ignor_line = sr.ReadLine();
                    FileStream fileout = new FileStream("YourOutput_Sub.txt", FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fileout);
                    for (int a = 0; a < cases; a++)
                    {
                        string first_number = sr.ReadLine();
                        string second_number = sr.ReadLine();
                        ignor_line = sr.ReadLine();

                        long timeBefore = System.Environment.TickCount;
                        string result = var.Subtraction(first_number, second_number);
                        long timeAfter = System.Environment.TickCount;
                        totalTime += (timeAfter - timeBefore);
                        sw.WriteLine(result);
                        if (a < cases - 1)
                        {
                            sw.WriteLine();
                        }
                    }
                    sw.Close();
                    fileout.Close();
                    Console.WriteLine("Time limit exceed for Subtraction: " + totalTime);
                    sr.Close();
                    file.Close();

                }
                else if (choice == '3')
                {
                    long totalTime = 0;
                    BigInteger var = new BigInteger();
                    FileStream file = new FileStream("MultiplyTestCases.txt", FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(file);
                    int cases = int.Parse(sr.ReadLine());
                    string ignor_line = sr.ReadLine();
                    FileStream fileout = new FileStream("YourOutput_Mul.txt", FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fileout);
                    for (int a = 0; a < cases; a++)
                    {
                        string first_number = sr.ReadLine();
                        string second_number = sr.ReadLine();
                        ignor_line = sr.ReadLine();

                        long timeBefore = System.Environment.TickCount;
                        string result = var.multiplication(first_number, second_number);
                        long timeAfter = System.Environment.TickCount;
                        totalTime += (timeAfter - timeBefore);

                        sw.WriteLine(result);
                        if (a < cases - 1)
                        {
                            sw.WriteLine();
                        }
                    }
                    sw.Close();
                    fileout.Close();
                    Console.WriteLine("Time limit exceed for multiplication: " + totalTime);

                    sr.Close();
                    file.Close();
                }
                else
                    Console.WriteLine("wrong answer!");

                Console.Write("Do you want to continue (y/n)? ");
                char cho = (char)Console.ReadLine()[0];
                if (cho == 'n' || cho == 'N')
                    break;
            }
        }
        public static void Final()
        {
            while (true)
            {
                Console.WriteLine("[1] SampleRSA\n[2] TestRSA");
                Console.Write("\nEnter your choice [1-2]: ");
                char choice = (char)Console.ReadLine()[0];

                if (choice == '1')
                {
                    long totalTime = 0;
                    BigInteger var = new BigInteger();
                    FileStream file = new FileStream("SampleRSA.txt", FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(file);
                    int cases = int.Parse(sr.ReadLine());
                    FileStream fileout = new FileStream("YourOutput_SampleRSA.txt", FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fileout);
                    for (int a = 0; a < cases; a++)
                    {
                        string divide = sr.ReadLine();
                        string pow = sr.ReadLine();
                        string number = sr.ReadLine();
                        string choi = sr.ReadLine();
                        if(choi=="0")
                        {
                            long timeBefore = System.Environment.TickCount;
                            string result = var.encryption(number, pow, divide);
                            long timeAfter = System.Environment.TickCount;
                            totalTime += (timeAfter - timeBefore);
                            Console.WriteLine("Time limit exceed for case "+ (a + 1) + ": "+(timeAfter - timeBefore));
                            sw.WriteLine(result);
                        }
                        else if (choi == "1")
                        {
                            long timeBefore = System.Environment.TickCount;
                            string result = var.decryption(number, pow, divide);
                            long timeAfter = System.Environment.TickCount;
                            totalTime += (timeAfter - timeBefore);
                            Console.WriteLine("Time limit exceed for case " + (a + 1) + ": " + (timeAfter - timeBefore));
                            sw.WriteLine(result);
                        }

                    }
                    sw.Close();
                    fileout.Close();
                    Console.WriteLine("Time limit exceed for Sample Test: " + totalTime);
                    sr.Close();
                    file.Close();
                }
                else if (choice == '2')
                {
                    long totalTime = 0;
                    BigInteger var = new BigInteger();
                    FileStream file = new FileStream("TestRSA.txt", FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(file);
                    int cases = int.Parse(sr.ReadLine());
                    FileStream fileout = new FileStream("YourOutput_TestRSA.txt", FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fileout);
                    for (int a = 0; a < cases; a++)
                    {
                        string divide = sr.ReadLine();
                        string pow = sr.ReadLine();
                        string number = sr.ReadLine();
                        string choi = sr.ReadLine();
                        if (choi == "0")
                        {
                            long timeBefore = System.Environment.TickCount;
                            string result = var.encryption(number, pow, divide);
                            long timeAfter = System.Environment.TickCount;
                            totalTime += (timeAfter - timeBefore);
                            Console.WriteLine("Time limit exceed for case " + (a + 1) + ": " + (timeAfter - timeBefore));
                            sw.WriteLine(result);
                        }
                        else if (choi == "1")
                        {
                            long timeBefore = System.Environment.TickCount;
                            string result = var.decryption(number, pow, divide);
                            long timeAfter = System.Environment.TickCount;
                            totalTime += (timeAfter - timeBefore);
                            Console.WriteLine("Time limit exceed for case " + (a + 1) + ": " + (timeAfter - timeBefore));
                            sw.WriteLine(result);
                        }

                    }
                    sw.Close();
                    fileout.Close();
                    Console.WriteLine("Time limit exceed for Complete Test: " + totalTime);
                    sr.Close();
                    file.Close();
                }
                else
                    Console.WriteLine("wrong answer!");

                Console.Write("Do you want to continue (y/n)? ");
                char cho = (char)Console.ReadLine()[0];
                if (cho == 'n' || cho == 'N')
                    break;
            }
        }
    }
}
