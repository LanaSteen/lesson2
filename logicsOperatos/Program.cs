class Lesson2
{
    static void Main(string[] args)
    {
        int num1 = 5;
        Console.WriteLine(num1++);
        Console.WriteLine(num1);


        switch (num1)
        {
            case int x when x == 1 && x == 4:
                Console.WriteLine(x);
                break;
            case 3:
                Console.WriteLine("samia");
                break;

            case 5:
                Console.WriteLine("metia");
                break;
            default:
                Console.WriteLine("udris");
                break;
        }

        switch (num1)
        {
            case int x when x == 1 && x == 4:
                Console.WriteLine(x);
                break;
            case 3:
                Console.WriteLine("samia");
                break;

            case 5:
                Console.WriteLine("metia");
                break;
            default:
                Console.WriteLine("udris");
                break;
        }



    }
}