﻿using AbstractLL;

namespace ConcreteLL
{
    internal class Tag : AbstractTAG
    {
        protected Tag(int Tag, string name, int nattribs = 0)
            : base(Tag, name, nattribs)
        { /* Nothing more todo */ }

        #region T E R M I N A I S
        public static readonly Tag
            RELOP = new(TERMINAL + 0, "relop"),
            ADDOP = new(TERMINAL + 1, "addop"),
            MULOP = new(TERMINAL + 2, "mulop"),
            LPAR = new(TERMINAL + 3, "("),
            RPAR = new(TERMINAL + 4, ")"),
            COMMA = new(TERMINAL + 5, ","),
            VARIABLE = new(TERMINAL + 6, "variable"),
            INTEGER = new(TERMINAL + 7, "integer"),
            DECIMAL = new(TERMINAL + 8, "decimal"),
            LITERAL = new(TERMINAL + 9, "literal"),
            FUNCTION = new(TERMINAL + 10, "fx"),
            IF = new(TERMINAL + 11, "if"),
            THEN = new(TERMINAL + 12, "then"),
            ELSE = new(TERMINAL + 13, "else"),
            TRUE = new(TERMINAL + 14, "true"),
            FALSE = new(TERMINAL + 15, "false"),
            IS = new(TERMINAL + 16, "is"),
            ISATLEAST = new(TERMINAL + 17, "isatleast"),
            ISATMOST = new(TERMINAL + 18, "isatmost"),
            ISLESSTHAN = new(TERMINAL + 19, "islessthan"),
            ISMORETHAN = new(TERMINAL + 20, "ismorethan"),
            ISNOT = new(TERMINAL + 21, "isnot"),
            AND = new(TERMINAL + 22, "and"),
            OR = new(TERMINAL + 23, "or"),
            XOR = new(TERMINAL + 24, "xor"),
            NOT = new(TERMINAL + 25, "not"),
            SELECT = new(TERMINAL + 26, "select"),
            FROM = new(TERMINAL + 27, "from"),
            FORMAT = new(TERMINAL + 28, "format"),
            ENDMARK = new(TERMINAL + 29, "#"),
            NumberOfTerminals = new(NONTERMINAL | 30, ""),

            // ABS, ACOS, ASCENDING, ASIN, ATAN, 
            ALT = new(TERMINAL + 100, "alt"),
            ANSWERED = new(TERMINAL + 102, "answered"),
            AS = new(TERMINAL + 103, "as"),
            ATTACH = new(TERMINAL + 104, "attach"),
            ATTRIBUTE = new(TERMINAL + 105, "attribute"),
            AUTHORNOTE = new(TERMINAL + 106, "authornote"),
            BY = new(TERMINAL + 107, "by"),
            CAPITALS = new(TERMINAL + 108, "capitals"),
            CELL = new(TERMINAL + 109, "cell"),
            CLOAKED = new(TERMINAL + 110, "cloaked"),
            COLLECT = new(TERMINAL + 111, "collect"),
            COLLECTVALUES = new(TERMINAL + 112, "collectvalues"),
            COMMITTED = new(TERMINAL + 113, "committed"),
            DATATYPE = new(TERMINAL + 114, "datatype"),
            DEFERRED = new(TERMINAL + 115, "deferred"),
            DEFINITE = new(TERMINAL + 116, "definite"),
            DOCTITLE = new(TERMINAL + 117, "doctitle"),
            DOCUMENT = new(TERMINAL + 118, "document"),
            EVERY = new(TERMINAL + 120, "every"),
            EXISTS = new(TERMINAL + 121, "exists"),
            EXPORT = new(TERMINAL + 122, "export"),
            EXPRESSIONTEXT = new(TERMINAL + 123, "expressiontext"),
            FOREACH = new(TERMINAL + 125, "foreach"),
            HYPERLINK = new(TERMINAL + 128, "hyperlink"),
            IFKNOWNELSE = new(TERMINAL + 130, "ifknownelse"),
            INCLUDE = new(TERMINAL + 131, "include"),
            KNOWN = new(TERMINAL + 138, "known"),
            KNOWNTRUE = new(TERMINAL + 139, "knowntrue"),
            LABEL = new(TERMINAL + 140, "label"),
            LIST = new(TERMINAL + 141, "list"),
            LOWER = new(TERMINAL + 142, "lower"),
            MARK = new(TERMINAL + 143, "mark"),
            NONMUTUALAND = new(TERMINAL + 144, "nonmutualand"),
            NONMUTUALOR = new(TERMINAL + 145, "nonmutualor"),
            NONREPEATED = new(TERMINAL + 146, "nonrepeated"),
            NOTE = new(TERMINAL + 148, "note"),
            NOW = new(TERMINAL + 149, "now"),
            OCCURRENCE = new(TERMINAL + 150, "occurrence"),
            ONLYONINPUT = new(TERMINAL + 151, "onlyoninput"),
            ONLYONOUTPUT = new(TERMINAL + 152, "onlyonoutput"),
            ONLYOTHER = new(TERMINAL + 153, "onlyother"),
            OTHER = new(TERMINAL + 155, "other"),
            OTHERSELECTIONS = new(TERMINAL + 156, "otherselections"),
            PICTURE = new(TERMINAL + 157, "picture"),
            PREFIX = new(TERMINAL + 158, "prefix"),
            PRESCRIBEDSELECTIONS = new(TERMINAL + 159, "prescribedselections"),
            PROPER = new(TERMINAL + 160, "proper"),
            PUNCTUATION = new(TERMINAL + 161, "punctuation"),
            REF = new(TERMINAL + 162, "ref"),
            REFERENCE = new(TERMINAL + 163, "reference"),
            RELEVANCE = new(TERMINAL + 164, "relevance"),
            REPEAT = new(TERMINAL + 165, "repeat"),
            REPEATCONTEXT = new(TERMINAL + 166, "repeatcontext"),
            REPEATCOUNTER = new(TERMINAL + 167, "repeatcounter"),
            SELECTIONOPTIONS = new(TERMINAL + 169, "selectionoptions"),
            SENSITIVE = new(TERMINAL + 170, "sensitive"),
            SIMPLIFY = new(TERMINAL + 171, "simplify"),
            SPANRELEVANCE = new(TERMINAL + 172, "spanrelevance"),
            STYLE = new(TERMINAL + 173, "style"),
            SURE = new(TERMINAL + 174, "sure"),
            TEMPLATE = new(TERMINAL + 175, "template"),
            TEMPLATERELEVANCE = new(TERMINAL + 176, "templaterelevance"),
            TEXTFILE = new(TERMINAL + 177, "textfile"),
            TO = new(TERMINAL + 179, "to"),
            TODAY = new(TERMINAL + 180, "today"),
            UNREPEATED = new(TERMINAL + 182, "unrepeated"),
            UPPER = new(TERMINAL + 183, "upper"),
            USING = new(TERMINAL + 184, "using"),
            VALUE = new(TERMINAL + 185, "value"),
            WHERE = new(TERMINAL + 186, "where"),
            WITH = new(TERMINAL + 187, "with"),

            UNKNOW = new(TERMINAL + 998, "unknow"),
            EMPTY = new(TERMINAL | 999, "empty");
        #endregion

        #region A Ç Õ E S   S E M Â N T I C A S
        public static readonly Tag
            _If = new(SEMANTIC | 0, "@If", 3),
            _Or = new(SEMANTIC | 1, "@Or", 2),
            _And = new(SEMANTIC | 2, "@And", 2),
            _Not = new(SEMANTIC | 3, "@Not", 1),
            _AddOp = new(SEMANTIC | 4, "@AddOp", 0),
            _Rel = new(SEMANTIC | 5, "@Rel", 3),
            _Add = new(SEMANTIC | 6, "@Add", 3),
            _Mul = new(SEMANTIC | 7, "@Mul", 3),
            _Variable = new(SEMANTIC | 8, "@Variable", 1),
            _Integer = new(SEMANTIC | 9, "@Integer", 0),
            _Decimal = new(SEMANTIC | 10, "@Decimal", 0),
            _Literal = new(SEMANTIC | 11, "@Literal", 0),
            _Skip = new(SEMANTIC | 12, "@Skip", 1),
            _Call = new(SEMANTIC | 13, "@Call", 2),
            _EmptyList = new(SEMANTIC | 14, "@EmptyList", 2),
            _CreateList = new(SEMANTIC | 15, "@CreateList", 1),
            _InsertList = new(SEMANTIC | 16, "@InsertList", 2),
            _True = new(SEMANTIC | 17, "@True", 0),
            _False = new(SEMANTIC | 18, "@False", 0),
            _Parameter = new(SEMANTIC | 19, "@Parameter", 1),
            _Function = new(SEMANTIC | 20, "@Function", 0),
            _MulOp = new(SEMANTIC | 21, "@MulOp", 0),
            _RelOp = new(SEMANTIC | 22, "@RelOp", 0),
            _Select = new(SEMANTIC | 23, "@Select", 1),
            _NoParameter = new(SEMANTIC | 24, "@NoParameter", 0),
            _FirstItem = new(SEMANTIC | 25, "@FirstItem", 1),
            _InsertItem = new(SEMANTIC | 26, "@InsertItem", 2),
            _SelectItem = new(SEMANTIC | 27, "@SelectItem", 2),
            _Then = new(SEMANTIC | 28, "@Then", 1),
            _Else = new(SEMANTIC | 29, "@Else", 1),
            _Test = new(SEMANTIC | 30, "@Test", 1),
            _Format = new(SEMANTIC + 31, "@Format", 2),

            _Echo = new(SEMANTIC | 999, "@Echo", 1),
            _Done = new(SEMANTIC | 1000, "@Done", 1)
            ;
        #endregion

        #region N Ã O   T E R M I N A I S
        public static readonly Tag
            Start = new(NONTERMINAL | 0, "Start"),
            Exp = new(NONTERMINAL | 1, "Exp"),
            Disj = new(NONTERMINAL | 2, "Disj"),
            Disj_ = new(NONTERMINAL | 3, "Disj'", 1),
            Conj = new(NONTERMINAL | 4, "Conj"),
            Conj_ = new(NONTERMINAL | 5, "Conj'", 1),
            Neg = new(NONTERMINAL | 6, "Neg"),
            Rel = new(NONTERMINAL | 7, "Rel"),
            Rel_ = new(NONTERMINAL | 8, "Rel'", 1),
            Add = new(NONTERMINAL | 9, "Add"),
            Add_ = new(NONTERMINAL | 10, "Add'", 1),
            Multiply = new(NONTERMINAL | 11, "Multiply"),
            Multiply_ = new(NONTERMINAL | 12, "Multiply'", 1),
            Factor = new(NONTERMINAL | 13, "Factor"),
            List = new(NONTERMINAL | 15, "List"),
            List_ = new(NONTERMINAL | 16, "List'", 1),
            Function_ = new(NONTERMINAL | 17, "Function'", 1),
            Selections = new(NONTERMINAL | 18, "Selections"),
            Selections_ = new(NONTERMINAL | 19, "Selections'", 1),
            SelItem = new(NONTERMINAL | 20, "SelItem"),
            SelItem_ = new(NONTERMINAL | 21, "SelItem'", 1),
            FmtExp = new(NONTERMINAL + 22, "FmtExp"),
            FmtExp_ = new(NONTERMINAL + 23, "FmtExp'", 1),
            NumberOfVariables = new(NONTERMINAL | 24, "")
            ;
        #endregion

        public override AbstractTAG Clone()
        {
            if (_inherited.Length > 0)
                return new Tag(_tag, _name, _inherited.Length);
            return this;
        }
    }
}
