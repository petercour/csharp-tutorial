using System;

namespace CalculatorApplication {
   class Example {
      // https://csharp1.com
      public void hello(string x1) {
         Console.WriteLine("Hello {0}", x1 );
      }
      
      static void Main(string[] args) {
         hello("Alice");
         Console.ReadLine();
      }
   }
}