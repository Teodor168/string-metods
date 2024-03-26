using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace Shake_it
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();
            int i = input.IndexOf(pattern);
            int j = 0;
            while (j<pattern.Length )
            {
                if (input.Contains(pattern))
                {
                    Console.WriteLine("Shake it");

                    while (input.Contains(pattern))
                    {
                        i = input.LastIndexOf(pattern);
                        input = input.Remove(i, pattern.Length);
                    }
                }
                else
                {
                    Console.WriteLine("No shake");
                    break;
                }
                j++;
            }
            Console.WriteLine(input);
        }
    }
}