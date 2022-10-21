var numbers = new List<int>();


var myNumber = 0;

do
{
    myNumber++;
    numbers.Add(myNumber);
}while (myNumber< 100);

    while (myNumber < 200)
{
    myNumber++;

    numbers.Add(myNumber);
}
    

    Console.WriteLine("increase:");

foreach (var item in numbers)

{
    Console.WriteLine($"{item}");

}

    Console.WriteLine("");
    Console.WriteLine("decrease:");



   for (var i = 199; i >= 0;i--)

        Console.WriteLine($"{numbers[i]}");





