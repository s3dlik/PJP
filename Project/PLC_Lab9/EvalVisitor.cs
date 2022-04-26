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
            helper.Value = Convert.ToInt32(context.INT().GetText()).ToString();
            helper.Type = "I";
            return helper;
        }

        public override Helper VisitFloat([NotNull] PLC_Lab9_exprParser.FloatContext context)
        {
            Helper helper = new();
            helper.Value = Convert.ToDecimal(context.FLOAT().GetText()).ToString();
            helper.Type = "F";
            return helper;
        }
        /*
        public override Helper VisitConstant([NotNull] PLC_Lab9_exprParser.ConstantContext context)
        {
            
            if(context.INTEGER() != null)
            {
                sb.AppendLine("PUSH I: " + context.INTEGER().GetText().ToString());
            }
            else if (context.FLOAT() != null)
            {
                sb.AppendLine("PUSH F: " + context.FLOAT().GetText().ToString());
            }
            
            return base.VisitConstant(context);
        }*/
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
                sb.AppendLine("PUSH: " + left.Type + " " + left.Value);
            }
            if (right.Value != null || right.Type != null)
            {
                sb.AppendLine("PUSH: " + right.Type + " " + right.Value);
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
        public override Helper VisitMul([NotNull] PLC_Lab9_exprParser.MulContext context)
        {
            Helper helper = new();
            var left = Visit(context.expression()[0]);
            var right = Visit(context.expression()[1]);

            if (left.Value != null || left.Type != null)
            {
                sb.AppendLine("PUSH: " + left.Type  + left.Value);
            }
            if (right.Value != null || right.Type != null)
            {
                sb.AppendLine("PUSH: " + right.Type + right.Value);
            }

            if (context.op.Text.Equals("*"))
            {
                helper.Value = (left.Value + right.Value).ToString() + "MUL\n";
                helper.Type = helper.Value.GetType().ToString();
                sb.AppendLine("ADD");
            }
            else if (context.op.Text.Equals("%")){
                helper.Value = (left.Value + right.Value).ToString() + "MOD\n";
                helper.Type = helper.Value.GetType().ToString();
            }
            else
            {
                helper.Value = (left.Value + right.Value).ToString() + "DIV\n";
                helper.Type = helper.Value.GetType().ToString();
                sb.AppendLine("SUB");
            }
            return helper;
        }

        public override Helper VisitStatement([NotNull] PLC_Lab9_exprParser.StatementContext context)
        {
            return base.VisitStatement(context);
        }

        public override Helper VisitDeclaration([NotNull] PLC_Lab9_exprParser.DeclarationContext context)
        {
            return base.VisitDeclaration(context);
        }

        public override Helper VisitWrite([NotNull] PLC_Lab9_exprParser.WriteContext context)
        {
            Helper helper = new();
            foreach (var item in context.fullSTRING())
            {
                VisitFullSTRING(item);
            }
            return helper;
        }

        public override Helper VisitDatatype([NotNull] PLC_Lab9_exprParser.DatatypeContext context)
        {
            var data = context;
            return base.VisitDatatype(context);
        }

        public override Helper VisitFullSTRING([NotNull] PLC_Lab9_exprParser.FullSTRINGContext context)
        {
            Helper helper = new();
            var test = context.STRING();
            sb.AppendLine("PUSH S: " + test.ToString());

            var exp = context.expression(0);
            if(context.expression(0)!= null)
            {
                var res = Visit(context.expression()[0]);
                if (res.Type != null) { 
                     sb.AppendLine("PUSH " + res.Type + ": " + res.Value);
                }
                //sb.AppendLine("PUSH: " + sdfsd + " " + sdfsd.Value);
            }

            var nevim = context.expression();
            return helper;
        }

        

        public override Helper VisitProg([NotNull] PLC_Lab9_exprParser.ProgContext context)
        {
            Helper helper = new();
            
            foreach (var expr in context.input())
            {
                var code = Visit(expr);

            }
            helper.Value = sb.ToString();
            return helper;
        }
    }
}
