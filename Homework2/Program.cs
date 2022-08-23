string firstnumber = Console.ReadLine();
string secondnumber = Console.ReadLine();
string thirdnumber = Console.ReadLine();

double max = 0;

double.TryParse(firstnumber, out double firstnumber1);
double.TryParse(secondnumber, out double secondnumber2);
double.TryParse(thirdnumber, out double thirdnumber3);

if(firstnumber1 > secondnumber2)
{  
    max = firstnumber1;
}
else
{
    max = secondnumber2;
}
if(thirdnumber3 > max)
{
    max = thirdnumber3;
}

Console.Write(max);