using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLC_Lab9
{
    public class VirtualMachine
    {
        private Stack<Helper> stack = new Stack<Helper>();
        private List<string> code = new List<string>();
        public VirtualMachine(string code)
        {
            this.code=code.Split("\n\r".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
        }
        public void Run()
        {

            foreach(var instruction in this.code)
            {
                var word = instruction.Split(" ")[0];

                switch (word)
                {
                    case "push":                     
                        Push(instruction);
                        break;
                    case "print":
                        var value = instruction.Split(" ")[1];
                        Print(value);
                        break;
                    case "add":
                        Add();
                        break;
                    case "sub":
                        Sub();
                        break;
                    case "div":
                        Div();
                        break;
                    case "mul":
                        Mul();
                        break;
                    case "mod":
                        Mod();
                        break;
                    case "pop":
                        Pop();
                        break;
                    case "uminus":
                        Uminus();
                        break;
                    case "concat":
                        Concat();
                        break;
                    case "read":
                        Read();
                        break;
                }
            }
        }


        public void Push(string instruction)
        {
            Helper helper = new();
            
            helper.Value = instruction.Split(' ')[2];
            helper.Type = instruction.Split(' ').Skip(1).FirstOrDefault();
            stack.Push(helper);

        }

        public void Print(string instruction) {
            int counter = 0;
            int.TryParse(instruction,out counter);
            if(counter > 0)
            {
                for (int i = 0; i < counter; i++)
                {
                    var tmp = stack.Pop();
                    Console.WriteLine(tmp.Value);
                }
            }
        }

        public void Read()
        {

        }

        public void Pop()
        {
            stack.Pop();
        }

        public void Mul()
        {
            var leftSide = stack.Pop();
            var rightSide = stack.Pop();
            Helper helper = new();

            if ((leftSide.Type == "I" || rightSide.Type == "F") && (leftSide.Type == "F" || rightSide.Type == "I"))
            {
                var result = decimal.Parse(leftSide.Value) * decimal.Parse(rightSide.Value);

                if (leftSide.Type == "I" && rightSide.Type == "I")
                {
                    helper.Value = ((int)result).ToString();
                    helper.Type = "I";
                }
                else
                {
                    helper.Value = ((float)result).ToString();
                    helper.Type = "F";
                }
                stack.Push(helper);
            }
        }

        public void Sub()
        {
            var leftSide = stack.Pop();
            var rightSide = stack.Pop();
            Helper helper = new();

            if ((leftSide.Type == "I" || rightSide.Type == "F") && (leftSide.Type == "F" || rightSide.Type == "I"))
            {
                var result = decimal.Parse(leftSide.Value) - decimal.Parse(rightSide.Value);

                if (leftSide.Type == "I" && rightSide.Type == "I")
                {
                    helper.Value = ((int)result).ToString();
                    helper.Type = "I";
                }
                else
                {
                    helper.Value = ((float)result).ToString();
                    helper.Type = "F";
                }
                stack.Push(helper);
            }
        }

        public void Div()
        {
            var rightSide = stack.Pop();
            var leftSide = stack.Pop();
            Helper helper = new();

            if ((leftSide.Type == "I" || rightSide.Type == "F") && (leftSide.Type == "F" || rightSide.Type == "I"))
            {
                var result = decimal.Parse(leftSide.Value) / decimal.Parse(rightSide.Value);

                if (leftSide.Type == "I" && rightSide.Type == "I")
                {
                    helper.Value = ((int)result).ToString();
                    helper.Type = "I";
                }
                else
                {
                    helper.Value = ((float)result).ToString();
                    helper.Type = "F";
                }
                stack.Push(helper);
            }
        }
        public void Mod()
        {
            var leftSide = stack.Pop();
            var rightSide = stack.Pop();
            Helper helper = new();
            var result = decimal.Parse(leftSide.Value) % decimal.Parse(rightSide.Value);
            if (leftSide.Type == "I" && rightSide.Type == "I")
            {
                helper.Value = ((int)result).ToString();
                helper.Type = "I";
            }
        
            stack.Push(helper);
     
            
        }
        public void Add()
        {
            var leftSide = stack.Pop();
            var rightSide = stack.Pop();
            Helper helper = new();

            if ((leftSide.Type == "I" || rightSide.Type == "F") && (leftSide.Type == "F" || rightSide.Type =="I"))
            {
                var result = decimal.Parse(leftSide.Value) + decimal.Parse(rightSide.Value);

                if(leftSide.Type == "I" && rightSide.Type == "I")
                {
                    helper.Value = ((int)result).ToString();
                    helper.Type = "I";
                }
                else
                {
                    helper.Value = ((float)result).ToString();
                    helper.Type = "F";
                }
                stack.Push(helper);
            }
        }
        public void Uminus()
        {
            Helper helper = new();
            var leftSide = stack.Pop();
            if(leftSide.Type == "I")
            {
                var tmp = int.Parse(leftSide.Value);
                tmp *= -1;
                helper.Value = tmp.ToString() ;
                helper.Type = "I";
            }
            else if(leftSide.Type == "F")
            {
                var tmp = float.Parse(leftSide.Value);
                tmp *= -1;
                helper.Value = tmp.ToString();
                helper.Type = "F";
            }
            stack.Push(helper);
        }

        public void Concat()
        {
            var leftSide = stack.Pop();
            var rightSide = stack.Pop();
            Helper helper = new();
            if(leftSide.Type == "S" && rightSide.Type == "S")
            {
                var output = leftSide.Value + rightSide.Value;
                helper.Value = output;
                helper.Type = "S";
            }
            stack.Push(helper);
        }

        public void AND()
        {
            Helper helper = new();
            var leftSide = stack.Pop();
            var rightSide = stack.Pop();

            if (leftSide.Type == "B" && rightSide.Type == "B")
            {
                var output = bool.Parse(leftSide.Value) && bool.Parse(rightSide.Value);
                helper.Value = output.ToString();
                helper.Type = "B";

            }
            stack.Push(helper);
        }

        public void OR()
        {

        }
        public void GT()
        {

        }
        public void LT()
        {

        }

        public void EQ()
        {

        }
        public void NOT()
        {

        }
    }
}
