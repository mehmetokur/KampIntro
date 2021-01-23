using System;

namespace Oop3
{
    class FileLoggerService : IloggerSevice
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
