using Antlr4.Runtime;
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
        int globalCounter = 0;
        int label = 0;
        bool wasAssigned = false;
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

        public override Helper VisitBool([NotNull] PLC_Lab9_exprParser.BoolContext context)
        {
            Helper helper = new();
            helper.Value = bool.Parse(context.BOOL().GetText()).ToString();
            helper.Type = "B";
            return helper;
        }
        public override Helper VisitString([NotNull] PLC_Lab9_exprParser.StringContext context)
        {
            Helper helper = new();
            helper.Type = "S";
            helper.Value = context.STRING().ToString();
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
            if (left.Value != null && left.Type != null)
            {
                sb.AppendLine("push " + left.Type + " " + left.Value);
            }
            if (right.Value != null && right.Type != null)
            {
                sb.AppendLine("push " + right.Type + " " + right.Value);
            }

            if (context.op.Text.Equals("+"))
            {
                helper.Value = left.ToString() + right.ToString();
                sb.AppendLine("add");
            }
            else
            {
                helper.Value = left.ToString() + right.ToString();
                sb.AppendLine("sub");
            }
            return helper;
        }
        public override Helper VisitMul([NotNull] PLC_Lab9_exprParser.MulContext context)
        {
            Helper helper = new();
            var left = Visit(context.expression()[0]);
            var right = Visit(context.expression()[1]);

            if (left.Value != null && left.Type != null)
            {
                sb.AppendLine("push " + left.Type  + " " + left.Value);
            }
            if (right.Value != null && right.Type != null)
            {
                sb.AppendLine("push " + right.Type + " " +  right.Value);
            }
            if(left.Type != null && right.Type != null)
            {
                if ((left.Type == "F" && right.Type == "I") || (left.Type == "I" && right.Type == "F")) {
                    sb.AppendLine("itof");
                }
            }

            if (context.op.Text.Equals("*"))
            {
                helper.Value = left.ToString() + right.ToString();
                sb.AppendLine("mul");
            }
            else if (context.op.Text.Equals("%")){
                helper.Value = left.ToString() + right.ToString();
                sb.AppendLine("mod");
            }
            else
            {
                helper.Value = left.ToString() + right.ToString();
                sb.AppendLine("div");
            }
            return helper;
        }

        public override Helper VisitStatement([NotNull] PLC_Lab9_exprParser.StatementContext context)
        {
            Helper helper = new();

            if (context.declaration() != null)
            {
                return VisitDeclaration(context.declaration());
            }
            else if (context.assignment() != null){
                VisitAssignment(context.assignment());
                sb.AppendLine("pop");
                wasAssigned = false;
            }
            return helper;
        }

        public override Helper VisitDeclaration([NotNull] PLC_Lab9_exprParser.DeclarationContext context)
        {
            Helper helper = new();
            var test = context.IDENTIFIER().ElementAt(0).ToString();
            var test1 = context.IDENTIFIER();
            var test2 = context.GetText();
            var test4 = context.children[0].GetText();
            //var nevim = test4.children[0];
            var test3 = context.children[0];

            if(context.children[0]!= null)
            {
                string type = context.children[0].GetText().ToString();
                foreach (var item in context.IDENTIFIER())
                {
                    if (item.ToString() == "," || item.ToString() == type)
                        continue;
                    switch (type)
                    {
                        case "string":
                            helper.Type = "S";
                            helper.Value = "\"\"";
                            break;
                        case "float":
                            helper.Type = "F";
                            helper.Value = "0.0";
                            break;
                        case "int":
                            helper.Type = "I";
                            helper.Value = "0";
                            break;
                        case "bool":
                            helper.Type = "B";
                            helper.Value = "true";
                            break;
                    }
                    sb.AppendLine($"push {helper.Type} {helper.Value}");
                    sb.AppendLine($"save {item}");
                    singleDicts.returnInstance().stackValues[item.ToString()] = helper.Type;
                }
            }
            return helper;
            
        }
        public override Helper VisitAssignment([NotNull] PLC_Lab9_exprParser.AssignmentContext context)
        {
            Helper helper = new();
            bool itof = false;
            bool negative = false;
            if(context.expression()!= null)
            {
                return Visit(context.expression());
            }

            var value = VisitAssignment(context.assignment()) ;


            if (!wasAssigned)
            {
                if(value.Type == "I" && value.Value != null)
                {
                    int res;
                    int.TryParse(value.Value, out res);
                    if(res < 0)
                    {
                        res *= -1;
                        value.Value = res.ToString(); ;
                        negative = true;
                    }
                }

                if(value.Type == "I" && singleDicts.returnInstance().stackValues[context.GetChild(0).ToString()] == "F")
                {
                    itof = true;
                }

            }

            if (value.Value != null && value.Type != null)
            {
                sb.AppendLine($"push {value.Type} {value.Value}");
            }

            if (negative)
                sb.AppendLine("uminus");

            if (itof)
                sb.AppendLine("itof");

            sb.AppendLine($"save {context.children[0]}");
            sb.AppendLine($"load {context.children[0]}");
            return helper;
        }
        public override Helper VisitWrite([NotNull] PLC_Lab9_exprParser.WriteContext context)
        {
            Helper helper = new();
            globalCounter = 0;
            foreach (var item in context.fullSTRING())
            {
                globalCounter++;
                VisitFullSTRING(item);
            }
            
            sb.AppendLine("print " + globalCounter);
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
            sb.AppendLine("push S " + test.ToString());
            
            var exp = context.expression(0);
            if(context.expression(0)!= null)
            {
                var res = Visit(context.expression()[0]);
                if ((res.Type == "F") || (res.Type == "S") || (res.Type == "I") || (res.Type == "B")) { 
                     sb.AppendLine("push " + res.Type + " " + res.Value);
                }
                globalCounter++;
                //sb.AppendLine("PUSH: " + sdfsd + " " + sdfsd.Value);
            }

            return helper;
        }

        public override Helper VisitRead([NotNull] PLC_Lab9_exprParser.ReadContext context)
        {
            Helper helper = new();
            foreach (var item in context.IDENTIFIER())
            {
                if (singleDicts.returnInstance().stackValues.ContainsKey(item.ToString()))
                {
                    var tmp = singleDicts.returnInstance().stackValues[item.ToString()];
                    sb.AppendLine($"read {tmp}");
                    sb.AppendLine($"save {item}");
                }
            }
            return helper;
        }

        public override Helper VisitIdentifierExpr([NotNull] PLC_Lab9_exprParser.IdentifierExprContext context)
        {
            Helper helper = new();

            sb.AppendLine($"load {context.IDENTIFIER().GetText()}");

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

        public override Helper VisitConcat([NotNull] PLC_Lab9_exprParser.ConcatContext context)
        {
            Helper helper = new();
            var text = context.GetText().ToString();
            string [] textArr= text.Split(".");

            sb.AppendLine($"push S {textArr[0]}");
            sb.AppendLine($"push S {textArr[1]}");
            sb.AppendLine("concat");
            return helper;
        }

        public override Helper VisitCompare([NotNull] PLC_Lab9_exprParser.CompareContext context)
        {
            Helper helper = new();
            var leftSide = Visit(context.expression()[0]);
            var rightSide = Visit(context.expression()[1]);
            //var test = context.compare.Text.ToString();

            if(leftSide.Type != null && leftSide.Value != null)
            {
                sb.AppendLine($"push {leftSide.Type} {leftSide.Value}");
                if((leftSide.Type == "I" && rightSide.Type == "F"))
                {
                    sb.AppendLine("itof");
                }
                
            }

            if (rightSide.Type != null && rightSide.Value != null)
            {
                sb.AppendLine($"push {rightSide.Type} {rightSide.Value}");
                if ((leftSide.Type == "F" && rightSide.Type == "I"))
                {
                    sb.AppendLine("itof");
                }
            }

            switch (context.compare.Text.ToString()) { 
                case "<":
                    
                    sb.AppendLine("lt");
                    break;
                case ">":
                    
                    sb.AppendLine("gt");
                    break;
                case "==":
                    
                    sb.AppendLine("eq");
                    break;
                case "!=":
                    
                    sb.AppendLine("eq");
                    sb.AppendLine("not");
                    break;
            }
            return helper;
        }

        public override Helper VisitBoolOper([NotNull] PLC_Lab9_exprParser.BoolOperContext context)
        {
            Helper helper = new();
            var leftSide = Visit(context.expression()[0]);
            var rightSide = Visit(context.expression()[1]);
            //var test = context.boolOper.Text.ToString();
            if (leftSide.Value != null && leftSide.Type != null)
            {
                sb.AppendLine($"push {leftSide.Type} {leftSide.Value}");
            }

            if (rightSide.Value != null && rightSide.Type != null)
            {
                sb.AppendLine($"push {rightSide.Type} {rightSide.Value}");
            }
            switch (context.boolOper.Text.ToString())
            {
                case "&&":
                    helper.Value = leftSide.ToString() + rightSide.ToString() + "AND\n";
                    sb.AppendLine("and");
                    break;
                case "||":
                    helper.Value = leftSide.ToString() + rightSide.ToString() + "OR\n";
                    sb.AppendLine("or");
                    break;
            }
            
            return helper;
        }

        public override Helper VisitNot([NotNull] PLC_Lab9_exprParser.NotContext context)
        {
            Helper helper = new();
            Visit(context.expression());
            sb.AppendLine("not");
            return helper;
        }

        public override Helper VisitIfStatement([NotNull] PLC_Lab9_exprParser.IfStatementContext context)
        {
            Helper helper = new();
            var condition = Visit(context.expression());
            bool first = true;
            if(condition.Type != null)
            {
                sb.AppendLine($"push {condition.Type} {condition.Value}");
            }
            sb.AppendLine($"fjmp {label}");

            VisitBlock(context.block());

            if(context.elseStatement() != null)
            {
                sb.AppendLine($"jmp {label+1}");
            }

            sb.AppendLine($"label {label}");

            if (context.elseStatement() != null)
            {
                foreach (var item in context.elseStatement())
                {
                    if (!first)
                        sb.AppendLine($"label {++label}");
                    else
                        first = false;
                    VisitElseStatement(item);
                }
                sb.AppendLine($"label {++label}");
            }
            label++;
            return helper;
        }

        public override Helper VisitElseStatement([NotNull] PLC_Lab9_exprParser.ElseStatementContext context)
        {
            Helper helper = new();

            if(context.block() != null)
            {
                return VisitBlock(context.block());
            }
            return helper;
        }

        public override Helper VisitWhileStatement([NotNull] PLC_Lab9_exprParser.WhileStatementContext context)
        {
            Helper helper = new();

            sb.AppendLine($"label {label}");

            Visit(context.expression());
            sb.AppendLine($"fjmp {label+1}");

            VisitBlock(context.block());

            sb.AppendLine($"jmp {label}");
            sb.AppendLine($"label {++label}");
            label++;
            return helper;
        }
    }
}
