namespace assignment_21_nov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Calculator App
            Console.WriteLine("This is a calculator app!");
            try
            {
                Console.WriteLine("Please, enter the first number:");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please, enter the second number:");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please, enter the operator: (possible operators: + ; - ; * ; /)");
                char operation = Convert.ToChar(Console.ReadLine());
                Calculator(num1, num2, operation);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured! Error info: " + ex.Message);
            } 
            #endregion
        }
        static double Calculator(double num1, double num2, char operation)
        {
            double result = 0;
            if (operation == '+')
            {
                result = num1 + num2;
            }
            else if (operation == '-')
            {
                result = num1 - num2;
            }
            else if (operation == '*')
            {
                result = num1 * num2;
            }
            else if (operation == '/')
            {
                    result = num1 / num2;
            }
            else
            {
                Console.WriteLine("The operator is incorrect!");
            }
            Console.WriteLine("\n" + num1 + " " + operation + " " + num2 + " = " + result);
            return result;
        }
    }
}