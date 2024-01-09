namespace Maths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 3;
            double y = 5;

            double a = Math.Pow(x, 3);        // Will be to the power of the following number, in this case to power of 3
            double b = Math.Sqrt(x);          // Will find the square root of x
            double c = Math.Abs(x);           // Will find absolute value of x, the number to get to 0 so in this case 3
            double d = Math.Round(x);         // Will round a decimal to nearest whole number
            double e = Math.Ceiling(x);       // Will round a decimal up to the nearest whole number
            double f = Math.Floor(x);         // Will round decimal down to nearest whole number 
            double g = Math.Max(x, y);        // Will find biggest number 
            double h = Math.Min(x, y);        // Will find smallest number

            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
