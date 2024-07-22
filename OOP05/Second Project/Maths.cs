namespace OOP05.Second_Project
{
    internal static class Maths
    {
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public static double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }
        public static double Multiply(double num1, double num2)
        {

            return (num1 * num2);
        }
        public static double Divide(double num1, double num2)
        {
            if (num1 != 0)
            {
                return num1 / num2;
            }
            else
            {

                return -1;
            }

        }
    }
}
