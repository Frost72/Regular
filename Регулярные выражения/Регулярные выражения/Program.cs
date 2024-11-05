using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using System.Xml;

namespace Регулярные_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern= @"\b\d{4}/\d{2}/\d{2} \d{2}:\d{2}(:\d{2})?\b";
            string htmlFile = @"C:\лаба.html";
            StreamReader sr = new StreamReader(htmlFile);
            string htmlContent = sr.ReadToEnd();
            htmlContent = Regex.Replace(htmlContent, pattern, "<i>$&</i>");
            File.WriteAllText(@"C:\лаба1.html", htmlContent);
            Console.WriteLine(htmlContent);
            Console.ReadLine();
        }
    }
}
