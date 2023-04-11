namespace Narcissistic_Number
{
    internal class Kata
    {
        public static bool Narcissistic(int value)
        {
            String valueStr = value.ToString();
            Double[] digits = new double[valueStr.Length];
            Double sum = 0;
            for (int i = 0; i < valueStr.Length; i++)
            {
                digits[i] = Math.Pow(double.Parse(valueStr[i].ToString()), valueStr.Length) ;
                Console.WriteLine(digits[i]);
                sum += digits[i];
            }
            return (value == sum);
        }
    }
}
