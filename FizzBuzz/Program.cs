using FizzBuzz;

Console.WriteLine("Hello, World!");

for (int i = 1; i < 100; i++)
{
    string number = i.ToString();
    
    number = Helper.AskFizzBuzz(i);

    Console.WriteLine(number);
}


Console.ReadLine();
