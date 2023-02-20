
//Ex 1. Write a C# Sharp program to accept two integers and check whether they are equal or not.

Console.WriteLine("Enter 2 numbers");
int a=int.Parse(Console.ReadLine());
int b=int.Parse(Console.ReadLine());

if (a==b)
{
    Console.WriteLine("Equal");
}
else
{
    Console.WriteLine("Different");
}

//Ex 2. Write a C# Sharp program to check whether a given number is even or odd.


Console.WriteLine("Enter number");
int a=int.Parse(Console.ReadLine());

if (a%2==0)
{
    Console.WriteLine("Even number");
}
else
{
    Console.WriteLine("Odd number");
}




//Ex 3. Write a C# Sharp program to check whether a given number is positive or negative. 

Console.WriteLine("Enter number");
int a=int.Parse(Console.ReadLine());

if (a<0)
{
    Console.WriteLine("Negative");
}
else
{
    Console.WriteLine("Positive");
}


//Ex 4. Write a C# Sharp program to find whether a given year is a leap year or not.


Console.WriteLine("Enter year to check leap year");
int a=int.Parse(Console.ReadLine());

if (a%400==0)
{
    Console.WriteLine("Leap year");
}
else if (a%100==0)
{
    Console.WriteLine("Not Leap year");
}
else if (a%4==0)
{
    Console.WriteLine("Leap year");
}
else
{
    Console.WriteLine("Not Leap year");
}


//Ex 5. Write a C# Sharp program to read the age of a candidate and determine whether it is eligible for casting his/her own vote.


Console.WriteLine("Enter you age");
int a=int.Parse(Console.ReadLine());

if (a<18)
{
    Console.WriteLine("You are not eligible");
}
else
{
    Console.WriteLine("You are eligible");
}

//Ex 6. Write a C# Sharp program to read the value of an integer m and display the value of n is 1 when m is larger than 0, 
//0 when m is 0 and -1 when m is less than 0.


Console.WriteLine("Enter integer");
int m=int.Parse(Console.ReadLine());

if (m<0)
{

    Console.WriteLine(-1);
}
else if (m>0)
{
    Console.WriteLine(1);
}
else
{
    Console.WriteLine(0);
}

//Ex 7. Write a C# Sharp program to accept the height of a person in centimeter and categorize the person according to their height.


Console.WriteLine("Enter height");
int a=int.Parse(Console.ReadLine());

if (a<150)
{
    Console.WriteLine("Dwarf");
}
else if (a<175 && a>150)
{
    Console.WriteLine("Normal height");
}
else
{
    Console.WriteLine("Tall");
}


//Ex 8. Write a C# Sharp program to find the largest of three numbers.

Console.WriteLine("Enter  3 number");
string[] input=Console.ReadLine().Split(' ');
int[] arr = Array.ConvertAll(input, int.Parse);

Console.WriteLine("Max value: "+arr.Max());





//Ex 9. Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.

Console.WriteLine("Enter values of x and y");
int x=int.Parse(Console.ReadLine());
int y=int.Parse(Console.ReadLine());



if (x==0  && y==0)
{
    Console.WriteLine("Origin");
}
else if (x>0 && y>0)
{
    Console.WriteLine("1st quadrant");
}
else if (x<0 && y>0)
{
    Console.WriteLine("2nd quadrant");
}
else if (x<0 && y<0)
{
    Console.WriteLine("3rd quadrant");
}
else
{
    Console.WriteLine("4th quadrant");
}


//Ex  10. Write a C# Sharp program to find the eligibility of admission for a professional course based on the following criteria: 
/*  Marks in Maths >=65
    Marks in Phy >=55
    Marks in Chem>=50
    Total in all three subject >=180
    or
    Total in Math and Subjects >=140 */

Console.WriteLine("Enter score of physics:");
int p=int.Parse(Console.ReadLine());

Console.WriteLine("Enter score of Chemistry: ");
int c=int.Parse(Console.ReadLine());

Console.WriteLine("Enter score of Mathematics: ");
int m=int.Parse(Console.ReadLine());


int total = m + c + p;

if (p>=65 && c>=55 && m>=50 && total>=180)
{
    Console.WriteLine("The candidate is eligible for admission.");
}
else if (m+p>=140)
{
    Console.WriteLine("The candidate is eligible for admission.");

}
else
{
    Console.WriteLine("The candidate is not eligible.");
}

//Ex 11. Write a C# Sharp program to calculate root of Quadratic Equation.

Console.WriteLine("Enter values of quadratic equation: ");
Console.WriteLine("Value of a: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Value of b: ");
double b = double.Parse(Console.ReadLine());

Console.WriteLine("Value of c: ");
double c= double.Parse(Console.ReadLine());

double d = Math.Pow(b, 2) - 4 * a * c;

if (d<0)
{
    Console.WriteLine("Root are imaginary");
}
else if (d>0)
{
    Console.WriteLine("Two solutions.");
    double r1 = (-b + Math.Sqrt(d)) / (2 * a);
    double r2 = (-b - Math.Sqrt(d)) / (2 * a);
    Console.WriteLine("Root 1: "+r1);
    Console.WriteLine("Root 2: " + r2);
}
else
{
    double r3 = (-b) / (2 * a);
    Console.WriteLine("One solution: "+r3);
}


//Ex 13. Write a C# Sharp program to read temperature in centigrade and display a suitable message according to temperature state below :
/*Temp < 0 then Freezing weather
Temp 0-10 then Very Cold weather
Temp 10-20 then Cold weather
Temp 20-30 then Normal in Temp
Temp 30-40 then Its Hot
Temp >=40 then Its Very Hot*/

Console.WriteLine("Enter temperature");
int t=int.Parse(Console.ReadLine());


switch (t)
{

    case int n when (n < 0):
        {
            Console.WriteLine("Freezing weather");
            break;
        }

    case int n when (n >= 0&& n<10):
        {
            Console.WriteLine("Very Cold weather");
            break;
        }

    case int n when (n >= 10 && n < 20):
        {
            Console.WriteLine("Cold weather");
            break;
        }

    case int n when (n >= 20 && n < 30):
        {
            Console.WriteLine("Normal temerature ");
            break;
        }

    case int n when (n >= 30 && n < 40):
        {
            Console.WriteLine("Hot temerature ");
            break;
        }

    case int n when (n >= 40 ):
        {
            Console.WriteLine("Very Hot");
            break;
        }

}


//Ex 14. Write a C# Sharp program to check whether a triangle is Equilateral, Isosceles or Scalene.

Console.WriteLine("Enter 3 angles of triangle");
Console.WriteLine("1st: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("2nd: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("3rd: ");
int c = int.Parse(Console.ReadLine());


if (a + b + c != 180)
{
    Console.WriteLine("Not possible triangle with entered angles");
}
else if (a == b && b == c)
{
    Console.WriteLine("Equilateral triangle");
}
else if (a == b || a == c || b == c)
{
    Console.WriteLine("Isosceles  triangle");
}
else
{
    Console.WriteLine("Scalene triangle");
}


//Ex 16. Write a C# Sharp program to check whether an alphabet is a vowel or consonant. 

Console.WriteLine("Enter letter.");
char c=char.Parse(Console.ReadLine());


string vowel = "aeiou";

if (vowel.Contains(c))
{
    Console.WriteLine("The alphabet is a vowel.");
}
else
{
    Console.WriteLine("The alphabet is a consonant.");

}


//Ex 17. Write a C# Sharp program to calculate profit and loss on a transaction.

Console.WriteLine("Enter your cost price:");
int cost=int.Parse(Console.ReadLine());
Console.WriteLine("Enter your selling price");
int selling_price=int.Parse(Console.ReadLine());


if (selling_price>cost)
{
    Console.WriteLine("Profit: "+(selling_price-cost));
}
else if (cost>selling_price)
{
    Console.WriteLine("Lost amount: " + (cost-selling_price ));
}
else
{
    Console.WriteLine("No loss no profit");
}

//Ex 

//Ex 

//Ex 

//Ex 

//Ex 











