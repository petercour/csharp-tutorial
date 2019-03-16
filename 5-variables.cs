using System;

namespace ExampleApplication {

   class ExampleProg {
   
      static void Main(string[] args) {
         // https://csharp1.com
         float price = 2 + 3;
	 float vat = price * 0.15;
	 float total = price + vat;
	 
         Console.WriteLine(total);
         Console.ReadKey() ;
      }
   }
}