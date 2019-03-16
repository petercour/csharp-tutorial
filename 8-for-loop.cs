using System;

namespace Loops {
   class Program {
        static void Main(string[] args) {
           // https://csharp1.com
           for (int i = 0; i < 4; i = i + 1) {
	     Console.WriteLine("iteration i: {0}", i);
	   }
	   Console.ReadLine();
	}
    }
}