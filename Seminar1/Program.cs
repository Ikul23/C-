// является ли число 1 квадратом числа 2
int a = 25;
int b = 5;

if (a == 0){
    Console.WriteLine($"Число {a} , корень 0");
}
else if (b*b == a){
    Console.WriteLine($"Число b={b} является корнем числа a={a}");
}
else if (a*a == b){
    Console.WriteLine($"Число a={a} является корнем числа b={b}");
}
else{
    Console.WriteLine($"Число a={a} не является корнем числа b={b}");
}