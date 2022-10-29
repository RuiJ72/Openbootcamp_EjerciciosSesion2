Console.WriteLine("_____________Welcome_____________");


Console.WriteLine(" Please, introduce your full name: ");
string name = Console.ReadLine();
Console.WriteLine("\n");


Console.WriteLine(" What is your age?: ");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n");

Console.WriteLine(" Inform your Birthday year: ");
int dateBirth = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n");

Console.WriteLine(" Do you know any programming language? Signal with Y or N ");
char programing = Convert.ToChar(Console.ReadLine());
Console.WriteLine("\n");


Console.WriteLine(" Your name is: " + name +
    ", you have " + age + " years old, " + "and you born in the year of " + dateBirth +
    ". You answered with " + programing + " about your programming skills ");
