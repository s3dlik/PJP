using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLC_Lab9
{
    public class EvalVisitor : PLC_Lab9_exprBaseVisitor<Helper>
    {
        StringBuilder sb = new StringBuilder();
        public override Helper VisitInt([NotNull] PLC_Lab9_exprParser.IntContext context)
        {
            Helper helper = new();
            helper.Value = Convert.ToInt32(context.INT().GetText(), 10).ToString();
            helper.Type = context.INT().GetType().ToString();
            return helper;
        }
        /*
        public override string VisitHexa([NotNull] PLC_Lab9_exprParser.HexaContext context)
        {
            var value = Convert.ToInt32(context.HEXA().GetText(), 16);
            return $"PUSH {value}\n";
        }
        public override string VisitOct([NotNull] PLC_Lab9_exprParser.OctContext context)
        {
            var value = Convert.ToInt32(context.OCT().GetText(), 8);
            return $"PUSH {value}\n";
        }*/
        public override Helper VisitPar([NotNull] PLC_Lab9_exprParser.ParContext context)
        {
            return Visit(context.expression());
        }
        public override Helper VisitAdd([NotNull] PLC_Lab9_exprParser.AddContext context)
        {
            Helper helper = new();
            var left = Visit(context.expression()[0]);
            var right = Visit(context.expression()[1]);
            if (left.Value != null || left.Type != null)
            {
                sb.AppendLine();
            }

            if (context.op.Text.Equals("+"))
            {
                
                helper.Value = (left.Value + right.Value).ToString() + "ADD\n";
                helper.Type = helper.Value.GetType().ToString();
                sb.AppendLine("ADD");
            }
            else
            {
                helper.Value = (left.Value + right.Value).ToString() + "SUB\n";
                helper.Type = helper.Value.GetType().ToString() ;
                sb.AppendLine("SUB");
            }
            return helper;
        }
        public override string VisitMul([NotNull] PLC_Lab9_exprParser.MulContext context)
        {
            var left = Visit(context.expression()[0]);
            var right = Visit(context.expression()[1]);
            if (context.op.Text.Equals("*"))
            {
                return left + right + "MUL\n"; 
            }
            else
            {
                return left + right + "DIV\n";
            }
        }
        public override string VisitProg([NotNull] PLC_Lab9_exprParser.ProgContext context)
        {
            StringBuilder sb = new StringBuilder();
            /*
            foreach (var expr in context.expression())
            {
                var code = Visit(expr);
                sb.Append(code);
                sb.AppendLine("PRINT");
            }*/
            return sb.ToString();
        }
    }
}
