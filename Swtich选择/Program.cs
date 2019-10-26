using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swtich选择
{
    class Program
    {
        static void Main(string[] args)
        {/*
            int a = 0;
            bool b=true;
            char c;
            try  //如果try出现异常直接不执行后边的代码 而是执行catch
            {
                Console.WriteLine("请输入老师的工资");
                a = Convert.ToInt32(Console.Read());
                
            }
            catch
            {
                Console.WriteLine("输入错误，请重新输入");
                Console.ReadKey();
            }

            if(b) //没有发生异常
            {
                if (a < 4000) { c = 'a'; }
                else if (a>=4000&&a<5400) { c='b';}
                else if(a>=5400&&a<7200){c='c';}
                else { c = 'd'; }
                switch (c)
                {
                    case 'a': 
                        Console.WriteLine("该老师职称为讲师");
                        break;
                    case 'b':
                        Console.WriteLine("该老师职称为副教授");
                            break;
                    case 'c':
                        Console.WriteLine("该老师职称为教授");
                        break;
                    case 'd':
                        Console.WriteLine("该老师职称为赵传旭");
                        break;
                    default:
                        Console.WriteLine("该老师是垃圾");
                        break;


                }
                Console.ReadKey();

            }
        */
            //判断某年月份有多少天



            /*两个连续的try*/

            bool b = true;
            int year = 0;
            int month = 0;
            int day = 0;

            try
            {
                Console.WriteLine("请输入年份");
                year = Convert.ToInt32(Console.ReadLine()); //这里注意Read和ReadLine()区别


                try
                {
                    /*Console.ReadKey();*/
                    Console.WriteLine("请输入月份");
                    month = Convert.ToInt32(Console.ReadLine());



                    switch (month)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 9:
                        case 10:
                        case 12:
                            day = 31;
                            break;
                        case 2:
                            if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                            {
                                day = 29;
                            }
                            else
                            {
                                day = 28;
                            }
                            break;
                        default:
                            day = 30;
                            break;

                    }
                    Console.WriteLine("{0}年{1}月为{2}天", year, month, day);
                    Console.ReadKey();
                }
                catch
                {
                    Console.WriteLine("输入月份有误");

                    Console.ReadKey();

                }
            }
            catch
            {
                Console.WriteLine("输入年份有误");

                Console.ReadKey();

            }

        }
        
    }
}
//两个try嵌套使用