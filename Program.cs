using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
        // (a)
      int  a, b, c, d, e;
     a=10, b=20, c=15, d=8, e=40;
    // Let n=equation 
        {
          int n = (a+b/(c-5))/((d+7)/(e-37)%3);
          Console.WriteLine(n);
          Console.ReadLine();
        }
        {
          // (b)
          int p = a+b/c-5/d+7/e-37%3;
          console.WriteLine(p);
          console.ReadLine();
        }
        {
          // (c)
          int q = a* (b*b) - (c*b) + d;
          console. WriteLine(q);
          console.ReadLine();
        }
      
     }
  }
}
