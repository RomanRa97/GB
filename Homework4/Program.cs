string number = Console.ReadLine();

int.TryParse(number, out int number2);

for (int x = 2; x < number2+1; x++)       
if (x%2==0)            
Console.Write($"{x} ") ;