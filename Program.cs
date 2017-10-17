using System;

namespace ExemploArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "amanda.moraes.botelho";
            string[] strArray;

            strArray = str.Split(".");

            foreach(string palavra in strArray){
                Console.WriteLine(palavra);
            }
        }
    }
}
