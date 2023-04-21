/*
输入任意一个位数未知的整数,输出这个数每一位上的数字.输出的时候,从个位开始输出,每输出一个数字换一行.
输入:3432 输出:
2
3
4
3
 */
namespace 輸出未知整數各位
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 3432;
            while (input %10 != 0) //等於0, 即可以只剩一位的時候, 終止
            {
                int gewei = input %10; //求得各位
                Console.WriteLine(gewei);
                input /=10; //各位撇了不要了, 繼續
            }
        }
    }
}