//#### 输入一个整数 a,和一个正整数 n,计算乘方 a 的 n 次方.
namespace 求平方
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("計算a的n次方, 請輸入正整數a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("請輸入正整數n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int result = 1; //注意這裡的初始值不能是0
            for (int i = 0; i < n; i++)
            {
                result *= a;
            }
            Console.WriteLine("{0}的{1}次方結果是: {2}", a, n, result);
            Console.ReadKey();
        }
    }
}