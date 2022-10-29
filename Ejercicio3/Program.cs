using System;

int number = 18;

char caracterA = 'a';
char vIn = '\xa';
bool vOut = (vIn != 0);



Console.WriteLine("Condition True: Número mayor que 18");
Console.WriteLine("---------------------------");
Console.WriteLine(18 >= 18);

Console.WriteLine("Condition True: a es un char");
Console.WriteLine("---------------------------");
Console.WriteLine(vIn);


Console.WriteLine("Dos condiciones verdaderas");
Console.WriteLine("----------------------------");
Console.WriteLine(18 == 18 && 17 <= 18);

Console.WriteLine("----------------------------");
Console.WriteLine("Una de dos condiciones verdadera");
Console.WriteLine("----------------------------");

Console.WriteLine(19 >= 18 || 65 == 65);

