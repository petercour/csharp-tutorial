using System;

namespace Loops {
   class Program {
      static void Main(string[] args) {
         // https://csharp1.com
         int i = 1;
         int max = 20;
	 
         while (i < max) {
            Console.WriteLine("value of i: {0}", i);
            i++;
         }
         Console.ReadLine();
      }
   }
} 