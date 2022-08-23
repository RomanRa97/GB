string number = Console.ReadLine();

int.TryParse(number, out int number1);

if(number1 % 2 == 0)
{  
    Console.Write("Да");
}

else
{
    Console.Write("Нет");
}