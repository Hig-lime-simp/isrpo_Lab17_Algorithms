static int Add(int num1,int num2)
{
    return num1 + num2;
}
static int Sub(int num1,int num2)
{
    return num1 - num2;
}
static int Mul(int num1,int num2)
{
    return num1 * num2;
}
static int Div(int num1,int num2)
{
    return num1 / num2;
}
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

string? opr = Console.ReadLine();

switch (opr)
{
    case "+": Console.WriteLine(Add(num1, num2)); break;
    case "-": Console.WriteLine(Sub(num1, num2)); break;
    case "*": Console.WriteLine(Mul(num1, num2)); break;
    case "/": Console.WriteLine(Div(num1, num2)); break;
}



