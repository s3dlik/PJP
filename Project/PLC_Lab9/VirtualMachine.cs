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
        private Dictionary<string, Helper> variables = new();
        public VirtualMachine(string code)
        {
            this.code=code.Split("\n\r".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
        }
        public void Run()
        {

            foreach(var instruction in this.code)
            {
                string[] identifier;
                if (instruction.Contains("\""))
                {
                    var parts = instruction.Split("\"");
                    identifier = parts[0].Split(' ');
                    identifier[2] = parts[1];

                }
                else
                {
                    identifier= instruction.Split(" ");
                }
                var word = instruction.Split(" ")[0];

                switch (identifier[0])
                {
                    case "push":                     
                        Push(identifier);
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

                        Read(identifier[1]);
                        break;
                    case "gt":
                        GT();
                        break;
                    case "label":
                        break;
                    case "save":
                        Save(identifier[1]);
                        break;
                    case "load":
                        Load(identifier[1]);
                        break;
                    case "eq":
                        EQ();
                        break;
                    case "not":
                        NOT();
                        break;
                    case "or":
                        OR();
                        break;
                    case "and":
                        AND();
                        break;
                    case "lt":
                        LT();
                        break;

                }
            }
        }


        public void Push(string[] instructions)
        {
            Helper helper = new();
            //var tmp = instructions[];
            helper.Value = instructions[2];
            helper.Type = instructions[1];
            //helper.Value = instruction.Split(' ')[2];
            //helper.Type = instruction.Split(' ').Skip(1).FirstOrDefault();
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

        public void Read(string input)
        {
            Helper helper = new();
            switch (input)
            {
                case "I":
                    helper.Type = "I";
                    helper.Value = Console.ReadLine();
                    break;
                case "F":
                    helper.Type = "F";
                    helper.Value = Console.ReadLine();
                    break;
                case "S":
                    helper.Type = "S";
                    helper.Value = Console.ReadLine();
                    break;
                case "B":
                    helper.Type = "B";
                    helper.Value = Console.ReadLine();
                    break;
            }
            stack.Push(helper);
        }

        public void Pop()
        {
            //stack.Pop();
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
                var output = rightSide.Value + leftSide.Value;
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

            }
            stack.Push(helper);
        }

        public void OR()
        {
            Helper helper = new();
            var leftSide = stack.Pop();
            var rightSide = stack.Pop();

            if (leftSide.Type == "B" || rightSide.Type == "B")
            {
                var output = bool.Parse(leftSide.Value) && bool.Parse(rightSide.Value);
                helper.Value = output.ToString();

            }
            stack.Push(helper);
        }
        public void GT()
        {
            Helper helper = new();
            var leftSide = stack.Pop();
            var rightSide = stack.Pop();

            if ((leftSide.Type == "I" || leftSide.Type == "F") && (rightSide.Type == "F"||rightSide.Type == "I"))
            {
                var output = decimal.Parse(rightSide.Value) > decimal.Parse(leftSide.Value);
                helper.Value = output.ToString();
                stack.Push(helper);
            }
        }
        public void LT()
        {
            Helper helper = new();
            var leftSide = stack.Pop();
            var rightSide = stack.Pop();

            if ((leftSide.Type == "I" || leftSide.Type == "F") && (rightSide.Type == "F" || rightSide.Type == "I"))
            {
                var output = decimal.Parse(rightSide.Value) < decimal.Parse(leftSide.Value);
                helper.Value = output.ToString();
                stack.Push(helper);
            }
        }

        public void EQ()
        {
            Helper helper = new();
            var leftSide = stack.Pop();
            var rightSide = stack.Pop();

            if((leftSide.Type == "I" || leftSide.Type == "F") && (rightSide.Type == "I" || rightSide.Type == "F"))
            {
                if(leftSide.Value == rightSide.Value)
                {
                    helper.Value = "True";
                }
                else
                {
                    helper.Value = "False";
                }
            }
            else if(leftSide.Type == "S")
            {
                if(leftSide.Value == rightSide.Value)
                {
                    helper.Value = "True";
                }
                else
                {
                    helper.Value = "False";
                }
            }
            helper.Type = "B";
            stack.Push(helper);
        }
        public void NOT()
        {
            Helper helper = new();
            var value = stack.Pop();
            if (value.Type == "B")
            {
                var output = !bool.Parse(value.Value);
                helper.Value = output.ToString();
                stack.Push(helper);
            }
        }

        public void ITOF()
        {
            Helper helper = new();
            var value = stack.Pop();
            if(value.Type == "I")
            {
                helper.Type = "F";
                helper.Value = float.Parse(value.Value).ToString() ;
                stack.Push(helper);
            }
        }
        public void Save(string input)
        {
            var val = stack.Pop();
            if (variables.ContainsKey(input))
            {
                variables[input] = val;
            }
            else
                variables.Add(input, val);
        }

        public void Load(string input)
        {
            if (variables.ContainsKey(input))
            {
                stack.Push(variables[input]);
            }
        }
    }
}
