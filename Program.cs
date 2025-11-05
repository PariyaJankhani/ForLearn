// calculator

//int result;
//Console.WriteLine("Please Enter Num1");
//int input1= int.Parse(Console.ReadLine());
//Console.WriteLine("Pleae Enter num2");
//int input2= int.Parse(Console.ReadLine());

//Console.WriteLine("Choose an Operator * / + -");

//char op =char.Parse( Console.ReadLine());

//switch(op)
//    {
//    case '*':
//        result = input1 * input2;
//        Console.WriteLine($"result is:{result}");
//        break;

//    case '/':
//        result = input1 / input2;
//        Console.WriteLine($"result is:{result}");
//        break;

//    case '+':
//        result = input1 + input2;
//        Console.WriteLine($"result is:{result}");
//        break;
    
//    case '-':
//        result = input1 - input2;
//        Console.WriteLine($"result is:{result}");
//        break;

//    default:
//        break;


//    }

//Console.ReadKey();

//****************************************************************

// Blue calculator wich is not blue, i love blue!
Console.WriteLine("Please enter number1");
int num1 = int.Parse( Console.ReadLine());
Console.WriteLine("Please enter number2");
int num2 = int.Parse( Console.ReadLine());

for(int i = 0; i <= 5; i++)
{
    int answer= num1 + num2;
    Console.WriteLine($"Add: {answer}");
    answer = num1 - num2;
    Console.WriteLine($"subtract: {answer}");
    answer = num1 * num2;
    Console.WriteLine($"Multiple: {answer}");
    answer = num1 / num2;
    Console.WriteLine($"Division: {answer}");
    answer = num1 % num2;
    Console.WriteLine($"Remaining: {answer}");
    break;
}

//*******************************************************************

void Add(int num1 , int num2)
{
    int result = num1 + num2;
    Console.WriteLine($" num1 + num2 ={result}");
}

void Sub(int num1, int num2)
{
    int result = num1 - num2;
    Console.WriteLine($" num1 - num2 ={result}");
}

void Multiple(int num1, int num2)
{
    int result = num1 * num2;
    Console.WriteLine($" num1 * num2 ={result}");
}

void Division(int num1, int num2)
{
    int result = num1 / num2;
    Console.WriteLine($" num1 / num2 ={result}");
}

Console.ForegroundColor = ConsoleColor.Blue;
Add(num1 , num2);
Sub(num1 , num2);
Multiple(num1, num2);
Division(num1, num2);

Console.ReadKey();
