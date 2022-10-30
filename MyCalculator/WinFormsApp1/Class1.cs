using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    internal class Class1
    {
        public string calculate(string s)
        {
            Regex regex = new Regex(@"([+, -])?(\d+)([+, \-, *, /])(\d+)");
            if (regex.IsMatch(s))
            {
                switch (regex.Match(s).Groups[3].Value)
                {
                    case "+": return sum(regex.Match(s).Groups[1].Value + regex.Match(s).Groups[2].Value, regex.Match(s).Groups[4].Value).ToString();
                    case "-": return minus(regex.Match(s).Groups[1].Value + regex.Match(s).Groups[2].Value, regex.Match(s).Groups[4].Value).ToString();
                    case "*": return myltiply(regex.Match(s).Groups[1].Value + regex.Match(s).Groups[2].Value, regex.Match(s).Groups[4].Value).ToString();
                    case "/": return divide(regex.Match(s).Groups[1].Value + regex.Match(s).Groups[2].Value, regex.Match(s).Groups[4].Value).ToString();
                }
            }
            return "";
        }

        public int sum(string a, string b)
        {
            return int.Parse(a) + int.Parse(b);
        }
        public int minus(string a, string b)
        {
            return int.Parse(a) - int.Parse(b);
        }
        public int myltiply(string a, string b)
        {
            return int.Parse(a) * int.Parse(b);
        }
        public int divide(string a, string b)
        {
            return int.Parse(a) / int.Parse(b);
        }
    }
}
