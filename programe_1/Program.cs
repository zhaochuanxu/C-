using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programe_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a programe");
            Console.ReadKey();//暂停 吃一个空格
            String max="This is Max";
            Console.WriteLine(max);
            int a = 3;
            Console.WriteLine("THE VALUE IS {0} {1}", max, a); //占位符索引要从0 开始 像数组
            Console.ReadKey();
            Console.WriteLine("这是一个转义字符"+ "\"\""); // \b把之前的删除了  放字符串两端不起效果
        }
    }
}
