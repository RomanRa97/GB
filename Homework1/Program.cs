string firstnumber = Console.ReadLine();
string secondnumber = Console.ReadLine();

double.TryParse(firstnumber, out double firstnumber1);
double.TryParse(secondnumber, out double secondnumber2);

if(firstnumber1 > secondnumber2)
{  
    Console.Write("max =" +" "+ firstnumber);
}

if(secondnumber2 > firstnumber1)
{
    Console.Write("max =" +" "+  secondnumber);
}

if (secondnumber2 == firstnumber1)
{
    Console.Write("Числа равны");
}