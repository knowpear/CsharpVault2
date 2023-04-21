//#### “水仙花数”
//所谓“水仙花数“是指一个三位数,其各位数字立方等于该数本身.
//例如 153=1*1*1+5*5*5+3*3*3,所以 153 是“水仙花数”.
namespace 水仙花數
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////we方法 三循環 位數組成數字
            //int a; //百位
            //int b; //十位
            //int c; //個位
            //int flower;
            //int temp;
            //for (a = 1; a < 10; a++)
            //{
            //    for (b = 0; b < 10; b++) //別忘了0
            //    {
            //        for (c = 0; c < 10; c++)
            //        {
            //            flower = a *100 + b *10 + c;
            //            temp = a*a*a + b*b*b + c*c*c;
            //            if (flower == temp)
            //            {
            //                Console.WriteLine(flower);
            //            }
            //        }
            //    }
            //}

            //老師方法 數字拆解位數
            for (int i = 100; i < 1000; i++)
            {
                int gewei = i % 10;
                int shiwei = i / 10 % 10;
                int baiwei = i / 100;
                //Console.WriteLine(baiwei * 100 + shiwei * 10 + gewei); //閒的自己測試
                if (i == baiwei * baiwei * baiwei + shiwei*shiwei*shiwei + gewei * gewei * gewei)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}