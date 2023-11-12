namespace ConcreteLL.Expressions
{
    public class OrExp : AbsExpression
    {
        public AbsExpression LeftExp { get; set; }
        public AbsExpression RightExp { get; set; }

        public OrExp(AbsExpression leftExp, AbsExpression rightExp)
        {
            LeftExp = leftExp;
            RightExp = rightExp;
        }

        public override object Evaluate()
            => (bool)LeftExp.Evaluate() || (bool)RightExp.Evaluate();

        public override string ToString()
            => $"{LeftExp} or {RightExp}";
    }
}
