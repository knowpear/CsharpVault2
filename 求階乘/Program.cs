namespace 求階乘
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("求階乘, 請輸入一個正整數");
            int result = 1;
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < input + 1; i++)
            {
                result *= i;
            }
            Console.WriteLine("結果是: " + result);
        }
    }
}