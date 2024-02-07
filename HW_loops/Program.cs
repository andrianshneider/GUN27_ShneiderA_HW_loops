internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Homework, loops");
        Console.WriteLine("");

        //task 1: Fibonacci numbers

        int[] array1 = new int[10];
        var s = "";

        for (int i=0; i<array1.Length; i++)
        {
            if (i < 2)
            {
                array1[i] = i;
                s = s + "[" + array1[i] + "]";
            }
            else
                array1[i] = array1[i - 1] + array1[i - 2];
                s = s + "[" + array1[i] + "]";
        }
        Console.WriteLine("TASK #1: Fibonacci numbers");
        Console.WriteLine("");
        Console.WriteLine(s);

        //task 2: Even numbers

        s = "";

        for (int i = 2; i <= 20; i+=2)
        {
            s = s + "[" + i + "]";
        }

        Console.WriteLine("");
        Console.WriteLine("TASK #2: Even numbers");
        Console.WriteLine("");
        Console.WriteLine(s);

        //task 3: Multiplication table

        Console.WriteLine("");
        Console.WriteLine("TASK #3: Multiplication table (1-5)");
        Console.WriteLine("");

        for (int i = 1; i <= 5; i++)
        {
            for (int j=1; j<=10; j++)
            {
                Console.WriteLine("{0} x {1} = {2}", i, j, i*j);
            }
        }

        //task 4: Password

        Console.WriteLine("");
        Console.WriteLine("TASK #4: Password Input");
        Console.WriteLine("");

        do
        {
            Console.WriteLine("Enter your password:");
            s = Console.ReadLine();
        } while (s != "qwerty");
        Console.WriteLine("Congratulations! Your password is correct!");
    }
}