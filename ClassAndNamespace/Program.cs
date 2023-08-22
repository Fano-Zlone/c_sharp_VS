using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools;

namespace ClassAndNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1");
            System.Console.WriteLine("2");


            Console.WriteLine("add:{0}", Calculator.Add(1, 2));
            Console.WriteLine("div:{0}", Calculator.Div(1, 2));
            Console.WriteLine("mul:{0}", Calculator.Mul(1, 2));
            Console.WriteLine("sub:{0}", Calculator.Sub(1, 2));

            Form form = new Form();
            form.ShowDialog();
        }
    }
}
//学习引用库，外部库（浏览）
//添加网络NuGet库，EntityFramework

//把自建库添加到solution中，然后项目引用，可以进行实时debug——Root cause

/*依赖关系：
类之间的耦合关系
好的程序追求“高内聚，低耦合”
UML类图，通用建模语言*/
