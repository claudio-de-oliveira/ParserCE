namespace ConcreteLL.Expressions
{
    public class RepeatExp : AbsExpression
    {
        public AbsExpression Exp { get; set; }

        public RepeatExp(AbsExpression exp)
        {
            Exp = exp;
        }

        public override object Evaluate()
            => Exp.Evaluate();

        public override string ToString()
            => $"repeat {Exp}";
    }

    public class UnrepeatedExp : AbsExpression
    {
        public AbsExpression Exp { get; set; }

        public UnrepeatedExp(AbsExpression exp)
        {
            Exp = exp;
        }

        public override object Evaluate()
            => Exp.Evaluate();

        public override string ToString()
            => $"unrepeated({Exp})";
    }
}
