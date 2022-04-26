using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLC_Lab9
{
    public class VirtualMachine
    {
        private Stack<int> stack = new Stack<int>();
        private List<string> code = new List<string>();
        public VirtualMachine(string code)
        {
            //this.code=code.Split("\n\r".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
        }
        public void Run()
        {/*
            foreach(var instruction in this.code)
            {
                if (instruction.StartsWith("PUSH")) {
                    var value = int.Parse(instruction.Split(" ")[1]);
                    stack.Push(value);
                }else if (instruction.Equals("PRINT"))
                {
                    Console.WriteLine(stack.Pop());
                }else
                {
                    var right = stack.Pop();
                    var left = stack.Pop();
                    var value = instruction switch
                    {
                        "ADD" => left + right,
                        "SUB" => left - right,
                        "MUL" => left * right,
                        "DIV" => left / right,
                        _ => throw new Exception("Unexpected operation")
                    };
                    stack.Push(value);
                }
            }*/
        }
    }
}
