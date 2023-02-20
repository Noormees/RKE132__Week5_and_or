
// Math >= 90 OR Chemi >= 90 
// Math && Chem || Math && Bio || Chem && Bio

int math, bio, chem;

Console.WriteLine("Please enter your Math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Please enter your Biology result:");
bio = Int32.Parse(Console.ReadLine());

Console.WriteLine("Please enter your Chemistry result:");
chem = Int32.Parse(Console.ReadLine());


if ((math >= 90 && chem >= 90) || (math >= 90 && bio >= 90) || (chem >= 90 && bio >= 90))
{
    Console.WriteLine("Congratilation! You got accepted");
}

else
{
    Console.WriteLine("You are not in!");
}

