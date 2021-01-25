using System;

namespace GenerecsIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<string> isimler = new MyList<string>();//çalısacagın tipi büyük kücüktür işareti icine yazmalısın generic claslarda 
            isimler.Add("Engin");
            isimler.Add("Mehmet");
            Console.WriteLine(isimler.Count);
            

          

        }
    }
}
