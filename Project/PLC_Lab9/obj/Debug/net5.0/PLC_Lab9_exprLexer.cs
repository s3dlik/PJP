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
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class PLC_Lab9_exprLexer : Lexer {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, T__23=24, 
		T__24=25, T__25=26, T__26=27, T__27=28, T__28=29, BOOL=30, INT=31, FLOAT=32, 
		STRING=33, NULL=34, IDENTIFIER=35, COMMENT=36, WS=37;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "T__20", "T__21", "T__22", "T__23", "T__24", 
		"T__25", "T__26", "T__27", "T__28", "BOOL", "INT", "FLOAT", "STRING", 
		"NULL", "IDENTIFIER", "COMMENT", "WS"
	};


	public PLC_Lab9_exprLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "';'", "','", "'='", "'write'", "'read'", "'if ('", "')'", "'else'", 
		"'while('", "'{'", "'}'", "'*'", "'/'", "'%'", "'+'", "'-'", "'.'", "'('", 
		"'!('", "'>'", "'<'", "'=='", "'!='", "'&&'", "'||'", "'int'", "'string'", 
		"'float'", "'bool'", null, null, null, null, "'null'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, "BOOL", "INT", "FLOAT", "STRING", 
		"NULL", "IDENTIFIER", "COMMENT", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "PLC_Lab9_expr.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\'\xFA\b\x1\x4\x2"+
		"\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4"+
		"\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10"+
		"\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15"+
		"\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B"+
		"\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 \t \x4!"+
		"\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x3\x2\x3\x2\x3\x3\x3\x3\x3\x4"+
		"\x3\x4\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x6\x3\x6\x3\x6\x3\x6\x3"+
		"\x6\x3\a\x3\a\x3\a\x3\a\x3\a\x3\b\x3\b\x3\t\x3\t\x3\t\x3\t\x3\t\x3\n\x3"+
		"\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\v\x3\v\x3\f\x3\f\x3\r\x3\r\x3\xE\x3\xE"+
		"\x3\xF\x3\xF\x3\x10\x3\x10\x3\x11\x3\x11\x3\x12\x3\x12\x3\x13\x3\x13\x3"+
		"\x14\x3\x14\x3\x14\x3\x15\x3\x15\x3\x16\x3\x16\x3\x17\x3\x17\x3\x17\x3"+
		"\x18\x3\x18\x3\x18\x3\x19\x3\x19\x3\x19\x3\x1A\x3\x1A\x3\x1A\x3\x1B\x3"+
		"\x1B\x3\x1B\x3\x1B\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3"+
		"\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3"+
		"\x1E\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x5"+
		"\x1F\xB6\n\x1F\x3 \x5 \xB9\n \x3 \a \xBC\n \f \xE \xBF\v \x3 \x6 \xC2"+
		"\n \r \xE \xC3\x3!\x5!\xC7\n!\x3!\x6!\xCA\n!\r!\xE!\xCB\x3!\x3!\x6!\xD0"+
		"\n!\r!\xE!\xD1\x3\"\x3\"\a\"\xD6\n\"\f\"\xE\"\xD9\v\"\x3\"\x3\"\x3#\x3"+
		"#\x3#\x3#\x3#\x3$\x3$\a$\xE4\n$\f$\xE$\xE7\v$\x3%\x3%\x3%\x3%\a%\xED\n"+
		"%\f%\xE%\xF0\v%\x3%\x3%\x3&\x6&\xF5\n&\r&\xE&\xF6\x3&\x3&\x2\x2\x2\'\x3"+
		"\x2\x3\x5\x2\x4\a\x2\x5\t\x2\x6\v\x2\a\r\x2\b\xF\x2\t\x11\x2\n\x13\x2"+
		"\v\x15\x2\f\x17\x2\r\x19\x2\xE\x1B\x2\xF\x1D\x2\x10\x1F\x2\x11!\x2\x12"+
		"#\x2\x13%\x2\x14\'\x2\x15)\x2\x16+\x2\x17-\x2\x18/\x2\x19\x31\x2\x1A\x33"+
		"\x2\x1B\x35\x2\x1C\x37\x2\x1D\x39\x2\x1E;\x2\x1F=\x2 ?\x2!\x41\x2\"\x43"+
		"\x2#\x45\x2$G\x2%I\x2&K\x2\'\x3\x2\t\x3\x2\x33;\x3\x2\x32;\x3\x2$$\x5"+
		"\x2\x43\\\x61\x61\x63|\x6\x2\x32;\x43\\\x61\x61\x63|\x4\x2\f\f\xF\xF\x5"+
		"\x2\v\f\xF\xF\"\"\x104\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2"+
		"\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2"+
		"\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17"+
		"\x3\x2\x2\x2\x2\x19\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2"+
		"\x2\x1F\x3\x2\x2\x2\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2"+
		"\'\x3\x2\x2\x2\x2)\x3\x2\x2\x2\x2+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2/\x3"+
		"\x2\x2\x2\x2\x31\x3\x2\x2\x2\x2\x33\x3\x2\x2\x2\x2\x35\x3\x2\x2\x2\x2"+
		"\x37\x3\x2\x2\x2\x2\x39\x3\x2\x2\x2\x2;\x3\x2\x2\x2\x2=\x3\x2\x2\x2\x2"+
		"?\x3\x2\x2\x2\x2\x41\x3\x2\x2\x2\x2\x43\x3\x2\x2\x2\x2\x45\x3\x2\x2\x2"+
		"\x2G\x3\x2\x2\x2\x2I\x3\x2\x2\x2\x2K\x3\x2\x2\x2\x3M\x3\x2\x2\x2\x5O\x3"+
		"\x2\x2\x2\aQ\x3\x2\x2\x2\tS\x3\x2\x2\x2\vY\x3\x2\x2\x2\r^\x3\x2\x2\x2"+
		"\xF\x63\x3\x2\x2\x2\x11\x65\x3\x2\x2\x2\x13j\x3\x2\x2\x2\x15q\x3\x2\x2"+
		"\x2\x17s\x3\x2\x2\x2\x19u\x3\x2\x2\x2\x1Bw\x3\x2\x2\x2\x1Dy\x3\x2\x2\x2"+
		"\x1F{\x3\x2\x2\x2!}\x3\x2\x2\x2#\x7F\x3\x2\x2\x2%\x81\x3\x2\x2\x2\'\x83"+
		"\x3\x2\x2\x2)\x86\x3\x2\x2\x2+\x88\x3\x2\x2\x2-\x8A\x3\x2\x2\x2/\x8D\x3"+
		"\x2\x2\x2\x31\x90\x3\x2\x2\x2\x33\x93\x3\x2\x2\x2\x35\x96\x3\x2\x2\x2"+
		"\x37\x9A\x3\x2\x2\x2\x39\xA1\x3\x2\x2\x2;\xA7\x3\x2\x2\x2=\xB5\x3\x2\x2"+
		"\x2?\xB8\x3\x2\x2\x2\x41\xC6\x3\x2\x2\x2\x43\xD3\x3\x2\x2\x2\x45\xDC\x3"+
		"\x2\x2\x2G\xE1\x3\x2\x2\x2I\xE8\x3\x2\x2\x2K\xF4\x3\x2\x2\x2MN\a=\x2\x2"+
		"N\x4\x3\x2\x2\x2OP\a.\x2\x2P\x6\x3\x2\x2\x2QR\a?\x2\x2R\b\x3\x2\x2\x2"+
		"ST\ay\x2\x2TU\at\x2\x2UV\ak\x2\x2VW\av\x2\x2WX\ag\x2\x2X\n\x3\x2\x2\x2"+
		"YZ\at\x2\x2Z[\ag\x2\x2[\\\a\x63\x2\x2\\]\a\x66\x2\x2]\f\x3\x2\x2\x2^_"+
		"\ak\x2\x2_`\ah\x2\x2`\x61\a\"\x2\x2\x61\x62\a*\x2\x2\x62\xE\x3\x2\x2\x2"+
		"\x63\x64\a+\x2\x2\x64\x10\x3\x2\x2\x2\x65\x66\ag\x2\x2\x66g\an\x2\x2g"+
		"h\au\x2\x2hi\ag\x2\x2i\x12\x3\x2\x2\x2jk\ay\x2\x2kl\aj\x2\x2lm\ak\x2\x2"+
		"mn\an\x2\x2no\ag\x2\x2op\a*\x2\x2p\x14\x3\x2\x2\x2qr\a}\x2\x2r\x16\x3"+
		"\x2\x2\x2st\a\x7F\x2\x2t\x18\x3\x2\x2\x2uv\a,\x2\x2v\x1A\x3\x2\x2\x2w"+
		"x\a\x31\x2\x2x\x1C\x3\x2\x2\x2yz\a\'\x2\x2z\x1E\x3\x2\x2\x2{|\a-\x2\x2"+
		"| \x3\x2\x2\x2}~\a/\x2\x2~\"\x3\x2\x2\x2\x7F\x80\a\x30\x2\x2\x80$\x3\x2"+
		"\x2\x2\x81\x82\a*\x2\x2\x82&\x3\x2\x2\x2\x83\x84\a#\x2\x2\x84\x85\a*\x2"+
		"\x2\x85(\x3\x2\x2\x2\x86\x87\a@\x2\x2\x87*\x3\x2\x2\x2\x88\x89\a>\x2\x2"+
		"\x89,\x3\x2\x2\x2\x8A\x8B\a?\x2\x2\x8B\x8C\a?\x2\x2\x8C.\x3\x2\x2\x2\x8D"+
		"\x8E\a#\x2\x2\x8E\x8F\a?\x2\x2\x8F\x30\x3\x2\x2\x2\x90\x91\a(\x2\x2\x91"+
		"\x92\a(\x2\x2\x92\x32\x3\x2\x2\x2\x93\x94\a~\x2\x2\x94\x95\a~\x2\x2\x95"+
		"\x34\x3\x2\x2\x2\x96\x97\ak\x2\x2\x97\x98\ap\x2\x2\x98\x99\av\x2\x2\x99"+
		"\x36\x3\x2\x2\x2\x9A\x9B\au\x2\x2\x9B\x9C\av\x2\x2\x9C\x9D\at\x2\x2\x9D"+
		"\x9E\ak\x2\x2\x9E\x9F\ap\x2\x2\x9F\xA0\ai\x2\x2\xA0\x38\x3\x2\x2\x2\xA1"+
		"\xA2\ah\x2\x2\xA2\xA3\an\x2\x2\xA3\xA4\aq\x2\x2\xA4\xA5\a\x63\x2\x2\xA5"+
		"\xA6\av\x2\x2\xA6:\x3\x2\x2\x2\xA7\xA8\a\x64\x2\x2\xA8\xA9\aq\x2\x2\xA9"+
		"\xAA\aq\x2\x2\xAA\xAB\an\x2\x2\xAB<\x3\x2\x2\x2\xAC\xAD\av\x2\x2\xAD\xAE"+
		"\at\x2\x2\xAE\xAF\aw\x2\x2\xAF\xB6\ag\x2\x2\xB0\xB1\ah\x2\x2\xB1\xB2\a"+
		"\x63\x2\x2\xB2\xB3\an\x2\x2\xB3\xB4\au\x2\x2\xB4\xB6\ag\x2\x2\xB5\xAC"+
		"\x3\x2\x2\x2\xB5\xB0\x3\x2\x2\x2\xB6>\x3\x2\x2\x2\xB7\xB9\a/\x2\x2\xB8"+
		"\xB7\x3\x2\x2\x2\xB8\xB9\x3\x2\x2\x2\xB9\xBD\x3\x2\x2\x2\xBA\xBC\t\x2"+
		"\x2\x2\xBB\xBA\x3\x2\x2\x2\xBC\xBF\x3\x2\x2\x2\xBD\xBB\x3\x2\x2\x2\xBD"+
		"\xBE\x3\x2\x2\x2\xBE\xC1\x3\x2\x2\x2\xBF\xBD\x3\x2\x2\x2\xC0\xC2\t\x3"+
		"\x2\x2\xC1\xC0\x3\x2\x2\x2\xC2\xC3\x3\x2\x2\x2\xC3\xC1\x3\x2\x2\x2\xC3"+
		"\xC4\x3\x2\x2\x2\xC4@\x3\x2\x2\x2\xC5\xC7\a/\x2\x2\xC6\xC5\x3\x2\x2\x2"+
		"\xC6\xC7\x3\x2\x2\x2\xC7\xC9\x3\x2\x2\x2\xC8\xCA\t\x3\x2\x2\xC9\xC8\x3"+
		"\x2\x2\x2\xCA\xCB\x3\x2\x2\x2\xCB\xC9\x3\x2\x2\x2\xCB\xCC\x3\x2\x2\x2"+
		"\xCC\xCD\x3\x2\x2\x2\xCD\xCF\a\x30\x2\x2\xCE\xD0\t\x3\x2\x2\xCF\xCE\x3"+
		"\x2\x2\x2\xD0\xD1\x3\x2\x2\x2\xD1\xCF\x3\x2\x2\x2\xD1\xD2\x3\x2\x2\x2"+
		"\xD2\x42\x3\x2\x2\x2\xD3\xD7\a$\x2\x2\xD4\xD6\n\x4\x2\x2\xD5\xD4\x3\x2"+
		"\x2\x2\xD6\xD9\x3\x2\x2\x2\xD7\xD5\x3\x2\x2\x2\xD7\xD8\x3\x2\x2\x2\xD8"+
		"\xDA\x3\x2\x2\x2\xD9\xD7\x3\x2\x2\x2\xDA\xDB\a$\x2\x2\xDB\x44\x3\x2\x2"+
		"\x2\xDC\xDD\ap\x2\x2\xDD\xDE\aw\x2\x2\xDE\xDF\an\x2\x2\xDF\xE0\an\x2\x2"+
		"\xE0\x46\x3\x2\x2\x2\xE1\xE5\t\x5\x2\x2\xE2\xE4\t\x6\x2\x2\xE3\xE2\x3"+
		"\x2\x2\x2\xE4\xE7\x3\x2\x2\x2\xE5\xE3\x3\x2\x2\x2\xE5\xE6\x3\x2\x2\x2"+
		"\xE6H\x3\x2\x2\x2\xE7\xE5\x3\x2\x2\x2\xE8\xE9\a\x31\x2\x2\xE9\xEA\a\x31"+
		"\x2\x2\xEA\xEE\x3\x2\x2\x2\xEB\xED\n\a\x2\x2\xEC\xEB\x3\x2\x2\x2\xED\xF0"+
		"\x3\x2\x2\x2\xEE\xEC\x3\x2\x2\x2\xEE\xEF\x3\x2\x2\x2\xEF\xF1\x3\x2\x2"+
		"\x2\xF0\xEE\x3\x2\x2\x2\xF1\xF2\b%\x2\x2\xF2J\x3\x2\x2\x2\xF3\xF5\t\b"+
		"\x2\x2\xF4\xF3\x3\x2\x2\x2\xF5\xF6\x3\x2\x2\x2\xF6\xF4\x3\x2\x2\x2\xF6"+
		"\xF7\x3\x2\x2\x2\xF7\xF8\x3\x2\x2\x2\xF8\xF9\b&\x2\x2\xF9L\x3\x2\x2\x2"+
		"\xE\x2\xB5\xB8\xBD\xC3\xC6\xCB\xD1\xD7\xE5\xEE\xF6\x3\b\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace PLC_Lab9
