using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] my = Process.GetProcesses();
            foreach (var i in my) 
            {
                if (i.ProcessName == "LolClient"||i.ProcessName=="lol.launcher_tencent"||i.ProcessName=="Client") 
                {
                label1:Console.WriteLine("发现英雄联盟残留进程，是否杀掉？");
                    string state = Console.ReadLine();

                    if (state != "y")
                    {
                        goto label1;
                    }
                    else
                        i.Kill();
                        goto label2;
                }
                    
            }
        label2: Console.WriteLine("全部杀掉，感谢使用");
        }
    }
}
