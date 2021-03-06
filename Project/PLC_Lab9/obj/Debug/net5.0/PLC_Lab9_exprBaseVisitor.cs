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
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IPLC_Lab9_exprVisitor{Result}"/>,
/// which can be extended to create a visitor which only needs to handle a subset
/// of the available methods.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class PLC_Lab9_exprBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, IPLC_Lab9_exprVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>add</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAdd([NotNull] PLC_Lab9_exprParser.AddContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>par</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPar([NotNull] PLC_Lab9_exprParser.ParContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>boolOper</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBoolOper([NotNull] PLC_Lab9_exprParser.BoolOperContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>not</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNot([NotNull] PLC_Lab9_exprParser.NotContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>compare</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCompare([NotNull] PLC_Lab9_exprParser.CompareContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>bool</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBool([NotNull] PLC_Lab9_exprParser.BoolContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>string</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitString([NotNull] PLC_Lab9_exprParser.StringContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>mul</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMul([NotNull] PLC_Lab9_exprParser.MulContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>concat</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitConcat([NotNull] PLC_Lab9_exprParser.ConcatContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>float</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFloat([NotNull] PLC_Lab9_exprParser.FloatContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>int</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitInt([NotNull] PLC_Lab9_exprParser.IntContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>identifierExpr</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIdentifierExpr([NotNull] PLC_Lab9_exprParser.IdentifierExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PLC_Lab9_exprParser.prog"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitProg([NotNull] PLC_Lab9_exprParser.ProgContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PLC_Lab9_exprParser.input"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitInput([NotNull] PLC_Lab9_exprParser.InputContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PLC_Lab9_exprParser.statement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitStatement([NotNull] PLC_Lab9_exprParser.StatementContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PLC_Lab9_exprParser.declaration"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDeclaration([NotNull] PLC_Lab9_exprParser.DeclarationContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PLC_Lab9_exprParser.assignment"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAssignment([NotNull] PLC_Lab9_exprParser.AssignmentContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PLC_Lab9_exprParser.write"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitWrite([NotNull] PLC_Lab9_exprParser.WriteContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PLC_Lab9_exprParser.fullSTRING"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFullSTRING([NotNull] PLC_Lab9_exprParser.FullSTRINGContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PLC_Lab9_exprParser.read"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitRead([NotNull] PLC_Lab9_exprParser.ReadContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PLC_Lab9_exprParser.ifStatement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIfStatement([NotNull] PLC_Lab9_exprParser.IfStatementContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PLC_Lab9_exprParser.elseStatement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitElseStatement([NotNull] PLC_Lab9_exprParser.ElseStatementContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PLC_Lab9_exprParser.whileStatement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitWhileStatement([NotNull] PLC_Lab9_exprParser.WhileStatementContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PLC_Lab9_exprParser.block"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBlock([NotNull] PLC_Lab9_exprParser.BlockContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PLC_Lab9_exprParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExpression([NotNull] PLC_Lab9_exprParser.ExpressionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PLC_Lab9_exprParser.datatype"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDatatype([NotNull] PLC_Lab9_exprParser.DatatypeContext context) { return VisitChildren(context); }
}
} // namespace PLC_Lab9
