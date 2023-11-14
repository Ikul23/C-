using Internal;
using System;

class Program {
  static void Main(string[] args) {

    Console.Write("Введите первое число: ");
    int a = Int32.Parse(Console.ReadLine());

    Console.Write("Введите второе число: ");    
    int b = Int32.Parse(Console.ReadLine());

    if (a == b * b) {
      Console.WriteLine("Да, первое число является квадратом второго");
    }
    else {
      Console.WriteLine("Нет, первое число не является квадратом второго"); 
    }

  }
}