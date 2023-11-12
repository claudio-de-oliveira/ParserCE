namespace ConcreteLL.Expressions
{
    public class NotExp : AbsExpression
    {
        public AbsExpression Exp { get; set; }

        public NotExp(AbsExpression exp)
        {
            Exp = exp;
        }
        public override object Evaluate()
            => !(bool)Exp.Evaluate();

        public override string ToString()
            => $"not {Exp}";
    }
}
