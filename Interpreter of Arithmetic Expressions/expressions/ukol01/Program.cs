using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ukol01
{
    class Program
    {
        static char[] expressions = { '+', '-', '*', '/' };

        static string removeSpaces(string line) {
            if (line.Contains(" "))
            {
                line = line.Replace(" ", "");
                return line;
            }
            return line;
        }

        static string getResultOperator(string line) {
            int index = 0;
            string firstNum = null;
            string secondNum = null;
            string anotherNum = null;
            string operat = null;
            int startIndex = 0;

            int lparCount = line.Count(par => par == '(');
            int pparCount = line.Count(par => par == ')');


            while (true) {
                
                while (index != line.Length) 
                {
                    //first number
                    if (((line[index] >= '0' && line[index] <= '9')) && (firstNum == null))
                    {
                        while (line[index] >= '0' && line[index] <= '9')
                        {
                            firstNum += line[index++];
                            startIndex++;
                            if (index >= line.Length) { break; }
                        }
                    }
                    //second number
                    else if (((line[index] >= '0' && line[index] <= '9')) && (secondNum == null))
                    {
                        while (line[index] >= '0' && line[index] <= '9')
                        {
                            secondNum += line[index++];
                            startIndex++;
                            if (index >= line.Length) { break; }
                        }
                    }
                    //another number
                    else if (((line[index] >= '0' && line[index] <= '9')) && (anotherNum == null))
                    {
                        while (line[index] >= '0' && line[index] <= '9')
                        {
                            anotherNum += line[index++];
                            startIndex++;
                            if (index >= line.Length) { break; }
                        }
                    }
                    //first operator
                    else if (((line[index] == '*' || line[index] == '/' || line[index] == '+' || line[index] == '-')) && (operat == null))
                    {
                        operat = line[index++].ToString();
                        startIndex++;
                        if (index >= line.Length) { Console.WriteLine("error"); return "err"; }
                    }
                    //other operators
                    else if (((operat == "+") || (operat == "-")) && ((line[index] == '/') || (line[index] == '/')))
                    {
                        if (anotherNum != null)
                        {
                            firstNum = anotherNum;
                            anotherNum = null;
                        }
                        else { firstNum = secondNum; }

                        secondNum = null;
                        operat = line[index].ToString();
                        startIndex++;
                        index++;

                        if (index >= line.Length)
                        {
                            Console.WriteLine("err");

                        }
                    }
                    else if (line[index] == '(')
                    {
                        firstNum = null;
                        secondNum = null;
                        operat = null;

                        index++;
                    }
                    else if (line[index] == ')')
                    {
                        index++;
                        break;
                    }
                    else
                    {
                        index++;
                    }
                }

                if (secondNum == null)
                {
                    return firstNum;
                }

                if (lparCount != pparCount) {
                    Console.WriteLine("different count of brackets!");
                    return "error";
                }

                

                string result = doMathStr(int.Parse(firstNum), int.Parse(secondNum), char.Parse(operat));
                //nalezena chyba pri prikladu 6 * 2 + (5 - 3) * 3 - 8 to sice prvni udela zavorku, ale potom to normalne pocita zleva doprava, tudiz misto vysledku 10 je to 34

                line = line.Replace(firstNum+operat+secondNum,result);
                if (int.Parse(result) < 0) {
                    Console.WriteLine("bad expression");
                    return "ERROR";
                }
                if ((lparCount > 0) && line.Contains("(" + int.Parse(result) + ")"))
                {
                    line = line.Replace("(" + result + ")", result);
                    lparCount--;
                    pparCount--;
                }

                firstNum = null;
                secondNum = null;
                anotherNum = null;
                operat = null;
                index = 0;
            }
        }

        static string doMathStr(int a, int b, char operation)
        {
            
            switch (operation)
            {
                case '*':
                    return (a * b).ToString();
                case '+':
                    return (a + b).ToString();

                case '-':
                    return (a - b).ToString();
      
                case '/':
                    return (a / b).ToString();
                default:
                    return "si kojot";
 
            }
        }
        static int calculate(string line)
        {
            List<string> znamenka = new List<string>();
            int startIndex, endIndex;
            int a, b;
            int result = 0;
            char operation;
            string nwm = null;

  
            nwm = getResultOperator(line);
            if (nwm == "ERROR")
            {
                Console.WriteLine("Error in computing expression");
                Environment.Exit(0);
            }
            else { 
                return int.Parse(nwm);
            }
            return 0;
        }

        static void Main(string[] args)
        {
            bool contin = true;
            while (contin) {
                
                bool userInput = false;
                int countings = 0;
                while (userInput == false) {
                    try
                    {
                        Console.WriteLine("How many countings you want? Type number");
                        countings = int.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    if (countings >= 1)
                    {
                        userInput = true;
                    }
                }


                for (int i = 0; i < countings; i++)
                {
                    string line;
                    Console.WriteLine("Enter matemathical operation");
                    line = Console.ReadLine();
                    if (string.IsNullOrEmpty(line)) {
                        Console.WriteLine("Empty input!");
                        Environment.Exit(0);
                    }
                    string lineWithoutSpaces = removeSpaces(line);
                    if (lineWithoutSpaces[0] == '-' || lineWithoutSpaces[0] == '+' || lineWithoutSpaces[0] == '/' || lineWithoutSpaces[0] == '*') { Console.WriteLine("You cannot use negative integer!"); Environment.Exit(0); }

                    int tmp = calculate(lineWithoutSpaces);
                    Console.WriteLine($"result: {tmp}");
                    
                }

                Console.WriteLine("Do you want to continue? If yes, type yes, otherwise type anything to exit\n");
                string answer = Console.ReadLine();
                if (answer.ToLower().Contains("yes") || answer.ToUpper().Contains("YES"))
                {
                    contin = true;
                }
                else
                {
                    contin = false;
                }


            }
        }
    } 
}
