using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;

namespace InstallSelfSign
{
    class Program
    {
        static void Main(string[] args)
        {
            PowerShell ps = PowerShell.Create();
            var result = ps.AddCommand("Set-ExecutionPolicy").AddArgument("RemoteSigned")
                           .AddScript("./SelfSignScript.ps1")
                           .AddCommand("Set-ExecutionPolicy").AddArgument("Restricted").Invoke();
           // Console.ReadLine();
        }
    }
}
