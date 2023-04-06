//输入 q 和 n,求下面公式的结果.
//q1 + q2 + q3 + ..+qn
namespace q的n次方再求和
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int q = 3;
            int n = 3;
            int fang = 1;
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                fang *= q;
                result += fang;
            }
            Console.WriteLine("結果是: " + result);
        }
    }
}