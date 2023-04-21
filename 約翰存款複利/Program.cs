/*
农夫约翰已知投资的
复合年利率为 R (0 到 20 之间的整数).
约翰现有总值为 M 的钱 (100 到 1,000,000 之间的整数).
他清楚地知道自己要投资 Y 年 (范围 0 到 400).
请帮助他计算最终他会有多少钱, 并输出它的整数部分.数据保证输出结果在 32 位有符号整数范围内.
输入三个整数 R, M, Y, 输出整数, 即最终拥有多少钱.
*/
namespace 約翰存款複利
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int R = 20; //復合年化
            int M = 100000; //錢數: 元
            int M2 = 100000; //錢數: 元
            int n = 40; //年限
            for (int i = 0; i < n; i++)
            {
                //we寫法
                M = (int)(M * (1 + R / 100.0)); //這裡的100.0很重要
                //老師寫法
                M2 = (int)(M2 * ((R / 100.0) + 1));
            }
            Console.WriteLine(M);
            Console.WriteLine(M2);
        }
    }
}