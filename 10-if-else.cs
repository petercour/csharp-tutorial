using System;

namespace HelloWorldApplication {
   class HelloWorld {
         static void Main(string[] args) {
	     // https://csharp1.com
	     int x = 1;

             if (x > 2){
                 Console.WriteLine("condition is true");
	         Console.ReadKey();
             } else {
                 Console.WriteLine("condition is not true");
	         Console.ReadKey();
             }
   	 }
   }
}