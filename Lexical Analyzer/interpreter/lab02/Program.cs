// See https://aka.ms/new-console-template for more information

using System;

namespace lab02 {
    
    internal class Program
    {
        static char[] operators = {'+', '-', '*', '/' };
        string[] delimiters = { "(", ")", ";" };
        static string[] keywords = {  "mod" , "div"};

        static string removeWhiteSpaces(string line) {
            return line.Replace(" ", "");
        }

        static void doOperations(string line) {
            string numberStr = string.Empty;
            string others = string.Empty;

            for (int i = 0; i < line.Length; i++)
            {

                if (line[i] == '(')
                {
                    Console.WriteLine("LPAR");
                    continue;
                }
                if (line[i] == ')')
                {
                    Console.WriteLine("RPAR");
                    continue;
                }
                if (line[i] == ';')
                {
                    Console.WriteLine("SEMICOLON");
                }
                if (line[i] >= '0' && line[i] <= '9')
                {
                    if (!(line[i + 1] >= '0' && line[i + 1] <= '9'))
                    {
                        numberStr += line[i];
                        Console.WriteLine($"NUM: {numberStr}");
                        numberStr = string.Empty;
                    }
                    else
                    {
                        numberStr += line[i];
                    }
                }
                if ((line[i] >= 'a' && line[i] <= 'z') || (line[i] >= 'A' && line[i] <= 'Z'))
                {
                    if (i + 1 < line.Length)
                    {
                        if (((line[i + 1] >= 'a' && line[i + 1] <= 'z') || (line[i + 1] >= 'A' && line[i + 1] <= 'Z')))
                        {
                            others += line[i];
                        }
                        else
                        {
                            others += line[i];
                            if (others.Contains("div") || others.Contains("mod"))
                            {
                                others = string.Empty;

                            }
                            else
                            {
                                Console.WriteLine($"ID: {others}");
                                others = string.Empty;
                            }
                        }
                    }
                    else {
                        others += line[i];
                        Console.WriteLine($"ID: {others}");
                    }
                }
                foreach (var item in operators)
                {
                    if (line[i] == item)
                    {
                        Console.WriteLine($"OP: {item}");
                    }
                }

                foreach (var item in keywords)
                {
                    if (i + item.Length > line.Length)
                    {
                        break;
                    }
                    var subStr = line.Substring(i, item.Length);
                    if (subStr == item)
                    {
                        Console.WriteLine(subStr);
                    }
                }
            }
        }

        static void handleTokens(string line) {

            string lineWithoutSpaces = removeWhiteSpaces(line);
            string newStr = string.Empty;
            string result = string.Empty;
            if (lineWithoutSpaces.Contains("//"))
            {
                result = line.Split("//").Last();
                newStr = line.Split("//").First();
                result = result.Replace(" ", "");
            }

            if (!string.IsNullOrEmpty(newStr))
            {
                doOperations(newStr);
            }
            else {
                doOperations(lineWithoutSpaces);
            }

            if (!string.IsNullOrEmpty(result)) {
                Console.WriteLine($"NOTE: {result.ToUpper()}");
            }
            
        }
        static void Main(string[] args) {
            Console.WriteLine("How many lexical senteces you want to input?");
            int countings = 0;
            try
            {
                 countings= int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
           
            for (int i = 0; i < countings; i++)
            {
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("empty input, exiting program");
                    Environment.Exit(1);
                }
                else {
                    handleTokens(input);
                }
            }
        }
    }
}
