namespace ConcreteLL.Expressions
{
    public class FormatExp : AbsExpression
    {
        public AbsExpression Exp { get; set; }
        public LiteralExp Format { get; set; }

        public FormatExp(AbsExpression exp, LiteralExp format)
        {
            Exp = exp;
            Format = format;
        }

        public override object Evaluate()
        {
            var exp = Exp.Evaluate();
            var format = Format.Evaluate();

            if (exp is DateTime dt)
                return dt.ToString((string)format);

            return exp.ToString()!;
        }
    }
}
