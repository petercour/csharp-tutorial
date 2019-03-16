using System;

namespace CalculatorApplication {
   class Example {
      // https://csharp1.com
      public float multiply(float x1, float x2) {
         float c = x1 * x2;
	 return c;
      }
      
      static void Main(string[] args) {
         float output = 0;
	 output = multiply(2,4);
	 Console.WriteLine("Output {0}",output);
         Console.ReadLine();
      }
   }
}