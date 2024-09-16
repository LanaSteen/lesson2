using System.Drawing;
using System.Globalization;
using System.Security.AccessControl;

namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {



            // დავალება 1
            //კონსოლის ფანჯრიდან შემოიყვანეთ ციფრი, და Convert.ToDouble ფუნქციით გადააკონვერტირეთ double-ში
            //და შეინახეთ ცვლადში სახელად number1.
            //კონსოლის ფანჯრიდან შემოიყვანეთ მეორე ციფრი, ესეც დააკონვერტირეთ double-ში და შეინახეთ
            //ცვლადში სახელად number2.
            //შექმენით ცვლადი sum და შეინახეთ მასში number1 მიმატებული number2 ანუ მათი ჯამი და დაბეჭდეთ.

            //double number1, number2;

            //Console.WriteLine("Enter first number:");
            //string? numb1 = Console.ReadLine();

            //if (double.TryParse(numb1, out number1))
            //{
            //    Console.WriteLine($"You entered: {number1}");
            //    Console.WriteLine("Enter second number:");
            //    string? numb2 = Console.ReadLine();
            //    if (double.TryParse(numb2, out number2))
            //    {
            //        double sum = number1 + number2;
            //        Console.WriteLine($"The sum is: {sum}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input for the second number. Please enter a valid number.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input for the first number. Please enter a valid number.");
            //}


            //დავალება 2
            //კონსოლის ფანჯრიდან შემოიყვანეთ ციფრი, და გადააკონვერტირეთ int-ში და შეინახეთ ცვლადში
            //სახელად number1.
            //კონსოლის ფანჯრიდან შემოიყვანეთ მეორე ციფრი, ესეც დააკონვერტირეთ int-ში და შეინახეთ ცვლადში
            //სახელად number2.
            //შექმენით ცვლადი result და შეინახეთ მასში number1 გამრავლებული number2 ანუ მათი ნამრავლი.
            //შეადარეთ result მეტია თუ არა 10 ზე და დაბეჭდეთ. { result} > 10 is { true or false } მსგავსი სახით მეტი იქნება
            //თუ ნაკლები შესაბამისად.


            //int number1, number2;

            //Console.WriteLine("Enter first number:");
            //string numb1 = Console.ReadLine();

            //if (int.TryParse(numb1, out number1))
            //{
            //    Console.WriteLine("Enter second number:");
            //    string numb2 = Console.ReadLine();
            //    if (int.TryParse(numb2, out number2))
            //    {
            //        int result = number1 * number2;
            //        Console.WriteLine($"{result} > 10 is {result > 10}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input for the second number. Please enter a valid integer.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input for the first number. Please enter a valid integer.");
            //}




            //დავალება 3
            //კონსოლის ფანჯრიდან შემოიყვანეთ ციფრი, და Convert.ToDouble ფუნქციით გადააკონვერტირეთ double-ში
            //და შეინახეთ ცვლადში სახელად number1.

            //კონსოლის ფანჭრიდან შემოიყვანეთ მეორე ციფრი, ესეც დააკონვერტირეთ double-ში და შეინახეთ
            //ცვლადში სახელად number2.
            //შექმენით ცვლადი sum და შეინახეთ მასში number1 მიმატებული number2 ანუ მათი ჯამი.
            //შექმენით ცვლადი isEven, bool ტიპის და შეინახეთ მასში sum არის კენტი თუ ლუწი
            //დაბეჭდე კონსოლში Sum და isEven.ანუ ჯამი და არის თუ არა ლუწი.

            //double number1, number2;
            //Console.WriteLine("Enter first number:");
            //string num1 = Console.ReadLine();
            //if (double.TryParse(num1, out number1))
            //{
            //    Console.WriteLine("Enter second number:");
            //    string num2 = Console.ReadLine();
            //    if (double.TryParse(num2, out number2))
            //    {
            //        double sum = number1+number2;
            //        bool isEven = sum % 2 == 0;
            //        Console.WriteLine($"sum : {sum} is even is - {isEven}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input for the second number. Please enter a valid number");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input for the first number. Please enter a valid number");
            //}



            //დავალება 4.
            //ააწყვეთ კონსოლური კალკულატორი სადაც მომხმარებელს სთხოვთ რომ შემოიყვანოს ორი ციფრი და აირჩიოს მისთვის სასურველი ოპერაცია   [+ - * /]
            // კალკულატორი ააწყვეთ როგორც IF ELSE ასევე SWITCH CASE - ის გამოყენებით.



            //Console.WriteLine("Enter first number:");
            //string num1 = Console.ReadLine();
            //Console.WriteLine("Enter math opperation (+ or - or * or / or %)");
            //string opp = Console.ReadLine();
            //char operation = Convert.ToChar(opp);
            //Console.WriteLine("Enter second number:");
            //string num2 = Console.ReadLine();
            //if ((!double.TryParse(num1, out double number1) || !double.TryParse(num2, out double number2)) ||
            //    !(operation == '+' || operation == '-' || operation == '*' || operation == '/' || operation == '%'))
            //{
            //    Console.WriteLine("Invalid input for the first or second number or operation. Please enter a valid numbers and math operation");
            //}
            //else
            //{
            //    if (operation == '+')
            //    {
            //        Console.WriteLine($"{number1} {operation} {number2} = {number1 + number2}");
            //    }
            //    else if (operation == '-')
            //    {
            //        Console.WriteLine($"{number1} {operation} {number2} = {number1 - number2}");
            //    }
            //    else if (operation == '*')
            //    {
            //        Console.WriteLine($"{number1} {operation} {number2} = {number1 * number2}");
            //    }
            //    else if (operation == '/')
            //    {
            //        if (number2 != 0)
            //        {
            //            Console.WriteLine($"{number1} {operation} {number2} = {number1 / number2}");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{number2} can't be 0 during devide operation");
            //        }

            //    }
            //    else if (operation == '%')
            //    {

            //        if (number2 != 0)
            //        {
            //            Console.WriteLine($"{number1} {operation} {number2} = {number1 % number2}");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{number2} can't be 0 during modulus operation");
            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("something went wrong");
            //    }

            //}






            //// swich case

            //Console.WriteLine("Enter first number:");
            //string num1 = Console.ReadLine();

            //Console.WriteLine("Enter math operation (+, -, *, /, %):");
            //string opp = Console.ReadLine();
            //char operation = Convert.ToChar(opp);

            //Console.WriteLine("Enter second number:");
            //string num2 = Console.ReadLine();

            //if (!double.TryParse(num1, out double number1) || !double.TryParse(num2, out double number2) ||
            //    !(operation == '+' || operation == '-' || operation == '*' || operation == '/' || operation == '%'))
            //{
            //    Console.WriteLine("Invalid input for the numbers or operation. Please enter valid numbers and a valid math operation.");
            //}
            //else
            //{
            //    switch (operation)
            //    {
            //        case '+':
            //            Console.WriteLine($"{number1} {operation} {number2} = {number1 + number2}");
            //            break;
            //        case '-':
            //            Console.WriteLine($"{number1} {operation} {number2} = {number1 - number2}");
            //            break;
            //        case '*':
            //            Console.WriteLine($"{number1} {operation} {number2} = {number1 * number2}");
            //            break;
            //        case '/':
            //            if (number2 != 0)
            //            {
            //                Console.WriteLine($"{number1} {operation} {number2} = {number1 / number2}");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Error: Division by zero is not allowed.");
            //            }
            //            break;
            //        case '%':
            //            if (number2 != 0)
            //            {
            //                Console.WriteLine($"{number1} {operation} {number2} = {number1 % number2}");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Error: Modulus by zero is not allowed.");
            //            }
            //            break;
            //        default:
            //            Console.WriteLine("Something went wrong.");
            //            break;
            //    }
            //}



            //დავალება 5
            //მოხმარებელს კლავიატურის გამოყენებით შეჰყავს 2 რიცხვი. პრიველი რიცხვი წარმოადგენს რაიმე
            //მნიშვნელობას, მეორე რიცხვი წარმოადგენს პროცენტს, რომელიც უნდა გამოვითვალოთ. მაგალითად, თუ ჩვენ
            //შევიყვანეთ რიცხვი - 90 და 10, შედეგად უნდა დაგვიბრუდნეს 90-ის 10 პროცენტი (%). პასუხი არის 9. 


            //Console.WriteLine("Enter the number:");
            //string num1 = Console.ReadLine();
            //Console.WriteLine("Enter the percentage");
            //string perc = Console.ReadLine();
            //if (double.TryParse(num1, out double number1) && double.TryParse(perc, out double percentage))
            //{
            //    double result = number1 * (percentage / 100);
            //    Console.WriteLine($"{percentage}% of {number1} is {result}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter valid numbers.");
            //}




            //დავალება 6
            //მომხმარებელს შეჰყავს 6-ნიშნა რიცხვი. ამის შემდეგ მომხმარებელს შეჰყავს მნიშვნელობები
            //ციფრების ადგილების ჩასანაცვლებლად. მაგალითად, თუ მომხმარებელმა შეიჰყვანა 1 და 6, უნდა შეიცვალოს
            //პირველი და მეექვსე ციფრების ადგილები. 
            //რიცხვი 723895 უნდა იქცეს - 523897 
            //თუ მომხმარებლის მიერ შეყვანილი რიცხვი არ იქნება 6-ნიშნა, ამ შემთხვევაში უნდა გამოვიდეს
            //შეცდომის (Error) შეტყობინების. 


            //Console.WriteLine("Enter 6 digit number");
            //string num = Console.ReadLine();
            //char[] arr = num.ToCharArray();
            //if (arr.Length !=6)
            //{
            //    Console.WriteLine("Error");
            //}
            //else
            //{
            //    Console.WriteLine("Enter number from 1 to 6 you wnat to be replaced");
            //    string firstInp = Console.ReadLine();
            //    Console.WriteLine("Enter number from 1 to 6 you want to be replaced with");
            //    string secondInp = Console.ReadLine();
            //    if (!byte.TryParse(firstInp, out byte firstInputNum) || firstInputNum < 1 || firstInputNum > 6
            //      || !byte.TryParse(secondInp, out byte secondInputNum) || secondInputNum < 1 || secondInputNum > 6 )
            //    {
            //        Console.WriteLine("Wrong input");
            //    }
            //    else
            //    {
            //        char temp = arr[firstInputNum - 1];
            //        arr[firstInputNum - 1] = arr[secondInputNum - 1];
            //        arr[secondInputNum - 1] = temp;

            //        Console.Write($"{arr[firstInputNum - 1]} and  {arr[secondInputNum - 1]} swiched places and now looks like that : ");
            //        Console.Write(arr);
            //    }
            //}


            //დავალება 7
            //მომხმარებელი შეიყვანს ტემპერატურის მაჩვენებლებს კლავიატურიდან. მომხმარებლის არჩევანის
            //მიხედვით, აპლიკაცია გარდაქმნის ტემპერატურას ფარენჰეიტიდან ცელსიუსში ან პირიქით

            //Console.WriteLine("Enter temperature degree");
            //string temp = Console.ReadLine();

            //Console.WriteLine("Enter temperature type 'C' or 'F'");
            //string type = Console.ReadLine();

            //if (!double.TryParse(temp, out double temperature ) || !char.TryParse (type, out char tempType) ||
            //   !(tempType =='C' || tempType == 'F'))
            //{
            //    Console.WriteLine("Wrong inputs");
            //}
            //else
            //{
            //    switch (tempType)
            //    {
            //        case 'C':
            //            Console.WriteLine($"{temperature} celsius to farengate = {(temperature * 9/5) + 32}");
            //            break;
            //        case 'F':
            //            Console.WriteLine($"{temperature} farengate to celsius = {(temperature-32) *5/9}");
            //            break;
            //    }

            //}

            //დავალება 8
            //მომხმარებელს კალვიატურის გამოყენებით შეჰყავს თარიღი.აპლიკაციამ, ამ თარიღის მიხედვით
            //უნდა აჩვენოს სეზონის სახელი და კვირის დღე. მაგალითად, თუ 12 / 22 / 2021 არის შეყვანილი, მომხმარებელმა
            //უნდა მიიღოს -ზამთარი ოთხშაბათი.

            //Console.WriteLine("Enter date in format 'MM/dd/yyyy':");
            //string dateInp = Console.ReadLine();
            //if (DateTime.TryParse(dateInp,  out DateTime date))
            //{
            //    string weekday = date.DayOfWeek.ToString();
            //    string season = "";
            //    if (date.Month >= 3 && date.Month <= 5)
            //        season ="Spring";
            //    else if (date.Month >= 6 && date.Month <= 8)
            //        season= "Summer";
            //    else if (date.Month >= 9 && date.Month <= 11)
            //        season= "Autumn";
            //    else
            //        season = "Winter";
            
            //    Console.WriteLine($"Season is {season} and weekday is {weekday}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid date format. Please enter the date in 'MM/dd/yyyy' format.");
            //}

        }
    }
}
