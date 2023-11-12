namespace ConcreteLL.Expressions
{
    public class MulExp : AbsExpression
    {
        public AbsExpression LeftExp { get; set; }
        public AbsExpression RightExp { get; set; }
        public string Operator { get; set; }

        public MulExp(string op, AbsExpression leftExp, AbsExpression rightExp)
        {
            Operator = op;
            LeftExp = leftExp;
            RightExp = rightExp;
        }

        public override object Evaluate()
        {
            var leftResult = LeftExp.Evaluate();
            var rightResult = RightExp.Evaluate();

            if (string.Compare(Operator, "*") == 0)
            {
                double left = Convert.ToDouble(leftResult);
                double right = Convert.ToDouble(rightResult);

                return left * right;
                // return (long)leftResult * (long)rightResult;
            }
            if (string.Compare(Operator, "/") == 0)
            {
                double left = Convert.ToDouble(leftResult);
                double right = Convert.ToDouble(rightResult);

                return left / right;
            }
            if (string.Compare(Operator, "//") == 0)
                return Convert.ToInt64(leftResult) / Convert.ToInt64(rightResult);

            throw new Exception();
        }

        public override string ToString()
            => $"{LeftExp} {Operator} {RightExp}";
    }
}
