using System;

struct Person {
   public string job;
   public string name;
};  

public class testStructure {
   public static void Main(string[] args) {
      // https://csharp1.com/
      Person b;
      
      b.name = "Bob";
      b.job = "Chemist";

      Console.WriteLine( "b.name : {0}", b.name);
      Console.WriteLine("b.job : {0}", b.job);

      Console.ReadKey();
   }
}