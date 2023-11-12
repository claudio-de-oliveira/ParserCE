namespace ConcreteLL.Expressions
{
    public class IfExp : AbsExpression
    {
        public AbsExpression TestExp { get; set; }
        public AbsExpression ThenExp { get; set; }
        public AbsExpression ElseExp { get; set; }

        public IfExp(AbsExpression testExp, AbsExpression thenExp, AbsExpression elseExp)
        {
            TestExp = testExp;
            ThenExp = thenExp;
            ElseExp = elseExp;
        }

        public override object Evaluate()
        {
            var testResult = (bool)TestExp.Evaluate();
            return (testResult) ? ThenExp.Evaluate() : ElseExp.Evaluate();
        }

        public override string ToString()
            => $"if ({TestExp}) then {ThenExp} else {ElseExp}";
    }
}
