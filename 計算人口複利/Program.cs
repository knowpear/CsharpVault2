//我国现有 k 亿人口,按照每年 0.1%的增长速度, n 年后将有多少人?
namespace 計算人口複利
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double k = 10; //10億人口
            int n = 100; //年
            double kFuture = k; //未來人口方法1
            double kFutrue2 = k; //未來人口方法2
            for (int i = 0; i < n; i++)
            {
                //寫法1
                kFuture *= 1.001;
                //寫法2 準確性待驗證
                kFutrue2 = kFutrue2 + kFutrue2 * 0.001; //kFutrue2 += kFutrue2 * 0.001;等同同行前句
            }
            Console.WriteLine(kFuture);
            Console.WriteLine(kFutrue2);
        }
    }
}