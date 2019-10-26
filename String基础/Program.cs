using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String基础
{
    class Program
    {
        static void Main(string[] args)
        {
                /*
                //下边就是对比String和StringBuilder类对象变与不变 各种操作的对比
                String s = "abc"; //普通的String 构造出来的对象是没没有其他的方法的因为是不可变的
                StringBuilder Ss = new StringBuilder("ABC");

                Stopwatch sw = new Stopwatch();
                Stopwatch sw_1 = new Stopwatch();
                sw.Start();
                for (int i = 0; i < 100000;i++ )
                {

                    Ss.Append(i+'0');
                }
                sw.Stop();
                Console.WriteLine(sw.Elapsed+"\n");//这个属性就是获取当前实例所运行的具体时间

                sw_1.Start();
                for (int i = 0; i < 100000; i++)
                {

                    s += i;
                }
                sw_1.Stop();
                Console.WriteLine( sw_1.Elapsed + "\n");
                Console.ReadKey();
            //上边两个总是存在着差距 差距就出现在开空间运行单位越大时间差距越多
        */

            //为什么StringBuiilder比String要快呢 因为 StringNBuilder不用开空间 


            /*
            String s ="null";   //String 和 string的区别 string是一个关键字 而String是一个类
            s += 1;
            Console.WriteLine(s);
            Console.ReadKey();
            */

            //最后我们还是希望得到的是string 还要转
            /*StringBuilder s = new StringBuilder("a");
            s.Append("euc");
            s.ToString();
            Console.WriteLine(s);
            Console.ReadKey();
             * */

           
            //练习一 输入一个string 得出长度利用Length属性
                //string s = Console.ReadLine();
                //Console.WriteLine(s.Length + "\n");
                //Console.ReadKey();



            //一切类型都可以通过ToString转化为string类型
            int a = 3;
            a.ToString();
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
