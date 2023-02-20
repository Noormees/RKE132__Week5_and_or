

// temp <= 0 - freesing cold
// temp > 0 AND <= 10 - cold
// temp > 10 AND <= 15 - good
// temp > 15 AND < 20 - warm
// temp >= 20 AND <30 - hot
// temp >= 30 - boiling hot


Console.WriteLine("Please enter the temperature outside:");
int temp = Int32.Parse(Console.ReadLine());

if(temp >= 30)
{ Console.WriteLine("Boiling hot!"); 
}
else if(temp >= 20 && temp < 30)
{
    Console.WriteLine("Hot");
}
else if(temp > 15 && temp < 20)
{
    Console.WriteLine("Warm");
}
else if(temp > 10 && temp <= 15)
{
    Console.WriteLine("Good");
}
else if(temp > 0 && temp <= 10)
        {
    Console.WriteLine("Cold");
}
else
{
    Console.WriteLine("Freezing cold!");

}
