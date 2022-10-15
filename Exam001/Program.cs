

class Program
{
  static void Foo (int i)
  {
    Console.WriteLine(i);
    if (i <= 1)
    return;
    
    i--;
    Foo(i);
  }

  static void Main(string[] args)
  {
    Foo(8);
  }
}
