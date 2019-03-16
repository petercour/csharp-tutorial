using System;

// https://csharp1.com/class/
namespace CubeApplication {
   class Cube {
      public double length;

      public void showSize( ) {
          Console.WriteLine("Cube is {0}x{0},{0}", this.length);
      }
   }
   
   class Boxtester {
      static void Main(string[] args) {
         Cube c1 = new Cube();
         Cube c2 = new Cube();

         c1.length = 3;
         c2.length = 4;

         c1.showSize();
         c2.showSize();

         Console.ReadKey();
      }
   }
}