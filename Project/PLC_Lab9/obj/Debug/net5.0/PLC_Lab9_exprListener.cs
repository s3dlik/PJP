//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:\git\PJP\Project\PLC_Lab9\PLC_Lab9_expr.g4 by ANTLR 4.6.6

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
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="PLC_Lab9_exprParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IPLC_Lab9_exprListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>add</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdd([NotNull] PLC_Lab9_exprParser.AddContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>add</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdd([NotNull] PLC_Lab9_exprParser.AddContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>par</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPar([NotNull] PLC_Lab9_exprParser.ParContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>par</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPar([NotNull] PLC_Lab9_exprParser.ParContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>boolOper</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBoolOper([NotNull] PLC_Lab9_exprParser.BoolOperContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>boolOper</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBoolOper([NotNull] PLC_Lab9_exprParser.BoolOperContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>compare</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompare([NotNull] PLC_Lab9_exprParser.CompareContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>compare</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompare([NotNull] PLC_Lab9_exprParser.CompareContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>bool</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBool([NotNull] PLC_Lab9_exprParser.BoolContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>bool</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBool([NotNull] PLC_Lab9_exprParser.BoolContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>string</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterString([NotNull] PLC_Lab9_exprParser.StringContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>string</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitString([NotNull] PLC_Lab9_exprParser.StringContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>mul</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMul([NotNull] PLC_Lab9_exprParser.MulContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>mul</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMul([NotNull] PLC_Lab9_exprParser.MulContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>concat</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConcat([NotNull] PLC_Lab9_exprParser.ConcatContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>concat</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConcat([NotNull] PLC_Lab9_exprParser.ConcatContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>float</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFloat([NotNull] PLC_Lab9_exprParser.FloatContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>float</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFloat([NotNull] PLC_Lab9_exprParser.FloatContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>int</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInt([NotNull] PLC_Lab9_exprParser.IntContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>int</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInt([NotNull] PLC_Lab9_exprParser.IntContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>identifierExpr</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifierExpr([NotNull] PLC_Lab9_exprParser.IdentifierExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>identifierExpr</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifierExpr([NotNull] PLC_Lab9_exprParser.IdentifierExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PLC_Lab9_exprParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProg([NotNull] PLC_Lab9_exprParser.ProgContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PLC_Lab9_exprParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProg([NotNull] PLC_Lab9_exprParser.ProgContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PLC_Lab9_exprParser.input"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInput([NotNull] PLC_Lab9_exprParser.InputContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PLC_Lab9_exprParser.input"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInput([NotNull] PLC_Lab9_exprParser.InputContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PLC_Lab9_exprParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] PLC_Lab9_exprParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PLC_Lab9_exprParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] PLC_Lab9_exprParser.StatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PLC_Lab9_exprParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclaration([NotNull] PLC_Lab9_exprParser.DeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PLC_Lab9_exprParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclaration([NotNull] PLC_Lab9_exprParser.DeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PLC_Lab9_exprParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignment([NotNull] PLC_Lab9_exprParser.AssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PLC_Lab9_exprParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignment([NotNull] PLC_Lab9_exprParser.AssignmentContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PLC_Lab9_exprParser.write"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWrite([NotNull] PLC_Lab9_exprParser.WriteContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PLC_Lab9_exprParser.write"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWrite([NotNull] PLC_Lab9_exprParser.WriteContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PLC_Lab9_exprParser.fullSTRING"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFullSTRING([NotNull] PLC_Lab9_exprParser.FullSTRINGContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PLC_Lab9_exprParser.fullSTRING"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFullSTRING([NotNull] PLC_Lab9_exprParser.FullSTRINGContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PLC_Lab9_exprParser.read"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRead([NotNull] PLC_Lab9_exprParser.ReadContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PLC_Lab9_exprParser.read"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRead([NotNull] PLC_Lab9_exprParser.ReadContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PLC_Lab9_exprParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfStatement([NotNull] PLC_Lab9_exprParser.IfStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PLC_Lab9_exprParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfStatement([NotNull] PLC_Lab9_exprParser.IfStatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PLC_Lab9_exprParser.elseStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElseStatement([NotNull] PLC_Lab9_exprParser.ElseStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PLC_Lab9_exprParser.elseStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElseStatement([NotNull] PLC_Lab9_exprParser.ElseStatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PLC_Lab9_exprParser.whileStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhileStatement([NotNull] PLC_Lab9_exprParser.WhileStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PLC_Lab9_exprParser.whileStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhileStatement([NotNull] PLC_Lab9_exprParser.WhileStatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PLC_Lab9_exprParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlock([NotNull] PLC_Lab9_exprParser.BlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PLC_Lab9_exprParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlock([NotNull] PLC_Lab9_exprParser.BlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PLC_Lab9_exprParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] PLC_Lab9_exprParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PLC_Lab9_exprParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] PLC_Lab9_exprParser.ExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PLC_Lab9_exprParser.datatype"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDatatype([NotNull] PLC_Lab9_exprParser.DatatypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PLC_Lab9_exprParser.datatype"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDatatype([NotNull] PLC_Lab9_exprParser.DatatypeContext context);
}
} // namespace PLC_Lab9
