//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:\VYSOKA\6semestr\PJP\project\PLC_Lab9\PLC_Lab9_expr.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace PLC_Lab9 {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="PLC_Lab9_exprParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IPLC_Lab9_exprVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>add</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAdd([NotNull] PLC_Lab9_exprParser.AddContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>str</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStr([NotNull] PLC_Lab9_exprParser.StrContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>par</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPar([NotNull] PLC_Lab9_exprParser.ParContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>boolOper</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolOper([NotNull] PLC_Lab9_exprParser.BoolOperContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>compare</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompare([NotNull] PLC_Lab9_exprParser.CompareContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>bool</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBool([NotNull] PLC_Lab9_exprParser.BoolContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>mul</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMul([NotNull] PLC_Lab9_exprParser.MulContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>float</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFloat([NotNull] PLC_Lab9_exprParser.FloatContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>int</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInt([NotNull] PLC_Lab9_exprParser.IntContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>constantExpr</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstantExpr([NotNull] PLC_Lab9_exprParser.ConstantExprContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>identifierExpr</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifierExpr([NotNull] PLC_Lab9_exprParser.IdentifierExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PLC_Lab9_exprParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProg([NotNull] PLC_Lab9_exprParser.ProgContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PLC_Lab9_exprParser.input"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInput([NotNull] PLC_Lab9_exprParser.InputContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PLC_Lab9_exprParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatement([NotNull] PLC_Lab9_exprParser.StatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PLC_Lab9_exprParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDeclaration([NotNull] PLC_Lab9_exprParser.DeclarationContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PLC_Lab9_exprParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignment([NotNull] PLC_Lab9_exprParser.AssignmentContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PLC_Lab9_exprParser.write"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWrite([NotNull] PLC_Lab9_exprParser.WriteContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PLC_Lab9_exprParser.fullSTRING"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFullSTRING([NotNull] PLC_Lab9_exprParser.FullSTRINGContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PLC_Lab9_exprParser.read"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRead([NotNull] PLC_Lab9_exprParser.ReadContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PLC_Lab9_exprParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfStatement([NotNull] PLC_Lab9_exprParser.IfStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PLC_Lab9_exprParser.elseStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElseStatement([NotNull] PLC_Lab9_exprParser.ElseStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PLC_Lab9_exprParser.whileStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhileStatement([NotNull] PLC_Lab9_exprParser.WhileStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PLC_Lab9_exprParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlock([NotNull] PLC_Lab9_exprParser.BlockContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PLC_Lab9_exprParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpression([NotNull] PLC_Lab9_exprParser.ExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PLC_Lab9_exprParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstant([NotNull] PLC_Lab9_exprParser.ConstantContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PLC_Lab9_exprParser.datatype"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDatatype([NotNull] PLC_Lab9_exprParser.DatatypeContext context);
}
} // namespace PLC_Lab9
