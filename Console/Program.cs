using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using T4Examples;

namespace TestConsole {
    class Program {
        static void Main(string[] args) {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            
            var template = new MyRuntimeTemplate();
            var text = template.TransformText();
            Console.WriteLine(text);

            Console.ReadLine();
        }
    }
}
