using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File类
{
    class Program
    {
        static void Main(string[] args)
        {
           /* File.Create(@"C:\Users\Robot_417\Desktop\new.txt"); //这是一个静态类 而且包含在头文件System.IO*/
            
             
            //这样就生成了一个新的new.txt文件 创建了文件以后在创建就是修改了
            Console.WriteLine("创建成功");

            //删除文件而且是彻底删除
            File.Delete(@"C:\Users\Robot_417\Desktop\new.txt");

            /*向空文件中添加东西*/



        }
    }
}
