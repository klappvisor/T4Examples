using System;
// This is code from template
namespace T4Examples {
    class TestConsole {
        public static void Main (string[] args) {
            var template = new MyRuntimeTemplate();
            string text = template.TransformText();
            Console.WriteLine(text);
            
            //TODO: place code here
            
            Console.ReadLine();
        }
    }
}

