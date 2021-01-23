using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class DatabaseLoggerService : IloggerSevice
    {
        public void Log()
        {
            Console.WriteLine("Veri tabanına loglandı");
        }
    }
}
