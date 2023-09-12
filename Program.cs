using System;
using System.Collections.Generic;

namespace ONP
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] result = new string[n];
            for (int a=0;a<n;a++)
            {
                Stack<char> Mystack = new Stack<char>();
                string line= Console.ReadLine();
                for (int i=0; i < line.Length;i++)
                {
                    if(line[i]>='a' && line[i]<='z')
                        result[a] += line[i].ToString();
                    else if (line[i] == ')')
                    {
                        result[a] += Mystack.Peek().ToString();
                        Mystack.Pop();
                    }
                    else if (line[i] != '(')
                        Mystack.Push(line[i]);
                }
            }
            foreach (var a in result)
                Console.WriteLine(a);
        }
    }
}
