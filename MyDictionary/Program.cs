using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> AdYas1 = new Dictionary<string, int>();
            AdYas1.Add("Mehmet", 32);
            AdYas1.Add("Ahmet", 30);
            AdYas1.Add("Salih",31);
            AdYas1.Add("Ömer", 33);
            Console.WriteLine(AdYas1.Count);
            AdYas1.Add("Zehra",26);
            Console.WriteLine(AdYas1.Count);


  
        }
    }
}
