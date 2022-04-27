grammar PLC_Lab9_expr;

/** The start rule; begin parsing here. */
prog: input*;

input: statement ';'
    | ifStatement
    | whileStatement
    | write ';'
    | read ';'
    | COMMENT
    | ';'
    ;

statement : declaration | assignment | expression ;

declaration: datatype IDENTIFIER (',' IDENTIFIER)* ;

assignment: expression
    | IDENTIFIER '=' assignment
    ;

write : 'write' (fullSTRING)+ ;

fullSTRING : STRING(',' expression ',')*(',' expression)* ;

read: 'read' IDENTIFIER (',' IDENTIFIER)* ;

ifStatement : 'if' ('expression') block ('else' elseStatement)* ;

elseStatement: block
    | ifStatement
    ;

whileStatement: 'while('expression')' block ;

block : input
    | '{'input+'}' ; 

expression: INT                            # int
    | FLOAT                                 # float
    | BOOL                                  # bool
    | STRING                                # string
    | IDENTIFIER                #identifierExpr
    | expression op=('*'|'/'|'%') expression    # mul
    | expression op=('+'|'-') expression    # add
    | STRING ('.') STRING                  #concat
    | '(' expression ')'        # par
    | expression compare=('>' | '<' | '==' | '!=') expression #compare
    | expression boolOper=('||' | '&&') expression #boolOper
    ;

datatype: 'int' | 'string' | 'float' | 'bool' ;


BOOL : 'true' | 'false' ;   // bool values
INT : ('-')?[1-9]*[0-9]+ ;          // match integers
FLOAT : ('-')?[0-9]+ '.' [0-9]+ ;   // match floats
STRING : ('"' ~'"'* '"') ;
NULL: 'null';
IDENTIFIER: [a-zA-Z_][a-zA-Z0-9_]*;
COMMENT : '//' ~( '\r' | '\n' )* -> skip;
WS : [ \t\r\n]+ -> skip ;   // toss out whitespace