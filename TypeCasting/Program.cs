class TypeCast
{
    static void Main(string[] args)
    {
        // Implicit casting
        // 1. Int to float
        int num1 = 10;
        float num2 = 5.5f;
        float result = num1 + num2;
        System.Console.WriteLine("The result of adding two numbers is: " + result);

        // 2. Char to int
        char ch = 'A';
        int charToInt = ch + 1;
        System.Console.WriteLine(charToInt);

        // 3. Int to char
        int intToCharValue = 97;
        char intToChar = (char)intToCharValue;
        System.Console.WriteLine(intToChar);

        // Explicit Casting
        // 1. Double to int
        double pi = 3.14159265;
        int intPi = (int)pi;
        System.Console.WriteLine(intPi);

        // 2. Float to char
        float floatNum = 65.5f;
        char charValue = (char)floatNum;
        System.Console.WriteLine(charValue);

        // 3. Int to float
        int numA = 10;
        int b = 3;
        float divisionResult = numA / (float)b;
        System.Console.WriteLine(divisionResult);
    }
}