/*
随机输入一个位数未知的整数,去除这个整数各个位上的 0,形成新的数,并输出.
输入的数字 n 大于 0,小于 1000000.
样例输入 20603 样例输出 23
 */
namespace 輸出未知整數各位2_修剪這個整數
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 20603;
            int result = 0; //預期結果變量
            int n = 1; //合法次數 標誌物
            int gewei;
            while (input != 0) //這裡我運用了debug window 監視we條件 while (input >0)
            {
                gewei = input % 10; //取得各個位數步驟1
                //接下來把每個合法位數存入預期結果變量
                if (gewei != 0)
                {
                    gewei *= n; //位數被標誌物賦值
                    result += gewei; //接收結果
                    n *= 10; //標誌物乘增. 每進來一個合法位數, 就乘以10以匹配它的位數值
                }
                input /= 10; //取得各個位數步驟2
            }
            Console.WriteLine(result);
        }
    }
}