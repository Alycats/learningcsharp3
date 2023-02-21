namespace learningcsharp3;
class Program
{
    static void Main(string[] args)
    
    {





Console.ReadKey(true); 
    }
static void StringPractice()
{
string num1, num2, temp;

        Console.WriteLine("Input first number");
        num1 = Console.ReadLine();
        Console.WriteLine("Input Second number");
        num2 = Console.ReadLine();
        temp = num1;
        num1 = num2;
        num2 = temp;
        Console.WriteLine("After Swapping");
        Console.WriteLine($"First Number : {num1}");
        Console.WriteLine($"Second Number : {num2}");

        
}

}
