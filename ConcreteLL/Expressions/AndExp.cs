namespace ConcreteLL.Expressions
{
    public class AndExp : AbsExpression
    {
        public AbsExpression LeftExp { get; set; }
        public AbsExpression RightExp { get; set; }

        public AndExp(AbsExpression leftExp, AbsExpression rightExp)
        {
            LeftExp = leftExp;
            RightExp = rightExp;
        }

        public override object Evaluate()
            => (bool)LeftExp.Evaluate() && (bool)RightExp.Evaluate();

        public override string ToString()
            => $"{LeftExp} and {RightExp}";
    }
}
