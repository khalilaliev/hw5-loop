// 1.1 average number // 

Console.Write("Enter the number of employees: ");
int count = int.Parse(Console.ReadLine());
double sum = 0;

for (int i = 1; i <= count; i++)
{
    Console.Write($"Enter the employee's salary {i}: ");
    double salary = double.Parse(Console.ReadLine());
    sum += salary;
}

double average = sum / count;

Console.WriteLine($"Average income: {average}");

// 1.2 a graph with stars // 

Console.Write("Enter the number of row: ");
int rows = int.Parse(Console.ReadLine());

for (int i = 1; i <= rows; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

// 1.3 prime numbers // 

Console.Write("Enter any number: ");
int number = int.Parse(Console.ReadLine());

for (int i = 2; i <= number; i++)
{
    int divisors = 0;

    for (int j = 1; j <= i; j++)
    {
        if (i % j == 0)
            divisors++;
    }

    if (divisors == 2)
        Console.Write(i + " ");
}

// 1.4 fibonacci // 

Console.Write("Enter a number: ");
int fibNumber = int.Parse(Console.ReadLine());

int a = 0;
int b = 1;
int i = 0;

while (i < fibNumber)
{
    Console.Write(a + " ");

    int c = a + b;
    a = b;
    b = c;

    i++;
}

// 1.5 salary per day // 

double totalPay = 0;

for (int partOfTheDay = 1; partOfTheDay <= 3; partOfTheDay++)
{
    double rate;

    if (partOfTheDay == 1)
    {
        Console.Write("Morning: ");
        rate = 10;
    }
    else if (partOfTheDay == 2)
    {
        Console.Write("Afternoon: ");
        rate = 12;
    }
    else
    {
        Console.Write("Evening: ");
        rate = 15;
    }

    double hours = double.Parse(Console.ReadLine());
    totalPay += hours * rate;
}

Console.WriteLine("Salary per day: " + totalPay);

// 1.6 multiplication table // 

Console.Write("Enter a number: ");
int multiplicationNumber = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(multiplicationNumber + " * " + i + " = " + (multiplicationNumber * i));
}

// 1.7 is prime number // 

Console.Write("Enter a number: ");
int numberPrime = int.Parse(Console.ReadLine());

bool isPrime = true;

if (numberPrime < 2)
{
    isPrime = false;
}
else
{
    for (int i = 2; i < numberPrime; i++)
    {
        if (numberPrime % i == 0)
        {
            isPrime = false;
            break;
        }
    }
}

if (isPrime)
    Console.WriteLine("The number is prime.");
else
    Console.WriteLine("The number is not prime.");
