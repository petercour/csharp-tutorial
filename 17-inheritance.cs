using System;

// https://csharp1.com/inheritance/
namespace InheritanceApplication {
   class Bird {
      public void quack() {
         // quack
         Console.WriteLine("Quack");
      }
   }

   // Sub class
   class Parrot: Bird {
      public void talk() { 
         // hello 
         Console.WriteLine("Hello");
      }
   }
   class Example {
      static void Main(string[] args) {
         Parrot obj = new Parrot();
	 obj.talk();
	 obj.quack();
	 
         Console.ReadKey();
      }
   }
}