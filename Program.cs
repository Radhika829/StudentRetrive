using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRetrive
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "StudentDetails.txt");


                if (File.Exists(filePath))
                {

                    string[] lines = File.ReadAllLines(filePath);


                    Console.WriteLine("Student Data:");


                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                }
                else
                {
                    Console.WriteLine("File not found: " + filePath);
                }


                Console.ReadLine();
            }
        }
    }
    

