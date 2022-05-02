
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System;
using System.Globalization;
using System.IO;
using System.Threading;

namespace PLC_Lab9
{
    public class Program
    {
        //check this before showing https://github.com/antlr/antlr4/blob/master/doc/index.md
        public static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            var fileName = "errors.txt";
            Console.WriteLine("Parsing: " + fileName);
            var inputFile = new StreamReader(fileName);
            AntlrInputStream input = new AntlrInputStream(inputFile);
            PLC_Lab9_exprLexer lexer = new PLC_Lab9_exprLexer(input);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            PLC_Lab9_exprParser parser = new PLC_Lab9_exprParser(tokens);

            parser.AddErrorListener(new VerboseListener());

            IParseTree tree = parser.prog();

            if (parser.NumberOfSyntaxErrors == 0)
            {
                //Console.WriteLine(tree.ToStringTree(parser));
              
                var result = new EvalVisitor().Visit(tree);
                Console.WriteLine(result.Value);
                VirtualMachine vm = new VirtualMachine(result.Value);
                vm.Run();
            }
        }
    }
}