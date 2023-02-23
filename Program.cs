namespace learningcsharp3;
class Program
{
    static void Main(string[] args)
    {

    }



       static string [] cars ={"Volvo", "Hatchback", "Marcades", "ect"};
       static void choices()
    {
     
        for (int i=0; i<10; i++)
        {
            Console.WriteLine ($"CarOne,(i+1): {cars [4]}");
            int choices = Convert.ToInt32 Console.ReadLine();
            Console.WriteLine ("You Selected"+ cars[choices-1]);
            choices.Add (cars[choices-1]);
        }




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
