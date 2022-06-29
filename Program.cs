

int a = 5;
int b = 0;
int c = 4;
if ((a + b + c > 10) || (a == b))
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("Or the firstnumber is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("Or the first number is not equal to the second");
}


// while loop
int counter = 0;
while (counter < 10)
{
    Console.WriteLine($"Hello World! The counter in {counter}");
    counter++;
}

// do while loop
int counter3 = 3;
do
{
    Console.WriteLine($"Hello World! The counter is {counter}");
    counter3 ++;
} while (counter3 <10);

//for loop
for (int index = 10; index > 0; index-=2) {
    Console.WriteLine($"Hello world! The index is {index}");
}

    for (char column = 'a'; column < 'k'; column++) {
{
    for (int row  = 1; row < 11; row++)
        Console.WriteLine($"The cell is ({column},{row})");
    }
}

//C# code challenge
int sum = 0;
for (int check = 0; check < 20; check++)
{
    if (check % 3 == 0){
        sum += check;
    }
}
        Console.WriteLine($"The sum of all numbers divisible by 3 between 0 and 20 is {sum}");